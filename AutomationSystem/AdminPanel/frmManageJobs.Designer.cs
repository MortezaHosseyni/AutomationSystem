namespace AutomationSystem.AdminPanel
{
    partial class frmManageJobs
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
            this.pnl_Contents = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_JobSubject = new DevComponents.DotNetBar.LabelX();
            this.lbl_JobDetails = new DevComponents.DotNetBar.LabelX();
            this.txt_JobSubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_JobDetails = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_Save = new DevComponents.DotNetBar.ButtonX();
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.pnl_Main.SuspendLayout();
            this.pnl_Contents.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.pnl_Contents);
            this.pnl_Main.Controls.Add(this.lbl_Title);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(639, 443);
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
            this.lbl_Title.Location = new System.Drawing.Point(231, 12);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(154, 46);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "تعريف شغل";
            // 
            // pnl_Contents
            // 
            this.pnl_Contents.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Contents.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Contents.Controls.Add(this.btn_Exit);
            this.pnl_Contents.Controls.Add(this.btn_Save);
            this.pnl_Contents.Controls.Add(this.txt_JobDetails);
            this.pnl_Contents.Controls.Add(this.txt_JobSubject);
            this.pnl_Contents.Controls.Add(this.lbl_JobDetails);
            this.pnl_Contents.Controls.Add(this.lbl_JobSubject);
            this.pnl_Contents.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Contents.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pnl_Contents.Location = new System.Drawing.Point(12, 66);
            this.pnl_Contents.Name = "pnl_Contents";
            this.pnl_Contents.Size = new System.Drawing.Size(615, 365);
            // 
            // 
            // 
            this.pnl_Contents.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Contents.Style.BackColorGradientAngle = 90;
            this.pnl_Contents.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Contents.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Contents.Style.BorderBottomWidth = 1;
            this.pnl_Contents.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Contents.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Contents.Style.BorderLeftWidth = 1;
            this.pnl_Contents.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Contents.Style.BorderRightWidth = 1;
            this.pnl_Contents.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Contents.Style.BorderTopWidth = 1;
            this.pnl_Contents.Style.CornerDiameter = 4;
            this.pnl_Contents.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_Contents.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_Contents.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Contents.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_Contents.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_Contents.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_Contents.TabIndex = 1;
            // 
            // lbl_JobSubject
            // 
            // 
            // 
            // 
            this.lbl_JobSubject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_JobSubject.Location = new System.Drawing.Point(457, 37);
            this.lbl_JobSubject.Name = "lbl_JobSubject";
            this.lbl_JobSubject.Size = new System.Drawing.Size(85, 30);
            this.lbl_JobSubject.TabIndex = 0;
            this.lbl_JobSubject.Text = "عنوان شغلي:";
            // 
            // lbl_JobDetails
            // 
            // 
            // 
            // 
            this.lbl_JobDetails.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_JobDetails.Location = new System.Drawing.Point(457, 81);
            this.lbl_JobDetails.Name = "lbl_JobDetails";
            this.lbl_JobDetails.Size = new System.Drawing.Size(70, 30);
            this.lbl_JobDetails.TabIndex = 0;
            this.lbl_JobDetails.Text = "توضيحات:";
            // 
            // txt_JobSubject
            // 
            // 
            // 
            // 
            this.txt_JobSubject.Border.Class = "TextBoxBorder";
            this.txt_JobSubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_JobSubject.Location = new System.Drawing.Point(143, 37);
            this.txt_JobSubject.Name = "txt_JobSubject";
            this.txt_JobSubject.PreventEnterBeep = true;
            this.txt_JobSubject.Size = new System.Drawing.Size(308, 38);
            this.txt_JobSubject.TabIndex = 1;
            this.txt_JobSubject.WatermarkText = "عنوان شغل را وارد كنيد...";
            // 
            // txt_JobDetails
            // 
            // 
            // 
            // 
            this.txt_JobDetails.Border.Class = "TextBoxBorder";
            this.txt_JobDetails.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_JobDetails.Location = new System.Drawing.Point(143, 81);
            this.txt_JobDetails.Multiline = true;
            this.txt_JobDetails.Name = "txt_JobDetails";
            this.txt_JobDetails.PreventEnterBeep = true;
            this.txt_JobDetails.Size = new System.Drawing.Size(308, 164);
            this.txt_JobDetails.TabIndex = 2;
            this.txt_JobDetails.WatermarkText = "توضيحاتي درمورد شغل (اختياري)...";
            // 
            // btn_Save
            // 
            this.btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Save.Location = new System.Drawing.Point(307, 280);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 2, 20, 20);
            this.btn_Save.Size = new System.Drawing.Size(235, 51);
            this.btn_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Save.Symbol = "58826";
            this.btn_Save.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "ثبت اطلاعات";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Exit.Location = new System.Drawing.Point(66, 280);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 2, 20, 20);
            this.btn_Exit.Size = new System.Drawing.Size(235, 51);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.Symbol = "58829";
            this.btn_Exit.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "خروج";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // frmManageJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 443);
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmManageJobs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmManageJobs_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Contents.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Contents;
        private DevComponents.DotNetBar.LabelX lbl_JobDetails;
        private DevComponents.DotNetBar.LabelX lbl_JobSubject;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_JobDetails;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_JobSubject;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
        private DevComponents.DotNetBar.ButtonX btn_Save;
    }
}