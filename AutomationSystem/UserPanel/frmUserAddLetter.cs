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
        public byte formType { get; set; } // newLetter = 1 | editLetter = 2
        public int getLetterID { get; set; }
        public frmUserAddLetter()
        {
            InitializeComponent();
        }

        private void frmUserAddLetter_Load(object sender, EventArgs e)
        {
            val_LetterCreatedDate.Text = PublicVariable.todayDate;

            if (this.formType == 1)
            {

            }
            else if (this.formType == 2)
            {
                tbc_LetterInformations.SelectedTabIndex = 1;
                btn_AddLetter.Text = "ويرايش نامه";
                var queryAttachName = (from AN in db.AttachmentFiles where AN.AttachLetterID == this.getLetterID select AN).ToList();
                if (queryAttachName.Count > 0)
                {
                    lbl_AttachmentFilePath.Text = queryAttachName[0].AttachFileName;
                }
                showLetterEditInfo();
            }

            this.Left = 10;
            this.Top = 160;
        }

        private void showLetterEditInfo()
        {
            try
            {
                var queryLetterInfo = (from L in db.Vw_Letters where L.LetterID == this.getLetterID select L).ToList();
                if (queryLetterInfo.Count > 0)
                {
                    txt_LetterSubject.Text = queryLetterInfo[0].LetterSubject;
                    txt_LetterAbstract.Text = queryLetterInfo[0].LetterAbstract;
                    adv_LetterContext.TextEditor.Text = queryLetterInfo[0].LetterCaption;
                    tbc_LetterInformations.SelectedTabIndex = 0;
                    val_LetterCreatedDate.Text = queryLetterInfo[0].LetterCreatedDate;

                    //LetterSecurityType
                    if (queryLetterInfo[0].LetterSecurityType == 1)
                    {
                        rdb_LetterSecurity_Normal.Checked = true;
                    }
                    else if (queryLetterInfo[0].LetterSecurityType == 2)
                    {
                        rdb_LetterSecurity_Confidential.Checked = true;
                    }
                    else if (queryLetterInfo[0].LetterSecurityType == 3)
                    {
                        rdb_LetterSecurity_Secretive.Checked = true;
                    }

                    //LetterForcedType
                    if (queryLetterInfo[0].LetterForceType == 1)
                    {
                        rdb_LetterForced_Normal.Checked = true;
                    }
                    else if (queryLetterInfo[0].LetterForceType == 2)
                    {
                        rdb_LetterForced_Immediate.Checked = true;
                    }
                    else if (queryLetterInfo[0].LetterForceType == 3)
                    {
                        rdb_LetterForced_Posthaste.Checked = true;
                    }

                    //LetterFollowingType
                    if (queryLetterInfo[0].LetterFollowingType == 1)
                    {
                        rdb_LetterFollowing_Yes.Checked = true;
                    }
                    else if (queryLetterInfo[0].LetterFollowingType == 2)
                    {
                        rdb_LetterFollowing_No.Checked = true;
                    }

                    //LetterAttachmentType
                    if (queryLetterInfo[0].LetterAttachmentType == 1)
                    {
                        rdb_LetterAttachment_Yes.Checked = true;
                    }
                    else if (queryLetterInfo[0].LetterAttachmentType == 2)
                    {
                        rdb_LetterAttachment_No.Checked = true;
                    }

                    //LetterDeadLineType
                    if (queryLetterInfo[0].LetterAnswerType == 1)
                    {
                        rdb_LetterDeadLine_Yes.Checked = true;
                        txt_LetterDeadLineValue.Value = Convert.ToDateTime(queryLetterInfo[0].LetterAnswerDeadLine);
                    }
                    else if (queryLetterInfo[0].LetterAnswerType == 2)
                    {
                        rdb_LetterDeadLine_No.Checked = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("خطايي در دريافت اطلاعات رخ داد","پايگاه داده");
                return;
            }
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
            if (this.formType == 1) //AddLetter
            {
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

                        MessageBox.Show("اطلاعات با موفقيت ثبت شد", "ايجاد نامه");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("خطايي در خواندن اطلاعات رخ داد", "پايگاه داده");
                        return;
                    }
                }
            }
            else if (this.formType == 2) //EditLetter
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    try
                    {
                        var query_update = (from L in db.Letters where L.LetterID == this.getLetterID where L.LetterUserID == PublicVariable.global_UserID select L).SingleOrDefault();
                        query_update.LetterSubject = txt_LetterSubject.Text.Trim();
                        query_update.LetterAbstract = txt_LetterAbstract.Text.Trim();
                        query_update.LetterCaption = adv_LetterContext.TextEditor.Text;
                        query_update.LetterCreatedDate = val_LetterCreatedDate.Text;

                        //SecurityType
                        if (rdb_LetterSecurity_Normal.Checked == true)
                        {
                            query_update.LetterSecurityType = 1;
                        }
                        else if (rdb_LetterSecurity_Confidential.Checked == true)
                        {
                            query_update.LetterSecurityType = 2;
                        }
                        else if (rdb_LetterSecurity_Secretive.Checked == true)
                        {
                            query_update.LetterSecurityType = 3;
                        }

                        //ForcedType
                        if (rdb_LetterForced_Normal.Checked == true)
                        {
                            query_update.LetterForceType = 1;
                        }
                        else if (rdb_LetterForced_Immediate.Checked == true)
                        {
                            query_update.LetterForceType = 2;
                        }
                        else if (rdb_LetterForced_Posthaste.Checked == true)
                        {
                            query_update.LetterForceType = 3;
                        }

                        //FollowingType
                        if (rdb_LetterFollowing_Yes.Checked == true)
                        {
                            query_update.LetterFollowingType = 1;
                        }
                        else if (rdb_LetterFollowing_No.Checked == true)
                        {
                            query_update.LetterFollowingType = 2;
                        }

                        //AttachmentType
                        if (rdb_LetterAttachment_Yes.Checked == true)
                        {
                            query_update.LetterAttachmentType = 1;
                        }
                        else if (rdb_LetterAttachment_No.Checked == true)
                        {
                            query_update.LetterAttachmentType = 2;
                        }

                        //AnswerType
                        if (rdb_LetterDeadLine_Yes.Checked == true)
                        {
                            query_update.LetterAnswerType = 1;
                            query_update.LetterAnswerDeadLine = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime(txt_LetterDeadLineValue.Value.Year.ToString() + "/" + txt_LetterDeadLineValue.Value.Month.ToString() + "/" + txt_LetterDeadLineValue.Value.Day.ToString()));
                        }
                        else if (rdb_LetterDeadLine_No.Checked == true)
                        {
                            query_update.LetterAnswerType = 2;
                            query_update.LetterAnswerDeadLine = "";
                        }
                        
                        db.SaveChanges();

                        //AttachFile Save
                        if (rdb_LetterAttachment_Yes.Checked == true)
                        {
                            if (lbl_AttachmentFilePath.Text != "")
                            {
                                var queryCheckAttachment = (from AF in db.AttachmentFiles where AF.AttachLetterID == this.getLetterID select AF).ToList();
                                if (queryCheckAttachment.Count == 0) //Letter not have attach -Editing-> Add attach
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
                                    AF.AttachLetterID = this.getLetterID;

                                    db.AttachmentFiles.Add(AF);
                                    db.SaveChanges();
                                }
                                else if (queryCheckAttachment.Count == 1) //Letter have attach -Editing-> Attach changed
                                {
                                    FileStream objFileStream = new FileStream(lbl_AttachmentFilePath.Text, FileMode.Open, FileAccess.Read);
                                    int intLenght = Convert.ToInt32(objFileStream.Length);
                                    byte[] objData = new byte[intLenght];
                                    string[] strPath = lbl_AttachmentFilePath.Text.Split(Convert.ToChar(@"\"));

                                    objFileStream.Read(objData, 0, intLenght);

                                    objFileStream.Close();

                                    var queryUpdateAttach = (from AF in db.AttachmentFiles where AF.AttachLetterID == this.getLetterID select AF).SingleOrDefault();
                                    queryUpdateAttach.AttachFileSize = intLenght / 1024; //KB
                                    queryUpdateAttach.AttachFileName = strPath[strPath.Length - 1];
                                    queryUpdateAttach.AttachFileData = objData;

                                    db.SaveChanges();
                                }
                            }
                        }
                        ts.Complete();

                        MessageBox.Show("اطلاعات با موفقيت ويرايش شد", "ويرايش نامه");
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
}
