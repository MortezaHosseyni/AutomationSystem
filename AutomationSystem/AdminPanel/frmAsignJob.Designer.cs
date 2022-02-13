namespace AutomationSystem.AdminPanel
{
    partial class frmAsignJob
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
            this.components = new System.ComponentModel.Container();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.lbl_AsignJobTo = new DevComponents.DotNetBar.LabelX();
            this.val_AsignJobOn = new DevComponents.DotNetBar.LabelX();
            this.lbl_Info = new DevComponents.DotNetBar.LabelX();
            this.pnl_JobsList = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.pnl_Buttons = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.trv_JobsList = new System.Windows.Forms.TreeView();
            this.btn_Save = new DevComponents.DotNetBar.ButtonX();
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panelEx1.SuspendLayout();
            this.pnl_JobsList.SuspendLayout();
            this.pnl_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.pnl_Buttons);
            this.panelEx1.Controls.Add(this.pnl_JobsList);
            this.panelEx1.Controls.Add(this.lbl_Info);
            this.panelEx1.Controls.Add(this.val_AsignJobOn);
            this.panelEx1.Controls.Add(this.lbl_AsignJobTo);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(682, 607);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // lbl_AsignJobTo
            // 
            // 
            // 
            // 
            this.lbl_AsignJobTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_AsignJobTo.Font = new System.Drawing.Font("B Nazanin", 20.25F);
            this.lbl_AsignJobTo.Location = new System.Drawing.Point(362, 12);
            this.lbl_AsignJobTo.Name = "lbl_AsignJobTo";
            this.lbl_AsignJobTo.Size = new System.Drawing.Size(127, 45);
            this.lbl_AsignJobTo.TabIndex = 0;
            this.lbl_AsignJobTo.Text = "انتساب شغل به";
            // 
            // val_AsignJobOn
            // 
            // 
            // 
            // 
            this.val_AsignJobOn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_AsignJobOn.Font = new System.Drawing.Font("B Nazanin", 20.25F);
            this.val_AsignJobOn.ForeColor = System.Drawing.Color.Blue;
            this.val_AsignJobOn.Location = new System.Drawing.Point(12, 12);
            this.val_AsignJobOn.Name = "val_AsignJobOn";
            this.val_AsignJobOn.Size = new System.Drawing.Size(344, 45);
            this.val_AsignJobOn.TabIndex = 0;
            this.val_AsignJobOn.Text = "نام و نام خانوادگي";
            // 
            // lbl_Info
            // 
            // 
            // 
            // 
            this.lbl_Info.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Info.Font = new System.Drawing.Font("B Nazanin", 16.25F);
            this.lbl_Info.Location = new System.Drawing.Point(127, 63);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(411, 30);
            this.lbl_Info.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_Info.TabIndex = 1;
            this.lbl_Info.Text = "توجه: هر كاربر فقط مي‌تواند يك شغل در سيستم داشته باشد.";
            // 
            // pnl_JobsList
            // 
            this.pnl_JobsList.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_JobsList.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_JobsList.Controls.Add(this.trv_JobsList);
            this.pnl_JobsList.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_JobsList.Location = new System.Drawing.Point(12, 99);
            this.pnl_JobsList.Name = "pnl_JobsList";
            this.pnl_JobsList.Size = new System.Drawing.Size(658, 384);
            // 
            // 
            // 
            this.pnl_JobsList.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_JobsList.Style.BackColorGradientAngle = 90;
            this.pnl_JobsList.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_JobsList.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_JobsList.Style.BorderBottomWidth = 1;
            this.pnl_JobsList.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_JobsList.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_JobsList.Style.BorderLeftWidth = 1;
            this.pnl_JobsList.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_JobsList.Style.BorderRightWidth = 1;
            this.pnl_JobsList.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_JobsList.Style.BorderTopWidth = 1;
            this.pnl_JobsList.Style.CornerDiameter = 4;
            this.pnl_JobsList.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_JobsList.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_JobsList.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_JobsList.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_JobsList.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_JobsList.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_JobsList.TabIndex = 2;
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Buttons.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Buttons.Controls.Add(this.btn_Exit);
            this.pnl_Buttons.Controls.Add(this.btn_Save);
            this.pnl_Buttons.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Buttons.Location = new System.Drawing.Point(12, 489);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(658, 100);
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
            this.pnl_Buttons.TabIndex = 3;
            // 
            // trv_JobsList
            // 
            this.trv_JobsList.CheckBoxes = true;
            this.trv_JobsList.Location = new System.Drawing.Point(3, 3);
            this.trv_JobsList.Name = "trv_JobsList";
            this.trv_JobsList.RightToLeftLayout = true;
            this.trv_JobsList.Size = new System.Drawing.Size(646, 372);
            this.trv_JobsList.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Save.Location = new System.Drawing.Point(326, 20);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20, 2, 2, 20);
            this.btn_Save.Size = new System.Drawing.Size(208, 50);
            this.btn_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Save.Symbol = "";
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "ثبت";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Exit.Location = new System.Drawing.Point(112, 20);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20, 2, 2, 20);
            this.btn_Exit.Size = new System.Drawing.Size(208, 50);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.Symbol = "";
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "خروج";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmAsignJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 607);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmAsignJob";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.frmAsignJob_Activated);
            this.Load += new System.EventHandler(this.frmAsignJob_Load);
            this.panelEx1.ResumeLayout(false);
            this.pnl_JobsList.ResumeLayout(false);
            this.pnl_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX lbl_AsignJobTo;
        private DevComponents.DotNetBar.LabelX lbl_Info;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_JobsList;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Buttons;
        private System.Windows.Forms.TreeView trv_JobsList;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
        private DevComponents.DotNetBar.ButtonX btn_Save;
        private System.Windows.Forms.ImageList imageList;
        internal DevComponents.DotNetBar.LabelX val_AsignJobOn;
    }
}