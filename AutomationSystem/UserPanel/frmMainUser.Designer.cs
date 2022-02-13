namespace AutomationSystem.UserPanel
{
    partial class frmMainUser
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
            this.exb_RightMenu = new DevComponents.DotNetBar.ExplorerBar();
            this.ebg_Dashboard = new DevComponents.DotNetBar.ExplorerBarGroupItem();
            this.lbl_AllRecivedMessages = new DevComponents.DotNetBar.LabelItem();
            this.lbl_ReadedMessages = new DevComponents.DotNetBar.LabelItem();
            this.lbl_UnReadedMessages = new DevComponents.DotNetBar.LabelItem();
            this.lbl_UrgentActionMessages = new DevComponents.DotNetBar.LabelItem();
            this.lbl_ConfidentialMessages = new DevComponents.DotNetBar.LabelItem();
            this.lbl_ArrivedNotes = new DevComponents.DotNetBar.LabelItem();
            this.lbl_ShowNotes = new DevComponents.DotNetBar.LabelItem();
            this.lbl_ShowGetReferenceLetters = new DevComponents.DotNetBar.LabelItem();
            this.ebg_Recycling = new DevComponents.DotNetBar.ExplorerBarGroupItem();
            this.lbl_SendedMessages = new DevComponents.DotNetBar.LabelItem();
            this.lbl_Following = new DevComponents.DotNetBar.LabelItem();
            this.lbl_SendedNotes = new DevComponents.DotNetBar.LabelItem();
            this.lbl_ReferredMessages = new DevComponents.DotNetBar.LabelItem();
            this.ebg_Operation = new DevComponents.DotNetBar.ExplorerBarGroupItem();
            this.lbl_CreateMessage = new DevComponents.DotNetBar.LabelItem();
            this.lbl_CreateNote = new DevComponents.DotNetBar.LabelItem();
            this.lbl_AddReminder = new DevComponents.DotNetBar.LabelItem();
            this.lbl_Draft = new DevComponents.DotNetBar.LabelItem();
            this.ebg_Newsletters = new DevComponents.DotNetBar.ExplorerBarGroupItem();
            this.lbl_NewsAndAnnouncement = new DevComponents.DotNetBar.LabelItem();
            this.ebg_Assessment = new DevComponents.DotNetBar.ExplorerBarGroupItem();
            this.lbl_DailyFunction = new DevComponents.DotNetBar.LabelItem();
            this.lbl_ShowPersonelsFunctions = new DevComponents.DotNetBar.LabelItem();
            this.pnl_UpMenu = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_Exit = new System.Windows.Forms.LinkLabel();
            this.lbl_RequestSupport = new System.Windows.Forms.LinkLabel();
            this.lbl_UpdatePassword = new System.Windows.Forms.LinkLabel();
            this.pic_UserPicture = new System.Windows.Forms.PictureBox();
            this.val_Job = new DevComponents.DotNetBar.LabelX();
            this.lbl_Job = new DevComponents.DotNetBar.LabelX();
            this.val_Gender = new DevComponents.DotNetBar.LabelX();
            this.lbl_Gender = new DevComponents.DotNetBar.LabelX();
            this.val_BrithDate = new DevComponents.DotNetBar.LabelX();
            this.lbl_BrithDate = new DevComponents.DotNetBar.LabelX();
            this.lbl_News = new DevComponents.DotNetBar.LabelX();
            this.val_AllSendedMessages = new DevComponents.DotNetBar.LabelX();
            this.val_AllReciveMessages = new DevComponents.DotNetBar.LabelX();
            this.val_PersonalCode = new DevComponents.DotNetBar.LabelX();
            this.lbl_AllSendedMessage = new DevComponents.DotNetBar.LabelX();
            this.lbl_AllReciveMessages = new DevComponents.DotNetBar.LabelX();
            this.lbl_PersonalCode = new DevComponents.DotNetBar.LabelX();
            this.val_Date = new DevComponents.DotNetBar.LabelX();
            this.val_LastName = new DevComponents.DotNetBar.LabelX();
            this.lbl_Date = new DevComponents.DotNetBar.LabelX();
            this.lbl_LastName = new DevComponents.DotNetBar.LabelX();
            this.val_Time = new DevComponents.DotNetBar.LabelX();
            this.lbl_Time = new DevComponents.DotNetBar.LabelX();
            this.val_Name = new DevComponents.DotNetBar.LabelX();
            this.lbl_Name = new DevComponents.DotNetBar.LabelX();
            this.lbl_Title = new DevComponents.DotNetBar.LabelX();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_AddDocument = new DevComponents.DotNetBar.LabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.exb_RightMenu)).BeginInit();
            this.pnl_UpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // exb_RightMenu
            // 
            this.exb_RightMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.exb_RightMenu.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.exb_RightMenu.BackStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ExplorerBarBackground2;
            this.exb_RightMenu.BackStyle.BackColorGradientAngle = 90;
            this.exb_RightMenu.BackStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ExplorerBarBackground;
            this.exb_RightMenu.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.exb_RightMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.exb_RightMenu.GroupImages = null;
            this.exb_RightMenu.Groups.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ebg_Dashboard,
            this.ebg_Recycling,
            this.ebg_Operation,
            this.ebg_Newsletters,
            this.ebg_Assessment});
            this.exb_RightMenu.Images = null;
            this.exb_RightMenu.Location = new System.Drawing.Point(1074, 163);
            this.exb_RightMenu.Name = "exb_RightMenu";
            this.exb_RightMenu.Size = new System.Drawing.Size(284, 597);
            this.exb_RightMenu.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors;
            this.exb_RightMenu.TabIndex = 1;
            // 
            // ebg_Dashboard
            // 
            // 
            // 
            // 
            this.ebg_Dashboard.BackStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(223)))), ((int)(((byte)(247)))));
            this.ebg_Dashboard.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ebg_Dashboard.BackStyle.BorderBottomWidth = 1;
            this.ebg_Dashboard.BackStyle.BorderColor = System.Drawing.Color.White;
            this.ebg_Dashboard.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ebg_Dashboard.BackStyle.BorderLeftWidth = 1;
            this.ebg_Dashboard.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ebg_Dashboard.BackStyle.BorderRightWidth = 1;
            this.ebg_Dashboard.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ebg_Dashboard.Cursor = System.Windows.Forms.Cursors.Default;
            this.ebg_Dashboard.Expanded = true;
            this.ebg_Dashboard.Name = "ebg_Dashboard";
            this.ebg_Dashboard.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors;
            this.ebg_Dashboard.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lbl_AllRecivedMessages,
            this.lbl_ReadedMessages,
            this.lbl_UnReadedMessages,
            this.lbl_UrgentActionMessages,
            this.lbl_ConfidentialMessages,
            this.lbl_ArrivedNotes,
            this.lbl_ShowNotes,
            this.lbl_ShowGetReferenceLetters});
            this.ebg_Dashboard.Text = "كارتابل";
            // 
            // 
            // 
            this.ebg_Dashboard.TitleHotStyle.BackColor = System.Drawing.Color.White;
            this.ebg_Dashboard.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(247)))));
            this.ebg_Dashboard.TitleHotStyle.CornerDiameter = 3;
            this.ebg_Dashboard.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ebg_Dashboard.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ebg_Dashboard.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ebg_Dashboard.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.ebg_Dashboard.TitleStyle.BackColor = System.Drawing.Color.White;
            this.ebg_Dashboard.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(247)))));
            this.ebg_Dashboard.TitleStyle.CornerDiameter = 3;
            this.ebg_Dashboard.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ebg_Dashboard.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ebg_Dashboard.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ebg_Dashboard.TitleStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
            // 
            // lbl_AllRecivedMessages
            // 
            this.lbl_AllRecivedMessages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_AllRecivedMessages.ForeColor = System.Drawing.Color.Blue;
            this.lbl_AllRecivedMessages.Name = "lbl_AllRecivedMessages";
            this.lbl_AllRecivedMessages.Symbol = "57673";
            this.lbl_AllRecivedMessages.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_AllRecivedMessages.Text = "همه نامه‌هاي وارده";
            this.lbl_AllRecivedMessages.Click += new System.EventHandler(this.lbl_AllRecivedMessages_Click);
            // 
            // lbl_ReadedMessages
            // 
            this.lbl_ReadedMessages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ReadedMessages.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ReadedMessages.Name = "lbl_ReadedMessages";
            this.lbl_ReadedMessages.Symbol = "57681";
            this.lbl_ReadedMessages.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_ReadedMessages.Text = "نامه‌هاي خوانده شده";
            this.lbl_ReadedMessages.Click += new System.EventHandler(this.lbl_ReadedMessages_Click);
            // 
            // lbl_UnReadedMessages
            // 
            this.lbl_UnReadedMessages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_UnReadedMessages.ForeColor = System.Drawing.Color.Blue;
            this.lbl_UnReadedMessages.Name = "lbl_UnReadedMessages";
            this.lbl_UnReadedMessages.Symbol = "57534";
            this.lbl_UnReadedMessages.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_UnReadedMessages.Text = "نامه‌هاي خوانده نشده";
            this.lbl_UnReadedMessages.Click += new System.EventHandler(this.lbl_UnReadedMessages_Click);
            // 
            // lbl_UrgentActionMessages
            // 
            this.lbl_UrgentActionMessages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_UrgentActionMessages.ForeColor = System.Drawing.Color.Blue;
            this.lbl_UrgentActionMessages.Name = "lbl_UrgentActionMessages";
            this.lbl_UrgentActionMessages.Symbol = "57553";
            this.lbl_UrgentActionMessages.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_UrgentActionMessages.Text = "نامه‌هاي اقدام فوري";
            this.lbl_UrgentActionMessages.Click += new System.EventHandler(this.lbl_UrgentActionMessages_Click);
            // 
            // lbl_ConfidentialMessages
            // 
            this.lbl_ConfidentialMessages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ConfidentialMessages.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ConfidentialMessages.Name = "lbl_ConfidentialMessages";
            this.lbl_ConfidentialMessages.Symbol = "59543";
            this.lbl_ConfidentialMessages.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_ConfidentialMessages.Text = "نامه‌هاي محرمانه";
            this.lbl_ConfidentialMessages.Click += new System.EventHandler(this.lbl_ConfidentialMessages_Click);
            // 
            // lbl_ArrivedNotes
            // 
            this.lbl_ArrivedNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ArrivedNotes.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ArrivedNotes.Name = "lbl_ArrivedNotes";
            this.lbl_ArrivedNotes.Symbol = "57391";
            this.lbl_ArrivedNotes.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_ArrivedNotes.Text = "يادداشت‌هاي رسيده";
            this.lbl_ArrivedNotes.Click += new System.EventHandler(this.lbl_ArrivedNotes_Click);
            // 
            // lbl_ShowNotes
            // 
            this.lbl_ShowNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ShowNotes.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ShowNotes.Name = "lbl_ShowNotes";
            this.lbl_ShowNotes.Symbol = "57819";
            this.lbl_ShowNotes.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_ShowNotes.Text = "نمايش يادآوري‌ها";
            this.lbl_ShowNotes.Click += new System.EventHandler(this.lbl_ShowNotes_Click);
            // 
            // lbl_ShowGetReferenceLetters
            // 
            this.lbl_ShowGetReferenceLetters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ShowGetReferenceLetters.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ShowGetReferenceLetters.Name = "lbl_ShowGetReferenceLetters";
            this.lbl_ShowGetReferenceLetters.Symbol = "";
            this.lbl_ShowGetReferenceLetters.Text = "نامه‌هاي مرجوعه وارده";
            this.lbl_ShowGetReferenceLetters.Click += new System.EventHandler(this.lbl_ShowGetReferenceLetters_Click);
            // 
            // ebg_Recycling
            // 
            // 
            // 
            // 
            this.ebg_Recycling.BackStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(223)))), ((int)(((byte)(247)))));
            this.ebg_Recycling.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ebg_Recycling.BackStyle.BorderBottomWidth = 1;
            this.ebg_Recycling.BackStyle.BorderColor = System.Drawing.Color.White;
            this.ebg_Recycling.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ebg_Recycling.BackStyle.BorderLeftWidth = 1;
            this.ebg_Recycling.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ebg_Recycling.BackStyle.BorderRightWidth = 1;
            this.ebg_Recycling.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ebg_Recycling.Cursor = System.Windows.Forms.Cursors.Default;
            this.ebg_Recycling.Name = "ebg_Recycling";
            this.ebg_Recycling.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors;
            this.ebg_Recycling.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lbl_SendedMessages,
            this.lbl_Following,
            this.lbl_SendedNotes,
            this.lbl_ReferredMessages});
            this.ebg_Recycling.Text = "بازيافت";
            // 
            // 
            // 
            this.ebg_Recycling.TitleHotStyle.BackColor = System.Drawing.Color.White;
            this.ebg_Recycling.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(247)))));
            this.ebg_Recycling.TitleHotStyle.CornerDiameter = 3;
            this.ebg_Recycling.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ebg_Recycling.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ebg_Recycling.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ebg_Recycling.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.ebg_Recycling.TitleStyle.BackColor = System.Drawing.Color.White;
            this.ebg_Recycling.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(247)))));
            this.ebg_Recycling.TitleStyle.CornerDiameter = 3;
            this.ebg_Recycling.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ebg_Recycling.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ebg_Recycling.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ebg_Recycling.TitleStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
            // 
            // lbl_SendedMessages
            // 
            this.lbl_SendedMessages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_SendedMessages.ForeColor = System.Drawing.Color.Blue;
            this.lbl_SendedMessages.Name = "lbl_SendedMessages";
            this.lbl_SendedMessages.Symbol = "59549";
            this.lbl_SendedMessages.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_SendedMessages.Text = "نامه‌هاي ارسالي";
            this.lbl_SendedMessages.Click += new System.EventHandler(this.lbl_SendedMessages_Click);
            // 
            // lbl_Following
            // 
            this.lbl_Following.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Following.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Following.Name = "lbl_Following";
            this.lbl_Following.Symbol = "57559";
            this.lbl_Following.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_Following.Text = "پيگيري";
            this.lbl_Following.Click += new System.EventHandler(this.lbl_Following_Click);
            // 
            // lbl_SendedNotes
            // 
            this.lbl_SendedNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_SendedNotes.ForeColor = System.Drawing.Color.Blue;
            this.lbl_SendedNotes.Name = "lbl_SendedNotes";
            this.lbl_SendedNotes.Symbol = "57404";
            this.lbl_SendedNotes.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_SendedNotes.Text = "يادداشت‌هاي ارسالي";
            this.lbl_SendedNotes.Click += new System.EventHandler(this.lbl_SendedNotes_Click);
            // 
            // lbl_ReferredMessages
            // 
            this.lbl_ReferredMessages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ReferredMessages.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ReferredMessages.Name = "lbl_ReferredMessages";
            this.lbl_ReferredMessages.Symbol = "57695";
            this.lbl_ReferredMessages.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_ReferredMessages.Text = "نامه‌هاي ارجاع داده شده";
            this.lbl_ReferredMessages.Click += new System.EventHandler(this.lbl_ReferredMessages_Click);
            // 
            // ebg_Operation
            // 
            // 
            // 
            // 
            this.ebg_Operation.BackStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(223)))), ((int)(((byte)(247)))));
            this.ebg_Operation.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ebg_Operation.BackStyle.BorderBottomWidth = 1;
            this.ebg_Operation.BackStyle.BorderColor = System.Drawing.Color.White;
            this.ebg_Operation.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ebg_Operation.BackStyle.BorderLeftWidth = 1;
            this.ebg_Operation.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ebg_Operation.BackStyle.BorderRightWidth = 1;
            this.ebg_Operation.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ebg_Operation.Cursor = System.Windows.Forms.Cursors.Default;
            this.ebg_Operation.Expanded = true;
            this.ebg_Operation.Name = "ebg_Operation";
            this.ebg_Operation.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors;
            this.ebg_Operation.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lbl_CreateMessage,
            this.lbl_CreateNote,
            this.lbl_AddReminder,
            this.lbl_Draft,
            this.lbl_AddDocument});
            this.ebg_Operation.Text = "عمليات";
            // 
            // 
            // 
            this.ebg_Operation.TitleHotStyle.BackColor = System.Drawing.Color.White;
            this.ebg_Operation.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(247)))));
            this.ebg_Operation.TitleHotStyle.CornerDiameter = 3;
            this.ebg_Operation.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ebg_Operation.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ebg_Operation.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ebg_Operation.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.ebg_Operation.TitleStyle.BackColor = System.Drawing.Color.White;
            this.ebg_Operation.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(247)))));
            this.ebg_Operation.TitleStyle.CornerDiameter = 3;
            this.ebg_Operation.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ebg_Operation.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ebg_Operation.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ebg_Operation.TitleStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
            // 
            // lbl_CreateMessage
            // 
            this.lbl_CreateMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_CreateMessage.ForeColor = System.Drawing.Color.Blue;
            this.lbl_CreateMessage.Name = "lbl_CreateMessage";
            this.lbl_CreateMessage.Symbol = "57680";
            this.lbl_CreateMessage.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_CreateMessage.Text = "ايجاد نامه";
            this.lbl_CreateMessage.Click += new System.EventHandler(this.lbl_CreateMessage_Click);
            // 
            // lbl_CreateNote
            // 
            this.lbl_CreateNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_CreateNote.ForeColor = System.Drawing.Color.Blue;
            this.lbl_CreateNote.Name = "lbl_CreateNote";
            this.lbl_CreateNote.Symbol = "57416";
            this.lbl_CreateNote.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_CreateNote.Text = "ايجاد يادداشت";
            this.lbl_CreateNote.Click += new System.EventHandler(this.lbl_CreateNote_Click);
            // 
            // lbl_AddReminder
            // 
            this.lbl_AddReminder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_AddReminder.ForeColor = System.Drawing.Color.Blue;
            this.lbl_AddReminder.Name = "lbl_AddReminder";
            this.lbl_AddReminder.Symbol = "59478";
            this.lbl_AddReminder.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_AddReminder.Text = "ثبت يادآوري";
            this.lbl_AddReminder.Click += new System.EventHandler(this.lbl_AddReminder_Click_1);
            // 
            // lbl_Draft
            // 
            this.lbl_Draft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Draft.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Draft.Name = "lbl_Draft";
            this.lbl_Draft.Symbol = "59568";
            this.lbl_Draft.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_Draft.Text = "پيش نويس";
            this.lbl_Draft.Click += new System.EventHandler(this.lbl_Draft_Click);
            // 
            // ebg_Newsletters
            // 
            // 
            // 
            // 
            this.ebg_Newsletters.BackStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(223)))), ((int)(((byte)(247)))));
            this.ebg_Newsletters.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ebg_Newsletters.BackStyle.BorderBottomWidth = 1;
            this.ebg_Newsletters.BackStyle.BorderColor = System.Drawing.Color.White;
            this.ebg_Newsletters.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ebg_Newsletters.BackStyle.BorderLeftWidth = 1;
            this.ebg_Newsletters.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ebg_Newsletters.BackStyle.BorderRightWidth = 1;
            this.ebg_Newsletters.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ebg_Newsletters.Cursor = System.Windows.Forms.Cursors.Default;
            this.ebg_Newsletters.Expanded = true;
            this.ebg_Newsletters.Name = "ebg_Newsletters";
            this.ebg_Newsletters.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors;
            this.ebg_Newsletters.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lbl_NewsAndAnnouncement});
            this.ebg_Newsletters.Text = "خبرنامه";
            // 
            // 
            // 
            this.ebg_Newsletters.TitleHotStyle.BackColor = System.Drawing.Color.White;
            this.ebg_Newsletters.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(247)))));
            this.ebg_Newsletters.TitleHotStyle.CornerDiameter = 3;
            this.ebg_Newsletters.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ebg_Newsletters.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ebg_Newsletters.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ebg_Newsletters.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.ebg_Newsletters.TitleStyle.BackColor = System.Drawing.Color.White;
            this.ebg_Newsletters.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(247)))));
            this.ebg_Newsletters.TitleStyle.CornerDiameter = 3;
            this.ebg_Newsletters.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ebg_Newsletters.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ebg_Newsletters.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ebg_Newsletters.TitleStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
            // 
            // lbl_NewsAndAnnouncement
            // 
            this.lbl_NewsAndAnnouncement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_NewsAndAnnouncement.ForeColor = System.Drawing.Color.Blue;
            this.lbl_NewsAndAnnouncement.Name = "lbl_NewsAndAnnouncement";
            this.lbl_NewsAndAnnouncement.Symbol = "59383";
            this.lbl_NewsAndAnnouncement.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_NewsAndAnnouncement.Text = "اخبار و اطلاعيه‌ها";
            this.lbl_NewsAndAnnouncement.Click += new System.EventHandler(this.lbl_NewsAndAnnouncement_Click);
            // 
            // ebg_Assessment
            // 
            // 
            // 
            // 
            this.ebg_Assessment.BackStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(223)))), ((int)(((byte)(247)))));
            this.ebg_Assessment.BackStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ebg_Assessment.BackStyle.BorderBottomWidth = 1;
            this.ebg_Assessment.BackStyle.BorderColor = System.Drawing.Color.White;
            this.ebg_Assessment.BackStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ebg_Assessment.BackStyle.BorderLeftWidth = 1;
            this.ebg_Assessment.BackStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ebg_Assessment.BackStyle.BorderRightWidth = 1;
            this.ebg_Assessment.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ebg_Assessment.Cursor = System.Windows.Forms.Cursors.Default;
            this.ebg_Assessment.Expanded = true;
            this.ebg_Assessment.Name = "ebg_Assessment";
            this.ebg_Assessment.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.SystemColors;
            this.ebg_Assessment.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lbl_DailyFunction,
            this.lbl_ShowPersonelsFunctions});
            this.ebg_Assessment.Text = "ارزشيابي پرسنل";
            // 
            // 
            // 
            this.ebg_Assessment.TitleHotStyle.BackColor = System.Drawing.Color.White;
            this.ebg_Assessment.TitleHotStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(247)))));
            this.ebg_Assessment.TitleHotStyle.CornerDiameter = 3;
            this.ebg_Assessment.TitleHotStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ebg_Assessment.TitleHotStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ebg_Assessment.TitleHotStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ebg_Assessment.TitleHotStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.ebg_Assessment.TitleStyle.BackColor = System.Drawing.Color.White;
            this.ebg_Assessment.TitleStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(247)))));
            this.ebg_Assessment.TitleStyle.CornerDiameter = 3;
            this.ebg_Assessment.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ebg_Assessment.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ebg_Assessment.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ebg_Assessment.TitleStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
            // 
            // lbl_DailyFunction
            // 
            this.lbl_DailyFunction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_DailyFunction.ForeColor = System.Drawing.Color.Blue;
            this.lbl_DailyFunction.Name = "lbl_DailyFunction";
            this.lbl_DailyFunction.Symbol = "58902";
            this.lbl_DailyFunction.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_DailyFunction.Text = "ثبت كاركرد روزانه";
            this.lbl_DailyFunction.Click += new System.EventHandler(this.lbl_DailyFunction_Click);
            // 
            // lbl_ShowPersonelsFunctions
            // 
            this.lbl_ShowPersonelsFunctions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ShowPersonelsFunctions.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ShowPersonelsFunctions.Name = "lbl_ShowPersonelsFunctions";
            this.lbl_ShowPersonelsFunctions.Symbol = "58057";
            this.lbl_ShowPersonelsFunctions.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_ShowPersonelsFunctions.Text = "نمايش كاركرد پرسنل";
            this.lbl_ShowPersonelsFunctions.Click += new System.EventHandler(this.lbl_ShowPersonelsFunctions_Click);
            // 
            // pnl_UpMenu
            // 
            this.pnl_UpMenu.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_UpMenu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_UpMenu.Controls.Add(this.lbl_Exit);
            this.pnl_UpMenu.Controls.Add(this.lbl_RequestSupport);
            this.pnl_UpMenu.Controls.Add(this.lbl_UpdatePassword);
            this.pnl_UpMenu.Controls.Add(this.pic_UserPicture);
            this.pnl_UpMenu.Controls.Add(this.val_Job);
            this.pnl_UpMenu.Controls.Add(this.lbl_Job);
            this.pnl_UpMenu.Controls.Add(this.val_Gender);
            this.pnl_UpMenu.Controls.Add(this.lbl_Gender);
            this.pnl_UpMenu.Controls.Add(this.val_BrithDate);
            this.pnl_UpMenu.Controls.Add(this.lbl_BrithDate);
            this.pnl_UpMenu.Controls.Add(this.lbl_News);
            this.pnl_UpMenu.Controls.Add(this.val_AllSendedMessages);
            this.pnl_UpMenu.Controls.Add(this.val_AllReciveMessages);
            this.pnl_UpMenu.Controls.Add(this.val_PersonalCode);
            this.pnl_UpMenu.Controls.Add(this.lbl_AllSendedMessage);
            this.pnl_UpMenu.Controls.Add(this.lbl_AllReciveMessages);
            this.pnl_UpMenu.Controls.Add(this.lbl_PersonalCode);
            this.pnl_UpMenu.Controls.Add(this.val_Date);
            this.pnl_UpMenu.Controls.Add(this.val_LastName);
            this.pnl_UpMenu.Controls.Add(this.lbl_Date);
            this.pnl_UpMenu.Controls.Add(this.lbl_LastName);
            this.pnl_UpMenu.Controls.Add(this.val_Time);
            this.pnl_UpMenu.Controls.Add(this.lbl_Time);
            this.pnl_UpMenu.Controls.Add(this.val_Name);
            this.pnl_UpMenu.Controls.Add(this.lbl_Name);
            this.pnl_UpMenu.Controls.Add(this.lbl_Title);
            this.pnl_UpMenu.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_UpMenu.Location = new System.Drawing.Point(12, 12);
            this.pnl_UpMenu.Name = "pnl_UpMenu";
            this.pnl_UpMenu.Size = new System.Drawing.Size(1346, 145);
            // 
            // 
            // 
            this.pnl_UpMenu.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_UpMenu.Style.BackColorGradientAngle = 90;
            this.pnl_UpMenu.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_UpMenu.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UpMenu.Style.BorderBottomWidth = 1;
            this.pnl_UpMenu.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_UpMenu.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UpMenu.Style.BorderLeftWidth = 1;
            this.pnl_UpMenu.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UpMenu.Style.BorderRightWidth = 1;
            this.pnl_UpMenu.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_UpMenu.Style.BorderTopWidth = 1;
            this.pnl_UpMenu.Style.CornerDiameter = 4;
            this.pnl_UpMenu.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_UpMenu.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_UpMenu.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_UpMenu.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_UpMenu.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_UpMenu.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_UpMenu.TabIndex = 0;
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.AutoSize = true;
            this.lbl_Exit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Exit.LinkColor = System.Drawing.Color.Red;
            this.lbl_Exit.Location = new System.Drawing.Point(137, 12);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(107, 28);
            this.lbl_Exit.TabIndex = 4;
            this.lbl_Exit.TabStop = true;
            this.lbl_Exit.Text = "خروج از سيستم";
            this.lbl_Exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_Exit_LinkClicked);
            // 
            // lbl_RequestSupport
            // 
            this.lbl_RequestSupport.AutoSize = true;
            this.lbl_RequestSupport.BackColor = System.Drawing.Color.Transparent;
            this.lbl_RequestSupport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_RequestSupport.LinkColor = System.Drawing.Color.Indigo;
            this.lbl_RequestSupport.Location = new System.Drawing.Point(137, 98);
            this.lbl_RequestSupport.Name = "lbl_RequestSupport";
            this.lbl_RequestSupport.Size = new System.Drawing.Size(126, 28);
            this.lbl_RequestSupport.TabIndex = 4;
            this.lbl_RequestSupport.TabStop = true;
            this.lbl_RequestSupport.Text = "درخواست پشتيباني";
            this.lbl_RequestSupport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_RequestSupport_LinkClicked);
            // 
            // lbl_UpdatePassword
            // 
            this.lbl_UpdatePassword.AutoSize = true;
            this.lbl_UpdatePassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UpdatePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_UpdatePassword.Location = new System.Drawing.Point(265, 98);
            this.lbl_UpdatePassword.Name = "lbl_UpdatePassword";
            this.lbl_UpdatePassword.Size = new System.Drawing.Size(90, 28);
            this.lbl_UpdatePassword.TabIndex = 4;
            this.lbl_UpdatePassword.TabStop = true;
            this.lbl_UpdatePassword.Text = "تغيير گذرواژه";
            this.lbl_UpdatePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_UpdatePassword_LinkClicked);
            // 
            // pic_UserPicture
            // 
            this.pic_UserPicture.Location = new System.Drawing.Point(3, 3);
            this.pic_UserPicture.Name = "pic_UserPicture";
            this.pic_UserPicture.Size = new System.Drawing.Size(128, 133);
            this.pic_UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_UserPicture.TabIndex = 2;
            this.pic_UserPicture.TabStop = false;
            // 
            // val_Job
            // 
            this.val_Job.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.val_Job.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_Job.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.val_Job.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.val_Job.Location = new System.Drawing.Point(137, 53);
            this.val_Job.Name = "val_Job";
            this.val_Job.Size = new System.Drawing.Size(185, 28);
            this.val_Job.TabIndex = 1;
            this.val_Job.Text = "...";
            // 
            // lbl_Job
            // 
            this.lbl_Job.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Job.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Job.Location = new System.Drawing.Point(328, 53);
            this.lbl_Job.Name = "lbl_Job";
            this.lbl_Job.Size = new System.Drawing.Size(33, 28);
            this.lbl_Job.TabIndex = 1;
            this.lbl_Job.Text = "شغل:";
            // 
            // val_Gender
            // 
            this.val_Gender.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.val_Gender.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_Gender.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.val_Gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.val_Gender.Location = new System.Drawing.Point(367, 53);
            this.val_Gender.Name = "val_Gender";
            this.val_Gender.Size = new System.Drawing.Size(42, 28);
            this.val_Gender.TabIndex = 1;
            this.val_Gender.Text = "...";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Gender.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Gender.Location = new System.Drawing.Point(415, 53);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(53, 28);
            this.lbl_Gender.TabIndex = 1;
            this.lbl_Gender.Text = "جنسيت:";
            // 
            // val_BrithDate
            // 
            this.val_BrithDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.val_BrithDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_BrithDate.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.val_BrithDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.val_BrithDate.Location = new System.Drawing.Point(474, 53);
            this.val_BrithDate.Name = "val_BrithDate";
            this.val_BrithDate.Size = new System.Drawing.Size(122, 28);
            this.val_BrithDate.TabIndex = 1;
            this.val_BrithDate.Text = "...";
            // 
            // lbl_BrithDate
            // 
            this.lbl_BrithDate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_BrithDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_BrithDate.Location = new System.Drawing.Point(602, 53);
            this.lbl_BrithDate.Name = "lbl_BrithDate";
            this.lbl_BrithDate.Size = new System.Drawing.Size(63, 28);
            this.lbl_BrithDate.TabIndex = 1;
            this.lbl_BrithDate.Text = "تاريخ تولد:";
            // 
            // lbl_News
            // 
            this.lbl_News.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_News.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_News.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_News.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_News.Location = new System.Drawing.Point(265, 10);
            this.lbl_News.Name = "lbl_News";
            this.lbl_News.Size = new System.Drawing.Size(80, 28);
            this.lbl_News.Symbol = "";
            this.lbl_News.TabIndex = 1;
            this.lbl_News.Text = "...";
            this.lbl_News.TextAlignment = System.Drawing.StringAlignment.Center;
            this.lbl_News.Visible = false;
            // 
            // val_AllSendedMessages
            // 
            this.val_AllSendedMessages.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.val_AllSendedMessages.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_AllSendedMessages.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.val_AllSendedMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.val_AllSendedMessages.Location = new System.Drawing.Point(367, 95);
            this.val_AllSendedMessages.Name = "val_AllSendedMessages";
            this.val_AllSendedMessages.Size = new System.Drawing.Size(170, 28);
            this.val_AllSendedMessages.TabIndex = 1;
            this.val_AllSendedMessages.Text = "...";
            // 
            // val_AllReciveMessages
            // 
            this.val_AllReciveMessages.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.val_AllReciveMessages.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_AllReciveMessages.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.val_AllReciveMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.val_AllReciveMessages.Location = new System.Drawing.Point(671, 94);
            this.val_AllReciveMessages.Name = "val_AllReciveMessages";
            this.val_AllReciveMessages.Size = new System.Drawing.Size(123, 28);
            this.val_AllReciveMessages.TabIndex = 1;
            this.val_AllReciveMessages.Text = "...";
            // 
            // val_PersonalCode
            // 
            this.val_PersonalCode.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.val_PersonalCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_PersonalCode.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.val_PersonalCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.val_PersonalCode.Location = new System.Drawing.Point(671, 53);
            this.val_PersonalCode.Name = "val_PersonalCode";
            this.val_PersonalCode.Size = new System.Drawing.Size(146, 28);
            this.val_PersonalCode.TabIndex = 1;
            this.val_PersonalCode.Text = "...";
            // 
            // lbl_AllSendedMessage
            // 
            this.lbl_AllSendedMessage.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_AllSendedMessage.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_AllSendedMessage.Location = new System.Drawing.Point(543, 95);
            this.lbl_AllSendedMessage.Name = "lbl_AllSendedMessage";
            this.lbl_AllSendedMessage.Size = new System.Drawing.Size(122, 28);
            this.lbl_AllSendedMessage.TabIndex = 1;
            this.lbl_AllSendedMessage.Text = "همه نامه‌هاي ارسالي:";
            // 
            // lbl_AllReciveMessages
            // 
            this.lbl_AllReciveMessages.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_AllReciveMessages.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_AllReciveMessages.Location = new System.Drawing.Point(800, 96);
            this.lbl_AllReciveMessages.Name = "lbl_AllReciveMessages";
            this.lbl_AllReciveMessages.Size = new System.Drawing.Size(127, 28);
            this.lbl_AllReciveMessages.TabIndex = 1;
            this.lbl_AllReciveMessages.Text = "همه نامه‌هاي دريافتي:";
            // 
            // lbl_PersonalCode
            // 
            this.lbl_PersonalCode.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_PersonalCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_PersonalCode.Location = new System.Drawing.Point(823, 53);
            this.lbl_PersonalCode.Name = "lbl_PersonalCode";
            this.lbl_PersonalCode.Size = new System.Drawing.Size(87, 28);
            this.lbl_PersonalCode.TabIndex = 1;
            this.lbl_PersonalCode.Text = "شماره پرسنلي:";
            // 
            // val_Date
            // 
            this.val_Date.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.val_Date.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_Date.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.val_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.val_Date.Location = new System.Drawing.Point(921, 95);
            this.val_Date.Name = "val_Date";
            this.val_Date.Size = new System.Drawing.Size(124, 28);
            this.val_Date.TabIndex = 1;
            this.val_Date.Text = "...";
            // 
            // val_LastName
            // 
            this.val_LastName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.val_LastName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_LastName.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.val_LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.val_LastName.Location = new System.Drawing.Point(916, 53);
            this.val_LastName.Name = "val_LastName";
            this.val_LastName.Size = new System.Drawing.Size(137, 28);
            this.val_LastName.TabIndex = 1;
            this.val_LastName.Text = "...";
            // 
            // lbl_Date
            // 
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Date.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Date.Location = new System.Drawing.Point(1051, 95);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(64, 28);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "تاريخ ورود:";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_LastName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_LastName.Location = new System.Drawing.Point(1059, 53);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(78, 28);
            this.lbl_LastName.TabIndex = 1;
            this.lbl_LastName.Text = "نام خانوادگي:";
            // 
            // val_Time
            // 
            this.val_Time.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.val_Time.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_Time.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.val_Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.val_Time.Location = new System.Drawing.Point(1130, 95);
            this.val_Time.Name = "val_Time";
            this.val_Time.Size = new System.Drawing.Size(119, 28);
            this.val_Time.TabIndex = 1;
            this.val_Time.Text = "...";
            // 
            // lbl_Time
            // 
            this.lbl_Time.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Time.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Time.Location = new System.Drawing.Point(1255, 96);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(69, 28);
            this.lbl_Time.TabIndex = 1;
            this.lbl_Time.Text = "ساعت ورود:";
            // 
            // val_Name
            // 
            this.val_Name.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.val_Name.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.val_Name.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.val_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.val_Name.Location = new System.Drawing.Point(1143, 53);
            this.val_Name.Name = "val_Name";
            this.val_Name.Size = new System.Drawing.Size(134, 28);
            this.val_Name.TabIndex = 1;
            this.val_Name.Text = "...";
            // 
            // lbl_Name
            // 
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Name.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Name.Location = new System.Drawing.Point(1283, 53);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(20, 28);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "نام:";
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Title.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Title.ForeColor = System.Drawing.Color.DarkViolet;
            this.lbl_Title.Location = new System.Drawing.Point(565, 3);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(208, 37);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "سيستم اتوماسيون اداري";
            // 
            // timer
            // 
            this.timer.Interval = 60000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbl_AddDocument
            // 
            this.lbl_AddDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_AddDocument.ForeColor = System.Drawing.Color.Blue;
            this.lbl_AddDocument.Name = "lbl_AddDocument";
            this.lbl_AddDocument.Symbol = "58417";
            this.lbl_AddDocument.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_AddDocument.Text = "ثبت اسناد";
            this.lbl_AddDocument.Click += new System.EventHandler(this.lbl_AddDocument_Click);
            // 
            // frmMainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.ControlBox = false;
            this.Controls.Add(this.exb_RightMenu);
            this.Controls.Add(this.pnl_UpMenu);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmMainUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainUser_FormClosing);
            this.Load += new System.EventHandler(this.frmMainUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exb_RightMenu)).EndInit();
            this.pnl_UpMenu.ResumeLayout(false);
            this.pnl_UpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UserPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_UpMenu;
        private DevComponents.DotNetBar.LabelX lbl_Title;
        private DevComponents.DotNetBar.LabelX lbl_LastName;
        private DevComponents.DotNetBar.LabelX lbl_Name;
        private DevComponents.DotNetBar.LabelX lbl_PersonalCode;
        private DevComponents.DotNetBar.LabelX lbl_BrithDate;
        private DevComponents.DotNetBar.LabelX lbl_Job;
        private DevComponents.DotNetBar.LabelX lbl_Gender;
        private DevComponents.DotNetBar.LabelX val_Name;
        private DevComponents.DotNetBar.LabelX val_LastName;
        private DevComponents.DotNetBar.LabelX val_PersonalCode;
        private DevComponents.DotNetBar.LabelX val_Gender;
        private DevComponents.DotNetBar.LabelX val_BrithDate;
        private System.Windows.Forms.PictureBox pic_UserPicture;
        private DevComponents.DotNetBar.LabelX val_Job;
        private DevComponents.DotNetBar.LabelX val_Time;
        private DevComponents.DotNetBar.LabelX lbl_Time;
        private DevComponents.DotNetBar.LabelX val_Date;
        private DevComponents.DotNetBar.LabelX lbl_Date;
        private DevComponents.DotNetBar.LabelX val_AllReciveMessages;
        private DevComponents.DotNetBar.LabelX lbl_AllReciveMessages;
        private DevComponents.DotNetBar.LabelX val_AllSendedMessages;
        private DevComponents.DotNetBar.LabelX lbl_AllSendedMessage;
        private DevComponents.DotNetBar.ExplorerBar exb_RightMenu;
        private DevComponents.DotNetBar.ExplorerBarGroupItem ebg_Dashboard;
        private DevComponents.DotNetBar.ExplorerBarGroupItem ebg_Recycling;
        private DevComponents.DotNetBar.ExplorerBarGroupItem ebg_Operation;
        private DevComponents.DotNetBar.ExplorerBarGroupItem ebg_Newsletters;
        private DevComponents.DotNetBar.LabelItem lbl_AllRecivedMessages;
        private DevComponents.DotNetBar.LabelItem lbl_ReadedMessages;
        private DevComponents.DotNetBar.LabelItem lbl_UnReadedMessages;
        private DevComponents.DotNetBar.LabelItem lbl_UrgentActionMessages;
        private DevComponents.DotNetBar.LabelItem lbl_ConfidentialMessages;
        private DevComponents.DotNetBar.LabelItem lbl_ArrivedNotes;
        private DevComponents.DotNetBar.LabelItem lbl_ShowNotes;
        private DevComponents.DotNetBar.LabelItem lbl_SendedMessages;
        private DevComponents.DotNetBar.LabelItem lbl_Following;
        private DevComponents.DotNetBar.LabelItem lbl_SendedNotes;
        private DevComponents.DotNetBar.LabelItem lbl_ReferredMessages;
        private DevComponents.DotNetBar.LabelItem lbl_CreateMessage;
        private DevComponents.DotNetBar.LabelItem lbl_CreateNote;
        private DevComponents.DotNetBar.LabelItem lbl_AddReminder;
        private DevComponents.DotNetBar.LabelItem lbl_Draft;
        private DevComponents.DotNetBar.LabelItem lbl_NewsAndAnnouncement;
        private DevComponents.DotNetBar.LabelItem lbl_ShowGetReferenceLetters;
        private System.Windows.Forms.Timer timer;
        private DevComponents.DotNetBar.LabelX lbl_News;
        private DevComponents.DotNetBar.ExplorerBarGroupItem ebg_Assessment;
        private DevComponents.DotNetBar.LabelItem lbl_DailyFunction;
        private DevComponents.DotNetBar.LabelItem lbl_ShowPersonelsFunctions;
        private System.Windows.Forms.LinkLabel lbl_UpdatePassword;
        private System.Windows.Forms.LinkLabel lbl_Exit;
        private System.Windows.Forms.LinkLabel lbl_RequestSupport;
        private DevComponents.DotNetBar.LabelItem lbl_AddDocument;
    }
}