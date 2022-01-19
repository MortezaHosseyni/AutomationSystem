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
            this.rbc_UpMenu = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
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
            this.lbl_CurrentUserValue = new DevComponents.DotNetBar.LabelX();
            this.lbl_CurrentUser = new DevComponents.DotNetBar.LabelX();
            this.lbl_Dashboard = new DevComponents.DotNetBar.LabelX();
            this.superTooltip = new DevComponents.DotNetBar.SuperTooltip();
            this.dgv_Reminder = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.rbc_UpMenu.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.panelEx1.SuspendLayout();
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
            this.rbc_UpMenu.Controls.Add(this.ribbonPanel1);
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
            this.rbc_UpMenu.Size = new System.Drawing.Size(862, 169);
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
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.rib_Reminder);
            this.ribbonPanel1.Controls.Add(this.rib_Messenger);
            this.ribbonPanel1.Controls.Add(this.rib_AssignmentJob);
            this.ribbonPanel1.Controls.Add(this.rib_JobsManager);
            this.ribbonPanel1.Controls.Add(this.rib_Jobs);
            this.ribbonPanel1.Controls.Add(this.rib_Users);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 64);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(862, 102);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
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
            this.ribbonPanel2.Size = new System.Drawing.Size(862, 102);
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
            this.rti_ManagmentSection.Panel = this.ribbonPanel1;
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
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.pnl_SystemStatus);
            this.panelEx1.Controls.Add(this.pnl_Reminder);
            this.panelEx1.Controls.Add(this.lbl_CurrentUserValue);
            this.panelEx1.Controls.Add(this.lbl_CurrentUser);
            this.panelEx1.Controls.Add(this.lbl_Dashboard);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 169);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(862, 531);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
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
            this.pnl_SystemStatus.Size = new System.Drawing.Size(838, 200);
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
            this.lbl_LastLoginValue.Location = new System.Drawing.Point(3, 107);
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
            this.lbl_LastLogin.Location = new System.Drawing.Point(213, 112);
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
            this.lbl_YourIPValue.Location = new System.Drawing.Point(312, 109);
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
            this.lbl_YourIP.Location = new System.Drawing.Point(473, 114);
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
            this.lbl_ForSupportValue.Location = new System.Drawing.Point(616, 110);
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
            this.lbl_ForSupport.Location = new System.Drawing.Point(689, 115);
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
            this.lbl_AllActiveUsersValue.Location = new System.Drawing.Point(25, 19);
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
            this.lbl_AllActiveUsers.Location = new System.Drawing.Point(110, 24);
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
            this.lbl_OnlineUsersValue.Location = new System.Drawing.Point(249, 19);
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
            this.lbl_OnlineUsers.Location = new System.Drawing.Point(332, 24);
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
            this.lbl_TimeValue.Location = new System.Drawing.Point(439, 19);
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
            this.lbl_Time.Location = new System.Drawing.Point(551, 24);
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
            this.lbl_DateValue.Location = new System.Drawing.Point(616, 19);
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
            this.lbl_Date.Location = new System.Drawing.Point(733, 24);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(45, 23);
            this.lbl_Date.TabIndex = 0;
            this.lbl_Date.Text = "تاريخ:";
            // 
            // pnl_Reminder
            // 
            this.pnl_Reminder.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnl_Reminder.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnl_Reminder.Controls.Add(this.dgv_Reminder);
            this.pnl_Reminder.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnl_Reminder.Location = new System.Drawing.Point(12, 67);
            this.pnl_Reminder.Name = "pnl_Reminder";
            this.pnl_Reminder.Size = new System.Drawing.Size(838, 233);
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
            this.lbl_Dashboard.Location = new System.Drawing.Point(738, 16);
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
            // dgv_Reminder
            // 
            this.dgv_Reminder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Reminder.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Reminder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(181)))), ((int)(((byte)(252)))));
            this.dgv_Reminder.Location = new System.Drawing.Point(3, 3);
            this.dgv_Reminder.Name = "dgv_Reminder";
            this.dgv_Reminder.Size = new System.Drawing.Size(826, 119);
            this.dgv_Reminder.TabIndex = 0;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 700);
            this.Controls.Add(this.panelEx1);
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
            this.ribbonPanel1.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.pnl_SystemStatus.ResumeLayout(false);
            this.pnl_Reminder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reminder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl rbc_UpMenu;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
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
        private DevComponents.DotNetBar.PanelEx panelEx1;
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
    }
}