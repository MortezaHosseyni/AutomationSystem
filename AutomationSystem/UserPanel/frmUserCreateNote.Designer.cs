namespace AutomationSystem.UserPanel
{
    partial class frmUserCreateNote
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.pnl_CreateNote = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.pnl_Recivers = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.pnl_Search = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.pnl_Send = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_NoteSubject = new DevComponents.DotNetBar.LabelX();
            this.lbl_NoteContext = new DevComponents.DotNetBar.LabelX();
            this.txt_NoteSubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_NoteContext = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_NoteCreateDate = new DevComponents.DotNetBar.LabelX();
            this.val_NoteCreatedDate = new DevComponents.DotNetBar.LabelX();
            this.lbl_InfoOne = new DevComponents.DotNetBar.LabelX();
            this.lbl_SearchFullName = new DevComponents.DotNetBar.LabelX();
            this.txt_SearchFullName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.lbl_InfoTwo = new DevComponents.DotNetBar.LabelX();
            this.btn_SendNote = new DevComponents.DotNetBar.ButtonX();
            this.dgv_Recivers = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_JobUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SelectUser = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_JobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            this.pnl_CreateNote.SuspendLayout();
            this.pnl_Recivers.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            this.pnl_Send.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Recivers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.pnl_Send);
            this.panelEx1.Controls.Add(this.pnl_Search);
            this.panelEx1.Controls.Add(this.pnl_Recivers);
            this.panelEx1.Controls.Add(this.pnl_CreateNote);
            this.panelEx1.Controls.Add(this.lbl_Title);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1050, 610);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // lbl_Title
            // 
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("B Nazanin", 22.25F);
            this.lbl_Title.Location = new System.Drawing.Point(472, 3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(106, 44);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "يادداشت";
            // 
            // pnl_CreateNote
            // 
            this.pnl_CreateNote.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_CreateNote.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_CreateNote.Controls.Add(this.txt_NoteContext);
            this.pnl_CreateNote.Controls.Add(this.txt_NoteSubject);
            this.pnl_CreateNote.Controls.Add(this.lbl_NoteContext);
            this.pnl_CreateNote.Controls.Add(this.val_NoteCreatedDate);
            this.pnl_CreateNote.Controls.Add(this.lbl_InfoOne);
            this.pnl_CreateNote.Controls.Add(this.lbl_NoteCreateDate);
            this.pnl_CreateNote.Controls.Add(this.lbl_NoteSubject);
            this.pnl_CreateNote.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_CreateNote.Location = new System.Drawing.Point(12, 53);
            this.pnl_CreateNote.Name = "pnl_CreateNote";
            this.pnl_CreateNote.Size = new System.Drawing.Size(1026, 219);
            // 
            // 
            // 
            this.pnl_CreateNote.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_CreateNote.Style.BackColorGradientAngle = 90;
            this.pnl_CreateNote.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_CreateNote.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_CreateNote.Style.BorderBottomWidth = 1;
            this.pnl_CreateNote.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_CreateNote.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_CreateNote.Style.BorderLeftWidth = 1;
            this.pnl_CreateNote.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_CreateNote.Style.BorderRightWidth = 1;
            this.pnl_CreateNote.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_CreateNote.Style.BorderTopWidth = 1;
            this.pnl_CreateNote.Style.CornerDiameter = 4;
            this.pnl_CreateNote.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_CreateNote.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_CreateNote.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_CreateNote.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_CreateNote.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_CreateNote.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_CreateNote.TabIndex = 1;
            this.pnl_CreateNote.Text = "ايجاد يادداشت";
            // 
            // pnl_Recivers
            // 
            this.pnl_Recivers.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Recivers.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Recivers.Controls.Add(this.dgv_Recivers);
            this.pnl_Recivers.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Recivers.Location = new System.Drawing.Point(530, 278);
            this.pnl_Recivers.Name = "pnl_Recivers";
            this.pnl_Recivers.Size = new System.Drawing.Size(508, 320);
            // 
            // 
            // 
            this.pnl_Recivers.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Recivers.Style.BackColorGradientAngle = 90;
            this.pnl_Recivers.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Recivers.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Recivers.Style.BorderBottomWidth = 1;
            this.pnl_Recivers.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Recivers.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Recivers.Style.BorderLeftWidth = 1;
            this.pnl_Recivers.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Recivers.Style.BorderRightWidth = 1;
            this.pnl_Recivers.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Recivers.Style.BorderTopWidth = 1;
            this.pnl_Recivers.Style.CornerDiameter = 4;
            this.pnl_Recivers.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_Recivers.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_Recivers.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Recivers.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_Recivers.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_Recivers.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_Recivers.TabIndex = 2;
            this.pnl_Recivers.Text = "كاركنان";
            // 
            // pnl_Search
            // 
            this.pnl_Search.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Search.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Search.Controls.Add(this.buttonX1);
            this.pnl_Search.Controls.Add(this.txt_SearchFullName);
            this.pnl_Search.Controls.Add(this.lbl_SearchFullName);
            this.pnl_Search.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Search.Location = new System.Drawing.Point(12, 278);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(512, 161);
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
            this.pnl_Search.TabIndex = 3;
            this.pnl_Search.Text = "جستجو";
            // 
            // pnl_Send
            // 
            this.pnl_Send.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Send.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Send.Controls.Add(this.btn_SendNote);
            this.pnl_Send.Controls.Add(this.lbl_InfoTwo);
            this.pnl_Send.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Send.Location = new System.Drawing.Point(12, 445);
            this.pnl_Send.Name = "pnl_Send";
            this.pnl_Send.Size = new System.Drawing.Size(512, 153);
            // 
            // 
            // 
            this.pnl_Send.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Send.Style.BackColorGradientAngle = 90;
            this.pnl_Send.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Send.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Send.Style.BorderBottomWidth = 1;
            this.pnl_Send.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Send.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Send.Style.BorderLeftWidth = 1;
            this.pnl_Send.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Send.Style.BorderRightWidth = 1;
            this.pnl_Send.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Send.Style.BorderTopWidth = 1;
            this.pnl_Send.Style.CornerDiameter = 4;
            this.pnl_Send.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_Send.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_Send.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Send.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_Send.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_Send.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_Send.TabIndex = 4;
            // 
            // lbl_NoteSubject
            // 
            // 
            // 
            // 
            this.lbl_NoteSubject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_NoteSubject.Location = new System.Drawing.Point(909, 21);
            this.lbl_NoteSubject.Name = "lbl_NoteSubject";
            this.lbl_NoteSubject.Size = new System.Drawing.Size(44, 25);
            this.lbl_NoteSubject.TabIndex = 0;
            this.lbl_NoteSubject.Text = "موضوع:";
            // 
            // lbl_NoteContext
            // 
            // 
            // 
            // 
            this.lbl_NoteContext.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_NoteContext.Location = new System.Drawing.Point(909, 75);
            this.lbl_NoteContext.Name = "lbl_NoteContext";
            this.lbl_NoteContext.Size = new System.Drawing.Size(29, 25);
            this.lbl_NoteContext.TabIndex = 0;
            this.lbl_NoteContext.Text = "متن:";
            // 
            // txt_NoteSubject
            // 
            this.txt_NoteSubject.BackColor = System.Drawing.Color.Cornsilk;
            // 
            // 
            // 
            this.txt_NoteSubject.Border.Class = "TextBoxBorder";
            this.txt_NoteSubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_NoteSubject.Location = new System.Drawing.Point(582, 15);
            this.txt_NoteSubject.Name = "txt_NoteSubject";
            this.txt_NoteSubject.PreventEnterBeep = true;
            this.txt_NoteSubject.Size = new System.Drawing.Size(321, 36);
            this.txt_NoteSubject.TabIndex = 1;
            this.txt_NoteSubject.WatermarkText = "موضوع نامه را وارد كنيد...";
            // 
            // txt_NoteContext
            // 
            this.txt_NoteContext.BackColor = System.Drawing.Color.Cornsilk;
            // 
            // 
            // 
            this.txt_NoteContext.Border.Class = "TextBoxBorder";
            this.txt_NoteContext.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_NoteContext.Location = new System.Drawing.Point(582, 57);
            this.txt_NoteContext.Multiline = true;
            this.txt_NoteContext.Name = "txt_NoteContext";
            this.txt_NoteContext.PreventEnterBeep = true;
            this.txt_NoteContext.Size = new System.Drawing.Size(321, 101);
            this.txt_NoteContext.TabIndex = 2;
            this.txt_NoteContext.WatermarkText = "متن نامه را وارد كنيد...";
            // 
            // lbl_NoteCreateDate
            // 
            // 
            // 
            // 
            this.lbl_NoteCreateDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_NoteCreateDate.Location = new System.Drawing.Point(345, 21);
            this.lbl_NoteCreateDate.Name = "lbl_NoteCreateDate";
            this.lbl_NoteCreateDate.Size = new System.Drawing.Size(61, 25);
            this.lbl_NoteCreateDate.TabIndex = 0;
            this.lbl_NoteCreateDate.Text = "تاريخ ثبت:";
            // 
            // val_NoteCreatedDate
            // 
            // 
            // 
            // 
            this.val_NoteCreatedDate.BackgroundStyle.BackColor = System.Drawing.Color.Cornsilk;
            this.val_NoteCreatedDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_NoteCreatedDate.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.val_NoteCreatedDate.ForeColor = System.Drawing.Color.Purple;
            this.val_NoteCreatedDate.Location = new System.Drawing.Point(116, 18);
            this.val_NoteCreatedDate.Name = "val_NoteCreatedDate";
            this.val_NoteCreatedDate.Size = new System.Drawing.Size(223, 30);
            this.val_NoteCreatedDate.TabIndex = 0;
            this.val_NoteCreatedDate.Text = "...";
            this.val_NoteCreatedDate.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lbl_InfoOne
            // 
            // 
            // 
            // 
            this.lbl_InfoOne.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_InfoOne.Location = new System.Drawing.Point(28, 84);
            this.lbl_InfoOne.Name = "lbl_InfoOne";
            this.lbl_InfoOne.Size = new System.Drawing.Size(457, 62);
            this.lbl_InfoOne.Symbol = "";
            this.lbl_InfoOne.TabIndex = 0;
            this.lbl_InfoOne.Text = "موضوع و متن يادداشت را بنويسيد، افرادي را كه مي‌خواهيد براي آنها يادداشت ارسال كن" +
    "يد را انتخاب نمائيد.";
            this.lbl_InfoOne.WordWrap = true;
            // 
            // lbl_SearchFullName
            // 
            // 
            // 
            // 
            this.lbl_SearchFullName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SearchFullName.Location = new System.Drawing.Point(376, 45);
            this.lbl_SearchFullName.Name = "lbl_SearchFullName";
            this.lbl_SearchFullName.Size = new System.Drawing.Size(104, 25);
            this.lbl_SearchFullName.TabIndex = 0;
            this.lbl_SearchFullName.Text = "نام و نام‌خانوادگي:";
            // 
            // txt_SearchFullName
            // 
            this.txt_SearchFullName.BackColor = System.Drawing.Color.Cornsilk;
            // 
            // 
            // 
            this.txt_SearchFullName.Border.Class = "TextBoxBorder";
            this.txt_SearchFullName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SearchFullName.Location = new System.Drawing.Point(84, 39);
            this.txt_SearchFullName.Name = "txt_SearchFullName";
            this.txt_SearchFullName.PreventEnterBeep = true;
            this.txt_SearchFullName.Size = new System.Drawing.Size(286, 36);
            this.txt_SearchFullName.TabIndex = 3;
            this.txt_SearchFullName.WatermarkText = "جستجوي در نام كاركنان...";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(26, 39);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(52, 36);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.TabIndex = 2;
            // 
            // lbl_InfoTwo
            // 
            // 
            // 
            // 
            this.lbl_InfoTwo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_InfoTwo.Location = new System.Drawing.Point(17, 3);
            this.lbl_InfoTwo.Name = "lbl_InfoTwo";
            this.lbl_InfoTwo.Size = new System.Drawing.Size(468, 75);
            this.lbl_InfoTwo.Symbol = "";
            this.lbl_InfoTwo.TabIndex = 0;
            this.lbl_InfoTwo.Text = "توجه: يادداشت يك نامه غيررسمي محسوب مي‌شود و شامل امكانات نامه مثل شماره نامه، پي" +
    "گيري، پيوست، بايگاني، طبقه بندي، فوريت و.. نمي‌باشد.";
            this.lbl_InfoTwo.WordWrap = true;
            // 
            // btn_SendNote
            // 
            this.btn_SendNote.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SendNote.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_SendNote.Location = new System.Drawing.Point(116, 84);
            this.btn_SendNote.Name = "btn_SendNote";
            this.btn_SendNote.Size = new System.Drawing.Size(266, 51);
            this.btn_SendNote.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_SendNote.Symbol = "";
            this.btn_SendNote.TabIndex = 4;
            this.btn_SendNote.Text = "ارسال يادداشت";
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Recivers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Recivers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_Recivers.Location = new System.Drawing.Point(3, 3);
            this.dgv_Recivers.Name = "dgv_Recivers";
            this.dgv_Recivers.Size = new System.Drawing.Size(496, 277);
            this.dgv_Recivers.TabIndex = 1;
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
            // frmUserCreateNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmUserCreateNote";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUserCreateNote_Load);
            this.panelEx1.ResumeLayout(false);
            this.pnl_CreateNote.ResumeLayout(false);
            this.pnl_Recivers.ResumeLayout(false);
            this.pnl_Search.ResumeLayout(false);
            this.pnl_Send.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Recivers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Send;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Search;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Recivers;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_CreateNote;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_NoteContext;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_NoteSubject;
        private DevComponents.DotNetBar.LabelX lbl_NoteContext;
        private DevComponents.DotNetBar.LabelX lbl_NoteSubject;
        private DevComponents.DotNetBar.LabelX val_NoteCreatedDate;
        private DevComponents.DotNetBar.LabelX lbl_NoteCreateDate;
        private DevComponents.DotNetBar.LabelX lbl_InfoOne;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SearchFullName;
        private DevComponents.DotNetBar.LabelX lbl_SearchFullName;
        private DevComponents.DotNetBar.LabelX lbl_InfoTwo;
        private DevComponents.DotNetBar.ButtonX btn_SendNote;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_Recivers;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_JobUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_UserID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_SelectUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_JobName;
    }
}