using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
