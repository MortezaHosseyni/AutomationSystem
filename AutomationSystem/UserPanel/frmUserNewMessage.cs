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
    public partial class frmUserNewMessage : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public byte letType { get; set; }
        public frmUserNewMessage()
        {
            InitializeComponent();
        }

        private void frmUserNewMessage_Load(object sender, EventArgs e)
        {
            sentMessage();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            sentMessage();

            this.Close();
        }

        private void sentMessage()
        {
            if (letType == 1)//Letter
            {
                db.Sp_UpdateSentMessage(PublicVariable.global_UserID);
            }
            else if (letType == 2)//Reference
            {
                db.Sp_UpdateRefMessage(PublicVariable.global_UserID);
            }
            db.SaveChanges();
        }
    }
}
