namespace AutomationSystem.AdminPanel
{
    partial class frmSendSMS
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
            this.pnl_Main = new DevComponents.DotNetBar.PanelEx();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.pnl_PanelInformation = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_Username = new DevComponents.DotNetBar.LabelX();
            this.lbl_Password = new DevComponents.DotNetBar.LabelX();
            this.lbl_LineSerial = new DevComponents.DotNetBar.LabelX();
            this.dgv_GetLineInfo = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lbl_LineNumber = new DevComponents.DotNetBar.LabelX();
            this.txt_Username = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_LineSerial = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.val_LineNumber = new DevComponents.DotNetBar.LabelX();
            this.btn_GetLineInfo = new DevComponents.DotNetBar.ButtonX();
            this.pnl_Main.SuspendLayout();
            this.pnl_PanelInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GetLineInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.pnl_PanelInformation);
            this.pnl_Main.Controls.Add(this.lbl_Title);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(854, 570);
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
            this.lbl_Title.Location = new System.Drawing.Point(348, 3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(147, 48);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "ارسال پيامك";
            // 
            // pnl_PanelInformation
            // 
            this.pnl_PanelInformation.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_PanelInformation.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_PanelInformation.Controls.Add(this.btn_GetLineInfo);
            this.pnl_PanelInformation.Controls.Add(this.txt_LineSerial);
            this.pnl_PanelInformation.Controls.Add(this.txt_Password);
            this.pnl_PanelInformation.Controls.Add(this.txt_Username);
            this.pnl_PanelInformation.Controls.Add(this.dgv_GetLineInfo);
            this.pnl_PanelInformation.Controls.Add(this.val_LineNumber);
            this.pnl_PanelInformation.Controls.Add(this.lbl_LineNumber);
            this.pnl_PanelInformation.Controls.Add(this.lbl_LineSerial);
            this.pnl_PanelInformation.Controls.Add(this.lbl_Password);
            this.pnl_PanelInformation.Controls.Add(this.lbl_Username);
            this.pnl_PanelInformation.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_PanelInformation.Location = new System.Drawing.Point(12, 57);
            this.pnl_PanelInformation.Name = "pnl_PanelInformation";
            this.pnl_PanelInformation.Size = new System.Drawing.Size(830, 213);
            // 
            // 
            // 
            this.pnl_PanelInformation.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_PanelInformation.Style.BackColorGradientAngle = 90;
            this.pnl_PanelInformation.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_PanelInformation.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_PanelInformation.Style.BorderBottomWidth = 1;
            this.pnl_PanelInformation.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_PanelInformation.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_PanelInformation.Style.BorderLeftWidth = 1;
            this.pnl_PanelInformation.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_PanelInformation.Style.BorderRightWidth = 1;
            this.pnl_PanelInformation.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_PanelInformation.Style.BorderTopWidth = 1;
            this.pnl_PanelInformation.Style.CornerDiameter = 4;
            this.pnl_PanelInformation.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_PanelInformation.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_PanelInformation.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_PanelInformation.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_PanelInformation.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_PanelInformation.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_PanelInformation.TabIndex = 1;
            this.pnl_PanelInformation.Text = "مشخصات پنل";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            // 
            // 
            // 
            this.lbl_Username.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Username.Location = new System.Drawing.Point(747, 3);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(65, 33);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "نام كاربري:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            // 
            // 
            // 
            this.lbl_Password.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Password.Location = new System.Drawing.Point(747, 45);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(49, 33);
            this.lbl_Password.TabIndex = 0;
            this.lbl_Password.Text = "گذرواژه:";
            // 
            // lbl_LineSerial
            // 
            this.lbl_LineSerial.AutoSize = true;
            // 
            // 
            // 
            this.lbl_LineSerial.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_LineSerial.Location = new System.Drawing.Point(747, 137);
            this.lbl_LineSerial.Name = "lbl_LineSerial";
            this.lbl_LineSerial.Size = new System.Drawing.Size(69, 33);
            this.lbl_LineSerial.TabIndex = 0;
            this.lbl_LineSerial.Text = "سريال خط:";
            // 
            // dgv_GetLineInfo
            // 
            this.dgv_GetLineInfo.AllowUserToAddRows = false;
            this.dgv_GetLineInfo.AllowUserToDeleteRows = false;
            this.dgv_GetLineInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_GetLineInfo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_GetLineInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(181)))), ((int)(((byte)(252)))));
            this.dgv_GetLineInfo.Location = new System.Drawing.Point(3, 3);
            this.dgv_GetLineInfo.Name = "dgv_GetLineInfo";
            this.dgv_GetLineInfo.Size = new System.Drawing.Size(290, 170);
            this.dgv_GetLineInfo.TabIndex = 1;
            this.dgv_GetLineInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GetLineInfo_CellContentClick);
            // 
            // lbl_LineNumber
            // 
            this.lbl_LineNumber.AutoSize = true;
            // 
            // 
            // 
            this.lbl_LineNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_LineNumber.Location = new System.Drawing.Point(483, 137);
            this.lbl_LineNumber.Name = "lbl_LineNumber";
            this.lbl_LineNumber.Size = new System.Drawing.Size(67, 33);
            this.lbl_LineNumber.TabIndex = 0;
            this.lbl_LineNumber.Text = "شماره خط:";
            // 
            // txt_Username
            // 
            // 
            // 
            // 
            this.txt_Username.Border.Class = "TextBoxBorder";
            this.txt_Username.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Username.Location = new System.Drawing.Point(518, 3);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PreventEnterBeep = true;
            this.txt_Username.Size = new System.Drawing.Size(223, 36);
            this.txt_Username.TabIndex = 2;
            this.txt_Username.WatermarkText = "نام كاربري پنل...";
            // 
            // txt_Password
            // 
            // 
            // 
            // 
            this.txt_Password.Border.Class = "TextBoxBorder";
            this.txt_Password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Password.Location = new System.Drawing.Point(518, 45);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.PreventEnterBeep = true;
            this.txt_Password.Size = new System.Drawing.Size(223, 36);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.WatermarkText = "گذرواژه پنل...";
            // 
            // txt_LineSerial
            // 
            // 
            // 
            // 
            this.txt_LineSerial.Border.Class = "TextBoxBorder";
            this.txt_LineSerial.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_LineSerial.Location = new System.Drawing.Point(556, 137);
            this.txt_LineSerial.Name = "txt_LineSerial";
            this.txt_LineSerial.PreventEnterBeep = true;
            this.txt_LineSerial.Size = new System.Drawing.Size(185, 36);
            this.txt_LineSerial.TabIndex = 2;
            this.txt_LineSerial.WatermarkText = "سريال خط...";
            // 
            // val_LineNumber
            // 
            this.val_LineNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.val_LineNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_LineNumber.Location = new System.Drawing.Point(299, 137);
            this.val_LineNumber.Name = "val_LineNumber";
            this.val_LineNumber.Size = new System.Drawing.Size(178, 33);
            this.val_LineNumber.TabIndex = 0;
            this.val_LineNumber.Text = "...";
            this.val_LineNumber.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_GetLineInfo
            // 
            this.btn_GetLineInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_GetLineInfo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_GetLineInfo.Location = new System.Drawing.Point(299, 3);
            this.btn_GetLineInfo.Name = "btn_GetLineInfo";
            this.btn_GetLineInfo.Size = new System.Drawing.Size(213, 78);
            this.btn_GetLineInfo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_GetLineInfo.Symbol = "";
            this.btn_GetLineInfo.TabIndex = 3;
            this.btn_GetLineInfo.Text = "دريافت اطلاعات خط";
            this.btn_GetLineInfo.Click += new System.EventHandler(this.btn_GetLineInfo_Click);
            // 
            // frmSendSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 570);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmSendSMS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.pnl_PanelInformation.ResumeLayout(false);
            this.pnl_PanelInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GetLineInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_PanelInformation;
        private DevComponents.DotNetBar.LabelX lbl_LineSerial;
        private DevComponents.DotNetBar.LabelX lbl_Password;
        private DevComponents.DotNetBar.LabelX lbl_Username;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_GetLineInfo;
        private DevComponents.DotNetBar.LabelX lbl_LineNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_LineSerial;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Password;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Username;
        private DevComponents.DotNetBar.LabelX val_LineNumber;
        private DevComponents.DotNetBar.ButtonX btn_GetLineInfo;
    }
}