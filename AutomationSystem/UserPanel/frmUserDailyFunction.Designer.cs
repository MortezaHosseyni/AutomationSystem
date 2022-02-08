namespace AutomationSystem.UserPanel
{
    partial class frmUserDailyFunction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserDailyFunction));
            this.pnl_Main = new DevComponents.DotNetBar.PanelEx();
            this.pnl_AddDailyFunction = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_FunctionDoTime = new DevComponents.DotNetBar.LabelX();
            this.lbl_FunctionRequesterUnit = new DevComponents.DotNetBar.LabelX();
            this.lbl_FunctionDoDate = new DevComponents.DotNetBar.LabelX();
            this.lbl_FunctionCaption = new DevComponents.DotNetBar.LabelX();
            this.lbl_FunctionSubject = new DevComponents.DotNetBar.LabelX();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.txt_FunctionSubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_FunctionCaption = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_FunctionDoTime = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_FunctionDoDate = new FreeControls.PersianDateTimePicker();
            this.cmb_FunctionRequesterUnit = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lbl_FunctionTimeUnit = new DevComponents.DotNetBar.LabelX();
            this.btn_Save = new DevComponents.DotNetBar.ButtonX();
            this.pnl_Main.SuspendLayout();
            this.pnl_AddDailyFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.pnl_AddDailyFunction);
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
            // pnl_AddDailyFunction
            // 
            this.pnl_AddDailyFunction.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_AddDailyFunction.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_AddDailyFunction.Controls.Add(this.btn_Save);
            this.pnl_AddDailyFunction.Controls.Add(this.cmb_FunctionRequesterUnit);
            this.pnl_AddDailyFunction.Controls.Add(this.txt_FunctionDoDate);
            this.pnl_AddDailyFunction.Controls.Add(this.txt_FunctionDoTime);
            this.pnl_AddDailyFunction.Controls.Add(this.txt_FunctionCaption);
            this.pnl_AddDailyFunction.Controls.Add(this.txt_FunctionSubject);
            this.pnl_AddDailyFunction.Controls.Add(this.lbl_FunctionTimeUnit);
            this.pnl_AddDailyFunction.Controls.Add(this.lbl_FunctionDoTime);
            this.pnl_AddDailyFunction.Controls.Add(this.lbl_FunctionRequesterUnit);
            this.pnl_AddDailyFunction.Controls.Add(this.lbl_FunctionDoDate);
            this.pnl_AddDailyFunction.Controls.Add(this.lbl_FunctionCaption);
            this.pnl_AddDailyFunction.Controls.Add(this.lbl_FunctionSubject);
            this.pnl_AddDailyFunction.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_AddDailyFunction.Location = new System.Drawing.Point(12, 57);
            this.pnl_AddDailyFunction.Name = "pnl_AddDailyFunction";
            this.pnl_AddDailyFunction.Size = new System.Drawing.Size(1026, 219);
            // 
            // 
            // 
            this.pnl_AddDailyFunction.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_AddDailyFunction.Style.BackColorGradientAngle = 90;
            this.pnl_AddDailyFunction.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_AddDailyFunction.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_AddDailyFunction.Style.BorderBottomWidth = 1;
            this.pnl_AddDailyFunction.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_AddDailyFunction.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_AddDailyFunction.Style.BorderLeftWidth = 1;
            this.pnl_AddDailyFunction.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_AddDailyFunction.Style.BorderRightWidth = 1;
            this.pnl_AddDailyFunction.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_AddDailyFunction.Style.BorderTopWidth = 1;
            this.pnl_AddDailyFunction.Style.CornerDiameter = 4;
            this.pnl_AddDailyFunction.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_AddDailyFunction.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_AddDailyFunction.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_AddDailyFunction.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_AddDailyFunction.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_AddDailyFunction.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_AddDailyFunction.TabIndex = 1;
            this.pnl_AddDailyFunction.Text = "ثبت فعاليت";
            // 
            // lbl_FunctionDoTime
            // 
            this.lbl_FunctionDoTime.AutoSize = true;
            // 
            // 
            // 
            this.lbl_FunctionDoTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_FunctionDoTime.Location = new System.Drawing.Point(398, 88);
            this.lbl_FunctionDoTime.Name = "lbl_FunctionDoTime";
            this.lbl_FunctionDoTime.Size = new System.Drawing.Size(98, 33);
            this.lbl_FunctionDoTime.TabIndex = 0;
            this.lbl_FunctionDoTime.Text = "مدت زمان انجام:";
            // 
            // lbl_FunctionRequesterUnit
            // 
            this.lbl_FunctionRequesterUnit.AutoSize = true;
            // 
            // 
            // 
            this.lbl_FunctionRequesterUnit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_FunctionRequesterUnit.Location = new System.Drawing.Point(398, 43);
            this.lbl_FunctionRequesterUnit.Name = "lbl_FunctionRequesterUnit";
            this.lbl_FunctionRequesterUnit.Size = new System.Drawing.Size(133, 33);
            this.lbl_FunctionRequesterUnit.TabIndex = 0;
            this.lbl_FunctionRequesterUnit.Text = "واحد درخواست كننده:";
            // 
            // lbl_FunctionDoDate
            // 
            this.lbl_FunctionDoDate.AutoSize = true;
            // 
            // 
            // 
            this.lbl_FunctionDoDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_FunctionDoDate.Location = new System.Drawing.Point(398, 3);
            this.lbl_FunctionDoDate.Name = "lbl_FunctionDoDate";
            this.lbl_FunctionDoDate.Size = new System.Drawing.Size(68, 33);
            this.lbl_FunctionDoDate.TabIndex = 0;
            this.lbl_FunctionDoDate.Text = "تاريخ انجام:";
            // 
            // lbl_FunctionCaption
            // 
            this.lbl_FunctionCaption.AutoSize = true;
            // 
            // 
            // 
            this.lbl_FunctionCaption.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_FunctionCaption.Location = new System.Drawing.Point(866, 48);
            this.lbl_FunctionCaption.Name = "lbl_FunctionCaption";
            this.lbl_FunctionCaption.Size = new System.Drawing.Size(76, 33);
            this.lbl_FunctionCaption.TabIndex = 0;
            this.lbl_FunctionCaption.Text = "شرح فعاليت:";
            // 
            // lbl_FunctionSubject
            // 
            this.lbl_FunctionSubject.AutoSize = true;
            // 
            // 
            // 
            this.lbl_FunctionSubject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_FunctionSubject.Location = new System.Drawing.Point(866, 3);
            this.lbl_FunctionSubject.Name = "lbl_FunctionSubject";
            this.lbl_FunctionSubject.Size = new System.Drawing.Size(45, 33);
            this.lbl_FunctionSubject.TabIndex = 0;
            this.lbl_FunctionSubject.Text = "موضوع:";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("B Nazanin", 22.25F);
            this.lbl_Title.Location = new System.Drawing.Point(430, 3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(193, 48);
            this.lbl_Title.Symbol = "58902";
            this.lbl_Title.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "ثبت كاركرد روزانه";
            // 
            // txt_FunctionSubject
            // 
            // 
            // 
            // 
            this.txt_FunctionSubject.Border.Class = "TextBoxBorder";
            this.txt_FunctionSubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_FunctionSubject.Location = new System.Drawing.Point(579, 3);
            this.txt_FunctionSubject.Name = "txt_FunctionSubject";
            this.txt_FunctionSubject.PreventEnterBeep = true;
            this.txt_FunctionSubject.Size = new System.Drawing.Size(281, 36);
            this.txt_FunctionSubject.TabIndex = 1;
            this.txt_FunctionSubject.WatermarkText = "موضوع فعاليت...";
            // 
            // txt_FunctionCaption
            // 
            // 
            // 
            // 
            this.txt_FunctionCaption.Border.Class = "TextBoxBorder";
            this.txt_FunctionCaption.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_FunctionCaption.Location = new System.Drawing.Point(579, 45);
            this.txt_FunctionCaption.Multiline = true;
            this.txt_FunctionCaption.Name = "txt_FunctionCaption";
            this.txt_FunctionCaption.PreventEnterBeep = true;
            this.txt_FunctionCaption.Size = new System.Drawing.Size(281, 128);
            this.txt_FunctionCaption.TabIndex = 2;
            this.txt_FunctionCaption.WatermarkText = "توضيحاتي درمورد فعاليت...";
            // 
            // txt_FunctionDoTime
            // 
            // 
            // 
            // 
            this.txt_FunctionDoTime.Border.Class = "TextBoxBorder";
            this.txt_FunctionDoTime.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_FunctionDoTime.Location = new System.Drawing.Point(152, 85);
            this.txt_FunctionDoTime.Name = "txt_FunctionDoTime";
            this.txt_FunctionDoTime.PreventEnterBeep = true;
            this.txt_FunctionDoTime.Size = new System.Drawing.Size(240, 36);
            this.txt_FunctionDoTime.TabIndex = 5;
            this.txt_FunctionDoTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_FunctionDoTime.WatermarkText = "زمان";
            this.txt_FunctionDoTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_FunctionDoTime_KeyPress);
            // 
            // txt_FunctionDoDate
            // 
            this.txt_FunctionDoDate.BackColor = System.Drawing.Color.White;
            this.txt_FunctionDoDate.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_FunctionDoDate.Location = new System.Drawing.Point(111, 3);
            this.txt_FunctionDoDate.Name = "txt_FunctionDoDate";
            this.txt_FunctionDoDate.ShowTime = false;
            this.txt_FunctionDoDate.Size = new System.Drawing.Size(281, 34);
            this.txt_FunctionDoDate.TabIndex = 3;
            this.txt_FunctionDoDate.Text = "persianDateTimePicker1";
            this.txt_FunctionDoDate.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_FunctionDoDate.Value")));
            // 
            // cmb_FunctionRequesterUnit
            // 
            this.cmb_FunctionRequesterUnit.DisplayMember = "Text";
            this.cmb_FunctionRequesterUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_FunctionRequesterUnit.FormattingEnabled = true;
            this.cmb_FunctionRequesterUnit.ItemHeight = 30;
            this.cmb_FunctionRequesterUnit.Location = new System.Drawing.Point(111, 43);
            this.cmb_FunctionRequesterUnit.Name = "cmb_FunctionRequesterUnit";
            this.cmb_FunctionRequesterUnit.Size = new System.Drawing.Size(281, 36);
            this.cmb_FunctionRequesterUnit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_FunctionRequesterUnit.TabIndex = 4;
            // 
            // lbl_FunctionTimeUnit
            // 
            this.lbl_FunctionTimeUnit.AutoSize = true;
            // 
            // 
            // 
            this.lbl_FunctionTimeUnit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_FunctionTimeUnit.Location = new System.Drawing.Point(111, 88);
            this.lbl_FunctionTimeUnit.Name = "lbl_FunctionTimeUnit";
            this.lbl_FunctionTimeUnit.Size = new System.Drawing.Size(35, 33);
            this.lbl_FunctionTimeUnit.TabIndex = 0;
            this.lbl_FunctionTimeUnit.Text = "دقيقه";
            // 
            // btn_Save
            // 
            this.btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Save.Location = new System.Drawing.Point(111, 127);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20, 2, 2, 20);
            this.btn_Save.Size = new System.Drawing.Size(420, 46);
            this.btn_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Save.Symbol = "";
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "ثبت كاركرد";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frmUserDailyFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmUserDailyFunction";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUserDailyFunction_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.pnl_AddDailyFunction.ResumeLayout(false);
            this.pnl_AddDailyFunction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_AddDailyFunction;
        private DevComponents.DotNetBar.LabelX lbl_FunctionSubject;
        private DevComponents.DotNetBar.LabelX lbl_FunctionCaption;
        private DevComponents.DotNetBar.LabelX lbl_FunctionDoTime;
        private DevComponents.DotNetBar.LabelX lbl_FunctionRequesterUnit;
        private DevComponents.DotNetBar.LabelX lbl_FunctionDoDate;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_FunctionDoTime;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_FunctionCaption;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_FunctionSubject;
        private FreeControls.PersianDateTimePicker txt_FunctionDoDate;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_FunctionRequesterUnit;
        private DevComponents.DotNetBar.LabelX lbl_FunctionTimeUnit;
        private DevComponents.DotNetBar.ButtonX btn_Save;
    }
}