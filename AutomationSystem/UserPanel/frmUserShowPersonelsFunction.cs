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
            tn.Tag = "1";
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
    }
}
