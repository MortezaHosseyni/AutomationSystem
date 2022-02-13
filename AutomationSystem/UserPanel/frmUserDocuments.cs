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

namespace AutomationSystem.UserPanel
{
    public partial class frmUserDocuments : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmUserDocuments()
        {
            InitializeComponent();
        }

        private void frmUserDocuments_Load(object sender, EventArgs e)
        {
            this.Left = 10;
            this.Top = 160;

            val_DocSaveDate.Text = PublicVariable.todayDate;
        }

        private void btn_DocAttachFile_Click(object sender, EventArgs e)
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
                val_DocFilePath.Text = file;
            }
            else
            {
                return;
            }
        }
    }
}
