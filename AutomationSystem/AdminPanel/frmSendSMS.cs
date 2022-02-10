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

namespace AutomationSystem.AdminPanel
{
    public partial class frmSendSMS : Form
    {
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
    }
}
