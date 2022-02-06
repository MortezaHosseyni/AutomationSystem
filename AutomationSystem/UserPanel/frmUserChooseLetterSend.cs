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
    public partial class frmUserChooseLetterSend : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public int GetLetterID { get; set; }
        public int getLetterReplyID { get; set; }
        public byte isReply { get; set; } // 1 = Reply Letter
        public byte isReference { get; set; } // 1 = Reference
        public frmUserChooseLetterSend()
        {
            InitializeComponent();
        }

        private void frmUserChooseLetterSend_Load(object sender, EventArgs e)
        {
            if (isReply == 1)
            {
                ShowAllowedUsers_ToReply(searchCondition());
            }
            else
            {
                ShowAllowedUsers(searchCondition());
            }
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

        private void ShowAllowedUsers_ToReply(string searchAllowedUser)
        {
            var query = db.Database.SqlQuery<Vw_AsignmentJobs>($"SELECT * FROM Vw_AsignmentJobs WHERE [AsignStatus] = 1 AND AsignUserID = {this.getLetterReplyID} AND [JobsDetermineLevel] >= {PublicVariable.global_JobsDetermineLevel} - 1 {searchAllowedUser}");
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
            if (txt_SearchFristAndLastName.Text != "")
            {
                searchString += $" AND UserFullName LIKE '%{txt_SearchFristAndLastName.Text.Trim()}%'";
            }
            
            return searchString;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ShowAllowedUsers(searchCondition());
        }

        private void btn_SendLetter_Click(object sender, EventArgs e)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                try
                {
                    if (this.isReference == 1)
                    {
                        List<DataGridView> rowsWithCheckColumn = new List<DataGridView>();
                        foreach (DataGridViewRow row in dgv_Recivers.Rows)
                        {
                            ReferenceLetter RL = new ReferenceLetter();
                            if (Convert.ToBoolean(row.Cells["col_SelectUser"].Value) == true)
                            {
                                var queryRefLevel = (from RE in db.ReferenceLetters where RE.RefLetterID == this.GetLetterID orderby RE.RefLevelNumber descending select RE).ToList();
                                if (queryRefLevel.Count > 0)
                                {
                                    var lastLevelNumber = queryRefLevel.Last().RefLevelNumber;
                                    RL.RefLevelNumber = lastLevelNumber + 1;
                                }
                                else
                                {
                                    RL.RefLevelNumber = 1;
                                }

                                RL.RefLetterID = this.GetLetterID;
                                RL.RefReciverUserID = Convert.ToInt32(row.Cells["col_UserID"].Value);
                                RL.RefSenderUserID = PublicVariable.global_UserID;
                                RL.RefDate = PublicVariable.todayDate;
                                RL.RefReadType = 1;

                                db.ReferenceLetters.Add(RL);
                            }
                        }
                        db.SaveChanges();
                        ts.Complete();

                        MessageBox.Show("نامه با موفقيت ارجاع شد", "ارسال نامه");

                        this.Close();
                    }
                    else
                    {
                        //Remove Letter on Drafts
                        var query_update = (from L in db.Letters where L.LetterID == this.GetLetterID select L).SingleOrDefault();
                        query_update.LetterDraftType = 2;
                        query_update.LetterSentDate = PublicVariable.todayDate;
                        db.SaveChanges();

                        //Sending Letter
                        List<DataGridView> rowsWithCheckColumn = new List<DataGridView>();
                        foreach (DataGridViewRow row in dgv_Recivers.Rows)
                        {
                            SentLetter SL = new SentLetter();
                            if (Convert.ToBoolean(row.Cells["col_SelectUser"].Value) == true)
                            {
                                SL.SentSendedLetterID = this.GetLetterID;
                                SL.SentUserID = Convert.ToInt32(row.Cells["col_UserID"].Value);
                                SL.SentReadType = 1;

                                db.SentLetters.Add(SL);
                            }
                        }
                        db.SaveChanges();
                        ts.Complete();

                        MessageBox.Show("نامه با موفقيت ارسال شد", "ارسال نامه");

                        this.Close();
                    }
                    
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
