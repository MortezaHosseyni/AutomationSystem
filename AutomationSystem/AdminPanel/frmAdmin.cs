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
    }
}
