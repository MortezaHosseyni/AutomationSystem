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

namespace AutomationSystem.AdminPanel
{
    public partial class frmAsignJob : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmAsignJob()
        {
            InitializeComponent();
        }

        private void frmAsignJob_Load(object sender, EventArgs e)
        {

        }

        private void frmAsignJob_Activated(object sender, EventArgs e)
        {
            trv_JobsList.Nodes.Clear();
            TreeNode tn = new TreeNode("مديرعامل");
            tn.ForeColor = Color.Red;
            tn.Tag = "1";
            trv_JobsList.Nodes.Add(tn);

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

                    if (tvn.Level < this.imageList.Images.Count - 1)
                    {
                        M.ImageIndex = tvn.Level + 1;
                        M.SelectedImageIndex = tvn.Level + 1;
                    }
                    else
                    {
                        M.ImageIndex = this.imageList.Images.Count - 1;
                        M.SelectedImageIndex = this.imageList.Images.Count - 1;
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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
