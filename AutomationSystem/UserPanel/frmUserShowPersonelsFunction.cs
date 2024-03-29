﻿using System;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace AutomationSystem.UserPanel
{
    public partial class frmUserShowPersonelsFunction : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities(PublicVariable.mainConnectionString);
        public string userJobName { get; set; }
        public int userJobID { get; set; }

        List<int> UID = new List<int>();
        List<string> family = new List<string>();
        List<int> time = new List<int>();
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

            chartInfo();
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
                        UID.Add(queryJobName[0].AsignUserID);
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

            dgv_UserWorks.Rows.Clear();

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

        private void chartInfo()
        {
            string userID = "";
            for (int counter = 0; counter < UID.Count; counter++)
            {
                userID += UID[counter].ToString() + ",";
            }
            userID = userID.Substring(0, userID.Length - 1);

            string[] listFamily = { };
            int[] listTime = { };

            var query = db.Database.SqlQuery<Vw_ChartInfo>($"SELECT * FROM Vw_ChartInfo WHERE WorkUserID IN ({userID}) ORDER BY TotalTime").ToList();
            if (query.Count > 0)
            {
                val_MaxWorkTime.Text = query[query.Count - 1].FullName;
                for (int ii = 0; ii < query.Count; ii++)
                {
                    family.Add(query[ii].FullName.ToString());
                    time.Add(Convert.ToInt32(query[ii].TotalTime));

                    listFamily = family.ToArray();
                    listTime = time.ToArray();
                }
                this.crt_UserWorkStatus.Series.Clear();
                this.crt_UserWorkStatus.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
                this.crt_UserWorkStatus.Titles.Add("نمودار كاركرد پرسنل");
                for (int i = 0; i < listFamily.Length; i++)
                {
                    Series series = this.crt_UserWorkStatus.Series.Add(listFamily[i] + "-" + query[i].TotalTime);
                    series.Points.Add(listTime[i]);
                }
            }
        }
    }
}
