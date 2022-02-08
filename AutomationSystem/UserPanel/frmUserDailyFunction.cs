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

namespace AutomationSystem.UserPanel
{
    public partial class frmUserDailyFunction : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmUserDailyFunction()
        {
            InitializeComponent();
        }

        private void frmUserDailyFunction_Load(object sender, EventArgs e)
        {
            this.Left = 10;
            this.Top = 160;

            fillRequesterUnit();
        }

        private void fillRequesterUnit()
        {
            var query = (from J in db.Jobs select J).ToList();

            cmb_FunctionRequesterUnit.DataSource = query;
            cmb_FunctionRequesterUnit.ValueMember = "JobsID";
            cmb_FunctionRequesterUnit.DisplayMember = "JobsName";
        }

        private void txt_FunctionDoTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
