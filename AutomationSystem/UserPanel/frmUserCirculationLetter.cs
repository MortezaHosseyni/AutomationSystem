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
        public int getLetterID { get; set; }
        public frmUserCirculationLetter()
        {
            InitializeComponent();
        }

        private void frmUserCirculationLetter_Load(object sender, EventArgs e)
        {
            circulationLetter();
        }

        private void circulationLetter()
        {
            try
            {
                var queryCirculation = (from RR in db.Vw_ReciveReference where RR.RefLetterID == this.getLetterID orderby RR.RefLevelNumber select RR).ToList();
                if (queryCirculation.Count > 0)
                {
                    int counter = 0;
                    for (int i = 0; i <= queryCirculation.Count - 1; i++)
                    {
                        counter++;
                        lbl_CirculationLetterContext.Text += $"{counter}. نامه شما توسط {queryCirculation[i].RefSender_FullName} به {queryCirculation[i].RefReciver_FullName} در مورخه {queryCirculation[i].RefDate} ارجاع داده شد. \nپاراف نامه: {queryCirculation[i].RefCaption} \n\n";
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("خطايي در دريافت اطلاعات رخ داد","پايگاه داده");
                return;
            }
        }
         
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
