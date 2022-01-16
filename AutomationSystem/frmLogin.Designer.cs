namespace AutomationSystem
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.lbl_Username = new DevComponents.DotNetBar.LabelX();
            this.pnl_MainPanel = new DevComponents.DotNetBar.PanelEx();
            this.pnl_Info = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_InfoTwo = new DevComponents.DotNetBar.LabelX();
            this.lbl_InfoOne = new DevComponents.DotNetBar.LabelX();
            this.btn_About = new DevComponents.DotNetBar.ButtonX();
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.btn_Login = new DevComponents.DotNetBar.ButtonX();
            this.rdb_Admin = new System.Windows.Forms.RadioButton();
            this.rdb_User = new System.Windows.Forms.RadioButton();
            this.txt_Password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Username = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_Password = new DevComponents.DotNetBar.LabelX();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.stb_StatusBar = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.lbl_Date = new DevComponents.DotNetBar.LabelItem();
            this.lbl_DateValue = new DevComponents.DotNetBar.LabelItem();
            this.lbl_DoubleLine1 = new DevComponents.DotNetBar.LabelItem();
            this.lbl_Time = new DevComponents.DotNetBar.LabelItem();
            this.lbl_TimeValue = new DevComponents.DotNetBar.LabelItem();
            this.lbl_DoubleLine2 = new DevComponents.DotNetBar.LabelItem();
            this.lbl_YourIP = new DevComponents.DotNetBar.LabelItem();
            this.lbl_YourIPValue = new DevComponents.DotNetBar.LabelItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnl_MainPanel.SuspendLayout();
            this.pnl_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("B Nazanin", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Title.Location = new System.Drawing.Point(197, 14);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(345, 69);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "سيستم اتوماسيون اداري";
            // 
            // lbl_Username
            // 
            // 
            // 
            // 
            this.lbl_Username.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Username.Location = new System.Drawing.Point(650, 142);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(65, 37);
            this.lbl_Username.TabIndex = 1;
            this.lbl_Username.Text = "نام كاربري";
            // 
            // pnl_MainPanel
            // 
            this.pnl_MainPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_MainPanel.Controls.Add(this.pnl_Info);
            this.pnl_MainPanel.Controls.Add(this.btn_About);
            this.pnl_MainPanel.Controls.Add(this.btn_Exit);
            this.pnl_MainPanel.Controls.Add(this.btn_Login);
            this.pnl_MainPanel.Controls.Add(this.rdb_Admin);
            this.pnl_MainPanel.Controls.Add(this.rdb_User);
            this.pnl_MainPanel.Controls.Add(this.txt_Password);
            this.pnl_MainPanel.Controls.Add(this.txt_Username);
            this.pnl_MainPanel.Controls.Add(this.lbl_Password);
            this.pnl_MainPanel.Controls.Add(this.lbl_Title);
            this.pnl_MainPanel.Controls.Add(this.lbl_Username);
            this.pnl_MainPanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_MainPanel.Font = new System.Drawing.Font("B Nazanin", 14.25F);
            this.pnl_MainPanel.Location = new System.Drawing.Point(0, 0);
            this.pnl_MainPanel.Name = "pnl_MainPanel";
            this.pnl_MainPanel.Size = new System.Drawing.Size(742, 431);
            this.pnl_MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl_MainPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_MainPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_MainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl_MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_MainPanel.Style.GradientAngle = 90;
            this.pnl_MainPanel.TabIndex = 2;
            // 
            // pnl_Info
            // 
            this.pnl_Info.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Info.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Info.Controls.Add(this.lbl_InfoTwo);
            this.pnl_Info.Controls.Add(this.lbl_InfoOne);
            this.pnl_Info.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Info.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pnl_Info.Location = new System.Drawing.Point(24, 121);
            this.pnl_Info.Name = "pnl_Info";
            this.pnl_Info.Size = new System.Drawing.Size(264, 279);
            // 
            // 
            // 
            this.pnl_Info.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Info.Style.BackColorGradientAngle = 90;
            this.pnl_Info.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Info.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Info.Style.BorderBottomWidth = 1;
            this.pnl_Info.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Info.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Info.Style.BorderLeftWidth = 1;
            this.pnl_Info.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Info.Style.BorderRightWidth = 1;
            this.pnl_Info.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Info.Style.BorderTopWidth = 1;
            this.pnl_Info.Style.CornerDiameter = 4;
            this.pnl_Info.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_Info.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_Info.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Info.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_Info.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_Info.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_Info.TabIndex = 10;
            this.pnl_Info.Text = "توجه";
            // 
            // lbl_InfoTwo
            // 
            // 
            // 
            // 
            this.lbl_InfoTwo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_InfoTwo.Location = new System.Drawing.Point(3, 135);
            this.lbl_InfoTwo.Name = "lbl_InfoTwo";
            this.lbl_InfoTwo.Size = new System.Drawing.Size(252, 89);
            this.lbl_InfoTwo.Symbol = "";
            this.lbl_InfoTwo.SymbolColor = System.Drawing.Color.Blue;
            this.lbl_InfoTwo.TabIndex = 1;
            this.lbl_InfoTwo.Text = "گذرواژه خود را به‌صورت دوره‌اي و مرتب تغيير دهيد.";
            this.lbl_InfoTwo.WordWrap = true;
            // 
            // lbl_InfoOne
            // 
            // 
            // 
            // 
            this.lbl_InfoOne.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_InfoOne.Location = new System.Drawing.Point(3, 21);
            this.lbl_InfoOne.Name = "lbl_InfoOne";
            this.lbl_InfoOne.Size = new System.Drawing.Size(252, 89);
            this.lbl_InfoOne.Symbol = "";
            this.lbl_InfoOne.SymbolColor = System.Drawing.Color.Blue;
            this.lbl_InfoOne.TabIndex = 0;
            this.lbl_InfoOne.Text = "نام كاربري و رمزعبور خود را به هيچ عنوان در اختيار ديگران قرار ندهيد.";
            this.lbl_InfoOne.WordWrap = true;
            // 
            // btn_About
            // 
            this.btn_About.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_About.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_About.Location = new System.Drawing.Point(294, 330);
            this.btn_About.Name = "btn_About";
            this.btn_About.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_About.Size = new System.Drawing.Size(423, 32);
            this.btn_About.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_About.TabIndex = 9;
            this.btn_About.Text = "درباره ما";
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Exit.Location = new System.Drawing.Point(294, 368);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btn_Exit.Size = new System.Drawing.Size(423, 32);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "خروج";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Login.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Login.Location = new System.Drawing.Point(294, 292);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btn_Login.Size = new System.Drawing.Size(423, 32);
            this.btn_Login.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Login.TabIndex = 7;
            this.btn_Login.Text = "ورود";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // rdb_Admin
            // 
            this.rdb_Admin.AutoSize = true;
            this.rdb_Admin.Checked = true;
            this.rdb_Admin.Location = new System.Drawing.Point(470, 235);
            this.rdb_Admin.Name = "rdb_Admin";
            this.rdb_Admin.Size = new System.Drawing.Size(104, 32);
            this.rdb_Admin.TabIndex = 6;
            this.rdb_Admin.TabStop = true;
            this.rdb_Admin.Text = "مدير سيستم";
            this.rdb_Admin.UseVisualStyleBackColor = true;
            // 
            // rdb_User
            // 
            this.rdb_User.AutoSize = true;
            this.rdb_User.Location = new System.Drawing.Point(377, 235);
            this.rdb_User.Name = "rdb_User";
            this.rdb_User.Size = new System.Drawing.Size(57, 32);
            this.rdb_User.TabIndex = 5;
            this.rdb_User.Text = "كاربر";
            this.rdb_User.UseVisualStyleBackColor = true;
            // 
            // txt_Password
            // 
            // 
            // 
            // 
            this.txt_Password.Border.Class = "TextBoxBorder";
            this.txt_Password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Password.Location = new System.Drawing.Point(294, 184);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.PreventEnterBeep = true;
            this.txt_Password.Size = new System.Drawing.Size(352, 36);
            this.txt_Password.TabIndex = 4;
            this.txt_Password.WatermarkText = "گذرواژه خود را وارد كنيد...";
            // 
            // txt_Username
            // 
            // 
            // 
            // 
            this.txt_Username.Border.Class = "TextBoxBorder";
            this.txt_Username.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Username.Location = new System.Drawing.Point(294, 142);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PreventEnterBeep = true;
            this.txt_Username.Size = new System.Drawing.Size(352, 36);
            this.txt_Username.TabIndex = 3;
            this.txt_Username.WatermarkText = "نام كاربري خود را وارد كنيد...";
            // 
            // lbl_Password
            // 
            // 
            // 
            // 
            this.lbl_Password.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Password.Location = new System.Drawing.Point(650, 184);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(53, 37);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "گذرواژه";
            // 
            // styleManager
            // 
            this.styleManager.ManagerColorTint = System.Drawing.Color.Blue;
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // stb_StatusBar
            // 
            // 
            // 
            // 
            this.stb_StatusBar.BackgroundStyle.BackColor = System.Drawing.Color.Blue;
            this.stb_StatusBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.stb_StatusBar.ContainerControlProcessDialogKey = true;
            this.stb_StatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stb_StatusBar.DragDropSupport = true;
            this.stb_StatusBar.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.stb_StatusBar.ForeColor = System.Drawing.Color.White;
            this.stb_StatusBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lbl_Date,
            this.lbl_DateValue,
            this.lbl_DoubleLine1,
            this.lbl_Time,
            this.lbl_TimeValue,
            this.lbl_DoubleLine2,
            this.lbl_YourIP,
            this.lbl_YourIPValue});
            this.stb_StatusBar.Location = new System.Drawing.Point(0, 409);
            this.stb_StatusBar.Name = "stb_StatusBar";
            this.stb_StatusBar.Size = new System.Drawing.Size(742, 22);
            this.stb_StatusBar.TabIndex = 6;
            this.stb_StatusBar.Text = "--";
            // 
            // lbl_Date
            // 
            this.lbl_Date.ForeColor = System.Drawing.Color.White;
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Text = "تاريخ:";
            // 
            // lbl_DateValue
            // 
            this.lbl_DateValue.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_DateValue.Name = "lbl_DateValue";
            this.lbl_DateValue.Text = "1400/10/26";
            // 
            // lbl_DoubleLine1
            // 
            this.lbl_DoubleLine1.Name = "lbl_DoubleLine1";
            this.lbl_DoubleLine1.Text = "--";
            // 
            // lbl_Time
            // 
            this.lbl_Time.ForeColor = System.Drawing.Color.White;
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Text = "ساعت:";
            // 
            // lbl_TimeValue
            // 
            this.lbl_TimeValue.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_TimeValue.Name = "lbl_TimeValue";
            this.lbl_TimeValue.Text = "22:44:13";
            // 
            // lbl_DoubleLine2
            // 
            this.lbl_DoubleLine2.Name = "lbl_DoubleLine2";
            this.lbl_DoubleLine2.Text = "--";
            // 
            // lbl_YourIP
            // 
            this.lbl_YourIP.ForeColor = System.Drawing.Color.White;
            this.lbl_YourIP.Name = "lbl_YourIP";
            this.lbl_YourIP.Text = "آي‌پي شما:";
            // 
            // lbl_YourIPValue
            // 
            this.lbl_YourIPValue.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_YourIPValue.Name = "lbl_YourIPValue";
            this.lbl_YourIPValue.Text = "192.168.202.517";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 431);
            this.Controls.Add(this.stb_StatusBar);
            this.Controls.Add(this.pnl_MainPanel);
            this.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnl_MainPanel.ResumeLayout(false);
            this.pnl_MainPanel.PerformLayout();
            this.pnl_Info.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.LabelX lbl_Username;
        private DevComponents.DotNetBar.PanelEx pnl_MainPanel;
        private DevComponents.DotNetBar.LabelX lbl_Password;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Password;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Username;
        private System.Windows.Forms.RadioButton rdb_Admin;
        private System.Windows.Forms.RadioButton rdb_User;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
        private DevComponents.DotNetBar.ButtonX btn_Login;
        private DevComponents.DotNetBar.ButtonX btn_About;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Info;
        private DevComponents.DotNetBar.LabelX lbl_InfoOne;
        private DevComponents.DotNetBar.LabelX lbl_InfoTwo;
        private DevComponents.DotNetBar.StyleManager styleManager;
        private DevComponents.DotNetBar.Metro.MetroStatusBar stb_StatusBar;
        private DevComponents.DotNetBar.LabelItem lbl_Date;
        private DevComponents.DotNetBar.LabelItem lbl_DateValue;
        private DevComponents.DotNetBar.LabelItem lbl_DoubleLine1;
        private DevComponents.DotNetBar.LabelItem lbl_Time;
        private DevComponents.DotNetBar.LabelItem lbl_TimeValue;
        private DevComponents.DotNetBar.LabelItem lbl_DoubleLine2;
        private DevComponents.DotNetBar.LabelItem lbl_YourIP;
        private DevComponents.DotNetBar.LabelItem lbl_YourIPValue;
        private System.Windows.Forms.Timer timer;
    }
}