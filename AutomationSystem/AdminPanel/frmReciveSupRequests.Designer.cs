namespace AutomationSystem.AdminPanel
{
    partial class frmReciveSupRequests
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReciveSupRequests));
            this.pnl_Main = new DevComponents.DotNetBar.PanelEx();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.pnl_Requests = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.pnl_Search = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.pnl_Buttons = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv_Requests = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_SupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SupSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SupCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SupRequester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SupDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SupUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.txt_DateTo = new FreeControls.PersianDateTimePicker();
            this.txt_DateIn = new FreeControls.PersianDateTimePicker();
            this.lbl_DateTo = new DevComponents.DotNetBar.LabelX();
            this.lbl_DateIn = new DevComponents.DotNetBar.LabelX();
            this.lbl_SupSubject = new DevComponents.DotNetBar.LabelX();
            this.lbl_SupCaption = new DevComponents.DotNetBar.LabelX();
            this.lbl_SupRequester = new DevComponents.DotNetBar.LabelX();
            this.txt_SupCaption = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_SupSubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_SupRequester = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_Search = new DevComponents.DotNetBar.ButtonX();
            this.pnl_Main.SuspendLayout();
            this.pnl_Requests.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            this.pnl_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Requests)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.pnl_Buttons);
            this.pnl_Main.Controls.Add(this.pnl_Search);
            this.pnl_Main.Controls.Add(this.pnl_Requests);
            this.pnl_Main.Controls.Add(this.lbl_Title);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(980, 610);
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
            this.lbl_Title.AutoSize = true;
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("B Nazanin", 22.25F);
            this.lbl_Title.Location = new System.Drawing.Point(383, 3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(185, 48);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "پشتيباني سيستم";
            // 
            // pnl_Requests
            // 
            this.pnl_Requests.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Requests.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Requests.Controls.Add(this.dgv_Requests);
            this.pnl_Requests.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Requests.Location = new System.Drawing.Point(12, 57);
            this.pnl_Requests.Name = "pnl_Requests";
            this.pnl_Requests.Size = new System.Drawing.Size(956, 364);
            // 
            // 
            // 
            this.pnl_Requests.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Requests.Style.BackColorGradientAngle = 90;
            this.pnl_Requests.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Requests.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Requests.Style.BorderBottomWidth = 1;
            this.pnl_Requests.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Requests.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Requests.Style.BorderLeftWidth = 1;
            this.pnl_Requests.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Requests.Style.BorderRightWidth = 1;
            this.pnl_Requests.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Requests.Style.BorderTopWidth = 1;
            this.pnl_Requests.Style.CornerDiameter = 4;
            this.pnl_Requests.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_Requests.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_Requests.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Requests.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_Requests.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_Requests.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_Requests.TabIndex = 1;
            // 
            // pnl_Search
            // 
            this.pnl_Search.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Search.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Search.Controls.Add(this.btn_Search);
            this.pnl_Search.Controls.Add(this.txt_SupRequester);
            this.pnl_Search.Controls.Add(this.txt_SupSubject);
            this.pnl_Search.Controls.Add(this.txt_SupCaption);
            this.pnl_Search.Controls.Add(this.txt_DateTo);
            this.pnl_Search.Controls.Add(this.txt_DateIn);
            this.pnl_Search.Controls.Add(this.lbl_DateTo);
            this.pnl_Search.Controls.Add(this.lbl_SupRequester);
            this.pnl_Search.Controls.Add(this.lbl_SupCaption);
            this.pnl_Search.Controls.Add(this.lbl_SupSubject);
            this.pnl_Search.Controls.Add(this.lbl_DateIn);
            this.pnl_Search.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Search.Location = new System.Drawing.Point(12, 427);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(956, 99);
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
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Buttons.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Buttons.Controls.Add(this.btn_Exit);
            this.pnl_Buttons.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Buttons.Location = new System.Drawing.Point(12, 532);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(956, 66);
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
            this.pnl_Buttons.TabIndex = 3;
            // 
            // dgv_Requests
            // 
            this.dgv_Requests.AllowUserToAddRows = false;
            this.dgv_Requests.AllowUserToDeleteRows = false;
            this.dgv_Requests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Requests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_SupID,
            this.col_SupSubject,
            this.col_SupCaption,
            this.col_SupRequester,
            this.col_SupDate,
            this.col_SupUserID});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Requests.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Requests.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(181)))), ((int)(((byte)(252)))));
            this.dgv_Requests.Location = new System.Drawing.Point(3, 3);
            this.dgv_Requests.Name = "dgv_Requests";
            this.dgv_Requests.Size = new System.Drawing.Size(944, 352);
            this.dgv_Requests.TabIndex = 0;
            // 
            // col_SupID
            // 
            this.col_SupID.HeaderText = "SupID";
            this.col_SupID.Name = "col_SupID";
            this.col_SupID.Visible = false;
            // 
            // col_SupSubject
            // 
            this.col_SupSubject.HeaderText = "موضوع";
            this.col_SupSubject.Name = "col_SupSubject";
            this.col_SupSubject.Width = 220;
            // 
            // col_SupCaption
            // 
            this.col_SupCaption.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_SupCaption.HeaderText = "توضيحات درخواست";
            this.col_SupCaption.Name = "col_SupCaption";
            // 
            // col_SupRequester
            // 
            this.col_SupRequester.HeaderText = "درخواست دهنده";
            this.col_SupRequester.Name = "col_SupRequester";
            this.col_SupRequester.Width = 200;
            // 
            // col_SupDate
            // 
            this.col_SupDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_SupDate.HeaderText = "تاريخ درخواست";
            this.col_SupDate.Name = "col_SupDate";
            this.col_SupDate.Width = 128;
            // 
            // col_SupUserID
            // 
            this.col_SupUserID.HeaderText = "SupUserID";
            this.col_SupUserID.Name = "col_SupUserID";
            this.col_SupUserID.Visible = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Exit.Location = new System.Drawing.Point(308, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 2, 20, 20);
            this.btn_Exit.Size = new System.Drawing.Size(296, 54);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.Symbol = "";
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "خروج";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // txt_DateTo
            // 
            this.txt_DateTo.BackColor = System.Drawing.Color.White;
            this.txt_DateTo.Font = new System.Drawing.Font("B Nazanin", 14F);
            this.txt_DateTo.Location = new System.Drawing.Point(471, 6);
            this.txt_DateTo.Name = "txt_DateTo";
            this.txt_DateTo.ShowTime = false;
            this.txt_DateTo.Size = new System.Drawing.Size(165, 33);
            this.txt_DateTo.TabIndex = 13;
            this.txt_DateTo.Text = "persianDateTimePicker2";
            this.txt_DateTo.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_DateTo.Value")));
            // 
            // txt_DateIn
            // 
            this.txt_DateIn.BackColor = System.Drawing.Color.White;
            this.txt_DateIn.Font = new System.Drawing.Font("B Nazanin", 14F);
            this.txt_DateIn.Location = new System.Drawing.Point(659, 6);
            this.txt_DateIn.Name = "txt_DateIn";
            this.txt_DateIn.ShowTime = false;
            this.txt_DateIn.Size = new System.Drawing.Size(165, 33);
            this.txt_DateIn.TabIndex = 12;
            this.txt_DateIn.Text = "persianDateTimePicker1";
            this.txt_DateIn.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_DateIn.Value")));
            // 
            // lbl_DateTo
            // 
            this.lbl_DateTo.AutoSize = true;
            // 
            // 
            // 
            this.lbl_DateTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_DateTo.Location = new System.Drawing.Point(642, 6);
            this.lbl_DateTo.Name = "lbl_DateTo";
            this.lbl_DateTo.Size = new System.Drawing.Size(11, 33);
            this.lbl_DateTo.TabIndex = 11;
            this.lbl_DateTo.Text = "تا";
            // 
            // lbl_DateIn
            // 
            this.lbl_DateIn.AutoSize = true;
            // 
            // 
            // 
            this.lbl_DateIn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_DateIn.Location = new System.Drawing.Point(830, 3);
            this.lbl_DateIn.Name = "lbl_DateIn";
            this.lbl_DateIn.Size = new System.Drawing.Size(98, 33);
            this.lbl_DateIn.TabIndex = 10;
            this.lbl_DateIn.Text = "تاريخ يادآوري از:";
            // 
            // lbl_SupSubject
            // 
            this.lbl_SupSubject.AutoSize = true;
            // 
            // 
            // 
            this.lbl_SupSubject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SupSubject.Location = new System.Drawing.Point(365, 6);
            this.lbl_SupSubject.Name = "lbl_SupSubject";
            this.lbl_SupSubject.Size = new System.Drawing.Size(45, 33);
            this.lbl_SupSubject.TabIndex = 10;
            this.lbl_SupSubject.Text = "موضوع:";
            // 
            // lbl_SupCaption
            // 
            this.lbl_SupCaption.AutoSize = true;
            // 
            // 
            // 
            this.lbl_SupCaption.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SupCaption.Location = new System.Drawing.Point(830, 48);
            this.lbl_SupCaption.Name = "lbl_SupCaption";
            this.lbl_SupCaption.Size = new System.Drawing.Size(61, 33);
            this.lbl_SupCaption.TabIndex = 10;
            this.lbl_SupCaption.Text = "توضيحات:";
            // 
            // lbl_SupRequester
            // 
            this.lbl_SupRequester.AutoSize = true;
            // 
            // 
            // 
            this.lbl_SupRequester.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SupRequester.Location = new System.Drawing.Point(365, 48);
            this.lbl_SupRequester.Name = "lbl_SupRequester";
            this.lbl_SupRequester.Size = new System.Drawing.Size(100, 33);
            this.lbl_SupRequester.TabIndex = 10;
            this.lbl_SupRequester.Text = "درخواست كننده:";
            // 
            // txt_SupCaption
            // 
            // 
            // 
            // 
            this.txt_SupCaption.Border.Class = "TextBoxBorder";
            this.txt_SupCaption.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SupCaption.Location = new System.Drawing.Point(471, 45);
            this.txt_SupCaption.Name = "txt_SupCaption";
            this.txt_SupCaption.PreventEnterBeep = true;
            this.txt_SupCaption.Size = new System.Drawing.Size(353, 36);
            this.txt_SupCaption.TabIndex = 2;
            this.txt_SupCaption.WatermarkText = "جستجو در توضيحات درخواست...";
            // 
            // txt_SupSubject
            // 
            // 
            // 
            // 
            this.txt_SupSubject.Border.Class = "TextBoxBorder";
            this.txt_SupSubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SupSubject.Location = new System.Drawing.Point(128, 6);
            this.txt_SupSubject.Name = "txt_SupSubject";
            this.txt_SupSubject.PreventEnterBeep = true;
            this.txt_SupSubject.Size = new System.Drawing.Size(231, 36);
            this.txt_SupSubject.TabIndex = 1;
            this.txt_SupSubject.WatermarkText = "جستجو در موضوع درخواست...";
            // 
            // txt_SupRequester
            // 
            // 
            // 
            // 
            this.txt_SupRequester.Border.Class = "TextBoxBorder";
            this.txt_SupRequester.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SupRequester.Location = new System.Drawing.Point(128, 48);
            this.txt_SupRequester.Name = "txt_SupRequester";
            this.txt_SupRequester.PreventEnterBeep = true;
            this.txt_SupRequester.Size = new System.Drawing.Size(231, 36);
            this.txt_SupRequester.TabIndex = 3;
            this.txt_SupRequester.WatermarkText = "جستجو در درخواست كننده‌ها...";
            // 
            // btn_Search
            // 
            this.btn_Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Search.Location = new System.Drawing.Point(19, 6);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(99, 78);
            this.btn_Search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Search.Symbol = "";
            this.btn_Search.TabIndex = 15;
            // 
            // frmReciveSupRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 610);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmReciveSupRequests";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmReciveSupRequests_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.pnl_Requests.ResumeLayout(false);
            this.pnl_Search.ResumeLayout(false);
            this.pnl_Search.PerformLayout();
            this.pnl_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Requests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Search;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Requests;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Buttons;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_Requests;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SupSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SupCaption;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SupRequester;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SupDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SupUserID;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
        private FreeControls.PersianDateTimePicker txt_DateTo;
        private FreeControls.PersianDateTimePicker txt_DateIn;
        private DevComponents.DotNetBar.LabelX lbl_DateTo;
        private DevComponents.DotNetBar.LabelX lbl_DateIn;
        private DevComponents.DotNetBar.LabelX lbl_SupRequester;
        private DevComponents.DotNetBar.LabelX lbl_SupCaption;
        private DevComponents.DotNetBar.LabelX lbl_SupSubject;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SupRequester;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SupSubject;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SupCaption;
        private DevComponents.DotNetBar.ButtonX btn_Search;
    }
}