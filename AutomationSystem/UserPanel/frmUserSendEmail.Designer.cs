namespace AutomationSystem.UserPanel
{
    partial class frmUserSendEmail
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
            this.pnl_Main = new DevComponents.DotNetBar.PanelEx();
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.btn_SendEMail = new DevComponents.DotNetBar.ButtonX();
            this.pnl_Setting = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.chb_SSL = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txt_SMTP = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_SMTP = new DevComponents.DotNetBar.LabelX();
            this.txt_Port = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_Port = new DevComponents.DotNetBar.LabelX();
            this.txt_SenderPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_SenderPassword = new DevComponents.DotNetBar.LabelX();
            this.txt_SenderEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_SenderEmail = new DevComponents.DotNetBar.LabelX();
            this.pnl_EmailReciver = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txt_EmailContext = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_EmailSubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Transcript = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_ReciverEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_Context = new DevComponents.DotNetBar.LabelX();
            this.lbl_Subject = new DevComponents.DotNetBar.LabelX();
            this.lbl_Transcript = new DevComponents.DotNetBar.LabelX();
            this.lbl_Reciver = new DevComponents.DotNetBar.LabelX();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.pnl_Main.SuspendLayout();
            this.pnl_Setting.SuspendLayout();
            this.pnl_EmailReciver.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.btn_Exit);
            this.pnl_Main.Controls.Add(this.btn_SendEMail);
            this.pnl_Main.Controls.Add(this.pnl_Setting);
            this.pnl_Main.Controls.Add(this.pnl_EmailReciver);
            this.pnl_Main.Controls.Add(this.lbl_Title);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(520, 600);
            this.pnl_Main.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl_Main.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Main.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Main.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl_Main.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Main.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Main.Style.GradientAngle = 90;
            this.pnl_Main.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Exit.Location = new System.Drawing.Point(471, 12);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(37, 30);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.Symbol = "";
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_SendEMail
            // 
            this.btn_SendEMail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SendEMail.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_SendEMail.Location = new System.Drawing.Point(88, 550);
            this.btn_SendEMail.Name = "btn_SendEMail";
            this.btn_SendEMail.Size = new System.Drawing.Size(328, 38);
            this.btn_SendEMail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_SendEMail.Symbol = "57941";
            this.btn_SendEMail.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn_SendEMail.TabIndex = 3;
            this.btn_SendEMail.Text = "ارسال ايميل";
            this.btn_SendEMail.Click += new System.EventHandler(this.btn_SendEMail_Click);
            // 
            // pnl_Setting
            // 
            this.pnl_Setting.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Setting.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Setting.Controls.Add(this.chb_SSL);
            this.pnl_Setting.Controls.Add(this.txt_SMTP);
            this.pnl_Setting.Controls.Add(this.lbl_SMTP);
            this.pnl_Setting.Controls.Add(this.txt_Port);
            this.pnl_Setting.Controls.Add(this.lbl_Port);
            this.pnl_Setting.Controls.Add(this.txt_SenderPassword);
            this.pnl_Setting.Controls.Add(this.lbl_SenderPassword);
            this.pnl_Setting.Controls.Add(this.txt_SenderEmail);
            this.pnl_Setting.Controls.Add(this.lbl_SenderEmail);
            this.pnl_Setting.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Setting.Location = new System.Drawing.Point(12, 347);
            this.pnl_Setting.Name = "pnl_Setting";
            this.pnl_Setting.Size = new System.Drawing.Size(496, 196);
            // 
            // 
            // 
            this.pnl_Setting.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Setting.Style.BackColorGradientAngle = 90;
            this.pnl_Setting.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Setting.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Setting.Style.BorderBottomWidth = 1;
            this.pnl_Setting.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Setting.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Setting.Style.BorderLeftWidth = 1;
            this.pnl_Setting.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Setting.Style.BorderRightWidth = 1;
            this.pnl_Setting.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Setting.Style.BorderTopWidth = 1;
            this.pnl_Setting.Style.CornerDiameter = 4;
            this.pnl_Setting.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_Setting.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_Setting.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Setting.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_Setting.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_Setting.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_Setting.TabIndex = 2;
            this.pnl_Setting.Text = "تنظيمات";
            // 
            // chb_SSL
            // 
            this.chb_SSL.AutoSize = true;
            // 
            // 
            // 
            this.chb_SSL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chb_SSL.Location = new System.Drawing.Point(313, 129);
            this.chb_SSL.Name = "chb_SSL";
            this.chb_SSL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chb_SSL.Size = new System.Drawing.Size(62, 31);
            this.chb_SSL.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chb_SSL.TabIndex = 9;
            this.chb_SSL.Text = "SSL";
            // 
            // txt_SMTP
            // 
            // 
            // 
            // 
            this.txt_SMTP.Border.Class = "TextBoxBorder";
            this.txt_SMTP.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SMTP.Location = new System.Drawing.Point(117, 87);
            this.txt_SMTP.Name = "txt_SMTP";
            this.txt_SMTP.PreventEnterBeep = true;
            this.txt_SMTP.Size = new System.Drawing.Size(192, 36);
            this.txt_SMTP.TabIndex = 8;
            this.txt_SMTP.Text = "smtp.gmail.com";
            this.txt_SMTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_SMTP.WatermarkText = "شماره پورت...";
            // 
            // lbl_SMTP
            // 
            this.lbl_SMTP.AutoSize = true;
            // 
            // 
            // 
            this.lbl_SMTP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SMTP.Location = new System.Drawing.Point(47, 90);
            this.lbl_SMTP.Name = "lbl_SMTP";
            this.lbl_SMTP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_SMTP.Size = new System.Drawing.Size(64, 33);
            this.lbl_SMTP.TabIndex = 0;
            this.lbl_SMTP.Text = "SMTP:";
            // 
            // txt_Port
            // 
            // 
            // 
            // 
            this.txt_Port.Border.Class = "TextBoxBorder";
            this.txt_Port.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Port.Location = new System.Drawing.Point(315, 87);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.PreventEnterBeep = true;
            this.txt_Port.Size = new System.Drawing.Size(60, 36);
            this.txt_Port.TabIndex = 7;
            this.txt_Port.Text = "587";
            this.txt_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Port.WatermarkText = "شماره پورت...";
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            // 
            // 
            // 
            this.lbl_Port.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Port.Location = new System.Drawing.Point(381, 90);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(75, 33);
            this.lbl_Port.TabIndex = 0;
            this.lbl_Port.Text = "شماره پورت:";
            // 
            // txt_SenderPassword
            // 
            // 
            // 
            // 
            this.txt_SenderPassword.Border.Class = "TextBoxBorder";
            this.txt_SenderPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SenderPassword.Location = new System.Drawing.Point(47, 45);
            this.txt_SenderPassword.Name = "txt_SenderPassword";
            this.txt_SenderPassword.PasswordChar = '*';
            this.txt_SenderPassword.PreventEnterBeep = true;
            this.txt_SenderPassword.Size = new System.Drawing.Size(328, 36);
            this.txt_SenderPassword.TabIndex = 6;
            this.txt_SenderPassword.WatermarkText = "گذرواژه ايميل...";
            // 
            // lbl_SenderPassword
            // 
            this.lbl_SenderPassword.AutoSize = true;
            // 
            // 
            // 
            this.lbl_SenderPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SenderPassword.Location = new System.Drawing.Point(381, 48);
            this.lbl_SenderPassword.Name = "lbl_SenderPassword";
            this.lbl_SenderPassword.Size = new System.Drawing.Size(49, 33);
            this.lbl_SenderPassword.TabIndex = 0;
            this.lbl_SenderPassword.Text = "گذرواژه:";
            // 
            // txt_SenderEmail
            // 
            // 
            // 
            // 
            this.txt_SenderEmail.Border.Class = "TextBoxBorder";
            this.txt_SenderEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SenderEmail.Location = new System.Drawing.Point(47, 3);
            this.txt_SenderEmail.Name = "txt_SenderEmail";
            this.txt_SenderEmail.PreventEnterBeep = true;
            this.txt_SenderEmail.Size = new System.Drawing.Size(328, 36);
            this.txt_SenderEmail.TabIndex = 5;
            this.txt_SenderEmail.WatermarkText = "ايميل فرستنده...";
            // 
            // lbl_SenderEmail
            // 
            this.lbl_SenderEmail.AutoSize = true;
            // 
            // 
            // 
            this.lbl_SenderEmail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SenderEmail.Location = new System.Drawing.Point(381, 6);
            this.lbl_SenderEmail.Name = "lbl_SenderEmail";
            this.lbl_SenderEmail.Size = new System.Drawing.Size(66, 33);
            this.lbl_SenderEmail.TabIndex = 0;
            this.lbl_SenderEmail.Text = "ايميل شما:";
            // 
            // pnl_EmailReciver
            // 
            this.pnl_EmailReciver.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_EmailReciver.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_EmailReciver.Controls.Add(this.txt_EmailContext);
            this.pnl_EmailReciver.Controls.Add(this.txt_EmailSubject);
            this.pnl_EmailReciver.Controls.Add(this.txt_Transcript);
            this.pnl_EmailReciver.Controls.Add(this.txt_ReciverEmail);
            this.pnl_EmailReciver.Controls.Add(this.lbl_Context);
            this.pnl_EmailReciver.Controls.Add(this.lbl_Subject);
            this.pnl_EmailReciver.Controls.Add(this.lbl_Transcript);
            this.pnl_EmailReciver.Controls.Add(this.lbl_Reciver);
            this.pnl_EmailReciver.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_EmailReciver.Location = new System.Drawing.Point(12, 57);
            this.pnl_EmailReciver.Name = "pnl_EmailReciver";
            this.pnl_EmailReciver.Size = new System.Drawing.Size(496, 284);
            // 
            // 
            // 
            this.pnl_EmailReciver.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_EmailReciver.Style.BackColorGradientAngle = 90;
            this.pnl_EmailReciver.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_EmailReciver.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_EmailReciver.Style.BorderBottomWidth = 1;
            this.pnl_EmailReciver.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_EmailReciver.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_EmailReciver.Style.BorderLeftWidth = 1;
            this.pnl_EmailReciver.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_EmailReciver.Style.BorderRightWidth = 1;
            this.pnl_EmailReciver.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_EmailReciver.Style.BorderTopWidth = 1;
            this.pnl_EmailReciver.Style.CornerDiameter = 4;
            this.pnl_EmailReciver.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_EmailReciver.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_EmailReciver.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_EmailReciver.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_EmailReciver.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_EmailReciver.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_EmailReciver.TabIndex = 1;
            this.pnl_EmailReciver.Text = "گيرنده ايميل";
            // 
            // txt_EmailContext
            // 
            // 
            // 
            // 
            this.txt_EmailContext.Border.Class = "TextBoxBorder";
            this.txt_EmailContext.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_EmailContext.Location = new System.Drawing.Point(47, 129);
            this.txt_EmailContext.Multiline = true;
            this.txt_EmailContext.Name = "txt_EmailContext";
            this.txt_EmailContext.PreventEnterBeep = true;
            this.txt_EmailContext.Size = new System.Drawing.Size(328, 110);
            this.txt_EmailContext.TabIndex = 4;
            this.txt_EmailContext.WatermarkText = "متن ايميل...";
            // 
            // txt_EmailSubject
            // 
            // 
            // 
            // 
            this.txt_EmailSubject.Border.Class = "TextBoxBorder";
            this.txt_EmailSubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_EmailSubject.Location = new System.Drawing.Point(47, 87);
            this.txt_EmailSubject.Name = "txt_EmailSubject";
            this.txt_EmailSubject.PreventEnterBeep = true;
            this.txt_EmailSubject.Size = new System.Drawing.Size(328, 36);
            this.txt_EmailSubject.TabIndex = 3;
            this.txt_EmailSubject.WatermarkText = "موضوع ايميل...";
            // 
            // txt_Transcript
            // 
            // 
            // 
            // 
            this.txt_Transcript.Border.Class = "TextBoxBorder";
            this.txt_Transcript.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Transcript.Location = new System.Drawing.Point(47, 45);
            this.txt_Transcript.Name = "txt_Transcript";
            this.txt_Transcript.PreventEnterBeep = true;
            this.txt_Transcript.Size = new System.Drawing.Size(328, 36);
            this.txt_Transcript.TabIndex = 2;
            this.txt_Transcript.WatermarkText = "آدرس ايميل براي رونوشت...";
            // 
            // txt_ReciverEmail
            // 
            // 
            // 
            // 
            this.txt_ReciverEmail.Border.Class = "TextBoxBorder";
            this.txt_ReciverEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_ReciverEmail.Location = new System.Drawing.Point(47, 3);
            this.txt_ReciverEmail.Name = "txt_ReciverEmail";
            this.txt_ReciverEmail.PreventEnterBeep = true;
            this.txt_ReciverEmail.Size = new System.Drawing.Size(328, 36);
            this.txt_ReciverEmail.TabIndex = 1;
            this.txt_ReciverEmail.WatermarkText = "ايميل گيرنده...";
            // 
            // lbl_Context
            // 
            this.lbl_Context.AutoSize = true;
            // 
            // 
            // 
            this.lbl_Context.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Context.Location = new System.Drawing.Point(381, 132);
            this.lbl_Context.Name = "lbl_Context";
            this.lbl_Context.Size = new System.Drawing.Size(29, 33);
            this.lbl_Context.TabIndex = 0;
            this.lbl_Context.Text = "متن:";
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            // 
            // 
            // 
            this.lbl_Subject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Subject.Location = new System.Drawing.Point(381, 90);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(45, 33);
            this.lbl_Subject.TabIndex = 0;
            this.lbl_Subject.Text = "موضوع:";
            // 
            // lbl_Transcript
            // 
            this.lbl_Transcript.AutoSize = true;
            // 
            // 
            // 
            this.lbl_Transcript.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Transcript.Location = new System.Drawing.Point(381, 48);
            this.lbl_Transcript.Name = "lbl_Transcript";
            this.lbl_Transcript.Size = new System.Drawing.Size(52, 33);
            this.lbl_Transcript.TabIndex = 0;
            this.lbl_Transcript.Text = "رونوشت:";
            // 
            // lbl_Reciver
            // 
            this.lbl_Reciver.AutoSize = true;
            // 
            // 
            // 
            this.lbl_Reciver.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Reciver.Location = new System.Drawing.Point(381, 6);
            this.lbl_Reciver.Name = "lbl_Reciver";
            this.lbl_Reciver.Size = new System.Drawing.Size(44, 33);
            this.lbl_Reciver.TabIndex = 0;
            this.lbl_Reciver.Text = "گيرنده:";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("B Nazanin", 22.25F);
            this.lbl_Title.Location = new System.Drawing.Point(190, 3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(141, 48);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "ارسال ايميل";
            // 
            // frmUserSendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmUserSendEmail";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUserSendEmail_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.pnl_Setting.ResumeLayout(false);
            this.pnl_Setting.PerformLayout();
            this.pnl_EmailReciver.ResumeLayout(false);
            this.pnl_EmailReciver.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_EmailReciver;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_EmailContext;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_EmailSubject;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Transcript;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_ReciverEmail;
        private DevComponents.DotNetBar.LabelX lbl_Context;
        private DevComponents.DotNetBar.LabelX lbl_Subject;
        private DevComponents.DotNetBar.LabelX lbl_Transcript;
        private DevComponents.DotNetBar.LabelX lbl_Reciver;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Setting;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SenderPassword;
        private DevComponents.DotNetBar.LabelX lbl_SenderPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SenderEmail;
        private DevComponents.DotNetBar.LabelX lbl_SenderEmail;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Port;
        private DevComponents.DotNetBar.LabelX lbl_Port;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SMTP;
        private DevComponents.DotNetBar.LabelX lbl_SMTP;
        private DevComponents.DotNetBar.Controls.CheckBoxX chb_SSL;
        private DevComponents.DotNetBar.ButtonX btn_SendEMail;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
    }
}