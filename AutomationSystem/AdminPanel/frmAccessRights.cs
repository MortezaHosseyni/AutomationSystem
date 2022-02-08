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
    public partial class frmAccessRights : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public int getUserID { get; set; }
        public frmAccessRights()
        {
            InitializeComponent();
        }

        private void frmAccessRights_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAccessRights_Activated(object sender, EventArgs e)
        {
            trv_AccessRights.Nodes.Clear();

            TreeNode n = new TreeNode("حقوق دسترسي سيستم");
            n.ForeColor = Color.Red;
            n.Tag = "1";
            trv_AccessRights.Nodes.Add(n);

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

        private void trv_AccessRights_AfterCheck(object sender, TreeViewEventArgs e)
        {
            checkTreeViewChild(e.Node, e.Node.Checked);
        }

        private void checkTreeViewChild(TreeNode node, Boolean isChecked)
        {
            foreach (TreeNode item in node.Nodes)
            {
                item.Checked = isChecked;

                if (item.Nodes.Count > 0)
                {
                    this.checkTreeViewChild(item, isChecked);
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            getCheckNode(trv_AccessRights.Nodes);

            MessageBox.Show("اطلاعات با موفقيت ثبت شد","تايين دسترسي");
        }

        private List<string> getCheckNode(TreeNodeCollection nodes)
        {
            List<string> nodeList = new List<string>();

            if (nodes == null)
            {
                return nodeList;
            }

            foreach (TreeNode childNode in nodes)
            {
                if (childNode.Checked) //Add access
                {
                    UserAccess UA = new UserAccess();
                    UA.UAccessUserID = this.getUserID;
                    UA.UAccessSPartID = Convert.ToInt32(childNode.Tag);

                    var query = (from UAccess in db.UserAccesses where UAccess.UAccessUserID == this.getUserID where UAccess.UAccessSPartID == UA.UAccessSPartID select UAccess).ToList();
                    if (query.Count == 0)
                    {
                        db.UserAccesses.Add(UA);
                        db.SaveChanges();
                    }
                }
                else if (childNode.Checked == false && childNode.Tag != "1") //Remove access
                {
                    try
                    {
                        db.Sp_DeleteUserAccess(this.getUserID, Convert.ToInt32(childNode.Tag));
                        db.SaveChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("خطايي در خواندن اطلاعات رخ داد","پايگاه داده");
                    }
                }
                nodeList.AddRange(getCheckNode(childNode.Nodes));
            }
            return nodeList;
        }
    }
}
