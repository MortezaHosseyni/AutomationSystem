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
    public partial class frmUserRequestSupport : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmUserRequestSupport()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_SupSubject.Text.Trim() == "" || txt_SupCaption.Text.Trim() == "")
            {
                MessageBox.Show("لطفا فيلدهاي خالي را پر كنيد","ثبت درخواست");
                return;
            }
            try
            {
                Support Sup = new Support();
                Sup.SupSubject = txt_SupSubject.Text.Trim();
                Sup.SupCaption = txt_SupCaption.Text.Trim();
                Sup.SupDate = val_SupDate.Text.Trim();
                Sup.SupUserID = PublicVariable.global_UserID;

                db.Supports.Add(Sup);
                db.SaveChanges();

                MessageBox.Show("درخواست شما با موفقيت ثبت شد","ثبت درخواست");

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

        private void frmUserRequestSupport_Load(object sender, EventArgs e)
        {
            val_SupDate.Text = PublicVariable.todayDate;
        }
    }
}
