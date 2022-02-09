namespace AutomationSystem.UserPanel
{
    partial class frmUserUpdatePassword
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
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.pnl_Main = new DevComponents.DotNetBar.PanelEx();
            this.pnl_Buttons = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.btn_Save = new DevComponents.DotNetBar.ButtonX();
            this.pnl_ChangePassword = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txt_ConfirmNewPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_NewPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_ConfirmNewPassword = new DevComponents.DotNetBar.LabelX();
            this.lbl_NewPassword = new DevComponents.DotNetBar.LabelX();
            this.lbl_OldPassword = new DevComponents.DotNetBar.LabelX();
            this.txt_OldPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pnl_Main.SuspendLayout();
            this.pnl_Buttons.SuspendLayout();
            this.pnl_ChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("B Nazanin", 18.25F);
            this.lbl_Title.Location = new System.Drawing.Point(12, 12);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(579, 39);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "...";
            this.lbl_Title.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.pnl_Buttons);
            this.pnl_Main.Controls.Add(this.pnl_ChangePassword);
            this.pnl_Main.Controls.Add(this.lbl_Title);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(603, 310);
            this.pnl_Main.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl_Main.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Main.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Main.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl_Main.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Main.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Main.Style.GradientAngle = 90;
            this.pnl_Main.TabIndex = 4;
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Buttons.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Buttons.Controls.Add(this.btn_Exit);
            this.pnl_Buttons.Controls.Add(this.btn_Save);
            this.pnl_Buttons.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Buttons.Location = new System.Drawing.Point(12, 236);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(579, 62);
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
            this.pnl_Buttons.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Exit.Location = new System.Drawing.Point(64, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20, 2, 2, 20);
            this.btn_Exit.Size = new System.Drawing.Size(217, 47);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.Symbol = "";
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "خروج";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Save.Location = new System.Drawing.Point(287, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20, 2, 2, 20);
            this.btn_Save.Size = new System.Drawing.Size(217, 47);
            this.btn_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Save.Symbol = "";
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "ثبت اطلاعات";
            // 
            // pnl_ChangePassword
            // 
            this.pnl_ChangePassword.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_ChangePassword.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_ChangePassword.Controls.Add(this.txt_ConfirmNewPassword);
            this.pnl_ChangePassword.Controls.Add(this.txt_OldPassword);
            this.pnl_ChangePassword.Controls.Add(this.txt_NewPassword);
            this.pnl_ChangePassword.Controls.Add(this.lbl_OldPassword);
            this.pnl_ChangePassword.Controls.Add(this.lbl_ConfirmNewPassword);
            this.pnl_ChangePassword.Controls.Add(this.lbl_NewPassword);
            this.pnl_ChangePassword.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_ChangePassword.Location = new System.Drawing.Point(12, 57);
            this.pnl_ChangePassword.Name = "pnl_ChangePassword";
            this.pnl_ChangePassword.Size = new System.Drawing.Size(579, 173);
            // 
            // 
            // 
            this.pnl_ChangePassword.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_ChangePassword.Style.BackColorGradientAngle = 90;
            this.pnl_ChangePassword.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_ChangePassword.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_ChangePassword.Style.BorderBottomWidth = 1;
            this.pnl_ChangePassword.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_ChangePassword.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_ChangePassword.Style.BorderLeftWidth = 1;
            this.pnl_ChangePassword.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_ChangePassword.Style.BorderRightWidth = 1;
            this.pnl_ChangePassword.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_ChangePassword.Style.BorderTopWidth = 1;
            this.pnl_ChangePassword.Style.CornerDiameter = 4;
            this.pnl_ChangePassword.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_ChangePassword.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_ChangePassword.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_ChangePassword.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_ChangePassword.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_ChangePassword.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_ChangePassword.TabIndex = 1;
            // 
            // txt_ConfirmNewPassword
            // 
            // 
            // 
            // 
            this.txt_ConfirmNewPassword.Border.Class = "TextBoxBorder";
            this.txt_ConfirmNewPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_ConfirmNewPassword.Location = new System.Drawing.Point(64, 106);
            this.txt_ConfirmNewPassword.Name = "txt_ConfirmNewPassword";
            this.txt_ConfirmNewPassword.PasswordChar = '*';
            this.txt_ConfirmNewPassword.PreventEnterBeep = true;
            this.txt_ConfirmNewPassword.Size = new System.Drawing.Size(330, 36);
            this.txt_ConfirmNewPassword.TabIndex = 3;
            this.txt_ConfirmNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ConfirmNewPassword.WatermarkText = "تكرار گذرواژه جديد...";
            // 
            // txt_NewPassword
            // 
            // 
            // 
            // 
            this.txt_NewPassword.Border.Class = "TextBoxBorder";
            this.txt_NewPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_NewPassword.Location = new System.Drawing.Point(64, 64);
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.PasswordChar = '*';
            this.txt_NewPassword.PreventEnterBeep = true;
            this.txt_NewPassword.Size = new System.Drawing.Size(330, 36);
            this.txt_NewPassword.TabIndex = 2;
            this.txt_NewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_NewPassword.WatermarkText = "گذرواژه جديد...";
            // 
            // lbl_ConfirmNewPassword
            // 
            this.lbl_ConfirmNewPassword.AutoSize = true;
            // 
            // 
            // 
            this.lbl_ConfirmNewPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_ConfirmNewPassword.Location = new System.Drawing.Point(400, 109);
            this.lbl_ConfirmNewPassword.Name = "lbl_ConfirmNewPassword";
            this.lbl_ConfirmNewPassword.Size = new System.Drawing.Size(118, 33);
            this.lbl_ConfirmNewPassword.TabIndex = 0;
            this.lbl_ConfirmNewPassword.Text = "تكرار گذرواژه جديد:";
            // 
            // lbl_NewPassword
            // 
            this.lbl_NewPassword.AutoSize = true;
            // 
            // 
            // 
            this.lbl_NewPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_NewPassword.Location = new System.Drawing.Point(400, 67);
            this.lbl_NewPassword.Name = "lbl_NewPassword";
            this.lbl_NewPassword.Size = new System.Drawing.Size(85, 33);
            this.lbl_NewPassword.TabIndex = 0;
            this.lbl_NewPassword.Text = "گذرواژه جديد:";
            // 
            // lbl_OldPassword
            // 
            this.lbl_OldPassword.AutoSize = true;
            // 
            // 
            // 
            this.lbl_OldPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_OldPassword.Location = new System.Drawing.Point(400, 25);
            this.lbl_OldPassword.Name = "lbl_OldPassword";
            this.lbl_OldPassword.Size = new System.Drawing.Size(80, 33);
            this.lbl_OldPassword.TabIndex = 0;
            this.lbl_OldPassword.Text = "گذرواژه قبلي:";
            // 
            // txt_OldPassword
            // 
            // 
            // 
            // 
            this.txt_OldPassword.Border.Class = "TextBoxBorder";
            this.txt_OldPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_OldPassword.Location = new System.Drawing.Point(64, 22);
            this.txt_OldPassword.Name = "txt_OldPassword";
            this.txt_OldPassword.PasswordChar = '*';
            this.txt_OldPassword.PreventEnterBeep = true;
            this.txt_OldPassword.Size = new System.Drawing.Size(330, 36);
            this.txt_OldPassword.TabIndex = 1;
            this.txt_OldPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_OldPassword.WatermarkText = "گذرواژه قبلي...";
            // 
            // frmUserUpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 310);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmUserUpdatePassword";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUserUpdatePassword_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Buttons.ResumeLayout(false);
            this.pnl_ChangePassword.ResumeLayout(false);
            this.pnl_ChangePassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Buttons;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
        private DevComponents.DotNetBar.ButtonX btn_Save;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_ChangePassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_ConfirmNewPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_NewPassword;
        private DevComponents.DotNetBar.LabelX lbl_ConfirmNewPassword;
        private DevComponents.DotNetBar.LabelX lbl_NewPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_OldPassword;
        private DevComponents.DotNetBar.LabelX lbl_OldPassword;
    }
}