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
using System.Globalization;
using System.Net;

namespace AutomationSystem.AdminPanel
{
    public partial class frmAdmin : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        PersianCalendar pCalender = new PersianCalendar();
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            txt_RemindDateTo.Value = DateTime.Now.AddDays(1);

            Reminder(searchCondition());

            //Date&Time
            lbl_DateValue.Text = PublicVariable.todayDate;
            timer.Enabled = true;

            //IP
            string pcName = Environment.MachineName;
            IPHostEntry ipe = Dns.GetHostByName(pcName);
            IPAddress[] ipAdresses = ipe.AddressList;
            lbl_YourIPValue.Text = ipAdresses[0].ToString();

            //ActiveUsers
            var queryActiveUsers = (from U in db.Users where U.UserActivity == 1 select U).ToList();
            lbl_AllActiveUsersValue.Text = queryActiveUsers.Count.ToString();

            //LastLogin
            var queryLastLogin = db.Database.SqlQuery<UserLog>("SELECT TOP 1 * FROM UserLog WHERE LogUserID = 1 AND LogUserExitDate IS NOT NULL ORDER BY LogID DESC");
            var resultLastLogin = queryLastLogin.ToList();
            if (resultLastLogin.Count > 0)
            {
                lbl_LastLoginValue.Text = resultLastLogin[0].LogUserEnterDate;
            }

            //OnlineUsers
            var queryOnlineUsers = db.Database.SqlQuery<UserLog>($"SELECT DISTINCT LogUserID, 1 AS LogID, '1' AS LogUserPcName, '1' AS LogUserIPAddress, '1' AS LogUserEnterDate, '1' AS LogUserExitDate FROM UserLog WHERE LogUserExitDate IS NULL AND LEFT(LogUserEnterDate, 10) = '{PublicVariable.todayDate}'");
            var resultOnlineUsers = queryOnlineUsers.ToList();
            if (resultOnlineUsers.Count > 0)
            {
                lbl_OnlineUsersValue.Text = resultOnlineUsers.Count.ToString();
            }

            //RecivedRequests
            var queryRecivedSup = db.Database.SqlQuery<Vw_Supports>($"SELECT * FROM Vw_Supports WHERE SupDate = '{PublicVariable.todayDate}'").ToList();
            lbl_ForSupportValue.Text = queryRecivedSup.Count.ToString();

            //RefreshDB
            timer_RefreshDB.Enabled = true;
        }
        private void Reminder(string searchRemind)
        {
            var query = db.Database.SqlQuery<Vw_Reminder>("SELECT * FROM Vw_Reminder WHERE 1=1" + searchRemind);
            var result = query.ToList();

            if (result.Count != 0)
            {
                dgv_Reminder.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_Reminder.Rows[i].Cells["col_RemindSubject"].Value = result[i].RemindSubject;
                    dgv_Reminder.Rows[i].Cells["col_RemindCaption"].Value = result[i].RemindCaption;
                    dgv_Reminder.Rows[i].Cells["col_RemindCreatedDate"].Value = result[i].RemindCreatedDate;
                    dgv_Reminder.Rows[i].Cells["col_RemindRememberDate"].Value = result[i].RemindRememberDate;
                    dgv_Reminder.Rows[i].Cells["col_RemindRead"].Value = result[i].RemindRead;

                    dgv_Reminder.Rows[i].Cells["col_RemindID"].Value = result[i].RemindID;
                    dgv_Reminder.Rows[i].Cells["col_Readed"].Value = result[i].RemindIsRead;


                    if (Convert.ToInt16(dgv_Reminder.Rows[i].Cells["col_Readed"].Value) == 1)
                    {
                        dgv_Reminder.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                    }
                    else
                    {
                        dgv_Reminder.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
            }
            else
            {
                dgv_Reminder.Rows.Clear();
            }
        }

        private string searchCondition() {
            string dateIn = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_RemindDateIn.Value.Year.ToString()}/{txt_RemindDateIn.Value.Month.ToString()}/{txt_RemindDateIn.Value.Day.ToString()}"));
            string dateTo = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_RemindDateTo.Value.Year.ToString()}/{txt_RemindDateTo.Value.Month.ToString()}/{txt_RemindDateTo.Value.Day.ToString()}"));
            

            string searchString = $" AND RemindRememberDate BETWEEN '{dateIn}' AND '{dateTo}'";

            if (txt_RemindSubjectSearch.Text != "")
            {
                searchString += $" AND RemindSubject LIKE '%{txt_RemindSubjectSearch.Text}%'";
            }

            return searchString;
        }
        private void btn_Users_Click(object sender, EventArgs e)
        {
            frmUsers usersForm = new frmUsers();
            usersForm.ShowDialog();
        }

        private void btn_RemindSearch_Click(object sender, EventArgs e)
        {
            Reminder(searchCondition());
        }

        private void dgv_Reminder_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(dgv_Reminder.CurrentRow.Cells["col_RemindCaption"].Value.ToString(),dgv_Reminder.CurrentRow.Cells["col_RemindSubject"].Value.ToString());

            try
            {
                int currentRemindID = Convert.ToInt32(dgv_Reminder.CurrentRow.Cells["col_RemindID"].Value);

                var updateQuery = (from R in db.Reminders where R.RemindID == currentRemindID select R).SingleOrDefault();
                updateQuery.RemindIsRead = 2;
                db.SaveChanges();

                Reminder(searchCondition());
            }
            catch (Exception)
            {
                MessageBox.Show("در نمايش اطلاعات مشكلي رخ داد","پايگاه داده");
                throw;
            }
        }

        private void btn_Reminder_Click(object sender, EventArgs e)
        {
            frmReminder reminderForm = new frmReminder();
            reminderForm.ShowDialog();

            Reminder(searchCondition());
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Sp_Update_ExitDate(PublicVariable.global_UserID, PublicVariable.todayDate + "-" + string.Format("{0:HH:mm:ss}", Convert.ToDateTime(pCalender.GetHour(DateTime.Now).ToString() + ":" + pCalender.GetMinute(DateTime.Now).ToString() + ":" + pCalender.GetSecond(DateTime.Now).ToString())));
            db.SaveChanges();
        }

        private void btn_UsersLog_Click(object sender, EventArgs e)
        {
            frmUsersLog usersLogForm = new frmUsersLog();
            usersLogForm.ShowDialog();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbl_TimeValue.Text = string.Format("{0:HH:mm:ss}",Convert.ToDateTime( pCalender.GetHour(DateTime.Now).ToString() + ":" + pCalender.GetMinute(DateTime.Now).ToString() + ":" + pCalender.GetSecond(DateTime.Now).ToString()));
        }

        private void btn_Jobs_Click(object sender, EventArgs e)
        {
            frmJobs jobsForm = new frmJobs();
            jobsForm.ShowDialog();
        }

        private void btn_AssignmentJob_Click(object sender, EventArgs e)
        {
            frmAsignmentJob asignmentJob = new frmAsignmentJob();

            asignmentJob.formType = 1;
            asignmentJob.ShowDialog();
        }

        private void btn_Messenger_Click(object sender, EventArgs e)
        {
            frmAddNewsAndAnnouncement newsAndAnnouncement = new frmAddNewsAndAnnouncement();
            newsAndAnnouncement.ShowDialog();
        }

        private void btn_SystemComponents_Click(object sender, EventArgs e)
        {
            frmSystemComponents systemParts = new frmSystemComponents();
            systemParts.ShowDialog();
        }

        private void btn_AccessRight_Click(object sender, EventArgs e)
        {
            frmAsignmentJob userAccessRights = new frmAsignmentJob();

            userAccessRights.formType = 2;
            userAccessRights.lbl_Title.Text = "سطوح دسترسي";
            userAccessRights.btn_JobsHistory.Text = "تايين دسترسي";
            userAccessRights.ShowDialog();
        }

        private void lbl_ForSupportValue_Click(object sender, EventArgs e)
        {
            frmReciveSupRequests reciveRequestes = new frmReciveSupRequests();
            reciveRequestes.ShowDialog();
        }

        private void timer_RefreshDB_Tick(object sender, EventArgs e)
        {
            timer_RefreshDB.Stop();
            frmAdmin_Load(sender, e);
            timer_RefreshDB.Start();
        }

        private void frmAdmin_Activated(object sender, EventArgs e)
        {
            frmAdmin_Load(sender, e);
        }
    }
}
