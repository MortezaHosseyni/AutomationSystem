namespace AutomationSystem.UserPanel
{
    partial class frmUserAddReminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAddReminder));
            this.pnl_Main = new DevComponents.DotNetBar.PanelEx();
            this.pnl_Buttons = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_Save = new DevComponents.DotNetBar.ButtonX();
            this.pnl_Info = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_ReminderCreatedDateValue = new DevComponents.DotNetBar.LabelX();
            this.txt_ReminderDate = new FreeControls.PersianDateTimePicker();
            this.lbl_ReminderCreatedDate = new DevComponents.DotNetBar.LabelX();
            this.lbl_ReminderDate = new DevComponents.DotNetBar.LabelX();
            this.txt_Caption = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_Caption = new DevComponents.DotNetBar.LabelX();
            this.txt_Subject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_Subject = new DevComponents.DotNetBar.LabelX();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.pnl_Main.SuspendLayout();
            this.pnl_Buttons.SuspendLayout();
            this.pnl_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.pnl_Buttons);
            this.pnl_Main.Controls.Add(this.pnl_Info);
            this.pnl_Main.Controls.Add(this.lbl_Title);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Margin = new System.Windows.Forms.Padding(6);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1050, 610);
            this.pnl_Main.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl_Main.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Main.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Main.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl_Main.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Main.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Main.Style.GradientAngle = 90;
            this.pnl_Main.TabIndex = 4;
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Buttons.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Buttons.Controls.Add(this.btn_Save);
            this.pnl_Buttons.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Buttons.Location = new System.Drawing.Point(12, 512);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(1026, 86);
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
            this.btn_Save.Location = new System.Drawing.Point(311, 17);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20, 2, 2, 20);
            this.btn_Save.Size = new System.Drawing.Size(389, 45);
            this.btn_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Save.Symbol = "";
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "ثبت يادآور";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // pnl_Info
            // 
            this.pnl_Info.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Info.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Info.Controls.Add(this.lbl_ReminderCreatedDateValue);
            this.pnl_Info.Controls.Add(this.txt_ReminderDate);
            this.pnl_Info.Controls.Add(this.lbl_ReminderCreatedDate);
            this.pnl_Info.Controls.Add(this.lbl_ReminderDate);
            this.pnl_Info.Controls.Add(this.txt_Caption);
            this.pnl_Info.Controls.Add(this.lbl_Caption);
            this.pnl_Info.Controls.Add(this.txt_Subject);
            this.pnl_Info.Controls.Add(this.lbl_Subject);
            this.pnl_Info.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Info.Location = new System.Drawing.Point(12, 65);
            this.pnl_Info.Name = "pnl_Info";
            this.pnl_Info.Size = new System.Drawing.Size(1026, 441);
            // 
            // 
            // 
            this.pnl_Info.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Info.Style.BackColorGradientAngle = 90;
            this.pnl_Info.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Info.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Info.Style.BorderBottomWidth = 1;
            this.pnl_Info.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Info.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Info.Style.BorderLeftWidth = 1;
            this.pnl_Info.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Info.Style.BorderRightWidth = 1;
            this.pnl_Info.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Info.Style.BorderTopWidth = 1;
            this.pnl_Info.Style.CornerDiameter = 4;
            this.pnl_Info.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_Info.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_Info.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Info.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_Info.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_Info.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_Info.TabIndex = 1;
            this.pnl_Info.Text = "جزئيات يادآور";
            // 
            // lbl_ReminderCreatedDateValue
            // 
            this.lbl_ReminderCreatedDateValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lbl_ReminderCreatedDateValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_ReminderCreatedDateValue.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_ReminderCreatedDateValue.ForeColor = System.Drawing.Color.Red;
            this.lbl_ReminderCreatedDateValue.Location = new System.Drawing.Point(23, 107);
            this.lbl_ReminderCreatedDateValue.Name = "lbl_ReminderCreatedDateValue";
            this.lbl_ReminderCreatedDateValue.Size = new System.Drawing.Size(329, 36);
            this.lbl_ReminderCreatedDateValue.TabIndex = 5;
            this.lbl_ReminderCreatedDateValue.Text = "...";
            this.lbl_ReminderCreatedDateValue.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // txt_ReminderDate
            // 
            this.txt_ReminderDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_ReminderDate.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ReminderDate.Location = new System.Drawing.Point(23, 24);
            this.txt_ReminderDate.Name = "txt_ReminderDate";
            this.txt_ReminderDate.ShowTime = false;
            this.txt_ReminderDate.Size = new System.Drawing.Size(329, 36);
            this.txt_ReminderDate.TabIndex = 3;
            this.txt_ReminderDate.Text = "persianDateTimePicker1";
            this.txt_ReminderDate.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_ReminderDate.Value")));
            // 
            // lbl_ReminderCreatedDate
            // 
            // 
            // 
            // 
            this.lbl_ReminderCreatedDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_ReminderCreatedDate.Location = new System.Drawing.Point(358, 107);
            this.lbl_ReminderCreatedDate.Name = "lbl_ReminderCreatedDate";
            this.lbl_ReminderCreatedDate.Size = new System.Drawing.Size(63, 31);
            this.lbl_ReminderCreatedDate.TabIndex = 3;
            this.lbl_ReminderCreatedDate.Text = "تاريخ ثبت:";
            // 
            // lbl_ReminderDate
            // 
            // 
            // 
            // 
            this.lbl_ReminderDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_ReminderDate.Location = new System.Drawing.Point(358, 22);
            this.lbl_ReminderDate.Name = "lbl_ReminderDate";
            this.lbl_ReminderDate.Size = new System.Drawing.Size(84, 31);
            this.lbl_ReminderDate.TabIndex = 2;
            this.lbl_ReminderDate.Text = "تاريخ يادآوري:";
            // 
            // txt_Caption
            // 
            this.txt_Caption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txt_Caption.Border.Class = "TextBoxBorder";
            this.txt_Caption.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Caption.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Caption.Location = new System.Drawing.Point(501, 64);
            this.txt_Caption.Multiline = true;
            this.txt_Caption.Name = "txt_Caption";
            this.txt_Caption.PreventEnterBeep = true;
            this.txt_Caption.Size = new System.Drawing.Size(418, 257);
            this.txt_Caption.TabIndex = 2;
            this.txt_Caption.WatermarkText = "توضيحاتي درمورد يادآوري...";
            // 
            // lbl_Caption
            // 
            // 
            // 
            // 
            this.lbl_Caption.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Caption.Location = new System.Drawing.Point(925, 107);
            this.lbl_Caption.Name = "lbl_Caption";
            this.lbl_Caption.Size = new System.Drawing.Size(62, 31);
            this.lbl_Caption.TabIndex = 0;
            this.lbl_Caption.Text = "توضيحات:";
            // 
            // txt_Subject
            // 
            this.txt_Subject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txt_Subject.Border.Class = "TextBoxBorder";
            this.txt_Subject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Subject.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Subject.Location = new System.Drawing.Point(501, 22);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.PreventEnterBeep = true;
            this.txt_Subject.Size = new System.Drawing.Size(418, 38);
            this.txt_Subject.TabIndex = 1;
            this.txt_Subject.WatermarkText = "موضوع يادآوري...";
            // 
            // lbl_Subject
            // 
            // 
            // 
            // 
            this.lbl_Subject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Subject.Location = new System.Drawing.Point(925, 22);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(48, 31);
            this.lbl_Subject.TabIndex = 0;
            this.lbl_Subject.Text = "موضوع:";
            // 
            // lbl_Title
            // 
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("B Nazanin", 25.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.Location = new System.Drawing.Point(441, 6);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(6);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(168, 50);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "ثبت يادآورد";
            // 
            // frmUserAddReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmUserAddReminder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmUserAddReminder_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Buttons.ResumeLayout(false);
            this.pnl_Info.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Buttons;
        private DevComponents.DotNetBar.ButtonX btn_Save;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Info;
        private DevComponents.DotNetBar.LabelX lbl_ReminderCreatedDateValue;
        private FreeControls.PersianDateTimePicker txt_ReminderDate;
        private DevComponents.DotNetBar.LabelX lbl_ReminderCreatedDate;
        private DevComponents.DotNetBar.LabelX lbl_ReminderDate;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Caption;
        private DevComponents.DotNetBar.LabelX lbl_Caption;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Subject;
        private DevComponents.DotNetBar.LabelX lbl_Subject;
        private DevComponents.DotNetBar.LabelX lbl_Title;
    }
}