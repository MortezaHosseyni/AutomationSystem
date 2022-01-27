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
    public partial class frmJobs : Form
    {
        public frmJobs()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmJobs_Activated(object sender, EventArgs e)
        {
            trv_Jobs.Nodes.Clear();
            TreeNode tn = new TreeNode("مديرعامل");
            tn.ForeColor = Color.Red;
            tn.Tag = "1";
            trv_Jobs.Nodes.Add(tn);
        }
    }
}
