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
            frmAsignJob asignJobForm = new frmAsignJob();

            asignJobForm.ShowDialog();
        }
    }
}
