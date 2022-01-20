using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationSystem.Moduls;
using System.Windows.Forms;
using System.Globalization;
using System.Net;

namespace AutomationSystem
{
    public partial class frmLogin : Form
    {
        PersianCalendar pCalender = new PersianCalendar();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "muro" && txt_Password.Text == "9889" && rdb_Admin.Checked)
            {
                AdminPanel.frmAdmin adminForm = new AdminPanel.frmAdmin();
                this.Hide();
                adminForm.Show();
            }
            else
            {
                MessageBox.Show("اطلاعات وارد شده اشتباه است");
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
            lbl_TimeValue.Text = pCalender.GetHour(DateTime.Now).ToString() + ":" + pCalender.GetMinute(DateTime.Now).ToString() + ":" + pCalender.GetSecond(DateTime.Now).ToString(); ;
        }
    }
}
