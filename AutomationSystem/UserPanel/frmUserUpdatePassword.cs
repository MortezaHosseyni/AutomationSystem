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
using System.Security.Cryptography;

namespace AutomationSystem.UserPanel
{
    public partial class frmUserUpdatePassword : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmUserUpdatePassword()
        {
            InitializeComponent();
        }

        private void frmUserUpdatePassword_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_OldPassword.Text.Trim() == "" || txt_NewPassword.Text.Trim() == "" || txt_ConfirmNewPassword.Text.Trim() == "")
            {
                MessageBox.Show("لطفا فيلد‌هاي خالي را پر كنيد","تغيير گذرواژه");
                return;
            }

            try
            {
                //Check old password
                SHA256CryptoServiceProvider SHA256 = new SHA256CryptoServiceProvider();
                Byte[] B1;
                Byte[] B2;

                B1 = UTF8Encoding.UTF8.GetBytes(txt_OldPassword.Text.Trim());
                B2 = SHA256.ComputeHash(B1);
                string hashedPass = BitConverter.ToString(B2);

                var queryCheckOldPass = (from U in db.Users where U.UserID == PublicVariable.global_UserID where U.UserPassword == hashedPass select U).ToList();
                if (queryCheckOldPass.Count == 0)
                {
                    MessageBox.Show("گذرواژه قبلي صحيح نمي‌باشد", "تغيير گذرواژه");
                    return;
                }
                if (txt_NewPassword.Text.Trim() == txt_ConfirmNewPassword.Text.Trim())
                {
                    //Hashing Password
                    SHA256CryptoServiceProvider newPassSHA256 = new SHA256CryptoServiceProvider();
                    Byte[] newPassB1;
                    Byte[] newPassB2;

                    newPassB1 = UTF8Encoding.UTF8.GetBytes(txt_NewPassword.Text.Trim());
                    newPassB2 = newPassSHA256.ComputeHash(newPassB1);
                    string newhashedPass = BitConverter.ToString(newPassB2);

                    //UpdatePassword
                    var queryUpdatePass = (from U in db.Users where U.UserID == PublicVariable.global_UserID select U).SingleOrDefault();
                    queryUpdatePass.UserPassword = newhashedPass;

                    db.SaveChanges();

                    MessageBox.Show("گذرواژه جديد با موفقيت ثبت شد", "تغيير گذرواژه");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("گذرواژه با تكرار گذرواژه جديد مطابقت ندارد", "تغيير گذرواژه");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("خطايي در خواندن اطلاعات رخ داد", "پايگاه داده");
                return;
            }
        }
    }
}
