namespace AutomationSystem.UserPanel
{
    partial class frmUserDailyFunction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserDailyFunction));
            this.pnl_Main = new DevComponents.DotNetBar.PanelEx();
            this.pnl_AddDailyFunction = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_FunctionDoTime = new DevComponents.DotNetBar.LabelX();
            this.lbl_FunctionRequesterUnit = new DevComponents.DotNetBar.LabelX();
            this.lbl_FunctionDoDate = new DevComponents.DotNetBar.LabelX();
            this.lbl_FunctionCaption = new DevComponents.DotNetBar.LabelX();
            this.lbl_FunctionSubject = new DevComponents.DotNetBar.LabelX();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.txt_FunctionSubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_FunctionCaption = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_FunctionDoTime = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_FunctionDoDate = new FreeControls.PersianDateTimePicker();
            this.cmb_FunctionRequesterUnit = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lbl_FunctionTimeUnit = new DevComponents.DotNetBar.LabelX();
            this.btn_Save = new DevComponents.DotNetBar.ButtonX();
            this.pnl_DailyFunctionsList = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv_DailyFunctionsList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_WorkID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WorkSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WorkCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WorkRequesterUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WorkJobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WorkDoneTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WorkDoneDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Search = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_SearchSubject = new DevComponents.DotNetBar.LabelX();
            this.txt_SearchSubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_SearchCaption = new DevComponents.DotNetBar.LabelX();
            this.txt_SearchCaption = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_SearchRequester = new DevComponents.DotNetBar.LabelX();
            this.cmb_SearchRequester = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txt_DateTo = new FreeControls.PersianDateTimePicker();
            this.txt_DateIn = new FreeControls.PersianDateTimePicker();
            this.lbl_SearchDateOn = new DevComponents.DotNetBar.LabelX();
            this.lbl_SearchDateTo = new DevComponents.DotNetBar.LabelX();
            this.btn_Search = new DevComponents.DotNetBar.ButtonX();
            this.pnl_Main.SuspendLayout();
            this.pnl_AddDailyFunction.SuspendLayout();
            this.pnl_DailyFunctionsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DailyFunctionsList)).BeginInit();
            this.pnl_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.pnl_Search);
            this.pnl_Main.Controls.Add(this.pnl_DailyFunctionsList);
            this.pnl_Main.Controls.Add(this.pnl_AddDailyFunction);
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
            // pnl_AddDailyFunction
            // 
            this.pnl_AddDailyFunction.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_AddDailyFunction.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_AddDailyFunction.Controls.Add(this.btn_Save);
            this.pnl_AddDailyFunction.Controls.Add(this.cmb_FunctionRequesterUnit);
            this.pnl_AddDailyFunction.Controls.Add(this.txt_FunctionDoDate);
            this.pnl_AddDailyFunction.Controls.Add(this.txt_FunctionDoTime);
            this.pnl_AddDailyFunction.Controls.Add(this.txt_FunctionCaption);
            this.pnl_AddDailyFunction.Controls.Add(this.txt_FunctionSubject);
            this.pnl_AddDailyFunction.Controls.Add(this.lbl_FunctionTimeUnit);
            this.pnl_AddDailyFunction.Controls.Add(this.lbl_FunctionDoTime);
            this.pnl_AddDailyFunction.Controls.Add(this.lbl_FunctionRequesterUnit);
            this.pnl_AddDailyFunction.Controls.Add(this.lbl_FunctionDoDate);
            this.pnl_AddDailyFunction.Controls.Add(this.lbl_FunctionCaption);
            this.pnl_AddDailyFunction.Controls.Add(this.lbl_FunctionSubject);
            this.pnl_AddDailyFunction.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_AddDailyFunction.Location = new System.Drawing.Point(12, 57);
            this.pnl_AddDailyFunction.Name = "pnl_AddDailyFunction";
            this.pnl_AddDailyFunction.Size = new System.Drawing.Size(1026, 202);
            // 
            // 
            // 
            this.pnl_AddDailyFunction.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_AddDailyFunction.Style.BackColorGradientAngle = 90;
            this.pnl_AddDailyFunction.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_AddDailyFunction.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_AddDailyFunction.Style.BorderBottomWidth = 1;
            this.pnl_AddDailyFunction.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_AddDailyFunction.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_AddDailyFunction.Style.BorderLeftWidth = 1;
            this.pnl_AddDailyFunction.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_AddDailyFunction.Style.BorderRightWidth = 1;
            this.pnl_AddDailyFunction.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_AddDailyFunction.Style.BorderTopWidth = 1;
            this.pnl_AddDailyFunction.Style.CornerDiameter = 4;
            this.pnl_AddDailyFunction.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_AddDailyFunction.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_AddDailyFunction.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_AddDailyFunction.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_AddDailyFunction.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_AddDailyFunction.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_AddDailyFunction.TabIndex = 1;
            this.pnl_AddDailyFunction.Text = "ثبت فعاليت";
            // 
            // lbl_FunctionDoTime
            // 
            this.lbl_FunctionDoTime.AutoSize = true;
            // 
            // 
            // 
            this.lbl_FunctionDoTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_FunctionDoTime.Location = new System.Drawing.Point(398, 88);
            this.lbl_FunctionDoTime.Name = "lbl_FunctionDoTime";
            this.lbl_FunctionDoTime.Size = new System.Drawing.Size(98, 33);
            this.lbl_FunctionDoTime.TabIndex = 0;
            this.lbl_FunctionDoTime.Text = "مدت زمان انجام:";
            // 
            // lbl_FunctionRequesterUnit
            // 
            this.lbl_FunctionRequesterUnit.AutoSize = true;
            // 
            // 
            // 
            this.lbl_FunctionRequesterUnit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_FunctionRequesterUnit.Location = new System.Drawing.Point(398, 43);
            this.lbl_FunctionRequesterUnit.Name = "lbl_FunctionRequesterUnit";
            this.lbl_FunctionRequesterUnit.Size = new System.Drawing.Size(133, 33);
            this.lbl_FunctionRequesterUnit.TabIndex = 0;
            this.lbl_FunctionRequesterUnit.Text = "واحد درخواست كننده:";
            // 
            // lbl_FunctionDoDate
            // 
            this.lbl_FunctionDoDate.AutoSize = true;
            // 
            // 
            // 
            this.lbl_FunctionDoDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_FunctionDoDate.Location = new System.Drawing.Point(398, 3);
            this.lbl_FunctionDoDate.Name = "lbl_FunctionDoDate";
            this.lbl_FunctionDoDate.Size = new System.Drawing.Size(68, 33);
            this.lbl_FunctionDoDate.TabIndex = 0;
            this.lbl_FunctionDoDate.Text = "تاريخ انجام:";
            // 
            // lbl_FunctionCaption
            // 
            this.lbl_FunctionCaption.AutoSize = true;
            // 
            // 
            // 
            this.lbl_FunctionCaption.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_FunctionCaption.Location = new System.Drawing.Point(866, 48);
            this.lbl_FunctionCaption.Name = "lbl_FunctionCaption";
            this.lbl_FunctionCaption.Size = new System.Drawing.Size(76, 33);
            this.lbl_FunctionCaption.TabIndex = 0;
            this.lbl_FunctionCaption.Text = "شرح فعاليت:";
            // 
            // lbl_FunctionSubject
            // 
            this.lbl_FunctionSubject.AutoSize = true;
            // 
            // 
            // 
            this.lbl_FunctionSubject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_FunctionSubject.Location = new System.Drawing.Point(866, 3);
            this.lbl_FunctionSubject.Name = "lbl_FunctionSubject";
            this.lbl_FunctionSubject.Size = new System.Drawing.Size(45, 33);
            this.lbl_FunctionSubject.TabIndex = 0;
            this.lbl_FunctionSubject.Text = "موضوع:";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("B Nazanin", 22.25F);
            this.lbl_Title.Location = new System.Drawing.Point(430, 3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(193, 48);
            this.lbl_Title.Symbol = "58902";
            this.lbl_Title.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "ثبت كاركرد روزانه";
            // 
            // txt_FunctionSubject
            // 
            // 
            // 
            // 
            this.txt_FunctionSubject.Border.Class = "TextBoxBorder";
            this.txt_FunctionSubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_FunctionSubject.Location = new System.Drawing.Point(579, 3);
            this.txt_FunctionSubject.Name = "txt_FunctionSubject";
            this.txt_FunctionSubject.PreventEnterBeep = true;
            this.txt_FunctionSubject.Size = new System.Drawing.Size(281, 36);
            this.txt_FunctionSubject.TabIndex = 1;
            this.txt_FunctionSubject.WatermarkText = "موضوع فعاليت...";
            // 
            // txt_FunctionCaption
            // 
            // 
            // 
            // 
            this.txt_FunctionCaption.Border.Class = "TextBoxBorder";
            this.txt_FunctionCaption.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_FunctionCaption.Location = new System.Drawing.Point(579, 45);
            this.txt_FunctionCaption.Multiline = true;
            this.txt_FunctionCaption.Name = "txt_FunctionCaption";
            this.txt_FunctionCaption.PreventEnterBeep = true;
            this.txt_FunctionCaption.Size = new System.Drawing.Size(281, 112);
            this.txt_FunctionCaption.TabIndex = 2;
            this.txt_FunctionCaption.WatermarkText = "توضيحاتي درمورد فعاليت...";
            // 
            // txt_FunctionDoTime
            // 
            // 
            // 
            // 
            this.txt_FunctionDoTime.Border.Class = "TextBoxBorder";
            this.txt_FunctionDoTime.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_FunctionDoTime.Location = new System.Drawing.Point(152, 85);
            this.txt_FunctionDoTime.Name = "txt_FunctionDoTime";
            this.txt_FunctionDoTime.PreventEnterBeep = true;
            this.txt_FunctionDoTime.Size = new System.Drawing.Size(240, 36);
            this.txt_FunctionDoTime.TabIndex = 5;
            this.txt_FunctionDoTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_FunctionDoTime.WatermarkText = "زمان";
            this.txt_FunctionDoTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_FunctionDoTime_KeyPress);
            // 
            // txt_FunctionDoDate
            // 
            this.txt_FunctionDoDate.BackColor = System.Drawing.Color.White;
            this.txt_FunctionDoDate.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_FunctionDoDate.Location = new System.Drawing.Point(111, 3);
            this.txt_FunctionDoDate.Name = "txt_FunctionDoDate";
            this.txt_FunctionDoDate.ShowTime = false;
            this.txt_FunctionDoDate.Size = new System.Drawing.Size(281, 34);
            this.txt_FunctionDoDate.TabIndex = 3;
            this.txt_FunctionDoDate.Text = "persianDateTimePicker1";
            this.txt_FunctionDoDate.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_FunctionDoDate.Value")));
            // 
            // cmb_FunctionRequesterUnit
            // 
            this.cmb_FunctionRequesterUnit.DisplayMember = "Text";
            this.cmb_FunctionRequesterUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_FunctionRequesterUnit.FormattingEnabled = true;
            this.cmb_FunctionRequesterUnit.ItemHeight = 30;
            this.cmb_FunctionRequesterUnit.Location = new System.Drawing.Point(111, 43);
            this.cmb_FunctionRequesterUnit.Name = "cmb_FunctionRequesterUnit";
            this.cmb_FunctionRequesterUnit.Size = new System.Drawing.Size(281, 36);
            this.cmb_FunctionRequesterUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_FunctionRequesterUnit.TabIndex = 4;
            // 
            // lbl_FunctionTimeUnit
            // 
            this.lbl_FunctionTimeUnit.AutoSize = true;
            // 
            // 
            // 
            this.lbl_FunctionTimeUnit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_FunctionTimeUnit.Location = new System.Drawing.Point(111, 88);
            this.lbl_FunctionTimeUnit.Name = "lbl_FunctionTimeUnit";
            this.lbl_FunctionTimeUnit.Size = new System.Drawing.Size(35, 33);
            this.lbl_FunctionTimeUnit.TabIndex = 0;
            this.lbl_FunctionTimeUnit.Text = "دقيقه";
            // 
            // btn_Save
            // 
            this.btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Save.Location = new System.Drawing.Point(111, 127);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20, 2, 2, 20);
            this.btn_Save.Size = new System.Drawing.Size(420, 30);
            this.btn_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Save.Symbol = "";
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "ثبت كاركرد";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // pnl_DailyFunctionsList
            // 
            this.pnl_DailyFunctionsList.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_DailyFunctionsList.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_DailyFunctionsList.Controls.Add(this.dgv_DailyFunctionsList);
            this.pnl_DailyFunctionsList.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_DailyFunctionsList.Location = new System.Drawing.Point(12, 265);
            this.pnl_DailyFunctionsList.Name = "pnl_DailyFunctionsList";
            this.pnl_DailyFunctionsList.Size = new System.Drawing.Size(1026, 225);
            // 
            // 
            // 
            this.pnl_DailyFunctionsList.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_DailyFunctionsList.Style.BackColorGradientAngle = 90;
            this.pnl_DailyFunctionsList.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_DailyFunctionsList.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_DailyFunctionsList.Style.BorderBottomWidth = 1;
            this.pnl_DailyFunctionsList.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_DailyFunctionsList.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_DailyFunctionsList.Style.BorderLeftWidth = 1;
            this.pnl_DailyFunctionsList.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_DailyFunctionsList.Style.BorderRightWidth = 1;
            this.pnl_DailyFunctionsList.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_DailyFunctionsList.Style.BorderTopWidth = 1;
            this.pnl_DailyFunctionsList.Style.CornerDiameter = 4;
            this.pnl_DailyFunctionsList.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_DailyFunctionsList.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_DailyFunctionsList.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_DailyFunctionsList.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_DailyFunctionsList.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_DailyFunctionsList.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_DailyFunctionsList.TabIndex = 2;
            this.pnl_DailyFunctionsList.Text = " فعاليت‌هاي انجام شده";
            // 
            // dgv_DailyFunctionsList
            // 
            this.dgv_DailyFunctionsList.AllowUserToAddRows = false;
            this.dgv_DailyFunctionsList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_DailyFunctionsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DailyFunctionsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DailyFunctionsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DailyFunctionsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_WorkID,
            this.col_WorkSubject,
            this.col_WorkCaption,
            this.col_WorkRequesterUnit,
            this.col_WorkJobID,
            this.col_WorkDoneTime,
            this.col_WorkDoneDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DailyFunctionsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DailyFunctionsList.EnableHeadersVisualStyles = false;
            this.dgv_DailyFunctionsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(181)))), ((int)(((byte)(252)))));
            this.dgv_DailyFunctionsList.Location = new System.Drawing.Point(3, 3);
            this.dgv_DailyFunctionsList.Name = "dgv_DailyFunctionsList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DailyFunctionsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_DailyFunctionsList.Size = new System.Drawing.Size(1014, 182);
            this.dgv_DailyFunctionsList.TabIndex = 0;
            // 
            // col_WorkID
            // 
            this.col_WorkID.HeaderText = "WorkID";
            this.col_WorkID.Name = "col_WorkID";
            this.col_WorkID.Visible = false;
            // 
            // col_WorkSubject
            // 
            this.col_WorkSubject.HeaderText = "موضوع";
            this.col_WorkSubject.Name = "col_WorkSubject";
            this.col_WorkSubject.Width = 180;
            // 
            // col_WorkCaption
            // 
            this.col_WorkCaption.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_WorkCaption.HeaderText = "شرح فعاليت";
            this.col_WorkCaption.Name = "col_WorkCaption";
            // 
            // col_WorkRequesterUnit
            // 
            this.col_WorkRequesterUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_WorkRequesterUnit.HeaderText = "واحد درخواست كننده";
            this.col_WorkRequesterUnit.Name = "col_WorkRequesterUnit";
            this.col_WorkRequesterUnit.Width = 166;
            // 
            // col_WorkJobID
            // 
            this.col_WorkJobID.HeaderText = "WorkJobID";
            this.col_WorkJobID.Name = "col_WorkJobID";
            this.col_WorkJobID.Visible = false;
            // 
            // col_WorkDoneTime
            // 
            this.col_WorkDoneTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_WorkDoneTime.HeaderText = "مدت زمان انجام";
            this.col_WorkDoneTime.Name = "col_WorkDoneTime";
            this.col_WorkDoneTime.Width = 129;
            // 
            // col_WorkDoneDate
            // 
            this.col_WorkDoneDate.HeaderText = "تاريخ انجام";
            this.col_WorkDoneDate.Name = "col_WorkDoneDate";
            this.col_WorkDoneDate.Width = 120;
            // 
            // pnl_Search
            // 
            this.pnl_Search.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Search.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Search.Controls.Add(this.btn_Search);
            this.pnl_Search.Controls.Add(this.txt_DateTo);
            this.pnl_Search.Controls.Add(this.txt_DateIn);
            this.pnl_Search.Controls.Add(this.txt_SearchCaption);
            this.pnl_Search.Controls.Add(this.cmb_SearchRequester);
            this.pnl_Search.Controls.Add(this.lbl_SearchCaption);
            this.pnl_Search.Controls.Add(this.txt_SearchSubject);
            this.pnl_Search.Controls.Add(this.lbl_SearchSubject);
            this.pnl_Search.Controls.Add(this.lbl_SearchDateTo);
            this.pnl_Search.Controls.Add(this.lbl_SearchDateOn);
            this.pnl_Search.Controls.Add(this.lbl_SearchRequester);
            this.pnl_Search.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Search.Location = new System.Drawing.Point(12, 496);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(1026, 102);
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
            // 
            // lbl_SearchSubject
            // 
            this.lbl_SearchSubject.AutoSize = true;
            // 
            // 
            // 
            this.lbl_SearchSubject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SearchSubject.Location = new System.Drawing.Point(901, 7);
            this.lbl_SearchSubject.Name = "lbl_SearchSubject";
            this.lbl_SearchSubject.Size = new System.Drawing.Size(45, 33);
            this.lbl_SearchSubject.TabIndex = 0;
            this.lbl_SearchSubject.Text = "موضوع:";
            // 
            // txt_SearchSubject
            // 
            // 
            // 
            // 
            this.txt_SearchSubject.Border.Class = "TextBoxBorder";
            this.txt_SearchSubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SearchSubject.Location = new System.Drawing.Point(645, 7);
            this.txt_SearchSubject.Name = "txt_SearchSubject";
            this.txt_SearchSubject.PreventEnterBeep = true;
            this.txt_SearchSubject.Size = new System.Drawing.Size(250, 36);
            this.txt_SearchSubject.TabIndex = 1;
            this.txt_SearchSubject.WatermarkText = "جستجو در موضوع فعاليت...";
            // 
            // lbl_SearchCaption
            // 
            this.lbl_SearchCaption.AutoSize = true;
            // 
            // 
            // 
            this.lbl_SearchCaption.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SearchCaption.Location = new System.Drawing.Point(539, 7);
            this.lbl_SearchCaption.Name = "lbl_SearchCaption";
            this.lbl_SearchCaption.Size = new System.Drawing.Size(32, 33);
            this.lbl_SearchCaption.TabIndex = 0;
            this.lbl_SearchCaption.Text = "شرح:";
            // 
            // txt_SearchCaption
            // 
            // 
            // 
            // 
            this.txt_SearchCaption.Border.Class = "TextBoxBorder";
            this.txt_SearchCaption.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SearchCaption.Location = new System.Drawing.Point(180, 7);
            this.txt_SearchCaption.Name = "txt_SearchCaption";
            this.txt_SearchCaption.PreventEnterBeep = true;
            this.txt_SearchCaption.Size = new System.Drawing.Size(353, 36);
            this.txt_SearchCaption.TabIndex = 1;
            this.txt_SearchCaption.WatermarkText = "جستجو در شرح فعاليت...";
            // 
            // lbl_SearchRequester
            // 
            this.lbl_SearchRequester.AutoSize = true;
            // 
            // 
            // 
            this.lbl_SearchRequester.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SearchRequester.Location = new System.Drawing.Point(901, 50);
            this.lbl_SearchRequester.Name = "lbl_SearchRequester";
            this.lbl_SearchRequester.Size = new System.Drawing.Size(100, 33);
            this.lbl_SearchRequester.TabIndex = 0;
            this.lbl_SearchRequester.Text = "درخواست كننده:";
            // 
            // cmb_SearchRequester
            // 
            this.cmb_SearchRequester.DisplayMember = "Text";
            this.cmb_SearchRequester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_SearchRequester.FormattingEnabled = true;
            this.cmb_SearchRequester.ItemHeight = 31;
            this.cmb_SearchRequester.Location = new System.Drawing.Point(645, 50);
            this.cmb_SearchRequester.Name = "cmb_SearchRequester";
            this.cmb_SearchRequester.Size = new System.Drawing.Size(250, 37);
            this.cmb_SearchRequester.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_SearchRequester.TabIndex = 4;
            // 
            // txt_DateTo
            // 
            this.txt_DateTo.BackColor = System.Drawing.Color.White;
            this.txt_DateTo.Font = new System.Drawing.Font("B Nazanin", 14F);
            this.txt_DateTo.Location = new System.Drawing.Point(180, 50);
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
            this.txt_DateIn.Location = new System.Drawing.Point(368, 50);
            this.txt_DateIn.Name = "txt_DateIn";
            this.txt_DateIn.ShowTime = false;
            this.txt_DateIn.Size = new System.Drawing.Size(165, 33);
            this.txt_DateIn.TabIndex = 12;
            this.txt_DateIn.Text = "persianDateTimePicker1";
            this.txt_DateIn.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_DateIn.Value")));
            // 
            // lbl_SearchDateOn
            // 
            this.lbl_SearchDateOn.AutoSize = true;
            // 
            // 
            // 
            this.lbl_SearchDateOn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SearchDateOn.Location = new System.Drawing.Point(539, 50);
            this.lbl_SearchDateOn.Name = "lbl_SearchDateOn";
            this.lbl_SearchDateOn.Size = new System.Drawing.Size(78, 33);
            this.lbl_SearchDateOn.TabIndex = 0;
            this.lbl_SearchDateOn.Text = "تاريخ انجام از";
            // 
            // lbl_SearchDateTo
            // 
            this.lbl_SearchDateTo.AutoSize = true;
            // 
            // 
            // 
            this.lbl_SearchDateTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SearchDateTo.Location = new System.Drawing.Point(351, 50);
            this.lbl_SearchDateTo.Name = "lbl_SearchDateTo";
            this.lbl_SearchDateTo.Size = new System.Drawing.Size(11, 33);
            this.lbl_SearchDateTo.TabIndex = 0;
            this.lbl_SearchDateTo.Text = "تا";
            // 
            // btn_Search
            // 
            this.btn_Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Search.Location = new System.Drawing.Point(33, 7);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(97, 76);
            this.btn_Search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Search.Symbol = "";
            this.btn_Search.TabIndex = 14;
            // 
            // frmUserDailyFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmUserDailyFunction";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUserDailyFunction_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.pnl_AddDailyFunction.ResumeLayout(false);
            this.pnl_AddDailyFunction.PerformLayout();
            this.pnl_DailyFunctionsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DailyFunctionsList)).EndInit();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_AddDailyFunction;
        private DevComponents.DotNetBar.LabelX lbl_FunctionSubject;
        private DevComponents.DotNetBar.LabelX lbl_FunctionCaption;
        private DevComponents.DotNetBar.LabelX lbl_FunctionDoTime;
        private DevComponents.DotNetBar.LabelX lbl_FunctionRequesterUnit;
        private DevComponents.DotNetBar.LabelX lbl_FunctionDoDate;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_FunctionDoTime;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_FunctionCaption;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_FunctionSubject;
        private FreeControls.PersianDateTimePicker txt_FunctionDoDate;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_FunctionRequesterUnit;
        private DevComponents.DotNetBar.LabelX lbl_FunctionTimeUnit;
        private DevComponents.DotNetBar.ButtonX btn_Save;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_DailyFunctionsList;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_DailyFunctionsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WorkID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WorkSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WorkCaption;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WorkRequesterUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WorkJobID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WorkDoneTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WorkDoneDate;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Search;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SearchCaption;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_SearchRequester;
        private DevComponents.DotNetBar.LabelX lbl_SearchCaption;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SearchSubject;
        private DevComponents.DotNetBar.LabelX lbl_SearchSubject;
        private DevComponents.DotNetBar.LabelX lbl_SearchRequester;
        private FreeControls.PersianDateTimePicker txt_DateTo;
        private FreeControls.PersianDateTimePicker txt_DateIn;
        private DevComponents.DotNetBar.LabelX lbl_SearchDateTo;
        private DevComponents.DotNetBar.LabelX lbl_SearchDateOn;
        private DevComponents.DotNetBar.ButtonX btn_Search;
    }
}