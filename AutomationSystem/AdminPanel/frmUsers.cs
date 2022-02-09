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
    public partial class frmUsers : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        PersianCalendar pCalender = new PersianCalendar();
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            ShowUsers(CreateSearchString());
        }

        private void ShowUsers(string searchStatemant)
        {
            var query = db.Database.SqlQuery<Vw_Users>("SELECT * FROM Vw_Users WHERE 1=1" + searchStatemant);
            var result = query.ToList();

            if (result.Count != 0)
            {
                dgv_Users.RowCount = result.Count;
                for (int i = 0; i <= result.Count-1; i++)
                {
                    dgv_Users.Rows[i].Cells["col_UserID"].Value = result[i].UserID;

                    dgv_Users.Rows[i].Cells["col_UserFristName"].Value = result[i].UserFirstName;
                    dgv_Users.Rows[i].Cells["col_UserLastName"].Value = result[i].UserLastName;
                    dgv_Users.Rows[i].Cells["col_UserName"].Value = result[i].UserName;
                    dgv_Users.Rows[i].Cells["col_UserPersonalCode"].Value = result[i].UserPersonalID;
                    dgv_Users.Rows[i].Cells["col_UserEmail"].Value = result[i].UserEmail;
                    dgv_Users.Rows[i].Cells["col_UserGender"].Value = result[i].UserGender;
                    dgv_Users.Rows[i].Cells["col_UserGenderCode"].Value = result[i].UserGender;
                    dgv_Users.Rows[i].Cells["col_UserStatus"].Value = result[i].UserActivity;
                    dgv_Users.Rows[i].Cells["col_UserTel"].Value = result[i].UserTel;
                    dgv_Users.Rows[i].Cells["col_UserBrithDay"].Value = result[i].UserBrithDate;
                    dgv_Users.Rows[i].Cells["col_UserRegisteredDate"].Value = result[i].UserRegisteredDate;
                    
                }
            }
            else
            {
                dgv_Users.Rows.Clear();
            }
        }

        private string CreateSearchString()
        {
            string searchString = "";
            if (txt_Name.Text != "")
            {
                searchString += " AND UserFirstName LIKE '%" + txt_Name.Text.Trim() + "%'";
            }
            if (txt_LastName.Text != "")
            {
                searchString += " AND UserLastName LIKE '%" + txt_LastName.Text.Trim() + "%'";
            }

            if (rbt_ActiveStatus.Checked)
            {
                searchString += " AND UserActivity = 'فعال'";
            }
            if (rbt_DeActiveStatus.Checked)
            {
                searchString += " AND UserActivity = 'غيرفعال'";
            }

            if (rbt_ManGender.Checked)
            {
                searchString += " AND UserGender = 'مرد'";
            }
            if (rbt_WomanGender.Checked)
            {
                searchString += " AND UserGender = 'زن'";
            }

            return searchString;
        } 

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ShowUsers(CreateSearchString());
        }

        private void btn_NewUser_Click(object sender, EventArgs e)
        {
            frmUserManager userManagerForm = new frmUserManager();
            userManagerForm.formType = 1; //Add User
            userManagerForm.ShowDialog();
            ShowUsers(CreateSearchString());
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            int itemSelected = dgv_Users.SelectedCells.Count;
            if (itemSelected > 0)
            {
                frmUserManager userManagerForm = new frmUserManager();
                userManagerForm.formType = 2; //Edit User
                userManagerForm.userID = Convert.ToInt32(dgv_Users.CurrentRow.Cells["col_UserID"].Value);
                userManagerForm.userFirstName = dgv_Users.CurrentRow.Cells["col_UserFristName"].Value.ToString();
                userManagerForm.userLastName = dgv_Users.CurrentRow.Cells["col_UserLastName"].Value.ToString();
                userManagerForm.userName = dgv_Users.CurrentRow.Cells["col_UserName"].Value.ToString();
                userManagerForm.userPassword = "**********";
                userManagerForm.userEmail = dgv_Users.CurrentRow.Cells["col_UserEmail"].Value.ToString();
                userManagerForm.userTel = dgv_Users.CurrentRow.Cells["col_UserTel"].Value.ToString();
                userManagerForm.userPersonalCode = dgv_Users.CurrentRow.Cells["col_UserPersonalCode"].Value.ToString();
                userManagerForm.userBrithDate = dgv_Users.CurrentRow.Cells["col_UserBrithDay"].Value.ToString();
                userManagerForm.userGender = dgv_Users.CurrentRow.Cells["col_UserGender"].Value.ToString();
                userManagerForm.userRegisterDate = dgv_Users.CurrentRow.Cells["col_UserRegisteredDate"].Value.ToString();
                
                userManagerForm.ShowDialog();
                ShowUsers(CreateSearchString());
            }
            else
            {
                MessageBox.Show("لطفا يك كاربر جهت ويرايش انتخاب كنيد","ويرايش كاربر");
            }
        }

        private void btn_DeactiveUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"از غيرفعال كردن كاربر {dgv_Users.CurrentRow.Cells["col_UserFristName"].Value.ToString()} {dgv_Users.CurrentRow.Cells["col_UserLastName"].Value.ToString()} مطمعن هستيد؟","غيرفعالسازي كاربر",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int getUserID = Convert.ToInt32(dgv_Users.CurrentRow.Cells["col_UserID"].Value);
                    var queryDisableUser = (from U in db.Users where U.UserID == getUserID select U).SingleOrDefault();
                    queryDisableUser.UserActivity = 2;

                    db.SaveChanges();
                    ShowUsers(CreateSearchString());
                }
                catch (Exception)
                {
                    MessageBox.Show("هنگام ارتباط با سرور خطايي رخ داد","پايگاه داده");
                    return;
                }
            }
            else
            {
                return;
            }
        }
        private void cms_EnableCurrentUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"از فعال كردن كاربر {dgv_Users.CurrentRow.Cells["col_UserFristName"].Value.ToString()} {dgv_Users.CurrentRow.Cells["col_UserLastName"].Value.ToString()} مطمعن هستيد؟", "فعالسازي كاربر", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int getUserID = Convert.ToInt32(dgv_Users.CurrentRow.Cells["col_UserID"].Value);
                    var queryDisableUser = (from U in db.Users where U.UserID == getUserID select U).SingleOrDefault();
                    queryDisableUser.UserActivity = 1;

                    db.SaveChanges();
                    ShowUsers(CreateSearchString());

                    MessageBox.Show("كاربر با موفقيت فعال شد", "كاربران");
                }
                catch (Exception)
                {
                    MessageBox.Show("هنگام ارتباط با سرور خطايي رخ داد", "پايگاه داده");
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void dgv_Users_DoubleClick(object sender, EventArgs e)
        {
            frmUserInfo formUserInfo = new frmUserInfo();
            formUserInfo.Get_UserID = Convert.ToInt32(dgv_Users.CurrentRow.Cells["col_UserID"].Value);
            formUserInfo.ShowDialog();
        }

        private void cms_UpdateUserPassword_Click(object sender, EventArgs e)
        {
            frmUpdatePassword userUpdatePass = new frmUpdatePassword();
            userUpdatePass.lbl_Title.Text = $"تغيير گذرواژه كاربر {dgv_Users.CurrentRow.Cells["col_UserFristName"].Value.ToString()} {dgv_Users.CurrentRow.Cells["col_UserLastName"].Value.ToString()}";
            userUpdatePass.getUserID = Convert.ToInt32(dgv_Users.CurrentRow.Cells["col_UserID"].Value);
            userUpdatePass.ShowDialog();
        }
    }
}
