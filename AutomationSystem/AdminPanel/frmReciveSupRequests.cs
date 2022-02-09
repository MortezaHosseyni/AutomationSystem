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

        private void recivedRequests(string searchRemind)
        {
            var query = db.Database.SqlQuery<Vw_Supports>("SELECT * FROM Vw_Supports WHERE 1=1 " + searchRemind);
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
            string dateIn = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_RemindDateIn.Value.Year.ToString()}/{txt_RemindDateIn.Value.Month.ToString()}/{txt_RemindDateIn.Value.Day.ToString()}"));
            string dateTo = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_RemindDateTo.Value.Year.ToString()}/{txt_RemindDateTo.Value.Month.ToString()}/{txt_RemindDateTo.Value.Day.ToString()}"));


            string searchString = $" AND RemindRememberDate BETWEEN '{dateIn}' AND '{dateTo}'";

            if (txt_RemindSubjectSearch.Text != "")
            {
                searchString += $" AND RemindSubject LIKE '%{txt_RemindSubjectSearch.Text}%'";
            }

            return searchString;
        }
    }
}