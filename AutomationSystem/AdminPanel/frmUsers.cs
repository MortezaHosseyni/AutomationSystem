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
    public partial class frmUsers : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            ShowUsers();
        }

        private void ShowUsers()
        {
            var query = db.Database.SqlQuery<Vw_Users>("SELECT * FROM Vw_Users");
            var result = query.ToList();

            if (result.Count != 0)
            {
                dgv_Users.RowCount = result.Count;
                for (int i = 0; i <= result.Count-1; i++)
                {
                    dgv_Users.Rows[i].Cells["col_UserID"].Value = result[i].UserID;

                    dgv_Users.Rows[i].Cells["col_UserFristName"].Value = result[i].UserFirstName;
                    dgv_Users.Rows[i].Cells["col_UserLastName"].Value = result[i].UserLastName;
                    dgv_Users.Rows[i].Cells["col_UserPersonalCode"].Value = result[i].UserPersonalID;
                    dgv_Users.Rows[i].Cells["col_UserEmail"].Value = result[i].UserEmail;
                    dgv_Users.Rows[i].Cells["col_UserGender"].Value = result[i].UserGender;
                    dgv_Users.Rows[i].Cells["col_UserStatus"].Value = result[i].UserActivity;
                    dgv_Users.Rows[i].Cells["col_UserTel"].Value = result[i].UserTel;
                    dgv_Users.Rows[i].Cells["col_UserBrithDay"].Value = result[i].UserBrithDate;
                    dgv_Users.Rows[i].Cells["col_UserRegisteredDate"].Value = result[i].UserRegisteredDate;
                }
            }
            else
            {
                MessageBox.Show("DB Error");
                dgv_Users.Rows.Clear();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
