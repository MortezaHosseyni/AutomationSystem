namespace AutomationSystem.UserPanel
{
    partial class frmUserChooseLetterSend
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
            this.pnl_SelectReciver = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.btn_SendLetter = new DevComponents.DotNetBar.ButtonX();
            this.btn_Search = new DevComponents.DotNetBar.ButtonX();
            this.txt_SearchFristAndLastName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_SearchFristAndLastName = new DevComponents.DotNetBar.LabelX();
            this.dgv_Recivers = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.col_JobUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SelectUser = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_JobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Main.SuspendLayout();
            this.pnl_SelectReciver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Recivers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.pnl_SelectReciver);
            this.pnl_Main.Controls.Add(this.lbl_Title);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(602, 460);
            this.pnl_Main.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl_Main.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Main.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Main.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl_Main.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Main.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Main.Style.GradientAngle = 90;
            this.pnl_Main.TabIndex = 2;
            // 
            // pnl_SelectReciver
            // 
            this.pnl_SelectReciver.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_SelectReciver.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_SelectReciver.Controls.Add(this.btn_Exit);
            this.pnl_SelectReciver.Controls.Add(this.btn_SendLetter);
            this.pnl_SelectReciver.Controls.Add(this.btn_Search);
            this.pnl_SelectReciver.Controls.Add(this.txt_SearchFristAndLastName);
            this.pnl_SelectReciver.Controls.Add(this.lbl_SearchFristAndLastName);
            this.pnl_SelectReciver.Controls.Add(this.dgv_Recivers);
            this.pnl_SelectReciver.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_SelectReciver.Location = new System.Drawing.Point(12, 58);
            this.pnl_SelectReciver.Name = "pnl_SelectReciver";
            this.pnl_SelectReciver.Size = new System.Drawing.Size(578, 390);
            // 
            // 
            // 
            this.pnl_SelectReciver.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_SelectReciver.Style.BackColorGradientAngle = 90;
            this.pnl_SelectReciver.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_SelectReciver.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SelectReciver.Style.BorderBottomWidth = 1;
            this.pnl_SelectReciver.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_SelectReciver.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SelectReciver.Style.BorderLeftWidth = 1;
            this.pnl_SelectReciver.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SelectReciver.Style.BorderRightWidth = 1;
            this.pnl_SelectReciver.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SelectReciver.Style.BorderTopWidth = 1;
            this.pnl_SelectReciver.Style.CornerDiameter = 4;
            this.pnl_SelectReciver.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_SelectReciver.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_SelectReciver.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_SelectReciver.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_SelectReciver.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_SelectReciver.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_SelectReciver.TabIndex = 3;
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Exit.Location = new System.Drawing.Point(150, 338);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20, 2, 2, 20);
            this.btn_Exit.Size = new System.Drawing.Size(152, 35);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.Symbol = "";
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "خروج";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_SendLetter
            // 
            this.btn_SendLetter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SendLetter.BackColor = System.Drawing.Color.Transparent;
            this.btn_SendLetter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_SendLetter.Location = new System.Drawing.Point(308, 338);
            this.btn_SendLetter.Name = "btn_SendLetter";
            this.btn_SendLetter.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20, 2, 2, 20);
            this.btn_SendLetter.Size = new System.Drawing.Size(152, 35);
            this.btn_SendLetter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_SendLetter.Symbol = "";
            this.btn_SendLetter.TabIndex = 4;
            this.btn_SendLetter.Text = "ارسال";
            // 
            // btn_Search
            // 
            this.btn_Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Search.Location = new System.Drawing.Point(46, 274);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(55, 36);
            this.btn_Search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Search.Symbol = "";
            this.btn_Search.TabIndex = 3;
            // 
            // txt_SearchFristAndLastName
            // 
            // 
            // 
            // 
            this.txt_SearchFristAndLastName.Border.Class = "TextBoxBorder";
            this.txt_SearchFristAndLastName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SearchFristAndLastName.Location = new System.Drawing.Point(140, 274);
            this.txt_SearchFristAndLastName.Name = "txt_SearchFristAndLastName";
            this.txt_SearchFristAndLastName.PreventEnterBeep = true;
            this.txt_SearchFristAndLastName.Size = new System.Drawing.Size(287, 36);
            this.txt_SearchFristAndLastName.TabIndex = 2;
            this.txt_SearchFristAndLastName.WatermarkText = "جستجو براساس نام و نام‌خانوادگي...";
            // 
            // lbl_SearchFristAndLastName
            // 
            this.lbl_SearchFristAndLastName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_SearchFristAndLastName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SearchFristAndLastName.Location = new System.Drawing.Point(433, 280);
            this.lbl_SearchFristAndLastName.Name = "lbl_SearchFristAndLastName";
            this.lbl_SearchFristAndLastName.Size = new System.Drawing.Size(103, 25);
            this.lbl_SearchFristAndLastName.TabIndex = 1;
            this.lbl_SearchFristAndLastName.Text = "نام و نام‌خانوادگي:";
            // 
            // dgv_Recivers
            // 
            this.dgv_Recivers.AllowUserToAddRows = false;
            this.dgv_Recivers.AllowUserToDeleteRows = false;
            this.dgv_Recivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Recivers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_JobUserID,
            this.col_UserID,
            this.col_SelectUser,
            this.col_FullName,
            this.col_JobName});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Recivers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Recivers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_Recivers.Location = new System.Drawing.Point(3, 3);
            this.dgv_Recivers.Name = "dgv_Recivers";
            this.dgv_Recivers.Size = new System.Drawing.Size(566, 247);
            this.dgv_Recivers.TabIndex = 0;
            // 
            // lbl_Title
            // 
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("B Nazanin", 20.25F);
            this.lbl_Title.Location = new System.Drawing.Point(246, 12);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(111, 40);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "ارسال نامه";
            // 
            // col_JobUserID
            // 
            this.col_JobUserID.HeaderText = "JobUserID";
            this.col_JobUserID.Name = "col_JobUserID";
            this.col_JobUserID.Visible = false;
            // 
            // col_UserID
            // 
            this.col_UserID.HeaderText = "UserID";
            this.col_UserID.Name = "col_UserID";
            this.col_UserID.Visible = false;
            // 
            // col_SelectUser
            // 
            this.col_SelectUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_SelectUser.HeaderText = "انتخاب";
            this.col_SelectUser.Name = "col_SelectUser";
            this.col_SelectUser.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_SelectUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_SelectUser.Width = 76;
            // 
            // col_FullName
            // 
            this.col_FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_FullName.HeaderText = "نام و نام‌خانواگي";
            this.col_FullName.Name = "col_FullName";
            // 
            // col_JobName
            // 
            this.col_JobName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_JobName.HeaderText = "شغل";
            this.col_JobName.Name = "col_JobName";
            // 
            // frmUserChooseLetterSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 460);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmUserChooseLetterSend";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUserChooseLetterSend_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_SelectReciver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Recivers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_SelectReciver;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
        private DevComponents.DotNetBar.ButtonX btn_SendLetter;
        private DevComponents.DotNetBar.ButtonX btn_Search;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SearchFristAndLastName;
        private DevComponents.DotNetBar.LabelX lbl_SearchFristAndLastName;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_Recivers;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_JobUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_SelectUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_JobName;
    }
}