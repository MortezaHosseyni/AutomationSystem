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
using AutomationSystem.Moduls;

namespace AutomationSystem.AdminPanel
{
    public partial class frmSendSMS : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities(PublicVariable.mainConnectionString);
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
                    dgv_Users.Rows[i].Cells["col_UserStatus"].Value = result[i].View_UserActivity;
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

        private void txt_SMSContext_TextChanged(object sender, EventArgs e)
        {
            val_CharNumber.Text = txt_SMSContext.Text.Length.ToString();
        }

        private void btn_SendSMS_Click(object sender, EventArgs e)
        {
            try
            {
                int smsLineID = 0;
                List<WebServiceSmsSend> sendDetail = new List<WebServiceSmsSend>();
                {
                    string messageBody = string.Empty;
                    long phoneNumber = 0;
                    bool isFlash = false;

                    foreach (DataGridViewRow dr in dgv_Users.Rows)
                    {
                        DataGridViewCheckBoxCell checking = dr.Cells["col_SelectUser"] as DataGridViewCheckBoxCell;
                        if (Convert.ToBoolean(checking.Value) == true)
                        {
                            messageBody = $"كارمند گرامي {dr.Cells[1].Value.ToString()} {dr.Cells[2].Value.ToString()} \n {txt_SMSContext.Text}";
                            phoneNumber = Convert.ToInt32(dr.Cells[4].Value);

                            sendDetail.Add(new WebServiceSmsSend()
                            {
                                MessageBody = messageBody,
                                MobileNo = phoneNumber,
                                IsFlash = isFlash
                            });
                        }
                    }
                }
                //Check LineID
                if (!int.TryParse(txt_LineSerial.Text, out smsLineID)) throw new Exception("شماره آي‌دي خط معتبر نيست");

                //Send List to WebService
                SendReceive ws = new SendReceive();
                string message = "";
                long[] result = ws.SendMessage(txt_Username.Text.Trim(), txt_Password.Text.Trim(),sendDetail.ToArray(), smsLineID, null, ref message);
                if (!string.IsNullOrWhiteSpace(message)) throw new Exception(message);

                MessageBox.Show("پيام شما با موفقيت ارسال شد","ارسال پيامك");
            }
            catch (Exception)
            {
                MessageBox.Show("خطايي در ارتباط با سرور رخ داد","سرور");
                return;
            }
        }
    }
}
