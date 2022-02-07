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
    public partial class frmUserCirculationLetter : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmUserCirculationLetter()
        {
            InitializeComponent();
        }

        private void frmUserCirculationLetter_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
