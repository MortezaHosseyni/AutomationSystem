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
using AutomationSystem.Moduls;

namespace AutomationSystem.AdminPanel
{
    public partial class frmUserManager : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        string userPictureName = "";
        string userSignatureName = "";

        public byte formType;

        //Form Propertys
        public string userFirstName { get; set; }
        public string userLastName { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string userEmail { get; set; }
        public string userTel { get; set; }
        public string userPersonalCode { get; set; }
        public string userBrithDate { get; set; }
        public string userGender { get; set; }
        public string userRegisterDate { get; set; }



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
            if (!checkNullableValues())
            {
                return;
            }

            try
            {
                //Check Repetitive User
                var queryRepetitiveUserName = (from U in db.Users
                                               where U.UserName == txt_UserName.Text.Trim()
                                               where U.UserActivity == 1
                                               select U).ToList();
                if (queryRepetitiveUserName.Count == 1)
                {
                    MessageBox.Show("اين نام‌كاربري قبلا در سيستم ثبت شده است","نام‌كاربري تكراري");
                    return;
                }

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



                //User Gender Checking
                byte checkGender = 0;
                if (rbt_Man.Checked)
                {
                    checkGender = 1;
                }
                else if (rbt_Woman.Checked)
                {
                    checkGender = 2;
                }



                //User Brithdate
                string userBrithDate = String.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime(txt_BrithDate.Text.ToString()));

                //Insert Data
                db.Sp_InsterUsers(txt_Name.Text.Trim(), txt_LastName.Text.Trim(), txt_UserName.Text.Trim(), hashedPass, txt_PersonalCode.Text.Trim(), txt_Email.Text.Trim(), checkGender, 1, txt_Tel.Text.Trim(), userBrithDate, userPicArr, userSignArr, lbl_RegisterDateValue.Text.Trim());
                db.SaveChanges();
                MessageBox.Show("كاربر با موفقيت ثبت شد");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("در ثبت اطلاعات خطايي رخ داد لطفا دوباره امتحان كنيد");
                throw;
            }
        }
        private bool checkNullableValues()
        {
            if (txt_Name.Text.Trim() == "")
            {
                MessageBox.Show("لطفا نام كاربر را وارد كنيد");
                txt_Name.Focus();
                return false;
            }
            if (txt_LastName.Text.Trim() == "")
            {
                MessageBox.Show("لطفا نام خانوادگي كاربر را وارد كنيد");
                txt_Name.Focus();
                return false;
            }
            if (txt_UserName.Text.Trim() == "")
            {
                MessageBox.Show("لطفا نام كاربري را وارد كنيد");
                txt_Name.Focus();
                return false;
            }
            if (txt_Password.Text.Trim() == "")
            {
                MessageBox.Show("لطفا گذرواژه كاربر را وارد كنيد");
                txt_Name.Focus();
                return false;
            }
            if (txt_Tel.Text.Trim() == "")
            {
                MessageBox.Show("لطفا شماره تماس كاربر را وارد كنيد");
                txt_Name.Focus();
                return false;
            }
            if (txt_PersonalCode.Text.Trim() == "")
            {
                MessageBox.Show("لطفا كد پرسنلي كاربر را وارد كنيد");
                txt_Name.Focus();
                return false;
            }
            if (userPictureName == "" || userSignatureName == "")
            {
                MessageBox.Show("عكس ويا نمونه امضاء كاربر نمي‌تواند خالي باشد");
                return false;
            }
            return true;
        }
        private void frmUserManager_Load(object sender, EventArgs e)
        {
            lbl_RegisterDateValue.Text = PublicVariable.todayDate;
            txt_BrithDate.Text = PublicVariable.todayDate;

            if (this.formType == 2)
            {
                txt_Name.Text = this.userFirstName;
                txt_LastName.Text = this.userLastName;
                txt_UserName.Text = this.userName;
                txt_Password.Text = this.userPassword;
                txt_Email.Text = this.userEmail;
                txt_Tel.Text = this.userTel;
                txt_PersonalCode.Text = this.userPersonalCode;

                txt_BrithDate.Text = this.userBrithDate;

                lbl_RegisterDateValue.Text = this.userRegisterDate;

                if (this.userGender == "مرد")
                {
                    rbt_Man.Checked = true;
                }
                else
                {
                    rbt_Woman.Checked = true;
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
