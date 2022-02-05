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
    public partial class frmNewsList : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmNewsList()
        {
            InitializeComponent();
        }

        private void frmNewsList_Load(object sender, EventArgs e)
        {

        }

        private void ShowAllNews(string searchRecivedLetters)
        {
            var query = db.Database.SqlQuery<Vw_News>($"SELECT * FROM Vw_News WHERE 1=1 {searchRecivedLetters}");
            var result = query.ToList();

            dgv_NewsList.Rows.Clear();

            if (result.Count != 0)
            {
                dgv_NewsList.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_NewsList.Rows[i].Cells["col_NewsID"].Value = result[i].NewsID;

                    dgv_NewsList.Rows[i].Cells["col_NewsSubject"].Value = result[i].NewsSubject;
                    dgv_NewsList.Rows[i].Cells["col_NewsContext"].Value = result[i].NewsContext;
                    dgv_NewsList.Rows[i].Cells["col_NewsDate"].Value = result[i].NewsDate;
                    dgv_NewsList.Rows[i].Cells["col_FullName"].Value = result[i].FullName;
                    dgv_NewsList.Rows[i].Cells["col_NewsAttachment"].Value = result[i].NewsAttachmentFileName;
                }
                dgv_NewsList.TopLeftHeaderCell.Value = "رديف";
                for (int counter = 0; counter <= dgv_NewsList.Rows.Count - 1; counter++)
                {
                    dgv_NewsList.Rows[counter].HeaderCell.Value = (counter + 1).ToString();
                }
            }
            else
            {
                dgv_NewsList.Rows.Clear();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
