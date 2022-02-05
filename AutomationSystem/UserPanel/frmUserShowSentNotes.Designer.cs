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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserShowSentNotes));
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
            this.txt_NoteDateTo = new FreeControls.PersianDateTimePicker();
            this.txt_NoteDateIn = new FreeControls.PersianDateTimePicker();
            this.lbl_RemindDateTo = new DevComponents.DotNetBar.LabelX();
            this.lbl_NoteDateIn = new DevComponents.DotNetBar.LabelX();
            this.lbl_SearchSubject = new DevComponents.DotNetBar.LabelX();
            this.lbl_SearchReciver = new DevComponents.DotNetBar.LabelX();
            this.lbl_SearchContext = new DevComponents.DotNetBar.LabelX();
            this.txt_SearchSubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_SearchReciver = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_SearchContext = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_Search = new DevComponents.DotNetBar.ButtonX();
            this.pnl_Main.SuspendLayout();
            this.pnl_SentNotes.SuspendLayout();
            this.pnl_Search.SuspendLayout();
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
            this.pnl_Search.Controls.Add(this.btn_Search);
            this.pnl_Search.Controls.Add(this.txt_SearchReciver);
            this.pnl_Search.Controls.Add(this.txt_SearchContext);
            this.pnl_Search.Controls.Add(this.txt_SearchSubject);
            this.pnl_Search.Controls.Add(this.txt_NoteDateTo);
            this.pnl_Search.Controls.Add(this.txt_NoteDateIn);
            this.pnl_Search.Controls.Add(this.lbl_RemindDateTo);
            this.pnl_Search.Controls.Add(this.lbl_SearchContext);
            this.pnl_Search.Controls.Add(this.lbl_SearchReciver);
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
            this.pnl_Search.TabIndex = 2;
            this.pnl_Search.Text = "جستجو";
            // 
            // dgv_SentNotes
            // 
            this.dgv_SentNotes.AllowUserToAddRows = false;
            this.dgv_SentNotes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_SentNotes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SentNotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_SentNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SentNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_SentNoteID,
            this.col_NoteSubject,
            this.col_NoteContext,
            this.col_ReciverFullName,
            this.col_NoteReciverID,
            this.col_NoteCreateDate});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SentNotes.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_SentNotes.EnableHeadersVisualStyles = false;
            this.dgv_SentNotes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(181)))), ((int)(((byte)(252)))));
            this.dgv_SentNotes.Location = new System.Drawing.Point(3, 3);
            this.dgv_SentNotes.Name = "dgv_SentNotes";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SentNotes.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
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
            // lbl_NoteDateIn
            // 
            // 
            // 
            // 
            this.lbl_NoteDateIn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_NoteDateIn.Location = new System.Drawing.Point(907, 13);
            this.lbl_NoteDateIn.Name = "lbl_NoteDateIn";
            this.lbl_NoteDateIn.Size = new System.Drawing.Size(99, 27);
            this.lbl_NoteDateIn.TabIndex = 10;
            this.lbl_NoteDateIn.Text = "تاريخ يادآوري از:";
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
            // lbl_SearchReciver
            // 
            // 
            // 
            // 
            this.lbl_SearchReciver.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SearchReciver.Location = new System.Drawing.Point(481, 65);
            this.lbl_SearchReciver.Name = "lbl_SearchReciver";
            this.lbl_SearchReciver.Size = new System.Drawing.Size(44, 27);
            this.lbl_SearchReciver.TabIndex = 10;
            this.lbl_SearchReciver.Text = "گيرنده:";
            // 
            // lbl_SearchContext
            // 
            // 
            // 
            // 
            this.lbl_SearchContext.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SearchContext.Location = new System.Drawing.Point(925, 68);
            this.lbl_SearchContext.Name = "lbl_SearchContext";
            this.lbl_SearchContext.Size = new System.Drawing.Size(84, 27);
            this.lbl_SearchContext.TabIndex = 10;
            this.lbl_SearchContext.Text = "متن يادداشت:";
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
            // txt_SearchReciver
            // 
            // 
            // 
            // 
            this.txt_SearchReciver.Border.Class = "TextBoxBorder";
            this.txt_SearchReciver.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SearchReciver.Location = new System.Drawing.Point(164, 63);
            this.txt_SearchReciver.Name = "txt_SearchReciver";
            this.txt_SearchReciver.PreventEnterBeep = true;
            this.txt_SearchReciver.Size = new System.Drawing.Size(311, 36);
            this.txt_SearchReciver.TabIndex = 2;
            this.txt_SearchReciver.WatermarkText = "جستجو در گيرنده يادداشت...";
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
            this.txt_SearchContext.Size = new System.Drawing.Size(371, 36);
            this.txt_SearchContext.TabIndex = 3;
            this.txt_SearchContext.WatermarkText = "جستجو در متن يادداشت‌ها...";
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
            this.pnl_Search.ResumeLayout(false);
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
        private FreeControls.PersianDateTimePicker txt_NoteDateTo;
        private FreeControls.PersianDateTimePicker txt_NoteDateIn;
        private DevComponents.DotNetBar.LabelX lbl_RemindDateTo;
        private DevComponents.DotNetBar.LabelX lbl_NoteDateIn;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SearchReciver;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SearchContext;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SearchSubject;
        private DevComponents.DotNetBar.LabelX lbl_SearchContext;
        private DevComponents.DotNetBar.LabelX lbl_SearchReciver;
        private DevComponents.DotNetBar.LabelX lbl_SearchSubject;
        private DevComponents.DotNetBar.ButtonX btn_Search;
    }
}