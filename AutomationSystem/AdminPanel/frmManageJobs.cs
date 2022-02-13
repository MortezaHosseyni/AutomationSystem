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
    public partial class frmManageJobs : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities(PublicVariable.mainConnectionString);

        public int Get_JobID { get; set; }
        public int Get_JobLevel { get; set; }
        public int Get_JobDetermineLevel { get; set; }
        public byte formType { get; set; }

        public frmManageJobs()
        {
            InitializeComponent();
        }

        private void frmManageJobs_Load(object sender, EventArgs e)
        {
            if (this.formType == 2)
            {
                var editQuery = (from J in db.Jobs where J.JobsID == this.Get_JobID select J).ToList();

                if (editQuery.Count == 1)
                {
                    txt_JobSubject.Text = editQuery[0].JobsName;
                    txt_JobDetails.Text = editQuery[0].JobsDetails;
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.formType == 1)
                {
                    if (txt_JobSubject.Text.Trim() == "")
                    {
                        MessageBox.Show("لطفا يك عنوان براي شغل انتخاب كنيد", "شغل جديد");
                    }

                    Job job = new Job();
                    job.JobsName = txt_JobSubject.Text.Trim();
                    job.JobsDetails = txt_JobDetails.Text.Trim();
                    job.JobsLevel = this.Get_JobLevel;
                    job.JobsDetermineLevel = this.Get_JobDetermineLevel + 1;

                    db.Jobs.Add(job);
                    db.SaveChanges();

                    MessageBox.Show("اطلاعات با موفقيت ثبت شد", "شغل جديد");

                    this.Close();
                }
                else if (this.formType == 2)
                {
                    if (txt_JobSubject.Text.Trim() == "")
                    {
                        MessageBox.Show("لطفا يك عنوان براي شغل انتخاب كنيد", "شغل جديد");
                    }

                    var updateQuery = (from J in db.Jobs where J.JobsID == this.Get_JobID select J).SingleOrDefault();
                    updateQuery.JobsName = txt_JobSubject.Text.Trim();
                    updateQuery.JobsDetails = txt_JobDetails.Text.Trim();

                    db.SaveChanges();

                    MessageBox.Show("اطلاعات با موفقيت ويرايش شد", "ويرايش شغل");

                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("خطايي در سرور رخ داد","پايگاه داده");
                return;
            }
        }
    }
}
