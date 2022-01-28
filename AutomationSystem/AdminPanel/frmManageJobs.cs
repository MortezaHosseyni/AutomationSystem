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
    public partial class frmManageJobs : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();

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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_JobSubject.Text.Trim() == "")
                {
                    MessageBox.Show("لطفا يك عنوان براي شغل انتخاب كنيد","شغل جديد");
                }

                Job job = new Job();
                job.JobsName = txt_JobSubject.Text.Trim();
                job.JobsDetails = txt_JobDetails.Text.Trim();
                job.JobsLevel = this.Get_JobLevel;
                job.JobsDetermineLevel = this.Get_JobDetermineLevel + 1;

                db.Jobs.Add(job);
                db.SaveChanges();

                MessageBox.Show("اطلاعات با موفقيت ثبت شد","شغل جديد");

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("خطايي در سرور رخ داد","پايگاه داده");
                return;
            }
        }
    }
}
