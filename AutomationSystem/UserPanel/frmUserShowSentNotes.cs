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
    public partial class frmUserShowSentNotes : Form
    {
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities(PublicVariable.mainConnectionString);
        public frmUserShowSentNotes()
        {
            InitializeComponent();
        }

        private void frmUserShowSentNotes_Load(object sender, EventArgs e)
        {
            this.Left = 10;
            this.Top = 160;

            txt_NoteDateIn.Value = DateTime.Now.AddDays(-10);
            ShowSentNotes(searchCondition());
        }

        private void ShowSentNotes(string searchSentNotes)
        {
            var query = db.Database.SqlQuery<Vw_ReciveNotes>($"SELECT * FROM Vw_ReciveNotes WHERE NoteUserID = {PublicVariable.global_UserID} {searchSentNotes}");
            var result = query.ToList();

            if (result.Count != 0)
            {
                dgv_SentNotes.RowCount = result.Count;
                for (int i = 0; i <= result.Count - 1; i++)
                {
                    dgv_SentNotes.Rows[i].Cells["col_SentNoteID"].Value = result[i].SentNoteID;
                    dgv_SentNotes.Rows[i].Cells["col_NoteReciverID"].Value = result[i].NoteReciverID;

                    dgv_SentNotes.Rows[i].Cells["col_NoteSubject"].Value = result[i].NoteSubject;
                    dgv_SentNotes.Rows[i].Cells["col_NoteContext"].Value = result[i].NoteContext;
                    dgv_SentNotes.Rows[i].Cells["col_ReciverFullName"].Value = result[i].ReciverFullName;
                    dgv_SentNotes.Rows[i].Cells["col_NoteCreateDate"].Value = result[i].NoteCreateDate;
                }
            }
            else
            {
                dgv_SentNotes.Rows.Clear();
            }
        }

        private string searchCondition()
        {
            string dateIn = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_NoteDateIn.Value.Year.ToString()}/{txt_NoteDateIn.Value.Month.ToString()}/{txt_NoteDateIn.Value.Day.ToString()}"));
            string dateTo = string.Format("{0:yyyy'/'MM'/'dd}", Convert.ToDateTime($"{txt_NoteDateTo.Value.Year.ToString()}/{txt_NoteDateTo.Value.Month.ToString()}/{txt_NoteDateTo.Value.Day.ToString()}"));


            string searchString = $" AND NoteCreateDate BETWEEN '{dateIn}' AND '{dateTo}'";

            if (txt_SearchSubject.Text != "")
            {
                searchString += $" AND NoteSubject LIKE '%{txt_SearchSubject.Text}%'";
            }

            if (txt_SearchReciver.Text != "")
            {
                searchString += $" AND ReciverFullName LIKE '%{txt_SearchReciver.Text}%'";
            }

            if (txt_SearchContext.Text != "")
            {
                searchString += $" AND NoteContext LIKE '%{txt_SearchContext.Text}%'";
            }

            return searchString;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ShowSentNotes(searchCondition());
        }
    }
}
