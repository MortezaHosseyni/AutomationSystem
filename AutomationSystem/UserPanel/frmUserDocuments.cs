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
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmUserDocuments()
        {
            InitializeComponent();
        }

        private void frmUserDocuments_Load(object sender, EventArgs e)
        {
            this.Left = 10;
            this.Top = 160;

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

                clearFill();
            }
            catch (Exception)
            {
                MessageBox.Show("خطايي در خواندن اطلاعات رخ داد", "پايگاه داده");
                return;
            }
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
    }
}
