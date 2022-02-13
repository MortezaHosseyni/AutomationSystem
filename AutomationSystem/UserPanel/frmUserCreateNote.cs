using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModelLayer.Models;
using AutomationSystem.Moduls;
using System.Transactions;

namespace AutomationSystem.UserPanel
{
    public partial class frmUserCreateNote : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities(PublicVariable.mainConnectionString);
        public frmUserCreateNote()
        {
            InitializeComponent();
        }

        private void frmUserCreateNote_Load(object sender, EventArgs e)
        {
            this.Left = 10;
            this.Top = 160;

            val_NoteCreatedDate.Text = PublicVariable.todayDate;
            ShowAllowedUsers(searchCondition());
        }

        private void ShowAllowedUsers(string searchAllowedUser)
        {
            var query = db.Database.SqlQuery<Vw_AsignmentJobs>($"SELECT * FROM Vw_AsignmentJobs WHERE [AsignStatus] = 1 AND [JobsDetermineLevel] >= {PublicVariable.global_JobsDetermineLevel} - 1 {searchAllowedUser} EXCEPT (SELECT * FROM Vw_AsignmentJobs WHERE [AsignUserID] = {PublicVariable.global_UserID})");
            var result = query.ToList();

            if (result.Count != 0)
            {
                dgv_Recivers.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_Recivers.Rows[i].Cells["col_JobUserID"].Value = result[i].AsignJobID;
                    dgv_Recivers.Rows[i].Cells["col_UserID"].Value = result[i].AsignUserID;

                    dgv_Recivers.Rows[i].Cells["col_FullName"].Value = result[i].UserFullName;
                    dgv_Recivers.Rows[i].Cells["col_JobName"].Value = result[i].JobsName;
                }
            }
            else
            {
                dgv_Recivers.Rows.Clear();
            }
        }

        private string searchCondition()
        {
            string searchString = "";

            //Subject Search
            if (txt_SearchFullName.Text != "")
            {
                searchString += $" AND UserFullName LIKE '%{txt_SearchFullName.Text.Trim()}%'";
            }

            return searchString;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ShowAllowedUsers(searchCondition());
        }

        private void btn_SendNote_Click(object sender, EventArgs e)
        {
            //Check Subject & Context to not empty
            if (txt_NoteSubject.Text == "" || txt_NoteContext.Text == "")
            {
                MessageBox.Show("اطلاعات يادداشت ناقص است، لطفا فيلدهاي خالي را پر كنيد","ارسال يادداشت");
                txt_NoteSubject.Focus();
                return;
            }

            //Check UsersTable to not selected user
            int counter = 0;
            foreach (DataGridViewRow row in dgv_Recivers.Rows)
            {
                if (Convert.ToBoolean(row.Cells["col_SelectUser"].Value) == true)
                {
                    counter += 1;
                }
            }
            if (counter == 0)
            {
                MessageBox.Show("لطفا كاربري را جهت ارسال يادداشت انتخاب كنيد","ارسال يادداشت");
                return;
            }

            using (TransactionScope ts = new TransactionScope())
            {
                try
                {
                    //CreateNote
                    Note N = new Note();
                    N.NoteSubject = txt_NoteSubject.Text.Trim();
                    N.NoteContext = txt_NoteContext.Text.Trim();
                    N.NoteCreateDate = val_NoteCreatedDate.Text;
                    N.NoteUserID = PublicVariable.global_UserID;

                    db.Notes.Add(N);
                    db.SaveChanges();

                    //Sending Note
                    List<DataGridView> rowsWithCheckColumn = new List<DataGridView>();
                    foreach (DataGridViewRow row in dgv_Recivers.Rows)
                    {
                        SentNote SN = new SentNote();
                        if (Convert.ToBoolean(row.Cells["col_SelectUser"].Value) == true)
                        {
                            SN.SentNoteSendedNoteID = N.NoteID;
                            SN.SentNoteUserID = Convert.ToInt32(row.Cells["col_UserID"].Value);

                            db.SentNotes.Add(SN);
                        }
                    }
                    db.SaveChanges();
                    ts.Complete();

                    MessageBox.Show("يادداشت با موفقيت ارسال شد", "ارسال يادداشت");
                }
                catch (Exception)
                {
                    MessageBox.Show("خطايي در دريافت اطلاعات رخ داد", "پايگاه داده");
                    return;
                }
            }
        }
    }
}
