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
    public partial class frmUserRecivedReferenceLetters : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmUserRecivedReferenceLetters()
        {
            InitializeComponent();
        }

        private void frmUserRecivedReferenceLetters_Load(object sender, EventArgs e)
        {
            this.Left = 10;
            this.Top = 160;
        }
    }
}
