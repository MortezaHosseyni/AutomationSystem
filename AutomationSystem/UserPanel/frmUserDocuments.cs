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
    public partial class frmUserDocuments : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities(PublicVariable.mainConnectionString);
        public frmUserDocuments()
        {
            InitializeComponent();
        }

        private void frmUserDocuments_Load(object sender, EventArgs e)
        {
            this.Left = 10;
            this.Top = 160;

            txt_DateIn.Value = DateTime.Now.AddDays(-10);
            ShowSavedDocuments(searchCondition());
            val_DocSaveDate.Text = PublicVariable.todayDate;
        }

        private void btn_DocAttachFile_Click(object sender, EventArgs e)
        {
            var file = "";

            openFileDialog.Filter = "All Files (*.*) | *.*";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "انتخاب فايل پيوست";
            openFileDialog.FileName = "AttachmentFile";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var lst = new string[] { ".jpg", ".bmp", ".png", ".zip", ".rar", ".pdf", ".doc", ".docx", ".txt", ".xls", ".xlsx", ".mp4", ".mp3" };

                file = openFileDialog.FileName;

                if (!lst.Contains(Path.GetExtension(file)))
                {
                    MessageBox.Show("فايل انتخاب شده مجاز نيست، لطفا يك فايل با پسوند مجاز انتخاب كنيد", "انتخاب فايل الصاق");
                    return;
                }
                val_DocFilePath.Text = file;
            }
            else
            {
                return;
            }
        }

        private void btn_SaveDoc_Click(object sender, EventArgs e)
        {
            if (!checkNullable())
            {
                return;
            }

            try
            {
                Document D = new Document();
                D.DocUserID = PublicVariable.global_UserID;
                D.DocSubject = txt_DocSubject.Text.Trim();
                D.DocExporter = txt_DocExporter.Text.Trim();
                D.DocCaption = txt_DocCaption.Text.Trim();
                D.DocDeliveryName = txt_DocDeliver.Text.Trim();
                D.DocDate = val_DocSaveDate.Text;
                //AttachFile Save
                if (val_DocFilePath.Text != "")
                {
                    FileStream objFileStream = new FileStream(val_DocFilePath.Text, FileMode.Open, FileAccess.Read);
                    int intLenght = Convert.ToInt32(objFileStream.Length);
                    byte[] objData = new byte[intLenght];
                    string[] strPath = val_DocFilePath.Text.Split(Convert.ToChar(@"\"));

                    objFileStream.Read(objData, 0, intLenght);

                    objFileStream.Close();

                    D.DocFileSize = intLenght;
                    D.DocFileName = strPath[strPath.Length - 1];
                    D.DocFileData = objData;
                }

                db.Documents.Add(D);
                db.SaveChanges();

                MessageBox.Show("سند جديد با موفقيت ثبت شد", "ثبت سند");

                ShowSavedDocuments(searchCondition());

                clearFill();
            }
            catch (Exception)
            {
                MessageBox.Show("خطايي در خواندن اطلاعات رخ داد", "پايگاه داده");
                return;
            }
        }
        private void ShowSavedDocuments(string searchSavedDocs)
        {
            var query = db.Database.SqlQuery<Document>($"SELECT * FROM Documents WHERE DocUserID = {PublicVariable.global_UserID} {searchSavedDocs}");
            var result = query.ToList();

            dgv_SavedDocuments.Rows.Clear();

            if (result.Count != 0)
            {
                dgv_SavedDocuments.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_SavedDocuments.Rows[i].Cells["col_DocID"].Value = result[i].DocID;

                    dgv_SavedDocuments.Rows[i].Cells["col_DocSubject"].Value = result[i].DocSubject;
                    dgv_SavedDocuments.Rows[i].Cells["col_DocCaption"].Value = result[i].DocCaption;
                    dgv_SavedDocuments.Rows[i].Cells["col_DocExporter"].Value = result[i].DocExporter;
                    dgv_SavedDocuments.Rows[i].Cells["col_DocDeliveryName"].Value = result[i].DocDeliveryName;
                    dgv_SavedDocuments.Rows[i].Cells["col_DocDate"].Value = result[i].DocDate;
                    dgv_SavedDocuments.Rows[i].Cells["col_DocAttachFile"].Value = result[i].DocFileName;
                }
                dgv_SavedDocuments.TopLeftHeaderCell.Value = "رديف";
                for (int counter = 0; counter <= dgv_SavedDocuments.Rows.Count - 1; counter++)
                {
                    dgv_SavedDocuments.Rows[counter].HeaderCell.Value = (counter + 1).ToString();
                }
            }
            else
            {
                dgv_SavedDocuments.Rows.Clear();
            }
        }
        private string searchCondition()
        {
            string dateIn = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_DateIn.Value.Year.ToString()}/{txt_DateIn.Value.Month.ToString()}/{txt_DateIn.Value.Day.ToString()}"));
            string dateTo = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_DateTo.Value.Year.ToString()}/{txt_DateTo.Value.Month.ToString()}/{txt_DateTo.Value.Day.ToString()}"));


            string searchString = $" AND DocDate BETWEEN '{dateIn}' AND '{dateTo}'";

            if (txt_SearchDocSubject.Text != "")
            {
                searchString += $" AND DocSubject LIKE '%{txt_SearchDocSubject.Text}%'";
            }
            if (txt_SearchDocExporter.Text != "")
            {
                searchString += $" AND DocExporter LIKE '%{txt_SearchDocExporter.Text}%'";
            }
            if (txt_SearchDocDeliver.Text != "")
            {
                searchString += $" AND DocDeliveryName LIKE '%{txt_SearchDocDeliver.Text}%'";
            }

            return searchString;
        }

        private bool checkNullable()
        {
            if (txt_DocSubject.Text.Trim() == "")
            {
                MessageBox.Show("موضوع سند را وارد كنيد", "ثبت سند");
                return false;
            }
            if (txt_DocExporter.Text.Trim() == "")
            {
                MessageBox.Show("فيلد صادر كننده سند را پر كنيد", "ثبت سند");
                return false;
            }
            if (txt_DocCaption.Text.Trim() == "")
            {
                MessageBox.Show("توضيحاتي در مورد سند بنويسيد", "ثبت سند");
                return false;
            }
            if (txt_DocDeliver.Text.Trim() == "")
            {
                MessageBox.Show("نام تحويل دهنده سند را بنويسيد", "ثبت سند");
                return false;
            }
            return true;
        }

        private void clearFill()
        {
            txt_DocSubject.Text = "";
            txt_DocCaption.Text = "";
            txt_DocExporter.Text = "";
            txt_DocDeliver.Text = "";
            val_DocFilePath.Text = "";
        }

        private void dgv_SavedDocuments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_SavedDocuments.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                if (dgv_SavedDocuments.CurrentCell != null && dgv_SavedDocuments.CurrentCell.Value != null)
                {
                    int get_DocID = Convert.ToInt32(dgv_SavedDocuments.CurrentRow.Cells["col_DocID"].Value);
                    var queryFileName = (from DA in db.Documents where DA.DocID == get_DocID select DA).ToList();
                    saveAttachmentFile(saveAttachFileDialog, dgv_SavedDocuments, get_DocID);
                }
            }
        }
        private void saveAttachmentFile(SaveFileDialog objSFD, DataGridView objGrid, int getLetterID)
        {
            try
            {
                string strID = objGrid.CurrentRow.Cells["col_DocAttachFile"].Value.ToString();
                if (strID != null)
                {
                    var queryAttachment = (from DA in db.Documents where DA.DocID == getLetterID select DA).ToList();

                    byte[] objData = (byte[])queryAttachment[0].DocFileData;

                    objSFD.FileName = queryAttachment[0].DocFileName;
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ShowSavedDocuments(searchCondition());
        }
    }
}
