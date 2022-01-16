namespace AutomationSystem.AdminPanel
{
    partial class frmUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.pnl_Main = new DevComponents.DotNetBar.PanelEx();
            this.pnl_Buttons = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.btn_EditUser = new DevComponents.DotNetBar.ButtonX();
            this.btn_DeactiveUser = new DevComponents.DotNetBar.ButtonX();
            this.btn_NewUser = new DevComponents.DotNetBar.ButtonX();
            this.pnl_Search = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_Search = new DevComponents.DotNetBar.ButtonX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbt_WomanGender = new System.Windows.Forms.RadioButton();
            this.rbt_ManGender = new System.Windows.Forms.RadioButton();
            this.rbt_AllGender = new System.Windows.Forms.RadioButton();
            this.lbl_Gender = new DevComponents.DotNetBar.LabelX();
            this.lbl_Status = new DevComponents.DotNetBar.LabelX();
            this.pnl_Status = new System.Windows.Forms.Panel();
            this.rbt_DeActiveStatus = new System.Windows.Forms.RadioButton();
            this.rbt_ActiveStatus = new System.Windows.Forms.RadioButton();
            this.rbt_AllStatus = new System.Windows.Forms.RadioButton();
            this.txt_LastName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_LastName = new DevComponents.DotNetBar.LabelX();
            this.lbl_Name = new DevComponents.DotNetBar.LabelX();
            this.pnl_Users = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv_Users = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_UserFristName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UserLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UserPersonalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UserEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UserGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UserStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UserTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UserBrithDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UserRegisteredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Main.SuspendLayout();
            this.pnl_Buttons.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnl_Status.SuspendLayout();
            this.pnl_Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.Location = new System.Drawing.Point(375, 6);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(291, 63);
            this.lbl_Title.Symbol = "59387";
            this.lbl_Title.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "سيستم اتوماسيون اداري";
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.pnl_Buttons);
            this.pnl_Main.Controls.Add(this.pnl_Search);
            this.pnl_Main.Controls.Add(this.pnl_Users);
            this.pnl_Main.Controls.Add(this.lbl_Title);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1000, 663);
            this.pnl_Main.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl_Main.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Main.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Main.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl_Main.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Main.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Main.Style.GradientAngle = 90;
            this.pnl_Main.TabIndex = 2;
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Buttons.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Buttons.Controls.Add(this.btn_Exit);
            this.pnl_Buttons.Controls.Add(this.btn_EditUser);
            this.pnl_Buttons.Controls.Add(this.btn_DeactiveUser);
            this.pnl_Buttons.Controls.Add(this.btn_NewUser);
            this.pnl_Buttons.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Buttons.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pnl_Buttons.Location = new System.Drawing.Point(12, 557);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(975, 100);
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
            this.pnl_Buttons.TabIndex = 4;
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Exit.Location = new System.Drawing.Point(95, 26);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 2, 20, 20);
            this.btn_Exit.Size = new System.Drawing.Size(184, 47);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.Symbol = "";
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "خروج";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_EditUser
            // 
            this.btn_EditUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_EditUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_EditUser.Location = new System.Drawing.Point(285, 26);
            this.btn_EditUser.Name = "btn_EditUser";
            this.btn_EditUser.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 2, 20, 20);
            this.btn_EditUser.Size = new System.Drawing.Size(184, 47);
            this.btn_EditUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_EditUser.Symbol = "58313";
            this.btn_EditUser.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn_EditUser.TabIndex = 2;
            this.btn_EditUser.Text = "ويرايش كاربر";
            // 
            // btn_DeactiveUser
            // 
            this.btn_DeactiveUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_DeactiveUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_DeactiveUser.Location = new System.Drawing.Point(517, 26);
            this.btn_DeactiveUser.Name = "btn_DeactiveUser";
            this.btn_DeactiveUser.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 2, 20, 20);
            this.btn_DeactiveUser.Size = new System.Drawing.Size(184, 47);
            this.btn_DeactiveUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_DeactiveUser.Symbol = "57692";
            this.btn_DeactiveUser.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn_DeactiveUser.TabIndex = 1;
            this.btn_DeactiveUser.Text = "غيرفعال كردن";
            // 
            // btn_NewUser
            // 
            this.btn_NewUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_NewUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_NewUser.Location = new System.Drawing.Point(707, 26);
            this.btn_NewUser.Name = "btn_NewUser";
            this.btn_NewUser.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 2, 20, 20);
            this.btn_NewUser.Size = new System.Drawing.Size(184, 47);
            this.btn_NewUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_NewUser.Symbol = "57671";
            this.btn_NewUser.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn_NewUser.TabIndex = 0;
            this.btn_NewUser.Text = "كاربر جديد";
            this.btn_NewUser.Click += new System.EventHandler(this.btn_NewUser_Click);
            // 
            // pnl_Search
            // 
            this.pnl_Search.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Search.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Search.Controls.Add(this.btn_Search);
            this.pnl_Search.Controls.Add(this.panel3);
            this.pnl_Search.Controls.Add(this.lbl_Gender);
            this.pnl_Search.Controls.Add(this.lbl_Status);
            this.pnl_Search.Controls.Add(this.pnl_Status);
            this.pnl_Search.Controls.Add(this.txt_LastName);
            this.pnl_Search.Controls.Add(this.txt_Name);
            this.pnl_Search.Controls.Add(this.lbl_LastName);
            this.pnl_Search.Controls.Add(this.lbl_Name);
            this.pnl_Search.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Search.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pnl_Search.Location = new System.Drawing.Point(12, 368);
            this.pnl_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(975, 182);
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
            this.btn_Search.Location = new System.Drawing.Point(47, 30);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(108, 90);
            this.btn_Search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Search.Symbol = "";
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbt_WomanGender);
            this.panel3.Controls.Add(this.rbt_ManGender);
            this.panel3.Controls.Add(this.rbt_AllGender);
            this.panel3.Location = new System.Drawing.Point(202, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(77, 131);
            this.panel3.TabIndex = 5;
            // 
            // rbt_WomanGender
            // 
            this.rbt_WomanGender.AutoSize = true;
            this.rbt_WomanGender.Location = new System.Drawing.Point(19, 88);
            this.rbt_WomanGender.Name = "rbt_WomanGender";
            this.rbt_WomanGender.Size = new System.Drawing.Size(46, 30);
            this.rbt_WomanGender.TabIndex = 2;
            this.rbt_WomanGender.TabStop = true;
            this.rbt_WomanGender.Text = "زن";
            this.rbt_WomanGender.UseVisualStyleBackColor = true;
            // 
            // rbt_ManGender
            // 
            this.rbt_ManGender.AutoSize = true;
            this.rbt_ManGender.Location = new System.Drawing.Point(15, 52);
            this.rbt_ManGender.Name = "rbt_ManGender";
            this.rbt_ManGender.Size = new System.Drawing.Size(50, 30);
            this.rbt_ManGender.TabIndex = 1;
            this.rbt_ManGender.TabStop = true;
            this.rbt_ManGender.Text = "مرد";
            this.rbt_ManGender.UseVisualStyleBackColor = true;
            // 
            // rbt_AllGender
            // 
            this.rbt_AllGender.AutoSize = true;
            this.rbt_AllGender.Checked = true;
            this.rbt_AllGender.Location = new System.Drawing.Point(13, 16);
            this.rbt_AllGender.Name = "rbt_AllGender";
            this.rbt_AllGender.Size = new System.Drawing.Size(52, 30);
            this.rbt_AllGender.TabIndex = 0;
            this.rbt_AllGender.TabStop = true;
            this.rbt_AllGender.Text = "همه";
            this.rbt_AllGender.UseVisualStyleBackColor = true;
            // 
            // lbl_Gender
            // 
            // 
            // 
            // 
            this.lbl_Gender.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Gender.Location = new System.Drawing.Point(285, 60);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(52, 23);
            this.lbl_Gender.TabIndex = 7;
            this.lbl_Gender.Text = "جنسيت:";
            // 
            // lbl_Status
            // 
            // 
            // 
            // 
            this.lbl_Status.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Status.Location = new System.Drawing.Point(483, 56);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(52, 23);
            this.lbl_Status.TabIndex = 5;
            this.lbl_Status.Text = "وضعيت:";
            // 
            // pnl_Status
            // 
            this.pnl_Status.Controls.Add(this.rbt_DeActiveStatus);
            this.pnl_Status.Controls.Add(this.rbt_ActiveStatus);
            this.pnl_Status.Controls.Add(this.rbt_AllStatus);
            this.pnl_Status.Location = new System.Drawing.Point(375, 7);
            this.pnl_Status.Name = "pnl_Status";
            this.pnl_Status.Size = new System.Drawing.Size(102, 131);
            this.pnl_Status.TabIndex = 4;
            // 
            // rbt_DeActiveStatus
            // 
            this.rbt_DeActiveStatus.AutoSize = true;
            this.rbt_DeActiveStatus.Location = new System.Drawing.Point(10, 88);
            this.rbt_DeActiveStatus.Name = "rbt_DeActiveStatus";
            this.rbt_DeActiveStatus.Size = new System.Drawing.Size(75, 30);
            this.rbt_DeActiveStatus.TabIndex = 2;
            this.rbt_DeActiveStatus.TabStop = true;
            this.rbt_DeActiveStatus.Text = "غيرفعال";
            this.rbt_DeActiveStatus.UseVisualStyleBackColor = true;
            // 
            // rbt_ActiveStatus
            // 
            this.rbt_ActiveStatus.AutoSize = true;
            this.rbt_ActiveStatus.Location = new System.Drawing.Point(30, 52);
            this.rbt_ActiveStatus.Name = "rbt_ActiveStatus";
            this.rbt_ActiveStatus.Size = new System.Drawing.Size(55, 30);
            this.rbt_ActiveStatus.TabIndex = 1;
            this.rbt_ActiveStatus.TabStop = true;
            this.rbt_ActiveStatus.Text = "فعال";
            this.rbt_ActiveStatus.UseVisualStyleBackColor = true;
            // 
            // rbt_AllStatus
            // 
            this.rbt_AllStatus.AutoSize = true;
            this.rbt_AllStatus.Checked = true;
            this.rbt_AllStatus.Location = new System.Drawing.Point(33, 16);
            this.rbt_AllStatus.Name = "rbt_AllStatus";
            this.rbt_AllStatus.Size = new System.Drawing.Size(52, 30);
            this.rbt_AllStatus.TabIndex = 0;
            this.rbt_AllStatus.TabStop = true;
            this.rbt_AllStatus.Text = "همه";
            this.rbt_AllStatus.UseVisualStyleBackColor = true;
            // 
            // txt_LastName
            // 
            // 
            // 
            // 
            this.txt_LastName.Border.Class = "TextBoxBorder";
            this.txt_LastName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_LastName.Location = new System.Drawing.Point(609, 67);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.PreventEnterBeep = true;
            this.txt_LastName.Size = new System.Drawing.Size(247, 33);
            this.txt_LastName.TabIndex = 3;
            this.txt_LastName.WatermarkText = "جهت جستجو نام‌خانوادگي را وارد كنيد...";
            // 
            // txt_Name
            // 
            // 
            // 
            // 
            this.txt_Name.Border.Class = "TextBoxBorder";
            this.txt_Name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Name.Location = new System.Drawing.Point(609, 28);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PreventEnterBeep = true;
            this.txt_Name.Size = new System.Drawing.Size(247, 33);
            this.txt_Name.TabIndex = 2;
            this.txt_Name.WatermarkText = "جهت جستجو نام را وارد كنيد...";
            // 
            // lbl_LastName
            // 
            // 
            // 
            // 
            this.lbl_LastName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_LastName.Location = new System.Drawing.Point(862, 69);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(74, 23);
            this.lbl_LastName.TabIndex = 1;
            this.lbl_LastName.Text = "نام خانوادگي:";
            // 
            // lbl_Name
            // 
            // 
            // 
            // 
            this.lbl_Name.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Name.Location = new System.Drawing.Point(862, 30);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(20, 23);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "نام:";
            // 
            // pnl_Users
            // 
            this.pnl_Users.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Users.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Users.Controls.Add(this.dgv_Users);
            this.pnl_Users.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Users.Location = new System.Drawing.Point(13, 79);
            this.pnl_Users.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Users.Name = "pnl_Users";
            this.pnl_Users.Size = new System.Drawing.Size(975, 281);
            // 
            // 
            // 
            this.pnl_Users.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Users.Style.BackColorGradientAngle = 90;
            this.pnl_Users.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Users.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Users.Style.BorderBottomWidth = 1;
            this.pnl_Users.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Users.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Users.Style.BorderLeftWidth = 1;
            this.pnl_Users.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Users.Style.BorderRightWidth = 1;
            this.pnl_Users.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Users.Style.BorderTopWidth = 1;
            this.pnl_Users.Style.CornerDiameter = 4;
            this.pnl_Users.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_Users.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_Users.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Users.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_Users.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_Users.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_Users.TabIndex = 2;
            // 
            // dgv_Users
            // 
            this.dgv_Users.AllowUserToAddRows = false;
            this.dgv_Users.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_UserFristName,
            this.col_UserLastName,
            this.col_UserPersonalCode,
            this.col_UserEmail,
            this.col_UserGender,
            this.col_UserStatus,
            this.col_UserTel,
            this.col_UserBrithDay,
            this.col_UserRegisteredDate,
            this.col_UserID});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Users.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Users.EnableHeadersVisualStyles = false;
            this.dgv_Users.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(181)))), ((int)(((byte)(252)))));
            this.dgv_Users.Location = new System.Drawing.Point(3, 3);
            this.dgv_Users.Name = "dgv_Users";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Users.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Users.Size = new System.Drawing.Size(963, 269);
            this.dgv_Users.TabIndex = 1;
            // 
            // col_UserFristName
            // 
            this.col_UserFristName.HeaderText = "نام";
            this.col_UserFristName.Name = "col_UserFristName";
            // 
            // col_UserLastName
            // 
            this.col_UserLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_UserLastName.HeaderText = "نام خانوادگي";
            this.col_UserLastName.Name = "col_UserLastName";
            // 
            // col_UserPersonalCode
            // 
            this.col_UserPersonalCode.HeaderText = "كد پرسنلي";
            this.col_UserPersonalCode.Name = "col_UserPersonalCode";
            // 
            // col_UserEmail
            // 
            this.col_UserEmail.HeaderText = "ايميل";
            this.col_UserEmail.Name = "col_UserEmail";
            // 
            // col_UserGender
            // 
            this.col_UserGender.HeaderText = "جنسيت";
            this.col_UserGender.Name = "col_UserGender";
            // 
            // col_UserStatus
            // 
            this.col_UserStatus.HeaderText = "وضعيت";
            this.col_UserStatus.Name = "col_UserStatus";
            // 
            // col_UserTel
            // 
            this.col_UserTel.HeaderText = "شماره تماس";
            this.col_UserTel.Name = "col_UserTel";
            // 
            // col_UserBrithDay
            // 
            this.col_UserBrithDay.HeaderText = "تاريخ تولد";
            this.col_UserBrithDay.Name = "col_UserBrithDay";
            // 
            // col_UserRegisteredDate
            // 
            this.col_UserRegisteredDate.HeaderText = "تاريخ ثبت";
            this.col_UserRegisteredDate.Name = "col_UserRegisteredDate";
            // 
            // col_UserID
            // 
            this.col_UserID.HeaderText = "UserID";
            this.col_UserID.Name = "col_UserID";
            this.col_UserID.Visible = false;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 663);
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmUsers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUsers";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Buttons.ResumeLayout(false);
            this.pnl_Search.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnl_Status.ResumeLayout(false);
            this.pnl_Status.PerformLayout();
            this.pnl_Users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Users;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Search;
        private DevComponents.DotNetBar.LabelX lbl_LastName;
        private DevComponents.DotNetBar.LabelX lbl_Name;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_LastName;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Name;
        private DevComponents.DotNetBar.LabelX lbl_Gender;
        private DevComponents.DotNetBar.LabelX lbl_Status;
        private System.Windows.Forms.Panel pnl_Status;
        private System.Windows.Forms.RadioButton rbt_DeActiveStatus;
        private System.Windows.Forms.RadioButton rbt_ActiveStatus;
        private System.Windows.Forms.RadioButton rbt_AllStatus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbt_WomanGender;
        private System.Windows.Forms.RadioButton rbt_ManGender;
        private System.Windows.Forms.RadioButton rbt_AllGender;
        private DevComponents.DotNetBar.ButtonX btn_Search;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Buttons;
        private DevComponents.DotNetBar.ButtonX btn_DeactiveUser;
        private DevComponents.DotNetBar.ButtonX btn_NewUser;
        private DevComponents.DotNetBar.ButtonX btn_EditUser;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_Users;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserFristName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserPersonalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserBrithDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserRegisteredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserID;
    }
}