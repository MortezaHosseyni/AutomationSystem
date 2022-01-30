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
    public partial class frmJobsHistory : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public int Get_UserID { get; set; }
        public frmJobsHistory()
        {
            InitializeComponent();
        }

        private void frmJobsHistory_Load(object sender, EventArgs e)
        {
            ShowUsers();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowUsers()
        {
            var query = db.Database.SqlQuery<Vw_AsignmentJobs>("SELECT * FROM Vw_AsignmentJobs WHERE AsignUserID = " + this.Get_UserID);
            var result = query.ToList();

            if (result.Count != 0)
            {
                dgv_UserJobHistory.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_UserJobHistory.Rows[i].Cells["col_AsignJobID"].Value = result[i].AsignJobID;

                    dgv_UserJobHistory.Rows[i].Cells["col_FullName"].Value = result[i].UserFullName;
                    dgv_UserJobHistory.Rows[i].Cells["col_JobName"].Value = result[i].JobsName;
                    dgv_UserJobHistory.Rows[i].Cells["col_AsignStatus"].Value = result[i].AsignStatusView;
                    dgv_UserJobHistory.Rows[i].Cells["col_AsignAsigntedDate"].Value = result[i].AsignAsigntedDate;
                    dgv_UserJobHistory.Rows[i].Cells["col_AsignDismissalDate"].Value = result[i].AsignDismissalDate;
                }
            }
            else
            {
                dgv_UserJobHistory.Rows.Clear();
            }
        }

        private void btn_AsignmentJob_Click(object sender, EventArgs e)
        {
            var queryCheckUserAsıgn = (from UserJ in db.AsignmentJobs where UserJ.AsignUserID == this.Get_UserID where UserJ.AsignStatus == 1 select UserJ).ToList();
            if (queryCheckUserAsıgn.Count > 0)
            {
                MessageBox.Show($"كاربر {lbl_UserFristAndLastName.Text} داري شغل ميباشد، براي انتساب شغل جديد بايد از شغل قبلي عزل شود","انتساب شغل");
            }
            else
            {
                frmAsignJob asignJobForm = new frmAsignJob();

                asignJobForm.Get_UserIDToAsignJob = this.Get_UserID;
                asignJobForm.val_AsignJobOn.Text = lbl_UserFristAndLastName.Text;
                asignJobForm.ShowDialog();
            }
        }
    }
}
