using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace AutomationSystem.UserPanel
{
    public partial class frmUserSendEmail : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        public frmUserSendEmail()
        {
            InitializeComponent();
        }

        private void frmUserSendEmail_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SendEMail_Click(object sender, EventArgs e)
        {
            login = new NetworkCredential(txt_SenderEmail.Text, txt_SenderPassword.Text);
            client = new SmtpClient(txt_SMTP.Text);
            client.Port = Convert.ToInt32(txt_Port.Text);
            client.EnableSsl = chb_SSL.Checked;
            client.Credentials = login;

            msg = new MailMessage { From = new MailAddress(txt_SenderEmail.Text + txt_SMTP.Text.Replace("smtp.", "@"), "سيستم اتوماسيون اداري", Encoding.UTF8) };
            msg.To.Add(new MailAddress(txt_ReciverEmail.Text));

            if (!string.IsNullOrEmpty(txt_Transcript.Text))
            {
                msg.To.Add(new MailAddress(txt_Transcript.Text));
            }

            msg.Subject = txt_EmailSubject.Text;
            msg.Body = txt_EmailContext.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallBack);

            string userState = "درحال ارسال...";
            client.SendAsync(msg, userState);
        }

        private static void SendCompletedCallBack(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                //MessageBox.Show(string.Format("{0} ارسال ايميل متوقف شد", e.UserState), MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("ارسال ايميل متوقف شد","ارسال ايميل");
            }
            if (e.Error != null)
            {
                MessageBox.Show("خطايي در ارسال ايميل رخ داد", "ارسال ايميل");
            }
            else
            {
                MessageBox.Show("ايميل شما با موفقيت ارسال شد", "ارسال ايميل");
            }
        }
    }
}
