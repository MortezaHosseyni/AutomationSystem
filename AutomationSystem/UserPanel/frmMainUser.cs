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
        public frmMainUser()
        {
            InitializeComponent();
        }
        private void frmMainUser_Load(object sender, EventArgs e)
        {
            ShowUserInfo();
        }

        private void ShowUserInfo()
        {
            var query = db.Sp_ShowAllUserInfo(PublicVariable.global_UserID).ToList();

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
    }
}
