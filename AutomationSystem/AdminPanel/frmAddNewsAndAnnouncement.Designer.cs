namespace AutomationSystem.AdminPanel
{
    partial class frmAddNewsAndAnnouncement
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
            this.pnl_Buttons = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.btn_SendNews = new DevComponents.DotNetBar.ButtonX();
            this.pnl_AddNewsAndAnnouncement = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.lbl_NewsSubject = new DevComponents.DotNetBar.LabelX();
            this.lbl_NewsContext = new DevComponents.DotNetBar.LabelX();
            this.lbl_NewsDate = new DevComponents.DotNetBar.LabelX();
            this.lbl_NewsWriter = new DevComponents.DotNetBar.LabelX();
            this.lbl_NewsAttachmentFilePath = new DevComponents.DotNetBar.LabelX();
            this.txt_NewsSubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_NewsContext = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.val_NewsDate = new DevComponents.DotNetBar.LabelX();
            this.val_NewsWriter = new DevComponents.DotNetBar.LabelX();
            this.btn_AttachFile = new DevComponents.DotNetBar.ButtonX();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_NewsList = new DevComponents.DotNetBar.ButtonX();
            this.pnl_Main.SuspendLayout();
            this.pnl_Buttons.SuspendLayout();
            this.pnl_AddNewsAndAnnouncement.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.pnl_Buttons);
            this.pnl_Main.Controls.Add(this.pnl_AddNewsAndAnnouncement);
            this.pnl_Main.Controls.Add(this.lbl_Title);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(771, 432);
            this.pnl_Main.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl_Main.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Main.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Main.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl_Main.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Main.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Main.Style.GradientAngle = 90;
            this.pnl_Main.TabIndex = 0;
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Buttons.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Buttons.Controls.Add(this.btn_Exit);
            this.pnl_Buttons.Controls.Add(this.btn_NewsList);
            this.pnl_Buttons.Controls.Add(this.btn_SendNews);
            this.pnl_Buttons.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Buttons.Location = new System.Drawing.Point(12, 339);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(747, 81);
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
            this.pnl_Buttons.TabIndex = 2;
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Exit.Location = new System.Drawing.Point(33, 17);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 2, 20, 20);
            this.btn_Exit.Size = new System.Drawing.Size(220, 43);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.Symbol = "";
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "خروج";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_SendNews
            // 
            this.btn_SendNews.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SendNews.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_SendNews.Location = new System.Drawing.Point(259, 17);
            this.btn_SendNews.Name = "btn_SendNews";
            this.btn_SendNews.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 2, 20, 20);
            this.btn_SendNews.Size = new System.Drawing.Size(220, 43);
            this.btn_SendNews.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_SendNews.Symbol = "";
            this.btn_SendNews.TabIndex = 4;
            this.btn_SendNews.Text = "ارسال خبر";
            this.btn_SendNews.Click += new System.EventHandler(this.btn_SendNews_Click);
            // 
            // pnl_AddNewsAndAnnouncement
            // 
            this.pnl_AddNewsAndAnnouncement.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_AddNewsAndAnnouncement.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_AddNewsAndAnnouncement.Controls.Add(this.btn_AttachFile);
            this.pnl_AddNewsAndAnnouncement.Controls.Add(this.txt_NewsContext);
            this.pnl_AddNewsAndAnnouncement.Controls.Add(this.txt_NewsSubject);
            this.pnl_AddNewsAndAnnouncement.Controls.Add(this.lbl_NewsContext);
            this.pnl_AddNewsAndAnnouncement.Controls.Add(this.lbl_NewsAttachmentFilePath);
            this.pnl_AddNewsAndAnnouncement.Controls.Add(this.lbl_NewsWriter);
            this.pnl_AddNewsAndAnnouncement.Controls.Add(this.val_NewsWriter);
            this.pnl_AddNewsAndAnnouncement.Controls.Add(this.val_NewsDate);
            this.pnl_AddNewsAndAnnouncement.Controls.Add(this.lbl_NewsDate);
            this.pnl_AddNewsAndAnnouncement.Controls.Add(this.lbl_NewsSubject);
            this.pnl_AddNewsAndAnnouncement.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_AddNewsAndAnnouncement.Location = new System.Drawing.Point(12, 67);
            this.pnl_AddNewsAndAnnouncement.Name = "pnl_AddNewsAndAnnouncement";
            this.pnl_AddNewsAndAnnouncement.Size = new System.Drawing.Size(747, 266);
            // 
            // 
            // 
            this.pnl_AddNewsAndAnnouncement.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_AddNewsAndAnnouncement.Style.BackColorGradientAngle = 90;
            this.pnl_AddNewsAndAnnouncement.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_AddNewsAndAnnouncement.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_AddNewsAndAnnouncement.Style.BorderBottomWidth = 1;
            this.pnl_AddNewsAndAnnouncement.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_AddNewsAndAnnouncement.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_AddNewsAndAnnouncement.Style.BorderLeftWidth = 1;
            this.pnl_AddNewsAndAnnouncement.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_AddNewsAndAnnouncement.Style.BorderRightWidth = 1;
            this.pnl_AddNewsAndAnnouncement.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_AddNewsAndAnnouncement.Style.BorderTopWidth = 1;
            this.pnl_AddNewsAndAnnouncement.Style.CornerDiameter = 4;
            this.pnl_AddNewsAndAnnouncement.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_AddNewsAndAnnouncement.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_AddNewsAndAnnouncement.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_AddNewsAndAnnouncement.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_AddNewsAndAnnouncement.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_AddNewsAndAnnouncement.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_AddNewsAndAnnouncement.TabIndex = 1;
            // 
            // lbl_Title
            // 
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("B Nazanin", 22.25F);
            this.lbl_Title.Location = new System.Drawing.Point(295, 3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(171, 58);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "اخبار و اطلاعيه";
            // 
            // lbl_NewsSubject
            // 
            // 
            // 
            // 
            this.lbl_NewsSubject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_NewsSubject.Location = new System.Drawing.Point(674, 27);
            this.lbl_NewsSubject.Name = "lbl_NewsSubject";
            this.lbl_NewsSubject.Size = new System.Drawing.Size(45, 31);
            this.lbl_NewsSubject.TabIndex = 0;
            this.lbl_NewsSubject.Text = "موضوع:";
            // 
            // lbl_NewsContext
            // 
            // 
            // 
            // 
            this.lbl_NewsContext.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_NewsContext.Location = new System.Drawing.Point(674, 98);
            this.lbl_NewsContext.Name = "lbl_NewsContext";
            this.lbl_NewsContext.Size = new System.Drawing.Size(28, 31);
            this.lbl_NewsContext.TabIndex = 0;
            this.lbl_NewsContext.Text = "متن:";
            // 
            // lbl_NewsDate
            // 
            // 
            // 
            // 
            this.lbl_NewsDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_NewsDate.Location = new System.Drawing.Point(270, 27);
            this.lbl_NewsDate.Name = "lbl_NewsDate";
            this.lbl_NewsDate.Size = new System.Drawing.Size(82, 31);
            this.lbl_NewsDate.TabIndex = 0;
            this.lbl_NewsDate.Text = "تاريخ اطلاعيه:";
            // 
            // lbl_NewsWriter
            // 
            // 
            // 
            // 
            this.lbl_NewsWriter.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_NewsWriter.Location = new System.Drawing.Point(270, 98);
            this.lbl_NewsWriter.Name = "lbl_NewsWriter";
            this.lbl_NewsWriter.Size = new System.Drawing.Size(77, 31);
            this.lbl_NewsWriter.TabIndex = 0;
            this.lbl_NewsWriter.Text = "نويسنده خبر:";
            // 
            // lbl_NewsAttachmentFilePath
            // 
            // 
            // 
            // 
            this.lbl_NewsAttachmentFilePath.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_NewsAttachmentFilePath.Font = new System.Drawing.Font("B Nazanin", 10.25F);
            this.lbl_NewsAttachmentFilePath.Location = new System.Drawing.Point(30, 198);
            this.lbl_NewsAttachmentFilePath.Name = "lbl_NewsAttachmentFilePath";
            this.lbl_NewsAttachmentFilePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_NewsAttachmentFilePath.Size = new System.Drawing.Size(322, 59);
            this.lbl_NewsAttachmentFilePath.TabIndex = 0;
            this.lbl_NewsAttachmentFilePath.WordWrap = true;
            // 
            // txt_NewsSubject
            // 
            this.txt_NewsSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.txt_NewsSubject.Border.Class = "TextBoxBorder";
            this.txt_NewsSubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_NewsSubject.Location = new System.Drawing.Point(394, 27);
            this.txt_NewsSubject.Name = "txt_NewsSubject";
            this.txt_NewsSubject.PreventEnterBeep = true;
            this.txt_NewsSubject.Size = new System.Drawing.Size(274, 36);
            this.txt_NewsSubject.TabIndex = 1;
            this.txt_NewsSubject.WatermarkText = "موضوع خبر...";
            // 
            // txt_NewsContext
            // 
            this.txt_NewsContext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.txt_NewsContext.Border.Class = "TextBoxBorder";
            this.txt_NewsContext.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_NewsContext.Location = new System.Drawing.Point(394, 69);
            this.txt_NewsContext.Multiline = true;
            this.txt_NewsContext.Name = "txt_NewsContext";
            this.txt_NewsContext.PreventEnterBeep = true;
            this.txt_NewsContext.Size = new System.Drawing.Size(274, 179);
            this.txt_NewsContext.TabIndex = 2;
            this.txt_NewsContext.WatermarkText = "متن خبر...";
            // 
            // val_NewsDate
            // 
            this.val_NewsDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.val_NewsDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_NewsDate.ForeColor = System.Drawing.Color.Red;
            this.val_NewsDate.Location = new System.Drawing.Point(30, 27);
            this.val_NewsDate.Name = "val_NewsDate";
            this.val_NewsDate.Size = new System.Drawing.Size(234, 31);
            this.val_NewsDate.TabIndex = 0;
            this.val_NewsDate.Text = "...";
            this.val_NewsDate.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // val_NewsWriter
            // 
            this.val_NewsWriter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.val_NewsWriter.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_NewsWriter.ForeColor = System.Drawing.Color.Red;
            this.val_NewsWriter.Location = new System.Drawing.Point(30, 98);
            this.val_NewsWriter.Name = "val_NewsWriter";
            this.val_NewsWriter.Size = new System.Drawing.Size(234, 31);
            this.val_NewsWriter.TabIndex = 0;
            this.val_NewsWriter.Text = "...";
            this.val_NewsWriter.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_AttachFile
            // 
            this.btn_AttachFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_AttachFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_AttachFile.Location = new System.Drawing.Point(30, 153);
            this.btn_AttachFile.Name = "btn_AttachFile";
            this.btn_AttachFile.Size = new System.Drawing.Size(322, 39);
            this.btn_AttachFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_AttachFile.Symbol = "57671";
            this.btn_AttachFile.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn_AttachFile.TabIndex = 3;
            this.btn_AttachFile.Text = "الصاق فايل";
            this.btn_AttachFile.Click += new System.EventHandler(this.btn_AttachFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btn_NewsList
            // 
            this.btn_NewsList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_NewsList.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_NewsList.Location = new System.Drawing.Point(485, 17);
            this.btn_NewsList.Name = "btn_NewsList";
            this.btn_NewsList.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 2, 20, 20);
            this.btn_NewsList.Size = new System.Drawing.Size(220, 43);
            this.btn_NewsList.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_NewsList.Symbol = "";
            this.btn_NewsList.TabIndex = 4;
            this.btn_NewsList.Text = "ليست اطلاعيه‌ها";
            this.btn_NewsList.Click += new System.EventHandler(this.btn_SendNews_Click);
            // 
            // frmAddNewsAndAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 432);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmAddNewsAndAnnouncement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddNewsAndAnnouncement_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Buttons.ResumeLayout(false);
            this.pnl_AddNewsAndAnnouncement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Buttons;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_AddNewsAndAnnouncement;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
        private DevComponents.DotNetBar.ButtonX btn_SendNews;
        private DevComponents.DotNetBar.LabelX lbl_NewsSubject;
        private DevComponents.DotNetBar.LabelX lbl_NewsContext;
        private DevComponents.DotNetBar.LabelX lbl_NewsAttachmentFilePath;
        private DevComponents.DotNetBar.LabelX lbl_NewsWriter;
        private DevComponents.DotNetBar.LabelX lbl_NewsDate;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_NewsContext;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_NewsSubject;
        private DevComponents.DotNetBar.LabelX val_NewsDate;
        private DevComponents.DotNetBar.LabelX val_NewsWriter;
        private DevComponents.DotNetBar.ButtonX btn_AttachFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevComponents.DotNetBar.ButtonX btn_NewsList;
    }
}