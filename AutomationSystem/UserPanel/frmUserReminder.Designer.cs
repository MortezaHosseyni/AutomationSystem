namespace AutomationSystem.UserPanel
{
    partial class frmUserReminder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserReminder));
            this.pnl_Main = new DevComponents.DotNetBar.PanelEx();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.pnl_ReminderList = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.pnl_SearchReminder = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv_Reminders = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txt_RemindDateTo = new FreeControls.PersianDateTimePicker();
            this.txt_RemindDateIn = new FreeControls.PersianDateTimePicker();
            this.btn_RemindSearch = new DevComponents.DotNetBar.ButtonX();
            this.lbl_RemindDateTo = new DevComponents.DotNetBar.LabelX();
            this.lbl_RemindDateIn = new DevComponents.DotNetBar.LabelX();
            this.txt_RemindSubjectSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_RemindSubjectSearch = new DevComponents.DotNetBar.LabelX();
            this.col_RemindSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RemindCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RemindCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RemindRememberDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RemindStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RemindID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RemindIsRead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Main.SuspendLayout();
            this.pnl_ReminderList.SuspendLayout();
            this.pnl_SearchReminder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reminders)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.pnl_SearchReminder);
            this.pnl_Main.Controls.Add(this.pnl_ReminderList);
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
            this.lbl_Title.Location = new System.Drawing.Point(400, 12);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(233, 43);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "فرم يادآوري‌هاي كاربر";
            // 
            // pnl_ReminderList
            // 
            this.pnl_ReminderList.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_ReminderList.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_ReminderList.Controls.Add(this.dgv_Reminders);
            this.pnl_ReminderList.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_ReminderList.Location = new System.Drawing.Point(12, 61);
            this.pnl_ReminderList.Name = "pnl_ReminderList";
            this.pnl_ReminderList.Size = new System.Drawing.Size(1026, 435);
            // 
            // 
            // 
            this.pnl_ReminderList.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_ReminderList.Style.BackColorGradientAngle = 90;
            this.pnl_ReminderList.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_ReminderList.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_ReminderList.Style.BorderBottomWidth = 1;
            this.pnl_ReminderList.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_ReminderList.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_ReminderList.Style.BorderLeftWidth = 1;
            this.pnl_ReminderList.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_ReminderList.Style.BorderRightWidth = 1;
            this.pnl_ReminderList.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_ReminderList.Style.BorderTopWidth = 1;
            this.pnl_ReminderList.Style.CornerDiameter = 4;
            this.pnl_ReminderList.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_ReminderList.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_ReminderList.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_ReminderList.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_ReminderList.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_ReminderList.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_ReminderList.TabIndex = 1;
            this.pnl_ReminderList.Text = "ليست يادآوري‌هاي شما";
            // 
            // pnl_SearchReminder
            // 
            this.pnl_SearchReminder.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_SearchReminder.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_SearchReminder.Controls.Add(this.txt_RemindDateTo);
            this.pnl_SearchReminder.Controls.Add(this.txt_RemindDateIn);
            this.pnl_SearchReminder.Controls.Add(this.btn_RemindSearch);
            this.pnl_SearchReminder.Controls.Add(this.lbl_RemindDateTo);
            this.pnl_SearchReminder.Controls.Add(this.lbl_RemindDateIn);
            this.pnl_SearchReminder.Controls.Add(this.txt_RemindSubjectSearch);
            this.pnl_SearchReminder.Controls.Add(this.lbl_RemindSubjectSearch);
            this.pnl_SearchReminder.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_SearchReminder.Location = new System.Drawing.Point(12, 502);
            this.pnl_SearchReminder.Name = "pnl_SearchReminder";
            this.pnl_SearchReminder.Size = new System.Drawing.Size(1026, 96);
            // 
            // 
            // 
            this.pnl_SearchReminder.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_SearchReminder.Style.BackColorGradientAngle = 90;
            this.pnl_SearchReminder.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_SearchReminder.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SearchReminder.Style.BorderBottomWidth = 1;
            this.pnl_SearchReminder.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_SearchReminder.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SearchReminder.Style.BorderLeftWidth = 1;
            this.pnl_SearchReminder.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SearchReminder.Style.BorderRightWidth = 1;
            this.pnl_SearchReminder.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SearchReminder.Style.BorderTopWidth = 1;
            this.pnl_SearchReminder.Style.CornerDiameter = 4;
            this.pnl_SearchReminder.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_SearchReminder.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_SearchReminder.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_SearchReminder.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_SearchReminder.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_SearchReminder.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_SearchReminder.TabIndex = 2;
            // 
            // dgv_Reminders
            // 
            this.dgv_Reminders.AllowUserToAddRows = false;
            this.dgv_Reminders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_Reminders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Reminders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Reminders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Reminders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_RemindSubject,
            this.col_RemindCaption,
            this.col_RemindCreatedDate,
            this.col_RemindRememberDate,
            this.col_RemindStatus,
            this.col_RemindID,
            this.col_RemindIsRead});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Reminders.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Reminders.EnableHeadersVisualStyles = false;
            this.dgv_Reminders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(181)))), ((int)(((byte)(252)))));
            this.dgv_Reminders.Location = new System.Drawing.Point(3, 3);
            this.dgv_Reminders.Name = "dgv_Reminders";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Reminders.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Reminders.Size = new System.Drawing.Size(1014, 392);
            this.dgv_Reminders.TabIndex = 0;
            // 
            // txt_RemindDateTo
            // 
            this.txt_RemindDateTo.BackColor = System.Drawing.Color.White;
            this.txt_RemindDateTo.Font = new System.Drawing.Font("B Nazanin", 14F);
            this.txt_RemindDateTo.Location = new System.Drawing.Point(190, 28);
            this.txt_RemindDateTo.Name = "txt_RemindDateTo";
            this.txt_RemindDateTo.ShowTime = false;
            this.txt_RemindDateTo.Size = new System.Drawing.Size(165, 33);
            this.txt_RemindDateTo.TabIndex = 16;
            this.txt_RemindDateTo.Text = "persianDateTimePicker2";
            this.txt_RemindDateTo.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_RemindDateTo.Value")));
            // 
            // txt_RemindDateIn
            // 
            this.txt_RemindDateIn.BackColor = System.Drawing.Color.White;
            this.txt_RemindDateIn.Font = new System.Drawing.Font("B Nazanin", 14F);
            this.txt_RemindDateIn.Location = new System.Drawing.Point(378, 28);
            this.txt_RemindDateIn.Name = "txt_RemindDateIn";
            this.txt_RemindDateIn.ShowTime = false;
            this.txt_RemindDateIn.Size = new System.Drawing.Size(165, 33);
            this.txt_RemindDateIn.TabIndex = 15;
            this.txt_RemindDateIn.Text = "persianDateTimePicker1";
            this.txt_RemindDateIn.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_RemindDateIn.Value")));
            // 
            // btn_RemindSearch
            // 
            this.btn_RemindSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_RemindSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_RemindSearch.Location = new System.Drawing.Point(89, 23);
            this.btn_RemindSearch.Name = "btn_RemindSearch";
            this.btn_RemindSearch.Size = new System.Drawing.Size(64, 44);
            this.btn_RemindSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_RemindSearch.Symbol = "";
            this.btn_RemindSearch.TabIndex = 14;
            // 
            // lbl_RemindDateTo
            // 
            // 
            // 
            // 
            this.lbl_RemindDateTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_RemindDateTo.Location = new System.Drawing.Point(361, 30);
            this.lbl_RemindDateTo.Name = "lbl_RemindDateTo";
            this.lbl_RemindDateTo.Size = new System.Drawing.Size(11, 27);
            this.lbl_RemindDateTo.TabIndex = 13;
            this.lbl_RemindDateTo.Text = "تا";
            // 
            // lbl_RemindDateIn
            // 
            // 
            // 
            // 
            this.lbl_RemindDateIn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_RemindDateIn.Location = new System.Drawing.Point(549, 30);
            this.lbl_RemindDateIn.Name = "lbl_RemindDateIn";
            this.lbl_RemindDateIn.Size = new System.Drawing.Size(99, 27);
            this.lbl_RemindDateIn.TabIndex = 12;
            this.lbl_RemindDateIn.Text = "تاريخ يادآوري از:";
            // 
            // txt_RemindSubjectSearch
            // 
            // 
            // 
            // 
            this.txt_RemindSubjectSearch.Border.Class = "TextBoxBorder";
            this.txt_RemindSubjectSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_RemindSubjectSearch.Location = new System.Drawing.Point(674, 28);
            this.txt_RemindSubjectSearch.Name = "txt_RemindSubjectSearch";
            this.txt_RemindSubjectSearch.PreventEnterBeep = true;
            this.txt_RemindSubjectSearch.Size = new System.Drawing.Size(165, 36);
            this.txt_RemindSubjectSearch.TabIndex = 11;
            this.txt_RemindSubjectSearch.WatermarkText = "جستجو در موضوعات...";
            // 
            // lbl_RemindSubjectSearch
            // 
            // 
            // 
            // 
            this.lbl_RemindSubjectSearch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_RemindSubjectSearch.Location = new System.Drawing.Point(845, 30);
            this.lbl_RemindSubjectSearch.Name = "lbl_RemindSubjectSearch";
            this.lbl_RemindSubjectSearch.Size = new System.Drawing.Size(93, 27);
            this.lbl_RemindSubjectSearch.TabIndex = 10;
            this.lbl_RemindSubjectSearch.Text = "موضوع يادآوري:";
            // 
            // col_RemindSubject
            // 
            this.col_RemindSubject.HeaderText = "موضوع";
            this.col_RemindSubject.Name = "col_RemindSubject";
            this.col_RemindSubject.Width = 200;
            // 
            // col_RemindCaption
            // 
            this.col_RemindCaption.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_RemindCaption.HeaderText = "توضيحات";
            this.col_RemindCaption.Name = "col_RemindCaption";
            // 
            // col_RemindCreatedDate
            // 
            this.col_RemindCreatedDate.HeaderText = "تاريخ ثبت";
            this.col_RemindCreatedDate.Name = "col_RemindCreatedDate";
            this.col_RemindCreatedDate.Width = 150;
            // 
            // col_RemindRememberDate
            // 
            this.col_RemindRememberDate.HeaderText = "تاريخ يادآوري";
            this.col_RemindRememberDate.Name = "col_RemindRememberDate";
            this.col_RemindRememberDate.Width = 150;
            // 
            // col_RemindStatus
            // 
            this.col_RemindStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_RemindStatus.HeaderText = "وضعيت";
            this.col_RemindStatus.Name = "col_RemindStatus";
            this.col_RemindStatus.Width = 81;
            // 
            // col_RemindID
            // 
            this.col_RemindID.HeaderText = "RemindID";
            this.col_RemindID.Name = "col_RemindID";
            this.col_RemindID.Visible = false;
            // 
            // col_RemindIsRead
            // 
            this.col_RemindIsRead.HeaderText = "RemindIsRead";
            this.col_RemindIsRead.Name = "col_RemindIsRead";
            this.col_RemindIsRead.Visible = false;
            // 
            // frmUserReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmUserReminder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUserReminder_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_ReminderList.ResumeLayout(false);
            this.pnl_SearchReminder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reminders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_ReminderList;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_SearchReminder;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_Reminders;
        private FreeControls.PersianDateTimePicker txt_RemindDateTo;
        private FreeControls.PersianDateTimePicker txt_RemindDateIn;
        private DevComponents.DotNetBar.ButtonX btn_RemindSearch;
        private DevComponents.DotNetBar.LabelX lbl_RemindDateTo;
        private DevComponents.DotNetBar.LabelX lbl_RemindDateIn;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_RemindSubjectSearch;
        private DevComponents.DotNetBar.LabelX lbl_RemindSubjectSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RemindSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RemindCaption;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RemindCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RemindRememberDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RemindStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RemindID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RemindIsRead;
    }
}