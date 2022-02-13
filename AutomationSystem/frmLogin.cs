using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationSystem.Moduls;
using DataModelLayer.Models;
using System.Windows.Forms;
using System.Globalization;
using System.Net;
using System.Security.Cryptography;
using AutomationSystem.AdminPanel;

namespace AutomationSystem
{
    public partial class frmLogin : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        PersianCalendar pCalender = new PersianCalendar();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (txt_Username.Text.Trim() != "" && txt_Password.Text.Trim() != "")
                {
                    //Hashing Password
                    SHA256CryptoServiceProvider SHA256 = new SHA256CryptoServiceProvider();
                    Byte[] B1;
                    Byte[] B2;
                    B1 = UTF8Encoding.UTF8.GetBytes(txt_Password.Text.Trim());
                    B2 = SHA256.ComputeHash(B1);
                    string hashedPass = BitConverter.ToString(B2);

                    var loginQuery = (from U in db.Users
                                      where U.UserName == txt_Username.Text.Trim()
                                      where U.UserPassword == hashedPass
                                      where U.UserActivity == 1
                                      select U).ToList();
                    if (loginQuery.Count == 1)
                    {
                        PublicVariable.global_UserFristName = loginQuery[0].UserFirstName;
                        PublicVariable.global_UserLastName = loginQuery[0].UserLastName;
                        PublicVariable.global_UserID = loginQuery[0].UserID;

                        UserLog UL = new UserLog();
                        string pcName = Environment.MachineName;
                        UL.LogUserPcName = pcName;
                        UL.LogUserIPAddress = lbl_YourIPValue.Text.Trim();
                        UL.LogUserEnterDate = lbl_DateValue.Text + "-" + string.Format("{0:HH:mm:ss}", Convert.ToDateTime(pCalender.GetHour(DateTime.Now).ToString() + ":" + pCalender.GetMinute(DateTime.Now).ToString() + ":" + pCalender.GetSecond(DateTime.Now).ToString()));
                        UL.LogUserID = PublicVariable.global_UserID;

                        db.UserLogs.Add(UL);
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("اطلاعات وارد شده را بررسي كرده و دوباره امتحان كنيد", "خطا هنگام ورود");
                        return;
                    }
                    if (rdb_Admin.Checked)
                    {
                        if (loginQuery[0].UserName == "admin")
                        {
                            PublicVariable.global_UserType = 1; //admin
                        }
                        else
                        {
                            MessageBox.Show("اطلاعات وارد شده را بررسي كرده و دوباره امتحان كنيد", "خطا هنگام ورود");
                            return;
                        }
                    }
                    else
                    {
                        PublicVariable.global_UserType = 2; //user
                    }
                    this.Close();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("خطايي در دريافت اطلاعات رخ داد","پايگاه داده");
                throw;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //Date&Time
            string pDate = String.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime(pCalender.GetYear(DateTime.Now).ToString() + "/" + pCalender.GetMonth(DateTime.Now).ToString() + "/" + pCalender.GetDayOfMonth(DateTime.Now).ToString()));
            PublicVariable.todayDate = pDate;
            lbl_DateValue.Text = pDate;
            timer.Enabled = true;

            //IP
            string pcName = Environment.MachineName;
            IPHostEntry ipe = Dns.GetHostByName(pcName);
            IPAddress[] ipAdresses = ipe.AddressList;

            lbl_YourIPValue.Text = ipAdresses[0].ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbl_TimeValue.Text = string.Format("{0:HH:mm:ss}", Convert.ToDateTime(pCalender.GetHour(DateTime.Now).ToString() + ":" + pCalender.GetMinute(DateTime.Now).ToString() + ":" + pCalender.GetSecond(DateTime.Now).ToString()));
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("طراح و برنامه‌نويس: مرتضي‌حسيني \nراه ارتباطي: morteza_hoseyni81@yahoo.com \n دانشگاه فني‌حرفه‌اي تبريز","درباره ما");
        }

        private void lbl_ServerSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmServerParameters serverSetting = new frmServerParameters();
            serverSetting.ShowDialog();
        }
    }
}
