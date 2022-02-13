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
    public partial class frmSystemComponents : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities(PublicVariable.mainConnectionString);
        public frmSystemComponents()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSystemComponents_Load(object sender, EventArgs e)
        {

        }

        private void frmSystemComponents_Activated(object sender, EventArgs e)
        {
            trv_SystemComponents.Nodes.Clear();

            TreeNode n = new TreeNode("حقوق دسترسي سيستم");
            n.ForeColor = Color.Red;
            n.Tag = "1";
            trv_SystemComponents.Nodes.Add(n);

            loadTreeView(n);

            n.Expand();
        }

        private void loadTreeView(TreeNode TN)
        {
            int intTag = Convert.ToInt32(TN.Tag);

            var query = (from SYSP in db.Vw_SystemParts where SYSP.SPartLevel == intTag select SYSP).ToList();
            if (query.Count > 0)
            {
                for (int i = 0; i < query.Count; i++)
                {
                    TreeNode M = new TreeNode();
                    M.Tag = query[i].SPartID;
                    M.Text = query[i].SPartName;
                    M.ToolTipText = M.Tag.ToString();

                    TN.Nodes.Add(M);

                    //Add Childs
                    int childCounter = Convert.ToInt32(query[i].SPartChildCount);
                    if (childCounter > 0)
                    {
                        loadTreeView(M);
                    }
                    M = null;
                }
            }
        }

        private void btn_AddComponent_Click(object sender, EventArgs e)
        {
            if (trv_SystemComponents.SelectedNode == null)
            {
                MessageBox.Show("لطفا يكي از اجزاء را انتخاب كنيد","افزودن اجزاء");
                return;
            }
            frmAddSystemPart addSystemPart = new frmAddSystemPart();
            addSystemPart.getSPartID = Convert.ToInt32(trv_SystemComponents.SelectedNode.Tag);
            addSystemPart.ShowDialog();
        }
    }
}
