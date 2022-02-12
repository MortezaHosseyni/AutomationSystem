using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomationSystem.SendMessageWebService;
using DataModelLayer.Models;

namespace AutomationSystem.AdminPanel
{
    public partial class frmSendSMS : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmSendSMS()
        {
            InitializeComponent();
        }

        private void btn_GetLineInfo_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("فيلدهاي خالي را پر كنيد","اطلاعات خط");
                return;
            }
            SendReceive ws = new SendReceive();
            string message = string.Empty;
            var smsLine = ws.GetSMSLines(txt_Username.Text, txt_Password.Text, ref message);

            dgv_GetLineInfo.DataSource = smsLine;

            dgv_GetLineInfo.Columns[0].HeaderText = "آي‌دي خط";
            dgv_GetLineInfo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_GetLineInfo.Columns[1].HeaderText = "شماره خط";
            dgv_GetLineInfo.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgv_GetLineInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            val_LineNumber.Text = dgv_GetLineInfo.CurrentRow.Cells["LineNumber"].Value.ToString();
        }

        private void ShowUsers()
        {
            var query = db.Database.SqlQuery<Vw_Users>("SELECT * FROM Vw_Users");
            var result = query.ToList();

            if (result.Count != 0)
            {
                dgv_Users.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_Users.Rows[i].Cells["col_UserID"].Value = result[i].UserID;

                    dgv_Users.Rows[i].Cells["col_UserFristName"].Value = result[i].UserFirstName;
                    dgv_Users.Rows[i].Cells["col_UserLastName"].Value = result[i].UserLastName;
                    dgv_Users.Rows[i].Cells["col_UserName"].Value = result[i].UserName;
                    dgv_Users.Rows[i].Cells["col_UserGenderCode"].Value = result[i].UserGender;
                    dgv_Users.Rows[i].Cells["col_UserStatus"].Value = result[i].UserActivity;
                    dgv_Users.Rows[i].Cells["col_UserTel"].Value = result[i].UserTel;
                    dgv_Users.Rows[i].Cells["col_UserRegisteredDate"].Value = result[i].UserRegisteredDate;
                }
            }
            else
            {
                dgv_Users.Rows.Clear();
            }
        }

        private void frmSendSMS_Load(object sender, EventArgs e)
        {
            ShowUsers();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
