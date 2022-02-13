namespace AutomationSystem.UserPanel
{
    partial class frmUserShowNewsContext
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
            this.val_NewsSubject = new DevComponents.DotNetBar.LabelX();
            this.pnl_Main = new DevComponents.DotNetBar.PanelEx();
            this.val_NewsContext = new DevComponents.DotNetBar.LabelX();
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // val_NewsSubject
            // 
            // 
            // 
            // 
            this.val_NewsSubject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_NewsSubject.Font = new System.Drawing.Font("B Nazanin", 18.25F, System.Drawing.FontStyle.Bold);
            this.val_NewsSubject.Location = new System.Drawing.Point(12, 38);
            this.val_NewsSubject.Name = "val_NewsSubject";
            this.val_NewsSubject.Size = new System.Drawing.Size(575, 39);
            this.val_NewsSubject.TabIndex = 0;
            this.val_NewsSubject.Text = "...";
            this.val_NewsSubject.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.btn_Exit);
            this.pnl_Main.Controls.Add(this.val_NewsContext);
            this.pnl_Main.Controls.Add(this.val_NewsSubject);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(599, 584);
            this.pnl_Main.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl_Main.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Main.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Main.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl_Main.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Main.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Main.Style.GradientAngle = 90;
            this.pnl_Main.TabIndex = 1;
            // 
            // val_NewsContext
            // 
            // 
            // 
            // 
            this.val_NewsContext.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_NewsContext.Location = new System.Drawing.Point(12, 96);
            this.val_NewsContext.Name = "val_NewsContext";
            this.val_NewsContext.Size = new System.Drawing.Size(575, 476);
            this.val_NewsContext.TabIndex = 1;
            this.val_NewsContext.Text = "...";
            this.val_NewsContext.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.val_NewsContext.WordWrap = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Exit.Location = new System.Drawing.Point(565, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(31, 29);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.Symbol = "";
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // frmUserShowNewsContext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 584);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmUserShowNewsContext";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.PanelEx pnl_Main;
        public DevComponents.DotNetBar.LabelX val_NewsSubject;
        public DevComponents.DotNetBar.LabelX val_NewsContext;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
    }
}