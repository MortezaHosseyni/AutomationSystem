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
    public partial class frmAsignmentJob : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmAsignmentJob()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAsignmentJob_Load(object sender, EventArgs e)
        {
            ShowUsers(CreateSearchString());
        }

        private void ShowUsers(string searchStatemant)
        {
            var query = db.Database.SqlQuery<Vw_Users>("SELECT * FROM Vw_Users WHERE 1=1" + searchStatemant);
            var result = query.ToList();

            if (result.Count != 0)
            {
                dgv_UsersList.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_UsersList.Rows[i].Cells["col_UserID"].Value = result[i].UserID;

                    dgv_UsersList.Rows[i].Cells["col_FristName"].Value = result[i].UserFirstName;
                    dgv_UsersList.Rows[i].Cells["col_LastName"].Value = result[i].UserLastName;
                    dgv_UsersList.Rows[i].Cells["col_PersonalCode"].Value = result[i].UserPersonalID;
                    dgv_UsersList.Rows[i].Cells["col_Gender"].Value = result[i].View_UserGender;
                    dgv_UsersList.Rows[i].Cells["col_Activity"].Value = result[i].View_UserActivity;
                }
            }
            else
            {
                dgv_UsersList.Rows.Clear();
            }
        }
        private string CreateSearchString()
        {
            string searchString = "";
            if (txt_SearchName.Text != "")
            {
                searchString += " AND UserFirstName LIKE '%" + txt_SearchName.Text.Trim() + "%'";
            }

            if (txt_SearchLastName.Text != "")
            {
                searchString += " AND UserLastName LIKE '%" + txt_SearchLastName.Text.Trim() + "%'";
            }

            if (txt_SearchPersonalCode.Text != "")
            {
                searchString += " AND UserPersonalID LIKE '%" + txt_SearchPersonalCode.Text.Trim() + "%'";
            }

            return searchString;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ShowUsers(CreateSearchString());
        }

        private void btn_JobsHistory_Click(object sender, EventArgs e)
        {
            if (dgv_UsersList.SelectedCells.Count > 0)
            {
                frmJobsHistory jobsHistoryForm = new frmJobsHistory();

                jobsHistoryForm.Get_UserID = Convert.ToInt32(dgv_UsersList.CurrentRow.Cells["col_UserID"].Value);
                jobsHistoryForm.lbl_UserFristAndLastName.Text = dgv_UsersList.CurrentRow.Cells["col_FristName"].Value + " " + dgv_UsersList.CurrentRow.Cells["col_LastName"].Value;
                jobsHistoryForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("براي مشاهده ليست لطفا يك كاربر انتخاب كنيد","تاريخچه مشاغل");
                return;
            }
        }
    }
}
