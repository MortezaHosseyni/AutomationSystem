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
    public partial class frmReciveSupRequests : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmReciveSupRequests()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReciveSupRequests_Load(object sender, EventArgs e)
        {
            recivedRequests(searchCondition());
        }

        private void recivedRequests(string searchSup)
        {
            var query = db.Database.SqlQuery<Vw_Supports>("SELECT * FROM Vw_Supports WHERE 1=1" + searchSup);
            var result = query.ToList();

            if (result.Count != 0)
            {
                dgv_Requests.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_Requests.Rows[i].Cells["col_SupID"].Value = result[i].SupID;
                    dgv_Requests.Rows[i].Cells["col_SupUserID"].Value = result[i].SupUserID;

                    dgv_Requests.Rows[i].Cells["col_SupSubject"].Value = result[i].SupSubject;
                    dgv_Requests.Rows[i].Cells["col_SupCaption"].Value = result[i].SupCaption;
                    dgv_Requests.Rows[i].Cells["col_SupRequester"].Value = result[i].FullName;
                    dgv_Requests.Rows[i].Cells["col_SupDate"].Value = result[i].SupDate;
                }
            }
            else
            {
                dgv_Requests.Rows.Clear();
            }
        }
        private string searchCondition()
        {
            string dateIn = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_DateIn.Value.Year.ToString()}/{txt_DateIn.Value.Month.ToString()}/{txt_DateIn.Value.Day.ToString()}"));
            string dateTo = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_DateTo.Value.Year.ToString()}/{txt_DateTo.Value.Month.ToString()}/{txt_DateTo.Value.Day.ToString()}"));


            string searchString = $" AND SupDate BETWEEN '{dateIn}' AND '{dateTo}'";

            if (txt_SupSubject.Text != "")
            {
                searchString += $" AND SupSubject LIKE '%{txt_SupSubject.Text}%'";
            }

            if (txt_SupCaption.Text != "")
            {
                searchString += $" AND SupCaption LIKE '%{txt_SupCaption.Text}%'";
            }

            if (txt_SupRequester.Text != "")
            {
                searchString += $" AND FullName LIKE '%{txt_SupRequester.Text}%'";
            }

            return searchString;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            recivedRequests(searchCondition());
        }
    }
}
