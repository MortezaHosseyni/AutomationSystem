namespace AutomationSystem.UserPanel
{
    partial class frmUserRecivedReferenceLetters
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserRecivedReferenceLetters));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.dgv_RecivedReferenceLetters = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_LetterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterCreator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterReferencer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterSecurityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterForceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterAnswerDeadLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterReadType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterAttachmentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterReffrence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterFollowingType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterReferenceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RefCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterDownloadAttach = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col_LetterCreatorUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterReplyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SecurityT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ForceT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AttachmentT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterAnswerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterReferencerUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_ArchiveLetter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ReadLetter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ReferenceLetter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_ReplyLetter = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_RecivedReferenceLetters = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_ForcedType = new DevComponents.DotNetBar.LabelX();
            this.lbl_SecurityType = new DevComponents.DotNetBar.LabelX();
            this.lbl_DateTo = new DevComponents.DotNetBar.LabelX();
            this.lbl_ReffrenceTo = new DevComponents.DotNetBar.LabelX();
            this.lbl_LetterSubject = new DevComponents.DotNetBar.LabelX();
            this.lbl_DateOn = new DevComponents.DotNetBar.LabelX();
            this.lbl_LetterNo = new DevComponents.DotNetBar.LabelX();
            this.lbl_Sender = new DevComponents.DotNetBar.LabelX();
            this.saveAttachFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lbl_LetterType = new DevComponents.DotNetBar.LabelX();
            this.txt_DateTo = new FreeControls.PersianDateTimePicker();
            this.btn_Search = new DevComponents.DotNetBar.ButtonX();
            this.txt_LetterReffrence = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_LetterSubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_LetterNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_LetterSender = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_DateOn = new FreeControls.PersianDateTimePicker();
            this.pnl_Search = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cbx_SearchStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbi_Status_All = new DevComponents.Editors.ComboItem();
            this.cbi_Status_Readed = new DevComponents.Editors.ComboItem();
            this.cbi_Status_UnReaded = new DevComponents.Editors.ComboItem();
            this.cbx_SearchLetterType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbi_LetterType_All = new DevComponents.Editors.ComboItem();
            this.cbi_LetterType_Letter = new DevComponents.Editors.ComboItem();
            this.cbi_LetterType_ReplyLetter = new DevComponents.Editors.ComboItem();
            this.cbx_SearchForced = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbi_Forced_All = new DevComponents.Editors.ComboItem();
            this.cbi_Forced_Normal = new DevComponents.Editors.ComboItem();
            this.cbi_Forced_Immediate = new DevComponents.Editors.ComboItem();
            this.cbi_Forced_Posthaste = new DevComponents.Editors.ComboItem();
            this.cbx_SearchCreator = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbx_SearchFollowing = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbi_Following_All = new DevComponents.Editors.ComboItem();
            this.cbi_Following_Yes = new DevComponents.Editors.ComboItem();
            this.cbi_Following_No = new DevComponents.Editors.ComboItem();
            this.cbx_SearchAttachment = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbi_Attachment_All = new DevComponents.Editors.ComboItem();
            this.cbi_Attachment_Yes = new DevComponents.Editors.ComboItem();
            this.cbi_Attachment_No = new DevComponents.Editors.ComboItem();
            this.cbx_SearchSecurity = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbi_Security_All = new DevComponents.Editors.ComboItem();
            this.cbi_Security_Normal = new DevComponents.Editors.ComboItem();
            this.cbi_Security_Confidencial = new DevComponents.Editors.ComboItem();
            this.cbi_Security_Secretive = new DevComponents.Editors.ComboItem();
            this.lbl_FollowingType = new DevComponents.DotNetBar.LabelX();
            this.lbl_Attachment = new DevComponents.DotNetBar.LabelX();
            this.lbl_Status = new DevComponents.DotNetBar.LabelX();
            this.lbl_Creator = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RecivedReferenceLetters)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.pnl_RecivedReferenceLetters.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.lbl_Title);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1050, 610);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("B Nazanin", 22.25F);
            this.lbl_Title.Location = new System.Drawing.Point(418, 3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(232, 40);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 7;
            this.lbl_Title.Text = "نامه‌هاي مرجوعه وارده";
            // 
            // dgv_RecivedReferenceLetters
            // 
            this.dgv_RecivedReferenceLetters.AllowUserToAddRows = false;
            this.dgv_RecivedReferenceLetters.AllowUserToDeleteRows = false;
            this.dgv_RecivedReferenceLetters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RecivedReferenceLetters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_LetterID,
            this.col_LetterNo,
            this.col_LetterSubject,
            this.col_LetterCreator,
            this.col_LetterReferencer,
            this.col_LetterSecurityType,
            this.col_LetterForceType,
            this.col_LetterType,
            this.col_LetterAnswerDeadLine,
            this.col_LetterReadType,
            this.col_LetterAttachmentType,
            this.col_LetterReffrence,
            this.col_LetterFollowingType,
            this.col_LetterReferenceDate,
            this.col_RefCaption,
            this.col_LetterDownloadAttach,
            this.col_LetterCreatorUserID,
            this.col_LetterReplyID,
            this.col_SecurityT,
            this.col_ForceT,
            this.col_AttachmentT,
            this.col_LetterAnswerType,
            this.col_LetterReferencerUserID});
            this.dgv_RecivedReferenceLetters.ContextMenuStrip = this.contextMenuStrip;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_RecivedReferenceLetters.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_RecivedReferenceLetters.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_RecivedReferenceLetters.Location = new System.Drawing.Point(3, 3);
            this.dgv_RecivedReferenceLetters.Name = "dgv_RecivedReferenceLetters";
            this.dgv_RecivedReferenceLetters.Size = new System.Drawing.Size(1014, 356);
            this.dgv_RecivedReferenceLetters.TabIndex = 0;
            this.dgv_RecivedReferenceLetters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RecivedReferenceLetters_CellClick);
            // 
            // col_LetterID
            // 
            this.col_LetterID.HeaderText = "LetterID";
            this.col_LetterID.Name = "col_LetterID";
            this.col_LetterID.Visible = false;
            // 
            // col_LetterNo
            // 
            this.col_LetterNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_LetterNo.HeaderText = "شماره نامه";
            this.col_LetterNo.Name = "col_LetterNo";
            this.col_LetterNo.Width = 98;
            // 
            // col_LetterSubject
            // 
            this.col_LetterSubject.HeaderText = "موضوع";
            this.col_LetterSubject.Name = "col_LetterSubject";
            this.col_LetterSubject.Width = 200;
            // 
            // col_LetterCreator
            // 
            this.col_LetterCreator.HeaderText = "ايجاد كننده";
            this.col_LetterCreator.Name = "col_LetterCreator";
            this.col_LetterCreator.Width = 150;
            // 
            // col_LetterReferencer
            // 
            this.col_LetterReferencer.HeaderText = "ارجاع دهنده";
            this.col_LetterReferencer.Name = "col_LetterReferencer";
            this.col_LetterReferencer.Width = 160;
            // 
            // col_LetterSecurityType
            // 
            this.col_LetterSecurityType.HeaderText = "طبقه بندي";
            this.col_LetterSecurityType.Name = "col_LetterSecurityType";
            this.col_LetterSecurityType.Width = 110;
            // 
            // col_LetterForceType
            // 
            this.col_LetterForceType.HeaderText = "فوريت";
            this.col_LetterForceType.Name = "col_LetterForceType";
            // 
            // col_LetterType
            // 
            this.col_LetterType.HeaderText = "نوع سند";
            this.col_LetterType.Name = "col_LetterType";
            // 
            // col_LetterAnswerDeadLine
            // 
            this.col_LetterAnswerDeadLine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_LetterAnswerDeadLine.HeaderText = "مهلت پاسخ";
            this.col_LetterAnswerDeadLine.Name = "col_LetterAnswerDeadLine";
            this.col_LetterAnswerDeadLine.Width = 102;
            // 
            // col_LetterReadType
            // 
            this.col_LetterReadType.HeaderText = "وضعيت";
            this.col_LetterReadType.Name = "col_LetterReadType";
            // 
            // col_LetterAttachmentType
            // 
            this.col_LetterAttachmentType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_LetterAttachmentType.HeaderText = "پيوست";
            this.col_LetterAttachmentType.Name = "col_LetterAttachmentType";
            this.col_LetterAttachmentType.Width = 78;
            // 
            // col_LetterReffrence
            // 
            this.col_LetterReffrence.HeaderText = "عطف به";
            this.col_LetterReffrence.Name = "col_LetterReffrence";
            this.col_LetterReffrence.Width = 140;
            // 
            // col_LetterFollowingType
            // 
            this.col_LetterFollowingType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_LetterFollowingType.HeaderText = "پيگيري";
            this.col_LetterFollowingType.Name = "col_LetterFollowingType";
            this.col_LetterFollowingType.Width = 80;
            // 
            // col_LetterReferenceDate
            // 
            this.col_LetterReferenceDate.HeaderText = "تاريخ ارجاع";
            this.col_LetterReferenceDate.Name = "col_LetterReferenceDate";
            this.col_LetterReferenceDate.Width = 120;
            // 
            // col_RefCaption
            // 
            this.col_RefCaption.HeaderText = "توضيحات";
            this.col_RefCaption.Name = "col_RefCaption";
            this.col_RefCaption.Width = 200;
            // 
            // col_LetterDownloadAttach
            // 
            this.col_LetterDownloadAttach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.col_LetterDownloadAttach.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_LetterDownloadAttach.HeaderText = "دريافت پيوست";
            this.col_LetterDownloadAttach.Name = "col_LetterDownloadAttach";
            this.col_LetterDownloadAttach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_LetterDownloadAttach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_LetterDownloadAttach.Width = 123;
            // 
            // col_LetterCreatorUserID
            // 
            this.col_LetterCreatorUserID.HeaderText = "LetterCreatorUserID";
            this.col_LetterCreatorUserID.Name = "col_LetterCreatorUserID";
            this.col_LetterCreatorUserID.Visible = false;
            // 
            // col_LetterReplyID
            // 
            this.col_LetterReplyID.HeaderText = "LetterReplyID";
            this.col_LetterReplyID.Name = "col_LetterReplyID";
            this.col_LetterReplyID.Visible = false;
            // 
            // col_SecurityT
            // 
            this.col_SecurityT.HeaderText = "SecurityT";
            this.col_SecurityT.Name = "col_SecurityT";
            this.col_SecurityT.Visible = false;
            // 
            // col_ForceT
            // 
            this.col_ForceT.HeaderText = "ForceT";
            this.col_ForceT.Name = "col_ForceT";
            this.col_ForceT.Visible = false;
            // 
            // col_AttachmentT
            // 
            this.col_AttachmentT.HeaderText = "AttachmentT";
            this.col_AttachmentT.Name = "col_AttachmentT";
            this.col_AttachmentT.Visible = false;
            // 
            // col_LetterAnswerType
            // 
            this.col_LetterAnswerType.HeaderText = "LetterAnswerType";
            this.col_LetterAnswerType.Name = "col_LetterAnswerType";
            this.col_LetterAnswerType.Visible = false;
            // 
            // col_LetterReferencerUserID
            // 
            this.col_LetterReferencerUserID.HeaderText = "LetterReferencerUserID";
            this.col_LetterReferencerUserID.Name = "col_LetterReferencerUserID";
            this.col_LetterReferencerUserID.Visible = false;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Font = new System.Drawing.Font("B Nazanin", 13F);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_ArchiveLetter,
            this.tsm_ReadLetter,
            this.tsm_ReferenceLetter,
            this.tsm_ReplyLetter});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip.Size = new System.Drawing.Size(150, 124);
            // 
            // tsm_ArchiveLetter
            // 
            this.tsm_ArchiveLetter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsm_ArchiveLetter.Image = global::AutomationSystem.Properties.Resources._10_ArchiveLetter;
            this.tsm_ArchiveLetter.Name = "tsm_ArchiveLetter";
            this.tsm_ArchiveLetter.Size = new System.Drawing.Size(149, 30);
            this.tsm_ArchiveLetter.Text = "بايگاني نامه";
            // 
            // tsm_ReadLetter
            // 
            this.tsm_ReadLetter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tsm_ReadLetter.Image = global::AutomationSystem.Properties.Resources._11_ReadLetter;
            this.tsm_ReadLetter.Name = "tsm_ReadLetter";
            this.tsm_ReadLetter.Size = new System.Drawing.Size(149, 30);
            this.tsm_ReadLetter.Text = "خواندن نامه";
            // 
            // tsm_ReferenceLetter
            // 
            this.tsm_ReferenceLetter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tsm_ReferenceLetter.Image = global::AutomationSystem.Properties.Resources._12_ReffrenceLetter;
            this.tsm_ReferenceLetter.Name = "tsm_ReferenceLetter";
            this.tsm_ReferenceLetter.Size = new System.Drawing.Size(149, 30);
            this.tsm_ReferenceLetter.Text = "ارجاع نامه";
            // 
            // tsm_ReplyLetter
            // 
            this.tsm_ReplyLetter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsm_ReplyLetter.Image = global::AutomationSystem.Properties.Resources._13_ReplyLetter;
            this.tsm_ReplyLetter.Name = "tsm_ReplyLetter";
            this.tsm_ReplyLetter.Size = new System.Drawing.Size(149, 30);
            this.tsm_ReplyLetter.Text = "پاسخ به نامه";
            // 
            // pnl_RecivedReferenceLetters
            // 
            this.pnl_RecivedReferenceLetters.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_RecivedReferenceLetters.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_RecivedReferenceLetters.Controls.Add(this.dgv_RecivedReferenceLetters);
            this.pnl_RecivedReferenceLetters.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_RecivedReferenceLetters.Location = new System.Drawing.Point(12, 54);
            this.pnl_RecivedReferenceLetters.Name = "pnl_RecivedReferenceLetters";
            this.pnl_RecivedReferenceLetters.Size = new System.Drawing.Size(1026, 368);
            // 
            // 
            // 
            this.pnl_RecivedReferenceLetters.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_RecivedReferenceLetters.Style.BackColorGradientAngle = 90;
            this.pnl_RecivedReferenceLetters.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_RecivedReferenceLetters.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_RecivedReferenceLetters.Style.BorderBottomWidth = 1;
            this.pnl_RecivedReferenceLetters.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_RecivedReferenceLetters.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_RecivedReferenceLetters.Style.BorderLeftWidth = 1;
            this.pnl_RecivedReferenceLetters.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_RecivedReferenceLetters.Style.BorderRightWidth = 1;
            this.pnl_RecivedReferenceLetters.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_RecivedReferenceLetters.Style.BorderTopWidth = 1;
            this.pnl_RecivedReferenceLetters.Style.CornerDiameter = 4;
            this.pnl_RecivedReferenceLetters.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_RecivedReferenceLetters.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_RecivedReferenceLetters.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_RecivedReferenceLetters.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_RecivedReferenceLetters.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_RecivedReferenceLetters.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_RecivedReferenceLetters.TabIndex = 8;
            // 
            // lbl_ForcedType
            // 
            this.lbl_ForcedType.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_ForcedType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_ForcedType.Location = new System.Drawing.Point(950, 41);
            this.lbl_ForcedType.Name = "lbl_ForcedType";
            this.lbl_ForcedType.Size = new System.Drawing.Size(35, 25);
            this.lbl_ForcedType.TabIndex = 0;
            this.lbl_ForcedType.Text = "فوريت:";
            // 
            // lbl_SecurityType
            // 
            this.lbl_SecurityType.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_SecurityType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SecurityType.Location = new System.Drawing.Point(950, 6);
            this.lbl_SecurityType.Name = "lbl_SecurityType";
            this.lbl_SecurityType.Size = new System.Drawing.Size(52, 25);
            this.lbl_SecurityType.TabIndex = 0;
            this.lbl_SecurityType.Text = "طبقه‌بندي:";
            // 
            // lbl_DateTo
            // 
            this.lbl_DateTo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_DateTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_DateTo.Location = new System.Drawing.Point(226, 112);
            this.lbl_DateTo.Name = "lbl_DateTo";
            this.lbl_DateTo.Size = new System.Drawing.Size(10, 25);
            this.lbl_DateTo.TabIndex = 0;
            this.lbl_DateTo.Text = "تا";
            // 
            // lbl_ReffrenceTo
            // 
            this.lbl_ReffrenceTo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_ReffrenceTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_ReffrenceTo.Location = new System.Drawing.Point(363, 72);
            this.lbl_ReffrenceTo.Name = "lbl_ReffrenceTo";
            this.lbl_ReffrenceTo.Size = new System.Drawing.Size(40, 25);
            this.lbl_ReffrenceTo.TabIndex = 0;
            this.lbl_ReffrenceTo.Text = "عطف به:";
            // 
            // lbl_LetterSubject
            // 
            this.lbl_LetterSubject.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_LetterSubject.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_LetterSubject.Location = new System.Drawing.Point(361, 6);
            this.lbl_LetterSubject.Name = "lbl_LetterSubject";
            this.lbl_LetterSubject.Size = new System.Drawing.Size(38, 25);
            this.lbl_LetterSubject.TabIndex = 0;
            this.lbl_LetterSubject.Text = "موضوع:";
            // 
            // lbl_DateOn
            // 
            this.lbl_DateOn.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_DateOn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_DateOn.Location = new System.Drawing.Point(358, 112);
            this.lbl_DateOn.Name = "lbl_DateOn";
            this.lbl_DateOn.Size = new System.Drawing.Size(44, 25);
            this.lbl_DateOn.TabIndex = 0;
            this.lbl_DateOn.Text = "از تاريخ";
            // 
            // lbl_LetterNo
            // 
            this.lbl_LetterNo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_LetterNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_LetterNo.Location = new System.Drawing.Point(353, 41);
            this.lbl_LetterNo.Name = "lbl_LetterNo";
            this.lbl_LetterNo.Size = new System.Drawing.Size(56, 25);
            this.lbl_LetterNo.TabIndex = 0;
            this.lbl_LetterNo.Text = "شماره‌نامه:";
            // 
            // lbl_Sender
            // 
            this.lbl_Sender.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Sender.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Sender.Location = new System.Drawing.Point(650, 113);
            this.lbl_Sender.Name = "lbl_Sender";
            this.lbl_Sender.Size = new System.Drawing.Size(48, 25);
            this.lbl_Sender.TabIndex = 0;
            this.lbl_Sender.Text = "فرستنده:";
            // 
            // lbl_LetterType
            // 
            this.lbl_LetterType.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_LetterType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_LetterType.Location = new System.Drawing.Point(950, 78);
            this.lbl_LetterType.Name = "lbl_LetterType";
            this.lbl_LetterType.Size = new System.Drawing.Size(43, 25);
            this.lbl_LetterType.TabIndex = 0;
            this.lbl_LetterType.Text = "نوع سند:";
            // 
            // txt_DateTo
            // 
            this.txt_DateTo.BackColor = System.Drawing.Color.White;
            this.txt_DateTo.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_DateTo.Location = new System.Drawing.Point(103, 112);
            this.txt_DateTo.Name = "txt_DateTo";
            this.txt_DateTo.ShowTime = false;
            this.txt_DateTo.Size = new System.Drawing.Size(119, 28);
            this.txt_DateTo.TabIndex = 6;
            this.txt_DateTo.Text = "persianDateTimePicker1";
            this.txt_DateTo.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_DateTo.Value")));
            // 
            // btn_Search
            // 
            this.btn_Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Search.Location = new System.Drawing.Point(10, 6);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(84, 134);
            this.btn_Search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Search.Symbol = "";
            this.btn_Search.TabIndex = 4;
            // 
            // txt_LetterReffrence
            // 
            // 
            // 
            // 
            this.txt_LetterReffrence.Border.Class = "TextBoxBorder";
            this.txt_LetterReffrence.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_LetterReffrence.Location = new System.Drawing.Point(103, 75);
            this.txt_LetterReffrence.Name = "txt_LetterReffrence";
            this.txt_LetterReffrence.PreventEnterBeep = true;
            this.txt_LetterReffrence.Size = new System.Drawing.Size(252, 29);
            this.txt_LetterReffrence.TabIndex = 3;
            this.txt_LetterReffrence.WatermarkText = "عطف به...";
            // 
            // txt_LetterSubject
            // 
            // 
            // 
            // 
            this.txt_LetterSubject.Border.Class = "TextBoxBorder";
            this.txt_LetterSubject.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_LetterSubject.Location = new System.Drawing.Point(103, 5);
            this.txt_LetterSubject.Name = "txt_LetterSubject";
            this.txt_LetterSubject.PreventEnterBeep = true;
            this.txt_LetterSubject.Size = new System.Drawing.Size(252, 29);
            this.txt_LetterSubject.TabIndex = 1;
            this.txt_LetterSubject.WatermarkText = "موضوع پيام...";
            // 
            // txt_LetterNo
            // 
            // 
            // 
            // 
            this.txt_LetterNo.Border.Class = "TextBoxBorder";
            this.txt_LetterNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_LetterNo.Location = new System.Drawing.Point(103, 41);
            this.txt_LetterNo.Name = "txt_LetterNo";
            this.txt_LetterNo.PreventEnterBeep = true;
            this.txt_LetterNo.Size = new System.Drawing.Size(252, 29);
            this.txt_LetterNo.TabIndex = 2;
            this.txt_LetterNo.WatermarkText = "شماره نامه پيام...";
            // 
            // txt_LetterSender
            // 
            // 
            // 
            // 
            this.txt_LetterSender.Border.Class = "TextBoxBorder";
            this.txt_LetterSender.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_LetterSender.Location = new System.Drawing.Point(415, 110);
            this.txt_LetterSender.Name = "txt_LetterSender";
            this.txt_LetterSender.PreventEnterBeep = true;
            this.txt_LetterSender.Size = new System.Drawing.Size(229, 29);
            this.txt_LetterSender.TabIndex = 4;
            this.txt_LetterSender.WatermarkText = "فرستنده پيام...";
            // 
            // txt_DateOn
            // 
            this.txt_DateOn.BackColor = System.Drawing.Color.White;
            this.txt_DateOn.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_DateOn.Location = new System.Drawing.Point(242, 112);
            this.txt_DateOn.Name = "txt_DateOn";
            this.txt_DateOn.ShowTime = false;
            this.txt_DateOn.Size = new System.Drawing.Size(113, 28);
            this.txt_DateOn.TabIndex = 6;
            this.txt_DateOn.Text = "persianDateTimePicker1";
            this.txt_DateOn.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_DateOn.Value")));
            // 
            // pnl_Search
            // 
            this.pnl_Search.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Search.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Search.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Search.Controls.Add(this.cbx_SearchStatus);
            this.pnl_Search.Controls.Add(this.cbx_SearchLetterType);
            this.pnl_Search.Controls.Add(this.cbx_SearchForced);
            this.pnl_Search.Controls.Add(this.cbx_SearchCreator);
            this.pnl_Search.Controls.Add(this.cbx_SearchFollowing);
            this.pnl_Search.Controls.Add(this.cbx_SearchAttachment);
            this.pnl_Search.Controls.Add(this.cbx_SearchSecurity);
            this.pnl_Search.Controls.Add(this.btn_Search);
            this.pnl_Search.Controls.Add(this.txt_LetterReffrence);
            this.pnl_Search.Controls.Add(this.txt_LetterSubject);
            this.pnl_Search.Controls.Add(this.txt_LetterNo);
            this.pnl_Search.Controls.Add(this.txt_LetterSender);
            this.pnl_Search.Controls.Add(this.txt_DateTo);
            this.pnl_Search.Controls.Add(this.txt_DateOn);
            this.pnl_Search.Controls.Add(this.lbl_FollowingType);
            this.pnl_Search.Controls.Add(this.lbl_Attachment);
            this.pnl_Search.Controls.Add(this.lbl_Status);
            this.pnl_Search.Controls.Add(this.lbl_LetterType);
            this.pnl_Search.Controls.Add(this.lbl_ForcedType);
            this.pnl_Search.Controls.Add(this.lbl_SecurityType);
            this.pnl_Search.Controls.Add(this.lbl_DateTo);
            this.pnl_Search.Controls.Add(this.lbl_ReffrenceTo);
            this.pnl_Search.Controls.Add(this.lbl_LetterSubject);
            this.pnl_Search.Controls.Add(this.lbl_Creator);
            this.pnl_Search.Controls.Add(this.lbl_LetterNo);
            this.pnl_Search.Controls.Add(this.lbl_Sender);
            this.pnl_Search.Controls.Add(this.lbl_DateOn);
            this.pnl_Search.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Search.Font = new System.Drawing.Font("B Nazanin", 10.25F, System.Drawing.FontStyle.Bold);
            this.pnl_Search.Location = new System.Drawing.Point(12, 428);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(1026, 175);
            // 
            // 
            // 
            this.pnl_Search.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Search.Style.BackColorGradientAngle = 90;
            this.pnl_Search.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Search.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Search.Style.BorderBottomWidth = 1;
            this.pnl_Search.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Search.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Search.Style.BorderLeftWidth = 1;
            this.pnl_Search.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Search.Style.BorderRightWidth = 1;
            this.pnl_Search.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Search.Style.BorderTopWidth = 1;
            this.pnl_Search.Style.CornerDiameter = 4;
            this.pnl_Search.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_Search.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_Search.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Search.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_Search.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_Search.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_Search.TabIndex = 9;
            this.pnl_Search.Text = "جستجو";
            // 
            // cbx_SearchStatus
            // 
            this.cbx_SearchStatus.DisplayMember = "Text";
            this.cbx_SearchStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_SearchStatus.FormattingEnabled = true;
            this.cbx_SearchStatus.ItemHeight = 24;
            this.cbx_SearchStatus.Items.AddRange(new object[] {
            this.cbi_Status_All,
            this.cbi_Status_Readed,
            this.cbi_Status_UnReaded});
            this.cbx_SearchStatus.Location = new System.Drawing.Point(715, 110);
            this.cbx_SearchStatus.Name = "cbx_SearchStatus";
            this.cbx_SearchStatus.Size = new System.Drawing.Size(229, 30);
            this.cbx_SearchStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbx_SearchStatus.TabIndex = 5;
            // 
            // cbi_Status_All
            // 
            this.cbi_Status_All.Text = "همه";
            // 
            // cbi_Status_Readed
            // 
            this.cbi_Status_Readed.Text = "خوانده شده";
            // 
            // cbi_Status_UnReaded
            // 
            this.cbi_Status_UnReaded.Text = "خوانده نشده";
            // 
            // cbx_SearchLetterType
            // 
            this.cbx_SearchLetterType.DisplayMember = "Text";
            this.cbx_SearchLetterType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_SearchLetterType.FormattingEnabled = true;
            this.cbx_SearchLetterType.ItemHeight = 24;
            this.cbx_SearchLetterType.Items.AddRange(new object[] {
            this.cbi_LetterType_All,
            this.cbi_LetterType_Letter,
            this.cbi_LetterType_ReplyLetter});
            this.cbx_SearchLetterType.Location = new System.Drawing.Point(715, 74);
            this.cbx_SearchLetterType.Name = "cbx_SearchLetterType";
            this.cbx_SearchLetterType.Size = new System.Drawing.Size(229, 30);
            this.cbx_SearchLetterType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbx_SearchLetterType.TabIndex = 5;
            // 
            // cbi_LetterType_All
            // 
            this.cbi_LetterType_All.Text = "همه";
            // 
            // cbi_LetterType_Letter
            // 
            this.cbi_LetterType_Letter.Text = "نامه";
            // 
            // cbi_LetterType_ReplyLetter
            // 
            this.cbi_LetterType_ReplyLetter.Text = "پاسخ به نامه";
            // 
            // cbx_SearchForced
            // 
            this.cbx_SearchForced.DisplayMember = "Text";
            this.cbx_SearchForced.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_SearchForced.FormattingEnabled = true;
            this.cbx_SearchForced.ItemHeight = 24;
            this.cbx_SearchForced.Items.AddRange(new object[] {
            this.cbi_Forced_All,
            this.cbi_Forced_Normal,
            this.cbi_Forced_Immediate,
            this.cbi_Forced_Posthaste});
            this.cbx_SearchForced.Location = new System.Drawing.Point(715, 38);
            this.cbx_SearchForced.Name = "cbx_SearchForced";
            this.cbx_SearchForced.Size = new System.Drawing.Size(229, 30);
            this.cbx_SearchForced.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbx_SearchForced.TabIndex = 5;
            // 
            // cbi_Forced_All
            // 
            this.cbi_Forced_All.Text = "همه";
            // 
            // cbi_Forced_Normal
            // 
            this.cbi_Forced_Normal.Text = "عادي";
            // 
            // cbi_Forced_Immediate
            // 
            this.cbi_Forced_Immediate.Text = "فوري";
            // 
            // cbi_Forced_Posthaste
            // 
            this.cbi_Forced_Posthaste.Text = "آني";
            // 
            // cbx_SearchCreator
            // 
            this.cbx_SearchCreator.DisplayMember = "Text";
            this.cbx_SearchCreator.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_SearchCreator.FormattingEnabled = true;
            this.cbx_SearchCreator.ItemHeight = 24;
            this.cbx_SearchCreator.Location = new System.Drawing.Point(415, 75);
            this.cbx_SearchCreator.Name = "cbx_SearchCreator";
            this.cbx_SearchCreator.Size = new System.Drawing.Size(229, 30);
            this.cbx_SearchCreator.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbx_SearchCreator.TabIndex = 5;
            // 
            // cbx_SearchFollowing
            // 
            this.cbx_SearchFollowing.DisplayMember = "Text";
            this.cbx_SearchFollowing.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_SearchFollowing.FormattingEnabled = true;
            this.cbx_SearchFollowing.ItemHeight = 24;
            this.cbx_SearchFollowing.Items.AddRange(new object[] {
            this.cbi_Following_All,
            this.cbi_Following_Yes,
            this.cbi_Following_No});
            this.cbx_SearchFollowing.Location = new System.Drawing.Point(415, 39);
            this.cbx_SearchFollowing.Name = "cbx_SearchFollowing";
            this.cbx_SearchFollowing.Size = new System.Drawing.Size(229, 30);
            this.cbx_SearchFollowing.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbx_SearchFollowing.TabIndex = 5;
            // 
            // cbi_Following_All
            // 
            this.cbi_Following_All.Text = "همه";
            // 
            // cbi_Following_Yes
            // 
            this.cbi_Following_Yes.Text = "دارد";
            // 
            // cbi_Following_No
            // 
            this.cbi_Following_No.Text = "ندارد";
            // 
            // cbx_SearchAttachment
            // 
            this.cbx_SearchAttachment.DisplayMember = "Text";
            this.cbx_SearchAttachment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_SearchAttachment.FormattingEnabled = true;
            this.cbx_SearchAttachment.ItemHeight = 24;
            this.cbx_SearchAttachment.Items.AddRange(new object[] {
            this.cbi_Attachment_All,
            this.cbi_Attachment_Yes,
            this.cbi_Attachment_No});
            this.cbx_SearchAttachment.Location = new System.Drawing.Point(415, 3);
            this.cbx_SearchAttachment.Name = "cbx_SearchAttachment";
            this.cbx_SearchAttachment.Size = new System.Drawing.Size(229, 30);
            this.cbx_SearchAttachment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbx_SearchAttachment.TabIndex = 5;
            // 
            // cbi_Attachment_All
            // 
            this.cbi_Attachment_All.Text = "همه";
            // 
            // cbi_Attachment_Yes
            // 
            this.cbi_Attachment_Yes.Text = "دارد";
            // 
            // cbi_Attachment_No
            // 
            this.cbi_Attachment_No.Text = "ندارد";
            // 
            // cbx_SearchSecurity
            // 
            this.cbx_SearchSecurity.DisplayMember = "Text";
            this.cbx_SearchSecurity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_SearchSecurity.FormattingEnabled = true;
            this.cbx_SearchSecurity.ItemHeight = 24;
            this.cbx_SearchSecurity.Items.AddRange(new object[] {
            this.cbi_Security_All,
            this.cbi_Security_Normal,
            this.cbi_Security_Confidencial,
            this.cbi_Security_Secretive});
            this.cbx_SearchSecurity.Location = new System.Drawing.Point(715, 3);
            this.cbx_SearchSecurity.Name = "cbx_SearchSecurity";
            this.cbx_SearchSecurity.Size = new System.Drawing.Size(229, 30);
            this.cbx_SearchSecurity.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbx_SearchSecurity.TabIndex = 5;
            // 
            // cbi_Security_All
            // 
            this.cbi_Security_All.Text = "همه";
            // 
            // cbi_Security_Normal
            // 
            this.cbi_Security_Normal.Text = "عادي";
            // 
            // cbi_Security_Confidencial
            // 
            this.cbi_Security_Confidencial.Text = "محرمانه";
            // 
            // cbi_Security_Secretive
            // 
            this.cbi_Security_Secretive.Text = "سري";
            // 
            // lbl_FollowingType
            // 
            this.lbl_FollowingType.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_FollowingType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_FollowingType.Location = new System.Drawing.Point(651, 41);
            this.lbl_FollowingType.Name = "lbl_FollowingType";
            this.lbl_FollowingType.Size = new System.Drawing.Size(39, 25);
            this.lbl_FollowingType.TabIndex = 0;
            this.lbl_FollowingType.Text = "پيگيري:";
            // 
            // lbl_Attachment
            // 
            this.lbl_Attachment.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Attachment.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Attachment.Location = new System.Drawing.Point(651, 6);
            this.lbl_Attachment.Name = "lbl_Attachment";
            this.lbl_Attachment.Size = new System.Drawing.Size(39, 25);
            this.lbl_Attachment.TabIndex = 0;
            this.lbl_Attachment.Text = "پيوست:";
            // 
            // lbl_Status
            // 
            this.lbl_Status.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Status.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Status.Location = new System.Drawing.Point(950, 110);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(38, 25);
            this.lbl_Status.TabIndex = 0;
            this.lbl_Status.Text = "وضعيت:";
            // 
            // lbl_Creator
            // 
            this.lbl_Creator.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Creator.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Creator.Location = new System.Drawing.Point(651, 79);
            this.lbl_Creator.Name = "lbl_Creator";
            this.lbl_Creator.Size = new System.Drawing.Size(59, 25);
            this.lbl_Creator.TabIndex = 0;
            this.lbl_Creator.Text = "ايجاد كننده:";
            // 
            // frmUserRecivedReferenceLetters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 610);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_RecivedReferenceLetters);
            this.Controls.Add(this.pnl_Search);
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmUserRecivedReferenceLetters";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUserRecivedReferenceLetters_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RecivedReferenceLetters)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.pnl_RecivedReferenceLetters.ResumeLayout(false);
            this.pnl_Search.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_RecivedReferenceLetters;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsm_ArchiveLetter;
        private System.Windows.Forms.ToolStripMenuItem tsm_ReadLetter;
        private System.Windows.Forms.ToolStripMenuItem tsm_ReferenceLetter;
        private System.Windows.Forms.ToolStripMenuItem tsm_ReplyLetter;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_RecivedReferenceLetters;
        private DevComponents.DotNetBar.LabelX lbl_ForcedType;
        private DevComponents.DotNetBar.LabelX lbl_SecurityType;
        private DevComponents.DotNetBar.LabelX lbl_DateTo;
        private DevComponents.DotNetBar.LabelX lbl_ReffrenceTo;
        private DevComponents.DotNetBar.LabelX lbl_LetterSubject;
        private DevComponents.DotNetBar.LabelX lbl_DateOn;
        private DevComponents.DotNetBar.LabelX lbl_LetterNo;
        private DevComponents.DotNetBar.LabelX lbl_Sender;
        private System.Windows.Forms.SaveFileDialog saveAttachFileDialog;
        private DevComponents.DotNetBar.LabelX lbl_LetterType;
        private FreeControls.PersianDateTimePicker txt_DateTo;
        private DevComponents.DotNetBar.ButtonX btn_Search;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_LetterReffrence;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_LetterSubject;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_LetterNo;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_LetterSender;
        private FreeControls.PersianDateTimePicker txt_DateOn;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Search;
        private DevComponents.DotNetBar.LabelX lbl_FollowingType;
        private DevComponents.DotNetBar.LabelX lbl_Attachment;
        private DevComponents.DotNetBar.LabelX lbl_Status;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.LabelX lbl_Creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterCreator;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterReferencer;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterSecurityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterForceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterAnswerDeadLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterReadType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterAttachmentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterReffrence;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterFollowingType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterReferenceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RefCaption;
        private System.Windows.Forms.DataGridViewLinkColumn col_LetterDownloadAttach;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterCreatorUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterReplyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SecurityT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ForceT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AttachmentT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterAnswerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterReferencerUserID;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbx_SearchStatus;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbx_SearchLetterType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbx_SearchForced;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbx_SearchSecurity;
        private DevComponents.Editors.ComboItem cbi_Security_All;
        private DevComponents.Editors.ComboItem cbi_Security_Normal;
        private DevComponents.Editors.ComboItem cbi_Security_Confidencial;
        private DevComponents.Editors.ComboItem cbi_Security_Secretive;
        private DevComponents.Editors.ComboItem cbi_Forced_All;
        private DevComponents.Editors.ComboItem cbi_Forced_Normal;
        private DevComponents.Editors.ComboItem cbi_Forced_Immediate;
        private DevComponents.Editors.ComboItem cbi_Forced_Posthaste;
        private DevComponents.Editors.ComboItem cbi_LetterType_All;
        private DevComponents.Editors.ComboItem cbi_LetterType_Letter;
        private DevComponents.Editors.ComboItem cbi_LetterType_ReplyLetter;
        private DevComponents.Editors.ComboItem cbi_Status_All;
        private DevComponents.Editors.ComboItem cbi_Status_Readed;
        private DevComponents.Editors.ComboItem cbi_Status_UnReaded;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbx_SearchFollowing;
        private DevComponents.Editors.ComboItem cbi_Following_All;
        private DevComponents.Editors.ComboItem cbi_Following_Yes;
        private DevComponents.Editors.ComboItem cbi_Following_No;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbx_SearchAttachment;
        private DevComponents.Editors.ComboItem cbi_Attachment_All;
        private DevComponents.Editors.ComboItem cbi_Attachment_Yes;
        private DevComponents.Editors.ComboItem cbi_Attachment_No;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbx_SearchCreator;
    }
}