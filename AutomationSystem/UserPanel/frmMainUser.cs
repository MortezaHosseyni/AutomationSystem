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
            var query = db.Sp_ShowAllUserInfo_UserForm(PublicVariable.global_UserID).ToList();

            if (query.Count == 1)
            {
                val_Name.Text = query[0].UserFirstName;
                val_LastName.Text = query[0].UserLastName;
                val_PersonalCode.Text = query[0].UserPersonalID;
                val_BrithDate.Text = query[0].UserBrithDate;
                val_Gender.Text = query[0].UserGender;
                val_Job.Text = query[0].JobsName;
                val_AllReciveMessages.Text = "24";
                val_AllSendedMessages.Text = "38";
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
            if (formNumber == 7)
            {
                userReminderForm.Close();
            }
            if (formNumber == 14)
            {
                addReminderForm.Close();
            }
            if (formNumber == 15)
            {
                userDraftForm.Close();
            }
            if (formNumber == 12)
            {
                userAddLetterForm.Close();
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
            userAddLetterForm.MdiParent = this;
            userAddLetterForm.Show();
        }
    }
}
