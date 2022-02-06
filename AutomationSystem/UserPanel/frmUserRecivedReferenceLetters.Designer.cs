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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserRecivedReferenceLetters));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.col_LetterArchiveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterSecurityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterSender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_RecivedReferenceLetters = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_LetterForceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterAnswerDeadLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterReadType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterAttachmentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterReffrence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterFollowingType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterRecivedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterDownloadAttach = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col_LetterSenderUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterReplyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SecurityT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ForceT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ArchiveT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_AttachmentT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LetterAnswerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.rdb_LetterSecurity_Secretive = new System.Windows.Forms.RadioButton();
            this.rdb_LetterSecurity_Confidential = new System.Windows.Forms.RadioButton();
            this.rdb_LetterSecurity_Normal = new System.Windows.Forms.RadioButton();
            this.lbl_LetterNo = new DevComponents.DotNetBar.LabelX();
            this.lbl_Sender = new DevComponents.DotNetBar.LabelX();
            this.saveAttachFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.rdb_LetterSecurity_All = new System.Windows.Forms.RadioButton();
            this.pnl_Status = new System.Windows.Forms.Panel();
            this.rdb_LetterStatus_NotReaded = new System.Windows.Forms.RadioButton();
            this.rdb_LetterStatus_Readed = new System.Windows.Forms.RadioButton();
            this.rdb_LetterStatus_All = new System.Windows.Forms.RadioButton();
            this.lbl_LetterType = new DevComponents.DotNetBar.LabelX();
            this.rdb_LetterAttachmentType_No = new System.Windows.Forms.RadioButton();
            this.rdb_LetterAttachmentType_Yes = new System.Windows.Forms.RadioButton();
            this.rdb_LetterAttachmentType_All = new System.Windows.Forms.RadioButton();
            this.pnl_Attachment = new System.Windows.Forms.Panel();
            this.pnl_Following = new System.Windows.Forms.Panel();
            this.rdb_LetterFollowingType_No = new System.Windows.Forms.RadioButton();
            this.rdb_LetterFollowingType_Yes = new System.Windows.Forms.RadioButton();
            this.rdb_LetterFollowingType_All = new System.Windows.Forms.RadioButton();
            this.txt_DateTo = new FreeControls.PersianDateTimePicker();
            this.btn_Search = new DevComponents.DotNetBar.ButtonX();
            this.txt_LetterReffrence = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_LetterSubject = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_LetterNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_LetterSender = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_DateOn = new FreeControls.PersianDateTimePicker();
            this.pnl_Search = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pnl_LetterType = new System.Windows.Forms.Panel();
            this.rdb_LetterType_ReplyLetter = new System.Windows.Forms.RadioButton();
            this.rdb_LetterType_Letter = new System.Windows.Forms.RadioButton();
            this.rdb_LetterType_All = new System.Windows.Forms.RadioButton();
            this.lbl_FollowingType = new DevComponents.DotNetBar.LabelX();
            this.lbl_Attachment = new DevComponents.DotNetBar.LabelX();
            this.pnl_ForcedType = new System.Windows.Forms.Panel();
            this.rdb_LetterForceType_Posthaste = new System.Windows.Forms.RadioButton();
            this.rdb_LetterForceType_Immediate = new System.Windows.Forms.RadioButton();
            this.rdb_LetterForceType_Normal = new System.Windows.Forms.RadioButton();
            this.rdb_LetterForceType_All = new System.Windows.Forms.RadioButton();
            this.lbl_Status = new DevComponents.DotNetBar.LabelX();
            this.pnl_SecurityType = new System.Windows.Forms.Panel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RecivedReferenceLetters)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.pnl_RecivedReferenceLetters.SuspendLayout();
            this.pnl_Status.SuspendLayout();
            this.pnl_Attachment.SuspendLayout();
            this.pnl_Following.SuspendLayout();
            this.pnl_Search.SuspendLayout();
            this.pnl_LetterType.SuspendLayout();
            this.pnl_ForcedType.SuspendLayout();
            this.pnl_SecurityType.SuspendLayout();
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
            this.lbl_Title.Location = new System.Drawing.Point(429, 3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(177, 40);
            this.lbl_Title.Symbol = "";
            this.lbl_Title.TabIndex = 7;
            this.lbl_Title.Text = "نامه‌هاي مرجوعه";
            // 
            // col_LetterArchiveType
            // 
            this.col_LetterArchiveType.HeaderText = "بايگاني";
            this.col_LetterArchiveType.Name = "col_LetterArchiveType";
            // 
            // col_LetterSecurityType
            // 
            this.col_LetterSecurityType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_LetterSecurityType.HeaderText = "طبقه بندي";
            this.col_LetterSecurityType.Name = "col_LetterSecurityType";
            this.col_LetterSecurityType.Width = 101;
            // 
            // col_LetterSender
            // 
            this.col_LetterSender.HeaderText = "فرستنده";
            this.col_LetterSender.Name = "col_LetterSender";
            this.col_LetterSender.Width = 150;
            // 
            // col_LetterSubject
            // 
            this.col_LetterSubject.HeaderText = "موضوع";
            this.col_LetterSubject.Name = "col_LetterSubject";
            this.col_LetterSubject.Width = 200;
            // 
            // col_LetterNo
            // 
            this.col_LetterNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_LetterNo.HeaderText = "شماره نامه";
            this.col_LetterNo.Name = "col_LetterNo";
            this.col_LetterNo.Width = 98;
            // 
            // col_LetterID
            // 
            this.col_LetterID.HeaderText = "LetterID";
            this.col_LetterID.Name = "col_LetterID";
            this.col_LetterID.Visible = false;
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
            this.col_LetterSender,
            this.col_LetterSecurityType,
            this.col_LetterForceType,
            this.col_LetterArchiveType,
            this.col_LetterType,
            this.col_LetterAnswerDeadLine,
            this.col_LetterReadType,
            this.col_LetterAttachmentType,
            this.col_LetterReffrence,
            this.col_LetterFollowingType,
            this.col_LetterRecivedDate,
            this.col_LetterDownloadAttach,
            this.col_LetterSenderUserID,
            this.col_LetterReplyID,
            this.col_SecurityT,
            this.col_ForceT,
            this.col_ArchiveT,
            this.col_AttachmentT,
            this.col_LetterAnswerType});
            this.dgv_RecivedReferenceLetters.ContextMenuStrip = this.contextMenuStrip;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_RecivedReferenceLetters.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_RecivedReferenceLetters.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_RecivedReferenceLetters.Location = new System.Drawing.Point(3, 3);
            this.dgv_RecivedReferenceLetters.Name = "dgv_RecivedReferenceLetters";
            this.dgv_RecivedReferenceLetters.Size = new System.Drawing.Size(1014, 324);
            this.dgv_RecivedReferenceLetters.TabIndex = 0;
            // 
            // col_LetterForceType
            // 
            this.col_LetterForceType.HeaderText = "فوريت";
            this.col_LetterForceType.Name = "col_LetterForceType";
            // 
            // col_LetterType
            // 
            this.col_LetterType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_LetterType.HeaderText = "نوع سند";
            this.col_LetterType.Name = "col_LetterType";
            this.col_LetterType.Width = 86;
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
            // col_LetterRecivedDate
            // 
            this.col_LetterRecivedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_LetterRecivedDate.HeaderText = "تاريخ دريافت";
            this.col_LetterRecivedDate.Name = "col_LetterRecivedDate";
            this.col_LetterRecivedDate.Width = 111;
            // 
            // col_LetterDownloadAttach
            // 
            this.col_LetterDownloadAttach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.col_LetterDownloadAttach.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_LetterDownloadAttach.HeaderText = "دريافت پيوست";
            this.col_LetterDownloadAttach.Name = "col_LetterDownloadAttach";
            this.col_LetterDownloadAttach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_LetterDownloadAttach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_LetterDownloadAttach.Width = 123;
            // 
            // col_LetterSenderUserID
            // 
            this.col_LetterSenderUserID.HeaderText = "LetterSenderUserID";
            this.col_LetterSenderUserID.Name = "col_LetterSenderUserID";
            this.col_LetterSenderUserID.Visible = false;
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
            // col_ArchiveT
            // 
            this.col_ArchiveT.HeaderText = "ArchiveT";
            this.col_ArchiveT.Name = "col_ArchiveT";
            this.col_ArchiveT.Visible = false;
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
            this.pnl_RecivedReferenceLetters.Size = new System.Drawing.Size(1026, 336);
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
            this.lbl_ForcedType.Location = new System.Drawing.Point(838, 99);
            this.lbl_ForcedType.Name = "lbl_ForcedType";
            this.lbl_ForcedType.Size = new System.Drawing.Size(41, 25);
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
            this.lbl_SecurityType.Location = new System.Drawing.Point(953, 99);
            this.lbl_SecurityType.Name = "lbl_SecurityType";
            this.lbl_SecurityType.Size = new System.Drawing.Size(64, 25);
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
            this.lbl_DateTo.Location = new System.Drawing.Point(841, 3);
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
            this.lbl_ReffrenceTo.Location = new System.Drawing.Point(209, 5);
            this.lbl_ReffrenceTo.Name = "lbl_ReffrenceTo";
            this.lbl_ReffrenceTo.Size = new System.Drawing.Size(51, 25);
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
            this.lbl_LetterSubject.Location = new System.Drawing.Point(475, 6);
            this.lbl_LetterSubject.Name = "lbl_LetterSubject";
            this.lbl_LetterSubject.Size = new System.Drawing.Size(44, 25);
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
            this.lbl_DateOn.Location = new System.Drawing.Point(973, 3);
            this.lbl_DateOn.Name = "lbl_DateOn";
            this.lbl_DateOn.Size = new System.Drawing.Size(44, 25);
            this.lbl_DateOn.TabIndex = 0;
            this.lbl_DateOn.Text = "از تاريخ";
            // 
            // rdb_LetterSecurity_Secretive
            // 
            this.rdb_LetterSecurity_Secretive.AutoSize = true;
            this.rdb_LetterSecurity_Secretive.Location = new System.Drawing.Point(17, 107);
            this.rdb_LetterSecurity_Secretive.Name = "rdb_LetterSecurity_Secretive";
            this.rdb_LetterSecurity_Secretive.Size = new System.Drawing.Size(51, 27);
            this.rdb_LetterSecurity_Secretive.TabIndex = 0;
            this.rdb_LetterSecurity_Secretive.TabStop = true;
            this.rdb_LetterSecurity_Secretive.Text = "سري";
            this.rdb_LetterSecurity_Secretive.UseVisualStyleBackColor = true;
            // 
            // rdb_LetterSecurity_Confidential
            // 
            this.rdb_LetterSecurity_Confidential.AutoSize = true;
            this.rdb_LetterSecurity_Confidential.Location = new System.Drawing.Point(1, 74);
            this.rdb_LetterSecurity_Confidential.Name = "rdb_LetterSecurity_Confidential";
            this.rdb_LetterSecurity_Confidential.Size = new System.Drawing.Size(66, 27);
            this.rdb_LetterSecurity_Confidential.TabIndex = 0;
            this.rdb_LetterSecurity_Confidential.TabStop = true;
            this.rdb_LetterSecurity_Confidential.Text = "محرمانه";
            this.rdb_LetterSecurity_Confidential.UseVisualStyleBackColor = true;
            // 
            // rdb_LetterSecurity_Normal
            // 
            this.rdb_LetterSecurity_Normal.AutoSize = true;
            this.rdb_LetterSecurity_Normal.Location = new System.Drawing.Point(14, 41);
            this.rdb_LetterSecurity_Normal.Name = "rdb_LetterSecurity_Normal";
            this.rdb_LetterSecurity_Normal.Size = new System.Drawing.Size(53, 27);
            this.rdb_LetterSecurity_Normal.TabIndex = 0;
            this.rdb_LetterSecurity_Normal.TabStop = true;
            this.rdb_LetterSecurity_Normal.Text = "عادي";
            this.rdb_LetterSecurity_Normal.UseVisualStyleBackColor = true;
            // 
            // lbl_LetterNo
            // 
            this.lbl_LetterNo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_LetterNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_LetterNo.Location = new System.Drawing.Point(657, 6);
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
            this.lbl_Sender.Location = new System.Drawing.Point(193, 73);
            this.lbl_Sender.Name = "lbl_Sender";
            this.lbl_Sender.Size = new System.Drawing.Size(54, 25);
            this.lbl_Sender.TabIndex = 0;
            this.lbl_Sender.Text = "فرستنده:";
            // 
            // rdb_LetterSecurity_All
            // 
            this.rdb_LetterSecurity_All.AutoSize = true;
            this.rdb_LetterSecurity_All.Checked = true;
            this.rdb_LetterSecurity_All.Location = new System.Drawing.Point(20, 8);
            this.rdb_LetterSecurity_All.Name = "rdb_LetterSecurity_All";
            this.rdb_LetterSecurity_All.Size = new System.Drawing.Size(47, 27);
            this.rdb_LetterSecurity_All.TabIndex = 0;
            this.rdb_LetterSecurity_All.TabStop = true;
            this.rdb_LetterSecurity_All.Text = "همه";
            this.rdb_LetterSecurity_All.UseVisualStyleBackColor = true;
            // 
            // pnl_Status
            // 
            this.pnl_Status.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Status.Controls.Add(this.rdb_LetterStatus_NotReaded);
            this.pnl_Status.Controls.Add(this.rdb_LetterStatus_Readed);
            this.pnl_Status.Controls.Add(this.rdb_LetterStatus_All);
            this.pnl_Status.Location = new System.Drawing.Point(484, 45);
            this.pnl_Status.Name = "pnl_Status";
            this.pnl_Status.Size = new System.Drawing.Size(98, 113);
            this.pnl_Status.TabIndex = 1;
            // 
            // rdb_LetterStatus_NotReaded
            // 
            this.rdb_LetterStatus_NotReaded.AutoSize = true;
            this.rdb_LetterStatus_NotReaded.Location = new System.Drawing.Point(3, 78);
            this.rdb_LetterStatus_NotReaded.Name = "rdb_LetterStatus_NotReaded";
            this.rdb_LetterStatus_NotReaded.Size = new System.Drawing.Size(90, 27);
            this.rdb_LetterStatus_NotReaded.TabIndex = 0;
            this.rdb_LetterStatus_NotReaded.TabStop = true;
            this.rdb_LetterStatus_NotReaded.Text = "خوانده نشده";
            this.rdb_LetterStatus_NotReaded.UseVisualStyleBackColor = true;
            // 
            // rdb_LetterStatus_Readed
            // 
            this.rdb_LetterStatus_Readed.AutoSize = true;
            this.rdb_LetterStatus_Readed.Location = new System.Drawing.Point(7, 40);
            this.rdb_LetterStatus_Readed.Name = "rdb_LetterStatus_Readed";
            this.rdb_LetterStatus_Readed.Size = new System.Drawing.Size(85, 27);
            this.rdb_LetterStatus_Readed.TabIndex = 0;
            this.rdb_LetterStatus_Readed.TabStop = true;
            this.rdb_LetterStatus_Readed.Text = "خوانده شده";
            this.rdb_LetterStatus_Readed.UseVisualStyleBackColor = true;
            // 
            // rdb_LetterStatus_All
            // 
            this.rdb_LetterStatus_All.AutoSize = true;
            this.rdb_LetterStatus_All.Checked = true;
            this.rdb_LetterStatus_All.Location = new System.Drawing.Point(45, 7);
            this.rdb_LetterStatus_All.Name = "rdb_LetterStatus_All";
            this.rdb_LetterStatus_All.Size = new System.Drawing.Size(47, 27);
            this.rdb_LetterStatus_All.TabIndex = 0;
            this.rdb_LetterStatus_All.TabStop = true;
            this.rdb_LetterStatus_All.Text = "همه";
            this.rdb_LetterStatus_All.UseVisualStyleBackColor = true;
            // 
            // lbl_LetterType
            // 
            this.lbl_LetterType.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_LetterType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_LetterType.Location = new System.Drawing.Point(709, 90);
            this.lbl_LetterType.Name = "lbl_LetterType";
            this.lbl_LetterType.Size = new System.Drawing.Size(43, 25);
            this.lbl_LetterType.TabIndex = 0;
            this.lbl_LetterType.Text = "نوع سند:";
            // 
            // rdb_LetterAttachmentType_No
            // 
            this.rdb_LetterAttachmentType_No.AutoSize = true;
            this.rdb_LetterAttachmentType_No.Location = new System.Drawing.Point(3, 78);
            this.rdb_LetterAttachmentType_No.Name = "rdb_LetterAttachmentType_No";
            this.rdb_LetterAttachmentType_No.Size = new System.Drawing.Size(53, 27);
            this.rdb_LetterAttachmentType_No.TabIndex = 0;
            this.rdb_LetterAttachmentType_No.TabStop = true;
            this.rdb_LetterAttachmentType_No.Text = "ندارد";
            this.rdb_LetterAttachmentType_No.UseVisualStyleBackColor = true;
            // 
            // rdb_LetterAttachmentType_Yes
            // 
            this.rdb_LetterAttachmentType_Yes.AutoSize = true;
            this.rdb_LetterAttachmentType_Yes.Location = new System.Drawing.Point(8, 45);
            this.rdb_LetterAttachmentType_Yes.Name = "rdb_LetterAttachmentType_Yes";
            this.rdb_LetterAttachmentType_Yes.Size = new System.Drawing.Size(48, 27);
            this.rdb_LetterAttachmentType_Yes.TabIndex = 0;
            this.rdb_LetterAttachmentType_Yes.TabStop = true;
            this.rdb_LetterAttachmentType_Yes.Text = "دارد";
            this.rdb_LetterAttachmentType_Yes.UseVisualStyleBackColor = true;
            // 
            // rdb_LetterAttachmentType_All
            // 
            this.rdb_LetterAttachmentType_All.AutoSize = true;
            this.rdb_LetterAttachmentType_All.Checked = true;
            this.rdb_LetterAttachmentType_All.Location = new System.Drawing.Point(9, 12);
            this.rdb_LetterAttachmentType_All.Name = "rdb_LetterAttachmentType_All";
            this.rdb_LetterAttachmentType_All.Size = new System.Drawing.Size(47, 27);
            this.rdb_LetterAttachmentType_All.TabIndex = 0;
            this.rdb_LetterAttachmentType_All.TabStop = true;
            this.rdb_LetterAttachmentType_All.Text = "همه";
            this.rdb_LetterAttachmentType_All.UseVisualStyleBackColor = true;
            // 
            // pnl_Attachment
            // 
            this.pnl_Attachment.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Attachment.Controls.Add(this.rdb_LetterAttachmentType_No);
            this.pnl_Attachment.Controls.Add(this.rdb_LetterAttachmentType_Yes);
            this.pnl_Attachment.Controls.Add(this.rdb_LetterAttachmentType_All);
            this.pnl_Attachment.Location = new System.Drawing.Point(378, 45);
            this.pnl_Attachment.Name = "pnl_Attachment";
            this.pnl_Attachment.Size = new System.Drawing.Size(64, 113);
            this.pnl_Attachment.TabIndex = 1;
            // 
            // pnl_Following
            // 
            this.pnl_Following.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Following.Controls.Add(this.rdb_LetterFollowingType_No);
            this.pnl_Following.Controls.Add(this.rdb_LetterFollowingType_Yes);
            this.pnl_Following.Controls.Add(this.rdb_LetterFollowingType_All);
            this.pnl_Following.Location = new System.Drawing.Point(266, 45);
            this.pnl_Following.Name = "pnl_Following";
            this.pnl_Following.Size = new System.Drawing.Size(64, 113);
            this.pnl_Following.TabIndex = 1;
            // 
            // rdb_LetterFollowingType_No
            // 
            this.rdb_LetterFollowingType_No.AutoSize = true;
            this.rdb_LetterFollowingType_No.Location = new System.Drawing.Point(3, 78);
            this.rdb_LetterFollowingType_No.Name = "rdb_LetterFollowingType_No";
            this.rdb_LetterFollowingType_No.Size = new System.Drawing.Size(53, 27);
            this.rdb_LetterFollowingType_No.TabIndex = 0;
            this.rdb_LetterFollowingType_No.TabStop = true;
            this.rdb_LetterFollowingType_No.Text = "ندارد";
            this.rdb_LetterFollowingType_No.UseVisualStyleBackColor = true;
            // 
            // rdb_LetterFollowingType_Yes
            // 
            this.rdb_LetterFollowingType_Yes.AutoSize = true;
            this.rdb_LetterFollowingType_Yes.Location = new System.Drawing.Point(8, 45);
            this.rdb_LetterFollowingType_Yes.Name = "rdb_LetterFollowingType_Yes";
            this.rdb_LetterFollowingType_Yes.Size = new System.Drawing.Size(48, 27);
            this.rdb_LetterFollowingType_Yes.TabIndex = 0;
            this.rdb_LetterFollowingType_Yes.TabStop = true;
            this.rdb_LetterFollowingType_Yes.Text = "دارد";
            this.rdb_LetterFollowingType_Yes.UseVisualStyleBackColor = true;
            // 
            // rdb_LetterFollowingType_All
            // 
            this.rdb_LetterFollowingType_All.AutoSize = true;
            this.rdb_LetterFollowingType_All.Checked = true;
            this.rdb_LetterFollowingType_All.Location = new System.Drawing.Point(9, 12);
            this.rdb_LetterFollowingType_All.Name = "rdb_LetterFollowingType_All";
            this.rdb_LetterFollowingType_All.Size = new System.Drawing.Size(47, 27);
            this.rdb_LetterFollowingType_All.TabIndex = 0;
            this.rdb_LetterFollowingType_All.TabStop = true;
            this.rdb_LetterFollowingType_All.Text = "همه";
            this.rdb_LetterFollowingType_All.UseVisualStyleBackColor = true;
            // 
            // txt_DateTo
            // 
            this.txt_DateTo.BackColor = System.Drawing.Color.White;
            this.txt_DateTo.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_DateTo.Location = new System.Drawing.Point(718, 3);
            this.txt_DateTo.Name = "txt_DateTo";
            this.txt_DateTo.ShowTime = false;
            this.txt_DateTo.Size = new System.Drawing.Size(119, 28);
            this.txt_DateTo.TabIndex = 2;
            this.txt_DateTo.Text = "persianDateTimePicker1";
            this.txt_DateTo.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_DateTo.Value")));
            // 
            // btn_Search
            // 
            this.btn_Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Search.Location = new System.Drawing.Point(6, 0);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(43, 46);
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
            this.txt_LetterReffrence.Location = new System.Drawing.Point(55, 3);
            this.txt_LetterReffrence.Name = "txt_LetterReffrence";
            this.txt_LetterReffrence.PreventEnterBeep = true;
            this.txt_LetterReffrence.Size = new System.Drawing.Size(159, 29);
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
            this.txt_LetterSubject.Location = new System.Drawing.Point(273, 3);
            this.txt_LetterSubject.Name = "txt_LetterSubject";
            this.txt_LetterSubject.PreventEnterBeep = true;
            this.txt_LetterSubject.Size = new System.Drawing.Size(209, 29);
            this.txt_LetterSubject.TabIndex = 3;
            this.txt_LetterSubject.WatermarkText = "موضوع پيام...";
            // 
            // txt_LetterNo
            // 
            // 
            // 
            // 
            this.txt_LetterNo.Border.Class = "TextBoxBorder";
            this.txt_LetterNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_LetterNo.Location = new System.Drawing.Point(520, 2);
            this.txt_LetterNo.Name = "txt_LetterNo";
            this.txt_LetterNo.PreventEnterBeep = true;
            this.txt_LetterNo.Size = new System.Drawing.Size(139, 29);
            this.txt_LetterNo.TabIndex = 3;
            this.txt_LetterNo.WatermarkText = "شماره نامه پيام...";
            // 
            // txt_LetterSender
            // 
            // 
            // 
            // 
            this.txt_LetterSender.Border.Class = "TextBoxBorder";
            this.txt_LetterSender.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_LetterSender.Location = new System.Drawing.Point(6, 71);
            this.txt_LetterSender.Name = "txt_LetterSender";
            this.txt_LetterSender.PreventEnterBeep = true;
            this.txt_LetterSender.Size = new System.Drawing.Size(194, 29);
            this.txt_LetterSender.TabIndex = 3;
            this.txt_LetterSender.WatermarkText = "فرستنده پيام...";
            // 
            // txt_DateOn
            // 
            this.txt_DateOn.BackColor = System.Drawing.Color.White;
            this.txt_DateOn.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_DateOn.Location = new System.Drawing.Point(857, 3);
            this.txt_DateOn.Name = "txt_DateOn";
            this.txt_DateOn.ShowTime = false;
            this.txt_DateOn.Size = new System.Drawing.Size(119, 28);
            this.txt_DateOn.TabIndex = 2;
            this.txt_DateOn.Text = "persianDateTimePicker1";
            this.txt_DateOn.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_DateOn.Value")));
            // 
            // pnl_Search
            // 
            this.pnl_Search.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Search.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Search.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Search.Controls.Add(this.btn_Search);
            this.pnl_Search.Controls.Add(this.txt_LetterReffrence);
            this.pnl_Search.Controls.Add(this.txt_LetterSubject);
            this.pnl_Search.Controls.Add(this.txt_LetterNo);
            this.pnl_Search.Controls.Add(this.textBoxX1);
            this.pnl_Search.Controls.Add(this.txt_LetterSender);
            this.pnl_Search.Controls.Add(this.txt_DateTo);
            this.pnl_Search.Controls.Add(this.txt_DateOn);
            this.pnl_Search.Controls.Add(this.pnl_Following);
            this.pnl_Search.Controls.Add(this.pnl_Attachment);
            this.pnl_Search.Controls.Add(this.pnl_Status);
            this.pnl_Search.Controls.Add(this.pnl_LetterType);
            this.pnl_Search.Controls.Add(this.lbl_FollowingType);
            this.pnl_Search.Controls.Add(this.lbl_Attachment);
            this.pnl_Search.Controls.Add(this.pnl_ForcedType);
            this.pnl_Search.Controls.Add(this.lbl_Status);
            this.pnl_Search.Controls.Add(this.pnl_SecurityType);
            this.pnl_Search.Controls.Add(this.lbl_LetterType);
            this.pnl_Search.Controls.Add(this.lbl_ForcedType);
            this.pnl_Search.Controls.Add(this.lbl_SecurityType);
            this.pnl_Search.Controls.Add(this.lbl_DateTo);
            this.pnl_Search.Controls.Add(this.lbl_ReffrenceTo);
            this.pnl_Search.Controls.Add(this.lbl_LetterSubject);
            this.pnl_Search.Controls.Add(this.labelX1);
            this.pnl_Search.Controls.Add(this.lbl_LetterNo);
            this.pnl_Search.Controls.Add(this.lbl_Sender);
            this.pnl_Search.Controls.Add(this.lbl_DateOn);
            this.pnl_Search.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Search.Font = new System.Drawing.Font("B Nazanin", 10.25F, System.Drawing.FontStyle.Bold);
            this.pnl_Search.Location = new System.Drawing.Point(12, 396);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Size = new System.Drawing.Size(1026, 207);
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
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(6, 106);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(194, 29);
            this.textBoxX1.TabIndex = 3;
            this.textBoxX1.WatermarkText = "ايجاد كننده پيام...";
            // 
            // pnl_LetterType
            // 
            this.pnl_LetterType.BackColor = System.Drawing.Color.Transparent;
            this.pnl_LetterType.Controls.Add(this.rdb_LetterType_ReplyLetter);
            this.pnl_LetterType.Controls.Add(this.rdb_LetterType_Letter);
            this.pnl_LetterType.Controls.Add(this.rdb_LetterType_All);
            this.pnl_LetterType.Location = new System.Drawing.Point(632, 45);
            this.pnl_LetterType.Name = "pnl_LetterType";
            this.pnl_LetterType.Size = new System.Drawing.Size(71, 113);
            this.pnl_LetterType.TabIndex = 1;
            // 
            // rdb_LetterType_ReplyLetter
            // 
            this.rdb_LetterType_ReplyLetter.AutoSize = true;
            this.rdb_LetterType_ReplyLetter.Location = new System.Drawing.Point(6, 73);
            this.rdb_LetterType_ReplyLetter.Name = "rdb_LetterType_ReplyLetter";
            this.rdb_LetterType_ReplyLetter.Size = new System.Drawing.Size(53, 27);
            this.rdb_LetterType_ReplyLetter.TabIndex = 0;
            this.rdb_LetterType_ReplyLetter.TabStop = true;
            this.rdb_LetterType_ReplyLetter.Text = "پاسخ";
            this.rdb_LetterType_ReplyLetter.UseVisualStyleBackColor = true;
            // 
            // rdb_LetterType_Letter
            // 
            this.rdb_LetterType_Letter.AutoSize = true;
            this.rdb_LetterType_Letter.Location = new System.Drawing.Point(12, 40);
            this.rdb_LetterType_Letter.Name = "rdb_LetterType_Letter";
            this.rdb_LetterType_Letter.Size = new System.Drawing.Size(47, 27);
            this.rdb_LetterType_Letter.TabIndex = 0;
            this.rdb_LetterType_Letter.TabStop = true;
            this.rdb_LetterType_Letter.Text = "نامه";
            this.rdb_LetterType_Letter.UseVisualStyleBackColor = true;
            // 
            // rdb_LetterType_All
            // 
            this.rdb_LetterType_All.AutoSize = true;
            this.rdb_LetterType_All.Checked = true;
            this.rdb_LetterType_All.Location = new System.Drawing.Point(12, 7);
            this.rdb_LetterType_All.Name = "rdb_LetterType_All";
            this.rdb_LetterType_All.Size = new System.Drawing.Size(47, 27);
            this.rdb_LetterType_All.TabIndex = 0;
            this.rdb_LetterType_All.TabStop = true;
            this.rdb_LetterType_All.Text = "همه";
            this.rdb_LetterType_All.UseVisualStyleBackColor = true;
            // 
            // lbl_FollowingType
            // 
            this.lbl_FollowingType.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_FollowingType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_FollowingType.Location = new System.Drawing.Point(336, 90);
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
            this.lbl_Attachment.Location = new System.Drawing.Point(435, 90);
            this.lbl_Attachment.Name = "lbl_Attachment";
            this.lbl_Attachment.Size = new System.Drawing.Size(47, 25);
            this.lbl_Attachment.TabIndex = 0;
            this.lbl_Attachment.Text = "پيوست:";
            // 
            // pnl_ForcedType
            // 
            this.pnl_ForcedType.BackColor = System.Drawing.Color.Transparent;
            this.pnl_ForcedType.Controls.Add(this.rdb_LetterForceType_Posthaste);
            this.pnl_ForcedType.Controls.Add(this.rdb_LetterForceType_Immediate);
            this.pnl_ForcedType.Controls.Add(this.rdb_LetterForceType_Normal);
            this.pnl_ForcedType.Controls.Add(this.rdb_LetterForceType_All);
            this.pnl_ForcedType.Location = new System.Drawing.Point(765, 37);
            this.pnl_ForcedType.Name = "pnl_ForcedType";
            this.pnl_ForcedType.Size = new System.Drawing.Size(67, 138);
            this.pnl_ForcedType.TabIndex = 1;
            // 
            // rdb_LetterForceType_Posthaste
            // 
            this.rdb_LetterForceType_Posthaste.AutoSize = true;
            this.rdb_LetterForceType_Posthaste.Location = new System.Drawing.Point(12, 105);
            this.rdb_LetterForceType_Posthaste.Name = "rdb_LetterForceType_Posthaste";
            this.rdb_LetterForceType_Posthaste.Size = new System.Drawing.Size(46, 27);
            this.rdb_LetterForceType_Posthaste.TabIndex = 0;
            this.rdb_LetterForceType_Posthaste.TabStop = true;
            this.rdb_LetterForceType_Posthaste.Text = "آني";
            this.rdb_LetterForceType_Posthaste.UseVisualStyleBackColor = true;
            // 
            // rdb_LetterForceType_Immediate
            // 
            this.rdb_LetterForceType_Immediate.AutoSize = true;
            this.rdb_LetterForceType_Immediate.Location = new System.Drawing.Point(6, 72);
            this.rdb_LetterForceType_Immediate.Name = "rdb_LetterForceType_Immediate";
            this.rdb_LetterForceType_Immediate.Size = new System.Drawing.Size(52, 27);
            this.rdb_LetterForceType_Immediate.TabIndex = 0;
            this.rdb_LetterForceType_Immediate.TabStop = true;
            this.rdb_LetterForceType_Immediate.Text = "فوري";
            this.rdb_LetterForceType_Immediate.UseVisualStyleBackColor = true;
            // 
            // rdb_LetterForceType_Normal
            // 
            this.rdb_LetterForceType_Normal.AutoSize = true;
            this.rdb_LetterForceType_Normal.Location = new System.Drawing.Point(6, 36);
            this.rdb_LetterForceType_Normal.Name = "rdb_LetterForceType_Normal";
            this.rdb_LetterForceType_Normal.Size = new System.Drawing.Size(53, 27);
            this.rdb_LetterForceType_Normal.TabIndex = 0;
            this.rdb_LetterForceType_Normal.TabStop = true;
            this.rdb_LetterForceType_Normal.Text = "عادي";
            this.rdb_LetterForceType_Normal.UseVisualStyleBackColor = true;
            // 
            // rdb_LetterForceType_All
            // 
            this.rdb_LetterForceType_All.AutoSize = true;
            this.rdb_LetterForceType_All.Checked = true;
            this.rdb_LetterForceType_All.Location = new System.Drawing.Point(12, 3);
            this.rdb_LetterForceType_All.Name = "rdb_LetterForceType_All";
            this.rdb_LetterForceType_All.Size = new System.Drawing.Size(47, 27);
            this.rdb_LetterForceType_All.TabIndex = 0;
            this.rdb_LetterForceType_All.TabStop = true;
            this.rdb_LetterForceType_All.Text = "همه";
            this.rdb_LetterForceType_All.UseVisualStyleBackColor = true;
            // 
            // lbl_Status
            // 
            this.lbl_Status.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Status.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Status.Location = new System.Drawing.Point(588, 90);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(38, 25);
            this.lbl_Status.TabIndex = 0;
            this.lbl_Status.Text = "وضعيت:";
            // 
            // pnl_SecurityType
            // 
            this.pnl_SecurityType.BackColor = System.Drawing.Color.Transparent;
            this.pnl_SecurityType.Controls.Add(this.rdb_LetterSecurity_Secretive);
            this.pnl_SecurityType.Controls.Add(this.rdb_LetterSecurity_Confidential);
            this.pnl_SecurityType.Controls.Add(this.rdb_LetterSecurity_Normal);
            this.pnl_SecurityType.Controls.Add(this.rdb_LetterSecurity_All);
            this.pnl_SecurityType.Location = new System.Drawing.Point(885, 37);
            this.pnl_SecurityType.Name = "pnl_SecurityType";
            this.pnl_SecurityType.Size = new System.Drawing.Size(79, 137);
            this.pnl_SecurityType.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(201, 109);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(59, 25);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "ايجاد كننده:";
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
            this.pnl_Status.ResumeLayout(false);
            this.pnl_Status.PerformLayout();
            this.pnl_Attachment.ResumeLayout(false);
            this.pnl_Attachment.PerformLayout();
            this.pnl_Following.ResumeLayout(false);
            this.pnl_Following.PerformLayout();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_LetterType.ResumeLayout(false);
            this.pnl_LetterType.PerformLayout();
            this.pnl_ForcedType.ResumeLayout(false);
            this.pnl_ForcedType.PerformLayout();
            this.pnl_SecurityType.ResumeLayout(false);
            this.pnl_SecurityType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterArchiveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterSecurityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterSender;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterID;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_RecivedReferenceLetters;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterForceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterAnswerDeadLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterReadType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterAttachmentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterReffrence;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterFollowingType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterRecivedDate;
        private System.Windows.Forms.DataGridViewLinkColumn col_LetterDownloadAttach;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterSenderUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterReplyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SecurityT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ForceT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ArchiveT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_AttachmentT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LetterAnswerType;
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
        private System.Windows.Forms.RadioButton rdb_LetterSecurity_Secretive;
        private System.Windows.Forms.RadioButton rdb_LetterSecurity_Confidential;
        private System.Windows.Forms.RadioButton rdb_LetterSecurity_Normal;
        private DevComponents.DotNetBar.LabelX lbl_LetterNo;
        private DevComponents.DotNetBar.LabelX lbl_Sender;
        private System.Windows.Forms.SaveFileDialog saveAttachFileDialog;
        private System.Windows.Forms.RadioButton rdb_LetterSecurity_All;
        private System.Windows.Forms.Panel pnl_Status;
        private System.Windows.Forms.RadioButton rdb_LetterStatus_NotReaded;
        private System.Windows.Forms.RadioButton rdb_LetterStatus_Readed;
        private System.Windows.Forms.RadioButton rdb_LetterStatus_All;
        private DevComponents.DotNetBar.LabelX lbl_LetterType;
        private System.Windows.Forms.RadioButton rdb_LetterAttachmentType_No;
        private System.Windows.Forms.RadioButton rdb_LetterAttachmentType_Yes;
        private System.Windows.Forms.RadioButton rdb_LetterAttachmentType_All;
        private System.Windows.Forms.Panel pnl_Attachment;
        private System.Windows.Forms.Panel pnl_Following;
        private System.Windows.Forms.RadioButton rdb_LetterFollowingType_No;
        private System.Windows.Forms.RadioButton rdb_LetterFollowingType_Yes;
        private System.Windows.Forms.RadioButton rdb_LetterFollowingType_All;
        private FreeControls.PersianDateTimePicker txt_DateTo;
        private DevComponents.DotNetBar.ButtonX btn_Search;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_LetterReffrence;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_LetterSubject;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_LetterNo;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_LetterSender;
        private FreeControls.PersianDateTimePicker txt_DateOn;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Search;
        private System.Windows.Forms.Panel pnl_LetterType;
        private System.Windows.Forms.RadioButton rdb_LetterType_ReplyLetter;
        private System.Windows.Forms.RadioButton rdb_LetterType_Letter;
        private System.Windows.Forms.RadioButton rdb_LetterType_All;
        private DevComponents.DotNetBar.LabelX lbl_FollowingType;
        private DevComponents.DotNetBar.LabelX lbl_Attachment;
        private System.Windows.Forms.Panel pnl_ForcedType;
        private System.Windows.Forms.RadioButton rdb_LetterForceType_Posthaste;
        private System.Windows.Forms.RadioButton rdb_LetterForceType_Immediate;
        private System.Windows.Forms.RadioButton rdb_LetterForceType_Normal;
        private System.Windows.Forms.RadioButton rdb_LetterForceType_All;
        private DevComponents.DotNetBar.LabelX lbl_Status;
        private System.Windows.Forms.Panel pnl_SecurityType;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}