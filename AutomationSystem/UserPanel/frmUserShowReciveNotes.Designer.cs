namespace AutomationSystem.UserPanel
{
    partial class frmUserShowReciveNotes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserShowReciveNotes));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pnl_ReciveNotes = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv_ReciveNotes = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_SentNoteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NoteSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NoteContext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SenderFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NoteSenderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NoteReciveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Search = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_Search = new DevComponents.DotNetBar.ButtonX();
            this.txt_SearchSender = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_SearchContext = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_SearchSubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_NoteDateTo = new FreeControls.PersianDateTimePicker();
            this.txt_NoteDateIn = new FreeControls.PersianDateTimePicker();
            this.lbl_RemindDateTo = new DevComponents.DotNetBar.LabelX();
            this.lbl_SearchContext = new DevComponents.DotNetBar.LabelX();
            this.lbl_SearchSender = new DevComponents.DotNetBar.LabelX();
            this.lbl_SearchSubject = new DevComponents.DotNetBar.LabelX();
            this.lbl_NoteDateIn = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            this.pnl_ReciveNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReciveNotes)).BeginInit();
            this.pnl_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.pnl_Search);
            this.panelEx1.Controls.Add(this.pnl_ReciveNotes);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1050, 610);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("B Nazanin", 22.25F);
            this.labelX1.Location = new System.Drawing.Point(413, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(224, 44);
            this.labelX1.Symbol = "";
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "يادداشت‌هاي دريافتي";
            // 
            // pnl_ReciveNotes
            // 
            this.pnl_ReciveNotes.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_ReciveNotes.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_ReciveNotes.Controls.Add(this.dgv_ReciveNotes);
            this.pnl_ReciveNotes.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_ReciveNotes.Location = new System.Drawing.Point(12, 53);
            this.pnl_ReciveNotes.Name = "pnl_ReciveNotes";
            this.pnl_ReciveNotes.Size = new System.Drawing.Size(1026, 389);
            // 
            // 
            // 
            this.pnl_ReciveNotes.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_ReciveNotes.Style.BackColorGradientAngle = 90;
            this.pnl_ReciveNotes.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_ReciveNotes.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_ReciveNotes.Style.BorderBottomWidth = 1;
            this.pnl_ReciveNotes.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_ReciveNotes.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_ReciveNotes.Style.BorderLeftWidth = 1;
            this.pnl_ReciveNotes.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_ReciveNotes.Style.BorderRightWidth = 1;
            this.pnl_ReciveNotes.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_ReciveNotes.Style.BorderTopWidth = 1;
            this.pnl_ReciveNotes.Style.CornerDiameter = 4;
            this.pnl_ReciveNotes.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_ReciveNotes.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_ReciveNotes.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_ReciveNotes.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_ReciveNotes.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_ReciveNotes.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_ReciveNotes.TabIndex = 2;
            this.pnl_ReciveNotes.Text = "يادداشت‌هاي دريافت شده";
            // 
            // dgv_ReciveNotes
            // 
            this.dgv_ReciveNotes.AllowUserToAddRows = false;
            this.dgv_ReciveNotes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_ReciveNotes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ReciveNotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ReciveNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ReciveNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_SentNoteID,
            this.col_NoteSubject,
            this.col_NoteContext,
            this.col_SenderFullName,
            this.col_NoteSenderID,
            this.col_NoteReciveDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ReciveNotes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ReciveNotes.EnableHeadersVisualStyles = false;
            this.dgv_ReciveNotes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(181)))), ((int)(((byte)(252)))));
            this.dgv_ReciveNotes.Location = new System.Drawing.Point(3, 3);
            this.dgv_ReciveNotes.Name = "dgv_ReciveNotes";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ReciveNotes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ReciveNotes.Size = new System.Drawing.Size(1014, 346);
            this.dgv_ReciveNotes.TabIndex = 0;
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
            // col_SenderFullName
            // 
            this.col_SenderFullName.HeaderText = "فرستنده";
            this.col_SenderFullName.Name = "col_SenderFullName";
            this.col_SenderFullName.Width = 210;
            // 
            // col_NoteSenderID
            // 
            this.col_NoteSenderID.HeaderText = "NoteSenderID";
            this.col_NoteSenderID.Name = "col_NoteSenderID";
            this.col_NoteSenderID.Visible = false;
            // 
            // col_NoteReciveDate
            // 
            this.col_NoteReciveDate.HeaderText = "تاريخ دريافت";
            this.col_NoteReciveDate.Name = "col_NoteReciveDate";
            this.col_NoteReciveDate.Width = 125;
            // 
            // pnl_Search
            // 
            this.pnl_Search.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Search.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Search.Controls.Add(this.btn_Search);
            this.pnl_Search.Controls.Add(this.txt_SearchSender);
            this.pnl_Search.Controls.Add(this.txt_SearchContext);
            this.pnl_Search.Controls.Add(this.txt_SearchSubject);
            this.pnl_Search.Controls.Add(this.txt_NoteDateTo);
            this.pnl_Search.Controls.Add(this.txt_NoteDateIn);
            this.pnl_Search.Controls.Add(this.lbl_RemindDateTo);
            this.pnl_Search.Controls.Add(this.lbl_SearchContext);
            this.pnl_Search.Controls.Add(this.lbl_SearchSender);
            this.pnl_Search.Controls.Add(this.lbl_SearchSubject);
            this.pnl_Search.Controls.Add(this.lbl_NoteDateIn);
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
            this.pnl_Search.TabIndex = 3;
            this.pnl_Search.Text = "جستجو";
            // 
            // btn_Search
            // 
            this.btn_Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Search.Location = new System.Drawing.Point(28, 13);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(97, 86);
            this.btn_Search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Search.Symbol = "";
            this.btn_Search.TabIndex = 4;
            // 
            // txt_SearchSender
            // 
            // 
            // 
            // 
            this.txt_SearchSender.Border.Class = "TextBoxBorder";
            this.txt_SearchSender.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SearchSender.Location = new System.Drawing.Point(164, 63);
            this.txt_SearchSender.Name = "txt_SearchSender";
            this.txt_SearchSender.PreventEnterBeep = true;
            this.txt_SearchSender.Size = new System.Drawing.Size(311, 36);
            this.txt_SearchSender.TabIndex = 2;
            this.txt_SearchSender.WatermarkText = "جستجو در فرستنده يادداشت...";
            // 
            // txt_SearchContext
            // 
            // 
            // 
            // 
            this.txt_SearchContext.Border.Class = "TextBoxBorder";
            this.txt_SearchContext.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SearchContext.Location = new System.Drawing.Point(548, 63);
            this.txt_SearchContext.Name = "txt_SearchContext";
            this.txt_SearchContext.PreventEnterBeep = true;
            this.txt_SearchContext.Size = new System.Drawing.Size(353, 36);
            this.txt_SearchContext.TabIndex = 3;
            this.txt_SearchContext.WatermarkText = "جستجو در متن يادداشت‌ها...";
            // 
            // txt_SearchSubject
            // 
            // 
            // 
            // 
            this.txt_SearchSubject.Border.Class = "TextBoxBorder";
            this.txt_SearchSubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SearchSubject.Location = new System.Drawing.Point(164, 11);
            this.txt_SearchSubject.Name = "txt_SearchSubject";
            this.txt_SearchSubject.PreventEnterBeep = true;
            this.txt_SearchSubject.Size = new System.Drawing.Size(311, 36);
            this.txt_SearchSubject.TabIndex = 1;
            this.txt_SearchSubject.WatermarkText = "جستجو در موضوع نيادداشت‌ها...";
            // 
            // txt_NoteDateTo
            // 
            this.txt_NoteDateTo.BackColor = System.Drawing.Color.White;
            this.txt_NoteDateTo.Font = new System.Drawing.Font("B Nazanin", 14F);
            this.txt_NoteDateTo.Location = new System.Drawing.Point(548, 11);
            this.txt_NoteDateTo.Name = "txt_NoteDateTo";
            this.txt_NoteDateTo.ShowTime = false;
            this.txt_NoteDateTo.Size = new System.Drawing.Size(165, 33);
            this.txt_NoteDateTo.TabIndex = 13;
            this.txt_NoteDateTo.Text = "persianDateTimePicker2";
            this.txt_NoteDateTo.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_NoteDateTo.Value")));
            // 
            // txt_NoteDateIn
            // 
            this.txt_NoteDateIn.BackColor = System.Drawing.Color.White;
            this.txt_NoteDateIn.Font = new System.Drawing.Font("B Nazanin", 14F);
            this.txt_NoteDateIn.Location = new System.Drawing.Point(736, 11);
            this.txt_NoteDateIn.Name = "txt_NoteDateIn";
            this.txt_NoteDateIn.ShowTime = false;
            this.txt_NoteDateIn.Size = new System.Drawing.Size(165, 33);
            this.txt_NoteDateIn.TabIndex = 12;
            this.txt_NoteDateIn.Text = "persianDateTimePicker1";
            this.txt_NoteDateIn.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_NoteDateIn.Value")));
            // 
            // lbl_RemindDateTo
            // 
            // 
            // 
            // 
            this.lbl_RemindDateTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_RemindDateTo.Location = new System.Drawing.Point(719, 13);
            this.lbl_RemindDateTo.Name = "lbl_RemindDateTo";
            this.lbl_RemindDateTo.Size = new System.Drawing.Size(11, 27);
            this.lbl_RemindDateTo.TabIndex = 11;
            this.lbl_RemindDateTo.Text = "تا";
            // 
            // lbl_SearchContext
            // 
            // 
            // 
            // 
            this.lbl_SearchContext.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SearchContext.Location = new System.Drawing.Point(910, 66);
            this.lbl_SearchContext.Name = "lbl_SearchContext";
            this.lbl_SearchContext.Size = new System.Drawing.Size(84, 27);
            this.lbl_SearchContext.TabIndex = 10;
            this.lbl_SearchContext.Text = "متن يادداشت:";
            // 
            // lbl_SearchSender
            // 
            // 
            // 
            // 
            this.lbl_SearchSender.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SearchSender.Location = new System.Drawing.Point(481, 68);
            this.lbl_SearchSender.Name = "lbl_SearchSender";
            this.lbl_SearchSender.Size = new System.Drawing.Size(54, 27);
            this.lbl_SearchSender.TabIndex = 10;
            this.lbl_SearchSender.Text = "فرستنده:";
            // 
            // lbl_SearchSubject
            // 
            // 
            // 
            // 
            this.lbl_SearchSubject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SearchSubject.Location = new System.Drawing.Point(481, 13);
            this.lbl_SearchSubject.Name = "lbl_SearchSubject";
            this.lbl_SearchSubject.Size = new System.Drawing.Size(46, 27);
            this.lbl_SearchSubject.TabIndex = 10;
            this.lbl_SearchSubject.Text = "موضوع:";
            // 
            // lbl_NoteDateIn
            // 
            // 
            // 
            // 
            this.lbl_NoteDateIn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_NoteDateIn.Location = new System.Drawing.Point(907, 13);
            this.lbl_NoteDateIn.Name = "lbl_NoteDateIn";
            this.lbl_NoteDateIn.Size = new System.Drawing.Size(87, 27);
            this.lbl_NoteDateIn.TabIndex = 10;
            this.lbl_NoteDateIn.Text = "تاريخ ارسال از:";
            // 
            // frmUserShowReciveNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmUserShowReciveNotes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUserShowReciveNotes_Load);
            this.panelEx1.ResumeLayout(false);
            this.pnl_ReciveNotes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReciveNotes)).EndInit();
            this.pnl_Search.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_ReciveNotes;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_ReciveNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SentNoteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NoteSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NoteContext;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SenderFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NoteSenderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NoteReciveDate;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Search;
        private DevComponents.DotNetBar.ButtonX btn_Search;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SearchSender;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SearchContext;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SearchSubject;
        private FreeControls.PersianDateTimePicker txt_NoteDateTo;
        private FreeControls.PersianDateTimePicker txt_NoteDateIn;
        private DevComponents.DotNetBar.LabelX lbl_RemindDateTo;
        private DevComponents.DotNetBar.LabelX lbl_SearchContext;
        private DevComponents.DotNetBar.LabelX lbl_SearchSender;
        private DevComponents.DotNetBar.LabelX lbl_SearchSubject;
        private DevComponents.DotNetBar.LabelX lbl_NoteDateIn;
    }
}