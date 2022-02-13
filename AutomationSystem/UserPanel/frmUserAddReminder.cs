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

namespace AutomationSystem.UserPanel
{
    public partial class frmUserAddReminder : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities(PublicVariable.mainConnectionString);
        public frmUserAddReminder()
        {
            InitializeComponent();
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

                MessageBox.Show("يادآورد ذخيره شد", "يادآور");
            }
            catch (Exception)
            {
                MessageBox.Show("هنگام ثبت يادآور خطايي رخ داد", "پايگاه داده");
                return;
            }
        }

        private void frmUserAddReminder_Load(object sender, EventArgs e)
        {
            lbl_ReminderCreatedDateValue.Text = PublicVariable.todayDate;

            this.Left = 10;
            this.Top = 160;
        }
    }
}
