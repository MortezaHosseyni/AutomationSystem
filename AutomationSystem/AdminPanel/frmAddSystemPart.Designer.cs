namespace AutomationSystem.AdminPanel
{
    partial class frmAddSystemPart
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
            this.lbl_PartName = new DevComponents.DotNetBar.LabelX();
            this.lbl_PartDetail = new DevComponents.DotNetBar.LabelX();
            this.txt_SPartName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_SPartDetail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_Save = new DevComponents.DotNetBar.ButtonX();
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Main.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_Main.Controls.Add(this.btn_Exit);
            this.pnl_Main.Controls.Add(this.btn_Save);
            this.pnl_Main.Controls.Add(this.txt_SPartDetail);
            this.pnl_Main.Controls.Add(this.txt_SPartName);
            this.pnl_Main.Controls.Add(this.lbl_PartDetail);
            this.pnl_Main.Controls.Add(this.lbl_PartName);
            this.pnl_Main.Controls.Add(this.lbl_Title);
            this.pnl_Main.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(573, 346);
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
            this.lbl_Title.Font = new System.Drawing.Font("B Nazanin", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Title.Location = new System.Drawing.Point(213, 12);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(139, 47);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "افزودن اجزاء";
            // 
            // lbl_PartName
            // 
            this.lbl_PartName.AutoSize = true;
            // 
            // 
            // 
            this.lbl_PartName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_PartName.Location = new System.Drawing.Point(473, 87);
            this.lbl_PartName.Name = "lbl_PartName";
            this.lbl_PartName.Size = new System.Drawing.Size(21, 33);
            this.lbl_PartName.TabIndex = 1;
            this.lbl_PartName.Text = "نام:";
            // 
            // lbl_PartDetail
            // 
            this.lbl_PartDetail.AutoSize = true;
            // 
            // 
            // 
            this.lbl_PartDetail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_PartDetail.Location = new System.Drawing.Point(473, 140);
            this.lbl_PartDetail.Name = "lbl_PartDetail";
            this.lbl_PartDetail.Size = new System.Drawing.Size(61, 33);
            this.lbl_PartDetail.TabIndex = 1;
            this.lbl_PartDetail.Text = "توضيحات:";
            // 
            // txt_SPartName
            // 
            // 
            // 
            // 
            this.txt_SPartName.Border.Class = "TextBoxBorder";
            this.txt_SPartName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SPartName.Location = new System.Drawing.Point(71, 84);
            this.txt_SPartName.Name = "txt_SPartName";
            this.txt_SPartName.PreventEnterBeep = true;
            this.txt_SPartName.Size = new System.Drawing.Size(396, 36);
            this.txt_SPartName.TabIndex = 1;
            this.txt_SPartName.WatermarkText = "نام جزء سيستم...";
            // 
            // txt_SPartDetail
            // 
            // 
            // 
            // 
            this.txt_SPartDetail.Border.Class = "TextBoxBorder";
            this.txt_SPartDetail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SPartDetail.Location = new System.Drawing.Point(71, 126);
            this.txt_SPartDetail.Multiline = true;
            this.txt_SPartDetail.Name = "txt_SPartDetail";
            this.txt_SPartDetail.PreventEnterBeep = true;
            this.txt_SPartDetail.Size = new System.Drawing.Size(396, 137);
            this.txt_SPartDetail.TabIndex = 2;
            this.txt_SPartDetail.WatermarkText = "توضيحاتي درمورد اجزاء...";
            // 
            // btn_Save
            // 
            this.btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Save.Location = new System.Drawing.Point(270, 280);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20, 2, 2, 20);
            this.btn_Save.Size = new System.Drawing.Size(183, 42);
            this.btn_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Save.Symbol = "";
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "ثبت";
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Exit.Location = new System.Drawing.Point(81, 280);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20, 2, 2, 20);
            this.btn_Exit.Size = new System.Drawing.Size(183, 42);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.Symbol = "";
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "خروج";
            // 
            // frmAddSystemPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 346);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmAddSystemPart";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnl_Main;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SPartDetail;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SPartName;
        private DevComponents.DotNetBar.LabelX lbl_PartDetail;
        private DevComponents.DotNetBar.LabelX lbl_PartName;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
        private DevComponents.DotNetBar.ButtonX btn_Save;
    }
}