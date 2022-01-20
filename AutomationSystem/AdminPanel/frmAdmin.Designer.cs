namespace AutomationSystem.AdminPanel
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbc_UpMenu = new DevComponents.DotNetBar.RibbonControl();
            this.rbp_UpMenu = new DevComponents.DotNetBar.RibbonPanel();
            this.rib_Reminder = new DevComponents.DotNetBar.RibbonBar();
            this.btn_Reminder = new DevComponents.DotNetBar.ButtonItem();
            this.rib_Messenger = new DevComponents.DotNetBar.RibbonBar();
            this.btn_Messenger = new DevComponents.DotNetBar.ButtonItem();
            this.rib_AssignmentJob = new DevComponents.DotNetBar.RibbonBar();
            this.btn_AssignmentJob = new DevComponents.DotNetBar.ButtonItem();
            this.rib_JobsManager = new DevComponents.DotNetBar.RibbonBar();
            this.btn_JobsManager = new DevComponents.DotNetBar.ButtonItem();
            this.rib_Jobs = new DevComponents.DotNetBar.RibbonBar();
            this.btn_Jobs = new DevComponents.DotNetBar.ButtonItem();
            this.rib_Users = new DevComponents.DotNetBar.RibbonBar();
            this.btn_Users = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.rti_ManagmentSection = new DevComponents.DotNetBar.RibbonTabItem();
            this.rti_Reports = new DevComponents.DotNetBar.RibbonTabItem();
            this.btn_MenuBar = new DevComponents.DotNetBar.ApplicationButton();
            this.btn_Title = new DevComponents.DotNetBar.ButtonItem();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.pnl_MainPanel = new DevComponents.DotNetBar.PanelEx();
            this.pnl_SystemStatus = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_LastLoginValue = new DevComponents.DotNetBar.LabelX();
            this.lbl_LastLogin = new DevComponents.DotNetBar.LabelX();
            this.lbl_YourIPValue = new DevComponents.DotNetBar.LabelX();
            this.lbl_YourIP = new DevComponents.DotNetBar.LabelX();
            this.lbl_ForSupportValue = new DevComponents.DotNetBar.LabelX();
            this.lbl_ForSupport = new DevComponents.DotNetBar.LabelX();
            this.lbl_AllActiveUsersValue = new DevComponents.DotNetBar.LabelX();
            this.lbl_AllActiveUsers = new DevComponents.DotNetBar.LabelX();
            this.lbl_OnlineUsersValue = new DevComponents.DotNetBar.LabelX();
            this.lbl_OnlineUsers = new DevComponents.DotNetBar.LabelX();
            this.lbl_TimeValue = new DevComponents.DotNetBar.LabelX();
            this.lbl_Time = new DevComponents.DotNetBar.LabelX();
            this.lbl_DateValue = new DevComponents.DotNetBar.LabelX();
            this.lbl_Date = new DevComponents.DotNetBar.LabelX();
            this.pnl_Reminder = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_RemindSearch = new DevComponents.DotNetBar.ButtonX();
            this.txt_RemindDateTo = new FreeControls.PersianDateTimePicker();
            this.lbl_RemindDateTo = new DevComponents.DotNetBar.LabelX();
            this.txt_RemindDateIn = new FreeControls.PersianDateTimePicker();
            this.lbl_RemindDateIn = new DevComponents.DotNetBar.LabelX();
            this.txt_RemindSubjectSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_RemindSubjectSearch = new DevComponents.DotNetBar.LabelX();
            this.dgv_Reminder = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.col_RemindSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RemindCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RemindCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RemindRememberDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RemindRead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_RemindID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_CurrentUserValue = new DevComponents.DotNetBar.LabelX();
            this.lbl_CurrentUser = new DevComponents.DotNetBar.LabelX();
            this.lbl_Dashboard = new DevComponents.DotNetBar.LabelX();
            this.superTooltip = new DevComponents.DotNetBar.SuperTooltip();
            this.col_Readed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbc_UpMenu.SuspendLayout();
            this.rbp_UpMenu.SuspendLayout();
            this.pnl_MainPanel.SuspendLayout();
            this.pnl_SystemStatus.SuspendLayout();
            this.pnl_Reminder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reminder)).BeginInit();
            this.SuspendLayout();
            // 
            // rbc_UpMenu
            // 
            // 
            // 
            // 
            this.rbc_UpMenu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbc_UpMenu.CanCustomize = false;
            this.rbc_UpMenu.CaptionVisible = true;
            this.rbc_UpMenu.Controls.Add(this.rbp_UpMenu);
            this.rbc_UpMenu.Controls.Add(this.ribbonPanel2);
            this.rbc_UpMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbc_UpMenu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.rti_ManagmentSection,
            this.rti_Reports});
            this.rbc_UpMenu.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.rbc_UpMenu.Location = new System.Drawing.Point(0, 0);
            this.rbc_UpMenu.Name = "rbc_UpMenu";
            this.rbc_UpMenu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.rbc_UpMenu.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_MenuBar,
            this.btn_Title});
            this.rbc_UpMenu.Size = new System.Drawing.Size(934, 169);
            this.rbc_UpMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbc_UpMenu.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.rbc_UpMenu.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.rbc_UpMenu.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.rbc_UpMenu.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.rbc_UpMenu.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.rbc_UpMenu.SystemText.QatDialogAddButton = "&Add >>";
            this.rbc_UpMenu.SystemText.QatDialogCancelButton = "Cancel";
            this.rbc_UpMenu.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.rbc_UpMenu.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.rbc_UpMenu.SystemText.QatDialogOkButton = "OK";
            this.rbc_UpMenu.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.rbc_UpMenu.SystemText.QatDialogRemoveButton = "&Remove";
            this.rbc_UpMenu.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.rbc_UpMenu.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.rbc_UpMenu.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.rbc_UpMenu.TabGroupHeight = 14;
            this.rbc_UpMenu.TabIndex = 0;
            this.rbc_UpMenu.Text = "سيستم اتوماسيون اداري";
            // 
            // rbp_UpMenu
            // 
            this.rbp_UpMenu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.rbp_UpMenu.Controls.Add(this.rib_Reminder);
            this.rbp_UpMenu.Controls.Add(this.rib_Messenger);
            this.rbp_UpMenu.Controls.Add(this.rib_AssignmentJob);
            this.rbp_UpMenu.Controls.Add(this.rib_JobsManager);
            this.rbp_UpMenu.Controls.Add(this.rib_Jobs);
            this.rbp_UpMenu.Controls.Add(this.rib_Users);
            this.rbp_UpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbp_UpMenu.Location = new System.Drawing.Point(0, 64);
            this.rbp_UpMenu.Name = "rbp_UpMenu";
            this.rbp_UpMenu.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.rbp_UpMenu.Size = new System.Drawing.Size(934, 102);
            // 
            // 
            // 
            this.rbp_UpMenu.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbp_UpMenu.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rbp_UpMenu.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rbp_UpMenu.TabIndex = 1;
            // 
            // rib_Reminder
            // 
            this.rib_Reminder.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rib_Reminder.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rib_Reminder.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rib_Reminder.ContainerControlProcessDialogKey = true;
            this.rib_Reminder.Dock = System.Windows.Forms.DockStyle.Left;
            this.rib_Reminder.DragDropSupport = true;
            this.rib_Reminder.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.rib_Reminder.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_Reminder});
            this.rib_Reminder.Location = new System.Drawing.Point(503, 0);
            this.rib_Reminder.Name = "rib_Reminder";
            this.rib_Reminder.Size = new System.Drawing.Size(100, 99);
            this.rib_Reminder.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip.SetSuperTooltip(this.rib_Reminder, new DevComponents.DotNetBar.SuperTooltipInfo("يادآور", "", "مي‌توانيد يك يادآور اضافه كنيد", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.rib_Reminder.TabIndex = 6;
            // 
            // 
            // 
            this.rib_Reminder.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rib_Reminder.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rib_Reminder.TitleVisible = false;
            // 
            // btn_Reminder
            // 
            this.btn_Reminder.Image = global::AutomationSystem.Properties.Resources._06_AddReminder;
            this.btn_Reminder.ImageFixedSize = new System.Drawing.Size(64, 64);
            this.btn_Reminder.Name = "btn_Reminder";
            this.btn_Reminder.SubItemsExpandWidth = 14;
            // 
            // rib_Messenger
            // 
            this.rib_Messenger.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rib_Messenger.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rib_Messenger.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rib_Messenger.ContainerControlProcessDialogKey = true;
            this.rib_Messenger.Dock = System.Windows.Forms.DockStyle.Left;
            this.rib_Messenger.DragDropSupport = true;
            this.rib_Messenger.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.rib_Messenger.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_Messenger});
            this.rib_Messenger.Location = new System.Drawing.Point(403, 0);
            this.rib_Messenger.Name = "rib_Messenger";
            this.rib_Messenger.Size = new System.Drawing.Size(100, 99);
            this.rib_Messenger.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip.SetSuperTooltip(this.rib_Messenger, new DevComponents.DotNetBar.SuperTooltipInfo("پيامرسان", "", "مي‌توانيد به كاربران سيستم پيام ارسال و دريافت كنيد", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.rib_Messenger.TabIndex = 5;
            // 
            // 
            // 
            this.rib_Messenger.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rib_Messenger.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rib_Messenger.TitleVisible = false;
            // 
            // btn_Messenger
            // 
            this.btn_Messenger.Image = global::AutomationSystem.Properties.Resources._05_SendMessage;
            this.btn_Messenger.ImageFixedSize = new System.Drawing.Size(64, 64);
            this.btn_Messenger.Name = "btn_Messenger";
            this.btn_Messenger.SubItemsExpandWidth = 14;
            // 
            // rib_AssignmentJob
            // 
            this.rib_AssignmentJob.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rib_AssignmentJob.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rib_AssignmentJob.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rib_AssignmentJob.ContainerControlProcessDialogKey = true;
            this.rib_AssignmentJob.Dock = System.Windows.Forms.DockStyle.Left;
            this.rib_AssignmentJob.DragDropSupport = true;
            this.rib_AssignmentJob.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.rib_AssignmentJob.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_AssignmentJob});
            this.rib_AssignmentJob.Location = new System.Drawing.Point(303, 0);
            this.rib_AssignmentJob.Name = "rib_AssignmentJob";
            this.rib_AssignmentJob.Size = new System.Drawing.Size(100, 99);
            this.rib_AssignmentJob.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip.SetSuperTooltip(this.rib_AssignmentJob, new DevComponents.DotNetBar.SuperTooltipInfo("انتساب شغل", "", "مي‌توانيد به كاركنان شغل انتساب دهيد", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.rib_AssignmentJob.TabIndex = 4;
            // 
            // 
            // 
            this.rib_AssignmentJob.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rib_AssignmentJob.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rib_AssignmentJob.TitleVisible = false;
            // 
            // btn_AssignmentJob
            // 
            this.btn_AssignmentJob.Image = global::AutomationSystem.Properties.Resources._04_AssignmentJob;
            this.btn_AssignmentJob.ImageFixedSize = new System.Drawing.Size(64, 64);
            this.btn_AssignmentJob.Name = "btn_AssignmentJob";
            this.btn_AssignmentJob.SubItemsExpandWidth = 14;
            // 
            // rib_JobsManager
            // 
            this.rib_JobsManager.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rib_JobsManager.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rib_JobsManager.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rib_JobsManager.ContainerControlProcessDialogKey = true;
            this.rib_JobsManager.Dock = System.Windows.Forms.DockStyle.Left;
            this.rib_JobsManager.DragDropSupport = true;
            this.rib_JobsManager.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.rib_JobsManager.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_JobsManager});
            this.rib_JobsManager.Location = new System.Drawing.Point(203, 0);
            this.rib_JobsManager.Name = "rib_JobsManager";
            this.rib_JobsManager.Size = new System.Drawing.Size(100, 99);
            this.rib_JobsManager.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip.SetSuperTooltip(this.rib_JobsManager, new DevComponents.DotNetBar.SuperTooltipInfo("مديريت مشاغل", "", "مي‌توانيد مشاغل را مديريت كنيد، اضافه يا حذف كنيد", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.rib_JobsManager.TabIndex = 3;
            // 
            // 
            // 
            this.rib_JobsManager.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rib_JobsManager.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rib_JobsManager.TitleVisible = false;
            // 
            // btn_JobsManager
            // 
            this.btn_JobsManager.Image = global::AutomationSystem.Properties.Resources._03_JobsManager;
            this.btn_JobsManager.ImageFixedSize = new System.Drawing.Size(64, 64);
            this.btn_JobsManager.Name = "btn_JobsManager";
            this.btn_JobsManager.SubItemsExpandWidth = 14;
            // 
            // rib_Jobs
            // 
            this.rib_Jobs.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rib_Jobs.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rib_Jobs.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rib_Jobs.ContainerControlProcessDialogKey = true;
            this.rib_Jobs.Dock = System.Windows.Forms.DockStyle.Left;
            this.rib_Jobs.DragDropSupport = true;
            this.rib_Jobs.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.rib_Jobs.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_Jobs});
            this.rib_Jobs.Location = new System.Drawing.Point(103, 0);
            this.rib_Jobs.Name = "rib_Jobs";
            this.rib_Jobs.Size = new System.Drawing.Size(100, 99);
            this.rib_Jobs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip.SetSuperTooltip(this.rib_Jobs, new DevComponents.DotNetBar.SuperTooltipInfo("مشاغل", "", "مي‌توانيد مشاغل را مشاهده كنيد", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.rib_Jobs.TabIndex = 2;
            // 
            // 
            // 
            this.rib_Jobs.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rib_Jobs.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rib_Jobs.TitleVisible = false;
            // 
            // btn_Jobs
            // 
            this.btn_Jobs.Image = global::AutomationSystem.Properties.Resources._02_Jobs;
            this.btn_Jobs.ImageFixedSize = new System.Drawing.Size(64, 64);
            this.btn_Jobs.Name = "btn_Jobs";
            this.btn_Jobs.SubItemsExpandWidth = 14;
            // 
            // rib_Users
            // 
            this.rib_Users.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.rib_Users.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rib_Users.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rib_Users.ContainerControlProcessDialogKey = true;
            this.rib_Users.Dock = System.Windows.Forms.DockStyle.Left;
            this.rib_Users.DragDropSupport = true;
            this.rib_Users.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center;
            this.rib_Users.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_Users});
            this.rib_Users.Location = new System.Drawing.Point(3, 0);
            this.rib_Users.Name = "rib_Users";
            this.rib_Users.Size = new System.Drawing.Size(100, 99);
            this.rib_Users.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.superTooltip.SetSuperTooltip(this.rib_Users, new DevComponents.DotNetBar.SuperTooltipInfo("كاربران", "", "مي‌توانيد كاربران را مشاهده و مديريت كنيد", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
            this.rib_Users.TabIndex = 1;
            // 
            // 
            // 
            this.rib_Users.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.rib_Users.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rib_Users.TitleVisible = false;
            // 
            // btn_Users
            // 
            this.btn_Users.Image = global::AutomationSystem.Properties.Resources._01_Users;
            this.btn_Users.ImageFixedSize = new System.Drawing.Size(64, 64);
            this.btn_Users.Name = "btn_Users";
            this.btn_Users.SubItemsExpandWidth = 14;
            this.btn_Users.Click += new System.EventHandler(this.btn_Users_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 64);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(934, 102);
            // 
            // 
            // 
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 2;
            this.ribbonPanel2.Visible = false;
            // 
            // rti_ManagmentSection
            // 
            this.rti_ManagmentSection.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.rti_ManagmentSection.Checked = true;
            this.rti_ManagmentSection.Name = "rti_ManagmentSection";
            this.rti_ManagmentSection.Panel = this.rbp_UpMenu;
            this.rti_ManagmentSection.Symbol = "57530";
            this.rti_ManagmentSection.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.rti_ManagmentSection.Text = "بخش مديريت";
            // 
            // rti_Reports
            // 
            this.rti_Reports.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.rti_Reports.Name = "rti_Reports";
            this.rti_Reports.Panel = this.ribbonPanel2;
            this.rti_Reports.Symbol = "57931";
            this.rti_Reports.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.rti_Reports.Text = "گزارشات و آمار";
            // 
            // btn_MenuBar
            // 
            this.btn_MenuBar.AutoExpandOnClick = true;
            this.btn_MenuBar.CanCustomize = false;
            this.btn_MenuBar.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.btn_MenuBar.Image = ((System.Drawing.Image)(resources.GetObject("btn_MenuBar.Image")));
            this.btn_MenuBar.ImagePaddingHorizontal = 2;
            this.btn_MenuBar.ImagePaddingVertical = 2;
            this.btn_MenuBar.Name = "btn_MenuBar";
            this.btn_MenuBar.ShowSubItems = false;
            this.btn_MenuBar.Text = "&File";
            // 
            // btn_Title
            // 
            this.btn_Title.Name = "btn_Title";
            this.btn_Title.Text = "پنل مديريتي";
            // 
            // styleManager
            // 
            this.styleManager.ManagerColorTint = System.Drawing.Color.Blue;
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // pnl_MainPanel
            // 
            this.pnl_MainPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnl_MainPanel.Controls.Add(this.pnl_SystemStatus);
            this.pnl_MainPanel.Controls.Add(this.pnl_Reminder);
            this.pnl_MainPanel.Controls.Add(this.lbl_CurrentUserValue);
            this.pnl_MainPanel.Controls.Add(this.lbl_CurrentUser);
            this.pnl_MainPanel.Controls.Add(this.lbl_Dashboard);
            this.pnl_MainPanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_MainPanel.Location = new System.Drawing.Point(0, 169);
            this.pnl_MainPanel.Name = "pnl_MainPanel";
            this.pnl_MainPanel.Size = new System.Drawing.Size(934, 531);
            this.pnl_MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnl_MainPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_MainPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_MainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnl_MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_MainPanel.Style.GradientAngle = 90;
            this.pnl_MainPanel.TabIndex = 1;
            // 
            // pnl_SystemStatus
            // 
            this.pnl_SystemStatus.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_SystemStatus.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_SystemStatus.Controls.Add(this.lbl_LastLoginValue);
            this.pnl_SystemStatus.Controls.Add(this.lbl_LastLogin);
            this.pnl_SystemStatus.Controls.Add(this.lbl_YourIPValue);
            this.pnl_SystemStatus.Controls.Add(this.lbl_YourIP);
            this.pnl_SystemStatus.Controls.Add(this.lbl_ForSupportValue);
            this.pnl_SystemStatus.Controls.Add(this.lbl_ForSupport);
            this.pnl_SystemStatus.Controls.Add(this.lbl_AllActiveUsersValue);
            this.pnl_SystemStatus.Controls.Add(this.lbl_AllActiveUsers);
            this.pnl_SystemStatus.Controls.Add(this.lbl_OnlineUsersValue);
            this.pnl_SystemStatus.Controls.Add(this.lbl_OnlineUsers);
            this.pnl_SystemStatus.Controls.Add(this.lbl_TimeValue);
            this.pnl_SystemStatus.Controls.Add(this.lbl_Time);
            this.pnl_SystemStatus.Controls.Add(this.lbl_DateValue);
            this.pnl_SystemStatus.Controls.Add(this.lbl_Date);
            this.pnl_SystemStatus.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_SystemStatus.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pnl_SystemStatus.Location = new System.Drawing.Point(12, 306);
            this.pnl_SystemStatus.Name = "pnl_SystemStatus";
            this.pnl_SystemStatus.Size = new System.Drawing.Size(910, 200);
            // 
            // 
            // 
            this.pnl_SystemStatus.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_SystemStatus.Style.BackColorGradientAngle = 90;
            this.pnl_SystemStatus.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_SystemStatus.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SystemStatus.Style.BorderBottomWidth = 1;
            this.pnl_SystemStatus.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_SystemStatus.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SystemStatus.Style.BorderLeftWidth = 1;
            this.pnl_SystemStatus.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SystemStatus.Style.BorderRightWidth = 1;
            this.pnl_SystemStatus.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_SystemStatus.Style.BorderTopWidth = 1;
            this.pnl_SystemStatus.Style.CornerDiameter = 4;
            this.pnl_SystemStatus.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_SystemStatus.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_SystemStatus.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_SystemStatus.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_SystemStatus.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_SystemStatus.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_SystemStatus.TabIndex = 4;
            this.pnl_SystemStatus.Text = "وضعيت سيستم";
            // 
            // lbl_LastLoginValue
            // 
            // 
            // 
            // 
            this.lbl_LastLoginValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_LastLoginValue.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_LastLoginValue.ForeColor = System.Drawing.Color.Blue;
            this.lbl_LastLoginValue.Location = new System.Drawing.Point(48, 107);
            this.lbl_LastLoginValue.Name = "lbl_LastLoginValue";
            this.lbl_LastLoginValue.Size = new System.Drawing.Size(204, 30);
            this.lbl_LastLoginValue.TabIndex = 13;
            this.lbl_LastLoginValue.Text = "1400/09/24 - 10:13:26";
            // 
            // lbl_LastLogin
            // 
            // 
            // 
            // 
            this.lbl_LastLogin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_LastLogin.Location = new System.Drawing.Point(258, 112);
            this.lbl_LastLogin.Name = "lbl_LastLogin";
            this.lbl_LastLogin.Size = new System.Drawing.Size(75, 23);
            this.lbl_LastLogin.TabIndex = 12;
            this.lbl_LastLogin.Text = "آخرين ورود:";
            // 
            // lbl_YourIPValue
            // 
            // 
            // 
            // 
            this.lbl_YourIPValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_YourIPValue.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_YourIPValue.ForeColor = System.Drawing.Color.Blue;
            this.lbl_YourIPValue.Location = new System.Drawing.Point(357, 109);
            this.lbl_YourIPValue.Name = "lbl_YourIPValue";
            this.lbl_YourIPValue.Size = new System.Drawing.Size(155, 30);
            this.lbl_YourIPValue.TabIndex = 11;
            this.lbl_YourIPValue.Text = "192.168.302.512";
            // 
            // lbl_YourIP
            // 
            // 
            // 
            // 
            this.lbl_YourIP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_YourIP.Location = new System.Drawing.Point(518, 114);
            this.lbl_YourIP.Name = "lbl_YourIP";
            this.lbl_YourIP.Size = new System.Drawing.Size(125, 23);
            this.lbl_YourIP.TabIndex = 10;
            this.lbl_YourIP.Text = "آي‌پي شما در سيستم:";
            // 
            // lbl_ForSupportValue
            // 
            // 
            // 
            // 
            this.lbl_ForSupportValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_ForSupportValue.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_ForSupportValue.ForeColor = System.Drawing.Color.Blue;
            this.lbl_ForSupportValue.Location = new System.Drawing.Point(661, 110);
            this.lbl_ForSupportValue.Name = "lbl_ForSupportValue";
            this.lbl_ForSupportValue.Size = new System.Drawing.Size(67, 30);
            this.lbl_ForSupportValue.TabIndex = 9;
            this.lbl_ForSupportValue.Text = "12";
            // 
            // lbl_ForSupport
            // 
            // 
            // 
            // 
            this.lbl_ForSupport.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_ForSupport.Location = new System.Drawing.Point(734, 115);
            this.lbl_ForSupport.Name = "lbl_ForSupport";
            this.lbl_ForSupport.Size = new System.Drawing.Size(89, 23);
            this.lbl_ForSupport.TabIndex = 8;
            this.lbl_ForSupport.Text = "موارد پشتيباني:";
            // 
            // lbl_AllActiveUsersValue
            // 
            // 
            // 
            // 
            this.lbl_AllActiveUsersValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_AllActiveUsersValue.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_AllActiveUsersValue.ForeColor = System.Drawing.Color.Blue;
            this.lbl_AllActiveUsersValue.Location = new System.Drawing.Point(70, 19);
            this.lbl_AllActiveUsersValue.Name = "lbl_AllActiveUsersValue";
            this.lbl_AllActiveUsersValue.Size = new System.Drawing.Size(79, 30);
            this.lbl_AllActiveUsersValue.TabIndex = 7;
            this.lbl_AllActiveUsersValue.Text = "108";
            // 
            // lbl_AllActiveUsers
            // 
            // 
            // 
            // 
            this.lbl_AllActiveUsers.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_AllActiveUsers.Location = new System.Drawing.Point(155, 24);
            this.lbl_AllActiveUsers.Name = "lbl_AllActiveUsers";
            this.lbl_AllActiveUsers.Size = new System.Drawing.Size(133, 23);
            this.lbl_AllActiveUsers.TabIndex = 6;
            this.lbl_AllActiveUsers.Text = "تعداد كل كاربران فعال:";
            // 
            // lbl_OnlineUsersValue
            // 
            // 
            // 
            // 
            this.lbl_OnlineUsersValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_OnlineUsersValue.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_OnlineUsersValue.ForeColor = System.Drawing.Color.Blue;
            this.lbl_OnlineUsersValue.Location = new System.Drawing.Point(294, 19);
            this.lbl_OnlineUsersValue.Name = "lbl_OnlineUsersValue";
            this.lbl_OnlineUsersValue.Size = new System.Drawing.Size(77, 30);
            this.lbl_OnlineUsersValue.TabIndex = 5;
            this.lbl_OnlineUsersValue.Text = "24";
            // 
            // lbl_OnlineUsers
            // 
            // 
            // 
            // 
            this.lbl_OnlineUsers.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_OnlineUsers.Location = new System.Drawing.Point(377, 24);
            this.lbl_OnlineUsers.Name = "lbl_OnlineUsers";
            this.lbl_OnlineUsers.Size = new System.Drawing.Size(88, 23);
            this.lbl_OnlineUsers.TabIndex = 4;
            this.lbl_OnlineUsers.Text = "كاربران آنلاين:";
            // 
            // lbl_TimeValue
            // 
            // 
            // 
            // 
            this.lbl_TimeValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_TimeValue.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_TimeValue.ForeColor = System.Drawing.Color.Blue;
            this.lbl_TimeValue.Location = new System.Drawing.Point(484, 19);
            this.lbl_TimeValue.Name = "lbl_TimeValue";
            this.lbl_TimeValue.Size = new System.Drawing.Size(106, 30);
            this.lbl_TimeValue.TabIndex = 3;
            this.lbl_TimeValue.Text = "17:30:22";
            // 
            // lbl_Time
            // 
            // 
            // 
            // 
            this.lbl_Time.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Time.Location = new System.Drawing.Point(596, 24);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(45, 23);
            this.lbl_Time.TabIndex = 2;
            this.lbl_Time.Text = "ساعت:";
            // 
            // lbl_DateValue
            // 
            // 
            // 
            // 
            this.lbl_DateValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_DateValue.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_DateValue.ForeColor = System.Drawing.Color.Blue;
            this.lbl_DateValue.Location = new System.Drawing.Point(661, 19);
            this.lbl_DateValue.Name = "lbl_DateValue";
            this.lbl_DateValue.Size = new System.Drawing.Size(111, 30);
            this.lbl_DateValue.TabIndex = 1;
            this.lbl_DateValue.Text = "1400/10/20";
            // 
            // lbl_Date
            // 
            // 
            // 
            // 
            this.lbl_Date.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Date.Location = new System.Drawing.Point(778, 24);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(45, 23);
            this.lbl_Date.TabIndex = 0;
            this.lbl_Date.Text = "تاريخ:";
            // 
            // pnl_Reminder
            // 
            this.pnl_Reminder.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Reminder.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Reminder.Controls.Add(this.btn_RemindSearch);
            this.pnl_Reminder.Controls.Add(this.txt_RemindDateTo);
            this.pnl_Reminder.Controls.Add(this.lbl_RemindDateTo);
            this.pnl_Reminder.Controls.Add(this.txt_RemindDateIn);
            this.pnl_Reminder.Controls.Add(this.lbl_RemindDateIn);
            this.pnl_Reminder.Controls.Add(this.txt_RemindSubjectSearch);
            this.pnl_Reminder.Controls.Add(this.lbl_RemindSubjectSearch);
            this.pnl_Reminder.Controls.Add(this.dgv_Reminder);
            this.pnl_Reminder.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Reminder.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pnl_Reminder.Location = new System.Drawing.Point(12, 67);
            this.pnl_Reminder.Name = "pnl_Reminder";
            this.pnl_Reminder.Size = new System.Drawing.Size(910, 233);
            // 
            // 
            // 
            this.pnl_Reminder.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnl_Reminder.Style.BackColorGradientAngle = 90;
            this.pnl_Reminder.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnl_Reminder.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Reminder.Style.BorderBottomWidth = 1;
            this.pnl_Reminder.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnl_Reminder.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Reminder.Style.BorderLeftWidth = 1;
            this.pnl_Reminder.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Reminder.Style.BorderRightWidth = 1;
            this.pnl_Reminder.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnl_Reminder.Style.BorderTopWidth = 1;
            this.pnl_Reminder.Style.CornerDiameter = 4;
            this.pnl_Reminder.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnl_Reminder.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnl_Reminder.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnl_Reminder.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnl_Reminder.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnl_Reminder.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnl_Reminder.TabIndex = 3;
            this.pnl_Reminder.Text = "يادآور";
            // 
            // btn_RemindSearch
            // 
            this.btn_RemindSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_RemindSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_RemindSearch.Location = new System.Drawing.Point(43, 147);
            this.btn_RemindSearch.Name = "btn_RemindSearch";
            this.btn_RemindSearch.Size = new System.Drawing.Size(64, 44);
            this.btn_RemindSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_RemindSearch.Symbol = "";
            this.btn_RemindSearch.TabIndex = 7;
            this.btn_RemindSearch.Click += new System.EventHandler(this.btn_RemindSearch_Click);
            // 
            // txt_RemindDateTo
            // 
            this.txt_RemindDateTo.BackColor = System.Drawing.Color.White;
            this.txt_RemindDateTo.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.txt_RemindDateTo.Location = new System.Drawing.Point(144, 154);
            this.txt_RemindDateTo.Name = "txt_RemindDateTo";
            this.txt_RemindDateTo.ShowTime = false;
            this.txt_RemindDateTo.Size = new System.Drawing.Size(165, 31);
            this.txt_RemindDateTo.TabIndex = 6;
            this.txt_RemindDateTo.Text = "persianDateTimePicker2";
            this.txt_RemindDateTo.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_RemindDateTo.Value")));
            // 
            // lbl_RemindDateTo
            // 
            // 
            // 
            // 
            this.lbl_RemindDateTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_RemindDateTo.Location = new System.Drawing.Point(315, 154);
            this.lbl_RemindDateTo.Name = "lbl_RemindDateTo";
            this.lbl_RemindDateTo.Size = new System.Drawing.Size(11, 23);
            this.lbl_RemindDateTo.TabIndex = 5;
            this.lbl_RemindDateTo.Text = "تا";
            // 
            // txt_RemindDateIn
            // 
            this.txt_RemindDateIn.BackColor = System.Drawing.Color.White;
            this.txt_RemindDateIn.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.txt_RemindDateIn.Location = new System.Drawing.Point(332, 154);
            this.txt_RemindDateIn.Name = "txt_RemindDateIn";
            this.txt_RemindDateIn.ShowTime = false;
            this.txt_RemindDateIn.Size = new System.Drawing.Size(165, 31);
            this.txt_RemindDateIn.TabIndex = 4;
            this.txt_RemindDateIn.Text = "persianDateTimePicker1";
            this.txt_RemindDateIn.Value = ((FreeControls.PersianDate)(resources.GetObject("txt_RemindDateIn.Value")));
            // 
            // lbl_RemindDateIn
            // 
            // 
            // 
            // 
            this.lbl_RemindDateIn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_RemindDateIn.Location = new System.Drawing.Point(503, 154);
            this.lbl_RemindDateIn.Name = "lbl_RemindDateIn";
            this.lbl_RemindDateIn.Size = new System.Drawing.Size(99, 23);
            this.lbl_RemindDateIn.TabIndex = 3;
            this.lbl_RemindDateIn.Text = "تاريخ يادآوري از:";
            // 
            // txt_RemindSubjectSearch
            // 
            // 
            // 
            // 
            this.txt_RemindSubjectSearch.Border.Class = "TextBoxBorder";
            this.txt_RemindSubjectSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_RemindSubjectSearch.Location = new System.Drawing.Point(628, 152);
            this.txt_RemindSubjectSearch.Name = "txt_RemindSubjectSearch";
            this.txt_RemindSubjectSearch.PreventEnterBeep = true;
            this.txt_RemindSubjectSearch.Size = new System.Drawing.Size(165, 33);
            this.txt_RemindSubjectSearch.TabIndex = 2;
            // 
            // lbl_RemindSubjectSearch
            // 
            // 
            // 
            // 
            this.lbl_RemindSubjectSearch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_RemindSubjectSearch.Location = new System.Drawing.Point(792, 154);
            this.lbl_RemindSubjectSearch.Name = "lbl_RemindSubjectSearch";
            this.lbl_RemindSubjectSearch.Size = new System.Drawing.Size(93, 23);
            this.lbl_RemindSubjectSearch.TabIndex = 1;
            this.lbl_RemindSubjectSearch.Text = "موضوع يادآوري:";
            // 
            // dgv_Reminder
            // 
            this.dgv_Reminder.AllowUserToAddRows = false;
            this.dgv_Reminder.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Reminder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Reminder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Reminder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_RemindSubject,
            this.col_RemindCaption,
            this.col_RemindCreatedDate,
            this.col_RemindRememberDate,
            this.col_RemindRead,
            this.col_RemindID,
            this.col_Readed});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Reminder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Reminder.EnableHeadersVisualStyles = false;
            this.dgv_Reminder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(181)))), ((int)(((byte)(252)))));
            this.dgv_Reminder.Location = new System.Drawing.Point(3, 3);
            this.dgv_Reminder.Name = "dgv_Reminder";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Reminder.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Reminder.Size = new System.Drawing.Size(898, 127);
            this.dgv_Reminder.TabIndex = 0;
            this.dgv_Reminder.DoubleClick += new System.EventHandler(this.dgv_Reminder_DoubleClick);
            // 
            // col_RemindSubject
            // 
            this.col_RemindSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_RemindSubject.HeaderText = "موضوع";
            this.col_RemindSubject.Name = "col_RemindSubject";
            // 
            // col_RemindCaption
            // 
            this.col_RemindCaption.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_RemindCaption.HeaderText = "توضيحات";
            this.col_RemindCaption.Name = "col_RemindCaption";
            this.col_RemindCaption.Width = 300;
            // 
            // col_RemindCreatedDate
            // 
            this.col_RemindCreatedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_RemindCreatedDate.HeaderText = "تاريخ ثبت";
            this.col_RemindCreatedDate.Name = "col_RemindCreatedDate";
            // 
            // col_RemindRememberDate
            // 
            this.col_RemindRememberDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_RemindRememberDate.HeaderText = "تاريخ يادآوري";
            this.col_RemindRememberDate.Name = "col_RemindRememberDate";
            // 
            // col_RemindRead
            // 
            this.col_RemindRead.HeaderText = "وضعيت";
            this.col_RemindRead.Name = "col_RemindRead";
            // 
            // col_RemindID
            // 
            this.col_RemindID.HeaderText = "RemindID";
            this.col_RemindID.Name = "col_RemindID";
            this.col_RemindID.Visible = false;
            // 
            // lbl_CurrentUserValue
            // 
            // 
            // 
            // 
            this.lbl_CurrentUserValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_CurrentUserValue.Font = new System.Drawing.Font("B Nazanin", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_CurrentUserValue.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_CurrentUserValue.Location = new System.Drawing.Point(12, 16);
            this.lbl_CurrentUserValue.Name = "lbl_CurrentUserValue";
            this.lbl_CurrentUserValue.Size = new System.Drawing.Size(229, 45);
            this.lbl_CurrentUserValue.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_CurrentUserValue.TabIndex = 2;
            this.lbl_CurrentUserValue.Text = "مرتضي حسيني";
            // 
            // lbl_CurrentUser
            // 
            // 
            // 
            // 
            this.lbl_CurrentUser.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_CurrentUser.Font = new System.Drawing.Font("B Nazanin", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_CurrentUser.ForeColor = System.Drawing.Color.Blue;
            this.lbl_CurrentUser.Location = new System.Drawing.Point(247, 16);
            this.lbl_CurrentUser.Name = "lbl_CurrentUser";
            this.lbl_CurrentUser.Size = new System.Drawing.Size(47, 45);
            this.lbl_CurrentUser.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_CurrentUser.TabIndex = 1;
            this.lbl_CurrentUser.Text = "كاربر:";
            // 
            // lbl_Dashboard
            // 
            // 
            // 
            // 
            this.lbl_Dashboard.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Dashboard.Font = new System.Drawing.Font("B Nazanin", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Dashboard.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Dashboard.Location = new System.Drawing.Point(793, 16);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(100, 45);
            this.lbl_Dashboard.Symbol = "57391";
            this.lbl_Dashboard.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbl_Dashboard.TabIndex = 0;
            this.lbl_Dashboard.Text = "داشبورد";
            // 
            // superTooltip
            // 
            this.superTooltip.DefaultTooltipSettings = new DevComponents.DotNetBar.SuperTooltipInfo("", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray);
            // 
            // col_Readed
            // 
            this.col_Readed.HeaderText = "Readed";
            this.col_Readed.Name = "col_Readed";
            this.col_Readed.Visible = false;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 700);
            this.Controls.Add(this.pnl_MainPanel);
            this.Controls.Add(this.rbc_UpMenu);
            this.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmAdmin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سيستم اتوماسيون اداري";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.rbc_UpMenu.ResumeLayout(false);
            this.rbc_UpMenu.PerformLayout();
            this.rbp_UpMenu.ResumeLayout(false);
            this.pnl_MainPanel.ResumeLayout(false);
            this.pnl_SystemStatus.ResumeLayout(false);
            this.pnl_Reminder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reminder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl rbc_UpMenu;
        private DevComponents.DotNetBar.RibbonPanel rbp_UpMenu;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.ApplicationButton btn_MenuBar;
        private DevComponents.DotNetBar.RibbonTabItem rti_ManagmentSection;
        private DevComponents.DotNetBar.RibbonTabItem rti_Reports;
        private DevComponents.DotNetBar.ButtonItem btn_Title;
        private DevComponents.DotNetBar.StyleManager styleManager;
        private DevComponents.DotNetBar.RibbonBar rib_Reminder;
        private DevComponents.DotNetBar.RibbonBar rib_Messenger;
        private DevComponents.DotNetBar.RibbonBar rib_AssignmentJob;
        private DevComponents.DotNetBar.RibbonBar rib_JobsManager;
        private DevComponents.DotNetBar.RibbonBar rib_Jobs;
        private DevComponents.DotNetBar.ButtonItem btn_Jobs;
        private DevComponents.DotNetBar.RibbonBar rib_Users;
        private DevComponents.DotNetBar.ButtonItem btn_Reminder;
        private DevComponents.DotNetBar.ButtonItem btn_Messenger;
        private DevComponents.DotNetBar.ButtonItem btn_AssignmentJob;
        private DevComponents.DotNetBar.ButtonItem btn_JobsManager;
        private DevComponents.DotNetBar.ButtonItem btn_Users;
        private DevComponents.DotNetBar.PanelEx pnl_MainPanel;
        private DevComponents.DotNetBar.LabelX lbl_Dashboard;
        private DevComponents.DotNetBar.LabelX lbl_CurrentUserValue;
        private DevComponents.DotNetBar.LabelX lbl_CurrentUser;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_Reminder;
        private DevComponents.DotNetBar.Controls.GroupPanel pnl_SystemStatus;
        private DevComponents.DotNetBar.LabelX lbl_Date;
        private DevComponents.DotNetBar.LabelX lbl_DateValue;
        private DevComponents.DotNetBar.LabelX lbl_TimeValue;
        private DevComponents.DotNetBar.LabelX lbl_Time;
        private DevComponents.DotNetBar.LabelX lbl_OnlineUsersValue;
        private DevComponents.DotNetBar.LabelX lbl_OnlineUsers;
        private DevComponents.DotNetBar.LabelX lbl_AllActiveUsersValue;
        private DevComponents.DotNetBar.LabelX lbl_AllActiveUsers;
        private DevComponents.DotNetBar.LabelX lbl_ForSupportValue;
        private DevComponents.DotNetBar.LabelX lbl_ForSupport;
        private DevComponents.DotNetBar.LabelX lbl_YourIPValue;
        private DevComponents.DotNetBar.LabelX lbl_YourIP;
        private DevComponents.DotNetBar.LabelX lbl_LastLoginValue;
        private DevComponents.DotNetBar.LabelX lbl_LastLogin;
        private DevComponents.DotNetBar.SuperTooltip superTooltip;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_Reminder;
        private FreeControls.PersianDateTimePicker txt_RemindDateIn;
        private DevComponents.DotNetBar.LabelX lbl_RemindDateIn;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_RemindSubjectSearch;
        private DevComponents.DotNetBar.LabelX lbl_RemindSubjectSearch;
        private FreeControls.PersianDateTimePicker txt_RemindDateTo;
        private DevComponents.DotNetBar.LabelX lbl_RemindDateTo;
        private DevComponents.DotNetBar.ButtonX btn_RemindSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RemindSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RemindCaption;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RemindCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RemindRememberDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RemindRead;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_RemindID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Readed;
    }
}