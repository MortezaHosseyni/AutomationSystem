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

namespace AutomationSystem.AdminPanel
{
    public partial class frmAdmin : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            Reminder();
        }
        private void Reminder()
        {
            var query = db.Database.SqlQuery<Vw_Reminder>("SELECT * FROM Vw_Reminder WHERE 1=1");
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
                }
            }
            else
            {
                dgv_Reminder.Rows.Clear();
            }
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            frmUsers usersForm = new frmUsers();
            usersForm.Show();
        }
    }
}
