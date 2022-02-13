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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Main = new DevComponents.DotNetBar.PanelEx();
            this.val_AllDoneWorks = new DevComponents.DotNetBar.LabelX();
            this.val_AllWorksTime = new DevComponents.DotNetBar.LabelX();
            this.lbl_AllWorksTime = new DevComponents.DotNetBar.LabelX();
            this.lbl_AllDoneWorks = new DevComponents.DotNetBar.LabelX();
            this.pnl_WorksChart = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.crt_UserWorkStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnl_UserWorks = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv_UserWorks = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_WorkID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WorkSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WorkCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WorkRequesterUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WorkJobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WorkDoneTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_WorkDoneDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_SubPersonels = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.trv_SubPersonels = new System.Windows.Forms.TreeView();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.lbl_MaxWorkTime = new DevComponents.DotNetBar.LabelX();
            this.val_MaxWorkTime = new DevComponents.DotNetBar.LabelX();
            this.pnl_Main.SuspendLayout();
            this.pnl_WorksChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crt_UserWorkStatus)).BeginInit();
            this.pnl_UserWorks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserWorks)).BeginInit();
            this.pnl_SubPersonels.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.val_AllDoneWorks);
            this.pnl_Main.Controls.Add(this.val_MaxWorkTime);
            this.pnl_Main.Controls.Add(this.lbl_MaxWorkTime);
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
            // val_AllDoneWorks
            // 
            this.val_AllDoneWorks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.val_AllDoneWorks.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_AllDoneWorks.Location = new System.Drawing.Point(613, 481);
            this.val_AllDoneWorks.Name = "val_AllDoneWorks";
            this.val_AllDoneWorks.Size = new System.Drawing.Size(290, 33);
            this.val_AllDoneWorks.TabIndex = 4;
            this.val_AllDoneWorks.Text = "...";
            this.val_AllDoneWorks.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // val_AllWorksTime
            // 
            this.val_AllWorksTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.val_AllWorksTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_AllWorksTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.val_AllWorksTime.Location = new System.Drawing.Point(613, 520);
            this.val_AllWorksTime.Name = "val_AllWorksTime";
            this.val_AllWorksTime.Size = new System.Drawing.Size(290, 33);
            this.val_AllWorksTime.TabIndex = 4;
            this.val_AllWorksTime.Text = "...";
            this.val_AllWorksTime.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lbl_AllWorksTime
            // 
            this.lbl_AllWorksTime.AutoSize = true;
            // 
            // 
            // 
            this.lbl_AllWorksTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_AllWorksTime.Location = new System.Drawing.Point(909, 520);
            this.lbl_AllWorksTime.Name = "lbl_AllWorksTime";
            this.lbl_AllWorksTime.Size = new System.Drawing.Size(118, 33);
            this.lbl_AllWorksTime.TabIndex = 4;
            this.lbl_AllWorksTime.Text = "مجموعه زمان كاري:";
            // 
            // lbl_AllDoneWorks
            // 
            this.lbl_AllDoneWorks.AutoSize = true;
            // 
            // 
            // 
            this.lbl_AllDoneWorks.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_AllDoneWorks.Location = new System.Drawing.Point(909, 481);
            this.lbl_AllDoneWorks.Name = "lbl_AllDoneWorks";
            this.lbl_AllDoneWorks.Size = new System.Drawing.Size(110, 33);
            this.lbl_AllDoneWorks.TabIndex = 4;
            this.lbl_AllDoneWorks.Text = "كارهاي انجام شده:";
            // 
            // pnl_WorksChart
            // 
            this.pnl_WorksChart.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_WorksChart.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_WorksChart.Controls.Add(this.crt_UserWorkStatus);
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
            // crt_UserWorkStatus
            // 
            this.crt_UserWorkStatus.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.crt_UserWorkStatus.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.crt_UserWorkStatus.Legends.Add(legend1);
            this.crt_UserWorkStatus.Location = new System.Drawing.Point(3, 3);
            this.crt_UserWorkStatus.Name = "crt_UserWorkStatus";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.crt_UserWorkStatus.Series.Add(series1);
            this.crt_UserWorkStatus.Size = new System.Drawing.Size(559, 260);
            this.crt_UserWorkStatus.TabIndex = 0;
            this.crt_UserWorkStatus.Text = "chart1";
            // 
            // pnl_UserWorks
            // 
            this.pnl_UserWorks.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_UserWorks.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_UserWorks.Controls.Add(this.dgv_UserWorks);
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
            // dgv_UserWorks
            // 
            this.dgv_UserWorks.AllowUserToAddRows = false;
            this.dgv_UserWorks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_UserWorks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_UserWorks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_UserWorks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserWorks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_WorkID,
            this.col_WorkSubject,
            this.col_WorkCaption,
            this.col_WorkRequesterUnit,
            this.col_WorkJobID,
            this.col_WorkDoneTime,
            this.col_WorkDoneDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_UserWorks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_UserWorks.EnableHeadersVisualStyles = false;
            this.dgv_UserWorks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_UserWorks.Location = new System.Drawing.Point(3, 3);
            this.dgv_UserWorks.Name = "dgv_UserWorks";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_UserWorks.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_UserWorks.Size = new System.Drawing.Size(559, 189);
            this.dgv_UserWorks.TabIndex = 1;
            // 
            // col_WorkID
            // 
            this.col_WorkID.HeaderText = "WorkID";
            this.col_WorkID.Name = "col_WorkID";
            this.col_WorkID.Visible = false;
            // 
            // col_WorkSubject
            // 
            this.col_WorkSubject.HeaderText = "موضوع";
            this.col_WorkSubject.Name = "col_WorkSubject";
            this.col_WorkSubject.Width = 180;
            // 
            // col_WorkCaption
            // 
            this.col_WorkCaption.HeaderText = "شرح فعاليت";
            this.col_WorkCaption.Name = "col_WorkCaption";
            this.col_WorkCaption.Width = 250;
            // 
            // col_WorkRequesterUnit
            // 
            this.col_WorkRequesterUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_WorkRequesterUnit.HeaderText = "واحد درخواست كننده";
            this.col_WorkRequesterUnit.Name = "col_WorkRequesterUnit";
            this.col_WorkRequesterUnit.Width = 166;
            // 
            // col_WorkJobID
            // 
            this.col_WorkJobID.HeaderText = "WorkJobID";
            this.col_WorkJobID.Name = "col_WorkJobID";
            this.col_WorkJobID.Visible = false;
            // 
            // col_WorkDoneTime
            // 
            this.col_WorkDoneTime.HeaderText = "مدت زمان انجام";
            this.col_WorkDoneTime.Name = "col_WorkDoneTime";
            this.col_WorkDoneTime.Width = 150;
            // 
            // col_WorkDoneDate
            // 
            this.col_WorkDoneDate.HeaderText = "تاريخ انجام";
            this.col_WorkDoneDate.Name = "col_WorkDoneDate";
            this.col_WorkDoneDate.Width = 120;
            // 
            // pnl_SubPersonels
            // 
            this.pnl_SubPersonels.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_SubPersonels.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_SubPersonels.Controls.Add(this.trv_SubPersonels);
            this.pnl_SubPersonels.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_SubPersonels.Location = new System.Drawing.Point(589, 57);
            this.pnl_SubPersonels.Name = "pnl_SubPersonels";
            this.pnl_SubPersonels.Size = new System.Drawing.Size(449, 408);
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
            this.trv_SubPersonels.RightToLeftLayout = true;
            this.trv_SubPersonels.Size = new System.Drawing.Size(437, 365);
            this.trv_SubPersonels.TabIndex = 0;
            this.trv_SubPersonels.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_SubPersonels_AfterSelect);
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
            // lbl_MaxWorkTime
            // 
            this.lbl_MaxWorkTime.AutoSize = true;
            // 
            // 
            // 
            this.lbl_MaxWorkTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_MaxWorkTime.Location = new System.Drawing.Point(909, 559);
            this.lbl_MaxWorkTime.Name = "lbl_MaxWorkTime";
            this.lbl_MaxWorkTime.Size = new System.Drawing.Size(128, 33);
            this.lbl_MaxWorkTime.TabIndex = 4;
            this.lbl_MaxWorkTime.Text = "بيشترين ساعت كاري:";
            // 
            // val_MaxWorkTime
            // 
            this.val_MaxWorkTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.val_MaxWorkTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_MaxWorkTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.val_MaxWorkTime.Location = new System.Drawing.Point(613, 559);
            this.val_MaxWorkTime.Name = "val_MaxWorkTime";
            this.val_MaxWorkTime.Size = new System.Drawing.Size(290, 33);
            this.val_MaxWorkTime.TabIndex = 4;
            this.val_MaxWorkTime.Text = "...";
            this.val_MaxWorkTime.TextAlignment = System.Drawing.StringAlignment.Center;
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
            this.Activated += new System.EventHandler(this.frmUserShowPersonelsFunction_Activated);
            this.Load += new System.EventHandler(this.frmUserShowPersonelsFunction_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.pnl_WorksChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crt_UserWorkStatus)).EndInit();
            this.pnl_UserWorks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserWorks)).EndInit();
            this.pnl_SubPersonels.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_SubPersonels;
        private System.Windows.Forms.TreeView trv_SubPersonels;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_UserWorks;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_WorksChart;
        private DevComponents.DotNetBar.LabelX lbl_AllDoneWorks;
        private DevComponents.DotNetBar.LabelX lbl_AllWorksTime;
        private DevComponents.DotNetBar.LabelX val_AllDoneWorks;
        private DevComponents.DotNetBar.LabelX val_AllWorksTime;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_UserWorks;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WorkID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WorkSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WorkCaption;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WorkRequesterUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WorkJobID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WorkDoneTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_WorkDoneDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart crt_UserWorkStatus;
        private DevComponents.DotNetBar.LabelX val_MaxWorkTime;
        private DevComponents.DotNetBar.LabelX lbl_MaxWorkTime;
    }
}