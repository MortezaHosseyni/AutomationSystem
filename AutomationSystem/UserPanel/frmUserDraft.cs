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
    public partial class frmUserDraft : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmMainUser mainUser;
        public frmUserDraft(frmMainUser inParent)
        {
            mainUser = inParent;
            InitializeComponent();
        }

        private void frmUserDraft_Load(object sender, EventArgs e)
        {
            ShowDraft(searchCondition());

            this.Left = 10;
            this.Top = 160;
        }

        private void ShowDraft(string searchDraft)
        {
            var query = db.Database.SqlQuery<Vw_Letters>($"SELECT * FROM Vw_Letters WHERE LetterDraftType = 1 AND LetterUserID = {PublicVariable.global_UserID} {searchDraft}");
            var result = query.ToList();

            dgv_DraftList.Rows.Clear();

            if (result.Count != 0)
            {
                dgv_DraftList.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_DraftList.Rows[i].Cells["col_LetterID"].Value = result[i].LetterID;

                    dgv_DraftList.Rows[i].Cells["col_LetterSubject"].Value = result[i].LetterSubject;
                    dgv_DraftList.Rows[i].Cells["col_LetterType"].Value = result[i].View_LetterType;
                    dgv_DraftList.Rows[i].Cells["col_LetterForceType"].Value = result[i].View_LetterForceType;
                    dgv_DraftList.Rows[i].Cells["col_LetterSecurityType"].Value = result[i].View_LetterSecurityType;
                    dgv_DraftList.Rows[i].Cells["col_LetterFollowingType"].Value = result[i].View_LetterFollowingType;
                    dgv_DraftList.Rows[i].Cells["col_LetterAttachmentType"].Value = result[i].View_LetterAttachmentType;
                    dgv_DraftList.Rows[i].Cells["col_LetterAnswerType"].Value = result[i].View_LetterAnswerType;
                    dgv_DraftList.Rows[i].Cells["col_LetterAnswerDeadLine"].Value = result[i].LetterAnswerDeadLine;
                    dgv_DraftList.Rows[i].Cells["col_LetterNo"].Value = result[i].LetterNo;
                    dgv_DraftList.Rows[i].Cells["col_LetterReplyID"].Value = result[i].LetterReplyID;

                    dgv_DraftList.Rows[i].Cells["col_ForceT"].Value = result[i].LetterForceType;
                    dgv_DraftList.Rows[i].Cells["col_SecurityT"].Value = result[i].LetterSecurityType;
                    dgv_DraftList.Rows[i].Cells["col_LetterT"].Value = result[i].LetterType;

                    //ForceType Style
                    if (Convert.ToInt16(dgv_DraftList.Rows[i].Cells["col_ForceT"].Value) == 2)
                    {
                        dgv_DraftList.Rows[i].Cells["col_LetterForceType"].Style.BackColor = Color.Yellow;
                    }
                    if (Convert.ToInt16(dgv_DraftList.Rows[i].Cells["col_ForceT"].Value) == 3)
                    {
                        dgv_DraftList.Rows[i].Cells["col_LetterForceType"].Style.BackColor = Color.Red;
                    }

                    //SecurityTyle Style
                    if (Convert.ToInt16(dgv_DraftList.Rows[i].Cells["col_SecurityT"].Value) == 2)
                    {
                        dgv_DraftList.Rows[i].Cells["col_LetterSecurityType"].Style.BackColor = Color.Yellow;
                    }
                    if (Convert.ToInt16(dgv_DraftList.Rows[i].Cells["col_SecurityT"].Value) == 3)
                    {
                        dgv_DraftList.Rows[i].Cells["col_LetterSecurityType"].Style.BackColor = Color.Red;
                    }
                }
            }
            else
            {
                dgv_DraftList.Rows.Clear();
            }
        }

        private string searchCondition()
        {
            string searchString = "";

            //Subject Search
            if (txt_SearchSubject.Text != "")
            {
                searchString += $" AND LetterSubject LIKE '%{txt_SearchSubject.Text}%'";
            }
            
            //ForcedType Search
            if (rdb_SearchNormalForced.Checked)
            {
                searchString += " AND LetterForceType = 1";
            }
            else if (rdb_SearchImmediateForced.Checked)
            {
                searchString += " AND LetterForceType = 2";
            }
            else if (rdb_SearchPosthasteForced.Checked)
            {
                searchString += " AND LetterForceType = 3";
            }

            //SecurityType Search
            if (rdb_SearchNormalSecurity.Checked)
            {
                searchString += " AND LetterSecurityType = 1";
            }
            else if (rdb_SearchConfidentialSecurity.Checked)
            {
                searchString += " AND LetterSecurityType = 2";
            }
            else if (rdb_SearchSecretiveSecurity.Checked)
            {
                searchString += " AND LetterSecurityType = 3";
            }

            return searchString;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ShowDraft(searchCondition());
        }

        private void btn_DeleteLetter_Click(object sender, EventArgs e)
        {
            try
            {
                int item = dgv_DraftList.SelectedCells.Count;
                if (item > 0)
                {
                    if (MessageBox.Show("آيا از حذف اين نامه مطمعن هستيد؟", "حذف نامه", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int Get_LetterID = Convert.ToInt32(dgv_DraftList.CurrentRow.Cells["col_LetterID"].Value);
                        var delLetterQuery = (from L in db.Letters where L.LetterID == Get_LetterID select L).SingleOrDefault();

                        db.Letters.Remove(delLetterQuery);

                        db.SaveChanges();

                        MessageBox.Show("نامه با موفقيت از پيش‌نويس حذف شد", "حذف نامه");

                        ShowDraft(searchCondition());
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("خطايي در خواندن اطلاعات رخ داد","پايگاه داده");
                return;
            }
        }

        private void btn_SendLetter_Click(object sender, EventArgs e)
        {
            int item = dgv_DraftList.SelectedCells.Count;
            if (item > 0)
            {
                int getLetterReplyID;
                int getLetterCreator;
                if (Convert.ToByte(dgv_DraftList.CurrentRow.Cells["col_LetterT"].Value) == 2)
                {
                    getLetterReplyID = Convert.ToInt32(dgv_DraftList.CurrentRow.Cells["col_LetterReplyID"].Value);
                    var query = (from L in db.Letters where L.LetterID == getLetterReplyID select L).ToList();
                    if (query.Count > 0)
                    {
                        getLetterCreator = query[0].LetterUserID;

                        frmUserChooseLetterSend userChooseLetterSendForm = new frmUserChooseLetterSend();

                        userChooseLetterSendForm.getLetterReplyID = getLetterCreator;
                        userChooseLetterSendForm.isReply = 1;
                        userChooseLetterSendForm.GetLetterID = Convert.ToInt32(dgv_DraftList.CurrentRow.Cells["col_LetterID"].Value);
                        userChooseLetterSendForm.ShowDialog();
                        ShowDraft(searchCondition());
                    }
                }
                else
                {
                    frmUserChooseLetterSend userChooseLetterSendForm = new frmUserChooseLetterSend();

                    userChooseLetterSendForm.GetLetterID = Convert.ToInt32(dgv_DraftList.CurrentRow.Cells["col_LetterID"].Value);
                    userChooseLetterSendForm.ShowDialog();
                    ShowDraft(searchCondition());
                }
            }
            else
            {
                MessageBox.Show("براي ارسال نامه ابتدا نامه‌اي را از جدول پيش‌نويس‌ها انتخاب كنيد","ارسال نامه");
                return;
            }
        }

        private void tsm_EditLetter_Click(object sender, EventArgs e)
        {
            int item = dgv_DraftList.SelectedCells.Count;
            if (item > 0)
            {
                frmUserAddLetter userAddLetterForm = new frmUserAddLetter();

                userAddLetterForm.MdiParent = mainUser;
                userAddLetterForm.formType = 2;
                userAddLetterForm.getLetterID = Convert.ToInt32(dgv_DraftList.CurrentRow.Cells["col_LetterID"].Value);
                this.Close();
                userAddLetterForm.Show();
            }
            else
            {
                MessageBox.Show("لطفا يك نامه انتخاب كنيد","ويرايش نامه");
                return;
            }
        }
    }
}
