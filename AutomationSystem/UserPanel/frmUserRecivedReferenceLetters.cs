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
    public partial class frmUserRecivedReferenceLetters : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmUserRecivedReferenceLetters()
        {
            InitializeComponent();
        }

        private void frmUserRecivedReferenceLetters_Load(object sender, EventArgs e)
        {
            this.Left = 10;
            this.Top = 160;

            //ComboBox-Items
            cbx_SearchSecurity.SelectedIndex = 0;
            cbx_SearchStatus.SelectedIndex = 0;
            cbx_SearchLetterType.SelectedIndex = 0;
            cbx_SearchForced.SelectedIndex = 0;
            cbx_SearchFollowing.SelectedIndex = 0;
            cbx_SearchAttachment.SelectedIndex = 0;

            ShowRecivedReferenceLetters();
        }

        private void ShowRecivedReferenceLetters()
        {
            var query = db.Database.SqlQuery<Vw_ReciveReference>($"SELECT * FROM Vw_ReciveReference WHERE LetterDraftType = 2 AND RefReciverUserID = {PublicVariable.global_UserID}");
            var result = query.ToList();

            dgv_RecivedReferenceLetters.Rows.Clear();

            if (result.Count != 0)
            {
                dgv_RecivedReferenceLetters.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_RecivedReferenceLetters.Rows[i].Cells["col_LetterID"].Value = result[i].RefLetterID;

                    dgv_RecivedReferenceLetters.Rows[i].Cells["col_LetterSubject"].Value = result[i].LetterSubject;
                    dgv_RecivedReferenceLetters.Rows[i].Cells["col_LetterType"].Value = result[i].View_LetterType;
                    dgv_RecivedReferenceLetters.Rows[i].Cells["col_LetterForceType"].Value = result[i].View_LetterForceType;
                    dgv_RecivedReferenceLetters.Rows[i].Cells["col_LetterSecurityType"].Value = result[i].View_LetterSecurityType;
                    dgv_RecivedReferenceLetters.Rows[i].Cells["col_LetterFollowingType"].Value = result[i].View_LetterFollowingType;
                    dgv_RecivedReferenceLetters.Rows[i].Cells["col_LetterAttachmentType"].Value = result[i].View_LetterAttachmentType;
                    dgv_RecivedReferenceLetters.Rows[i].Cells["col_LetterAnswerType"].Value = result[i].LetterAnswerType;
                    dgv_RecivedReferenceLetters.Rows[i].Cells["col_LetterAnswerDeadLine"].Value = result[i].LetterAnswerDeadLine;
                    dgv_RecivedReferenceLetters.Rows[i].Cells["col_LetterNo"].Value = result[i].LetterNo;
                    dgv_RecivedReferenceLetters.Rows[i].Cells["col_LetterReadType"].Value = result[i].View_RefReadType;
                    dgv_RecivedReferenceLetters.Rows[i].Cells["col_LetterCreator"].Value = result[i].UserFullName;
                    dgv_RecivedReferenceLetters.Rows[i].Cells["col_LetterCreatorUserID"].Value = result[i].RefSenderUserID;
                    dgv_RecivedReferenceLetters.Rows[i].Cells["col_LetterReffrence"].Value = result[i].LetterReffrence;
                    dgv_RecivedReferenceLetters.Rows[i].Cells["col_LetterReferenceDate"].Value = result[i].RefDate;

                    dgv_RecivedReferenceLetters.Rows[i].Cells["col_SecurityT"].Value = result[i].LetterSecurityType;
                    dgv_RecivedReferenceLetters.Rows[i].Cells["col_ForceT"].Value = result[i].LetterForceType;
                    dgv_RecivedReferenceLetters.Rows[i].Cells["col_AttachmentT"].Value = result[i].LetterAttachmentType;

                    if (Convert.ToInt16(dgv_RecivedReferenceLetters.Rows[i].Cells["col_AttachmentT"].Value) == 1)
                    {
                        dgv_RecivedReferenceLetters.Rows[i].Cells["col_LetterDownloadAttach"].Value = result[i].AttachFileName;
                    }

                    //SecurityType - Colors
                    if (Convert.ToInt16(dgv_RecivedReferenceLetters.Rows[i].Cells["col_SecurityT"].Value) == 2)
                    {
                        dgv_RecivedReferenceLetters.Rows[i].Cells["col_LetterSecurityType"].Style.BackColor = Color.Yellow;
                    }
                    else if (Convert.ToInt16(dgv_RecivedReferenceLetters.Rows[i].Cells["col_SecurityT"].Value) == 3)
                    {
                        dgv_RecivedReferenceLetters.Rows[i].Cells["col_LetterSecurityType"].Style.BackColor = Color.Red;
                    }

                    //ForceType - Colors
                    if (Convert.ToInt16(dgv_RecivedReferenceLetters.Rows[i].Cells["col_ForceT"].Value) == 2)
                    {
                        dgv_RecivedReferenceLetters.Rows[i].Cells["col_LetterForceType"].Style.BackColor = Color.Yellow;
                    }
                    else if (Convert.ToInt16(dgv_RecivedReferenceLetters.Rows[i].Cells["col_ForceT"].Value) == 3)
                    {
                        dgv_RecivedReferenceLetters.Rows[i].Cells["col_LetterForceType"].Style.BackColor = Color.Red;
                    }
                }
                dgv_RecivedReferenceLetters.TopLeftHeaderCell.Value = "رديف";
                for (int counter = 0; counter <= dgv_RecivedReferenceLetters.Rows.Count - 1; counter++)
                {
                    dgv_RecivedReferenceLetters.Rows[counter].HeaderCell.Value = (counter + 1).ToString();
                }
            }
            else
            {
                dgv_RecivedReferenceLetters.Rows.Clear();
            }
        }
        //private string searchCondition()
        //{
        //    string dateIn = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_DateOn.Value.Year.ToString()}/{txt_DateOn.Value.Month.ToString()}/{txt_DateOn.Value.Day.ToString()}"));
        //    string dateTo = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_DateTo.Value.Year.ToString()}/{txt_DateTo.Value.Month.ToString()}/{txt_DateTo.Value.Day.ToString()}"));


        //    string searchString = $" AND LetterSentDate BETWEEN '{dateIn}' AND '{dateTo}'";

        //    if (txt_LetterSender.Text != "")
        //    {
        //        searchString += $" AND UserFullName LIKE '%{txt_LetterSender.Text}%'";
        //    }

        //    if (txt_LetterNo.Text != "")
        //    {
        //        searchString += $" AND LetterNo LIKE '%{txt_LetterNo.Text}%'";
        //    }

        //    if (txt_LetterSubject.Text != "")
        //    {
        //        searchString += $" AND LetterSubject LIKE '%{txt_LetterSubject.Text}%'";
        //    }

        //    if (txt_LetterReffrence.Text != "")
        //    {
        //        searchString += $" AND LetterReffrence LIKE '%{txt_LetterReffrence.Text}%'";
        //    }

        //    //SecurityType - Search
        //    if (rdb_LetterSecurity_Normal.Checked == true)
        //    {
        //        searchString += " AND LetterSecurityType = 1";
        //    }
        //    else if (rdb_LetterSecurity_Confidential.Checked == true)
        //    {
        //        searchString += " AND LetterSecurityType = 2";
        //    }
        //    else if (rdb_LetterSecurity_Secretive.Checked == true)
        //    {
        //        searchString += " AND LetterSecurityType = 3";
        //    }

        //    //ForcedType - Search
        //    if (rdb_LetterForceType_Normal.Checked == true)
        //    {
        //        searchString += " AND LetterForceType = 1";
        //    }
        //    else if (rdb_LetterForceType_Immediate.Checked == true)
        //    {
        //        searchString += " AND LetterForceType = 2";
        //    }
        //    else if (rdb_LetterForceType_Posthaste.Checked == true)
        //    {
        //        searchString += " AND LetterForceType = 3";
        //    }

        //    //LetterType - Search
        //    if (rdb_LetterType_Letter.Checked == true)
        //    {
        //        searchString += " AND LetterType = 1";
        //    }
        //    else if (rdb_LetterType_ReplyLetter.Checked == true)
        //    {
        //        searchString += " AND LetterType = 2";
        //    }

        //    //LetterStatus - Search
        //    if (rdb_LetterStatus_Readed.Checked == true)
        //    {
        //        searchString += " AND SentReadType = 2";
        //    }
        //    else if (rdb_LetterStatus_NotReaded.Checked == true)
        //    {
        //        searchString += " AND SentReadType = 1";
        //    }

        //    //LetterAttachment - Search
        //    if (rdb_LetterAttachmentType_Yes.Checked == true)
        //    {
        //        searchString += " AND LetterAttachmentType = 1";
        //    }
        //    else if (rdb_LetterAttachmentType_No.Checked == true)
        //    {
        //        searchString += " AND LetterAttachmentType = 2";
        //    }

        //    //LetterFollowing - Search
        //    if (rdb_LetterFollowingType_Yes.Checked == true)
        //    {
        //        searchString += " AND LetterFollowingType = 1";
        //    }
        //    if (rdb_LetterFollowingType_No.Checked == true)
        //    {
        //        searchString += " AND LetterFollowingType = 2";
        //    }

        //    return searchString;
        //}
    }
}
