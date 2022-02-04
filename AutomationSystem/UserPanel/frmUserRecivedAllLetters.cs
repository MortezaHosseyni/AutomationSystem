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
    public partial class frmUserRecivedAllLetters : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmUserRecivedAllLetters()
        {
            InitializeComponent();
        }

        private void frmUserRecivedAllLetters_Load(object sender, EventArgs e)
        {
            this.Left = 10;
            this.Top = 160;

            ShowRecivedLetters();
        }

        private void ShowRecivedLetters()//string searchRecivedLetters)
        {
            var query = db.Database.SqlQuery<Vw_ReciveLetter>($"SELECT * FROM Vw_ReciveLetter WHERE LetterDraftType = 2 AND SentUserID = {PublicVariable.global_UserID}");
            var result = query.ToList();

            dgv_RecivedLetters.Rows.Clear();

            if (result.Count != 0)
            {
                dgv_RecivedLetters.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_RecivedLetters.Rows[i].Cells["col_LetterID"].Value = result[i].LetterID;

                    dgv_RecivedLetters.Rows[i].Cells["col_LetterSubject"].Value = result[i].LetterSubject;
                    dgv_RecivedLetters.Rows[i].Cells["col_LetterType"].Value = result[i].View_LetterType;
                    dgv_RecivedLetters.Rows[i].Cells["col_LetterForceType"].Value = result[i].View_LetterForceType;
                    dgv_RecivedLetters.Rows[i].Cells["col_LetterSecurityType"].Value = result[i].View_LetterSecurityType;
                    dgv_RecivedLetters.Rows[i].Cells["col_LetterFollowingType"].Value = result[i].View_LetterFollowingType;
                    dgv_RecivedLetters.Rows[i].Cells["col_LetterAttachmentType"].Value = result[i].View_LetterAttachmentType;
                    dgv_RecivedLetters.Rows[i].Cells["col_LetterAnswerDeadLine"].Value = result[i].LetterAnswerDeadLine;
                    dgv_RecivedLetters.Rows[i].Cells["col_LetterNo"].Value = result[i].LetterNo;
                    dgv_RecivedLetters.Rows[i].Cells["col_LetterReadType"].Value = result[i].View_LetterReadType;
                    dgv_RecivedLetters.Rows[i].Cells["col_LetterArchiveType"].Value = result[i].View_LetterArchiveType;
                    dgv_RecivedLetters.Rows[i].Cells["col_LetterSender"].Value = result[i].UserFullName;
                    dgv_RecivedLetters.Rows[i].Cells["col_LetterSenderUserID"].Value = result[i].SentUserID;
                    dgv_RecivedLetters.Rows[i].Cells["col_LetterReffrence"].Value = result[i].LetterReffrence;

                    dgv_RecivedLetters.Rows[i].Cells["col_ScurityT"].Value = result[i].LetterSecurityType;
                    dgv_RecivedLetters.Rows[i].Cells["col_ForceT"].Value = result[i].LetterForceType;
                    dgv_RecivedLetters.Rows[i].Cells["col_ArchiveT"].Value = result[i].LetterArchiveType;

                    //SecurityType - Colors
                    if (Convert.ToInt16(dgv_RecivedLetters.Rows[i].Cells["col_ScurityT"].Value) == 2)
                    {
                        dgv_RecivedLetters.Rows[i].Cells["col_LetterSecurityType"].Style.BackColor = Color.Yellow;
                    }
                    else if (Convert.ToInt16(dgv_RecivedLetters.Rows[i].Cells["col_ScurityT"].Value) == 3)
                    {
                        dgv_RecivedLetters.Rows[i].Cells["col_LetterSecurityType"].Style.BackColor = Color.Red;
                    }

                    //ForceType - Colors
                    if (Convert.ToInt16(dgv_RecivedLetters.Rows[i].Cells["col_ForceT"].Value) == 2)
                    {
                        dgv_RecivedLetters.Rows[i].Cells["col_LetterForceType"].Style.BackColor = Color.Yellow;
                    }
                    else if (Convert.ToInt16(dgv_RecivedLetters.Rows[i].Cells["col_ForceT"].Value) == 3)
                    {
                        dgv_RecivedLetters.Rows[i].Cells["col_LetterForceType"].Style.BackColor = Color.Red;
                    }

                    //ArchiveType - Colors
                    if (Convert.ToInt16(dgv_RecivedLetters.Rows[i].Cells["col_ArchiveT"].Value) == 2)
                    {
                        dgv_RecivedLetters.Rows[i].Cells["col_LetterArchiveType"].Style.BackColor = Color.Plum;
                    }
                }
            }
            else
            {
                dgv_RecivedLetters.Rows.Clear();
            }
        }

        //private string searchCondition()
        //{
        //    string searchString = "";

        //    //Subject Search
        //    if (txt_SearchSubject.Text != "")
        //    {
        //        searchString += $" AND LetterSubject LIKE '%{txt_SearchSubject.Text}%'";
        //    }

        //    //ForcedType Search
        //    if (rdb_SearchNormalForced.Checked)
        //    {
        //        searchString += " AND LetterForceType = 1";
        //    }
        //    else if (rdb_SearchImmediateForced.Checked)
        //    {
        //        searchString += " AND LetterForceType = 2";
        //    }
        //    else if (rdb_SearchPosthasteForced.Checked)
        //    {
        //        searchString += " AND LetterForceType = 3";
        //    }

        //    //SecurityType Search
        //    if (rdb_SearchNormalSecurity.Checked)
        //    {
        //        searchString += " AND LetterSecurityType = 1";
        //    }
        //    else if (rdb_SearchConfidentialSecurity.Checked)
        //    {
        //        searchString += " AND LetterSecurityType = 2";
        //    }
        //    else if (rdb_SearchSecretiveSecurity.Checked)
        //    {
        //        searchString += " AND LetterSecurityType = 3";
        //    }

        //    return searchString;
        //}
    }
}
