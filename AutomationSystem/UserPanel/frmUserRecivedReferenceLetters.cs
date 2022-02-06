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
using System.IO;

namespace AutomationSystem.UserPanel
{
    public partial class frmUserRecivedReferenceLetters : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmUserRecivedReferenceLetters()
        {
            InitializeComponent();
        }
        
        private void fillComboBox()
        {
            //ComboBox-Items
            cbx_SearchSecurity.SelectedIndex = 0;
            cbx_SearchStatus.SelectedIndex = 0;
            cbx_SearchLetterType.SelectedIndex = 0;
            cbx_SearchForced.SelectedIndex = 0;
            cbx_SearchFollowing.SelectedIndex = 0;
            cbx_SearchAttachment.SelectedIndex = 0;

            //CreatorCombo-Items
            var query = (from U in db.Vw_Users where U.UserActivity == 1 select U).ToList();

            query.Insert(0, new Vw_Users { UserID = -1, FullName = "همه" });
            cbx_SearchCreator.DataSource = query;
            cbx_SearchCreator.ValueMember = "UserID";
            cbx_SearchCreator.DisplayMember = "FullName";
        }
        private void frmUserRecivedReferenceLetters_Load(object sender, EventArgs e)
        {
            this.Left = 10;
            this.Top = 160;

            fillComboBox();
            txt_DateOn.Value = DateTime.Now.AddDays(-10);
            ShowRecivedReferenceLetters(searchCondition());
        }

        private void ShowRecivedReferenceLetters(string searchReference)
        {
            var query = db.Database.SqlQuery<Vw_ReciveReference>($"SELECT * FROM Vw_ReciveReference WHERE LetterDraftType = 2 AND RefReciverUserID = {PublicVariable.global_UserID} {searchReference}");
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
                    dgv_RecivedReferenceLetters.Rows[i].Cells["col_LetterReferencer"].Value = result[i].RefSender_FullName;
                    dgv_RecivedReferenceLetters.Rows[i].Cells["col_RefCaption"].Value = result[i].RefCaption;

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

        private void dgv_RecivedReferenceLetters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_RecivedReferenceLetters.CurrentCell.ColumnIndex.Equals(15) && e.RowIndex != -1)
            {
                if (dgv_RecivedReferenceLetters.CurrentCell != null && dgv_RecivedReferenceLetters.CurrentCell.Value != null)
                {
                    int get_LetterID = Convert.ToInt32(dgv_RecivedReferenceLetters.CurrentRow.Cells["col_LetterID"].Value);
                    var queryFileName = (from FN in db.AttachmentFiles where FN.AttachLetterID == get_LetterID select FN).ToList();
                    saveAttachmentFile(saveAttachFileDialog, dgv_RecivedReferenceLetters, get_LetterID);
                }
            }
        }

        private void saveAttachmentFile(SaveFileDialog objSFD, DataGridView objGrid, int getLetterID)
        {
            try
            {
                string strID = objGrid.CurrentRow.Cells["col_LetterDownloadAttach"].Value.ToString();
                if (strID != null)
                {
                    var queryAttachment = (from AF in db.AttachmentFiles where AF.AttachLetterID == getLetterID select AF).ToList();

                    byte[] objData = (byte[])queryAttachment[0].AttachFileData;

                    objSFD.FileName = queryAttachment[0].AttachFileName;
                    objSFD.Title = "دريافت فايل الصاقي";

                    if (objSFD.ShowDialog() != DialogResult.Cancel)
                    {
                        string strFileToSave = objSFD.FileName;
                        FileStream objFileStream = new FileStream(strFileToSave, FileMode.Create, FileAccess.Write);
                        objFileStream.Write(objData, 0, objData.Length);
                        objFileStream.Close();

                        MessageBox.Show("فايل الصاقي باموفقيت دانلود شد", "دريافت فايل الصاق");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("در خواندن اطلاعات خطايي رخ داد", "پايگاه داده");
                return;
            }
        }
        private string searchCondition()
        {
            string dateIn = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_DateOn.Value.Year.ToString()}/{txt_DateOn.Value.Month.ToString()}/{txt_DateOn.Value.Day.ToString()}"));
            string dateTo = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_DateTo.Value.Year.ToString()}/{txt_DateTo.Value.Month.ToString()}/{txt_DateTo.Value.Day.ToString()}"));


            string searchString = $" AND RefDate BETWEEN '{dateIn}' AND '{dateTo}'";

            if (txt_LetterSender.Text != "")
            {
                searchString += $" AND RefSender_FullName LIKE '%{txt_LetterSender.Text}%'";
            }

            if (txt_LetterNo.Text != "")
            {
                searchString += $" AND LetterNo LIKE '%{txt_LetterNo.Text}%'";
            }

            if (txt_LetterSubject.Text != "")
            {
                searchString += $" AND LetterSubject LIKE '%{txt_LetterSubject.Text}%'";
            }

            if (txt_LetterReffrence.Text != "")
            {
                searchString += $" AND LetterReffrence LIKE '%{txt_LetterReffrence.Text}%'";
            }

            //SecurityType - Search
            if (cbx_SearchSecurity.SelectedIndex == 1)
            {
                searchString += " AND LetterSecurityType = 1";
            }
            else if (cbx_SearchSecurity.SelectedIndex == 2)
            {
                searchString += " AND LetterSecurityType = 2";
            }
            else if (cbx_SearchSecurity.SelectedIndex == 3)
            {
                searchString += " AND LetterSecurityType = 3";
            }

            //ForcedType - Search
            if (cbx_SearchForced.SelectedIndex == 1)
            {
                searchString += " AND LetterForceType = 1";
            }
            else if (cbx_SearchForced.SelectedIndex == 2)
            {
                searchString += " AND LetterForceType = 2";
            }
            else if (cbx_SearchForced.SelectedIndex == 3)
            {
                searchString += " AND LetterForceType = 3";
            }

            //LetterType - Search
            if (cbx_SearchLetterType.SelectedIndex == 1)
            {
                searchString += " AND LetterType = 1";
            }
            else if (cbx_SearchLetterType.SelectedIndex == 2)
            {
                searchString += " AND LetterType = 2";
            }

            //LetterStatus - Search
            if (cbx_SearchStatus.SelectedIndex == 1)
            {
                searchString += " AND RefReadType = 2";
            }
            else if (cbx_SearchStatus.SelectedIndex == 2)
            {
                searchString += " AND RefReadType = 1";
            }

            //LetterAttachment - Search
            if (cbx_SearchAttachment.SelectedIndex == 1)
            {
                searchString += " AND LetterAttachmentType = 1";
            }
            else if (cbx_SearchAttachment.SelectedIndex == 2)
            {
                searchString += " AND LetterAttachmentType = 2";
            }

            //LetterFollowing - Search
            if (cbx_SearchFollowing.SelectedIndex == 1)
            {
                searchString += " AND LetterFollowingType = 1";
            }
            if (cbx_SearchFollowing.SelectedIndex == 2)
            {
                searchString += " AND LetterFollowingType = 2";
            }

            //Creator - Search
            if (cbx_SearchCreator.SelectedIndex != 0)
            {
                searchString += " AND LetterUserID = " + cbx_SearchCreator.SelectedValue;
            }

            return searchString;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ShowRecivedReferenceLetters(searchCondition());
        }
    }
}
