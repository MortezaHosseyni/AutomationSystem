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

namespace AutomationSystem.UserPanel
{
    public partial class frmUserReminder : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities(PublicVariable.mainConnectionString);
        public frmUserReminder()
        {
            InitializeComponent();
        }

        private void frmUserReminder_Load(object sender, EventArgs e)
        {
            this.Left = 10;
            this.Top = 160;

            txt_RemindDateTo.Value = DateTime.Now.AddDays(1);
            Reminder(searchCondition());
        }

        private void Reminder(string searchRemind)
        {
            var query = db.Database.SqlQuery<Vw_Reminder>("SELECT * FROM Vw_Reminder WHERE 1=1" + searchRemind);
            var result = query.ToList();

            if (result.Count != 0)
            {
                dgv_Reminders.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_Reminders.Rows[i].Cells["col_RemindSubject"].Value = result[i].RemindSubject;
                    dgv_Reminders.Rows[i].Cells["col_RemindCaption"].Value = result[i].RemindCaption;
                    dgv_Reminders.Rows[i].Cells["col_RemindCreatedDate"].Value = result[i].RemindCreatedDate;
                    dgv_Reminders.Rows[i].Cells["col_RemindRememberDate"].Value = result[i].RemindRememberDate;
                    dgv_Reminders.Rows[i].Cells["col_RemindStatus"].Value = result[i].RemindRead;

                    dgv_Reminders.Rows[i].Cells["col_RemindID"].Value = result[i].RemindID;
                    dgv_Reminders.Rows[i].Cells["col_RemindIsRead"].Value = result[i].RemindIsRead;


                    if (Convert.ToInt16(dgv_Reminders.Rows[i].Cells["col_RemindIsRead"].Value) == 1)
                    {
                        dgv_Reminders.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                    }
                    else
                    {
                        dgv_Reminders.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
            }
            else
            {
                dgv_Reminders.Rows.Clear();
            }
        }

        private string searchCondition()
        {
            string dateIn = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_RemindDateIn.Value.Year.ToString()}/{txt_RemindDateIn.Value.Month.ToString()}/{txt_RemindDateIn.Value.Day.ToString()}"));
            string dateTo = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_RemindDateTo.Value.Year.ToString()}/{txt_RemindDateTo.Value.Month.ToString()}/{txt_RemindDateTo.Value.Day.ToString()}"));


            string searchString = $" AND RemindRememberDate BETWEEN '{dateIn}' AND '{dateTo}'";

            if (txt_RemindSubjectSearch.Text != "")
            {
                searchString += $" AND RemindSubject LIKE '%{txt_RemindSubjectSearch.Text}%'";
            }

            return searchString;
        }

        private void btn_RemindSearch_Click(object sender, EventArgs e)
        {
            Reminder(searchCondition());
        }

        private void dgv_Reminders_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(dgv_Reminders.CurrentRow.Cells["col_RemindCaption"].Value.ToString(), dgv_Reminders.CurrentRow.Cells["col_RemindSubject"].Value.ToString());

            try
            {
                int currentRemindID = Convert.ToInt32(dgv_Reminders.CurrentRow.Cells["col_RemindID"].Value);

                var updateQuery = (from R in db.Reminders where R.RemindID == currentRemindID select R).SingleOrDefault();
                updateQuery.RemindIsRead = 2;
                db.SaveChanges();

                Reminder(searchCondition());
            }
            catch (Exception)
            {
                MessageBox.Show("در نمايش اطلاعات مشكلي رخ داد", "پايگاه داده");
                throw;
            }
        }
    }
}
