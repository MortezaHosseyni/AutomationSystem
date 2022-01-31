namespace AutomationSystem.UserPanel
{
    partial class frmUserAddLetter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAddLetter));
            this.pnl_Main = new DevComponents.DotNetBar.PanelEx();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tcp_LetterInformation = new DevComponents.DotNetBar.TabControlPanel();
            this.txt_LetterCaption = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_LetterSubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_LetterAttachFile = new DevComponents.DotNetBar.ButtonX();
            this.txt_LetterDeadLineValue = new FreeControls.PersianDateTimePicker();
            this.pnl_LetterDeadLineType = new System.Windows.Forms.Panel();
            this.rdb_LetterDeadLine_Yes = new System.Windows.Forms.RadioButton();
            this.rdb_LetterDeadLine_No = new System.Windows.Forms.RadioButton();
            this.pnl_LetterAttachment = new System.Windows.Forms.Panel();
            this.rdb_LetterAttachment_Yes = new System.Windows.Forms.RadioButton();
            this.rdb_LetterAttachment_No = new System.Windows.Forms.RadioButton();
            this.pnl_LetterFollowing = new System.Windows.Forms.Panel();
            this.rdb_LetterFollowing_Yes = new System.Windows.Forms.RadioButton();
            this.rdb_LetterFollowing_No = new System.Windows.Forms.RadioButton();
            this.pnl_LetterForced = new System.Windows.Forms.Panel();
            this.rdb_LetterForced_Posthaste = new System.Windows.Forms.RadioButton();
            this.rdb_LetterForced_Immediate = new System.Windows.Forms.RadioButton();
            this.rdb_LetterForced_Normal = new System.Windows.Forms.RadioButton();
            this.pnl_LetterSecurity = new System.Windows.Forms.Panel();
            this.rdb_LetterSecurity_Secretive = new System.Windows.Forms.RadioButton();
            this.rdb_LetterSecurity_Confidential = new System.Windows.Forms.RadioButton();
            this.rdb_LetterSecurity_Normal = new System.Windows.Forms.RadioButton();
            this.lbl_LetterCaption = new DevComponents.DotNetBar.LabelX();
            this.lbl_InfoTwo = new DevComponents.DotNetBar.LabelX();
            this.lbl_InfoOne = new DevComponents.DotNetBar.LabelX();
            this.lbl_LetterAttachFile = new DevComponents.DotNetBar.LabelX();
            this.lbl_LetterDeadLineSetValue = new DevComponents.DotNetBar.LabelX();
            this.lbl_LetterDeadLineType = new DevComponents.DotNetBar.LabelX();
            this.lbl_LetterAttachment = new DevComponents.DotNetBar.LabelX();
            this.lbl_LetterFollowing = new DevComponents.DotNetBar.LabelX();
            this.lbl_LetterForced = new DevComponents.DotNetBar.LabelX();
            this.lbl_LetterSecurity = new DevComponents.DotNetBar.LabelX();
            this.val_LetterCreatedDate = new DevComponents.DotNetBar.LabelX();
            this.lbl_LetterCreatedDate = new DevComponents.DotNetBar.LabelX();
            this.lbl_LetterSubject = new DevComponents.DotNetBar.LabelX();
            this.tbi_LetterInformation = new DevComponents.DotNetBar.TabItem(this.components);
            this.tcp_LetterContext = new DevComponents.DotNetBar.TabControlPanel();
            this.tbi_LetterContext = new DevComponents.DotNetBar.TabItem(this.components);
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.superTooltip = new DevComponents.DotNetBar.SuperTooltip();
            this.adv_LetterContext = new TextRuler.AdvancedTextEditorControl.AdvancedTextEditor();
            this.btn_AddLetter = new DevComponents.DotNetBar.ButtonX();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tcp_LetterInformation.SuspendLayout();
            this.pnl_LetterDeadLineType.SuspendLayout();
            this.pnl_LetterAttachment.SuspendLayout();
            this.pnl_LetterFollowing.SuspendLayout();
            this.pnl_LetterForced.SuspendLayout();
            this.pnl_LetterSecurity.SuspendLayout();
            this.tcp_LetterContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.tabControl1);
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
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.Transparent;
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tcp_LetterContext);
            this.tabControl1.Controls.Add(this.tcp_LetterInformation);
            this.tabControl1.Location = new System.Drawing.Point(12, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1026, 537);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tbi_LetterInformation);
            this.tabControl1.Tabs.Add(this.tbi_LetterContext);
            // 
            // tcp_LetterInformation
            // 
            this.tcp_LetterInformation.Controls.Add(this.txt_LetterCaption);
            this.tcp_LetterInformation.Controls.Add(this.txt_LetterSubject);
            this.tcp_LetterInformation.Controls.Add(this.btn_LetterAttachFile);
            this.tcp_LetterInformation.Controls.Add(this.txt_LetterDeadLineValue);
            this.tcp_LetterInformation.Controls.Add(this.pnl_LetterDeadLineType);
            this.tcp_LetterInformation.Controls.Add(this.pnl_LetterAttachment);
            this.tcp_LetterInformation.Controls.Add(this.pnl_LetterFollowing);
            this.tcp_LetterInformation.Controls.Add(this.pnl_LetterForced);
            this.tcp_LetterInformation.Controls.Add(this.pnl_LetterSecurity);
            this.tcp_LetterInformation.Controls.Add(this.lbl_LetterCaption);
            this.tcp_LetterInformation.Controls.Add(this.lbl_InfoTwo);
            this.tcp_LetterInformation.Controls.Add(this.lbl_InfoOne);
            this.tcp_LetterInformation.Controls.Add(this.lbl_LetterAttachFile);
            this.tcp_LetterInformation.Controls.Add(this.lbl_LetterDeadLineSetValue);
            this.tcp_LetterInformation.Controls.Add(this.lbl_LetterDeadLineType);
            this.tcp_LetterInformation.Controls.Add(this.lbl_LetterAttachment);
            this.tcp_LetterInformation.Controls.Add(this.lbl_LetterFollowing);
            this.tcp_LetterInformation.Controls.Add(this.lbl_LetterForced);
            this.tcp_LetterInformation.Controls.Add(this.lbl_LetterSecurity);
            this.tcp_LetterInformation.Controls.Add(this.val_LetterCreatedDate);
            this.tcp_LetterInformation.Controls.Add(this.lbl_LetterCreatedDate);
            this.tcp_LetterInformation.Controls.Add(this.lbl_LetterSubject);
            this.tcp_LetterInformation.DisabledBackColor = System.Drawing.Color.Empty;
            this.tcp_LetterInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcp_LetterInformation.Location = new System.Drawing.Point(0, 41);
            this.tcp_LetterInformation.Name = "tcp_LetterInformation";
            this.tcp_LetterInformation.Padding = new System.Windows.Forms.Padding(1);
            this.tcp_LetterInformation.Size = new System.Drawing.Size(1026, 496);
            this.tcp_LetterInformation.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tcp_LetterInformation.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tcp_LetterInformation.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tcp_LetterInformation.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tcp_LetterInformation.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tcp_LetterInformation.Style.GradientAngle = 90;
            this.tcp_LetterInformation.TabIndex = 1;
            this.tcp_LetterInformation.TabItem = this.tbi_LetterInformation;
            // 
            // txt_LetterCaption
            // 
            // 
            // 
            // 
            this.txt_LetterCaption.Border.Class = "TextBoxBorder";
            this.txt_LetterCaption.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_LetterCaption.Location = new System.Drawing.Point(560, 98);
            this.txt_LetterCaption.Multiline = true;
            this.txt_LetterCaption.Name = "txt_LetterCaption";
            this.txt_LetterCaption.PreventEnterBeep = true;
            this.txt_LetterCaption.Size = new System.Drawing.Size(352, 217);
            this.superTooltip.SetSuperTooltip(this.txt_LetterCaption, new DevComponents.DotNetBar.SuperTooltipInfo("چكيده", "", "يك چكيده براي نامه بنويسيد و مي‌توانيد حداكثر از 200 كاراكتر استفاده كنيد.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.txt_LetterCaption.TabIndex = 2;
            this.txt_LetterCaption.WatermarkText = "چكيده...";
            // 
            // txt_LetterSubject
            // 
            // 
            // 
            // 
            this.txt_LetterSubject.Border.Class = "TextBoxBorder";
            this.txt_LetterSubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_LetterSubject.Location = new System.Drawing.Point(560, 56);
            this.txt_LetterSubject.Name = "txt_LetterSubject";
            this.txt_LetterSubject.PreventEnterBeep = true;
            this.txt_LetterSubject.Size = new System.Drawing.Size(352, 36);
            this.superTooltip.SetSuperTooltip(this.txt_LetterSubject, new DevComponents.DotNetBar.SuperTooltipInfo("موضوع نامه", "", "براي نامه يك موضوع انتخاب كنيد و حداكثر ميتوانيد از 100 كاراكتر استفاده كنيد.", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.txt_LetterSubject.TabIndex = 1;
            this.txt_LetterSubject.WatermarkText = "موضوع نامه...";
            // 
            // btn_LetterAttachFile
            // 
            this.btn_LetterAttachFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_LetterAttachFile.BackColor = System.Drawing.Color.Transparent;
            this.btn_LetterAttachFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_LetterAttachFile.Enabled = false;
            this.btn_LetterAttachFile.Location = new System.Drawing.Point(89, 383);
            this.btn_LetterAttachFile.Name = "btn_LetterAttachFile";
            this.btn_LetterAttachFile.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btn_LetterAttachFile.Size = new System.Drawing.Size(264, 49);
            this.btn_LetterAttachFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_LetterAttachFile.Symbol = "";
            this.btn_LetterAttachFile.TabIndex = 3;
            this.btn_LetterAttachFile.Text = "انتخاب فايل";
            // 
            // txt_LetterDeadLineValue
            // 
            this.txt_LetterDeadLineValue.BackColor = System.Drawing.Color.White;
            this.txt_LetterDeadLineValue.Enabled = false;
            this.txt_LetterDeadLineValue.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txt_LetterDeadLineValue.Location = new System.Drawing.Point(89, 348);
            this.txt_LetterDeadLineValue.Name = "txt_LetterDeadLineValue";
            this.txt_LetterDeadLineValue.ShowTime = false;
            this.txt_LetterDeadLineValue.Size = new System.Drawing.Size(264, 29);
            this.txt_LetterDeadLineValue.TabIndex = 2;
            this.txt_LetterDeadLineValue.Text = "persianDateTimePicker1";
            this.txt_LetterDeadLineValue.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_LetterDeadLineValue.Value")));
            // 
            // pnl_LetterDeadLineType
            // 
            this.pnl_LetterDeadLineType.BackColor = System.Drawing.Color.Transparent;
            this.pnl_LetterDeadLineType.Controls.Add(this.rdb_LetterDeadLine_Yes);
            this.pnl_LetterDeadLineType.Controls.Add(this.rdb_LetterDeadLine_No);
            this.pnl_LetterDeadLineType.Location = new System.Drawing.Point(89, 298);
            this.pnl_LetterDeadLineType.Name = "pnl_LetterDeadLineType";
            this.pnl_LetterDeadLineType.Size = new System.Drawing.Size(264, 44);
            this.pnl_LetterDeadLineType.TabIndex = 1;
            // 
            // rdb_LetterDeadLine_Yes
            // 
            this.rdb_LetterDeadLine_Yes.AutoSize = true;
            this.rdb_LetterDeadLine_Yes.Location = new System.Drawing.Point(113, 6);
            this.rdb_LetterDeadLine_Yes.Name = "rdb_LetterDeadLine_Yes";
            this.rdb_LetterDeadLine_Yes.Size = new System.Drawing.Size(53, 32);
            this.rdb_LetterDeadLine_Yes.TabIndex = 0;
            this.rdb_LetterDeadLine_Yes.Text = "دارد";
            this.rdb_LetterDeadLine_Yes.UseVisualStyleBackColor = true;
            // 
            // rdb_LetterDeadLine_No
            // 
            this.rdb_LetterDeadLine_No.AutoSize = true;
            this.rdb_LetterDeadLine_No.Checked = true;
            this.rdb_LetterDeadLine_No.Location = new System.Drawing.Point(188, 6);
            this.rdb_LetterDeadLine_No.Name = "rdb_LetterDeadLine_No";
            this.rdb_LetterDeadLine_No.Size = new System.Drawing.Size(58, 32);
            this.rdb_LetterDeadLine_No.TabIndex = 0;
            this.rdb_LetterDeadLine_No.TabStop = true;
            this.rdb_LetterDeadLine_No.Text = "ندارد";
            this.rdb_LetterDeadLine_No.UseVisualStyleBackColor = true;
            // 
            // pnl_LetterAttachment
            // 
            this.pnl_LetterAttachment.BackColor = System.Drawing.Color.Transparent;
            this.pnl_LetterAttachment.Controls.Add(this.rdb_LetterAttachment_Yes);
            this.pnl_LetterAttachment.Controls.Add(this.rdb_LetterAttachment_No);
            this.pnl_LetterAttachment.Location = new System.Drawing.Point(89, 248);
            this.pnl_LetterAttachment.Name = "pnl_LetterAttachment";
            this.pnl_LetterAttachment.Size = new System.Drawing.Size(264, 44);
            this.pnl_LetterAttachment.TabIndex = 1;
            // 
            // rdb_LetterAttachment_Yes
            // 
            this.rdb_LetterAttachment_Yes.AutoSize = true;
            this.rdb_LetterAttachment_Yes.Location = new System.Drawing.Point(113, 6);
            this.rdb_LetterAttachment_Yes.Name = "rdb_LetterAttachment_Yes";
            this.rdb_LetterAttachment_Yes.Size = new System.Drawing.Size(53, 32);
            this.rdb_LetterAttachment_Yes.TabIndex = 0;
            this.rdb_LetterAttachment_Yes.Text = "دارد";
            this.rdb_LetterAttachment_Yes.UseVisualStyleBackColor = true;
            // 
            // rdb_LetterAttachment_No
            // 
            this.rdb_LetterAttachment_No.AutoSize = true;
            this.rdb_LetterAttachment_No.Checked = true;
            this.rdb_LetterAttachment_No.Location = new System.Drawing.Point(188, 6);
            this.rdb_LetterAttachment_No.Name = "rdb_LetterAttachment_No";
            this.rdb_LetterAttachment_No.Size = new System.Drawing.Size(58, 32);
            this.rdb_LetterAttachment_No.TabIndex = 0;
            this.rdb_LetterAttachment_No.TabStop = true;
            this.rdb_LetterAttachment_No.Text = "ندارد";
            this.rdb_LetterAttachment_No.UseVisualStyleBackColor = true;
            // 
            // pnl_LetterFollowing
            // 
            this.pnl_LetterFollowing.BackColor = System.Drawing.Color.Transparent;
            this.pnl_LetterFollowing.Controls.Add(this.rdb_LetterFollowing_Yes);
            this.pnl_LetterFollowing.Controls.Add(this.rdb_LetterFollowing_No);
            this.pnl_LetterFollowing.Location = new System.Drawing.Point(89, 198);
            this.pnl_LetterFollowing.Name = "pnl_LetterFollowing";
            this.pnl_LetterFollowing.Size = new System.Drawing.Size(264, 44);
            this.pnl_LetterFollowing.TabIndex = 1;
            // 
            // rdb_LetterFollowing_Yes
            // 
            this.rdb_LetterFollowing_Yes.AutoSize = true;
            this.rdb_LetterFollowing_Yes.Location = new System.Drawing.Point(113, 6);
            this.rdb_LetterFollowing_Yes.Name = "rdb_LetterFollowing_Yes";
            this.rdb_LetterFollowing_Yes.Size = new System.Drawing.Size(53, 32);
            this.rdb_LetterFollowing_Yes.TabIndex = 0;
            this.rdb_LetterFollowing_Yes.Text = "دارد";
            this.rdb_LetterFollowing_Yes.UseVisualStyleBackColor = true;
            // 
            // rdb_LetterFollowing_No
            // 
            this.rdb_LetterFollowing_No.AutoSize = true;
            this.rdb_LetterFollowing_No.Checked = true;
            this.rdb_LetterFollowing_No.Location = new System.Drawing.Point(188, 6);
            this.rdb_LetterFollowing_No.Name = "rdb_LetterFollowing_No";
            this.rdb_LetterFollowing_No.Size = new System.Drawing.Size(58, 32);
            this.rdb_LetterFollowing_No.TabIndex = 0;
            this.rdb_LetterFollowing_No.TabStop = true;
            this.rdb_LetterFollowing_No.Text = "ندارد";
            this.rdb_LetterFollowing_No.UseVisualStyleBackColor = true;
            // 
            // pnl_LetterForced
            // 
            this.pnl_LetterForced.BackColor = System.Drawing.Color.Transparent;
            this.pnl_LetterForced.Controls.Add(this.rdb_LetterForced_Posthaste);
            this.pnl_LetterForced.Controls.Add(this.rdb_LetterForced_Immediate);
            this.pnl_LetterForced.Controls.Add(this.rdb_LetterForced_Normal);
            this.pnl_LetterForced.Location = new System.Drawing.Point(89, 148);
            this.pnl_LetterForced.Name = "pnl_LetterForced";
            this.pnl_LetterForced.Size = new System.Drawing.Size(264, 44);
            this.pnl_LetterForced.TabIndex = 1;
            // 
            // rdb_LetterForced_Posthaste
            // 
            this.rdb_LetterForced_Posthaste.AutoSize = true;
            this.rdb_LetterForced_Posthaste.Location = new System.Drawing.Point(21, 6);
            this.rdb_LetterForced_Posthaste.Name = "rdb_LetterForced_Posthaste";
            this.rdb_LetterForced_Posthaste.Size = new System.Drawing.Size(50, 32);
            this.rdb_LetterForced_Posthaste.TabIndex = 0;
            this.rdb_LetterForced_Posthaste.Text = "آني";
            this.rdb_LetterForced_Posthaste.UseVisualStyleBackColor = true;
            // 
            // rdb_LetterForced_Immediate
            // 
            this.rdb_LetterForced_Immediate.AutoSize = true;
            this.rdb_LetterForced_Immediate.Location = new System.Drawing.Point(106, 6);
            this.rdb_LetterForced_Immediate.Name = "rdb_LetterForced_Immediate";
            this.rdb_LetterForced_Immediate.Size = new System.Drawing.Size(60, 32);
            this.rdb_LetterForced_Immediate.TabIndex = 0;
            this.rdb_LetterForced_Immediate.Text = "فوري";
            this.rdb_LetterForced_Immediate.UseVisualStyleBackColor = true;
            // 
            // rdb_LetterForced_Normal
            // 
            this.rdb_LetterForced_Normal.AutoSize = true;
            this.rdb_LetterForced_Normal.Checked = true;
            this.rdb_LetterForced_Normal.Location = new System.Drawing.Point(186, 6);
            this.rdb_LetterForced_Normal.Name = "rdb_LetterForced_Normal";
            this.rdb_LetterForced_Normal.Size = new System.Drawing.Size(60, 32);
            this.rdb_LetterForced_Normal.TabIndex = 0;
            this.rdb_LetterForced_Normal.TabStop = true;
            this.rdb_LetterForced_Normal.Text = "عادي";
            this.rdb_LetterForced_Normal.UseVisualStyleBackColor = true;
            // 
            // pnl_LetterSecurity
            // 
            this.pnl_LetterSecurity.BackColor = System.Drawing.Color.Transparent;
            this.pnl_LetterSecurity.Controls.Add(this.rdb_LetterSecurity_Secretive);
            this.pnl_LetterSecurity.Controls.Add(this.rdb_LetterSecurity_Confidential);
            this.pnl_LetterSecurity.Controls.Add(this.rdb_LetterSecurity_Normal);
            this.pnl_LetterSecurity.Location = new System.Drawing.Point(89, 98);
            this.pnl_LetterSecurity.Name = "pnl_LetterSecurity";
            this.pnl_LetterSecurity.Size = new System.Drawing.Size(264, 44);
            this.pnl_LetterSecurity.TabIndex = 1;
            // 
            // rdb_LetterSecurity_Secretive
            // 
            this.rdb_LetterSecurity_Secretive.AutoSize = true;
            this.rdb_LetterSecurity_Secretive.Location = new System.Drawing.Point(12, 6);
            this.rdb_LetterSecurity_Secretive.Name = "rdb_LetterSecurity_Secretive";
            this.rdb_LetterSecurity_Secretive.Size = new System.Drawing.Size(59, 32);
            this.rdb_LetterSecurity_Secretive.TabIndex = 0;
            this.rdb_LetterSecurity_Secretive.Text = "سري";
            this.rdb_LetterSecurity_Secretive.UseVisualStyleBackColor = true;
            // 
            // rdb_LetterSecurity_Confidential
            // 
            this.rdb_LetterSecurity_Confidential.AutoSize = true;
            this.rdb_LetterSecurity_Confidential.Location = new System.Drawing.Point(92, 6);
            this.rdb_LetterSecurity_Confidential.Name = "rdb_LetterSecurity_Confidential";
            this.rdb_LetterSecurity_Confidential.Size = new System.Drawing.Size(74, 32);
            this.rdb_LetterSecurity_Confidential.TabIndex = 0;
            this.rdb_LetterSecurity_Confidential.Text = "محرمانه";
            this.rdb_LetterSecurity_Confidential.UseVisualStyleBackColor = true;
            // 
            // rdb_LetterSecurity_Normal
            // 
            this.rdb_LetterSecurity_Normal.AutoSize = true;
            this.rdb_LetterSecurity_Normal.Checked = true;
            this.rdb_LetterSecurity_Normal.Location = new System.Drawing.Point(186, 6);
            this.rdb_LetterSecurity_Normal.Name = "rdb_LetterSecurity_Normal";
            this.rdb_LetterSecurity_Normal.Size = new System.Drawing.Size(60, 32);
            this.rdb_LetterSecurity_Normal.TabIndex = 0;
            this.rdb_LetterSecurity_Normal.TabStop = true;
            this.rdb_LetterSecurity_Normal.Text = "عادي";
            this.rdb_LetterSecurity_Normal.UseVisualStyleBackColor = true;
            // 
            // lbl_LetterCaption
            // 
            this.lbl_LetterCaption.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_LetterCaption.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_LetterCaption.Location = new System.Drawing.Point(918, 176);
            this.lbl_LetterCaption.Name = "lbl_LetterCaption";
            this.lbl_LetterCaption.Size = new System.Drawing.Size(43, 32);
            this.lbl_LetterCaption.TabIndex = 0;
            this.lbl_LetterCaption.Text = "چكيده:";
            // 
            // lbl_InfoTwo
            // 
            this.lbl_InfoTwo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_InfoTwo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_InfoTwo.Location = new System.Drawing.Point(560, 410);
            this.lbl_InfoTwo.Name = "lbl_InfoTwo";
            this.lbl_InfoTwo.Size = new System.Drawing.Size(352, 56);
            this.lbl_InfoTwo.Symbol = "";
            this.lbl_InfoTwo.TabIndex = 0;
            this.lbl_InfoTwo.Text = "توجه: براي الصاق فايل ابتدا وضعيت پيوست نامه را مشخص كنيد.";
            this.lbl_InfoTwo.WordWrap = true;
            // 
            // lbl_InfoOne
            // 
            this.lbl_InfoOne.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_InfoOne.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_InfoOne.Location = new System.Drawing.Point(560, 348);
            this.lbl_InfoOne.Name = "lbl_InfoOne";
            this.lbl_InfoOne.Size = new System.Drawing.Size(352, 56);
            this.lbl_InfoOne.Symbol = "";
            this.lbl_InfoOne.TabIndex = 0;
            this.lbl_InfoOne.Text = "توجه: براي تايين مهلت پاسخ ابتدا وضعيت آن را مشخص كنيد.";
            this.lbl_InfoOne.WordWrap = true;
            // 
            // lbl_LetterAttachFile
            // 
            this.lbl_LetterAttachFile.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_LetterAttachFile.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_LetterAttachFile.Location = new System.Drawing.Point(379, 394);
            this.lbl_LetterAttachFile.Name = "lbl_LetterAttachFile";
            this.lbl_LetterAttachFile.Size = new System.Drawing.Size(67, 32);
            this.lbl_LetterAttachFile.TabIndex = 0;
            this.lbl_LetterAttachFile.Text = "الصاق فايل:";
            // 
            // lbl_LetterDeadLineSetValue
            // 
            this.lbl_LetterDeadLineSetValue.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_LetterDeadLineSetValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_LetterDeadLineSetValue.Location = new System.Drawing.Point(377, 347);
            this.lbl_LetterDeadLineSetValue.Name = "lbl_LetterDeadLineSetValue";
            this.lbl_LetterDeadLineSetValue.Size = new System.Drawing.Size(105, 32);
            this.lbl_LetterDeadLineSetValue.TabIndex = 0;
            this.lbl_LetterDeadLineSetValue.Text = "تايين مهلت پاسخ:";
            // 
            // lbl_LetterDeadLineType
            // 
            this.lbl_LetterDeadLineType.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_LetterDeadLineType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_LetterDeadLineType.Location = new System.Drawing.Point(378, 305);
            this.lbl_LetterDeadLineType.Name = "lbl_LetterDeadLineType";
            this.lbl_LetterDeadLineType.Size = new System.Drawing.Size(69, 32);
            this.lbl_LetterDeadLineType.TabIndex = 0;
            this.lbl_LetterDeadLineType.Text = "مهلت پاسخ:";
            // 
            // lbl_LetterAttachment
            // 
            this.lbl_LetterAttachment.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_LetterAttachment.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_LetterAttachment.Location = new System.Drawing.Point(378, 255);
            this.lbl_LetterAttachment.Name = "lbl_LetterAttachment";
            this.lbl_LetterAttachment.Size = new System.Drawing.Size(46, 32);
            this.lbl_LetterAttachment.TabIndex = 0;
            this.lbl_LetterAttachment.Text = "پيوست:";
            // 
            // lbl_LetterFollowing
            // 
            this.lbl_LetterFollowing.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_LetterFollowing.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_LetterFollowing.Location = new System.Drawing.Point(378, 206);
            this.lbl_LetterFollowing.Name = "lbl_LetterFollowing";
            this.lbl_LetterFollowing.Size = new System.Drawing.Size(48, 32);
            this.lbl_LetterFollowing.TabIndex = 0;
            this.lbl_LetterFollowing.Text = "پيگيري:";
            // 
            // lbl_LetterForced
            // 
            this.lbl_LetterForced.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_LetterForced.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_LetterForced.Location = new System.Drawing.Point(378, 156);
            this.lbl_LetterForced.Name = "lbl_LetterForced";
            this.lbl_LetterForced.Size = new System.Drawing.Size(54, 32);
            this.lbl_LetterForced.TabIndex = 0;
            this.lbl_LetterForced.Text = "نوع اقدام:";
            // 
            // lbl_LetterSecurity
            // 
            this.lbl_LetterSecurity.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_LetterSecurity.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_LetterSecurity.Location = new System.Drawing.Point(378, 107);
            this.lbl_LetterSecurity.Name = "lbl_LetterSecurity";
            this.lbl_LetterSecurity.Size = new System.Drawing.Size(50, 32);
            this.lbl_LetterSecurity.TabIndex = 0;
            this.lbl_LetterSecurity.Text = "نوع نامه:";
            // 
            // val_LetterCreatedDate
            // 
            this.val_LetterCreatedDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.val_LetterCreatedDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_LetterCreatedDate.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.val_LetterCreatedDate.Location = new System.Drawing.Point(89, 60);
            this.val_LetterCreatedDate.Name = "val_LetterCreatedDate";
            this.val_LetterCreatedDate.Size = new System.Drawing.Size(264, 32);
            this.val_LetterCreatedDate.TabIndex = 0;
            this.val_LetterCreatedDate.Text = "...";
            // 
            // lbl_LetterCreatedDate
            // 
            this.lbl_LetterCreatedDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_LetterCreatedDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_LetterCreatedDate.Location = new System.Drawing.Point(374, 60);
            this.lbl_LetterCreatedDate.Name = "lbl_LetterCreatedDate";
            this.lbl_LetterCreatedDate.Size = new System.Drawing.Size(94, 32);
            this.lbl_LetterCreatedDate.TabIndex = 0;
            this.lbl_LetterCreatedDate.Text = "تاريخ ايجاد نامه:";
            // 
            // lbl_LetterSubject
            // 
            this.lbl_LetterSubject.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_LetterSubject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_LetterSubject.Location = new System.Drawing.Point(918, 60);
            this.lbl_LetterSubject.Name = "lbl_LetterSubject";
            this.lbl_LetterSubject.Size = new System.Drawing.Size(69, 32);
            this.lbl_LetterSubject.TabIndex = 0;
            this.lbl_LetterSubject.Text = "موضوع نامه:";
            // 
            // tbi_LetterInformation
            // 
            this.tbi_LetterInformation.AttachedControl = this.tcp_LetterInformation;
            this.tbi_LetterInformation.Name = "tbi_LetterInformation";
            this.tbi_LetterInformation.Text = "مشخصات نامه";
            // 
            // tcp_LetterContext
            // 
            this.tcp_LetterContext.Controls.Add(this.btn_AddLetter);
            this.tcp_LetterContext.Controls.Add(this.adv_LetterContext);
            this.tcp_LetterContext.DisabledBackColor = System.Drawing.Color.Empty;
            this.tcp_LetterContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcp_LetterContext.Location = new System.Drawing.Point(0, 41);
            this.tcp_LetterContext.Name = "tcp_LetterContext";
            this.tcp_LetterContext.Padding = new System.Windows.Forms.Padding(1);
            this.tcp_LetterContext.Size = new System.Drawing.Size(1026, 496);
            this.tcp_LetterContext.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tcp_LetterContext.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tcp_LetterContext.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tcp_LetterContext.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tcp_LetterContext.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tcp_LetterContext.Style.GradientAngle = 90;
            this.tcp_LetterContext.TabIndex = 5;
            this.tcp_LetterContext.TabItem = this.tbi_LetterContext;
            // 
            // tbi_LetterContext
            // 
            this.tbi_LetterContext.AttachedControl = this.tcp_LetterContext;
            this.tbi_LetterContext.Name = "tbi_LetterContext";
            this.tbi_LetterContext.Text = "متن نامه";
            // 
            // lbl_Title
            // 
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("B Nazanin", 22.25F);
            this.lbl_Title.Location = new System.Drawing.Point(452, 12);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(125, 43);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "ايجاد نامه";
            // 
            // superTooltip
            // 
            this.superTooltip.DefaultTooltipSettings = new DevComponents.DotNetBar.SuperTooltipInfo("", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray);
            // 
            // adv_LetterContext
            // 
            this.adv_LetterContext.Location = new System.Drawing.Point(3, 0);
            this.adv_LetterContext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.adv_LetterContext.Name = "adv_LetterContext";
            this.adv_LetterContext.Size = new System.Drawing.Size(1020, 433);
            this.adv_LetterContext.TabIndex = 0;
            // 
            // btn_AddLetter
            // 
            this.btn_AddLetter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_AddLetter.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddLetter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_AddLetter.Location = new System.Drawing.Point(20, 442);
            this.btn_AddLetter.Name = "btn_AddLetter";
            this.btn_AddLetter.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20, 2, 2, 20);
            this.btn_AddLetter.Size = new System.Drawing.Size(194, 40);
            this.btn_AddLetter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_AddLetter.Symbol = "";
            this.btn_AddLetter.TabIndex = 1;
            this.btn_AddLetter.Text = "ثبت نامه";
            // 
            // frmUserAddLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmUserAddLetter";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmUserAddLetter_Load);
            this.pnl_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tcp_LetterInformation.ResumeLayout(false);
            this.pnl_LetterDeadLineType.ResumeLayout(false);
            this.pnl_LetterDeadLineType.PerformLayout();
            this.pnl_LetterAttachment.ResumeLayout(false);
            this.pnl_LetterAttachment.PerformLayout();
            this.pnl_LetterFollowing.ResumeLayout(false);
            this.pnl_LetterFollowing.PerformLayout();
            this.pnl_LetterForced.ResumeLayout(false);
            this.pnl_LetterForced.PerformLayout();
            this.pnl_LetterSecurity.ResumeLayout(false);
            this.pnl_LetterSecurity.PerformLayout();
            this.tcp_LetterContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tcp_LetterInformation;
        private DevComponents.DotNetBar.TabItem tbi_LetterInformation;
        private DevComponents.DotNetBar.TabControlPanel tcp_LetterContext;
        private DevComponents.DotNetBar.TabItem tbi_LetterContext;
        private DevComponents.DotNetBar.LabelX lbl_LetterSubject;
        private DevComponents.DotNetBar.LabelX lbl_LetterCaption;
        private DevComponents.DotNetBar.LabelX lbl_LetterFollowing;
        private DevComponents.DotNetBar.LabelX lbl_LetterForced;
        private DevComponents.DotNetBar.LabelX lbl_LetterSecurity;
        private DevComponents.DotNetBar.LabelX lbl_LetterCreatedDate;
        private DevComponents.DotNetBar.LabelX lbl_LetterAttachment;
        private DevComponents.DotNetBar.LabelX lbl_LetterDeadLineType;
        private DevComponents.DotNetBar.LabelX lbl_LetterDeadLineSetValue;
        private DevComponents.DotNetBar.LabelX lbl_LetterAttachFile;
        private DevComponents.DotNetBar.LabelX val_LetterCreatedDate;
        private System.Windows.Forms.Panel pnl_LetterDeadLineType;
        private System.Windows.Forms.Panel pnl_LetterAttachment;
        private System.Windows.Forms.Panel pnl_LetterFollowing;
        private System.Windows.Forms.Panel pnl_LetterForced;
        private System.Windows.Forms.Panel pnl_LetterSecurity;
        private System.Windows.Forms.RadioButton rdb_LetterSecurity_Confidential;
        private System.Windows.Forms.RadioButton rdb_LetterSecurity_Normal;
        private System.Windows.Forms.RadioButton rdb_LetterSecurity_Secretive;
        private System.Windows.Forms.RadioButton rdb_LetterForced_Posthaste;
        private System.Windows.Forms.RadioButton rdb_LetterForced_Immediate;
        private System.Windows.Forms.RadioButton rdb_LetterForced_Normal;
        private System.Windows.Forms.RadioButton rdb_LetterDeadLine_Yes;
        private System.Windows.Forms.RadioButton rdb_LetterDeadLine_No;
        private System.Windows.Forms.RadioButton rdb_LetterAttachment_Yes;
        private System.Windows.Forms.RadioButton rdb_LetterAttachment_No;
        private System.Windows.Forms.RadioButton rdb_LetterFollowing_Yes;
        private System.Windows.Forms.RadioButton rdb_LetterFollowing_No;
        private FreeControls.PersianDateTimePicker txt_LetterDeadLineValue;
        private DevComponents.DotNetBar.ButtonX btn_LetterAttachFile;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_LetterSubject;
        private DevComponents.DotNetBar.SuperTooltip superTooltip;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_LetterCaption;
        private DevComponents.DotNetBar.LabelX lbl_InfoOne;
        private DevComponents.DotNetBar.LabelX lbl_InfoTwo;
        private TextRuler.AdvancedTextEditorControl.AdvancedTextEditor adv_LetterContext;
        private DevComponents.DotNetBar.ButtonX btn_AddLetter;
    }
}