using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModelLayer.Models;
using AutomationSystem.Moduls;
using System.Transactions;

namespace AutomationSystem.UserPanel
{
    public partial class frmUserAddLetter : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmUserAddLetter()
        {
            InitializeComponent();
        }

        private void frmUserAddLetter_Load(object sender, EventArgs e)
        {
            val_LetterCreatedDate.Text = PublicVariable.todayDate;

            this.Left = 10;
            this.Top = 160;
        }

        private void rdb_LetterDeadLine_Yes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_LetterDeadLine_Yes.Checked == true)
            {
                txt_LetterDeadLineValue.Enabled = true;
            }
            else
            {
                txt_LetterDeadLineValue.Enabled = false;
            }
        }

        private void rdb_LetterAttachment_Yes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_LetterAttachment_Yes.Checked == true)
            {
                btn_LetterAttachFile.Enabled = true;
            }
            else
            {
                btn_LetterAttachFile.Enabled = false;
            }
        }

        private void btn_LetterAttachFile_Click(object sender, EventArgs e)
        {
            var file = "";

            openFileDialog.Filter = "All Files (*.*) | *.*";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "انتخاب فايل پيوست";
            openFileDialog.FileName = "AttachmentFile";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var lst = new string[] {".jpg",".bmp",".png",".zip",".rar",".pdf",".doc",".docx",".txt",".xls",".xlsx",".mp4",".mp3"};

                file = openFileDialog.FileName;

                if (!lst.Contains(Path.GetExtension(file)))
                {
                    MessageBox.Show("فايل انتخاب شده مجاز نيست، لطفا يك فايل با پسوند مجاز انتخاب كنيد","انتخاب فايل الصاق");
                    return;
                }
                lbl_AttachmentFilePath.Text = file;
            }
            else
            {
                return;
            }
        }

        private void btn_AddLetter_Click(object sender, EventArgs e)
        {
            if (txt_LetterSubject.Text.Trim() == "" || txt_LetterAbstract.Text.Trim() == "" || adv_LetterContext.TextEditor.Text.Trim() == "")
            {
                MessageBox.Show("اطلاعات نامه ناقص است، لطفا همه بخش‌هاي نامه را كامل كنيد","نامه جديد");
                return;
            }
            using (TransactionScope ts = new TransactionScope())
            {
                try
                {
                    Letter L = new Letter();
                    L.LetterSubject = txt_LetterSubject.Text.Trim();
                    L.LetterAbstract = txt_LetterAbstract.Text.Trim();
                    L.LetterCaption = adv_LetterContext.TextEditor.Text;
                    {
                        //Letter Number Formul
                        var lastLetterID = (from LLID in db.Letters orderby LLID.LetterID descending select LLID).First();
                        L.LetterNo = PublicVariable.todayDate.Substring(0, 4).Substring(2, 2) + PublicVariable.global_JobsDetermineLevel + "/" + Convert.ToInt32(lastLetterID.LetterID + 1);
                    }
                    L.LetterCreatedDate = val_LetterCreatedDate.Text;
                    L.LetterUserID = PublicVariable.global_UserID;

                    //SecurityType
                    if (rdb_LetterSecurity_Normal.Checked == true)
                    {
                        L.LetterSecurityType = 1;
                    }
                    else if (rdb_LetterSecurity_Confidential.Checked == true)
                    {
                        L.LetterSecurityType = 2;
                    }
                    else if (rdb_LetterSecurity_Secretive.Checked == true)
                    {
                        L.LetterSecurityType = 3;
                    }

                    //ForcedType
                    if (rdb_LetterForced_Normal.Checked == true)
                    {
                        L.LetterForceType = 1;
                    }
                    else if (rdb_LetterForced_Immediate.Checked == true)
                    {
                        L.LetterForceType = 2;
                    }
                    else if (rdb_LetterForced_Posthaste.Checked == true)
                    {
                        L.LetterForceType = 3;
                    }

                    L.LetterArchiveType = 1;

                    //FollowingType
                    if (rdb_LetterFollowing_Yes.Checked == true)
                    {
                        L.LetterFollowingType = 1;
                    }
                    else if (rdb_LetterFollowing_No.Checked == true)
                    {
                        L.LetterFollowingType = 2;
                    }

                    //AttachmentType
                    if (rdb_LetterAttachment_Yes.Checked == true)
                    {
                        L.LetterAttachmentType = 1;
                    }
                    else if (rdb_LetterAttachment_No.Checked == true)
                    {
                        L.LetterAttachmentType = 2;
                    }

                    L.LetterReadType = 1;
                    L.LetterType = 1;
                    L.LetterDraftType = 1;

                    //AnswerType
                    if (rdb_LetterDeadLine_Yes.Checked == true)
                    {
                        L.LetterAnswerType = 1;
                        L.LetterAnswerDeadLine = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime(txt_LetterDeadLineValue.Value.Year.ToString() + "/" + txt_LetterDeadLineValue.Value.Month.ToString() + "/" + txt_LetterDeadLineValue.Value.Day.ToString()));
                    }
                    else if (rdb_LetterDeadLine_No.Checked == true)
                    {
                        L.LetterAnswerType = 2;
                    }

                    db.Letters.Add(L);
                    db.SaveChanges();

                    //AttachFile Save
                    if (rdb_LetterAttachment_Yes.Checked == true)
                    {
                        if (lbl_AttachmentFilePath.Text != "")
                        {
                            FileStream objFileStream = new FileStream(lbl_AttachmentFilePath.Text, FileMode.Open, FileAccess.Read);
                            int intLenght = Convert.ToInt32(objFileStream.Length);
                            byte[] objData = new byte[intLenght];
                            string[] strPath = lbl_AttachmentFilePath.Text.Split(Convert.ToChar(@"\"));

                            objFileStream.Read(objData, 0, intLenght);

                            objFileStream.Close();

                            AttachmentFile AF = new AttachmentFile();
                            AF.AttachFileSize = intLenght / 1024; //KB
                            AF.AttachFileName = strPath[strPath.Length - 1];
                            AF.AttachFileData = objData;
                            AF.AttachLetterID = L.LetterID;

                            db.AttachmentFiles.Add(AF);
                            db.SaveChanges();
                        }
                    }
                    ts.Complete();

                    MessageBox.Show("اطلاعات با موفقيت ثبت شد","ايجاد نامه");
                }
                catch (Exception)
                {
                    MessageBox.Show("خطايي در خواندن اطلاعات رخ داد", "پايگاه داده");
                    return;
                }
            }
        }
    }
}
