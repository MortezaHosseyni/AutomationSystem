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
using System.Security.Cryptography;

namespace AutomationSystem.AdminPanel
{
    public partial class frmUpdatePassword : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public int getUserID { get; set; }
        public frmUpdatePassword()
        {
            InitializeComponent();
        }

        private void frmUpdatePassword_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_NewPassword.Text.Trim() == "" || txt_ConfirmNewPassword.Text.Trim() == "")
            {
                MessageBox.Show("فيلدهاي خالي را پركنيد","تغيير گذرواژه");
                return;
            }
            if (txt_NewPassword.Text.Trim() == txt_ConfirmNewPassword.Text.Trim())
            {
                //Hashing Password
                SHA256CryptoServiceProvider SHA256 = new SHA256CryptoServiceProvider();
                Byte[] B1;
                Byte[] B2;

                B1 = UTF8Encoding.UTF8.GetBytes(txt_NewPassword.Text.Trim());
                B2 = SHA256.ComputeHash(B1);
                string hashedPass = BitConverter.ToString(B2);

                //UpdatePassword
                var queryUpdatePass = (from U in db.Users where U.UserID == this.getUserID select U).SingleOrDefault();
                queryUpdatePass.UserPassword = hashedPass;

                db.SaveChanges();

                MessageBox.Show("گذرواژه جديد با موفقيت ثبت شد", "تغيير گذرواژه");

                this.Close();
            }
            else
            {
                MessageBox.Show("گذرواژه جديد با تكرار گذرواژه جديد مطابقت ندارد", "تغيير گذرواژه");
                return;
            }
        }
    }
}
