using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModelLayer.Models;

namespace AutomationSystem.AdminPanel
{
    public partial class frmUserManager : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        string userPictureName = "";
        string userSignatureName = "";

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
                userPictureName = openFileDLG.FileName;
                pic_UserPic.Image = new Bitmap(userPictureName);
            }
        }

        private void pic_UserSignature_Click(object sender, EventArgs e)
        {
            openFileDLG.Filter = "Image Files (*.JPG;*.BMP) | *.jpg;*.bmp";
            openFileDLG.Title = "نمونه امضاء كاربر";
            openFileDLG.FileName = "Signuter.jpg";

            if (openFileDLG.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                userSignatureName = openFileDLG.FileName;
                pic_UserSignature.Image = new Bitmap(userSignatureName);
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
                string hashedPass = BitConverter.ToString(B2);



                //User Picture Array
                FileStream fileStreamUserPic = new FileStream(userPictureName,FileMode.Open,FileAccess.Read);
                byte[] userPicArr = new byte[fileStreamUserPic.Length];
                fileStreamUserPic.Read(userPicArr, 0, Convert.ToInt32(fileStreamUserPic.Length));
                fileStreamUserPic.Close();

                //User Signature Array
                FileStream fileStreamUserSignature = new FileStream(userSignatureName, FileMode.Open, FileAccess.Read);
                byte[] userSignArr = new byte[fileStreamUserSignature.Length];
                fileStreamUserSignature.Read(userSignArr, 0, Convert.ToInt32(fileStreamUserSignature.Length));
                fileStreamUserSignature.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("در ثبت اطلاعات خطايي رخ داد لطفا دوباره امتحان كنيد");
                throw;
            }
        }
    }
}
