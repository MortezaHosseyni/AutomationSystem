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

namespace AutomationSystem.UserPanel
{
    public partial class frmUserDraft : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmUserDraft()
        {
            InitializeComponent();
        }

        private void frmUserDraft_Load(object sender, EventArgs e)
        {
            ShowDraft(searchCondition());

            this.Left = 10;
            this.Top = 160;
        }

        private void ShowDraft(string searchDraft)
        {
            var query = db.Database.SqlQuery<Vw_Letters>("SELECT * FROM Vw_Letters WHERE LetterDraftType = 1" + searchDraft);
            var result = query.ToList();

            if (result.Count != 0)
            {
                dgv_DraftList.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_DraftList.Rows[i].Cells["col_LetterID"].Value = result[i].LetterID;

                    dgv_DraftList.Rows[i].Cells["col_LetterSubject"].Value = result[i].LetterSubject;
                    dgv_DraftList.Rows[i].Cells["col_LetterType"].Value = result[i].View_LetterType;
                    dgv_DraftList.Rows[i].Cells["col_LetterForceType"].Value = result[i].View_LetterForceType;
                    dgv_DraftList.Rows[i].Cells["col_LetterSecurityType"].Value = result[i].View_LetterSecurityType;
                    dgv_DraftList.Rows[i].Cells["col_LetterFollowingType"].Value = result[i].View_LetterFollowingType;
                    dgv_DraftList.Rows[i].Cells["col_LetterAttachmentType"].Value = result[i].View_LetterAttachmentType;
                    dgv_DraftList.Rows[i].Cells["col_LetterAnswerType"].Value = result[i].View_LetterAnswerType;
                    dgv_DraftList.Rows[i].Cells["col_LetterAnswerDeadLine"].Value = result[i].LetterAnswerDeadLine;
                }
            }
            else
            {
                dgv_DraftList.Rows.Clear();
            }
        }

        private string searchCondition()
        {
            string searchString = "";

            //Subject Search
            if (txt_SearchSubject.Text != "")
            {
                searchString += $" AND LetterSubject LIKE '%{txt_SearchSubject.Text}%'";
            }
            
            //ForcedType Search
            if (rdb_SearchNormalForced.Checked)
            {
                searchString += " AND LetterForceType = 1";
            }
            else if (rdb_SearchImmediateForced.Checked)
            {
                searchString += " AND LetterForceType = 2";
            }
            else if (rdb_SearchPosthasteForced.Checked)
            {
                searchString += " AND LetterForceType = 3";
            }

            //SecurityType Search
            if (rdb_SearchNormalSecurity.Checked)
            {
                searchString += " AND LetterSecurityType = 1";
            }
            else if (rdb_SearchConfidentialSecurity.Checked)
            {
                searchString += " AND LetterSecurityType = 2";
            }
            else if (rdb_SearchSecretiveSecurity.Checked)
            {
                searchString += " AND LetterSecurityType = 3";
            }

            return searchString;
        }
    }
}
