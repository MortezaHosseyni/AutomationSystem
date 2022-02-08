namespace AutomationSystem.UserPanel
{
    partial class frmUserShowPersonelsFunction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Main = new DevComponents.DotNetBar.PanelEx();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.pnl_SubPersonels = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.trv_SubPersonels = new System.Windows.Forms.TreeView();
            this.pnl_UserWorks = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv_PersonelWorks = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.pnl_WorksChart = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_AllDoneWorks = new DevComponents.DotNetBar.LabelX();
            this.lbl_AllWorksTime = new DevComponents.DotNetBar.LabelX();
            this.val_AllWorksTime = new DevComponents.DotNetBar.LabelX();
            this.val_AllDoneWorks = new DevComponents.DotNetBar.LabelX();
            this.pnl_Main.SuspendLayout();
            this.pnl_SubPersonels.SuspendLayout();
            this.pnl_UserWorks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PersonelWorks)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.val_AllDoneWorks);
            this.pnl_Main.Controls.Add(this.val_AllWorksTime);
            this.pnl_Main.Controls.Add(this.lbl_AllWorksTime);
            this.pnl_Main.Controls.Add(this.lbl_AllDoneWorks);
            this.pnl_Main.Controls.Add(this.pnl_WorksChart);
            this.pnl_Main.Controls.Add(this.pnl_UserWorks);
            this.pnl_Main.Controls.Add(this.pnl_SubPersonels);
            this.pnl_Main.Controls.Add(this.lbl_Title);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1050, 610);
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
            this.lbl_Title.Location = new System.Drawing.Point(439, 3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(159, 48);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "كاركرد پرسنل";
            // 
            // pnl_SubPersonels
            // 
            this.pnl_SubPersonels.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_SubPersonels.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_SubPersonels.Controls.Add(this.trv_SubPersonels);
            this.pnl_SubPersonels.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_SubPersonels.Location = new System.Drawing.Point(589, 57);
            this.pnl_SubPersonels.Name = "pnl_SubPersonels";
            this.pnl_SubPersonels.Size = new System.Drawing.Size(449, 440);
            // 
            // 
            // 
            this.pnl_SubPersonels.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_SubPersonels.Style.BackColorGradientAngle = 90;
            this.pnl_SubPersonels.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_SubPersonels.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SubPersonels.Style.BorderBottomWidth = 1;
            this.pnl_SubPersonels.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_SubPersonels.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SubPersonels.Style.BorderLeftWidth = 1;
            this.pnl_SubPersonels.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SubPersonels.Style.BorderRightWidth = 1;
            this.pnl_SubPersonels.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SubPersonels.Style.BorderTopWidth = 1;
            this.pnl_SubPersonels.Style.CornerDiameter = 4;
            this.pnl_SubPersonels.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_SubPersonels.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_SubPersonels.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_SubPersonels.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_SubPersonels.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_SubPersonels.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_SubPersonels.TabIndex = 1;
            this.pnl_SubPersonels.Text = "زيرمجموعه‌هاي شما";
            // 
            // trv_SubPersonels
            // 
            this.trv_SubPersonels.Location = new System.Drawing.Point(3, 3);
            this.trv_SubPersonels.Name = "trv_SubPersonels";
            this.trv_SubPersonels.Size = new System.Drawing.Size(437, 397);
            this.trv_SubPersonels.TabIndex = 0;
            // 
            // pnl_UserWorks
            // 
            this.pnl_UserWorks.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_UserWorks.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_UserWorks.Controls.Add(this.dgv_PersonelWorks);
            this.pnl_UserWorks.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_UserWorks.Location = new System.Drawing.Point(12, 57);
            this.pnl_UserWorks.Name = "pnl_UserWorks";
            this.pnl_UserWorks.Size = new System.Drawing.Size(571, 232);
            // 
            // 
            // 
            this.pnl_UserWorks.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_UserWorks.Style.BackColorGradientAngle = 90;
            this.pnl_UserWorks.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_UserWorks.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UserWorks.Style.BorderBottomWidth = 1;
            this.pnl_UserWorks.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_UserWorks.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UserWorks.Style.BorderLeftWidth = 1;
            this.pnl_UserWorks.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UserWorks.Style.BorderRightWidth = 1;
            this.pnl_UserWorks.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UserWorks.Style.BorderTopWidth = 1;
            this.pnl_UserWorks.Style.CornerDiameter = 4;
            this.pnl_UserWorks.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_UserWorks.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_UserWorks.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_UserWorks.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_UserWorks.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_UserWorks.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_UserWorks.TabIndex = 2;
            this.pnl_UserWorks.Text = "فعاليت‌ها";
            // 
            // dgv_PersonelWorks
            // 
            this.dgv_PersonelWorks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_PersonelWorks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_PersonelWorks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_PersonelWorks.Location = new System.Drawing.Point(3, 3);
            this.dgv_PersonelWorks.Name = "dgv_PersonelWorks";
            this.dgv_PersonelWorks.Size = new System.Drawing.Size(559, 189);
            this.dgv_PersonelWorks.TabIndex = 0;
            // 
            // pnl_WorksChart
            // 
            this.pnl_WorksChart.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_WorksChart.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_WorksChart.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_WorksChart.Location = new System.Drawing.Point(12, 295);
            this.pnl_WorksChart.Name = "pnl_WorksChart";
            this.pnl_WorksChart.Size = new System.Drawing.Size(571, 303);
            // 
            // 
            // 
            this.pnl_WorksChart.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_WorksChart.Style.BackColorGradientAngle = 90;
            this.pnl_WorksChart.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_WorksChart.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_WorksChart.Style.BorderBottomWidth = 1;
            this.pnl_WorksChart.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_WorksChart.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_WorksChart.Style.BorderLeftWidth = 1;
            this.pnl_WorksChart.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_WorksChart.Style.BorderRightWidth = 1;
            this.pnl_WorksChart.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_WorksChart.Style.BorderTopWidth = 1;
            this.pnl_WorksChart.Style.CornerDiameter = 4;
            this.pnl_WorksChart.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_WorksChart.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_WorksChart.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_WorksChart.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_WorksChart.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_WorksChart.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_WorksChart.TabIndex = 3;
            this.pnl_WorksChart.Text = "نمودار كاركرد پرسنل";
            // 
            // lbl_AllDoneWorks
            // 
            this.lbl_AllDoneWorks.AutoSize = true;
            // 
            // 
            // 
            this.lbl_AllDoneWorks.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_AllDoneWorks.Location = new System.Drawing.Point(903, 520);
            this.lbl_AllDoneWorks.Name = "lbl_AllDoneWorks";
            this.lbl_AllDoneWorks.Size = new System.Drawing.Size(110, 33);
            this.lbl_AllDoneWorks.TabIndex = 4;
            this.lbl_AllDoneWorks.Text = "كارهاي انجام شده:";
            // 
            // lbl_AllWorksTime
            // 
            this.lbl_AllWorksTime.AutoSize = true;
            // 
            // 
            // 
            this.lbl_AllWorksTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_AllWorksTime.Location = new System.Drawing.Point(903, 559);
            this.lbl_AllWorksTime.Name = "lbl_AllWorksTime";
            this.lbl_AllWorksTime.Size = new System.Drawing.Size(118, 33);
            this.lbl_AllWorksTime.TabIndex = 4;
            this.lbl_AllWorksTime.Text = "مجموعه زمان كاري:";
            // 
            // val_AllWorksTime
            // 
            this.val_AllWorksTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.val_AllWorksTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_AllWorksTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.val_AllWorksTime.Location = new System.Drawing.Point(607, 559);
            this.val_AllWorksTime.Name = "val_AllWorksTime";
            this.val_AllWorksTime.Size = new System.Drawing.Size(290, 33);
            this.val_AllWorksTime.TabIndex = 4;
            this.val_AllWorksTime.Text = "...";
            this.val_AllWorksTime.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // val_AllDoneWorks
            // 
            this.val_AllDoneWorks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.val_AllDoneWorks.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_AllDoneWorks.Location = new System.Drawing.Point(607, 520);
            this.val_AllDoneWorks.Name = "val_AllDoneWorks";
            this.val_AllDoneWorks.Size = new System.Drawing.Size(290, 33);
            this.val_AllDoneWorks.TabIndex = 4;
            this.val_AllDoneWorks.Text = "...";
            this.val_AllDoneWorks.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // frmUserShowPersonelsFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmUserShowPersonelsFunction";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUserShowPersonelsFunction_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.pnl_SubPersonels.ResumeLayout(false);
            this.pnl_UserWorks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PersonelWorks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_SubPersonels;
        private System.Windows.Forms.TreeView trv_SubPersonels;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_UserWorks;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_PersonelWorks;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_WorksChart;
        private DevComponents.DotNetBar.LabelX lbl_AllDoneWorks;
        private DevComponents.DotNetBar.LabelX lbl_AllWorksTime;
        private DevComponents.DotNetBar.LabelX val_AllDoneWorks;
        private DevComponents.DotNetBar.LabelX val_AllWorksTime;
    }
}