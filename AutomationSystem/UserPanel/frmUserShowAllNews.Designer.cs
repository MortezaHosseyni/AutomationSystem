namespace AutomationSystem.UserPanel
{
    partial class frmUserShowAllNews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserShowAllNews));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.col_NewsAttachment = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btn_Search = new DevComponents.DotNetBar.ButtonX();
            this.txt_NewsContext = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_NewsSubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_DateTo = new FreeControls.PersianDateTimePicker();
            this.txt_DateOn = new FreeControls.PersianDateTimePicker();
            this.lbl_DateTo = new DevComponents.DotNetBar.LabelX();
            this.lbl_NewsContext = new DevComponents.DotNetBar.LabelX();
            this.lbl_NewsSubject = new DevComponents.DotNetBar.LabelX();
            this.col_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NewsDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NewsContext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NewsSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_DateOn = new DevComponents.DotNetBar.LabelX();
            this.dgv_NewsList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_NewsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Search = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.pnl_NewsList = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NewsList)).BeginInit();
            this.pnl_Search.SuspendLayout();
            this.pnl_NewsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.pnl_Search);
            this.panelEx1.Controls.Add(this.pnl_NewsList);
            this.panelEx1.Controls.Add(this.lbl_Title);
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
            // col_NewsAttachment
            // 
            this.col_NewsAttachment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_NewsAttachment.HeaderText = "فايل الصاقي";
            this.col_NewsAttachment.Name = "col_NewsAttachment";
            this.col_NewsAttachment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_NewsAttachment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_NewsAttachment.Width = 104;
            // 
            // btn_Search
            // 
            this.btn_Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Search.Location = new System.Drawing.Point(51, 24);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(110, 84);
            this.btn_Search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Search.Symbol = "";
            this.btn_Search.TabIndex = 12;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click_1);
            // 
            // txt_NewsContext
            // 
            // 
            // 
            // 
            this.txt_NewsContext.Border.Class = "TextBoxBorder";
            this.txt_NewsContext.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_NewsContext.Location = new System.Drawing.Point(194, 72);
            this.txt_NewsContext.Name = "txt_NewsContext";
            this.txt_NewsContext.PreventEnterBeep = true;
            this.txt_NewsContext.Size = new System.Drawing.Size(701, 36);
            this.txt_NewsContext.TabIndex = 10;
            this.txt_NewsContext.WatermarkText = "جستجو در متن اطلاعيه...";
            // 
            // txt_NewsSubject
            // 
            // 
            // 
            // 
            this.txt_NewsSubject.Border.Class = "TextBoxBorder";
            this.txt_NewsSubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_NewsSubject.Location = new System.Drawing.Point(194, 24);
            this.txt_NewsSubject.Name = "txt_NewsSubject";
            this.txt_NewsSubject.PreventEnterBeep = true;
            this.txt_NewsSubject.Size = new System.Drawing.Size(240, 36);
            this.txt_NewsSubject.TabIndex = 11;
            this.txt_NewsSubject.WatermarkText = "جستجو در موضوع اطلاعيه...";
            // 
            // txt_DateTo
            // 
            this.txt_DateTo.BackColor = System.Drawing.Color.White;
            this.txt_DateTo.Font = new System.Drawing.Font("B Nazanin", 14.25F);
            this.txt_DateTo.Location = new System.Drawing.Point(539, 24);
            this.txt_DateTo.Name = "txt_DateTo";
            this.txt_DateTo.ShowTime = false;
            this.txt_DateTo.Size = new System.Drawing.Size(169, 34);
            this.txt_DateTo.TabIndex = 8;
            this.txt_DateTo.Text = "persianDateTimePicker1";
            this.txt_DateTo.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_DateTo.Value")));
            // 
            // txt_DateOn
            // 
            this.txt_DateOn.BackColor = System.Drawing.Color.White;
            this.txt_DateOn.Font = new System.Drawing.Font("B Nazanin", 14.25F);
            this.txt_DateOn.Location = new System.Drawing.Point(730, 24);
            this.txt_DateOn.Name = "txt_DateOn";
            this.txt_DateOn.ShowTime = false;
            this.txt_DateOn.Size = new System.Drawing.Size(165, 34);
            this.txt_DateOn.TabIndex = 9;
            this.txt_DateOn.Text = "persianDateTimePicker1";
            this.txt_DateOn.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_DateOn.Value")));
            // 
            // lbl_DateTo
            // 
            // 
            // 
            // 
            this.lbl_DateTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_DateTo.Location = new System.Drawing.Point(714, 28);
            this.lbl_DateTo.Name = "lbl_DateTo";
            this.lbl_DateTo.Size = new System.Drawing.Size(10, 25);
            this.lbl_DateTo.TabIndex = 4;
            this.lbl_DateTo.Text = "تا";
            // 
            // lbl_NewsContext
            // 
            // 
            // 
            // 
            this.lbl_NewsContext.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_NewsContext.Location = new System.Drawing.Point(901, 78);
            this.lbl_NewsContext.Name = "lbl_NewsContext";
            this.lbl_NewsContext.Size = new System.Drawing.Size(76, 25);
            this.lbl_NewsContext.TabIndex = 5;
            this.lbl_NewsContext.Text = "متن اطلاعيه:";
            // 
            // lbl_NewsSubject
            // 
            // 
            // 
            // 
            this.lbl_NewsSubject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_NewsSubject.Location = new System.Drawing.Point(440, 30);
            this.lbl_NewsSubject.Name = "lbl_NewsSubject";
            this.lbl_NewsSubject.Size = new System.Drawing.Size(71, 25);
            this.lbl_NewsSubject.TabIndex = 6;
            this.lbl_NewsSubject.Text = "موضوع خبر:";
            // 
            // col_FullName
            // 
            this.col_FullName.HeaderText = "نويسنده خبر";
            this.col_FullName.Name = "col_FullName";
            this.col_FullName.Width = 160;
            // 
            // col_NewsDate
            // 
            this.col_NewsDate.HeaderText = "تاريخ خبر";
            this.col_NewsDate.Name = "col_NewsDate";
            this.col_NewsDate.Width = 130;
            // 
            // col_NewsContext
            // 
            this.col_NewsContext.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_NewsContext.HeaderText = "متن";
            this.col_NewsContext.Name = "col_NewsContext";
            // 
            // col_NewsSubject
            // 
            this.col_NewsSubject.HeaderText = "موضوع";
            this.col_NewsSubject.Name = "col_NewsSubject";
            this.col_NewsSubject.Width = 160;
            // 
            // lbl_DateOn
            // 
            // 
            // 
            // 
            this.lbl_DateOn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_DateOn.Location = new System.Drawing.Point(901, 28);
            this.lbl_DateOn.Name = "lbl_DateOn";
            this.lbl_DateOn.Size = new System.Drawing.Size(44, 25);
            this.lbl_DateOn.TabIndex = 7;
            this.lbl_DateOn.Text = "از تاريخ";
            // 
            // dgv_NewsList
            // 
            this.dgv_NewsList.AllowUserToAddRows = false;
            this.dgv_NewsList.AllowUserToDeleteRows = false;
            this.dgv_NewsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NewsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_NewsID,
            this.col_NewsSubject,
            this.col_NewsContext,
            this.col_NewsDate,
            this.col_FullName,
            this.col_NewsAttachment});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_NewsList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_NewsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(181)))), ((int)(((byte)(252)))));
            this.dgv_NewsList.Location = new System.Drawing.Point(3, 3);
            this.dgv_NewsList.Name = "dgv_NewsList";
            this.dgv_NewsList.Size = new System.Drawing.Size(1014, 361);
            this.dgv_NewsList.TabIndex = 0;
            this.dgv_NewsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NewsList_CellClick);
            this.dgv_NewsList.DoubleClick += new System.EventHandler(this.dgv_NewsList_DoubleClick);
            // 
            // col_NewsID
            // 
            this.col_NewsID.HeaderText = "NewsID";
            this.col_NewsID.Name = "col_NewsID";
            this.col_NewsID.Visible = false;
            // 
            // pnl_Search
            // 
            this.pnl_Search.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Search.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Search.Controls.Add(this.btn_Search);
            this.pnl_Search.Controls.Add(this.txt_NewsContext);
            this.pnl_Search.Controls.Add(this.txt_NewsSubject);
            this.pnl_Search.Controls.Add(this.txt_DateTo);
            this.pnl_Search.Controls.Add(this.txt_DateOn);
            this.pnl_Search.Controls.Add(this.lbl_DateTo);
            this.pnl_Search.Controls.Add(this.lbl_NewsContext);
            this.pnl_Search.Controls.Add(this.lbl_NewsSubject);
            this.pnl_Search.Controls.Add(this.lbl_DateOn);
            this.pnl_Search.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Search.Location = new System.Drawing.Point(12, 436);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(1026, 162);
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
            this.pnl_Search.TabIndex = 6;
            this.pnl_Search.Text = "جستجو";
            // 
            // pnl_NewsList
            // 
            this.pnl_NewsList.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_NewsList.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_NewsList.Controls.Add(this.dgv_NewsList);
            this.pnl_NewsList.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_NewsList.Location = new System.Drawing.Point(12, 57);
            this.pnl_NewsList.Name = "pnl_NewsList";
            this.pnl_NewsList.Size = new System.Drawing.Size(1026, 373);
            // 
            // 
            // 
            this.pnl_NewsList.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_NewsList.Style.BackColorGradientAngle = 90;
            this.pnl_NewsList.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_NewsList.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_NewsList.Style.BorderBottomWidth = 1;
            this.pnl_NewsList.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_NewsList.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_NewsList.Style.BorderLeftWidth = 1;
            this.pnl_NewsList.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_NewsList.Style.BorderRightWidth = 1;
            this.pnl_NewsList.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_NewsList.Style.BorderTopWidth = 1;
            this.pnl_NewsList.Style.CornerDiameter = 4;
            this.pnl_NewsList.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_NewsList.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_NewsList.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_NewsList.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_NewsList.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_NewsList.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_NewsList.TabIndex = 5;
            // 
            // lbl_Title
            // 
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("B Nazanin", 22.25F);
            this.lbl_Title.Location = new System.Drawing.Point(364, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(251, 51);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "ليست اخبار و اطلاعيه‌ها";
            // 
            // frmUserShowAllNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmUserShowAllNews";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUserShowAllNews_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NewsList)).EndInit();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_NewsList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Search;
        private DevComponents.DotNetBar.ButtonX btn_Search;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_NewsContext;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_NewsSubject;
        private FreeControls.PersianDateTimePicker txt_DateTo;
        private FreeControls.PersianDateTimePicker txt_DateOn;
        private DevComponents.DotNetBar.LabelX lbl_DateTo;
        private DevComponents.DotNetBar.LabelX lbl_NewsContext;
        private DevComponents.DotNetBar.LabelX lbl_NewsSubject;
        private DevComponents.DotNetBar.LabelX lbl_DateOn;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_NewsList;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_NewsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NewsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NewsSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NewsContext;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NewsDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FullName;
        private System.Windows.Forms.DataGridViewLinkColumn col_NewsAttachment;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}