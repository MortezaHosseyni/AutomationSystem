namespace AutomationSystem.UserPanel
{
    partial class frmUserRequestSupport
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
            this.pnl_RequestDetail = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.pnl_Buttons = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_Save = new DevComponents.DotNetBar.ButtonX();
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.lbl_ReqSubject = new DevComponents.DotNetBar.LabelX();
            this.lbl_ReqCaption = new DevComponents.DotNetBar.LabelX();
            this.lbl_ReqDate = new DevComponents.DotNetBar.LabelX();
            this.txt_SupSubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_SupCaption = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.val_SupDate = new DevComponents.DotNetBar.LabelX();
            this.pnl_Main.SuspendLayout();
            this.pnl_RequestDetail.SuspendLayout();
            this.pnl_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.pnl_Buttons);
            this.pnl_Main.Controls.Add(this.pnl_RequestDetail);
            this.pnl_Main.Controls.Add(this.lbl_Title);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(635, 359);
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
            this.lbl_Title.Font = new System.Drawing.Font("B Nazanin", 20.25F);
            this.lbl_Title.Location = new System.Drawing.Point(220, 3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(191, 45);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "درخواست پشتيباني";
            // 
            // pnl_RequestDetail
            // 
            this.pnl_RequestDetail.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_RequestDetail.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_RequestDetail.Controls.Add(this.txt_SupCaption);
            this.pnl_RequestDetail.Controls.Add(this.txt_SupSubject);
            this.pnl_RequestDetail.Controls.Add(this.val_SupDate);
            this.pnl_RequestDetail.Controls.Add(this.lbl_ReqDate);
            this.pnl_RequestDetail.Controls.Add(this.lbl_ReqCaption);
            this.pnl_RequestDetail.Controls.Add(this.lbl_ReqSubject);
            this.pnl_RequestDetail.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_RequestDetail.Location = new System.Drawing.Point(12, 54);
            this.pnl_RequestDetail.Name = "pnl_RequestDetail";
            this.pnl_RequestDetail.Size = new System.Drawing.Size(611, 229);
            // 
            // 
            // 
            this.pnl_RequestDetail.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_RequestDetail.Style.BackColorGradientAngle = 90;
            this.pnl_RequestDetail.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_RequestDetail.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_RequestDetail.Style.BorderBottomWidth = 1;
            this.pnl_RequestDetail.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_RequestDetail.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_RequestDetail.Style.BorderLeftWidth = 1;
            this.pnl_RequestDetail.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_RequestDetail.Style.BorderRightWidth = 1;
            this.pnl_RequestDetail.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_RequestDetail.Style.BorderTopWidth = 1;
            this.pnl_RequestDetail.Style.CornerDiameter = 4;
            this.pnl_RequestDetail.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_RequestDetail.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_RequestDetail.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_RequestDetail.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_RequestDetail.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_RequestDetail.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_RequestDetail.TabIndex = 1;
            this.pnl_RequestDetail.Text = "جزئيات درخواست";
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Buttons.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Buttons.Controls.Add(this.btn_Exit);
            this.pnl_Buttons.Controls.Add(this.btn_Save);
            this.pnl_Buttons.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Buttons.Location = new System.Drawing.Point(12, 289);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(611, 58);
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
            // btn_Save
            // 
            this.btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Save.Location = new System.Drawing.Point(301, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 2, 20, 20);
            this.btn_Save.Size = new System.Drawing.Size(191, 46);
            this.btn_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Save.Symbol = "";
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "ثبت درخواست";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Exit.Location = new System.Drawing.Point(104, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 2, 20, 20);
            this.btn_Exit.Size = new System.Drawing.Size(191, 46);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.Symbol = "";
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "خروج";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_ReqSubject
            // 
            this.lbl_ReqSubject.AutoSize = true;
            // 
            // 
            // 
            this.lbl_ReqSubject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_ReqSubject.Location = new System.Drawing.Point(462, 49);
            this.lbl_ReqSubject.Name = "lbl_ReqSubject";
            this.lbl_ReqSubject.Size = new System.Drawing.Size(45, 33);
            this.lbl_ReqSubject.TabIndex = 0;
            this.lbl_ReqSubject.Text = "موضوع:";
            // 
            // lbl_ReqCaption
            // 
            this.lbl_ReqCaption.AutoSize = true;
            // 
            // 
            // 
            this.lbl_ReqCaption.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_ReqCaption.Location = new System.Drawing.Point(462, 91);
            this.lbl_ReqCaption.Name = "lbl_ReqCaption";
            this.lbl_ReqCaption.Size = new System.Drawing.Size(61, 33);
            this.lbl_ReqCaption.TabIndex = 0;
            this.lbl_ReqCaption.Text = "توضيحات:";
            // 
            // lbl_ReqDate
            // 
            this.lbl_ReqDate.AutoSize = true;
            // 
            // 
            // 
            this.lbl_ReqDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_ReqDate.Location = new System.Drawing.Point(462, 10);
            this.lbl_ReqDate.Name = "lbl_ReqDate";
            this.lbl_ReqDate.Size = new System.Drawing.Size(35, 33);
            this.lbl_ReqDate.TabIndex = 0;
            this.lbl_ReqDate.Text = "تاريخ:";
            // 
            // txt_SupSubject
            // 
            // 
            // 
            // 
            this.txt_SupSubject.Border.Class = "TextBoxBorder";
            this.txt_SupSubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SupSubject.Location = new System.Drawing.Point(71, 49);
            this.txt_SupSubject.Name = "txt_SupSubject";
            this.txt_SupSubject.PreventEnterBeep = true;
            this.txt_SupSubject.Size = new System.Drawing.Size(385, 36);
            this.txt_SupSubject.TabIndex = 1;
            this.txt_SupSubject.WatermarkText = "موضوع درخواست...";
            // 
            // txt_SupCaption
            // 
            // 
            // 
            // 
            this.txt_SupCaption.Border.Class = "TextBoxBorder";
            this.txt_SupCaption.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SupCaption.Location = new System.Drawing.Point(71, 91);
            this.txt_SupCaption.Multiline = true;
            this.txt_SupCaption.Name = "txt_SupCaption";
            this.txt_SupCaption.PreventEnterBeep = true;
            this.txt_SupCaption.Size = new System.Drawing.Size(385, 98);
            this.txt_SupCaption.TabIndex = 1;
            this.txt_SupCaption.WatermarkText = "توضيحات درخواست...";
            // 
            // val_SupDate
            // 
            this.val_SupDate.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.val_SupDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_SupDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.val_SupDate.Location = new System.Drawing.Point(71, 10);
            this.val_SupDate.Name = "val_SupDate";
            this.val_SupDate.Size = new System.Drawing.Size(385, 33);
            this.val_SupDate.TabIndex = 0;
            this.val_SupDate.Text = "...";
            this.val_SupDate.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // frmUserRequestSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 359);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmUserRequestSupport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.pnl_RequestDetail.ResumeLayout(false);
            this.pnl_RequestDetail.PerformLayout();
            this.pnl_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_RequestDetail;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Buttons;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
        private DevComponents.DotNetBar.ButtonX btn_Save;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SupCaption;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SupSubject;
        private DevComponents.DotNetBar.LabelX lbl_ReqDate;
        private DevComponents.DotNetBar.LabelX lbl_ReqCaption;
        private DevComponents.DotNetBar.LabelX lbl_ReqSubject;
        private DevComponents.DotNetBar.LabelX val_SupDate;
    }
}