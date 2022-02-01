using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationSystem.UserPanel
{
    public partial class frmUserAddLetter : Form
    {
        public frmUserAddLetter()
        {
            InitializeComponent();
        }

        private void frmUserAddLetter_Load(object sender, EventArgs e)
        {
            this.Left = 10;
            this.Top = 160;
        }

        private void rdb_LetterDeadLine_Yes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_LetterDeadLine_Yes.Checked == true)
            {
                txt_LetterDeadLineValue.Enabled = true;
            }
            else
            {
                txt_LetterDeadLineValue.Enabled = false;
            }
        }

        private void rdb_LetterAttachment_Yes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_LetterAttachment_Yes.Checked == true)
            {
                btn_LetterAttachFile.Enabled = true;
            }
            else
            {
                btn_LetterAttachFile.Enabled = false;
            }
        }

        private void btn_LetterAttachFile_Click(object sender, EventArgs e)
        {
            var file = "";

            openFileDialog.Filter = "All Files (*.*) | *.*";
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "انتخاب فايل پيوست";
            openFileDialog.FileName = "AttachmentFile";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var lst = new string[] {".jpg",".bmp",".png",".zip",".rar",".pdf",".doc",".docx",".txt",".xls",".xlsx",".mp4",".mp3"};

                file = openFileDialog.FileName;

                if (!lst.Contains(Path.GetExtension(file)))
                {
                    MessageBox.Show("فايل انتخاب شده مجاز نيست، لطفا يك فايل با پسوند مجاز انتخاب كنيد","انتخاب فايل الصاق");
                    return;
                }
                lbl_AttachmentFilePath.Text = file;
            }
            else
            {
                return;
            }
        }
    }
}
