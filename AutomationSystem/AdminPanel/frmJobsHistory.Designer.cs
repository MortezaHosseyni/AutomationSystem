namespace AutomationSystem.AdminPanel
{
    partial class frmJobsHistory
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
            this.pnl_Buttons = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.btn_DismissalJob = new DevComponents.DotNetBar.ButtonX();
            this.btn_AsignmentJob = new DevComponents.DotNetBar.ButtonX();
            this.pnl_JobsList = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv_UserJobHistory = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_AsignJobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_JobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AsignAsigntedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AsignDismissalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AsignStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_UserFristAndLastName = new DevComponents.DotNetBar.LabelX();
            this.lbl_Jobs = new DevComponents.DotNetBar.LabelX();
            this.pnl_Main.SuspendLayout();
            this.pnl_Buttons.SuspendLayout();
            this.pnl_JobsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserJobHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.pnl_Buttons);
            this.pnl_Main.Controls.Add(this.pnl_JobsList);
            this.pnl_Main.Controls.Add(this.lbl_UserFristAndLastName);
            this.pnl_Main.Controls.Add(this.lbl_Jobs);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(863, 494);
            this.pnl_Main.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl_Main.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Main.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Main.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl_Main.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Main.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Main.Style.GradientAngle = 90;
            this.pnl_Main.TabIndex = 0;
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Buttons.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Buttons.Controls.Add(this.btn_Exit);
            this.pnl_Buttons.Controls.Add(this.btn_DismissalJob);
            this.pnl_Buttons.Controls.Add(this.btn_AsignmentJob);
            this.pnl_Buttons.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Buttons.Location = new System.Drawing.Point(12, 382);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(839, 100);
            // 
            // 
            // 
            this.pnl_Buttons.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Buttons.Style.BackColorGradientAngle = 90;
            this.pnl_Buttons.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Buttons.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Buttons.Style.BorderBottomWidth = 1;
            this.pnl_Buttons.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Buttons.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Buttons.Style.BorderLeftWidth = 1;
            this.pnl_Buttons.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Buttons.Style.BorderRightWidth = 1;
            this.pnl_Buttons.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Buttons.Style.BorderTopWidth = 1;
            this.pnl_Buttons.Style.CornerDiameter = 4;
            this.pnl_Buttons.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_Buttons.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_Buttons.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Buttons.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_Buttons.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_Buttons.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_Buttons.TabIndex = 7;
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Exit.Location = new System.Drawing.Point(160, 14);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 2, 20, 20);
            this.btn_Exit.Size = new System.Drawing.Size(177, 55);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.Symbol = "";
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "خروج";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_DismissalJob
            // 
            this.btn_DismissalJob.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_DismissalJob.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_DismissalJob.Location = new System.Drawing.Point(343, 14);
            this.btn_DismissalJob.Name = "btn_DismissalJob";
            this.btn_DismissalJob.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 2, 20, 20);
            this.btn_DismissalJob.Size = new System.Drawing.Size(177, 55);
            this.btn_DismissalJob.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_DismissalJob.Symbol = "58684";
            this.btn_DismissalJob.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn_DismissalJob.TabIndex = 0;
            this.btn_DismissalJob.Text = "عزل كردن";
            this.btn_DismissalJob.Click += new System.EventHandler(this.btn_DismissalJob_Click);
            // 
            // btn_AsignmentJob
            // 
            this.btn_AsignmentJob.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_AsignmentJob.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_AsignmentJob.Location = new System.Drawing.Point(526, 14);
            this.btn_AsignmentJob.Name = "btn_AsignmentJob";
            this.btn_AsignmentJob.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 2, 20, 20);
            this.btn_AsignmentJob.Size = new System.Drawing.Size(177, 55);
            this.btn_AsignmentJob.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_AsignmentJob.Symbol = "58683";
            this.btn_AsignmentJob.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn_AsignmentJob.TabIndex = 0;
            this.btn_AsignmentJob.Text = "انتساب شغل";
            this.btn_AsignmentJob.Click += new System.EventHandler(this.btn_AsignmentJob_Click);
            // 
            // pnl_JobsList
            // 
            this.pnl_JobsList.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_JobsList.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_JobsList.Controls.Add(this.dgv_UserJobHistory);
            this.pnl_JobsList.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_JobsList.Location = new System.Drawing.Point(12, 65);
            this.pnl_JobsList.Name = "pnl_JobsList";
            this.pnl_JobsList.Size = new System.Drawing.Size(839, 311);
            // 
            // 
            // 
            this.pnl_JobsList.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_JobsList.Style.BackColorGradientAngle = 90;
            this.pnl_JobsList.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_JobsList.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_JobsList.Style.BorderBottomWidth = 1;
            this.pnl_JobsList.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_JobsList.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_JobsList.Style.BorderLeftWidth = 1;
            this.pnl_JobsList.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_JobsList.Style.BorderRightWidth = 1;
            this.pnl_JobsList.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_JobsList.Style.BorderTopWidth = 1;
            this.pnl_JobsList.Style.CornerDiameter = 4;
            this.pnl_JobsList.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_JobsList.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_JobsList.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_JobsList.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_JobsList.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_JobsList.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_JobsList.TabIndex = 6;
            this.pnl_JobsList.Text = "ليست مشاغل";
            // 
            // dgv_UserJobHistory
            // 
            this.dgv_UserJobHistory.AllowUserToAddRows = false;
            this.dgv_UserJobHistory.AllowUserToDeleteRows = false;
            this.dgv_UserJobHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserJobHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_AsignJobID,
            this.col_FullName,
            this.col_JobName,
            this.col_AsignAsigntedDate,
            this.col_AsignDismissalDate,
            this.col_AsignStatus});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_UserJobHistory.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_UserJobHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_UserJobHistory.Location = new System.Drawing.Point(3, 3);
            this.dgv_UserJobHistory.Name = "dgv_UserJobHistory";
            this.dgv_UserJobHistory.Size = new System.Drawing.Size(827, 268);
            this.dgv_UserJobHistory.TabIndex = 0;
            // 
            // col_AsignJobID
            // 
            this.col_AsignJobID.HeaderText = "AsignJobID";
            this.col_AsignJobID.Name = "col_AsignJobID";
            this.col_AsignJobID.Visible = false;
            // 
            // col_FullName
            // 
            this.col_FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_FullName.HeaderText = "نام و نام‌خانوادگي";
            this.col_FullName.Name = "col_FullName";
            // 
            // col_JobName
            // 
            this.col_JobName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_JobName.HeaderText = "عنوان شغلي";
            this.col_JobName.Name = "col_JobName";
            // 
            // col_AsignAsigntedDate
            // 
            this.col_AsignAsigntedDate.HeaderText = "تاريخ انتساب";
            this.col_AsignAsigntedDate.Name = "col_AsignAsigntedDate";
            this.col_AsignAsigntedDate.Width = 150;
            // 
            // col_AsignDismissalDate
            // 
            this.col_AsignDismissalDate.HeaderText = "تاريخ عزل";
            this.col_AsignDismissalDate.Name = "col_AsignDismissalDate";
            this.col_AsignDismissalDate.Width = 150;
            // 
            // col_AsignStatus
            // 
            this.col_AsignStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_AsignStatus.HeaderText = "وضعيت";
            this.col_AsignStatus.Name = "col_AsignStatus";
            this.col_AsignStatus.Width = 81;
            // 
            // lbl_UserFristAndLastName
            // 
            // 
            // 
            // 
            this.lbl_UserFristAndLastName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_UserFristAndLastName.Font = new System.Drawing.Font("B Nazanin", 22.25F);
            this.lbl_UserFristAndLastName.ForeColor = System.Drawing.Color.Blue;
            this.lbl_UserFristAndLastName.Location = new System.Drawing.Point(39, 12);
            this.lbl_UserFristAndLastName.Name = "lbl_UserFristAndLastName";
            this.lbl_UserFristAndLastName.Size = new System.Drawing.Size(418, 47);
            this.lbl_UserFristAndLastName.TabIndex = 5;
            this.lbl_UserFristAndLastName.Text = "نام و نام خانوادگي";
            // 
            // lbl_Jobs
            // 
            // 
            // 
            // 
            this.lbl_Jobs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Jobs.Font = new System.Drawing.Font("B Nazanin", 22.25F);
            this.lbl_Jobs.Location = new System.Drawing.Point(463, 12);
            this.lbl_Jobs.Name = "lbl_Jobs";
            this.lbl_Jobs.Size = new System.Drawing.Size(68, 47);
            this.lbl_Jobs.TabIndex = 4;
            this.lbl_Jobs.Text = "مشاغل";
            // 
            // frmJobsHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 494);
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmJobsHistory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmJobsHistory_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Buttons.ResumeLayout(false);
            this.pnl_JobsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserJobHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.LabelX lbl_Jobs;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Buttons;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_JobsList;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
        private DevComponents.DotNetBar.ButtonX btn_DismissalJob;
        private DevComponents.DotNetBar.ButtonX btn_AsignmentJob;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_UserJobHistory;
        internal DevComponents.DotNetBar.LabelX lbl_UserFristAndLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AsignJobID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_JobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AsignAsigntedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AsignDismissalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AsignStatus;
    }
}