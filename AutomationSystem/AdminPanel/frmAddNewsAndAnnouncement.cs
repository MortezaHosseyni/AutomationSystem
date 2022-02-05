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
using System.IO;

namespace AutomationSystem.AdminPanel
{
    public partial class frmAddNewsAndAnnouncement : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmAddNewsAndAnnouncement()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddNewsAndAnnouncement_Load(object sender, EventArgs e)
        {
            val_NewsDate.Text = PublicVariable.todayDate;
            val_NewsWriter.Text = PublicVariable.global_UserFristName + " " + PublicVariable.global_UserLastName;
        }

        private void btn_AttachFile_Click(object sender, EventArgs e)
        {
            var file = "";

            openFileDialog.Filter = "All Files (*.*) | *.*";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "انتخاب فايل پيوست";
            openFileDialog.FileName = "AttachmentFile";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var lst = new string[] { ".jpg", ".bmp", ".png", ".zip", ".rar", ".pdf", ".doc", ".docx", ".txt", ".xls", ".xlsx", ".mp4", ".mp3" };

                file = openFileDialog.FileName;

                if (!lst.Contains(Path.GetExtension(file)))
                {
                    MessageBox.Show("فايل انتخاب شده مجاز نيست، لطفا يك فايل با پسوند مجاز انتخاب كنيد", "انتخاب فايل الصاق");
                    return;
                }
                lbl_NewsAttachmentFilePath.Text = file;
            }
            else
            {
                return;
            }
        }
    }
}
