namespace AutomationSystem.AdminPanel
{
    partial class frmSystemComponents
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
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.btn_AddComponent = new DevComponents.DotNetBar.ButtonX();
            this.pnl_ComponentsList = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.trv_SystemComponents = new System.Windows.Forms.TreeView();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.pnl_Main.SuspendLayout();
            this.pnl_ComponentsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.btn_Exit);
            this.pnl_Main.Controls.Add(this.btn_AddComponent);
            this.pnl_Main.Controls.Add(this.pnl_ComponentsList);
            this.pnl_Main.Controls.Add(this.lbl_Title);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(517, 541);
            this.pnl_Main.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl_Main.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Main.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Main.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl_Main.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Main.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Main.Style.GradientAngle = 90;
            this.pnl_Main.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Exit.Location = new System.Drawing.Point(102, 488);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 2, 10, 10);
            this.btn_Exit.Size = new System.Drawing.Size(155, 41);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.Symbol = "";
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "خروج";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_AddComponent
            // 
            this.btn_AddComponent.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_AddComponent.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_AddComponent.Location = new System.Drawing.Point(263, 488);
            this.btn_AddComponent.Name = "btn_AddComponent";
            this.btn_AddComponent.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 2, 10, 10);
            this.btn_AddComponent.Size = new System.Drawing.Size(155, 41);
            this.btn_AddComponent.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_AddComponent.Symbol = "";
            this.btn_AddComponent.TabIndex = 2;
            this.btn_AddComponent.Text = "تعريف اجزاء";
            // 
            // pnl_ComponentsList
            // 
            this.pnl_ComponentsList.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_ComponentsList.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_ComponentsList.Controls.Add(this.trv_SystemComponents);
            this.pnl_ComponentsList.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_ComponentsList.Location = new System.Drawing.Point(12, 65);
            this.pnl_ComponentsList.Name = "pnl_ComponentsList";
            this.pnl_ComponentsList.Size = new System.Drawing.Size(493, 417);
            // 
            // 
            // 
            this.pnl_ComponentsList.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_ComponentsList.Style.BackColorGradientAngle = 90;
            this.pnl_ComponentsList.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_ComponentsList.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_ComponentsList.Style.BorderBottomWidth = 1;
            this.pnl_ComponentsList.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_ComponentsList.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_ComponentsList.Style.BorderLeftWidth = 1;
            this.pnl_ComponentsList.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_ComponentsList.Style.BorderRightWidth = 1;
            this.pnl_ComponentsList.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_ComponentsList.Style.BorderTopWidth = 1;
            this.pnl_ComponentsList.Style.CornerDiameter = 4;
            this.pnl_ComponentsList.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_ComponentsList.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_ComponentsList.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_ComponentsList.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_ComponentsList.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_ComponentsList.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_ComponentsList.TabIndex = 1;
            this.pnl_ComponentsList.Text = "ليست اجزاء سيستم";
            // 
            // trv_SystemComponents
            // 
            this.trv_SystemComponents.Location = new System.Drawing.Point(3, 3);
            this.trv_SystemComponents.Name = "trv_SystemComponents";
            this.trv_SystemComponents.RightToLeftLayout = true;
            this.trv_SystemComponents.Size = new System.Drawing.Size(481, 374);
            this.trv_SystemComponents.TabIndex = 0;
            // 
            // lbl_Title
            // 
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("B Nazanin", 22.25F);
            this.lbl_Title.Location = new System.Drawing.Point(182, 3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(148, 56);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "اجزاء سيستم";
            // 
            // frmSystemComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 541);
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmSystemComponents";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmSystemComponents_Activated);
            this.Load += new System.EventHandler(this.frmSystemComponents_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_ComponentsList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.ButtonX btn_AddComponent;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_ComponentsList;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
        private System.Windows.Forms.TreeView trv_SystemComponents;
    }
}