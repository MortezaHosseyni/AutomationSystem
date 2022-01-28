namespace AutomationSystem.AdminPanel
{
    partial class frmAsignmentJob
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Main = new DevComponents.DotNetBar.PanelEx();
            this.pnl_UsersList = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.dgv_UsersList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.pnl_Search = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_SearchName = new DevComponents.DotNetBar.LabelX();
            this.txt_SearchName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_SearchLastName = new DevComponents.DotNetBar.LabelX();
            this.txt_SearchLastName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_SearchPersonalCode = new DevComponents.DotNetBar.LabelX();
            this.txt_SearchPersonalCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_Search = new DevComponents.DotNetBar.ButtonX();
            this.pnl_Buttons = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_JobsHistory = new DevComponents.DotNetBar.ButtonX();
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.col_FristName = new DevComponents.DotNetBar.Controls.DataGridViewSliderColumn();
            this.col_LastName = new DevComponents.DotNetBar.Controls.DataGridViewSliderColumn();
            this.col_Gender = new DevComponents.DotNetBar.Controls.DataGridViewSliderColumn();
            this.col_PersonalCode = new DevComponents.DotNetBar.Controls.DataGridViewSliderColumn();
            this.col_UserID = new DevComponents.DotNetBar.Controls.DataGridViewSliderColumn();
            this.pnl_Main.SuspendLayout();
            this.pnl_UsersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UsersList)).BeginInit();
            this.pnl_Search.SuspendLayout();
            this.pnl_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.pnl_Buttons);
            this.pnl_Main.Controls.Add(this.pnl_Search);
            this.pnl_Main.Controls.Add(this.lbl_Title);
            this.pnl_Main.Controls.Add(this.pnl_UsersList);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(911, 569);
            this.pnl_Main.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl_Main.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Main.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Main.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl_Main.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Main.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Main.Style.GradientAngle = 90;
            this.pnl_Main.TabIndex = 0;
            // 
            // pnl_UsersList
            // 
            this.pnl_UsersList.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_UsersList.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_UsersList.Controls.Add(this.dgv_UsersList);
            this.pnl_UsersList.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_UsersList.Location = new System.Drawing.Point(12, 77);
            this.pnl_UsersList.Name = "pnl_UsersList";
            this.pnl_UsersList.Size = new System.Drawing.Size(887, 277);
            // 
            // 
            // 
            this.pnl_UsersList.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_UsersList.Style.BackColorGradientAngle = 90;
            this.pnl_UsersList.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_UsersList.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UsersList.Style.BorderBottomWidth = 1;
            this.pnl_UsersList.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_UsersList.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UsersList.Style.BorderLeftWidth = 1;
            this.pnl_UsersList.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UsersList.Style.BorderRightWidth = 1;
            this.pnl_UsersList.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UsersList.Style.BorderTopWidth = 1;
            this.pnl_UsersList.Style.CornerDiameter = 4;
            this.pnl_UsersList.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_UsersList.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_UsersList.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_UsersList.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_UsersList.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_UsersList.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_UsersList.TabIndex = 0;
            this.pnl_UsersList.Text = "ليست پرسنل";
            // 
            // lbl_Title
            // 
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("B Nazanin", 22.25F);
            this.lbl_Title.Location = new System.Drawing.Point(375, 12);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(148, 48);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "انتصاب شغل";
            // 
            // dgv_UsersList
            // 
            this.dgv_UsersList.AllowUserToAddRows = false;
            this.dgv_UsersList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_UsersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_UsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UsersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_FristName,
            this.col_LastName,
            this.col_Gender,
            this.col_PersonalCode,
            this.col_UserID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_UsersList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_UsersList.EnableHeadersVisualStyles = false;
            this.dgv_UsersList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(181)))), ((int)(((byte)(252)))));
            this.dgv_UsersList.Location = new System.Drawing.Point(3, 3);
            this.dgv_UsersList.Name = "dgv_UsersList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_UsersList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_UsersList.Size = new System.Drawing.Size(875, 234);
            this.dgv_UsersList.TabIndex = 0;
            // 
            // pnl_Search
            // 
            this.pnl_Search.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Search.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Search.Controls.Add(this.btn_Search);
            this.pnl_Search.Controls.Add(this.txt_SearchPersonalCode);
            this.pnl_Search.Controls.Add(this.lbl_SearchPersonalCode);
            this.pnl_Search.Controls.Add(this.txt_SearchLastName);
            this.pnl_Search.Controls.Add(this.lbl_SearchLastName);
            this.pnl_Search.Controls.Add(this.txt_SearchName);
            this.pnl_Search.Controls.Add(this.lbl_SearchName);
            this.pnl_Search.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Search.Location = new System.Drawing.Point(12, 360);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(887, 125);
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
            this.pnl_Search.TabIndex = 2;
            this.pnl_Search.Text = "جستجو";
            // 
            // lbl_SearchName
            // 
            // 
            // 
            // 
            this.lbl_SearchName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SearchName.Location = new System.Drawing.Point(835, 25);
            this.lbl_SearchName.Name = "lbl_SearchName";
            this.lbl_SearchName.Size = new System.Drawing.Size(21, 36);
            this.lbl_SearchName.TabIndex = 0;
            this.lbl_SearchName.Text = "نام:";
            // 
            // txt_SearchName
            // 
            // 
            // 
            // 
            this.txt_SearchName.Border.Class = "TextBoxBorder";
            this.txt_SearchName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SearchName.Location = new System.Drawing.Point(650, 25);
            this.txt_SearchName.Name = "txt_SearchName";
            this.txt_SearchName.PreventEnterBeep = true;
            this.txt_SearchName.Size = new System.Drawing.Size(179, 36);
            this.txt_SearchName.TabIndex = 1;
            this.txt_SearchName.WatermarkText = "نام پرسنل...";
            // 
            // lbl_SearchLastName
            // 
            // 
            // 
            // 
            this.lbl_SearchLastName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SearchLastName.Location = new System.Drawing.Point(566, 25);
            this.lbl_SearchLastName.Name = "lbl_SearchLastName";
            this.lbl_SearchLastName.Size = new System.Drawing.Size(78, 36);
            this.lbl_SearchLastName.TabIndex = 0;
            this.lbl_SearchLastName.Text = "نام خانوادگي:";
            // 
            // txt_SearchLastName
            // 
            // 
            // 
            // 
            this.txt_SearchLastName.Border.Class = "TextBoxBorder";
            this.txt_SearchLastName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SearchLastName.Location = new System.Drawing.Point(381, 25);
            this.txt_SearchLastName.Name = "txt_SearchLastName";
            this.txt_SearchLastName.PreventEnterBeep = true;
            this.txt_SearchLastName.Size = new System.Drawing.Size(179, 36);
            this.txt_SearchLastName.TabIndex = 1;
            this.txt_SearchLastName.WatermarkText = "نام خانوادگي پرسنل...";
            // 
            // lbl_SearchPersonalCode
            // 
            // 
            // 
            // 
            this.lbl_SearchPersonalCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SearchPersonalCode.Location = new System.Drawing.Point(306, 25);
            this.lbl_SearchPersonalCode.Name = "lbl_SearchPersonalCode";
            this.lbl_SearchPersonalCode.Size = new System.Drawing.Size(69, 36);
            this.lbl_SearchPersonalCode.TabIndex = 0;
            this.lbl_SearchPersonalCode.Text = "كد پرسنلي:";
            // 
            // txt_SearchPersonalCode
            // 
            // 
            // 
            // 
            this.txt_SearchPersonalCode.Border.Class = "TextBoxBorder";
            this.txt_SearchPersonalCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SearchPersonalCode.Location = new System.Drawing.Point(121, 25);
            this.txt_SearchPersonalCode.Name = "txt_SearchPersonalCode";
            this.txt_SearchPersonalCode.PreventEnterBeep = true;
            this.txt_SearchPersonalCode.Size = new System.Drawing.Size(179, 36);
            this.txt_SearchPersonalCode.TabIndex = 1;
            this.txt_SearchPersonalCode.WatermarkText = "كد پرسنلي...";
            // 
            // btn_Search
            // 
            this.btn_Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Search.Location = new System.Drawing.Point(24, 13);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(74, 58);
            this.btn_Search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Search.Symbol = "";
            this.btn_Search.TabIndex = 2;
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Buttons.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Buttons.Controls.Add(this.btn_Exit);
            this.pnl_Buttons.Controls.Add(this.btn_JobsHistory);
            this.pnl_Buttons.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Buttons.Location = new System.Drawing.Point(12, 491);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(887, 66);
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
            this.pnl_Buttons.TabIndex = 3;
            // 
            // btn_JobsHistory
            // 
            this.btn_JobsHistory.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_JobsHistory.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_JobsHistory.Location = new System.Drawing.Point(449, 3);
            this.btn_JobsHistory.Name = "btn_JobsHistory";
            this.btn_JobsHistory.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20, 2, 2, 20);
            this.btn_JobsHistory.Size = new System.Drawing.Size(214, 53);
            this.btn_JobsHistory.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_JobsHistory.Symbol = "";
            this.btn_JobsHistory.TabIndex = 0;
            this.btn_JobsHistory.Text = "تاريخچه مشاغل";
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Exit.Location = new System.Drawing.Point(229, 4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20, 2, 2, 20);
            this.btn_Exit.Size = new System.Drawing.Size(214, 53);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.Symbol = "";
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "خروج";
            // 
            // col_FristName
            // 
            this.col_FristName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_FristName.HeaderText = "نام";
            this.col_FristName.Name = "col_FristName";
            this.col_FristName.Value = 0;
            this.col_FristName.Width = 150;
            // 
            // col_LastName
            // 
            this.col_LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_LastName.HeaderText = "نام خانوادگي";
            this.col_LastName.Name = "col_LastName";
            this.col_LastName.Value = 0;
            // 
            // col_Gender
            // 
            this.col_Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_Gender.HeaderText = "جنسيت";
            this.col_Gender.Name = "col_Gender";
            this.col_Gender.Value = 0;
            this.col_Gender.Width = 84;
            // 
            // col_PersonalCode
            // 
            this.col_PersonalCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_PersonalCode.HeaderText = "شماره پرسنلي";
            this.col_PersonalCode.Name = "col_PersonalCode";
            this.col_PersonalCode.Value = 0;
            // 
            // col_UserID
            // 
            this.col_UserID.HeaderText = "UserID";
            this.col_UserID.Name = "col_UserID";
            this.col_UserID.Value = 0;
            this.col_UserID.Visible = false;
            // 
            // frmAsignmentJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 569);
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmAsignmentJob";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_Main.ResumeLayout(false);
            this.pnl_UsersList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UsersList)).EndInit();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_UsersList;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Search;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_UsersList;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SearchLastName;
        private DevComponents.DotNetBar.LabelX lbl_SearchLastName;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SearchName;
        private DevComponents.DotNetBar.LabelX lbl_SearchName;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SearchPersonalCode;
        private DevComponents.DotNetBar.LabelX lbl_SearchPersonalCode;
        private DevComponents.DotNetBar.ButtonX btn_Search;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Buttons;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
        private DevComponents.DotNetBar.ButtonX btn_JobsHistory;
        private DevComponents.DotNetBar.Controls.DataGridViewSliderColumn col_FristName;
        private DevComponents.DotNetBar.Controls.DataGridViewSliderColumn col_LastName;
        private DevComponents.DotNetBar.Controls.DataGridViewSliderColumn col_Gender;
        private DevComponents.DotNetBar.Controls.DataGridViewSliderColumn col_PersonalCode;
        private DevComponents.DotNetBar.Controls.DataGridViewSliderColumn col_UserID;
    }
}