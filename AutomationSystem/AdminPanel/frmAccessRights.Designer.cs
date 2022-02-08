namespace AutomationSystem.AdminPanel
{
    partial class frmAccessRights
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
            this.pnl_AccessRights = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.trv_AccessRights = new System.Windows.Forms.TreeView();
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.btn_Save = new DevComponents.DotNetBar.ButtonX();
            this.pnl_Main.SuspendLayout();
            this.pnl_AccessRights.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.btn_Exit);
            this.pnl_Main.Controls.Add(this.btn_Save);
            this.pnl_Main.Controls.Add(this.pnl_AccessRights);
            this.pnl_Main.Controls.Add(this.lbl_Title);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(546, 557);
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
            this.lbl_Title.Location = new System.Drawing.Point(164, 3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(230, 48);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "تايين سطوح دسترسي";
            // 
            // pnl_AccessRights
            // 
            this.pnl_AccessRights.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_AccessRights.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_AccessRights.Controls.Add(this.trv_AccessRights);
            this.pnl_AccessRights.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_AccessRights.Location = new System.Drawing.Point(12, 57);
            this.pnl_AccessRights.Name = "pnl_AccessRights";
            this.pnl_AccessRights.Size = new System.Drawing.Size(522, 438);
            // 
            // 
            // 
            this.pnl_AccessRights.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_AccessRights.Style.BackColorGradientAngle = 90;
            this.pnl_AccessRights.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_AccessRights.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_AccessRights.Style.BorderBottomWidth = 1;
            this.pnl_AccessRights.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_AccessRights.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_AccessRights.Style.BorderLeftWidth = 1;
            this.pnl_AccessRights.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_AccessRights.Style.BorderRightWidth = 1;
            this.pnl_AccessRights.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_AccessRights.Style.BorderTopWidth = 1;
            this.pnl_AccessRights.Style.CornerDiameter = 4;
            this.pnl_AccessRights.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_AccessRights.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_AccessRights.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_AccessRights.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_AccessRights.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_AccessRights.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_AccessRights.TabIndex = 1;
            this.pnl_AccessRights.Text = "سطوح دسترسي";
            // 
            // trv_AccessRights
            // 
            this.trv_AccessRights.Location = new System.Drawing.Point(3, 3);
            this.trv_AccessRights.Name = "trv_AccessRights";
            this.trv_AccessRights.RightToLeftLayout = true;
            this.trv_AccessRights.Size = new System.Drawing.Size(510, 395);
            this.trv_AccessRights.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Exit.Location = new System.Drawing.Point(87, 503);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20, 2, 2, 20);
            this.btn_Exit.Size = new System.Drawing.Size(183, 42);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.Symbol = "";
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "خروج";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Save.Location = new System.Drawing.Point(276, 503);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20, 2, 2, 20);
            this.btn_Save.Size = new System.Drawing.Size(183, 42);
            this.btn_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Save.Symbol = "";
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "ثبت";
            // 
            // frmAccessRights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 557);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmAccessRights";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmAccessRights_Activated);
            this.Load += new System.EventHandler(this.frmAccessRights_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.pnl_AccessRights.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_AccessRights;
        private System.Windows.Forms.TreeView trv_AccessRights;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
        private DevComponents.DotNetBar.ButtonX btn_Save;
    }
}