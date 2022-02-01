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
    public partial class frmUserChooseLetterSend : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmUserChooseLetterSend()
        {
            InitializeComponent();
        }

        private void frmUserChooseLetterSend_Load(object sender, EventArgs e)
        {
            ShowAllowedUsers(searchCondition());
        }

        private void ShowAllowedUsers(string searchAllowedUser)
        {
            var query = db.Database.SqlQuery<Vw_AsignmentJobs>($"SELECT * FROM Vw_AsignmentJobs WHERE [AsignStatus] = 1 AND [JobsDetermineLevel] >= {PublicVariable.global_JobsDetermineLevel} - 1 {searchAllowedUser} EXCEPT (SELECT * FROM Vw_AsignmentJobs WHERE [AsignUserID] = {PublicVariable.global_UserID})");
            var result = query.ToList();

            if (result.Count != 0)
            {
                dgv_Recivers.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_Recivers.Rows[i].Cells["col_JobUserID"].Value = result[i].AsignJobID;
                    dgv_Recivers.Rows[i].Cells["col_UserID"].Value = result[i].AsignUserID;

                    dgv_Recivers.Rows[i].Cells["col_FullName"].Value = result[i].UserFullName;
                    dgv_Recivers.Rows[i].Cells["col_JobName"].Value = result[i].JobsName;
                }
            }
            else
            {
                dgv_Recivers.Rows.Clear();
            }
        }

        private string searchCondition()
        {
            string searchString = "";

            //Subject Search
            if (txt_SearchFristAndLastName.Text != "")
            {
                searchString += $" AND UserFullName LIKE '%{txt_SearchFristAndLastName.Text}%'";
            }
            
            return searchString;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ShowAllowedUsers(searchCondition());
        }
    }
}
