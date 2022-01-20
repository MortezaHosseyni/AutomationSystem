using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomationSystem.Moduls;

namespace AutomationSystem.AdminPanel
{
    public partial class frmReminder : Form
    {
        public frmReminder()
        {
            InitializeComponent();
        }

        private void frmReminder_Load(object sender, EventArgs e)
        {
            lbl_ReminderCreatedDateValue.Text = PublicVariable.todayDate;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
