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
    public partial class frmManageJobs : Form
    {
        public int Get_JobLevel { get; set; }
        public int Get_JobDetermineLevel { get; set; }

        public frmManageJobs()
        {
            InitializeComponent();
        }

        private void frmManageJobs_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
