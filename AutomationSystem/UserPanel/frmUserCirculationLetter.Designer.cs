namespace AutomationSystem.UserPanel
{
    partial class frmUserCirculationLetter
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
            this.lbl_CirculationLetterTitle = new DevComponents.DotNetBar.LabelX();
            this.lbl_CirculationLetterContext = new DevComponents.DotNetBar.LabelX();
            this.pnl_CirculationLetter = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.pnl_Main.SuspendLayout();
            this.pnl_CirculationLetter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.btn_Exit);
            this.pnl_Main.Controls.Add(this.pnl_CirculationLetter);
            this.pnl_Main.Controls.Add(this.lbl_CirculationLetterTitle);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(591, 657);
            this.pnl_Main.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl_Main.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Main.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Main.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl_Main.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Main.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Main.Style.GradientAngle = 90;
            this.pnl_Main.TabIndex = 0;
            // 
            // lbl_CirculationLetterTitle
            // 
            // 
            // 
            // 
            this.lbl_CirculationLetterTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_CirculationLetterTitle.Font = new System.Drawing.Font("B Nazanin", 16.25F);
            this.lbl_CirculationLetterTitle.ForeColor = System.Drawing.Color.Red;
            this.lbl_CirculationLetterTitle.Location = new System.Drawing.Point(12, 12);
            this.lbl_CirculationLetterTitle.Name = "lbl_CirculationLetterTitle";
            this.lbl_CirculationLetterTitle.Size = new System.Drawing.Size(530, 38);
            this.lbl_CirculationLetterTitle.TabIndex = 0;
            this.lbl_CirculationLetterTitle.Text = "...";
            this.lbl_CirculationLetterTitle.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lbl_CirculationLetterContext
            // 
            // 
            // 
            // 
            this.lbl_CirculationLetterContext.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_CirculationLetterContext.ForeColor = System.Drawing.Color.Blue;
            this.lbl_CirculationLetterContext.Location = new System.Drawing.Point(3, 3);
            this.lbl_CirculationLetterContext.Name = "lbl_CirculationLetterContext";
            this.lbl_CirculationLetterContext.Size = new System.Drawing.Size(555, 546);
            this.lbl_CirculationLetterContext.TabIndex = 1;
            this.lbl_CirculationLetterContext.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.lbl_CirculationLetterContext.WordWrap = true;
            // 
            // pnl_CirculationLetter
            // 
            this.pnl_CirculationLetter.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_CirculationLetter.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_CirculationLetter.Controls.Add(this.lbl_CirculationLetterContext);
            this.pnl_CirculationLetter.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_CirculationLetter.Location = new System.Drawing.Point(12, 56);
            this.pnl_CirculationLetter.Name = "pnl_CirculationLetter";
            this.pnl_CirculationLetter.Size = new System.Drawing.Size(567, 589);
            // 
            // 
            // 
            this.pnl_CirculationLetter.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_CirculationLetter.Style.BackColorGradientAngle = 90;
            this.pnl_CirculationLetter.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_CirculationLetter.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_CirculationLetter.Style.BorderBottomWidth = 1;
            this.pnl_CirculationLetter.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_CirculationLetter.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_CirculationLetter.Style.BorderLeftWidth = 1;
            this.pnl_CirculationLetter.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_CirculationLetter.Style.BorderRightWidth = 1;
            this.pnl_CirculationLetter.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_CirculationLetter.Style.BorderTopWidth = 1;
            this.pnl_CirculationLetter.Style.CornerDiameter = 4;
            this.pnl_CirculationLetter.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_CirculationLetter.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_CirculationLetter.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_CirculationLetter.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_CirculationLetter.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_CirculationLetter.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_CirculationLetter.TabIndex = 2;
            this.pnl_CirculationLetter.Text = "گردش نامه";
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Exit.Location = new System.Drawing.Point(548, 11);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(31, 28);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.Symbol = "";
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // frmUserCirculationLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(591, 657);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmUserCirculationLetter";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUserCirculationLetter_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_CirculationLetter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.LabelX lbl_CirculationLetterContext;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_CirculationLetter;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
        public DevComponents.DotNetBar.LabelX lbl_CirculationLetterTitle;
    }
}