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
    public partial class frmUserShowPersonelsFunction : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public string userJobName { get; set; }
        public int userJobID { get; set; }
        public frmUserShowPersonelsFunction()
        {
            InitializeComponent();
        }

        private void frmUserShowPersonelsFunction_Load(object sender, EventArgs e)
        {
            this.Left = 10;
            this.Top = 160;
        }

        private void frmUserShowPersonelsFunction_Activated(object sender, EventArgs e)
        {
            trv_SubPersonels.Nodes.Clear();
            TreeNode tn = new TreeNode(userJobName);
            tn.ForeColor = Color.Red;
            tn.Tag = userJobID;
            trv_SubPersonels.Nodes.Add(tn);

            loadTreeViewNodes(tn);

            tn.Expand();
        }
        private void loadTreeViewNodes(TreeNode tvn)
        {
            int tagInt = Convert.ToInt32(tvn.Tag);

            var treeQuery = (from Vw_J in db.Vw_Jobs where Vw_J.JobsLevel == tagInt select Vw_J).ToList();

            if (treeQuery.Count > 0)
            {
                for (int i = 0; i < treeQuery.Count; i++)
                {
                    TreeNode M = new TreeNode();
                    M.Tag = treeQuery[i].JobsID;
                    M.Text = treeQuery[i].JobsID + "-" + treeQuery[i].JobsName;

                    int currentJobID = treeQuery[i].JobsID;
                    var queryJobName = (from UJ in db.Vw_AsignmentJobs where UJ.AsignJobID == currentJobID where UJ.AsignStatus == 1 select UJ).ToList();
                    if (queryJobName.Count > 0)
                    {
                        M.Text = $"{M.Text} ({queryJobName[0].UserFullName})";
                    }

                    tvn.Nodes.Add(M);

                    int CH = Convert.ToInt32(treeQuery[i].JobsChild);
                    if (CH > 0)
                    {
                        loadTreeViewNodes(M);
                    }
                    M = null;
                }
            }
        }

        private void trv_SubPersonels_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int getJobID = Convert.ToInt32(trv_SubPersonels.SelectedNode.Tag);

            var queryGetUser = (from UJ in db.Vw_AsignmentJobs where UJ.AsignJobID == getJobID where UJ.AsignStatus == 1 select UJ).ToList();

            val_AllDoneWorks.Text = "0";
            val_AllWorksTime.Text = "0";

            if (queryGetUser.Count > 0)
            {
                var query = db.Database.SqlQuery<Vw_Works>($"SELECT * FROM Vw_Works WHERE WorkUserID = {queryGetUser[0].AsignUserID}");
                var result = query.ToList();

                dgv_UserWorks.Rows.Clear();

                if (result.Count != 0)
                {
                    dgv_UserWorks.RowCount = result.Count;
                    int totalTime = 0;
                    for (int i = 0; i <= result.Count - 1; i++)
                    {
                        dgv_UserWorks.Rows[i].Cells["col_WorkID"].Value = result[i].WorkID;

                        dgv_UserWorks.Rows[i].Cells["col_WorkSubject"].Value = result[i].WorkSubject;
                        dgv_UserWorks.Rows[i].Cells["col_WorkCaption"].Value = result[i].WorkCaption;
                        dgv_UserWorks.Rows[i].Cells["col_WorkRequesterUnit"].Value = result[i].JobsName;
                        dgv_UserWorks.Rows[i].Cells["col_WorkDoneDate"].Value = result[i].WorkDoneDate;
                        dgv_UserWorks.Rows[i].Cells["col_WorkDoneTime"].Value = result[i].WorkDoneTime;

                        totalTime += Convert.ToInt32(result[i].WorkDoneTime);
                    }
                    int totalHour = totalTime / 60;
                    int totalMinu = totalTime % 60;
                    val_AllWorksTime.Text = $"{totalHour} ساعت و {totalMinu} دقيقه";
                    val_AllDoneWorks.Text = dgv_UserWorks.Rows.Count.ToString();
                }
                else
                {
                    dgv_UserWorks.Rows.Clear();
                }
            }
        }
    }
}
