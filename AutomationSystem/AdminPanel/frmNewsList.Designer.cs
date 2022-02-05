namespace AutomationSystem.AdminPanel
{
    partial class frmNewsList
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
            this.pnl_Main = new DevComponents.DotNetBar.PanelEx();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.pnl_NewsList = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.pnl_Search = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv_NewsList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.col_NewsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NewsSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NewsContext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NewsDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NewsAttachment = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pnl_Main.SuspendLayout();
            this.pnl_NewsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NewsList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.btn_Exit);
            this.pnl_Main.Controls.Add(this.pnl_Search);
            this.pnl_Main.Controls.Add(this.pnl_NewsList);
            this.pnl_Main.Controls.Add(this.lbl_Title);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(965, 568);
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
            this.lbl_Title.Location = new System.Drawing.Point(347, 3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(251, 51);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "ليست اخبار و اطلاعيه‌ها";
            // 
            // pnl_NewsList
            // 
            this.pnl_NewsList.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_NewsList.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_NewsList.Controls.Add(this.dgv_NewsList);
            this.pnl_NewsList.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_NewsList.Location = new System.Drawing.Point(12, 60);
            this.pnl_NewsList.Name = "pnl_NewsList";
            this.pnl_NewsList.Size = new System.Drawing.Size(941, 306);
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
            this.pnl_NewsList.TabIndex = 1;
            // 
            // pnl_Search
            // 
            this.pnl_Search.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Search.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Search.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Search.Location = new System.Drawing.Point(12, 372);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(941, 132);
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
            this.dgv_NewsList.Size = new System.Drawing.Size(929, 294);
            this.dgv_NewsList.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Exit.Location = new System.Drawing.Point(361, 510);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 2, 20, 20);
            this.btn_Exit.Size = new System.Drawing.Size(247, 46);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.Symbol = "";
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "خروج";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // col_NewsID
            // 
            this.col_NewsID.HeaderText = "NewsID";
            this.col_NewsID.Name = "col_NewsID";
            this.col_NewsID.Visible = false;
            // 
            // col_NewsSubject
            // 
            this.col_NewsSubject.HeaderText = "موضوع";
            this.col_NewsSubject.Name = "col_NewsSubject";
            this.col_NewsSubject.Width = 160;
            // 
            // col_NewsContext
            // 
            this.col_NewsContext.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_NewsContext.HeaderText = "متن";
            this.col_NewsContext.Name = "col_NewsContext";
            // 
            // col_NewsDate
            // 
            this.col_NewsDate.HeaderText = "تاريخ خبر";
            this.col_NewsDate.Name = "col_NewsDate";
            this.col_NewsDate.Width = 130;
            // 
            // col_FullName
            // 
            this.col_FullName.HeaderText = "نويسنده خبر";
            this.col_FullName.Name = "col_FullName";
            this.col_FullName.Width = 160;
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
            // frmNewsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 568);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmNewsList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmNewsList_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_NewsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NewsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Search;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_NewsList;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_NewsList;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NewsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NewsSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NewsContext;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NewsDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FullName;
        private System.Windows.Forms.DataGridViewLinkColumn col_NewsAttachment;
    }
}