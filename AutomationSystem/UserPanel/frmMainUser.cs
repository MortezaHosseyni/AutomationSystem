using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using DataModelLayer.Models;
using AutomationSystem.Moduls;
using System.IO;

namespace AutomationSystem.UserPanel
{
    public partial class frmMainUser : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        PersianCalendar pCalender = new PersianCalendar();

        byte formNumber = 7;
        int userMainJobID;

        //Forms
        frmUserAddReminder addReminderForm;
        frmUserReminder userReminderForm;
        frmUserDraft userDraftForm;
        frmUserAddLetter userAddLetterForm;
        frmUserRecivedAllLetters userReciveAllLettersForm;
        frmUserSendedLetters userSendedLettersForm;
        frmUserCreateNote userCreateNoteForm;
        frmUserShowSentNotes userShowSentNotes;
        frmUserShowReciveNotes userShowReciveNotes;
        frmUserShowReadedLetters userReadedLettersForm;
        frmUserUnReadLetters userUnReadedLettersForm;
        frmUserImmediateLetters userImmediateLettersForm;
        frmUserConfidentialLetters userConfidentialLettersForm;
        frmUserShowAllNews userShowNews;
        frmUserRecivedReferenceLetters userRecivedReference;
        frmUserSentReferenceLetters userSentReference;
        frmUserFollowingLetters userFollowingLetters;
        frmUserDailyFunction userDailyFunction;
        frmUserShowPersonelsFunction userPersonelsFunctions;
        public frmMainUser()
        {
            InitializeComponent();
        }
        private void frmMainUser_Load(object sender, EventArgs e)
        {
            this.AutoScroll = false;
            ShowUserInfo();

            userReminderForm = new frmUserReminder();
            userReminderForm.Show();
            userReminderForm.MdiParent = this;
            userReminderForm.TopMost = true;

            timer.Start();
            timer_Tick(sender, e);
        }

        private void ShowUserInfo()
        {
            var query = db.Sp_ShowAllUserInfo_UserForm_Up_2(PublicVariable.global_UserID).ToList();

            if (query.Count == 1)
            {
                val_Name.Text = query[0].UserFirstName;
                val_LastName.Text = query[0].UserLastName;
                val_PersonalCode.Text = query[0].UserPersonalID;
                val_BrithDate.Text = query[0].UserBrithDate;
                val_Gender.Text = query[0].View_UserGender;
                val_Job.Text = query[0].JobsName;
                userMainJobID = query[0].AsignJobID;

                var queryLetterCount = db.Sp_LetterCount(PublicVariable.global_UserID).ToList();
                val_AllReciveMessages.Text = queryLetterCount[0].SentLettersCount.ToString();
                val_AllSendedMessages.Text = queryLetterCount[0].ReciveLettersCount.ToString();

                PublicVariable.global_JobsDetermineLevel = Convert.ToInt32(query[0].JobsDetermineLevel);

                var dataUserPicture = (Byte[])(query[0].UserImage);
                var streamUserPicture = new MemoryStream(dataUserPicture);
                pic_UserPicture.Image = Image.FromStream(streamUserPicture);

                val_Date.Text = PublicVariable.todayDate;
                val_Time.Text = string.Format("{0:HH:mm:ss}", Convert.ToDateTime(pCalender.GetHour(DateTime.Now).ToString() + ":" + pCalender.GetMinute(DateTime.Now).ToString() + ":" + pCalender.GetSecond(DateTime.Now).ToString()));
            }
            else
            {
                MessageBox.Show("اين كاربر هيچ شغلي ندارد","ورود مجاز نيست");
                Environment.Exit(0);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            db.Sp_Update_ExitDate(PublicVariable.global_UserID, PublicVariable.todayDate + "-" + string.Format("{0:HH:mm:ss}", Convert.ToDateTime(pCalender.GetHour(DateTime.Now).ToString() + ":" + pCalender.GetMinute(DateTime.Now).ToString() + ":" + pCalender.GetSecond(DateTime.Now).ToString())));
            db.SaveChanges();
            Environment.Exit(0);
        }

        private void lbl_AddReminder_Click_1(object sender, EventArgs e)
        {
            var queryAccess = (from UA in db.UserAccesses where UA.UAccessUserID == PublicVariable.global_UserID where UA.UAccessSPartID == 20 select UA).ToList();
            if (queryAccess.Count == 0)
            {
                MessageBox.Show("شما به اين بخش دسترسي نداريد", "دسترسي ممنوع");
                return;
            }

            CloseForms();

            formNumber = 14;

            addReminderForm = new frmUserAddReminder();

            addReminderForm.Show();
            addReminderForm.MdiParent = this;
        }

        private void CloseForms()
        {
            if (formNumber == 1)
            {
                userReciveAllLettersForm.Close();
            }
            if (formNumber == 2)
            {
                userReadedLettersForm.Close();
            }
            if (formNumber == 3)
            {
                userUnReadedLettersForm.Close();
            }
            if (formNumber == 4)
            {
                userImmediateLettersForm.Close();
            }
            if (formNumber == 5)
            {
                userConfidentialLettersForm.Close();
            }
            if (formNumber == 6)
            {
                userShowReciveNotes.Close();
            }
            if (formNumber == 7)
            {
                userReminderForm.Close();
            }
            if (formNumber == 8)
            {
                userSendedLettersForm.Close();
            }
            if (formNumber == 9)
            {
                userFollowingLetters.Close();
            }
            if (formNumber == 10)
            {
                userShowSentNotes.Close();
            }
            if (formNumber == 11)
            {
                userSentReference.Close();
            }
            if (formNumber == 12)
            {
                userAddLetterForm.Close();
            }
            if (formNumber == 13)
            {
                userCreateNoteForm.Close();
            }
            if (formNumber == 14)
            {
                addReminderForm.Close();
            }
            if (formNumber == 15)
            {
                userDraftForm.Close();
            }
            if (formNumber == 16)
            {
                userShowNews.Close();
            }
            if (formNumber == 17)
            {
                userRecivedReference.Close();
            }
            if (formNumber == 50)
            {
                userDailyFunction.Close();
            }
            if (formNumber == 60)
            {
                userPersonelsFunctions.Close();
            }
        }

        private void lbl_ShowNotes_Click(object sender, EventArgs e)
        {
            var queryAccess = (from UA in db.UserAccesses where UA.UAccessUserID == PublicVariable.global_UserID where UA.UAccessSPartID == 12 select UA).ToList();
            if (queryAccess.Count == 0)
            {
                MessageBox.Show("شما به اين بخش دسترسي نداريد", "دسترسي ممنوع");
                return;
            }

            CloseForms();

            formNumber = 7;

            userReminderForm = new frmUserReminder();
            userReminderForm.Show();
            userReminderForm.MdiParent = this;
        }

        private void lbl_Draft_Click(object sender, EventArgs e)
        {
            var queryAccess = (from UA in db.UserAccesses where UA.UAccessUserID == PublicVariable.global_UserID where UA.UAccessSPartID == 21 select UA).ToList();
            if (queryAccess.Count == 0)
            {
                MessageBox.Show("شما به اين بخش دسترسي نداريد", "دسترسي ممنوع");
                return;
            }

            CloseForms();

            formNumber = 15;

            userDraftForm = new frmUserDraft(this);
            userDraftForm.MdiParent = this;
            userDraftForm.Show();
        }

        private void lbl_CreateMessage_Click(object sender, EventArgs e)
        {
            var queryAccess = (from UA in db.UserAccesses where UA.UAccessUserID == PublicVariable.global_UserID where UA.UAccessSPartID == 18 select UA).ToList();
            if (queryAccess.Count == 0)
            {
                MessageBox.Show("شما به اين بخش دسترسي نداريد", "دسترسي ممنوع");
                return;
            }

            CloseForms();

            formNumber = 12;

            userAddLetterForm = new frmUserAddLetter();
            userAddLetterForm.formType = 1;
            userAddLetterForm.MdiParent = this;
            userAddLetterForm.Show();
        }

        private void lbl_AllRecivedMessages_Click(object sender, EventArgs e)
        {
            var queryAccess = (from UA in db.UserAccesses where UA.UAccessUserID == PublicVariable.global_UserID where UA.UAccessSPartID == 6 select UA).ToList();
            if (queryAccess.Count == 0)
            {
                MessageBox.Show("شما به اين بخش دسترسي نداريد","دسترسي ممنوع");
                return;
            }

            CloseForms();

            formNumber = 1;

            userReciveAllLettersForm = new frmUserRecivedAllLetters(this);
            userReciveAllLettersForm.MdiParent = this;
            userReciveAllLettersForm.Show();
        }

        private void lbl_SendedMessages_Click(object sender, EventArgs e)
        {
            var queryAccess = (from UA in db.UserAccesses where UA.UAccessUserID == PublicVariable.global_UserID where UA.UAccessSPartID == 14 select UA).ToList();
            if (queryAccess.Count == 0)
            {
                MessageBox.Show("شما به اين بخش دسترسي نداريد", "دسترسي ممنوع");
                return;
            }

            CloseForms();

            formNumber = 8;

            userSendedLettersForm = new frmUserSendedLetters();
            userSendedLettersForm.MdiParent = this;
            userSendedLettersForm.Show();
        }

        private void lbl_CreateNote_Click(object sender, EventArgs e)
        {
            var queryAccess = (from UA in db.UserAccesses where UA.UAccessUserID == PublicVariable.global_UserID where UA.UAccessSPartID == 19 select UA).ToList();
            if (queryAccess.Count == 0)
            {
                MessageBox.Show("شما به اين بخش دسترسي نداريد", "دسترسي ممنوع");
                return;
            }

            CloseForms();

            formNumber = 13;

            userCreateNoteForm = new frmUserCreateNote();
            userCreateNoteForm.MdiParent = this;
            userCreateNoteForm.Show();
        }

        private void lbl_SendedNotes_Click(object sender, EventArgs e)
        {
            var queryAccess = (from UA in db.UserAccesses where UA.UAccessUserID == PublicVariable.global_UserID where UA.UAccessSPartID == 16 select UA).ToList();
            if (queryAccess.Count == 0)
            {
                MessageBox.Show("شما به اين بخش دسترسي نداريد", "دسترسي ممنوع");
                return;
            }

            CloseForms();

            formNumber = 10;

            userShowSentNotes = new frmUserShowSentNotes();
            userShowSentNotes.MdiParent = this;
            userShowSentNotes.Show();
        }

        private void lbl_ArrivedNotes_Click(object sender, EventArgs e)
        {
            var queryAccess = (from UA in db.UserAccesses where UA.UAccessUserID == PublicVariable.global_UserID where UA.UAccessSPartID == 11 select UA).ToList();
            if (queryAccess.Count == 0)
            {
                MessageBox.Show("شما به اين بخش دسترسي نداريد", "دسترسي ممنوع");
                return;
            }

            CloseForms();

            formNumber = 6;

            userShowReciveNotes = new frmUserShowReciveNotes();
            userShowReciveNotes.MdiParent = this;
            userShowReciveNotes.Show();
        }

        private void lbl_ReadedMessages_Click(object sender, EventArgs e)
        {
            var queryAccess = (from UA in db.UserAccesses where UA.UAccessUserID == PublicVariable.global_UserID where UA.UAccessSPartID == 7 select UA).ToList();
            if (queryAccess.Count == 0)
            {
                MessageBox.Show("شما به اين بخش دسترسي نداريد", "دسترسي ممنوع");
                return;
            }

            CloseForms();

            formNumber = 2;

            userReadedLettersForm = new frmUserShowReadedLetters();
            userReadedLettersForm.MdiParent = this;
            userReadedLettersForm.Show();
        }

        private void lbl_UnReadedMessages_Click(object sender, EventArgs e)
        {
            var queryAccess = (from UA in db.UserAccesses where UA.UAccessUserID == PublicVariable.global_UserID where UA.UAccessSPartID == 8 select UA).ToList();
            if (queryAccess.Count == 0)
            {
                MessageBox.Show("شما به اين بخش دسترسي نداريد", "دسترسي ممنوع");
                return;
            }

            CloseForms();

            formNumber = 3;

            userUnReadedLettersForm = new frmUserUnReadLetters();
            userUnReadedLettersForm.MdiParent = this;
            userUnReadedLettersForm.Show();
        }

        private void lbl_UrgentActionMessages_Click(object sender, EventArgs e)
        {
            var queryAccess = (from UA in db.UserAccesses where UA.UAccessUserID == PublicVariable.global_UserID where UA.UAccessSPartID == 9 select UA).ToList();
            if (queryAccess.Count == 0)
            {
                MessageBox.Show("شما به اين بخش دسترسي نداريد", "دسترسي ممنوع");
                return;
            }

            CloseForms();

            formNumber = 4;

            userImmediateLettersForm = new frmUserImmediateLetters();
            userImmediateLettersForm.MdiParent = this;
            userImmediateLettersForm.Show();
        }

        private void lbl_ConfidentialMessages_Click(object sender, EventArgs e)
        {
            var queryAccess = (from UA in db.UserAccesses where UA.UAccessUserID == PublicVariable.global_UserID where UA.UAccessSPartID == 10 select UA).ToList();
            if (queryAccess.Count == 0)
            {
                MessageBox.Show("شما به اين بخش دسترسي نداريد", "دسترسي ممنوع");
                return;
            }

            CloseForms();

            formNumber = 5;

            userConfidentialLettersForm = new frmUserConfidentialLetters();
            userConfidentialLettersForm.MdiParent = this;
            userConfidentialLettersForm.Show();
        }

        private void lbl_NewsAndAnnouncement_Click(object sender, EventArgs e)
        {
            var queryAccess = (from UA in db.UserAccesses where UA.UAccessUserID == PublicVariable.global_UserID where UA.UAccessSPartID == 22 select UA).ToList();
            if (queryAccess.Count == 0)
            {
                MessageBox.Show("شما به اين بخش دسترسي نداريد", "دسترسي ممنوع");
                return;
            }

            CloseForms();

            formNumber = 16;

            userShowNews = new frmUserShowAllNews();
            userShowNews.MdiParent = this;
            userShowNews.Show();
        }

        private void lbl_ShowGetReferenceLetters_Click(object sender, EventArgs e)
        {
            var queryAccess = (from UA in db.UserAccesses where UA.UAccessUserID == PublicVariable.global_UserID where UA.UAccessSPartID == 13 select UA).ToList();
            if (queryAccess.Count == 0)
            {
                MessageBox.Show("شما به اين بخش دسترسي نداريد", "دسترسي ممنوع");
                return;
            }

            CloseForms();

            formNumber = 17;

            userRecivedReference = new frmUserRecivedReferenceLetters();
            userRecivedReference.MdiParent = this;
            userRecivedReference.Show();
        }

        private void lbl_ReferredMessages_Click(object sender, EventArgs e)
        {
            var queryAccess = (from UA in db.UserAccesses where UA.UAccessUserID == PublicVariable.global_UserID where UA.UAccessSPartID == 17 select UA).ToList();
            if (queryAccess.Count == 0)
            {
                MessageBox.Show("شما به اين بخش دسترسي نداريد", "دسترسي ممنوع");
                return;
            }

            CloseForms();

            formNumber = 11;

            userSentReference = new frmUserSentReferenceLetters();
            userSentReference.MdiParent = this;
            userSentReference.Show();
        }

        private void lbl_Following_Click(object sender, EventArgs e)
        {
            var queryAccess = (from UA in db.UserAccesses where UA.UAccessUserID == PublicVariable.global_UserID where UA.UAccessSPartID == 15 select UA).ToList();
            if (queryAccess.Count == 0)
            {
                MessageBox.Show("شما به اين بخش دسترسي نداريد", "دسترسي ممنوع");
                return;
            }

            CloseForms();

            formNumber = 9;

            userFollowingLetters = new frmUserFollowingLetters();
            userFollowingLetters.MdiParent = this;
            userFollowingLetters.Show();
        }

        private void frmMainUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Sp_Update_ExitDate(PublicVariable.global_UserID, PublicVariable.todayDate + "-" + string.Format("{0:HH:mm:ss}", Convert.ToDateTime(pCalender.GetHour(DateTime.Now).ToString() + ":" + pCalender.GetMinute(DateTime.Now).ToString() + ":" + pCalender.GetSecond(DateTime.Now).ToString())));
            db.SaveChanges();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //Letters Message check
            var queryCheckMessage = (from RR in db.Vw_ReciveLetter where RR.SentUserID == PublicVariable.global_UserID where RR.SentMessage == 1 select RR).ToList();
            if (queryCheckMessage.Count > 0)
            {
                timer.Stop();

                frmUserNewMessage newMessage = new frmUserNewMessage();

                newMessage.val_MessageTitle.Text = $"كاربر {PublicVariable.global_UserFristName} {PublicVariable.global_UserLastName} يك پيام جديد داريد!";
                newMessage.val_MessageContext.Text = $"شما تعداد {queryCheckMessage.Count.ToString()} پيغام خوانده نشده داريد، در اسراع وقت مشاهده كنيد";
                newMessage.letType = 1;
                newMessage.ShowDialog();

                lbl_AllRecivedMessages.Text = $"همه نامه‌هاي وارده ({queryCheckMessage.Count})";
            }

            //Reference Message check
            var queryCheckRefMessage = (from RRe in db.Vw_ReciveReference where RRe.RefReciverUserID == PublicVariable.global_UserID where RRe.RefMessage == 1 select RRe).ToList();
            if (queryCheckRefMessage.Count > 0)
            {
                timer.Stop();

                frmUserNewMessage newMessage = new frmUserNewMessage();

                newMessage.val_MessageTitle.Text = $"كاربر {PublicVariable.global_UserFristName} {PublicVariable.global_UserLastName} يك ارجاع جديد داريد!";
                newMessage.val_MessageContext.Text = $"شما تعداد {queryCheckMessage.Count.ToString()} پيغام مرجوعه خوانده نشده داريد، در اسراع وقت مطالعه كنيد";
                newMessage.letType = 2;
                newMessage.ShowDialog();

                lbl_ShowGetReferenceLetters.Text = $"نامه‌هاي مرجوعه وارده ({queryCheckRefMessage.Count})";
            }

            //News Get check
            var queryGetNews = (from N in db.News where N.NewsDate == PublicVariable.todayDate select N).ToList();
            if (queryGetNews.Count > 0)
            {
                lbl_News.Text = queryGetNews.Count.ToString();
                lbl_NewsAndAnnouncement.Text = $"اخبار و اطلاعيه‌ها ({queryGetNews.Count})";
                lbl_News.Visible = true;
            }

            timer.Start();
        }

        private void lbl_DailyFunction_Click(object sender, EventArgs e)
        {
            var queryAccess = (from UA in db.UserAccesses where UA.UAccessUserID == PublicVariable.global_UserID where UA.UAccessSPartID == 24 select UA).ToList();
            if (queryAccess.Count == 0)
            {
                MessageBox.Show("شما به اين بخش دسترسي نداريد", "دسترسي ممنوع");
                return;
            }

            CloseForms();

            formNumber = 50;

            userDailyFunction = new frmUserDailyFunction();
            userDailyFunction.MdiParent = this;
            userDailyFunction.Show();
        }

        private void lbl_ShowPersonelsFunctions_Click(object sender, EventArgs e)
        {
            var queryAccess = (from UA in db.UserAccesses where UA.UAccessUserID == PublicVariable.global_UserID where UA.UAccessSPartID == 25 select UA).ToList();
            if (queryAccess.Count == 0)
            {
                MessageBox.Show("شما به اين بخش دسترسي نداريد", "دسترسي ممنوع");
                return;
            }

            CloseForms();

            formNumber = 60;

            userPersonelsFunctions = new frmUserShowPersonelsFunction();
            userPersonelsFunctions.MdiParent = this;
            userPersonelsFunctions.userJobName = val_Job.Text.Trim();
            userPersonelsFunctions.userJobID = userMainJobID;
            userPersonelsFunctions.Show();
        }

        private void lbl_UpdatePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUserUpdatePassword userUpdatePass = new frmUserUpdatePassword();
            userUpdatePass.ShowDialog();
        }

        private void lbl_Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void lbl_RequestSupport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUserRequestSupport requestSupport = new frmUserRequestSupport();
            requestSupport.ShowDialog();
        }
    }
}
