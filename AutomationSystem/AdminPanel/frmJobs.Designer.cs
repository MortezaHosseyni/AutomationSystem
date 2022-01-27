namespace AutomationSystem.AdminPanel
{
    partial class frmJobs
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
            this.lbl_Tittle = new DevComponents.DotNetBar.LabelX();
            this.pnl_Opreations = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.pnl_Jobs = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_NewJob = new DevComponents.DotNetBar.ButtonX();
            this.btn_EditJob = new DevComponents.DotNetBar.ButtonX();
            this.lbl_HintOne = new DevComponents.DotNetBar.LabelX();
            this.lbl_HintTwo = new DevComponents.DotNetBar.LabelX();
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.trv_Jobs = new System.Windows.Forms.TreeView();
            this.pnl_Main.SuspendLayout();
            this.pnl_Opreations.SuspendLayout();
            this.pnl_Jobs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.pnl_Jobs);
            this.pnl_Main.Controls.Add(this.pnl_Opreations);
            this.pnl_Main.Controls.Add(this.lbl_Tittle);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(740, 565);
            this.pnl_Main.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl_Main.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Main.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Main.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl_Main.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Main.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Main.Style.GradientAngle = 90;
            this.pnl_Main.TabIndex = 1;
            // 
            // lbl_Tittle
            // 
            // 
            // 
            // 
            this.lbl_Tittle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Tittle.Font = new System.Drawing.Font("B Nazanin", 22.25F);
            this.lbl_Tittle.Location = new System.Drawing.Point(313, 12);
            this.lbl_Tittle.Name = "lbl_Tittle";
            this.lbl_Tittle.Size = new System.Drawing.Size(102, 51);
            this.lbl_Tittle.Symbol = "";
            this.lbl_Tittle.TabIndex = 0;
            this.lbl_Tittle.Text = "مشاغل";
            // 
            // pnl_Opreations
            // 
            this.pnl_Opreations.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Opreations.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Opreations.Controls.Add(this.lbl_HintTwo);
            this.pnl_Opreations.Controls.Add(this.lbl_HintOne);
            this.pnl_Opreations.Controls.Add(this.btn_Exit);
            this.pnl_Opreations.Controls.Add(this.btn_EditJob);
            this.pnl_Opreations.Controls.Add(this.btn_NewJob);
            this.pnl_Opreations.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Opreations.Location = new System.Drawing.Point(515, 74);
            this.pnl_Opreations.Name = "pnl_Opreations";
            this.pnl_Opreations.Size = new System.Drawing.Size(213, 479);
            // 
            // 
            // 
            this.pnl_Opreations.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Opreations.Style.BackColorGradientAngle = 90;
            this.pnl_Opreations.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Opreations.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Opreations.Style.BorderBottomWidth = 1;
            this.pnl_Opreations.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Opreations.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Opreations.Style.BorderLeftWidth = 1;
            this.pnl_Opreations.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Opreations.Style.BorderRightWidth = 1;
            this.pnl_Opreations.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Opreations.Style.BorderTopWidth = 1;
            this.pnl_Opreations.Style.CornerDiameter = 4;
            this.pnl_Opreations.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_Opreations.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_Opreations.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Opreations.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_Opreations.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_Opreations.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_Opreations.TabIndex = 1;
            this.pnl_Opreations.Text = "عمليات";
            // 
            // pnl_Jobs
            // 
            this.pnl_Jobs.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Jobs.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Jobs.Controls.Add(this.trv_Jobs);
            this.pnl_Jobs.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Jobs.Location = new System.Drawing.Point(12, 74);
            this.pnl_Jobs.Name = "pnl_Jobs";
            this.pnl_Jobs.Size = new System.Drawing.Size(497, 479);
            // 
            // 
            // 
            this.pnl_Jobs.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Jobs.Style.BackColorGradientAngle = 90;
            this.pnl_Jobs.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Jobs.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Jobs.Style.BorderBottomWidth = 1;
            this.pnl_Jobs.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Jobs.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Jobs.Style.BorderLeftWidth = 1;
            this.pnl_Jobs.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Jobs.Style.BorderRightWidth = 1;
            this.pnl_Jobs.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Jobs.Style.BorderTopWidth = 1;
            this.pnl_Jobs.Style.CornerDiameter = 4;
            this.pnl_Jobs.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_Jobs.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_Jobs.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Jobs.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_Jobs.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_Jobs.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_Jobs.TabIndex = 2;
            this.pnl_Jobs.Text = "ليست مشاغل";
            // 
            // btn_NewJob
            // 
            this.btn_NewJob.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_NewJob.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_NewJob.Location = new System.Drawing.Point(3, 15);
            this.btn_NewJob.Name = "btn_NewJob";
            this.btn_NewJob.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 20, 20, 2);
            this.btn_NewJob.Size = new System.Drawing.Size(201, 38);
            this.btn_NewJob.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_NewJob.Symbol = "57404";
            this.btn_NewJob.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn_NewJob.TabIndex = 0;
            this.btn_NewJob.Text = "شغل جديد";
            // 
            // btn_EditJob
            // 
            this.btn_EditJob.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_EditJob.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_EditJob.Location = new System.Drawing.Point(3, 59);
            this.btn_EditJob.Name = "btn_EditJob";
            this.btn_EditJob.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 20, 20, 2);
            this.btn_EditJob.Size = new System.Drawing.Size(201, 38);
            this.btn_EditJob.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_EditJob.Symbol = "57899";
            this.btn_EditJob.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.btn_EditJob.TabIndex = 0;
            this.btn_EditJob.Text = "ويرايش شغل";
            // 
            // lbl_HintOne
            // 
            // 
            // 
            // 
            this.lbl_HintOne.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_HintOne.Location = new System.Drawing.Point(3, 130);
            this.lbl_HintOne.Name = "lbl_HintOne";
            this.lbl_HintOne.Size = new System.Drawing.Size(201, 125);
            this.lbl_HintOne.Symbol = "";
            this.lbl_HintOne.TabIndex = 1;
            this.lbl_HintOne.Text = "براي افزودن شغل جديد در هر قسمت از سازمان ابتدا آن قسمت را انتخاب كنيد و بعد دكمه" +
    " شغل جديد را بزنيد.";
            this.lbl_HintOne.WordWrap = true;
            // 
            // lbl_HintTwo
            // 
            // 
            // 
            // 
            this.lbl_HintTwo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_HintTwo.Location = new System.Drawing.Point(3, 261);
            this.lbl_HintTwo.Name = "lbl_HintTwo";
            this.lbl_HintTwo.Size = new System.Drawing.Size(201, 110);
            this.lbl_HintTwo.Symbol = "";
            this.lbl_HintTwo.TabIndex = 1;
            this.lbl_HintTwo.Text = "براي ويرايش هر شغل ابتدا آن‌را انتخاب كنيد سپس روي دكمه ويرايش شغل كليك كنيد.";
            this.lbl_HintTwo.WordWrap = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Exit.Location = new System.Drawing.Point(3, 401);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 20, 20, 2);
            this.btn_Exit.Size = new System.Drawing.Size(201, 38);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.Symbol = "";
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "خروج";
            // 
            // trv_Jobs
            // 
            this.trv_Jobs.Location = new System.Drawing.Point(3, 3);
            this.trv_Jobs.Name = "trv_Jobs";
            this.trv_Jobs.Size = new System.Drawing.Size(485, 436);
            this.trv_Jobs.TabIndex = 0;
            // 
            // frmJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 565);
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmJobs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Opreations.ResumeLayout(false);
            this.pnl_Jobs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.LabelX lbl_Tittle;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Jobs;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Opreations;
        private DevComponents.DotNetBar.ButtonX btn_EditJob;
        private DevComponents.DotNetBar.ButtonX btn_NewJob;
        private DevComponents.DotNetBar.LabelX lbl_HintOne;
        private DevComponents.DotNetBar.LabelX lbl_HintTwo;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
        private System.Windows.Forms.TreeView trv_Jobs;
    }
}