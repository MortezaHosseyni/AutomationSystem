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
        }

        private void ShowUserInfo()
        {
            var query = db.Sp_ShowAllUserInfo_UserForm_Up(PublicVariable.global_UserID).ToList();

            if (query.Count == 1)
            {
                val_Name.Text = query[0].UserFirstName;
                val_LastName.Text = query[0].UserLastName;
                val_PersonalCode.Text = query[0].UserPersonalID;
                val_BrithDate.Text = query[0].UserBrithDate;
                val_Gender.Text = query[0].View_UserGender;
                val_Job.Text = query[0].JobsName;

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
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            db.Sp_Update_ExitDate(PublicVariable.global_UserID, PublicVariable.todayDate + "-" + string.Format("{0:HH:mm:ss}", Convert.ToDateTime(pCalender.GetHour(DateTime.Now).ToString() + ":" + pCalender.GetMinute(DateTime.Now).ToString() + ":" + pCalender.GetSecond(DateTime.Now).ToString())));
            db.SaveChanges();
            Environment.Exit(0);
        }

        private void lbl_AddReminder_Click_1(object sender, EventArgs e)
        {
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
        }

        private void lbl_ShowNotes_Click(object sender, EventArgs e)
        {
            CloseForms();

            formNumber = 7;

            userReminderForm = new frmUserReminder();
            userReminderForm.Show();
            userReminderForm.MdiParent = this;
        }

        private void lbl_Draft_Click(object sender, EventArgs e)
        {
            CloseForms();

            formNumber = 15;

            userDraftForm = new frmUserDraft(this);
            userDraftForm.MdiParent = this;
            userDraftForm.Show();
        }

        private void lbl_CreateMessage_Click(object sender, EventArgs e)
        {
            CloseForms();

            formNumber = 12;

            userAddLetterForm = new frmUserAddLetter();
            userAddLetterForm.formType = 1;
            userAddLetterForm.MdiParent = this;
            userAddLetterForm.Show();
        }

        private void lbl_AllRecivedMessages_Click(object sender, EventArgs e)
        {
            CloseForms();

            formNumber = 1;

            userReciveAllLettersForm = new frmUserRecivedAllLetters(this);
            userReciveAllLettersForm.MdiParent = this;
            userReciveAllLettersForm.Show();
        }

        private void lbl_SendedMessages_Click(object sender, EventArgs e)
        {
            CloseForms();

            formNumber = 8;

            userSendedLettersForm = new frmUserSendedLetters();
            userSendedLettersForm.MdiParent = this;
            userSendedLettersForm.Show();
        }

        private void lbl_CreateNote_Click(object sender, EventArgs e)
        {
            CloseForms();

            formNumber = 13;

            userCreateNoteForm = new frmUserCreateNote();
            userCreateNoteForm.MdiParent = this;
            userCreateNoteForm.Show();
        }

        private void lbl_SendedNotes_Click(object sender, EventArgs e)
        {
            CloseForms();

            formNumber = 10;

            userShowSentNotes = new frmUserShowSentNotes();
            userShowSentNotes.MdiParent = this;
            userShowSentNotes.Show();
        }

        private void lbl_ArrivedNotes_Click(object sender, EventArgs e)
        {
            CloseForms();

            formNumber = 6;

            userShowReciveNotes = new frmUserShowReciveNotes();
            userShowReciveNotes.MdiParent = this;
            userShowReciveNotes.Show();
        }

        private void lbl_ReadedMessages_Click(object sender, EventArgs e)
        {
            CloseForms();

            formNumber = 2;

            userReadedLettersForm = new frmUserShowReadedLetters();
            userReadedLettersForm.MdiParent = this;
            userReadedLettersForm.Show();
        }

        private void lbl_UnReadedMessages_Click(object sender, EventArgs e)
        {
            CloseForms();

            formNumber = 3;

            userUnReadedLettersForm = new frmUserUnReadLetters();
            userUnReadedLettersForm.MdiParent = this;
            userUnReadedLettersForm.Show();
        }

        private void lbl_UrgentActionMessages_Click(object sender, EventArgs e)
        {
            CloseForms();

            formNumber = 4;

            userImmediateLettersForm = new frmUserImmediateLetters();
            userImmediateLettersForm.MdiParent = this;
            userImmediateLettersForm.Show();
        }

        private void lbl_ConfidentialMessages_Click(object sender, EventArgs e)
        {
            CloseForms();

            formNumber = 5;

            userConfidentialLettersForm = new frmUserConfidentialLetters();
            userConfidentialLettersForm.MdiParent = this;
            userConfidentialLettersForm.Show();
        }

        private void lbl_NewsAndAnnouncement_Click(object sender, EventArgs e)
        {
            CloseForms();

            formNumber = 16;

            userShowNews = new frmUserShowAllNews();
            userShowNews.MdiParent = this;
            userShowNews.Show();
        }

        private void lbl_ShowGetReferenceLetters_Click(object sender, EventArgs e)
        {
            CloseForms();

            formNumber = 17;

            userRecivedReference = new frmUserRecivedReferenceLetters();
            userRecivedReference.MdiParent = this;
            userRecivedReference.Show();
        }

        private void lbl_ReferredMessages_Click(object sender, EventArgs e)
        {
            CloseForms();

            formNumber = 11;

            userSentReference = new frmUserSentReferenceLetters();
            userSentReference.MdiParent = this;
            userSentReference.Show();
        }

        private void lbl_Following_Click(object sender, EventArgs e)
        {
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

        }
    }
}
