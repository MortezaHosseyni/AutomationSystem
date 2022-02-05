namespace AutomationSystem.UserPanel
{
    partial class frmUserShowSentNotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Main = new DevComponents.DotNetBar.PanelEx();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.pnl_SentNotes = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.pnl_Search = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv_SentNotes = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_SentNoteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NoteSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NoteContext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ReciverFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NoteReciverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NoteCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Main.SuspendLayout();
            this.pnl_SentNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SentNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.pnl_Search);
            this.pnl_Main.Controls.Add(this.pnl_SentNotes);
            this.pnl_Main.Controls.Add(this.lbl_Title);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1050, 610);
            this.pnl_Main.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl_Main.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Main.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Main.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl_Main.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Main.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Main.Style.GradientAngle = 90;
            this.pnl_Main.TabIndex = 0;
            // 
            // lbl_Title
            // 
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("B Nazanin", 22.25F);
            this.lbl_Title.Location = new System.Drawing.Point(402, 12);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(215, 46);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "يادداشت‌هاي ارسالي";
            // 
            // pnl_SentNotes
            // 
            this.pnl_SentNotes.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_SentNotes.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_SentNotes.Controls.Add(this.dgv_SentNotes);
            this.pnl_SentNotes.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_SentNotes.Location = new System.Drawing.Point(12, 64);
            this.pnl_SentNotes.Name = "pnl_SentNotes";
            this.pnl_SentNotes.Size = new System.Drawing.Size(1026, 378);
            // 
            // 
            // 
            this.pnl_SentNotes.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_SentNotes.Style.BackColorGradientAngle = 90;
            this.pnl_SentNotes.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_SentNotes.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SentNotes.Style.BorderBottomWidth = 1;
            this.pnl_SentNotes.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_SentNotes.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SentNotes.Style.BorderLeftWidth = 1;
            this.pnl_SentNotes.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SentNotes.Style.BorderRightWidth = 1;
            this.pnl_SentNotes.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SentNotes.Style.BorderTopWidth = 1;
            this.pnl_SentNotes.Style.CornerDiameter = 4;
            this.pnl_SentNotes.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_SentNotes.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_SentNotes.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_SentNotes.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_SentNotes.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_SentNotes.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_SentNotes.TabIndex = 1;
            this.pnl_SentNotes.Text = "يادداشت‌هاي ارسال شده";
            // 
            // pnl_Search
            // 
            this.pnl_Search.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Search.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Search.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Search.Location = new System.Drawing.Point(12, 448);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(1026, 150);
            // 
            // 
            // 
            this.pnl_Search.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Search.Style.BackColorGradientAngle = 90;
            this.pnl_Search.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Search.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Search.Style.BorderBottomWidth = 1;
            this.pnl_Search.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Search.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Search.Style.BorderLeftWidth = 1;
            this.pnl_Search.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Search.Style.BorderRightWidth = 1;
            this.pnl_Search.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Search.Style.BorderTopWidth = 1;
            this.pnl_Search.Style.CornerDiameter = 4;
            this.pnl_Search.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_Search.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_Search.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Search.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_Search.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_Search.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_Search.TabIndex = 2;
            this.pnl_Search.Text = "جستجو";
            // 
            // dgv_SentNotes
            // 
            this.dgv_SentNotes.AllowUserToAddRows = false;
            this.dgv_SentNotes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_SentNotes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_SentNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SentNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_SentNoteID,
            this.col_NoteSubject,
            this.col_NoteContext,
            this.col_ReciverFullName,
            this.col_NoteReciverID,
            this.col_NoteCreateDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SentNotes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_SentNotes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_SentNotes.Location = new System.Drawing.Point(3, 3);
            this.dgv_SentNotes.Name = "dgv_SentNotes";
            this.dgv_SentNotes.Size = new System.Drawing.Size(1014, 335);
            this.dgv_SentNotes.TabIndex = 0;
            // 
            // col_SentNoteID
            // 
            this.col_SentNoteID.HeaderText = "SentNoteID";
            this.col_SentNoteID.Name = "col_SentNoteID";
            this.col_SentNoteID.Visible = false;
            // 
            // col_NoteSubject
            // 
            this.col_NoteSubject.HeaderText = "موضوع";
            this.col_NoteSubject.Name = "col_NoteSubject";
            this.col_NoteSubject.Width = 250;
            // 
            // col_NoteContext
            // 
            this.col_NoteContext.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_NoteContext.HeaderText = "متن يادداشت";
            this.col_NoteContext.Name = "col_NoteContext";
            // 
            // col_ReciverFullName
            // 
            this.col_ReciverFullName.HeaderText = "گيرنده";
            this.col_ReciverFullName.Name = "col_ReciverFullName";
            this.col_ReciverFullName.Width = 210;
            // 
            // col_NoteReciverID
            // 
            this.col_NoteReciverID.HeaderText = "NoteReciverID";
            this.col_NoteReciverID.Name = "col_NoteReciverID";
            this.col_NoteReciverID.Visible = false;
            // 
            // col_NoteCreateDate
            // 
            this.col_NoteCreateDate.HeaderText = "تاريخ ارسال";
            this.col_NoteCreateDate.Name = "col_NoteCreateDate";
            this.col_NoteCreateDate.Width = 110;
            // 
            // frmUserShowSentNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmUserShowSentNotes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUserShowSentNotes_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_SentNotes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SentNotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_SentNotes;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Search;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_SentNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SentNoteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NoteSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NoteContext;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ReciverFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NoteReciverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NoteCreateDate;
    }
}