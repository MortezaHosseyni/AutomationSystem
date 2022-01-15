using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "muro" && txt_Password.Text == "9889" && rdb_Admin.Checked)
            {
                AdminPanel.frmAdmin adminForm = new AdminPanel.frmAdmin();
                this.Hide();
                adminForm.Show();
            }
            else
            {
                MessageBox.Show("اطلاعات وارد شده اشتباه است");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
