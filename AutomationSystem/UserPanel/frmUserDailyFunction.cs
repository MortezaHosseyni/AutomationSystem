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

namespace AutomationSystem.UserPanel
{
    public partial class frmUserDailyFunction : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmUserDailyFunction()
        {
            InitializeComponent();
        }

        private void frmUserDailyFunction_Load(object sender, EventArgs e)
        {
            this.Left = 10;
            this.Top = 160;

            fillRequesterUnit();
            ShowWorks();
        }

        private void ShowWorks()//string searchWorks)
        {
            var query = db.Database.SqlQuery<Vw_Works>($"SELECT * FROM Vw_Works WHERE WorkUserID = {PublicVariable.global_UserID}");
            var result = query.ToList();

            dgv_DailyFunctionsList.Rows.Clear();

            if (result.Count != 0)
            {
                dgv_DailyFunctionsList.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_DailyFunctionsList.Rows[i].Cells["col_WorkID"].Value = result[i].WorkID;

                    dgv_DailyFunctionsList.Rows[i].Cells["col_WorkSubject"].Value = result[i].WorkSubject;
                    dgv_DailyFunctionsList.Rows[i].Cells["col_WorkCaption"].Value = result[i].WorkCaption;
                    dgv_DailyFunctionsList.Rows[i].Cells["col_WorkRequesterUnit"].Value = result[i].JobsName;
                    dgv_DailyFunctionsList.Rows[i].Cells["col_WorkDoneDate"].Value = result[i].WorkDoneDate;
                    dgv_DailyFunctionsList.Rows[i].Cells["col_WorkDoneTime"].Value = result[i].WorkDoneTime;
                }
            }
            else
            {
                dgv_DailyFunctionsList.Rows.Clear();
            }
        }

        private void fillRequesterUnit()
        {
            var query = (from J in db.Jobs select J).ToList();

            cmb_FunctionRequesterUnit.DataSource = query;
            cmb_FunctionRequesterUnit.ValueMember = "JobsID";
            cmb_FunctionRequesterUnit.DisplayMember = "JobsName";
        }

        private void txt_FunctionDoTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_FunctionSubject.Text.Trim() == "" || txt_FunctionCaption.Text.Trim() == "" || txt_FunctionDoTime.Text.Trim() == "")
            {
                MessageBox.Show("لطفا همه فيلد‌ها را پُر كنيد","ثبت فعاليت");
                return;
            }

            try
            {
                Work W = new Work();
                W.WorkSubject = txt_FunctionSubject.Text.Trim();
                W.WorkCaption = txt_FunctionCaption.Text.Trim();
                W.WorkDoneDate = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime(txt_FunctionDoDate.Value.Year + "/" + txt_FunctionDoDate.Value.Month + "/" + txt_FunctionDoDate.Value.Day));
                W.WorkDoneTime = Convert.ToInt32(txt_FunctionDoTime.Text.Trim());
                W.WorkUserID = PublicVariable.global_UserID;
                W.WorkJobID = Convert.ToInt32(cmb_FunctionRequesterUnit.SelectedValue);

                db.Works.Add(W);
                db.SaveChanges();

                MessageBox.Show("اطلاعات با موفقيت ثبت شد","ثبت فعاليت");

                clearForm();

                ShowWorks();
            }
            catch (Exception)
            {
                MessageBox.Show("خطايي در خواندن اطلاعات رخ داد","پايگاه داده");
                return;
            }
        }

        private void clearForm()
        {
            txt_FunctionSubject.Text = "";
            txt_FunctionCaption.Text = "";
            txt_FunctionDoTime.Text = "";
            fillRequesterUnit();
            txt_FunctionDoDate.Value = DateTime.Now;
        }
    }
}
