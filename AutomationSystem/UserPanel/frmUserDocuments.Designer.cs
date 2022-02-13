namespace AutomationSystem.UserPanel
{
    partial class frmUserDocuments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserDocuments));
            this.pnl_Main = new DevComponents.DotNetBar.PanelEx();
            this.pnl_NewDocument = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.val_DocFilePath = new DevComponents.DotNetBar.LabelX();
            this.btn_SaveDoc = new DevComponents.DotNetBar.ButtonX();
            this.btn_DocAttachFile = new DevComponents.DotNetBar.ButtonX();
            this.lbl_AttachFile = new DevComponents.DotNetBar.LabelX();
            this.txt_DocCaption = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_DocExporter = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_DocDeliver = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_DocSubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_Caption = new DevComponents.DotNetBar.LabelX();
            this.lbl_Exporter = new DevComponents.DotNetBar.LabelX();
            this.val_DocSaveDate = new DevComponents.DotNetBar.LabelX();
            this.lbl_AddDate = new DevComponents.DotNetBar.LabelX();
            this.lbl_Deliver = new DevComponents.DotNetBar.LabelX();
            this.lbl_Subject = new DevComponents.DotNetBar.LabelX();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pnl_SavedDocuments = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv_SavedDocuments = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.saveAttachFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.col_DocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DocSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DocCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DocExporter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DocDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DocDeliveryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DocAttachFile = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pnl_Search = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txt_DateTo = new FreeControls.PersianDateTimePicker();
            this.txt_DateIn = new FreeControls.PersianDateTimePicker();
            this.lbl_DateTo = new DevComponents.DotNetBar.LabelX();
            this.lbl_DateIn = new DevComponents.DotNetBar.LabelX();
            this.lbl_SearchSubject = new DevComponents.DotNetBar.LabelX();
            this.lbl_SearchExporter = new DevComponents.DotNetBar.LabelX();
            this.lbl_SearchDeliver = new DevComponents.DotNetBar.LabelX();
            this.txt_SearchDocSubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_SearchDocExporter = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_SearchDocDeliver = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_Search = new DevComponents.DotNetBar.ButtonX();
            this.pnl_Main.SuspendLayout();
            this.pnl_NewDocument.SuspendLayout();
            this.pnl_SavedDocuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SavedDocuments)).BeginInit();
            this.pnl_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.pnl_Search);
            this.pnl_Main.Controls.Add(this.pnl_SavedDocuments);
            this.pnl_Main.Controls.Add(this.pnl_NewDocument);
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
            // pnl_NewDocument
            // 
            this.pnl_NewDocument.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_NewDocument.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_NewDocument.Controls.Add(this.val_DocFilePath);
            this.pnl_NewDocument.Controls.Add(this.btn_SaveDoc);
            this.pnl_NewDocument.Controls.Add(this.btn_DocAttachFile);
            this.pnl_NewDocument.Controls.Add(this.lbl_AttachFile);
            this.pnl_NewDocument.Controls.Add(this.txt_DocCaption);
            this.pnl_NewDocument.Controls.Add(this.txt_DocExporter);
            this.pnl_NewDocument.Controls.Add(this.txt_DocDeliver);
            this.pnl_NewDocument.Controls.Add(this.txt_DocSubject);
            this.pnl_NewDocument.Controls.Add(this.lbl_Caption);
            this.pnl_NewDocument.Controls.Add(this.lbl_Exporter);
            this.pnl_NewDocument.Controls.Add(this.val_DocSaveDate);
            this.pnl_NewDocument.Controls.Add(this.lbl_AddDate);
            this.pnl_NewDocument.Controls.Add(this.lbl_Deliver);
            this.pnl_NewDocument.Controls.Add(this.lbl_Subject);
            this.pnl_NewDocument.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_NewDocument.Location = new System.Drawing.Point(12, 57);
            this.pnl_NewDocument.Name = "pnl_NewDocument";
            this.pnl_NewDocument.Size = new System.Drawing.Size(1026, 236);
            // 
            // 
            // 
            this.pnl_NewDocument.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_NewDocument.Style.BackColorGradientAngle = 90;
            this.pnl_NewDocument.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_NewDocument.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_NewDocument.Style.BorderBottomWidth = 1;
            this.pnl_NewDocument.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_NewDocument.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_NewDocument.Style.BorderLeftWidth = 1;
            this.pnl_NewDocument.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_NewDocument.Style.BorderRightWidth = 1;
            this.pnl_NewDocument.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_NewDocument.Style.BorderTopWidth = 1;
            this.pnl_NewDocument.Style.CornerDiameter = 4;
            this.pnl_NewDocument.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_NewDocument.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_NewDocument.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_NewDocument.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_NewDocument.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_NewDocument.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_NewDocument.TabIndex = 1;
            this.pnl_NewDocument.Text = "ثبت سند";
            // 
            // val_DocFilePath
            // 
            this.val_DocFilePath.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.val_DocFilePath.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_DocFilePath.Font = new System.Drawing.Font("B Nazanin", 9.25F);
            this.val_DocFilePath.Location = new System.Drawing.Point(3, 91);
            this.val_DocFilePath.Name = "val_DocFilePath";
            this.val_DocFilePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.val_DocFilePath.Size = new System.Drawing.Size(468, 49);
            this.val_DocFilePath.TabIndex = 7;
            this.val_DocFilePath.WordWrap = true;
            // 
            // btn_SaveDoc
            // 
            this.btn_SaveDoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SaveDoc.BackColor = System.Drawing.Color.Transparent;
            this.btn_SaveDoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_SaveDoc.Location = new System.Drawing.Point(3, 146);
            this.btn_SaveDoc.Name = "btn_SaveDoc";
            this.btn_SaveDoc.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btn_SaveDoc.Size = new System.Drawing.Size(468, 49);
            this.btn_SaveDoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_SaveDoc.Symbol = "";
            this.btn_SaveDoc.TabIndex = 7;
            this.btn_SaveDoc.Text = "ثبت سند";
            this.btn_SaveDoc.Click += new System.EventHandler(this.btn_SaveDoc_Click);
            // 
            // btn_DocAttachFile
            // 
            this.btn_DocAttachFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_DocAttachFile.BackColor = System.Drawing.Color.Transparent;
            this.btn_DocAttachFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_DocAttachFile.Location = new System.Drawing.Point(3, 48);
            this.btn_DocAttachFile.Name = "btn_DocAttachFile";
            this.btn_DocAttachFile.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btn_DocAttachFile.Size = new System.Drawing.Size(468, 37);
            this.btn_DocAttachFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_DocAttachFile.Symbol = "";
            this.btn_DocAttachFile.TabIndex = 6;
            this.btn_DocAttachFile.Text = "انتخاب فايل";
            this.btn_DocAttachFile.Click += new System.EventHandler(this.btn_DocAttachFile_Click);
            // 
            // lbl_AttachFile
            // 
            this.lbl_AttachFile.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_AttachFile.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_AttachFile.Location = new System.Drawing.Point(477, 49);
            this.lbl_AttachFile.Name = "lbl_AttachFile";
            this.lbl_AttachFile.Size = new System.Drawing.Size(67, 32);
            this.lbl_AttachFile.TabIndex = 5;
            this.lbl_AttachFile.Text = "الصاق فايل:";
            // 
            // txt_DocCaption
            // 
            // 
            // 
            // 
            this.txt_DocCaption.Border.Class = "TextBoxBorder";
            this.txt_DocCaption.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_DocCaption.Location = new System.Drawing.Point(568, 87);
            this.txt_DocCaption.Multiline = true;
            this.txt_DocCaption.Name = "txt_DocCaption";
            this.txt_DocCaption.PreventEnterBeep = true;
            this.txt_DocCaption.Size = new System.Drawing.Size(357, 108);
            this.txt_DocCaption.TabIndex = 3;
            this.txt_DocCaption.WatermarkText = "توضيحات سند...";
            // 
            // txt_DocExporter
            // 
            // 
            // 
            // 
            this.txt_DocExporter.Border.Class = "TextBoxBorder";
            this.txt_DocExporter.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_DocExporter.Location = new System.Drawing.Point(568, 45);
            this.txt_DocExporter.Name = "txt_DocExporter";
            this.txt_DocExporter.PreventEnterBeep = true;
            this.txt_DocExporter.Size = new System.Drawing.Size(357, 36);
            this.txt_DocExporter.TabIndex = 2;
            this.txt_DocExporter.WatermarkText = "صادر كننده سند...";
            // 
            // txt_DocDeliver
            // 
            // 
            // 
            // 
            this.txt_DocDeliver.Border.Class = "TextBoxBorder";
            this.txt_DocDeliver.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_DocDeliver.Location = new System.Drawing.Point(242, 6);
            this.txt_DocDeliver.Name = "txt_DocDeliver";
            this.txt_DocDeliver.PreventEnterBeep = true;
            this.txt_DocDeliver.Size = new System.Drawing.Size(229, 36);
            this.txt_DocDeliver.TabIndex = 4;
            this.txt_DocDeliver.WatermarkText = "تحويل دهنده سند...";
            // 
            // txt_DocSubject
            // 
            // 
            // 
            // 
            this.txt_DocSubject.Border.Class = "TextBoxBorder";
            this.txt_DocSubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_DocSubject.Location = new System.Drawing.Point(568, 3);
            this.txt_DocSubject.Name = "txt_DocSubject";
            this.txt_DocSubject.PreventEnterBeep = true;
            this.txt_DocSubject.Size = new System.Drawing.Size(357, 36);
            this.txt_DocSubject.TabIndex = 1;
            this.txt_DocSubject.WatermarkText = "موضوع سند...";
            // 
            // lbl_Caption
            // 
            this.lbl_Caption.AutoSize = true;
            // 
            // 
            // 
            this.lbl_Caption.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Caption.Location = new System.Drawing.Point(931, 91);
            this.lbl_Caption.Name = "lbl_Caption";
            this.lbl_Caption.Size = new System.Drawing.Size(61, 33);
            this.lbl_Caption.TabIndex = 0;
            this.lbl_Caption.Text = "توضيحات:";
            // 
            // lbl_Exporter
            // 
            this.lbl_Exporter.AutoSize = true;
            // 
            // 
            // 
            this.lbl_Exporter.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Exporter.Location = new System.Drawing.Point(931, 48);
            this.lbl_Exporter.Name = "lbl_Exporter";
            this.lbl_Exporter.Size = new System.Drawing.Size(66, 33);
            this.lbl_Exporter.TabIndex = 0;
            this.lbl_Exporter.Text = "صادر كنند:";
            // 
            // val_DocSaveDate
            // 
            this.val_DocSaveDate.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.val_DocSaveDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_DocSaveDate.Location = new System.Drawing.Point(3, 6);
            this.val_DocSaveDate.Name = "val_DocSaveDate";
            this.val_DocSaveDate.Size = new System.Drawing.Size(164, 33);
            this.val_DocSaveDate.TabIndex = 5;
            this.val_DocSaveDate.Text = "...";
            this.val_DocSaveDate.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lbl_AddDate
            // 
            this.lbl_AddDate.AutoSize = true;
            // 
            // 
            // 
            this.lbl_AddDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_AddDate.Location = new System.Drawing.Point(173, 6);
            this.lbl_AddDate.Name = "lbl_AddDate";
            this.lbl_AddDate.Size = new System.Drawing.Size(63, 33);
            this.lbl_AddDate.TabIndex = 0;
            this.lbl_AddDate.Text = "تاريخ ثبت:";
            // 
            // lbl_Deliver
            // 
            this.lbl_Deliver.AutoSize = true;
            // 
            // 
            // 
            this.lbl_Deliver.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Deliver.Location = new System.Drawing.Point(477, 6);
            this.lbl_Deliver.Name = "lbl_Deliver";
            this.lbl_Deliver.Size = new System.Drawing.Size(83, 33);
            this.lbl_Deliver.TabIndex = 0;
            this.lbl_Deliver.Text = "تحويل دهنده:";
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            // 
            // 
            // 
            this.lbl_Subject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Subject.Location = new System.Drawing.Point(931, 6);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(45, 33);
            this.lbl_Subject.TabIndex = 0;
            this.lbl_Subject.Text = "موضوع:";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("B Nazanin", 22.25F);
            this.lbl_Title.Location = new System.Drawing.Point(361, 3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(298, 48);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "اسناد و نامه‌هاي خارج سازمان";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // pnl_SavedDocuments
            // 
            this.pnl_SavedDocuments.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_SavedDocuments.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_SavedDocuments.Controls.Add(this.dgv_SavedDocuments);
            this.pnl_SavedDocuments.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_SavedDocuments.Location = new System.Drawing.Point(12, 299);
            this.pnl_SavedDocuments.Name = "pnl_SavedDocuments";
            this.pnl_SavedDocuments.Size = new System.Drawing.Size(1026, 195);
            // 
            // 
            // 
            this.pnl_SavedDocuments.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_SavedDocuments.Style.BackColorGradientAngle = 90;
            this.pnl_SavedDocuments.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_SavedDocuments.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SavedDocuments.Style.BorderBottomWidth = 1;
            this.pnl_SavedDocuments.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_SavedDocuments.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SavedDocuments.Style.BorderLeftWidth = 1;
            this.pnl_SavedDocuments.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SavedDocuments.Style.BorderRightWidth = 1;
            this.pnl_SavedDocuments.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SavedDocuments.Style.BorderTopWidth = 1;
            this.pnl_SavedDocuments.Style.CornerDiameter = 4;
            this.pnl_SavedDocuments.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_SavedDocuments.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_SavedDocuments.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_SavedDocuments.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_SavedDocuments.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_SavedDocuments.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_SavedDocuments.TabIndex = 2;
            // 
            // dgv_SavedDocuments
            // 
            this.dgv_SavedDocuments.AllowUserToAddRows = false;
            this.dgv_SavedDocuments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_SavedDocuments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SavedDocuments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_SavedDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SavedDocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_DocID,
            this.col_DocSubject,
            this.col_DocCaption,
            this.col_DocExporter,
            this.col_DocDate,
            this.col_DocDeliveryName,
            this.col_DocAttachFile});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SavedDocuments.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_SavedDocuments.EnableHeadersVisualStyles = false;
            this.dgv_SavedDocuments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(181)))), ((int)(((byte)(252)))));
            this.dgv_SavedDocuments.Location = new System.Drawing.Point(3, 3);
            this.dgv_SavedDocuments.Name = "dgv_SavedDocuments";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SavedDocuments.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_SavedDocuments.Size = new System.Drawing.Size(1014, 183);
            this.dgv_SavedDocuments.TabIndex = 0;
            this.dgv_SavedDocuments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SavedDocuments_CellClick);
            // 
            // col_DocID
            // 
            this.col_DocID.HeaderText = "DocID";
            this.col_DocID.Name = "col_DocID";
            this.col_DocID.Visible = false;
            // 
            // col_DocSubject
            // 
            this.col_DocSubject.HeaderText = "موضوع";
            this.col_DocSubject.Name = "col_DocSubject";
            this.col_DocSubject.Width = 200;
            // 
            // col_DocCaption
            // 
            this.col_DocCaption.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_DocCaption.HeaderText = "توضيحات";
            this.col_DocCaption.Name = "col_DocCaption";
            // 
            // col_DocExporter
            // 
            this.col_DocExporter.HeaderText = "صادر كننده";
            this.col_DocExporter.Name = "col_DocExporter";
            this.col_DocExporter.Width = 130;
            // 
            // col_DocDate
            // 
            this.col_DocDate.HeaderText = "تاريخ ثبت";
            this.col_DocDate.Name = "col_DocDate";
            this.col_DocDate.Width = 120;
            // 
            // col_DocDeliveryName
            // 
            this.col_DocDeliveryName.HeaderText = "تحويل دهنده";
            this.col_DocDeliveryName.Name = "col_DocDeliveryName";
            this.col_DocDeliveryName.Width = 120;
            // 
            // col_DocAttachFile
            // 
            this.col_DocAttachFile.HeaderText = "فايل الصاقي";
            this.col_DocAttachFile.Name = "col_DocAttachFile";
            this.col_DocAttachFile.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_DocAttachFile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_DocAttachFile.Width = 115;
            // 
            // pnl_Search
            // 
            this.pnl_Search.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Search.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Search.Controls.Add(this.btn_Search);
            this.pnl_Search.Controls.Add(this.txt_SearchDocDeliver);
            this.pnl_Search.Controls.Add(this.txt_SearchDocExporter);
            this.pnl_Search.Controls.Add(this.txt_SearchDocSubject);
            this.pnl_Search.Controls.Add(this.txt_DateTo);
            this.pnl_Search.Controls.Add(this.txt_DateIn);
            this.pnl_Search.Controls.Add(this.lbl_DateTo);
            this.pnl_Search.Controls.Add(this.lbl_SearchDeliver);
            this.pnl_Search.Controls.Add(this.lbl_SearchExporter);
            this.pnl_Search.Controls.Add(this.lbl_SearchSubject);
            this.pnl_Search.Controls.Add(this.lbl_DateIn);
            this.pnl_Search.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Search.Location = new System.Drawing.Point(12, 500);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(1026, 98);
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
            // 
            // txt_DateTo
            // 
            this.txt_DateTo.BackColor = System.Drawing.Color.White;
            this.txt_DateTo.Font = new System.Drawing.Font("B Nazanin", 14F);
            this.txt_DateTo.Location = new System.Drawing.Point(554, 7);
            this.txt_DateTo.Name = "txt_DateTo";
            this.txt_DateTo.ShowTime = false;
            this.txt_DateTo.Size = new System.Drawing.Size(165, 33);
            this.txt_DateTo.TabIndex = 13;
            this.txt_DateTo.Text = "persianDateTimePicker2";
            this.txt_DateTo.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_DateTo.Value")));
            // 
            // txt_DateIn
            // 
            this.txt_DateIn.BackColor = System.Drawing.Color.White;
            this.txt_DateIn.Font = new System.Drawing.Font("B Nazanin", 14F);
            this.txt_DateIn.Location = new System.Drawing.Point(742, 7);
            this.txt_DateIn.Name = "txt_DateIn";
            this.txt_DateIn.ShowTime = false;
            this.txt_DateIn.Size = new System.Drawing.Size(165, 33);
            this.txt_DateIn.TabIndex = 12;
            this.txt_DateIn.Text = "persianDateTimePicker1";
            this.txt_DateIn.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_DateIn.Value")));
            // 
            // lbl_DateTo
            // 
            this.lbl_DateTo.AutoSize = true;
            // 
            // 
            // 
            this.lbl_DateTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_DateTo.Location = new System.Drawing.Point(725, 9);
            this.lbl_DateTo.Name = "lbl_DateTo";
            this.lbl_DateTo.Size = new System.Drawing.Size(11, 33);
            this.lbl_DateTo.TabIndex = 11;
            this.lbl_DateTo.Text = "تا";
            // 
            // lbl_DateIn
            // 
            this.lbl_DateIn.AutoSize = true;
            // 
            // 
            // 
            this.lbl_DateIn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_DateIn.Location = new System.Drawing.Point(913, 9);
            this.lbl_DateIn.Name = "lbl_DateIn";
            this.lbl_DateIn.Size = new System.Drawing.Size(98, 33);
            this.lbl_DateIn.TabIndex = 10;
            this.lbl_DateIn.Text = "تاريخ يادآوري از:";
            // 
            // lbl_SearchSubject
            // 
            this.lbl_SearchSubject.AutoSize = true;
            // 
            // 
            // 
            this.lbl_SearchSubject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SearchSubject.Location = new System.Drawing.Point(913, 48);
            this.lbl_SearchSubject.Name = "lbl_SearchSubject";
            this.lbl_SearchSubject.Size = new System.Drawing.Size(45, 33);
            this.lbl_SearchSubject.TabIndex = 10;
            this.lbl_SearchSubject.Text = "موضوع:";
            // 
            // lbl_SearchExporter
            // 
            this.lbl_SearchExporter.AutoSize = true;
            // 
            // 
            // 
            this.lbl_SearchExporter.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SearchExporter.Location = new System.Drawing.Point(461, 10);
            this.lbl_SearchExporter.Name = "lbl_SearchExporter";
            this.lbl_SearchExporter.Size = new System.Drawing.Size(72, 33);
            this.lbl_SearchExporter.TabIndex = 10;
            this.lbl_SearchExporter.Text = "صادر كننده:";
            // 
            // lbl_SearchDeliver
            // 
            this.lbl_SearchDeliver.AutoSize = true;
            // 
            // 
            // 
            this.lbl_SearchDeliver.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SearchDeliver.Location = new System.Drawing.Point(461, 52);
            this.lbl_SearchDeliver.Name = "lbl_SearchDeliver";
            this.lbl_SearchDeliver.Size = new System.Drawing.Size(83, 33);
            this.lbl_SearchDeliver.TabIndex = 10;
            this.lbl_SearchDeliver.Text = "تحويل دهنده:";
            // 
            // txt_SearchDocSubject
            // 
            // 
            // 
            // 
            this.txt_SearchDocSubject.Border.Class = "TextBoxBorder";
            this.txt_SearchDocSubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SearchDocSubject.Location = new System.Drawing.Point(554, 46);
            this.txt_SearchDocSubject.Name = "txt_SearchDocSubject";
            this.txt_SearchDocSubject.PreventEnterBeep = true;
            this.txt_SearchDocSubject.Size = new System.Drawing.Size(353, 36);
            this.txt_SearchDocSubject.TabIndex = 14;
            this.txt_SearchDocSubject.WatermarkText = "جستجو در موضوع اسناد...";
            // 
            // txt_SearchDocExporter
            // 
            // 
            // 
            // 
            this.txt_SearchDocExporter.Border.Class = "TextBoxBorder";
            this.txt_SearchDocExporter.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SearchDocExporter.Location = new System.Drawing.Point(102, 7);
            this.txt_SearchDocExporter.Name = "txt_SearchDocExporter";
            this.txt_SearchDocExporter.PreventEnterBeep = true;
            this.txt_SearchDocExporter.Size = new System.Drawing.Size(353, 36);
            this.txt_SearchDocExporter.TabIndex = 14;
            this.txt_SearchDocExporter.WatermarkText = "جستجو در صادر كننده اسناد...";
            // 
            // txt_SearchDocDeliver
            // 
            // 
            // 
            // 
            this.txt_SearchDocDeliver.Border.Class = "TextBoxBorder";
            this.txt_SearchDocDeliver.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SearchDocDeliver.Location = new System.Drawing.Point(102, 49);
            this.txt_SearchDocDeliver.Name = "txt_SearchDocDeliver";
            this.txt_SearchDocDeliver.PreventEnterBeep = true;
            this.txt_SearchDocDeliver.Size = new System.Drawing.Size(353, 36);
            this.txt_SearchDocDeliver.TabIndex = 14;
            this.txt_SearchDocDeliver.WatermarkText = "جستجو در تحويل دهنده اسناد...";
            // 
            // btn_Search
            // 
            this.btn_Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Search.Location = new System.Drawing.Point(3, 7);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(93, 75);
            this.btn_Search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Search.Symbol = "";
            this.btn_Search.TabIndex = 15;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frmUserDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmUserDocuments";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUserDocuments_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.pnl_NewDocument.ResumeLayout(false);
            this.pnl_NewDocument.PerformLayout();
            this.pnl_SavedDocuments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SavedDocuments)).EndInit();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_NewDocument;
        private DevComponents.DotNetBar.LabelX lbl_Caption;
        private DevComponents.DotNetBar.LabelX lbl_Exporter;
        private DevComponents.DotNetBar.LabelX lbl_AddDate;
        private DevComponents.DotNetBar.LabelX lbl_Deliver;
        private DevComponents.DotNetBar.LabelX lbl_Subject;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_DocCaption;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_DocExporter;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_DocDeliver;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_DocSubject;
        private DevComponents.DotNetBar.LabelX val_DocSaveDate;
        private DevComponents.DotNetBar.LabelX val_DocFilePath;
        private DevComponents.DotNetBar.ButtonX btn_DocAttachFile;
        private DevComponents.DotNetBar.LabelX lbl_AttachFile;
        private DevComponents.DotNetBar.ButtonX btn_SaveDoc;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_SavedDocuments;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_SavedDocuments;
        private System.Windows.Forms.SaveFileDialog saveAttachFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DocID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DocSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DocCaption;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DocExporter;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DocDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DocDeliveryName;
        private System.Windows.Forms.DataGridViewLinkColumn col_DocAttachFile;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Search;
        private FreeControls.PersianDateTimePicker txt_DateTo;
        private FreeControls.PersianDateTimePicker txt_DateIn;
        private DevComponents.DotNetBar.LabelX lbl_DateTo;
        private DevComponents.DotNetBar.LabelX lbl_DateIn;
        private DevComponents.DotNetBar.LabelX lbl_SearchExporter;
        private DevComponents.DotNetBar.LabelX lbl_SearchSubject;
        private DevComponents.DotNetBar.LabelX lbl_SearchDeliver;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SearchDocDeliver;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SearchDocExporter;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SearchDocSubject;
        private DevComponents.DotNetBar.ButtonX btn_Search;
    }
}