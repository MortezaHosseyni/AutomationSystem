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
using System.IO;
using AutomationSystem.Moduls;

namespace AutomationSystem.AdminPanel
{
    public partial class frmNewsList : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities(PublicVariable.mainConnectionString);
        public frmNewsList()
        {
            InitializeComponent();
        }

        private void frmNewsList_Load(object sender, EventArgs e)
        {
            txt_DateOn.Value = DateTime.Now.AddDays(-10);
            ShowAllNews(searchCondition());
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

        private string searchCondition()
        {
            string dateIn = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_DateOn.Value.Year.ToString()}/{txt_DateOn.Value.Month.ToString()}/{txt_DateOn.Value.Day.ToString()}"));
            string dateTo = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_DateTo.Value.Year.ToString()}/{txt_DateTo.Value.Month.ToString()}/{txt_DateTo.Value.Day.ToString()}"));


            string searchString = $" AND NewsDate BETWEEN '{dateIn}' AND '{dateTo}'";

            if (txt_NewsSubject.Text != "")
            {
                searchString += $" AND NewsSubject LIKE '%{txt_NewsSubject.Text}%'";
            }

            if (txt_NewsContext.Text != "")
            {
                searchString += $" AND NewsContext LIKE '%{txt_NewsContext.Text}%'";
            }

            return searchString;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ShowAllNews(searchCondition());
        }

        private void dgv_NewsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_NewsList.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                if (dgv_NewsList.CurrentCell != null && dgv_NewsList.CurrentCell.Value != null)
                {
                    int get_NewsID = Convert.ToInt32(dgv_NewsList.CurrentRow.Cells["col_NewsID"].Value);
                    var queryFileName = (from AN in db.News where AN.NewsID == get_NewsID select AN).ToList();
                    saveAttachmentFile(saveFileDialog, dgv_NewsList, get_NewsID);
                }
            }
        }

        private void saveAttachmentFile(SaveFileDialog objSFD, DataGridView objGrid, int getNewsID)
        {
            try
            {
                string strID = objGrid.CurrentRow.Cells["col_NewsAttachment"].Value.ToString();
                if (strID != null)
                {
                    var queryAttachment = (from AN in db.News where AN.NewsID == getNewsID select AN).ToList();

                    byte[] objData = (byte[])queryAttachment[0].NewsAttachment;

                    objSFD.FileName = queryAttachment[0].NewsAttachmentFileName;
                    objSFD.Title = "دريافت فايل الصاقي";

                    if (objSFD.ShowDialog() != DialogResult.Cancel)
                    {
                        string strFileToSave = objSFD.FileName;
                        FileStream objFileStream = new FileStream(strFileToSave, FileMode.Create, FileAccess.Write);
                        objFileStream.Write(objData, 0, objData.Length);
                        objFileStream.Close();

                        MessageBox.Show("فايل الصاقي باموفقيت دانلود شد", "دريافت فايل الصاق");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("در خواندن اطلاعات خطايي رخ داد", "پايگاه داده");
                return;
            }
        }
    }
}
