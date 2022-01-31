namespace AutomationSystem.UserPanel
{
    partial class frmUserDraft
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
            this.pnl_DraftList = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.pnl_Search = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.pnl_Buttons = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_SendLetter = new DevComponents.DotNetBar.ButtonX();
            this.btn_DeleteLetter = new DevComponents.DotNetBar.ButtonX();
            this.lbl_SearchSubject = new DevComponents.DotNetBar.LabelX();
            this.txt_SearchSubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_SearchLetterForcedType = new DevComponents.DotNetBar.LabelX();
            this.pnl_SearchLetterForcedType = new System.Windows.Forms.Panel();
            this.rdb_SearchAllForced = new System.Windows.Forms.RadioButton();
            this.rdb_SearchNormalForced = new System.Windows.Forms.RadioButton();
            this.rdb_SearchImmediateForced = new System.Windows.Forms.RadioButton();
            this.rdb_SearchPosthasteForced = new System.Windows.Forms.RadioButton();
            this.lbl_SearchLetterSecurityType = new DevComponents.DotNetBar.LabelX();
            this.pnl_SearchLetterSecurityType = new System.Windows.Forms.Panel();
            this.rdb_SearchSecretiveSecurity = new System.Windows.Forms.RadioButton();
            this.rdb_SearchConfidentialSecurity = new System.Windows.Forms.RadioButton();
            this.rdb_SearchNormalSecurity = new System.Windows.Forms.RadioButton();
            this.rdb_SearchAllSecurity = new System.Windows.Forms.RadioButton();
            this.btn_Search = new DevComponents.DotNetBar.ButtonX();
            this.dgv_DraftList = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.pnl_Main.SuspendLayout();
            this.pnl_DraftList.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            this.pnl_Buttons.SuspendLayout();
            this.pnl_SearchLetterForcedType.SuspendLayout();
            this.pnl_SearchLetterSecurityType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DraftList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.pnl_Buttons);
            this.pnl_Main.Controls.Add(this.pnl_Search);
            this.pnl_Main.Controls.Add(this.pnl_DraftList);
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
            // lbl_Title
            // 
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("B Nazanin", 22.25F);
            this.lbl_Title.Location = new System.Drawing.Point(438, 3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(150, 44);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "پيش نويس‌ها";
            // 
            // pnl_DraftList
            // 
            this.pnl_DraftList.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_DraftList.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_DraftList.Controls.Add(this.dgv_DraftList);
            this.pnl_DraftList.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_DraftList.Location = new System.Drawing.Point(12, 62);
            this.pnl_DraftList.Name = "pnl_DraftList";
            this.pnl_DraftList.Size = new System.Drawing.Size(1026, 296);
            // 
            // 
            // 
            this.pnl_DraftList.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_DraftList.Style.BackColorGradientAngle = 90;
            this.pnl_DraftList.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_DraftList.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_DraftList.Style.BorderBottomWidth = 1;
            this.pnl_DraftList.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_DraftList.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_DraftList.Style.BorderLeftWidth = 1;
            this.pnl_DraftList.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_DraftList.Style.BorderRightWidth = 1;
            this.pnl_DraftList.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_DraftList.Style.BorderTopWidth = 1;
            this.pnl_DraftList.Style.CornerDiameter = 4;
            this.pnl_DraftList.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_DraftList.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_DraftList.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_DraftList.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_DraftList.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_DraftList.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_DraftList.TabIndex = 5;
            // 
            // pnl_Search
            // 
            this.pnl_Search.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Search.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Search.Controls.Add(this.btn_Search);
            this.pnl_Search.Controls.Add(this.pnl_SearchLetterSecurityType);
            this.pnl_Search.Controls.Add(this.pnl_SearchLetterForcedType);
            this.pnl_Search.Controls.Add(this.lbl_SearchLetterSecurityType);
            this.pnl_Search.Controls.Add(this.txt_SearchSubject);
            this.pnl_Search.Controls.Add(this.lbl_SearchLetterForcedType);
            this.pnl_Search.Controls.Add(this.lbl_SearchSubject);
            this.pnl_Search.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Search.Location = new System.Drawing.Point(12, 364);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(1026, 154);
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
            this.pnl_Search.TabIndex = 6;
            this.pnl_Search.Text = "جستجو";
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Buttons.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Buttons.Controls.Add(this.btn_DeleteLetter);
            this.pnl_Buttons.Controls.Add(this.btn_SendLetter);
            this.pnl_Buttons.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Buttons.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pnl_Buttons.Location = new System.Drawing.Point(12, 524);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(1026, 74);
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
            this.pnl_Buttons.TabIndex = 7;
            // 
            // btn_SendLetter
            // 
            this.btn_SendLetter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SendLetter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_SendLetter.Location = new System.Drawing.Point(519, 3);
            this.btn_SendLetter.Name = "btn_SendLetter";
            this.btn_SendLetter.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 2, 20, 20);
            this.btn_SendLetter.Size = new System.Drawing.Size(232, 62);
            this.btn_SendLetter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_SendLetter.Symbol = "";
            this.btn_SendLetter.TabIndex = 0;
            this.btn_SendLetter.Text = "ارسال نامه";
            // 
            // btn_DeleteLetter
            // 
            this.btn_DeleteLetter.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_DeleteLetter.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_DeleteLetter.Location = new System.Drawing.Point(281, 3);
            this.btn_DeleteLetter.Name = "btn_DeleteLetter";
            this.btn_DeleteLetter.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 2, 20, 20);
            this.btn_DeleteLetter.Size = new System.Drawing.Size(232, 62);
            this.btn_DeleteLetter.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_DeleteLetter.Symbol = "";
            this.btn_DeleteLetter.TabIndex = 0;
            this.btn_DeleteLetter.Text = "حذف از پيش‌نويس";
            // 
            // lbl_SearchSubject
            // 
            // 
            // 
            // 
            this.lbl_SearchSubject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SearchSubject.Location = new System.Drawing.Point(910, 39);
            this.lbl_SearchSubject.Name = "lbl_SearchSubject";
            this.lbl_SearchSubject.Size = new System.Drawing.Size(71, 29);
            this.lbl_SearchSubject.TabIndex = 0;
            this.lbl_SearchSubject.Text = "موضوع نامه:";
            // 
            // txt_SearchSubject
            // 
            // 
            // 
            // 
            this.txt_SearchSubject.Border.Class = "TextBoxBorder";
            this.txt_SearchSubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SearchSubject.Location = new System.Drawing.Point(690, 34);
            this.txt_SearchSubject.Name = "txt_SearchSubject";
            this.txt_SearchSubject.PreventEnterBeep = true;
            this.txt_SearchSubject.Size = new System.Drawing.Size(214, 36);
            this.txt_SearchSubject.TabIndex = 1;
            this.txt_SearchSubject.WatermarkText = "جستجو در موضوعات...";
            // 
            // lbl_SearchLetterForcedType
            // 
            // 
            // 
            // 
            this.lbl_SearchLetterForcedType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SearchLetterForcedType.Location = new System.Drawing.Point(618, 39);
            this.lbl_SearchLetterForcedType.Name = "lbl_SearchLetterForcedType";
            this.lbl_SearchLetterForcedType.Size = new System.Drawing.Size(66, 29);
            this.lbl_SearchLetterForcedType.TabIndex = 0;
            this.lbl_SearchLetterForcedType.Text = "فوريت نامه:";
            // 
            // pnl_SearchLetterForcedType
            // 
            this.pnl_SearchLetterForcedType.Controls.Add(this.rdb_SearchPosthasteForced);
            this.pnl_SearchLetterForcedType.Controls.Add(this.rdb_SearchImmediateForced);
            this.pnl_SearchLetterForcedType.Controls.Add(this.rdb_SearchNormalForced);
            this.pnl_SearchLetterForcedType.Controls.Add(this.rdb_SearchAllForced);
            this.pnl_SearchLetterForcedType.Location = new System.Drawing.Point(451, 7);
            this.pnl_SearchLetterForcedType.Name = "pnl_SearchLetterForcedType";
            this.pnl_SearchLetterForcedType.Size = new System.Drawing.Size(161, 98);
            this.pnl_SearchLetterForcedType.TabIndex = 2;
            // 
            // rdb_SearchAllForced
            // 
            this.rdb_SearchAllForced.AutoSize = true;
            this.rdb_SearchAllForced.Location = new System.Drawing.Point(96, 3);
            this.rdb_SearchAllForced.Name = "rdb_SearchAllForced";
            this.rdb_SearchAllForced.Size = new System.Drawing.Size(55, 32);
            this.rdb_SearchAllForced.TabIndex = 0;
            this.rdb_SearchAllForced.TabStop = true;
            this.rdb_SearchAllForced.Text = "همه";
            this.rdb_SearchAllForced.UseVisualStyleBackColor = true;
            // 
            // rdb_SearchNormalForced
            // 
            this.rdb_SearchNormalForced.AutoSize = true;
            this.rdb_SearchNormalForced.Location = new System.Drawing.Point(5, 3);
            this.rdb_SearchNormalForced.Name = "rdb_SearchNormalForced";
            this.rdb_SearchNormalForced.Size = new System.Drawing.Size(60, 32);
            this.rdb_SearchNormalForced.TabIndex = 0;
            this.rdb_SearchNormalForced.TabStop = true;
            this.rdb_SearchNormalForced.Text = "عادي";
            this.rdb_SearchNormalForced.UseVisualStyleBackColor = true;
            // 
            // rdb_SearchImmediateForced
            // 
            this.rdb_SearchImmediateForced.AutoSize = true;
            this.rdb_SearchImmediateForced.Location = new System.Drawing.Point(91, 59);
            this.rdb_SearchImmediateForced.Name = "rdb_SearchImmediateForced";
            this.rdb_SearchImmediateForced.Size = new System.Drawing.Size(60, 32);
            this.rdb_SearchImmediateForced.TabIndex = 0;
            this.rdb_SearchImmediateForced.TabStop = true;
            this.rdb_SearchImmediateForced.Text = "فوري";
            this.rdb_SearchImmediateForced.UseVisualStyleBackColor = true;
            // 
            // rdb_SearchPosthasteForced
            // 
            this.rdb_SearchPosthasteForced.AutoSize = true;
            this.rdb_SearchPosthasteForced.Location = new System.Drawing.Point(15, 59);
            this.rdb_SearchPosthasteForced.Name = "rdb_SearchPosthasteForced";
            this.rdb_SearchPosthasteForced.Size = new System.Drawing.Size(50, 32);
            this.rdb_SearchPosthasteForced.TabIndex = 0;
            this.rdb_SearchPosthasteForced.TabStop = true;
            this.rdb_SearchPosthasteForced.Text = "آني";
            this.rdb_SearchPosthasteForced.UseVisualStyleBackColor = true;
            // 
            // lbl_SearchLetterSecurityType
            // 
            // 
            // 
            // 
            this.lbl_SearchLetterSecurityType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SearchLetterSecurityType.Location = new System.Drawing.Point(336, 39);
            this.lbl_SearchLetterSecurityType.Name = "lbl_SearchLetterSecurityType";
            this.lbl_SearchLetterSecurityType.Size = new System.Drawing.Size(94, 29);
            this.lbl_SearchLetterSecurityType.TabIndex = 0;
            this.lbl_SearchLetterSecurityType.Text = "طبقه بندي نامه:";
            // 
            // pnl_SearchLetterSecurityType
            // 
            this.pnl_SearchLetterSecurityType.Controls.Add(this.rdb_SearchSecretiveSecurity);
            this.pnl_SearchLetterSecurityType.Controls.Add(this.rdb_SearchConfidentialSecurity);
            this.pnl_SearchLetterSecurityType.Controls.Add(this.rdb_SearchNormalSecurity);
            this.pnl_SearchLetterSecurityType.Controls.Add(this.rdb_SearchAllSecurity);
            this.pnl_SearchLetterSecurityType.Location = new System.Drawing.Point(169, 7);
            this.pnl_SearchLetterSecurityType.Name = "pnl_SearchLetterSecurityType";
            this.pnl_SearchLetterSecurityType.Size = new System.Drawing.Size(161, 98);
            this.pnl_SearchLetterSecurityType.TabIndex = 2;
            // 
            // rdb_SearchSecretiveSecurity
            // 
            this.rdb_SearchSecretiveSecurity.AutoSize = true;
            this.rdb_SearchSecretiveSecurity.Location = new System.Drawing.Point(6, 59);
            this.rdb_SearchSecretiveSecurity.Name = "rdb_SearchSecretiveSecurity";
            this.rdb_SearchSecretiveSecurity.Size = new System.Drawing.Size(59, 32);
            this.rdb_SearchSecretiveSecurity.TabIndex = 0;
            this.rdb_SearchSecretiveSecurity.TabStop = true;
            this.rdb_SearchSecretiveSecurity.Text = "سري";
            this.rdb_SearchSecretiveSecurity.UseVisualStyleBackColor = true;
            // 
            // rdb_SearchConfidentialSecurity
            // 
            this.rdb_SearchConfidentialSecurity.AutoSize = true;
            this.rdb_SearchConfidentialSecurity.Location = new System.Drawing.Point(77, 59);
            this.rdb_SearchConfidentialSecurity.Name = "rdb_SearchConfidentialSecurity";
            this.rdb_SearchConfidentialSecurity.Size = new System.Drawing.Size(74, 32);
            this.rdb_SearchConfidentialSecurity.TabIndex = 0;
            this.rdb_SearchConfidentialSecurity.TabStop = true;
            this.rdb_SearchConfidentialSecurity.Text = "محرمانه";
            this.rdb_SearchConfidentialSecurity.UseVisualStyleBackColor = true;
            // 
            // rdb_SearchNormalSecurity
            // 
            this.rdb_SearchNormalSecurity.AutoSize = true;
            this.rdb_SearchNormalSecurity.Location = new System.Drawing.Point(5, 3);
            this.rdb_SearchNormalSecurity.Name = "rdb_SearchNormalSecurity";
            this.rdb_SearchNormalSecurity.Size = new System.Drawing.Size(60, 32);
            this.rdb_SearchNormalSecurity.TabIndex = 0;
            this.rdb_SearchNormalSecurity.TabStop = true;
            this.rdb_SearchNormalSecurity.Text = "عادي";
            this.rdb_SearchNormalSecurity.UseVisualStyleBackColor = true;
            // 
            // rdb_SearchAllSecurity
            // 
            this.rdb_SearchAllSecurity.AutoSize = true;
            this.rdb_SearchAllSecurity.Location = new System.Drawing.Point(96, 3);
            this.rdb_SearchAllSecurity.Name = "rdb_SearchAllSecurity";
            this.rdb_SearchAllSecurity.Size = new System.Drawing.Size(55, 32);
            this.rdb_SearchAllSecurity.TabIndex = 0;
            this.rdb_SearchAllSecurity.TabStop = true;
            this.rdb_SearchAllSecurity.Text = "همه";
            this.rdb_SearchAllSecurity.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Search.Location = new System.Drawing.Point(43, 14);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(103, 87);
            this.btn_Search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Search.Symbol = "";
            this.btn_Search.TabIndex = 3;
            // 
            // dgv_DraftList
            // 
            this.dgv_DraftList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DraftList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DraftList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_DraftList.Location = new System.Drawing.Point(3, 3);
            this.dgv_DraftList.Name = "dgv_DraftList";
            this.dgv_DraftList.Size = new System.Drawing.Size(1014, 284);
            this.dgv_DraftList.TabIndex = 0;
            // 
            // frmUserDraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmUserDraft";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.pnl_Main.ResumeLayout(false);
            this.pnl_DraftList.ResumeLayout(false);
            this.pnl_Search.ResumeLayout(false);
            this.pnl_Buttons.ResumeLayout(false);
            this.pnl_SearchLetterForcedType.ResumeLayout(false);
            this.pnl_SearchLetterForcedType.PerformLayout();
            this.pnl_SearchLetterSecurityType.ResumeLayout(false);
            this.pnl_SearchLetterSecurityType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DraftList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_DraftList;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Search;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Buttons;
        private DevComponents.DotNetBar.ButtonX btn_DeleteLetter;
        private DevComponents.DotNetBar.ButtonX btn_SendLetter;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SearchSubject;
        private DevComponents.DotNetBar.LabelX lbl_SearchLetterForcedType;
        private DevComponents.DotNetBar.LabelX lbl_SearchSubject;
        private System.Windows.Forms.Panel pnl_SearchLetterForcedType;
        private System.Windows.Forms.RadioButton rdb_SearchPosthasteForced;
        private System.Windows.Forms.RadioButton rdb_SearchImmediateForced;
        private System.Windows.Forms.RadioButton rdb_SearchNormalForced;
        private System.Windows.Forms.RadioButton rdb_SearchAllForced;
        private System.Windows.Forms.Panel pnl_SearchLetterSecurityType;
        private System.Windows.Forms.RadioButton rdb_SearchSecretiveSecurity;
        private System.Windows.Forms.RadioButton rdb_SearchConfidentialSecurity;
        private System.Windows.Forms.RadioButton rdb_SearchNormalSecurity;
        private System.Windows.Forms.RadioButton rdb_SearchAllSecurity;
        private DevComponents.DotNetBar.LabelX lbl_SearchLetterSecurityType;
        private DevComponents.DotNetBar.ButtonX btn_Search;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_DraftList;
    }
}