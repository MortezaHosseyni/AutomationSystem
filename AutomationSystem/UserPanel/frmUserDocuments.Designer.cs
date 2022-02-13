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
            this.pnl_Main = new DevComponents.DotNetBar.PanelEx();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.pnl_NewDocument = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_Subject = new DevComponents.DotNetBar.LabelX();
            this.lbl_Exporter = new DevComponents.DotNetBar.LabelX();
            this.lbl_Caption = new DevComponents.DotNetBar.LabelX();
            this.lbl_Deliver = new DevComponents.DotNetBar.LabelX();
            this.lbl_AddDate = new DevComponents.DotNetBar.LabelX();
            this.txt_DocSubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_DocExporter = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_DocCaption = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_DocDeliver = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.val_DocSaveDate = new DevComponents.DotNetBar.LabelX();
            this.val_DocFilePath = new DevComponents.DotNetBar.LabelX();
            this.btn_DocAttachFile = new DevComponents.DotNetBar.ButtonX();
            this.lbl_AttachFile = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pnl_Main.SuspendLayout();
            this.pnl_NewDocument.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            // pnl_NewDocument
            // 
            this.pnl_NewDocument.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_NewDocument.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_NewDocument.Controls.Add(this.val_DocFilePath);
            this.pnl_NewDocument.Controls.Add(this.buttonX1);
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
            this.pnl_NewDocument.Size = new System.Drawing.Size(1026, 323);
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
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            // 
            // 
            // 
            this.lbl_Subject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Subject.Location = new System.Drawing.Point(931, 25);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(45, 33);
            this.lbl_Subject.TabIndex = 0;
            this.lbl_Subject.Text = "موضوع:";
            // 
            // lbl_Exporter
            // 
            this.lbl_Exporter.AutoSize = true;
            // 
            // 
            // 
            this.lbl_Exporter.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Exporter.Location = new System.Drawing.Point(931, 67);
            this.lbl_Exporter.Name = "lbl_Exporter";
            this.lbl_Exporter.Size = new System.Drawing.Size(66, 33);
            this.lbl_Exporter.TabIndex = 0;
            this.lbl_Exporter.Text = "صادر كنند:";
            // 
            // lbl_Caption
            // 
            this.lbl_Caption.AutoSize = true;
            // 
            // 
            // 
            this.lbl_Caption.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Caption.Location = new System.Drawing.Point(931, 110);
            this.lbl_Caption.Name = "lbl_Caption";
            this.lbl_Caption.Size = new System.Drawing.Size(61, 33);
            this.lbl_Caption.TabIndex = 0;
            this.lbl_Caption.Text = "توضيحات:";
            // 
            // lbl_Deliver
            // 
            this.lbl_Deliver.AutoSize = true;
            // 
            // 
            // 
            this.lbl_Deliver.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Deliver.Location = new System.Drawing.Point(346, 25);
            this.lbl_Deliver.Name = "lbl_Deliver";
            this.lbl_Deliver.Size = new System.Drawing.Size(83, 33);
            this.lbl_Deliver.TabIndex = 0;
            this.lbl_Deliver.Text = "تحويل دهنده:";
            // 
            // lbl_AddDate
            // 
            this.lbl_AddDate.AutoSize = true;
            // 
            // 
            // 
            this.lbl_AddDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_AddDate.Location = new System.Drawing.Point(346, 71);
            this.lbl_AddDate.Name = "lbl_AddDate";
            this.lbl_AddDate.Size = new System.Drawing.Size(63, 33);
            this.lbl_AddDate.TabIndex = 0;
            this.lbl_AddDate.Text = "تاريخ ثبت:";
            // 
            // txt_DocSubject
            // 
            // 
            // 
            // 
            this.txt_DocSubject.Border.Class = "TextBoxBorder";
            this.txt_DocSubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_DocSubject.Location = new System.Drawing.Point(477, 22);
            this.txt_DocSubject.Name = "txt_DocSubject";
            this.txt_DocSubject.PreventEnterBeep = true;
            this.txt_DocSubject.Size = new System.Drawing.Size(448, 36);
            this.txt_DocSubject.TabIndex = 1;
            this.txt_DocSubject.WatermarkText = "موضوع سند...";
            // 
            // txt_DocExporter
            // 
            // 
            // 
            // 
            this.txt_DocExporter.Border.Class = "TextBoxBorder";
            this.txt_DocExporter.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_DocExporter.Location = new System.Drawing.Point(477, 64);
            this.txt_DocExporter.Name = "txt_DocExporter";
            this.txt_DocExporter.PreventEnterBeep = true;
            this.txt_DocExporter.Size = new System.Drawing.Size(448, 36);
            this.txt_DocExporter.TabIndex = 2;
            this.txt_DocExporter.WatermarkText = "صادر كننده سند...";
            // 
            // txt_DocCaption
            // 
            // 
            // 
            // 
            this.txt_DocCaption.Border.Class = "TextBoxBorder";
            this.txt_DocCaption.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_DocCaption.Location = new System.Drawing.Point(477, 106);
            this.txt_DocCaption.Multiline = true;
            this.txt_DocCaption.Name = "txt_DocCaption";
            this.txt_DocCaption.PreventEnterBeep = true;
            this.txt_DocCaption.Size = new System.Drawing.Size(448, 163);
            this.txt_DocCaption.TabIndex = 3;
            this.txt_DocCaption.WatermarkText = "توضيحات سند...";
            // 
            // txt_DocDeliver
            // 
            // 
            // 
            // 
            this.txt_DocDeliver.Border.Class = "TextBoxBorder";
            this.txt_DocDeliver.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_DocDeliver.Location = new System.Drawing.Point(3, 25);
            this.txt_DocDeliver.Name = "txt_DocDeliver";
            this.txt_DocDeliver.PreventEnterBeep = true;
            this.txt_DocDeliver.Size = new System.Drawing.Size(337, 36);
            this.txt_DocDeliver.TabIndex = 4;
            this.txt_DocDeliver.WatermarkText = "تحويل دهنده سند...";
            // 
            // val_DocSaveDate
            // 
            this.val_DocSaveDate.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.val_DocSaveDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_DocSaveDate.Location = new System.Drawing.Point(3, 67);
            this.val_DocSaveDate.Name = "val_DocSaveDate";
            this.val_DocSaveDate.Size = new System.Drawing.Size(337, 33);
            this.val_DocSaveDate.TabIndex = 5;
            this.val_DocSaveDate.Text = "...";
            this.val_DocSaveDate.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // val_DocFilePath
            // 
            this.val_DocFilePath.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.val_DocFilePath.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_DocFilePath.Font = new System.Drawing.Font("B Nazanin", 9.25F);
            this.val_DocFilePath.Location = new System.Drawing.Point(3, 165);
            this.val_DocFilePath.Name = "val_DocFilePath";
            this.val_DocFilePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.val_DocFilePath.Size = new System.Drawing.Size(468, 49);
            this.val_DocFilePath.TabIndex = 7;
            this.val_DocFilePath.WordWrap = true;
            // 
            // btn_DocAttachFile
            // 
            this.btn_DocAttachFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_DocAttachFile.BackColor = System.Drawing.Color.Transparent;
            this.btn_DocAttachFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_DocAttachFile.Enabled = false;
            this.btn_DocAttachFile.Location = new System.Drawing.Point(3, 106);
            this.btn_DocAttachFile.Name = "btn_DocAttachFile";
            this.btn_DocAttachFile.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.btn_DocAttachFile.Size = new System.Drawing.Size(337, 49);
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
            this.lbl_AttachFile.Location = new System.Drawing.Point(346, 111);
            this.lbl_AttachFile.Name = "lbl_AttachFile";
            this.lbl_AttachFile.Size = new System.Drawing.Size(67, 32);
            this.lbl_AttachFile.TabIndex = 5;
            this.lbl_AttachFile.Text = "الصاق فايل:";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.BackColor = System.Drawing.Color.Transparent;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Enabled = false;
            this.buttonX1.Location = new System.Drawing.Point(3, 220);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 2, 2, 10);
            this.buttonX1.Size = new System.Drawing.Size(337, 49);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.TabIndex = 7;
            this.buttonX1.Text = "ثبت سند";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmUserDocuments";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUserDocuments_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.pnl_NewDocument.ResumeLayout(false);
            this.pnl_NewDocument.PerformLayout();
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
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}