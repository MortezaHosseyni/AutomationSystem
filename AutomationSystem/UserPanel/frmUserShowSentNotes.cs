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
        Office_Automation_DatabaseEntities db = new Office_Automation_DatabaseEntities();
        public frmUserShowSentNotes()
        {
            InitializeComponent();
        }

        private void frmUserShowSentNotes_Load(object sender, EventArgs e)
        {
            this.Left = 10;
            this.Top = 160;

            ShowSentNotes();
        }

        private void ShowSentNotes()
        {
            var query = db.Database.SqlQuery<Vw_ReciveNotes>($"SELECT * FROM Vw_ReciveNotes WHERE NoteUserID = {PublicVariable.global_UserID}");
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
    }
}
