namespace AutomationSystem.UserPanel
{
    partial class frmUserNewMessage
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
            this.val_MessageTittle = new DevComponents.DotNetBar.LabelX();
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.val_MessageContext = new DevComponents.DotNetBar.LabelX();
            this.pic_Announce = new System.Windows.Forms.PictureBox();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Announce)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.pic_Announce);
            this.pnl_Main.Controls.Add(this.val_MessageContext);
            this.pnl_Main.Controls.Add(this.btn_Exit);
            this.pnl_Main.Controls.Add(this.val_MessageTittle);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(750, 430);
            this.pnl_Main.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl_Main.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Main.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Main.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl_Main.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Main.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Main.Style.GradientAngle = 90;
            this.pnl_Main.TabIndex = 0;
            // 
            // val_MessageTittle
            // 
            // 
            // 
            // 
            this.val_MessageTittle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_MessageTittle.Font = new System.Drawing.Font("B Nazanin", 15.25F);
            this.val_MessageTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.val_MessageTittle.Location = new System.Drawing.Point(12, 12);
            this.val_MessageTittle.Name = "val_MessageTittle";
            this.val_MessageTittle.Size = new System.Drawing.Size(682, 34);
            this.val_MessageTittle.TabIndex = 0;
            this.val_MessageTittle.Text = "...";
            this.val_MessageTittle.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Exit.Location = new System.Drawing.Point(700, 10);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(38, 36);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.Symbol = "";
            this.btn_Exit.TabIndex = 1;
            // 
            // val_MessageContext
            // 
            // 
            // 
            // 
            this.val_MessageContext.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_MessageContext.Location = new System.Drawing.Point(132, 52);
            this.val_MessageContext.Name = "val_MessageContext";
            this.val_MessageContext.Size = new System.Drawing.Size(606, 366);
            this.val_MessageContext.TabIndex = 2;
            this.val_MessageContext.Text = "...";
            this.val_MessageContext.TextLineAlignment = System.Drawing.StringAlignment.Near;
            this.val_MessageContext.WordWrap = true;
            // 
            // pic_Announce
            // 
            this.pic_Announce.Image = global::AutomationSystem.Properties.Resources._16_Announce;
            this.pic_Announce.Location = new System.Drawing.Point(12, 302);
            this.pic_Announce.Name = "pic_Announce";
            this.pic_Announce.Size = new System.Drawing.Size(114, 116);
            this.pic_Announce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Announce.TabIndex = 3;
            this.pic_Announce.TabStop = false;
            // 
            // frmUserNewMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 430);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmUserNewMessage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Announce)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.LabelX val_MessageTittle;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
        private DevComponents.DotNetBar.LabelX val_MessageContext;
        private System.Windows.Forms.PictureBox pic_Announce;
    }
}