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

namespace AutomationSystem.AdminPanel
{
    public partial class frmAddSystemPart : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities(PublicVariable.mainConnectionString);
        public int getSPartID { get; set; }
        public frmAddSystemPart()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_SPartName.Text == "")
                {
                    MessageBox.Show("لطفا يك نام براي جزء انتخاب كنيد","افزودن اجزاء");
                }
                SystemPart sPart = new SystemPart();
                sPart.SPartName = txt_SPartName.Text.Trim();
                sPart.SPartDetail = txt_SPartDetail.Text.Trim();
                sPart.SPartLevel = getSPartID;

                db.SystemParts.Add(sPart);
                db.SaveChanges();

                MessageBox.Show("اطلاعات با موفقيت ثبت شد","افزودن اجزاء");

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("خطايي در خواندن اطلاعات رخ داد","پايگاه داده");
                return;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
