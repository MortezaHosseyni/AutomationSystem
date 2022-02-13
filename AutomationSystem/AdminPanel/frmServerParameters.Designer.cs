namespace AutomationSystem.AdminPanel
{
    partial class frmServerParameters
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
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.pnl_SetServerParameters = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.ServerIP = new DevComponents.DotNetBar.LabelX();
            this.lbl_DatabaseName = new DevComponents.DotNetBar.LabelX();
            this.lbl_DatabasePassword = new DevComponents.DotNetBar.LabelX();
            this.txt_ServerIP = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_DatabaseName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_DatabasePassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_Save = new DevComponents.DotNetBar.ButtonX();
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.pnl_Main.SuspendLayout();
            this.pnl_SetServerParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.btn_Exit);
            this.pnl_Main.Controls.Add(this.btn_Save);
            this.pnl_Main.Controls.Add(this.pnl_SetServerParameters);
            this.pnl_Main.Controls.Add(this.lbl_Title);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(486, 318);
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
            this.lbl_Title.Location = new System.Drawing.Point(109, 3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(260, 48);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "پارامترهاي ارتباط با سرور";
            // 
            // pnl_SetServerParameters
            // 
            this.pnl_SetServerParameters.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_SetServerParameters.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_SetServerParameters.Controls.Add(this.txt_DatabasePassword);
            this.pnl_SetServerParameters.Controls.Add(this.txt_DatabaseName);
            this.pnl_SetServerParameters.Controls.Add(this.txt_ServerIP);
            this.pnl_SetServerParameters.Controls.Add(this.lbl_DatabasePassword);
            this.pnl_SetServerParameters.Controls.Add(this.lbl_DatabaseName);
            this.pnl_SetServerParameters.Controls.Add(this.ServerIP);
            this.pnl_SetServerParameters.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_SetServerParameters.Location = new System.Drawing.Point(12, 57);
            this.pnl_SetServerParameters.Name = "pnl_SetServerParameters";
            this.pnl_SetServerParameters.Size = new System.Drawing.Size(462, 205);
            // 
            // 
            // 
            this.pnl_SetServerParameters.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_SetServerParameters.Style.BackColorGradientAngle = 90;
            this.pnl_SetServerParameters.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_SetServerParameters.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SetServerParameters.Style.BorderBottomWidth = 1;
            this.pnl_SetServerParameters.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_SetServerParameters.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SetServerParameters.Style.BorderLeftWidth = 1;
            this.pnl_SetServerParameters.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SetServerParameters.Style.BorderRightWidth = 1;
            this.pnl_SetServerParameters.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SetServerParameters.Style.BorderTopWidth = 1;
            this.pnl_SetServerParameters.Style.CornerDiameter = 4;
            this.pnl_SetServerParameters.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_SetServerParameters.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_SetServerParameters.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_SetServerParameters.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_SetServerParameters.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_SetServerParameters.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_SetServerParameters.TabIndex = 1;
            // 
            // ServerIP
            // 
            this.ServerIP.AutoSize = true;
            // 
            // 
            // 
            this.ServerIP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ServerIP.Location = new System.Drawing.Point(334, 35);
            this.ServerIP.Name = "ServerIP";
            this.ServerIP.Size = new System.Drawing.Size(72, 33);
            this.ServerIP.TabIndex = 0;
            this.ServerIP.Text = "آي‌پي سرور:";
            // 
            // lbl_DatabaseName
            // 
            this.lbl_DatabaseName.AutoSize = true;
            // 
            // 
            // 
            this.lbl_DatabaseName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_DatabaseName.Location = new System.Drawing.Point(334, 77);
            this.lbl_DatabaseName.Name = "lbl_DatabaseName";
            this.lbl_DatabaseName.Size = new System.Drawing.Size(85, 33);
            this.lbl_DatabaseName.TabIndex = 0;
            this.lbl_DatabaseName.Text = "نام پايگاه داده:";
            // 
            // lbl_DatabasePassword
            // 
            this.lbl_DatabasePassword.AutoSize = true;
            // 
            // 
            // 
            this.lbl_DatabasePassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_DatabasePassword.Location = new System.Drawing.Point(334, 119);
            this.lbl_DatabasePassword.Name = "lbl_DatabasePassword";
            this.lbl_DatabasePassword.Size = new System.Drawing.Size(112, 33);
            this.lbl_DatabasePassword.TabIndex = 0;
            this.lbl_DatabasePassword.Text = "گذرواژه پايگاه داده:";
            // 
            // txt_ServerIP
            // 
            // 
            // 
            // 
            this.txt_ServerIP.Border.Class = "TextBoxBorder";
            this.txt_ServerIP.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_ServerIP.Location = new System.Drawing.Point(20, 32);
            this.txt_ServerIP.Name = "txt_ServerIP";
            this.txt_ServerIP.PreventEnterBeep = true;
            this.txt_ServerIP.Size = new System.Drawing.Size(308, 36);
            this.txt_ServerIP.TabIndex = 1;
            this.txt_ServerIP.WatermarkText = "آي‌پي سرور...";
            // 
            // txt_DatabaseName
            // 
            // 
            // 
            // 
            this.txt_DatabaseName.Border.Class = "TextBoxBorder";
            this.txt_DatabaseName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_DatabaseName.Location = new System.Drawing.Point(20, 74);
            this.txt_DatabaseName.Name = "txt_DatabaseName";
            this.txt_DatabaseName.PasswordChar = '#';
            this.txt_DatabaseName.PreventEnterBeep = true;
            this.txt_DatabaseName.Size = new System.Drawing.Size(308, 36);
            this.txt_DatabaseName.TabIndex = 2;
            this.txt_DatabaseName.WatermarkText = "نام ديتابيس...";
            // 
            // txt_DatabasePassword
            // 
            // 
            // 
            // 
            this.txt_DatabasePassword.Border.Class = "TextBoxBorder";
            this.txt_DatabasePassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_DatabasePassword.Location = new System.Drawing.Point(20, 116);
            this.txt_DatabasePassword.Name = "txt_DatabasePassword";
            this.txt_DatabasePassword.PasswordChar = '*';
            this.txt_DatabasePassword.PreventEnterBeep = true;
            this.txt_DatabasePassword.Size = new System.Drawing.Size(308, 36);
            this.txt_DatabasePassword.TabIndex = 3;
            this.txt_DatabasePassword.WatermarkText = "گذرواژه ديتابيس...";
            // 
            // btn_Save
            // 
            this.btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Save.Location = new System.Drawing.Point(155, 268);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(156, 38);
            this.btn_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Save.Symbol = "";
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "ذخيره";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Exit.Location = new System.Drawing.Point(439, 12);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(35, 26);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.Symbol = "";
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // frmServerParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 318);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmServerParameters";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmServerParameters_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.pnl_SetServerParameters.ResumeLayout(false);
            this.pnl_SetServerParameters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_SetServerParameters;
        private DevComponents.DotNetBar.LabelX ServerIP;
        private DevComponents.DotNetBar.LabelX lbl_DatabasePassword;
        private DevComponents.DotNetBar.LabelX lbl_DatabaseName;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
        private DevComponents.DotNetBar.ButtonX btn_Save;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_DatabasePassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_DatabaseName;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_ServerIP;
    }
}