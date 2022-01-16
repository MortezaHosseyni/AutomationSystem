using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationSystem.AdminPanel
{
    public partial class frmUserManager : Form
    {
        public frmUserManager()
        {
            InitializeComponent();
        }

        private void pic_UserPic_Click(object sender, EventArgs e)
        {
            openFileDLG.Filter = "Image Files (*.PNG;*.JPG;*.BMP) | *.png;*.jpg;*.bmp";
            openFileDLG.Title = "عكس پرسنلي كاربر";
            openFileDLG.FileName = "PersonalPicture.jpg";

            if (openFileDLG.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pic_UserPic.Image = new Bitmap(openFileDLG.FileName);
            }
        }

        private void pic_UserSignature_Click(object sender, EventArgs e)
        {
            openFileDLG.Filter = "Image Files (*.JPG;*.BMP) | *.jpg;*.bmp";
            openFileDLG.Title = "نمونه امضاء كاربر";
            openFileDLG.FileName = "Signuter.jpg";

            if (openFileDLG.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pic_UserSignature.Image = new Bitmap(openFileDLG.FileName);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                //Hashing Password
                SHA256CryptoServiceProvider SHA256 = new SHA256CryptoServiceProvider();
                Byte[] B1;
                Byte[] B2;

                B1 = UTF8Encoding.UTF8.GetBytes(txt_Password.Text.Trim());
                B2 = SHA256.ComputeHash(B1);

                //Image Array


                string hashedPass = BitConverter.ToString(B2);
            }
            catch (Exception)
            {
                MessageBox.Show("در ثبت اطلاعات خطايي رخ داد لطفا دوباره امتحان كنيد");
                throw;
            }
        }
    }
}
