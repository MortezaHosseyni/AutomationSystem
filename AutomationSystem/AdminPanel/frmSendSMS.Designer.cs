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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pnl_Users = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv_Users = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_SelectUser = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_UserFristName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UserLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UserStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UserTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UserRegisteredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UserGenderCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Main.SuspendLayout();
            this.pnl_PanelInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GetLineInfo)).BeginInit();
            this.pnl_Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.pnl_Users);
            this.pnl_Main.Controls.Add(this.pnl_PanelInformation);
            this.pnl_Main.Controls.Add(this.lbl_Title);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(854, 650);
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
            this.pnl_PanelInformation.Size = new System.Drawing.Size(830, 168);
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
            this.lbl_LineSerial.Location = new System.Drawing.Point(747, 87);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_GetLineInfo.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_GetLineInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(181)))), ((int)(((byte)(252)))));
            this.dgv_GetLineInfo.Location = new System.Drawing.Point(3, 3);
            this.dgv_GetLineInfo.Name = "dgv_GetLineInfo";
            this.dgv_GetLineInfo.Size = new System.Drawing.Size(290, 120);
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
            this.lbl_LineNumber.Location = new System.Drawing.Point(483, 87);
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
            this.txt_Username.TabIndex = 1;
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
            this.txt_LineSerial.Location = new System.Drawing.Point(556, 87);
            this.txt_LineSerial.Name = "txt_LineSerial";
            this.txt_LineSerial.PreventEnterBeep = true;
            this.txt_LineSerial.Size = new System.Drawing.Size(185, 36);
            this.txt_LineSerial.TabIndex = 3;
            this.txt_LineSerial.WatermarkText = "سريال خط...";
            // 
            // val_LineNumber
            // 
            this.val_LineNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.val_LineNumber.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_LineNumber.Location = new System.Drawing.Point(299, 87);
            this.val_LineNumber.Name = "val_LineNumber";
            this.val_LineNumber.Size = new System.Drawing.Size(178, 33);
            this.val_LineNumber.TabIndex = 6;
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
            this.btn_GetLineInfo.TabIndex = 4;
            this.btn_GetLineInfo.Text = "دريافت اطلاعات خط";
            this.btn_GetLineInfo.Click += new System.EventHandler(this.btn_GetLineInfo_Click);
            // 
            // pnl_Users
            // 
            this.pnl_Users.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Users.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Users.Controls.Add(this.dgv_Users);
            this.pnl_Users.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Users.Location = new System.Drawing.Point(12, 232);
            this.pnl_Users.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Users.Name = "pnl_Users";
            this.pnl_Users.Size = new System.Drawing.Size(830, 231);
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
            this.pnl_Users.TabIndex = 3;
            // 
            // dgv_Users
            // 
            this.dgv_Users.AllowUserToAddRows = false;
            this.dgv_Users.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_SelectUser,
            this.col_UserFristName,
            this.col_UserLastName,
            this.col_UserStatus,
            this.col_UserTel,
            this.col_UserRegisteredDate,
            this.col_UserID,
            this.col_UserName,
            this.col_UserGenderCode});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Users.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Users.EnableHeadersVisualStyles = false;
            this.dgv_Users.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(181)))), ((int)(((byte)(252)))));
            this.dgv_Users.Location = new System.Drawing.Point(3, 3);
            this.dgv_Users.Name = "dgv_Users";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Users.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Users.Size = new System.Drawing.Size(818, 219);
            this.dgv_Users.TabIndex = 5;
            // 
            // col_SelectUser
            // 
            this.col_SelectUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_SelectUser.HeaderText = "انتخاب";
            this.col_SelectUser.Name = "col_SelectUser";
            this.col_SelectUser.Width = 57;
            // 
            // col_UserFristName
            // 
            this.col_UserFristName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_UserFristName.HeaderText = "نام";
            this.col_UserFristName.Name = "col_UserFristName";
            // 
            // col_UserLastName
            // 
            this.col_UserLastName.HeaderText = "نام خانوادگي";
            this.col_UserLastName.Name = "col_UserLastName";
            this.col_UserLastName.Width = 200;
            // 
            // col_UserStatus
            // 
            this.col_UserStatus.HeaderText = "وضعيت";
            this.col_UserStatus.Name = "col_UserStatus";
            // 
            // col_UserTel
            // 
            this.col_UserTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_UserTel.HeaderText = "شماره تماس";
            this.col_UserTel.Name = "col_UserTel";
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
            // col_UserName
            // 
            this.col_UserName.HeaderText = "UserName";
            this.col_UserName.Name = "col_UserName";
            this.col_UserName.Visible = false;
            // 
            // col_UserGenderCode
            // 
            this.col_UserGenderCode.HeaderText = "GenderCode";
            this.col_UserGenderCode.Name = "col_UserGenderCode";
            this.col_UserGenderCode.Visible = false;
            // 
            // frmSendSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 650);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmSendSMS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSendSMS_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.pnl_PanelInformation.ResumeLayout(false);
            this.pnl_PanelInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GetLineInfo)).EndInit();
            this.pnl_Users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).EndInit();
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
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Users;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_Users;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_SelectUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserFristName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserRegisteredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserGenderCode;
    }
}