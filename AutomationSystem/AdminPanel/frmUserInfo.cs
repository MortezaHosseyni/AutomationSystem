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
using System.IO;

namespace AutomationSystem.AdminPanel
{
    public partial class frmUserInfo : Form
    {
        public int Get_UserID { get; set; }
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmUserInfo()
        {
            InitializeComponent();
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            try
            {
                var infoQuery = (from U in db.Vw_Users where U.UserID == this.Get_UserID select U).ToList();

                if (infoQuery.Count == 1)
                {
                    val_Name.Text = infoQuery[0].UserFirstName;
                    val_LastName.Text = infoQuery[0].UserLastName;
                    val_Tel.Text = infoQuery[0].UserTel;
                    val_BrithDate.Text = infoQuery[0].UserBrithDate;
                    val_Gender.Text = infoQuery[0].UserGender;
                    val_PersonalCode.Text = infoQuery[0].UserPersonalID;
                    val_Status.Text = infoQuery[0].UserActivity;
                    val_UserName.Text = infoQuery[0].UserName;
                    val_Email.Text = infoQuery[0].UserEmail;
                    val_Job.Text = "برنامه نويس";

                    //User Picture
                    var dataUserPicture = (Byte[])(infoQuery[0].UserImage);
                    var streamUserPicture = new MemoryStream(dataUserPicture);
                    pic_PersonalPicture.Image = Image.FromStream(streamUserPicture);

                    //User Signature
                    var dataUserSignature = (Byte[])(infoQuery[0].UserSignature);
                    var streamUserSignature = new MemoryStream(dataUserSignature);
                    pic_PersonalSignature.Image = Image.FromStream(streamUserSignature);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("خطايي در خواندن اطلاعات رخ داد","پايگاه‌ داده");
                return;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
