using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomationSystem.Moduls;
using DataModelLayer.Models;

namespace AutomationSystem.AdminPanel
{
    public partial class frmReminder : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities(PublicVariable.mainConnectionString);
        public frmReminder()
        {
            InitializeComponent();
        }

        private void frmReminder_Load(object sender, EventArgs e)
        {
            lbl_ReminderCreatedDateValue.Text = PublicVariable.todayDate;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Reminder R = new Reminder();

                R.RemindUserID = 1;
                R.RemindSubject = txt_Subject.Text.Trim();
                R.RemindCaption = txt_Caption.Text.Trim();
                R.RemindIsRead = 1;
                R.RemindCreatedDate = lbl_ReminderCreatedDateValue.Text.Trim();
                R.RemindRememberDate = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_ReminderDate.Value.Year}/{txt_ReminderDate.Value.Month}/{txt_ReminderDate.Value.Day}"));

                db.Reminders.Add(R);
                db.SaveChanges();

                MessageBox.Show("يادآورد ذخيره شد","يادآور");

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("هنگام ثبت يادآور خطايي رخ داد","پايگاه داده");
                throw;
            }
        }
    }
}
