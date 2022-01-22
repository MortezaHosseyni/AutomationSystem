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
    public partial class frmUsersLog : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmUsersLog()
        {
            InitializeComponent();
        }

        private void frmUsersLog_Load(object sender, EventArgs e)
        {
            txt_DateIn.Value = DateTime.Now.AddDays(-10);
            ShowUsersLog(logSearchCondition());
        }
        private void ShowUsersLog(string logSearch)
        {
            var query = db.Database.SqlQuery<Vw_UserLog>("SELECT * FROM Vw_UserLog WHERE 1=1" + logSearchCondition());
            var result = query.ToList();

            if (result.Count != 0)
            {
                dgv_UsersLogTable.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_UsersLogTable.Rows[i].Cells["col_LogUserID"].Value = result[i].LogUserID;
                    dgv_UsersLogTable.Rows[i].Cells["col_LogFullName"].Value = result[i].LogFullName;
                    dgv_UsersLogTable.Rows[i].Cells["col_LogComputerName"].Value = result[i].LogUserPcName;
                    dgv_UsersLogTable.Rows[i].Cells["col_LogIPAddress"].Value = result[i].LogUserIPAddress;
                    dgv_UsersLogTable.Rows[i].Cells["col_LogEnterDate"].Value = result[i].LogUserEnterDate;
                    dgv_UsersLogTable.Rows[i].Cells["col_LogExitDate"].Value = result[i].LogUserExitDate;
                }
            }
            else
            {
                dgv_UsersLogTable.Rows.Clear();
            }
        }
        private string logSearchCondition()
        {
            string dateIn = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_DateIn.Value.Year.ToString()}/{txt_DateIn.Value.Month.ToString()}/{txt_DateIn.Value.Day.ToString()}")) + "-" + txt_TimeIn.Value.ToString("{0:HH:mm:ss}");
            string dateTo = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_DateTo.Value.Year.ToString()}/{txt_DateTo.Value.Month.ToString()}/{txt_DateTo.Value.Day.ToString()}")) + "-" + txt_TimeTo.Value.ToString("{0:HH:mm:ss}");


            string searchString = $" AND LogUserEnterDate BETWEEN '{dateIn}' AND '{dateTo}'";

            if (txt_FullName.Text != "")
            {
                searchString += $" AND LogFullName LIKE '%{txt_FullName.Text.Trim()}%'";
            }
            if (txt_UserIPAddress.Text != "")
            {
                searchString += $" AND LogUserIPAddress LIKE '%{txt_UserIPAddress.Text.Trim()}%'";
            }
            if (txt_ComputerName.Text != "")
            {
                searchString += $" AND LogUserPcName LIKE '%{txt_ComputerName.Text.Trim()}%'";
            }

            return searchString;
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ShowUsersLog(logSearchCondition());
        }
    }
}
