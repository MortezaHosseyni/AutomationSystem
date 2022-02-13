namespace AutomationSystem.AdminPanel
{
    partial class frmUsersLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersLog));
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.pnl_Main = new DevComponents.DotNetBar.PanelEx();
            this.pnl_UsersLogTable = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.pnl_Search = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv_UsersLogTable = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lbl_FristNameAndLastName = new DevComponents.DotNetBar.LabelX();
            this.lbl_IPAddress = new DevComponents.DotNetBar.LabelX();
            this.lbl_ComputerName = new DevComponents.DotNetBar.LabelX();
            this.txt_FullName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_UserIPAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_ComputerName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_DateIn = new DevComponents.DotNetBar.LabelX();
            this.txt_DateIn = new FreeControls.PersianDateTimePicker();
            this.lbl_DateTo = new DevComponents.DotNetBar.LabelX();
            this.txt_DateTo = new FreeControls.PersianDateTimePicker();
            this.lbl_TimeIn = new DevComponents.DotNetBar.LabelX();
            this.lbl_TimeTo = new DevComponents.DotNetBar.LabelX();
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.btn_GetReport = new DevComponents.DotNetBar.ButtonX();
            this.txt_TimeIn = new System.Windows.Forms.DateTimePicker();
            this.txt_TimeTo = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new DevComponents.DotNetBar.ButtonX();
            this.col_LogUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LogFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LogComputerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LogIPAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LogEnterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LogExitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Main.SuspendLayout();
            this.pnl_UsersLogTable.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UsersLogTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Title.Location = new System.Drawing.Point(320, 12);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(290, 45);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "كنترل ورود و خروج كاربران";
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.btn_GetReport);
            this.pnl_Main.Controls.Add(this.btn_Exit);
            this.pnl_Main.Controls.Add(this.pnl_Search);
            this.pnl_Main.Controls.Add(this.pnl_UsersLogTable);
            this.pnl_Main.Controls.Add(this.lbl_Title);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(915, 600);
            this.pnl_Main.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl_Main.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Main.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Main.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl_Main.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Main.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Main.Style.GradientAngle = 90;
            this.pnl_Main.TabIndex = 1;
            // 
            // pnl_UsersLogTable
            // 
            this.pnl_UsersLogTable.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_UsersLogTable.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_UsersLogTable.Controls.Add(this.dgv_UsersLogTable);
            this.pnl_UsersLogTable.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_UsersLogTable.Location = new System.Drawing.Point(12, 63);
            this.pnl_UsersLogTable.Name = "pnl_UsersLogTable";
            this.pnl_UsersLogTable.Size = new System.Drawing.Size(891, 282);
            // 
            // 
            // 
            this.pnl_UsersLogTable.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_UsersLogTable.Style.BackColorGradientAngle = 90;
            this.pnl_UsersLogTable.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_UsersLogTable.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UsersLogTable.Style.BorderBottomWidth = 1;
            this.pnl_UsersLogTable.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_UsersLogTable.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UsersLogTable.Style.BorderLeftWidth = 1;
            this.pnl_UsersLogTable.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UsersLogTable.Style.BorderRightWidth = 1;
            this.pnl_UsersLogTable.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UsersLogTable.Style.BorderTopWidth = 1;
            this.pnl_UsersLogTable.Style.CornerDiameter = 4;
            this.pnl_UsersLogTable.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_UsersLogTable.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_UsersLogTable.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_UsersLogTable.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_UsersLogTable.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_UsersLogTable.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_UsersLogTable.TabIndex = 1;
            // 
            // pnl_Search
            // 
            this.pnl_Search.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Search.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Search.Controls.Add(this.btn_Search);
            this.pnl_Search.Controls.Add(this.txt_TimeTo);
            this.pnl_Search.Controls.Add(this.txt_TimeIn);
            this.pnl_Search.Controls.Add(this.lbl_TimeTo);
            this.pnl_Search.Controls.Add(this.lbl_DateTo);
            this.pnl_Search.Controls.Add(this.txt_DateTo);
            this.pnl_Search.Controls.Add(this.txt_DateIn);
            this.pnl_Search.Controls.Add(this.txt_ComputerName);
            this.pnl_Search.Controls.Add(this.txt_UserIPAddress);
            this.pnl_Search.Controls.Add(this.txt_FullName);
            this.pnl_Search.Controls.Add(this.lbl_ComputerName);
            this.pnl_Search.Controls.Add(this.lbl_IPAddress);
            this.pnl_Search.Controls.Add(this.lbl_TimeIn);
            this.pnl_Search.Controls.Add(this.lbl_DateIn);
            this.pnl_Search.Controls.Add(this.lbl_FristNameAndLastName);
            this.pnl_Search.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Search.Location = new System.Drawing.Point(12, 351);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(891, 186);
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
            // dgv_UsersLogTable
            // 
            this.dgv_UsersLogTable.AllowUserToAddRows = false;
            this.dgv_UsersLogTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgv_UsersLogTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_UsersLogTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_UsersLogTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UsersLogTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_LogUserID,
            this.col_LogFullName,
            this.col_LogComputerName,
            this.col_LogIPAddress,
            this.col_LogEnterDate,
            this.col_LogExitDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_UsersLogTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_UsersLogTable.EnableHeadersVisualStyles = false;
            this.dgv_UsersLogTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(181)))), ((int)(((byte)(252)))));
            this.dgv_UsersLogTable.Location = new System.Drawing.Point(3, 3);
            this.dgv_UsersLogTable.Name = "dgv_UsersLogTable";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_UsersLogTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_UsersLogTable.Size = new System.Drawing.Size(879, 270);
            this.dgv_UsersLogTable.TabIndex = 0;
            // 
            // lbl_FristNameAndLastName
            // 
            // 
            // 
            // 
            this.lbl_FristNameAndLastName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_FristNameAndLastName.Location = new System.Drawing.Point(770, 14);
            this.lbl_FristNameAndLastName.Name = "lbl_FristNameAndLastName";
            this.lbl_FristNameAndLastName.Size = new System.Drawing.Size(104, 27);
            this.lbl_FristNameAndLastName.TabIndex = 0;
            this.lbl_FristNameAndLastName.Text = "نام و نام‌خانوادگي:";
            // 
            // lbl_IPAddress
            // 
            // 
            // 
            // 
            this.lbl_IPAddress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_IPAddress.Location = new System.Drawing.Point(770, 56);
            this.lbl_IPAddress.Name = "lbl_IPAddress";
            this.lbl_IPAddress.Size = new System.Drawing.Size(70, 27);
            this.lbl_IPAddress.TabIndex = 0;
            this.lbl_IPAddress.Text = "آي‌پي كاربر:";
            // 
            // lbl_ComputerName
            // 
            // 
            // 
            // 
            this.lbl_ComputerName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_ComputerName.Location = new System.Drawing.Point(770, 98);
            this.lbl_ComputerName.Name = "lbl_ComputerName";
            this.lbl_ComputerName.Size = new System.Drawing.Size(71, 27);
            this.lbl_ComputerName.TabIndex = 0;
            this.lbl_ComputerName.Text = "نام كامپيوتر:";
            // 
            // txt_FullName
            // 
            // 
            // 
            // 
            this.txt_FullName.Border.Class = "TextBoxBorder";
            this.txt_FullName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_FullName.Location = new System.Drawing.Point(579, 14);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.PreventEnterBeep = true;
            this.txt_FullName.Size = new System.Drawing.Size(185, 36);
            this.txt_FullName.TabIndex = 1;
            // 
            // txt_UserIPAddress
            // 
            // 
            // 
            // 
            this.txt_UserIPAddress.Border.Class = "TextBoxBorder";
            this.txt_UserIPAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_UserIPAddress.Location = new System.Drawing.Point(579, 56);
            this.txt_UserIPAddress.Name = "txt_UserIPAddress";
            this.txt_UserIPAddress.PreventEnterBeep = true;
            this.txt_UserIPAddress.Size = new System.Drawing.Size(185, 36);
            this.txt_UserIPAddress.TabIndex = 1;
            // 
            // txt_ComputerName
            // 
            // 
            // 
            // 
            this.txt_ComputerName.Border.Class = "TextBoxBorder";
            this.txt_ComputerName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_ComputerName.Location = new System.Drawing.Point(579, 98);
            this.txt_ComputerName.Name = "txt_ComputerName";
            this.txt_ComputerName.PreventEnterBeep = true;
            this.txt_ComputerName.Size = new System.Drawing.Size(185, 36);
            this.txt_ComputerName.TabIndex = 1;
            // 
            // lbl_DateIn
            // 
            // 
            // 
            // 
            this.lbl_DateIn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_DateIn.Location = new System.Drawing.Point(511, 38);
            this.lbl_DateIn.Name = "lbl_DateIn";
            this.lbl_DateIn.Size = new System.Drawing.Size(48, 27);
            this.lbl_DateIn.TabIndex = 0;
            this.lbl_DateIn.Text = "از تاريخ:";
            // 
            // txt_DateIn
            // 
            this.txt_DateIn.BackColor = System.Drawing.Color.White;
            this.txt_DateIn.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_DateIn.Location = new System.Drawing.Point(320, 31);
            this.txt_DateIn.Name = "txt_DateIn";
            this.txt_DateIn.ShowTime = false;
            this.txt_DateIn.Size = new System.Drawing.Size(185, 34);
            this.txt_DateIn.TabIndex = 2;
            this.txt_DateIn.Text = "persianDateTimePicker1";
            this.txt_DateIn.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_DateIn.Value")));
            // 
            // lbl_DateTo
            // 
            // 
            // 
            // 
            this.lbl_DateTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_DateTo.Location = new System.Drawing.Point(304, 38);
            this.lbl_DateTo.Name = "lbl_DateTo";
            this.lbl_DateTo.Size = new System.Drawing.Size(10, 27);
            this.lbl_DateTo.TabIndex = 3;
            this.lbl_DateTo.Text = "تا";
            // 
            // txt_DateTo
            // 
            this.txt_DateTo.BackColor = System.Drawing.Color.White;
            this.txt_DateTo.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_DateTo.Location = new System.Drawing.Point(113, 31);
            this.txt_DateTo.Name = "txt_DateTo";
            this.txt_DateTo.ShowTime = false;
            this.txt_DateTo.Size = new System.Drawing.Size(185, 34);
            this.txt_DateTo.TabIndex = 2;
            this.txt_DateTo.Text = "persianDateTimePicker1";
            this.txt_DateTo.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_DateTo.Value")));
            // 
            // lbl_TimeIn
            // 
            // 
            // 
            // 
            this.lbl_TimeIn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TimeIn.Location = new System.Drawing.Point(511, 82);
            this.lbl_TimeIn.Name = "lbl_TimeIn";
            this.lbl_TimeIn.Size = new System.Drawing.Size(53, 27);
            this.lbl_TimeIn.TabIndex = 0;
            this.lbl_TimeIn.Text = "از ساعت:";
            // 
            // lbl_TimeTo
            // 
            // 
            // 
            // 
            this.lbl_TimeTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TimeTo.Location = new System.Drawing.Point(304, 82);
            this.lbl_TimeTo.Name = "lbl_TimeTo";
            this.lbl_TimeTo.Size = new System.Drawing.Size(10, 27);
            this.lbl_TimeTo.TabIndex = 3;
            this.lbl_TimeTo.Text = "تا";
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Exit.Location = new System.Drawing.Point(462, 543);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20, 2, 2, 20);
            this.btn_Exit.Size = new System.Drawing.Size(148, 45);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.Symbol = "";
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "خروج";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_GetReport
            // 
            this.btn_GetReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_GetReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_GetReport.Location = new System.Drawing.Point(308, 543);
            this.btn_GetReport.Name = "btn_GetReport";
            this.btn_GetReport.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20, 2, 2, 20);
            this.btn_GetReport.Size = new System.Drawing.Size(148, 45);
            this.btn_GetReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_GetReport.Symbol = "";
            this.btn_GetReport.TabIndex = 3;
            this.btn_GetReport.Text = "تهيه گزارش";
            // 
            // txt_TimeIn
            // 
            this.txt_TimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txt_TimeIn.Location = new System.Drawing.Point(320, 73);
            this.txt_TimeIn.Name = "txt_TimeIn";
            this.txt_TimeIn.Size = new System.Drawing.Size(185, 36);
            this.txt_TimeIn.TabIndex = 4;
            this.txt_TimeIn.Value = new System.DateTime(2022, 1, 22, 0, 0, 0, 0);
            // 
            // txt_TimeTo
            // 
            this.txt_TimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txt_TimeTo.Location = new System.Drawing.Point(113, 73);
            this.txt_TimeTo.Name = "txt_TimeTo";
            this.txt_TimeTo.Size = new System.Drawing.Size(185, 36);
            this.txt_TimeTo.TabIndex = 4;
            // 
            // btn_Search
            // 
            this.btn_Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Search.Location = new System.Drawing.Point(22, 31);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 78);
            this.btn_Search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Search.Symbol = "";
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // col_LogUserID
            // 
            this.col_LogUserID.HeaderText = "LogUserID";
            this.col_LogUserID.Name = "col_LogUserID";
            this.col_LogUserID.Visible = false;
            // 
            // col_LogFullName
            // 
            this.col_LogFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_LogFullName.HeaderText = "نام و نام‌خانوادگي";
            this.col_LogFullName.Name = "col_LogFullName";
            // 
            // col_LogComputerName
            // 
            this.col_LogComputerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_LogComputerName.HeaderText = "نام كامپيوتر";
            this.col_LogComputerName.Name = "col_LogComputerName";
            // 
            // col_LogIPAddress
            // 
            this.col_LogIPAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_LogIPAddress.HeaderText = "آي‌پي";
            this.col_LogIPAddress.Name = "col_LogIPAddress";
            // 
            // col_LogEnterDate
            // 
            this.col_LogEnterDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_LogEnterDate.HeaderText = "تاريخ ورود";
            this.col_LogEnterDate.Name = "col_LogEnterDate";
            // 
            // col_LogExitDate
            // 
            this.col_LogExitDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_LogExitDate.HeaderText = "تاريخ خروج";
            this.col_LogExitDate.Name = "col_LogExitDate";
            // 
            // frmUsersLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 600);
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmUsersLog";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUsersLog_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_UsersLogTable.ResumeLayout(false);
            this.pnl_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UsersLogTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_UsersLogTable;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Search;
        private DevComponents.DotNetBar.LabelX lbl_FristNameAndLastName;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_UsersLogTable;
        private DevComponents.DotNetBar.LabelX lbl_IPAddress;
        private DevComponents.DotNetBar.LabelX lbl_ComputerName;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_ComputerName;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_UserIPAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_FullName;
        private DevComponents.DotNetBar.LabelX lbl_DateIn;
        private DevComponents.DotNetBar.LabelX lbl_DateTo;
        private FreeControls.PersianDateTimePicker txt_DateTo;
        private FreeControls.PersianDateTimePicker txt_DateIn;
        private DevComponents.DotNetBar.LabelX lbl_TimeTo;
        private DevComponents.DotNetBar.LabelX lbl_TimeIn;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
        private DevComponents.DotNetBar.ButtonX btn_GetReport;
        private System.Windows.Forms.DateTimePicker txt_TimeTo;
        private System.Windows.Forms.DateTimePicker txt_TimeIn;
        private DevComponents.DotNetBar.ButtonX btn_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LogUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LogFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LogComputerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LogIPAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LogEnterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LogExitDate;
    }
}