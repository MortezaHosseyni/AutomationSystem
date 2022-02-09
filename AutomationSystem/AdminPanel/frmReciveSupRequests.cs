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

namespace AutomationSystem.AdminPanel
{
    public partial class frmReciveSupRequests : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmReciveSupRequests()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReciveSupRequests_Load(object sender, EventArgs e)
        {

        }
    }
}
