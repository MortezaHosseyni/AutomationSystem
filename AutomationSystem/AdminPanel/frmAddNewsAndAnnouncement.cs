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

namespace AutomationSystem.AdminPanel
{
    public partial class frmAddNewsAndAnnouncement : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmAddNewsAndAnnouncement()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddNewsAndAnnouncement_Load(object sender, EventArgs e)
        {
            val_NewsDate.Text = PublicVariable.todayDate;
            val_NewsWriter.Text = PublicVariable.global_UserFristName + " " + PublicVariable.global_UserLastName;
        }

        private void btn_AttachFile_Click(object sender, EventArgs e)
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
                lbl_NewsAttachmentFilePath.Text = file;
            }
            else
            {
                return;
            }
        }

        private void btn_SendNews_Click(object sender, EventArgs e)
        {
            if (txt_NewsSubject.Text == "" || txt_NewsContext.Text == "")
            {
                MessageBox.Show("اطلاعات ناقص است، لطفا فيلدهاي خالي را پُر كنيد","ارسال اطلاعيه");
                txt_NewsSubject.Focus();
                return;
            }

            try
            {
                News N = new News();
                N.NewsUserID = PublicVariable.global_UserID;
                N.NewsSubject = txt_NewsSubject.Text.Trim();
                N.NewsContext = txt_NewsContext.Text.Trim();
                N.NewsDate = val_NewsDate.Text.Trim();

                //AttachFile Save
                if (lbl_NewsAttachmentFilePath.Text != "")
                {
                    FileStream objFileStream = new FileStream(lbl_NewsAttachmentFilePath.Text, FileMode.Open, FileAccess.Read);
                    int intLenght = Convert.ToInt32(objFileStream.Length);
                    byte[] objData = new byte[intLenght];
                    string[] strPath = lbl_NewsAttachmentFilePath.Text.Split(Convert.ToChar(@"\"));

                    objFileStream.Read(objData, 0, intLenght);

                    objFileStream.Close();

                    N.NewsAttachmentFileSize = intLenght;
                    N.NewsAttachmentFileName = strPath[strPath.Length - 1];
                    N.NewsAttachment = objData;
                }

                db.News.Add(N);
                db.SaveChanges();

                MessageBox.Show("اطلاعيه با موفقيت ارسال شد","ارسال خبر");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("خطايي در خواندن اطلاعات رخ داد","پايگاه داده");
                return;
            }
        }

        private void btn_NewsList_Click(object sender, EventArgs e)
        {
            frmNewsList newsListForm = new frmNewsList();
            newsListForm.ShowDialog();
        }

        private void btn_SendSMS_Click(object sender, EventArgs e)
        {
            frmSendSMS sendSMS = new frmSendSMS();
            sendSMS.ShowDialog();
        }
    }
}
