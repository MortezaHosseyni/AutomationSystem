namespace AutomationSystem.AdminPanel
{
    partial class frmUserManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserManager));
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.pnl_Main = new DevComponents.DotNetBar.PanelEx();
            this.pnl_UserInformation = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txt_Email = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_UserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_LastName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_Email = new DevComponents.DotNetBar.LabelX();
            this.lbl_Password = new DevComponents.DotNetBar.LabelX();
            this.lbl_UserName = new DevComponents.DotNetBar.LabelX();
            this.lbl_LastName = new DevComponents.DotNetBar.LabelX();
            this.lbl_Name = new DevComponents.DotNetBar.LabelX();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.txt_Tel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_Tel = new DevComponents.DotNetBar.LabelX();
            this.txt_PersonalCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_PersonalCode = new DevComponents.DotNetBar.LabelX();
            this.lbl_BrithDate = new DevComponents.DotNetBar.LabelX();
            this.lbl_Gender = new DevComponents.DotNetBar.LabelX();
            this.rbt_Man = new System.Windows.Forms.RadioButton();
            this.rbt_Woman = new System.Windows.Forms.RadioButton();
            this.lbl_RegisterDate = new DevComponents.DotNetBar.LabelX();
            this.lbl_RegisterDateValue = new DevComponents.DotNetBar.LabelX();
            this.pnl_UserPic = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.pnl_UserSignature = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.pnl_Buttons = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.pic_UserSignature = new System.Windows.Forms.PictureBox();
            this.pic_UserPic = new System.Windows.Forms.PictureBox();
            this.txt_BrithDate = new FreeControls.PersianDateTimePicker();
            this.btn_Save = new DevComponents.DotNetBar.ButtonX();
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.openFileDLG = new System.Windows.Forms.OpenFileDialog();
            this.pnl_Main.SuspendLayout();
            this.pnl_UserInformation.SuspendLayout();
            this.pnl_UserPic.SuspendLayout();
            this.pnl_UserSignature.SuspendLayout();
            this.pnl_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UserSignature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UserPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("B Nazanin", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Title.Location = new System.Drawing.Point(420, 6);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(206, 42);
            this.lbl_Title.Symbol = "59389";
            this.lbl_Title.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "فرم مديريت كاربر";
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.pnl_Buttons);
            this.pnl_Main.Controls.Add(this.pnl_UserInformation);
            this.pnl_Main.Controls.Add(this.lbl_Title);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1042, 460);
            this.pnl_Main.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl_Main.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Main.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Main.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl_Main.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Main.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Main.Style.GradientAngle = 90;
            this.pnl_Main.TabIndex = 1;
            // 
            // pnl_UserInformation
            // 
            this.pnl_UserInformation.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_UserInformation.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_UserInformation.Controls.Add(this.txt_BrithDate);
            this.pnl_UserInformation.Controls.Add(this.pnl_UserSignature);
            this.pnl_UserInformation.Controls.Add(this.pnl_UserPic);
            this.pnl_UserInformation.Controls.Add(this.lbl_RegisterDateValue);
            this.pnl_UserInformation.Controls.Add(this.lbl_RegisterDate);
            this.pnl_UserInformation.Controls.Add(this.rbt_Woman);
            this.pnl_UserInformation.Controls.Add(this.rbt_Man);
            this.pnl_UserInformation.Controls.Add(this.lbl_Gender);
            this.pnl_UserInformation.Controls.Add(this.lbl_BrithDate);
            this.pnl_UserInformation.Controls.Add(this.txt_PersonalCode);
            this.pnl_UserInformation.Controls.Add(this.lbl_PersonalCode);
            this.pnl_UserInformation.Controls.Add(this.txt_Tel);
            this.pnl_UserInformation.Controls.Add(this.lbl_Tel);
            this.pnl_UserInformation.Controls.Add(this.txt_Email);
            this.pnl_UserInformation.Controls.Add(this.txt_Password);
            this.pnl_UserInformation.Controls.Add(this.txt_UserName);
            this.pnl_UserInformation.Controls.Add(this.txt_LastName);
            this.pnl_UserInformation.Controls.Add(this.txt_Name);
            this.pnl_UserInformation.Controls.Add(this.lbl_Email);
            this.pnl_UserInformation.Controls.Add(this.lbl_Password);
            this.pnl_UserInformation.Controls.Add(this.lbl_UserName);
            this.pnl_UserInformation.Controls.Add(this.lbl_LastName);
            this.pnl_UserInformation.Controls.Add(this.lbl_Name);
            this.pnl_UserInformation.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_UserInformation.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pnl_UserInformation.Location = new System.Drawing.Point(12, 72);
            this.pnl_UserInformation.Name = "pnl_UserInformation";
            this.pnl_UserInformation.Size = new System.Drawing.Size(1018, 282);
            // 
            // 
            // 
            this.pnl_UserInformation.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_UserInformation.Style.BackColorGradientAngle = 90;
            this.pnl_UserInformation.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_UserInformation.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UserInformation.Style.BorderBottomWidth = 1;
            this.pnl_UserInformation.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_UserInformation.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UserInformation.Style.BorderLeftWidth = 1;
            this.pnl_UserInformation.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UserInformation.Style.BorderRightWidth = 1;
            this.pnl_UserInformation.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UserInformation.Style.BorderTopWidth = 1;
            this.pnl_UserInformation.Style.CornerDiameter = 4;
            this.pnl_UserInformation.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_UserInformation.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_UserInformation.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_UserInformation.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_UserInformation.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_UserInformation.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_UserInformation.TabIndex = 1;
            this.pnl_UserInformation.Text = "مشخصات كاربر";
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.txt_Email.Border.Class = "TextBoxBorder";
            this.txt_Email.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Email.Location = new System.Drawing.Point(710, 186);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.PreventEnterBeep = true;
            this.txt_Email.Size = new System.Drawing.Size(209, 33);
            this.txt_Email.TabIndex = 4;
            this.txt_Email.WatermarkText = "ايميل كاربر را وارد كنيد...";
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.txt_Password.Border.Class = "TextBoxBorder";
            this.txt_Password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Password.Location = new System.Drawing.Point(710, 147);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.PreventEnterBeep = true;
            this.txt_Password.Size = new System.Drawing.Size(209, 33);
            this.txt_Password.TabIndex = 3;
            this.txt_Password.WatermarkText = "براي كاربر گذرواژه وارد كنيد...";
            // 
            // txt_UserName
            // 
            this.txt_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.txt_UserName.Border.Class = "TextBoxBorder";
            this.txt_UserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_UserName.Location = new System.Drawing.Point(710, 108);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.PreventEnterBeep = true;
            this.txt_UserName.Size = new System.Drawing.Size(209, 33);
            this.txt_UserName.TabIndex = 2;
            this.txt_UserName.WatermarkText = "يك نام كاربري وارد كنيد...";
            // 
            // txt_LastName
            // 
            this.txt_LastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.txt_LastName.Border.Class = "TextBoxBorder";
            this.txt_LastName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_LastName.Location = new System.Drawing.Point(710, 69);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.PreventEnterBeep = true;
            this.txt_LastName.Size = new System.Drawing.Size(209, 33);
            this.txt_LastName.TabIndex = 1;
            this.txt_LastName.WatermarkText = "نام خانوادگي كاربر را وارد كنيد...";
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.txt_Name.Border.Class = "TextBoxBorder";
            this.txt_Name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Name.Location = new System.Drawing.Point(710, 30);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PreventEnterBeep = true;
            this.txt_Name.Size = new System.Drawing.Size(209, 33);
            this.txt_Name.TabIndex = 0;
            this.txt_Name.WatermarkText = "نام كاربر را وارد كنيد...";
            // 
            // lbl_Email
            // 
            // 
            // 
            // 
            this.lbl_Email.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Email.Location = new System.Drawing.Point(925, 188);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(37, 23);
            this.lbl_Email.TabIndex = 4;
            this.lbl_Email.Text = "ايميل:";
            // 
            // lbl_Password
            // 
            // 
            // 
            // 
            this.lbl_Password.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Password.Location = new System.Drawing.Point(925, 149);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(47, 23);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "گذرواژه:";
            // 
            // lbl_UserName
            // 
            // 
            // 
            // 
            this.lbl_UserName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_UserName.Location = new System.Drawing.Point(925, 110);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(62, 23);
            this.lbl_UserName.TabIndex = 2;
            this.lbl_UserName.Text = "نام كاربري:";
            // 
            // lbl_LastName
            // 
            // 
            // 
            // 
            this.lbl_LastName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_LastName.Location = new System.Drawing.Point(925, 71);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(75, 23);
            this.lbl_LastName.TabIndex = 1;
            this.lbl_LastName.Text = "نام خانوادگي:";
            // 
            // lbl_Name
            // 
            // 
            // 
            // 
            this.lbl_Name.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Name.Location = new System.Drawing.Point(925, 32);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(21, 23);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "نام:";
            // 
            // styleManager
            // 
            this.styleManager.ManagerColorTint = System.Drawing.Color.Blue;
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // txt_Tel
            // 
            this.txt_Tel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.txt_Tel.Border.Class = "TextBoxBorder";
            this.txt_Tel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Tel.Location = new System.Drawing.Point(402, 30);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.PreventEnterBeep = true;
            this.txt_Tel.Size = new System.Drawing.Size(209, 33);
            this.txt_Tel.TabIndex = 5;
            this.txt_Tel.WatermarkText = "شماره تماس كاربر را وارد كنيد...";
            // 
            // lbl_Tel
            // 
            // 
            // 
            // 
            this.lbl_Tel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Tel.Location = new System.Drawing.Point(617, 32);
            this.lbl_Tel.Name = "lbl_Tel";
            this.lbl_Tel.Size = new System.Drawing.Size(73, 23);
            this.lbl_Tel.TabIndex = 10;
            this.lbl_Tel.Text = "شماره تماس:";
            // 
            // txt_PersonalCode
            // 
            this.txt_PersonalCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.txt_PersonalCode.Border.Class = "TextBoxBorder";
            this.txt_PersonalCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_PersonalCode.Location = new System.Drawing.Point(402, 69);
            this.txt_PersonalCode.Name = "txt_PersonalCode";
            this.txt_PersonalCode.PreventEnterBeep = true;
            this.txt_PersonalCode.Size = new System.Drawing.Size(209, 33);
            this.txt_PersonalCode.TabIndex = 6;
            this.txt_PersonalCode.WatermarkText = "كد پرسنلي كاربر را وارد كنيد...";
            // 
            // lbl_PersonalCode
            // 
            // 
            // 
            // 
            this.lbl_PersonalCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_PersonalCode.Location = new System.Drawing.Point(617, 71);
            this.lbl_PersonalCode.Name = "lbl_PersonalCode";
            this.lbl_PersonalCode.Size = new System.Drawing.Size(66, 23);
            this.lbl_PersonalCode.TabIndex = 12;
            this.lbl_PersonalCode.Text = "كد پرسنلي:";
            // 
            // lbl_BrithDate
            // 
            // 
            // 
            // 
            this.lbl_BrithDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_BrithDate.Location = new System.Drawing.Point(617, 110);
            this.lbl_BrithDate.Name = "lbl_BrithDate";
            this.lbl_BrithDate.Size = new System.Drawing.Size(61, 23);
            this.lbl_BrithDate.TabIndex = 14;
            this.lbl_BrithDate.Text = "تاريخ تولد:";
            // 
            // lbl_Gender
            // 
            // 
            // 
            // 
            this.lbl_Gender.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Gender.Location = new System.Drawing.Point(617, 149);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(51, 23);
            this.lbl_Gender.TabIndex = 16;
            this.lbl_Gender.Text = "جنسيت:";
            // 
            // rbt_Man
            // 
            this.rbt_Man.AutoSize = true;
            this.rbt_Man.Location = new System.Drawing.Point(520, 147);
            this.rbt_Man.Name = "rbt_Man";
            this.rbt_Man.Size = new System.Drawing.Size(50, 30);
            this.rbt_Man.TabIndex = 8;
            this.rbt_Man.TabStop = true;
            this.rbt_Man.Text = "مرد";
            this.rbt_Man.UseVisualStyleBackColor = true;
            // 
            // rbt_Woman
            // 
            this.rbt_Woman.AutoSize = true;
            this.rbt_Woman.Location = new System.Drawing.Point(443, 147);
            this.rbt_Woman.Name = "rbt_Woman";
            this.rbt_Woman.Size = new System.Drawing.Size(46, 30);
            this.rbt_Woman.TabIndex = 9;
            this.rbt_Woman.TabStop = true;
            this.rbt_Woman.Text = "زن";
            this.rbt_Woman.UseVisualStyleBackColor = true;
            // 
            // lbl_RegisterDate
            // 
            // 
            // 
            // 
            this.lbl_RegisterDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_RegisterDate.Location = new System.Drawing.Point(617, 188);
            this.lbl_RegisterDate.Name = "lbl_RegisterDate";
            this.lbl_RegisterDate.Size = new System.Drawing.Size(63, 23);
            this.lbl_RegisterDate.TabIndex = 19;
            this.lbl_RegisterDate.Text = "تاريخ ثبت:";
            // 
            // lbl_RegisterDateValue
            // 
            this.lbl_RegisterDateValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.lbl_RegisterDateValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_RegisterDateValue.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_RegisterDateValue.ForeColor = System.Drawing.Color.Blue;
            this.lbl_RegisterDateValue.Location = new System.Drawing.Point(402, 183);
            this.lbl_RegisterDateValue.Name = "lbl_RegisterDateValue";
            this.lbl_RegisterDateValue.SingleLineColor = System.Drawing.SystemColors.Control;
            this.lbl_RegisterDateValue.Size = new System.Drawing.Size(209, 31);
            this.lbl_RegisterDateValue.TabIndex = 20;
            this.lbl_RegisterDateValue.Text = "1400/10/26";
            this.lbl_RegisterDateValue.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pnl_UserPic
            // 
            this.pnl_UserPic.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_UserPic.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_UserPic.Controls.Add(this.pic_UserPic);
            this.pnl_UserPic.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_UserPic.Location = new System.Drawing.Point(196, 13);
            this.pnl_UserPic.Name = "pnl_UserPic";
            this.pnl_UserPic.Size = new System.Drawing.Size(171, 202);
            // 
            // 
            // 
            this.pnl_UserPic.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_UserPic.Style.BackColorGradientAngle = 90;
            this.pnl_UserPic.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_UserPic.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UserPic.Style.BorderBottomWidth = 1;
            this.pnl_UserPic.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_UserPic.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UserPic.Style.BorderLeftWidth = 1;
            this.pnl_UserPic.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UserPic.Style.BorderRightWidth = 1;
            this.pnl_UserPic.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UserPic.Style.BorderTopWidth = 1;
            this.pnl_UserPic.Style.CornerDiameter = 4;
            this.pnl_UserPic.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_UserPic.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_UserPic.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_UserPic.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_UserPic.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_UserPic.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_UserPic.TabIndex = 21;
            this.pnl_UserPic.Text = "عكس كاربر";
            // 
            // pnl_UserSignature
            // 
            this.pnl_UserSignature.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_UserSignature.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_UserSignature.Controls.Add(this.pic_UserSignature);
            this.pnl_UserSignature.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_UserSignature.Location = new System.Drawing.Point(18, 12);
            this.pnl_UserSignature.Name = "pnl_UserSignature";
            this.pnl_UserSignature.Size = new System.Drawing.Size(171, 202);
            // 
            // 
            // 
            this.pnl_UserSignature.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_UserSignature.Style.BackColorGradientAngle = 90;
            this.pnl_UserSignature.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_UserSignature.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UserSignature.Style.BorderBottomWidth = 1;
            this.pnl_UserSignature.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_UserSignature.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UserSignature.Style.BorderLeftWidth = 1;
            this.pnl_UserSignature.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UserSignature.Style.BorderRightWidth = 1;
            this.pnl_UserSignature.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UserSignature.Style.BorderTopWidth = 1;
            this.pnl_UserSignature.Style.CornerDiameter = 4;
            this.pnl_UserSignature.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_UserSignature.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_UserSignature.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_UserSignature.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_UserSignature.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_UserSignature.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_UserSignature.TabIndex = 22;
            this.pnl_UserSignature.Text = "نمونه امضاء";
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Buttons.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Buttons.Controls.Add(this.btn_Exit);
            this.pnl_Buttons.Controls.Add(this.btn_Save);
            this.pnl_Buttons.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Buttons.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pnl_Buttons.Location = new System.Drawing.Point(12, 362);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(1018, 91);
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
            this.pnl_Buttons.TabIndex = 2;
            // 
            // pic_UserSignature
            // 
            this.pic_UserSignature.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_UserSignature.Image = global::AutomationSystem.Properties.Resources._08_UserSignature;
            this.pic_UserSignature.Location = new System.Drawing.Point(3, 3);
            this.pic_UserSignature.Name = "pic_UserSignature";
            this.pic_UserSignature.Size = new System.Drawing.Size(159, 162);
            this.pic_UserSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_UserSignature.TabIndex = 1;
            this.pic_UserSignature.TabStop = false;
            this.pic_UserSignature.Click += new System.EventHandler(this.pic_UserSignature_Click);
            // 
            // pic_UserPic
            // 
            this.pic_UserPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_UserPic.Image = global::AutomationSystem.Properties.Resources._07_UserPicture;
            this.pic_UserPic.Location = new System.Drawing.Point(3, 3);
            this.pic_UserPic.Name = "pic_UserPic";
            this.pic_UserPic.Size = new System.Drawing.Size(159, 162);
            this.pic_UserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_UserPic.TabIndex = 0;
            this.pic_UserPic.TabStop = false;
            this.pic_UserPic.Click += new System.EventHandler(this.pic_UserPic_Click);
            // 
            // txt_BrithDate
            // 
            this.txt_BrithDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_BrithDate.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_BrithDate.Location = new System.Drawing.Point(402, 108);
            this.txt_BrithDate.Name = "txt_BrithDate";
            this.txt_BrithDate.ShowTime = false;
            this.txt_BrithDate.Size = new System.Drawing.Size(209, 29);
            this.txt_BrithDate.TabIndex = 7;
            this.txt_BrithDate.Text = "persianDateTimePicker1";
            this.txt_BrithDate.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_BrithDate.Value")));
            // 
            // btn_Save
            // 
            this.btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Save.Location = new System.Drawing.Point(538, 21);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 2, 20, 20);
            this.btn_Save.Size = new System.Drawing.Size(204, 46);
            this.btn_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Save.Symbol = "";
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "ثبت اطلاعات";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Exit.Location = new System.Drawing.Point(295, 21);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 2, 20, 20);
            this.btn_Exit.Size = new System.Drawing.Size(204, 46);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.Symbol = "";
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "خروج";
            // 
            // openFileDLG
            // 
            this.openFileDLG.FileName = "openFileDialog1";
            // 
            // frmUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 460);
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmUserManager";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_Main.ResumeLayout(false);
            this.pnl_UserInformation.ResumeLayout(false);
            this.pnl_UserInformation.PerformLayout();
            this.pnl_UserPic.ResumeLayout(false);
            this.pnl_UserSignature.ResumeLayout(false);
            this.pnl_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_UserSignature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UserPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.StyleManager styleManager;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_UserInformation;
        private DevComponents.DotNetBar.LabelX lbl_Name;
        private DevComponents.DotNetBar.LabelX lbl_LastName;
        private DevComponents.DotNetBar.LabelX lbl_UserName;
        private DevComponents.DotNetBar.LabelX lbl_Password;
        private DevComponents.DotNetBar.LabelX lbl_Email;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Email;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Password;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_UserName;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_LastName;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Name;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_PersonalCode;
        private DevComponents.DotNetBar.LabelX lbl_PersonalCode;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Tel;
        private DevComponents.DotNetBar.LabelX lbl_Tel;
        private DevComponents.DotNetBar.LabelX lbl_BrithDate;
        private DevComponents.DotNetBar.LabelX lbl_Gender;
        private System.Windows.Forms.RadioButton rbt_Woman;
        private System.Windows.Forms.RadioButton rbt_Man;
        private DevComponents.DotNetBar.LabelX lbl_RegisterDate;
        private DevComponents.DotNetBar.LabelX lbl_RegisterDateValue;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_UserSignature;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_UserPic;
        private System.Windows.Forms.PictureBox pic_UserSignature;
        private System.Windows.Forms.PictureBox pic_UserPic;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Buttons;
        private FreeControls.PersianDateTimePicker txt_BrithDate;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
        private DevComponents.DotNetBar.ButtonX btn_Save;
        private System.Windows.Forms.OpenFileDialog openFileDLG;
    }
}