using Controls;
namespace Constructor
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Общее");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("История");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Школа", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Одноклассники");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Учителя");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Архив");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Информация");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Контент", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Цвета");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Кнопки");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Скроллбары");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Оформление", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.проектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.собратьПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panelManager1 = new Controls.PanelManager();
            this.GeneralPanel = new Controls.ManagedPanel();
            this.general_start_fullscreen = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.general_intro_video = new Constructor.FileSelect();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.general_show_intro = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoPanel = new Controls.ManagedPanel();
            this.label48 = new System.Windows.Forms.Label();
            this.info_html = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SchoolPanel = new Controls.ManagedPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label24 = new System.Windows.Forms.Label();
            this.school_video = new Constructor.FileSelect();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.school_director_name = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.school_director_photo = new Constructor.FileSelect();
            this.school_director_video = new Constructor.FileSelect();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.school_pictures_director = new Constructor.FileSelect();
            this.school_pictures_history = new Constructor.FileSelect();
            this.school_pictures_video = new Constructor.FileSelect();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.school_name = new System.Windows.Forms.TextBox();
            this.school_contacts_phone = new System.Windows.Forms.TextBox();
            this.school_contacts_email = new System.Windows.Forms.TextBox();
            this.school_contacts_links = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.school_photo = new Constructor.FileSelect();
            this.label2 = new System.Windows.Forms.Label();
            this.ArchivePanel = new Controls.ManagedPanel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.archiveSection_photos = new Constructor.FolderSelect();
            this.archiveSection_name = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.archiveSections_path = new Constructor.FolderSelect();
            this.label35 = new System.Windows.Forms.Label();
            this.archiveSections_list = new System.Windows.Forms.ListBox();
            this.archiveSections_datasource = new System.Windows.Forms.BindingSource(this.components);
            this.archiveSections_navigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.label5 = new System.Windows.Forms.Label();
            this.SchoolmatesPanel = new Controls.ManagedPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.schoolmate_contacts_links = new System.Windows.Forms.TextBox();
            this.schoolmate_contacts_phone = new System.Windows.Forms.TextBox();
            this.schoolmate_contacts_cellphone = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.schoolmate_birthday = new System.Windows.Forms.DateTimePicker();
            this.schoolmate_name = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.schoolmate_photos = new Constructor.FolderSelect();
            this.schoolmate_videos = new Constructor.FolderSelect();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.schoolmate_photo = new Constructor.FileSelect();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.schoolmates_path = new Constructor.FolderSelect();
            this.label26 = new System.Windows.Forms.Label();
            this.schoolmates_list = new System.Windows.Forms.ListBox();
            this.schoolmates_datasource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolmates_navigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.TeachersPanel = new Controls.ManagedPanel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.teacher_contacts_links = new System.Windows.Forms.TextBox();
            this.teacher_contacts_phone = new System.Windows.Forms.TextBox();
            this.teacher_contacts_cellphone = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.teacher_name = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.teacher_photos = new Constructor.FolderSelect();
            this.teacher_videos = new Constructor.FolderSelect();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.teacher_photo = new Constructor.FileSelect();
            this.teacher_discipline = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.teachers_path = new Constructor.FolderSelect();
            this.label47 = new System.Windows.Forms.Label();
            this.teachers_list = new System.Windows.Forms.ListBox();
            this.teachers_datasource = new System.Windows.Forms.BindingSource(this.components);
            this.teachers_navigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.label4 = new System.Windows.Forms.Label();
            this.ColorsPanel = new Controls.ManagedPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.ButtonsPanel = new Controls.ManagedPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.ScrollbarsPanel = new Controls.ManagedPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.SchoolHistoryPanel = new Controls.ManagedPanel();
            this.label25 = new System.Windows.Forms.Label();
            this.school_history_html = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.folderSelect3 = new Constructor.FolderSelect();
            this.label38 = new System.Windows.Forms.Label();
            this.data_source = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelManager1.SuspendLayout();
            this.GeneralPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.SchoolPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.ArchivePanel.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archiveSections_datasource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveSections_navigator)).BeginInit();
            this.archiveSections_navigator.SuspendLayout();
            this.SchoolmatesPanel.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolmates_datasource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolmates_navigator)).BeginInit();
            this.schoolmates_navigator.SuspendLayout();
            this.TeachersPanel.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachers_datasource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachers_navigator)).BeginInit();
            this.teachers_navigator.SuspendLayout();
            this.ColorsPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.ScrollbarsPanel.SuspendLayout();
            this.SchoolHistoryPanel.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_source)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проектToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // проектToolStripMenuItem
            // 
            this.проектToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйПроектToolStripMenuItem,
            this.сохранитьПроектToolStripMenuItem,
            this.открытьПроектToolStripMenuItem,
            this.toolStripMenuItem2,
            this.собратьПроектToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.проектToolStripMenuItem.Name = "проектToolStripMenuItem";
            this.проектToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.проектToolStripMenuItem.Text = "Проект";
            // 
            // новыйПроектToolStripMenuItem
            // 
            this.новыйПроектToolStripMenuItem.Name = "новыйПроектToolStripMenuItem";
            this.новыйПроектToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.новыйПроектToolStripMenuItem.Text = "Новый проект";
            this.новыйПроектToolStripMenuItem.Click += new System.EventHandler(this.новыйПроектToolStripMenuItem_Click);
            // 
            // сохранитьПроектToolStripMenuItem
            // 
            this.сохранитьПроектToolStripMenuItem.Name = "сохранитьПроектToolStripMenuItem";
            this.сохранитьПроектToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.сохранитьПроектToolStripMenuItem.Text = "Сохранить проект";
            this.сохранитьПроектToolStripMenuItem.Click += new System.EventHandler(this.сохранитьПроектToolStripMenuItem_Click);
            // 
            // открытьПроектToolStripMenuItem
            // 
            this.открытьПроектToolStripMenuItem.Name = "открытьПроектToolStripMenuItem";
            this.открытьПроектToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.открытьПроектToolStripMenuItem.Text = "Открыть проект";
            this.открытьПроектToolStripMenuItem.Click += new System.EventHandler(this.открытьПроектToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(176, 6);
            // 
            // собратьПроектToolStripMenuItem
            // 
            this.собратьПроектToolStripMenuItem.Name = "собратьПроектToolStripMenuItem";
            this.собратьПроектToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.собратьПроектToolStripMenuItem.Text = "Собрать проект";
            this.собратьПроектToolStripMenuItem.Click += new System.EventHandler(this.собратьПроектToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(176, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelManager1);
            this.splitContainer1.Size = new System.Drawing.Size(1030, 574);
            this.splitContainer1.SplitterDistance = 233;
            this.splitContainer1.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode13.Name = "General";
            treeNode13.Text = "Общее";
            treeNode14.Name = "SchoolHistory";
            treeNode14.Text = "История";
            treeNode15.Name = "School";
            treeNode15.Text = "Школа";
            treeNode16.Name = "Schoolmates";
            treeNode16.Text = "Одноклассники";
            treeNode17.Name = "Teachers";
            treeNode17.Text = "Учителя";
            treeNode18.Name = "Archive";
            treeNode18.Text = "Архив";
            treeNode19.Name = "Info";
            treeNode19.Text = "Информация";
            treeNode20.Name = "Content";
            treeNode20.Text = "Контент";
            treeNode21.Name = "Colors";
            treeNode21.Text = "Цвета";
            treeNode22.Name = "Buttons";
            treeNode22.Text = "Кнопки";
            treeNode23.Name = "Scrollbars";
            treeNode23.Text = "Скроллбары";
            treeNode24.Name = "Design";
            treeNode24.Text = "Оформление";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode24});
            this.treeView1.Size = new System.Drawing.Size(233, 574);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panelManager1
            // 
            this.panelManager1.Controls.Add(this.GeneralPanel);
            this.panelManager1.Controls.Add(this.InfoPanel);
            this.panelManager1.Controls.Add(this.SchoolPanel);
            this.panelManager1.Controls.Add(this.ArchivePanel);
            this.panelManager1.Controls.Add(this.SchoolmatesPanel);
            this.panelManager1.Controls.Add(this.TeachersPanel);
            this.panelManager1.Controls.Add(this.ColorsPanel);
            this.panelManager1.Controls.Add(this.ButtonsPanel);
            this.panelManager1.Controls.Add(this.ScrollbarsPanel);
            this.panelManager1.Controls.Add(this.SchoolHistoryPanel);
            this.panelManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManager1.Location = new System.Drawing.Point(0, 0);
            this.panelManager1.Name = "panelManager1";
            this.panelManager1.SelectedIndex = -1;
            this.panelManager1.SelectedPanel = null;
            this.panelManager1.Size = new System.Drawing.Size(793, 574);
            this.panelManager1.TabIndex = 0;
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.BackColor = System.Drawing.SystemColors.Window;
            this.GeneralPanel.Controls.Add(this.general_start_fullscreen);
            this.GeneralPanel.Controls.Add(this.groupBox1);
            this.GeneralPanel.Controls.Add(this.label1);
            this.GeneralPanel.Location = new System.Drawing.Point(0, 0);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(0, 0);
            this.GeneralPanel.Text = "Общее";
            // 
            // general_start_fullscreen
            // 
            this.general_start_fullscreen.AutoSize = true;
            this.general_start_fullscreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.general_start_fullscreen.Location = new System.Drawing.Point(0, 124);
            this.general_start_fullscreen.Name = "general_start_fullscreen";
            this.general_start_fullscreen.Padding = new System.Windows.Forms.Padding(5);
            this.general_start_fullscreen.Size = new System.Drawing.Size(0, 27);
            this.general_start_fullscreen.TabIndex = 5;
            this.general_start_fullscreen.Text = "Стартовать в полноэкранном режиме";
            this.general_start_fullscreen.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(0, 85);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вступительный ролик";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.general_intro_video, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.general_show_intro, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 62);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // general_intro_video
            // 
            this.general_intro_video.AutoSize = true;
            this.general_intro_video.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.general_intro_video.filename = "";
            this.general_intro_video.filter = "";
            this.general_intro_video.Location = new System.Drawing.Point(158, 8);
            this.general_intro_video.Name = "general_intro_video";
            this.general_intro_video.Size = new System.Drawing.Size(300, 23);
            this.general_intro_video.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Вступительный ролик:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 2;
            // 
            // general_show_intro
            // 
            this.general_show_intro.AutoSize = true;
            this.general_show_intro.Location = new System.Drawing.Point(158, 37);
            this.general_show_intro.Name = "general_show_intro";
            this.general_show_intro.Size = new System.Drawing.Size(300, 17);
            this.general_show_intro.TabIndex = 3;
            this.general_show_intro.Text = "Показывать вступительный ролик";
            this.general_show_intro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(0, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Общее";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.SystemColors.Window;
            this.InfoPanel.Controls.Add(this.label48);
            this.InfoPanel.Controls.Add(this.info_html);
            this.InfoPanel.Controls.Add(this.label6);
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(0, 0);
            this.InfoPanel.Text = "Информация";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Dock = System.Windows.Forms.DockStyle.Top;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label48.Location = new System.Drawing.Point(0, 537);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(168, 13);
            this.label48.TabIndex = 7;
            this.label48.Text = "Доступно html-форматирование";
            this.label48.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // info_html
            // 
            this.info_html.Dock = System.Windows.Forms.DockStyle.Top;
            this.info_html.Location = new System.Drawing.Point(0, 39);
            this.info_html.Multiline = true;
            this.info_html.Name = "info_html";
            this.info_html.Size = new System.Drawing.Size(0, 498);
            this.info_html.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10);
            this.label6.Size = new System.Drawing.Size(0, 39);
            this.label6.TabIndex = 1;
            this.label6.Text = "Информация";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SchoolPanel
            // 
            this.SchoolPanel.BackColor = System.Drawing.SystemColors.Window;
            this.SchoolPanel.Controls.Add(this.groupBox3);
            this.SchoolPanel.Controls.Add(this.groupBox5);
            this.SchoolPanel.Controls.Add(this.groupBox4);
            this.SchoolPanel.Controls.Add(this.groupBox2);
            this.SchoolPanel.Controls.Add(this.label2);
            this.SchoolPanel.Location = new System.Drawing.Point(0, 0);
            this.SchoolPanel.Name = "SchoolPanel";
            this.SchoolPanel.Size = new System.Drawing.Size(0, 0);
            this.SchoolPanel.Text = "Школа";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 490);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(0, 49);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Видео";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label24, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.school_video, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(0, 27);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(78, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Видео школы:";
            // 
            // school_video
            // 
            this.school_video.AutoSize = true;
            this.school_video.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.school_video.filename = "";
            this.school_video.filter = "";
            this.school_video.Location = new System.Drawing.Point(153, 3);
            this.school_video.Name = "school_video";
            this.school_video.Size = new System.Drawing.Size(300, 21);
            this.school_video.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel4);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 388);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(0, 102);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Директор";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.school_director_name, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label21, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label22, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label23, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.school_director_photo, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.school_director_video, 1, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(0, 80);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // school_director_name
            // 
            this.school_director_name.Location = new System.Drawing.Point(153, 3);
            this.school_director_name.Name = "school_director_name";
            this.school_director_name.Size = new System.Drawing.Size(300, 20);
            this.school_director_name.TabIndex = 5;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Имя директора:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 26);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "Фото директора:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 55);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(97, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Видео директора:";
            // 
            // school_director_photo
            // 
            this.school_director_photo.AutoSize = true;
            this.school_director_photo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.school_director_photo.filename = "";
            this.school_director_photo.filter = "";
            this.school_director_photo.Location = new System.Drawing.Point(153, 29);
            this.school_director_photo.Name = "school_director_photo";
            this.school_director_photo.Size = new System.Drawing.Size(300, 23);
            this.school_director_photo.TabIndex = 6;
            // 
            // school_director_video
            // 
            this.school_director_video.AutoSize = true;
            this.school_director_video.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.school_director_video.filename = "";
            this.school_director_video.filter = "";
            this.school_director_video.Location = new System.Drawing.Point(153, 58);
            this.school_director_video.Name = "school_director_video";
            this.school_director_video.Size = new System.Drawing.Size(300, 23);
            this.school_director_video.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 280);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(0, 108);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Картинки в меню:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label18, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label20, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.school_pictures_director, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.school_pictures_history, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.school_pictures_video, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(0, 87);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Директор:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "История:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Видео:";
            // 
            // school_pictures_director
            // 
            this.school_pictures_director.AutoSize = true;
            this.school_pictures_director.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.school_pictures_director.filename = "";
            this.school_pictures_director.filter = "";
            this.school_pictures_director.Location = new System.Drawing.Point(153, 3);
            this.school_pictures_director.Name = "school_pictures_director";
            this.school_pictures_director.Size = new System.Drawing.Size(300, 23);
            this.school_pictures_director.TabIndex = 3;
            // 
            // school_pictures_history
            // 
            this.school_pictures_history.AutoSize = true;
            this.school_pictures_history.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.school_pictures_history.filename = "";
            this.school_pictures_history.filter = "";
            this.school_pictures_history.Location = new System.Drawing.Point(153, 32);
            this.school_pictures_history.Name = "school_pictures_history";
            this.school_pictures_history.Size = new System.Drawing.Size(300, 23);
            this.school_pictures_history.TabIndex = 4;
            // 
            // school_pictures_video
            // 
            this.school_pictures_video.AutoSize = true;
            this.school_pictures_video.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.school_pictures_video.filename = "";
            this.school_pictures_video.filter = "";
            this.school_pictures_video.Location = new System.Drawing.Point(153, 61);
            this.school_pictures_video.Name = "school_pictures_video";
            this.school_pictures_video.Size = new System.Drawing.Size(300, 23);
            this.school_pictures_video.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(0, 241);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Описание школы";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.school_name, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.school_contacts_phone, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.school_contacts_email, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.school_contacts_links, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label16, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.school_photo, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(0, 218);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Название школы:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Телефон школы:";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(3, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 2;
            this.label14.Text = "E-mail школы:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Ссылки школы:";
            // 
            // school_name
            // 
            this.school_name.Location = new System.Drawing.Point(153, 3);
            this.school_name.Name = "school_name";
            this.school_name.Size = new System.Drawing.Size(300, 20);
            this.school_name.TabIndex = 4;
            // 
            // school_contacts_phone
            // 
            this.school_contacts_phone.Location = new System.Drawing.Point(153, 29);
            this.school_contacts_phone.Name = "school_contacts_phone";
            this.school_contacts_phone.Size = new System.Drawing.Size(300, 20);
            this.school_contacts_phone.TabIndex = 5;
            // 
            // school_contacts_email
            // 
            this.school_contacts_email.Location = new System.Drawing.Point(153, 55);
            this.school_contacts_email.Name = "school_contacts_email";
            this.school_contacts_email.Size = new System.Drawing.Size(300, 20);
            this.school_contacts_email.TabIndex = 6;
            // 
            // school_contacts_links
            // 
            this.school_contacts_links.Location = new System.Drawing.Point(153, 81);
            this.school_contacts_links.Multiline = true;
            this.school_contacts_links.Name = "school_contacts_links";
            this.school_contacts_links.Size = new System.Drawing.Size(300, 100);
            this.school_contacts_links.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 184);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Фотография школы:";
            // 
            // school_photo
            // 
            this.school_photo.AutoSize = true;
            this.school_photo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.school_photo.filename = "";
            this.school_photo.filter = "";
            this.school_photo.Location = new System.Drawing.Point(153, 187);
            this.school_photo.Name = "school_photo";
            this.school_photo.Size = new System.Drawing.Size(300, 23);
            this.school_photo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(0, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Школа";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArchivePanel
            // 
            this.ArchivePanel.BackColor = System.Drawing.SystemColors.Window;
            this.ArchivePanel.Controls.Add(this.groupBox9);
            this.ArchivePanel.Controls.Add(this.groupBox8);
            this.ArchivePanel.Controls.Add(this.label5);
            this.ArchivePanel.Location = new System.Drawing.Point(0, 0);
            this.ArchivePanel.Name = "ArchivePanel";
            this.ArchivePanel.Size = new System.Drawing.Size(0, 0);
            this.ArchivePanel.Text = "Архив";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tableLayoutPanel9);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox9.Location = new System.Drawing.Point(0, 281);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(0, 75);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Раздел архива";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.label36, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.label37, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.archiveSection_photos, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.archiveSection_name, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.Size = new System.Drawing.Size(0, 55);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(3, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(105, 13);
            this.label36.TabIndex = 0;
            this.label36.Text = "Название раздела:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(3, 26);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(96, 13);
            this.label37.TabIndex = 1;
            this.label37.Text = "Католог раздела:";
            // 
            // archiveSection_photos
            // 
            this.archiveSection_photos.AutoSize = true;
            this.archiveSection_photos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.archiveSection_photos.filepath = "";
            this.archiveSection_photos.Location = new System.Drawing.Point(153, 29);
            this.archiveSection_photos.Name = "archiveSection_photos";
            this.archiveSection_photos.Size = new System.Drawing.Size(300, 23);
            this.archiveSection_photos.TabIndex = 2;
            // 
            // archiveSection_name
            // 
            this.archiveSection_name.Location = new System.Drawing.Point(153, 3);
            this.archiveSection_name.Name = "archiveSection_name";
            this.archiveSection_name.Size = new System.Drawing.Size(300, 20);
            this.archiveSection_name.TabIndex = 3;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tableLayoutPanel8);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.Location = new System.Drawing.Point(0, 39);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(0, 242);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Разделы архива";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.archiveSections_path, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.label35, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.archiveSections_list, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.archiveSections_navigator, 1, 2);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(602, 223);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // archiveSections_path
            // 
            this.archiveSections_path.AutoSize = true;
            this.archiveSections_path.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.archiveSections_path.filepath = "";
            this.archiveSections_path.Location = new System.Drawing.Point(153, 3);
            this.archiveSections_path.Name = "archiveSections_path";
            this.archiveSections_path.Size = new System.Drawing.Size(446, 23);
            this.archiveSections_path.TabIndex = 0;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(3, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(89, 13);
            this.label35.TabIndex = 1;
            this.label35.Text = "Католог архива:";
            // 
            // archiveSections_list
            // 
            this.archiveSections_list.DataSource = this.archiveSections_datasource;
            this.archiveSections_list.FormattingEnabled = true;
            this.archiveSections_list.Location = new System.Drawing.Point(153, 32);
            this.archiveSections_list.Name = "archiveSections_list";
            this.archiveSections_list.Size = new System.Drawing.Size(446, 160);
            this.archiveSections_list.TabIndex = 2;
            // 
            // archiveSections_navigator
            // 
            this.archiveSections_navigator.AddNewItem = this.toolStripButton1;
            this.archiveSections_navigator.BindingSource = this.archiveSections_datasource;
            this.archiveSections_navigator.CountItem = this.toolStripLabel1;
            this.archiveSections_navigator.DeleteItem = this.toolStripButton2;
            this.archiveSections_navigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2});
            this.archiveSections_navigator.Location = new System.Drawing.Point(150, 195);
            this.archiveSections_navigator.MoveFirstItem = this.toolStripButton3;
            this.archiveSections_navigator.MoveLastItem = this.toolStripButton6;
            this.archiveSections_navigator.MoveNextItem = this.toolStripButton5;
            this.archiveSections_navigator.MovePreviousItem = this.toolStripButton4;
            this.archiveSections_navigator.Name = "archiveSections_navigator";
            this.archiveSections_navigator.PositionItem = this.toolStripTextBox1;
            this.archiveSections_navigator.Size = new System.Drawing.Size(452, 25);
            this.archiveSections_navigator.TabIndex = 3;
            this.archiveSections_navigator.Text = "bindingNavigator2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Add new";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Delete";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move first";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move next";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10);
            this.label5.Size = new System.Drawing.Size(0, 39);
            this.label5.TabIndex = 1;
            this.label5.Text = "Архив";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SchoolmatesPanel
            // 
            this.SchoolmatesPanel.BackColor = System.Drawing.SystemColors.Window;
            this.SchoolmatesPanel.Controls.Add(this.groupBox7);
            this.SchoolmatesPanel.Controls.Add(this.groupBox6);
            this.SchoolmatesPanel.Controls.Add(this.label3);
            this.SchoolmatesPanel.Location = new System.Drawing.Point(0, 0);
            this.SchoolmatesPanel.Name = "SchoolmatesPanel";
            this.SchoolmatesPanel.Size = new System.Drawing.Size(0, 0);
            this.SchoolmatesPanel.Text = "Одноклассники";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel7);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox7.Location = new System.Drawing.Point(0, 281);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(0, 290);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Карточка одноклассника";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.schoolmate_contacts_links, 1, 5);
            this.tableLayoutPanel7.Controls.Add(this.schoolmate_contacts_phone, 1, 4);
            this.tableLayoutPanel7.Controls.Add(this.schoolmate_contacts_cellphone, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.label27, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.schoolmate_birthday, 1, 6);
            this.tableLayoutPanel7.Controls.Add(this.schoolmate_name, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label28, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label29, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.schoolmate_photos, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.schoolmate_videos, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.label30, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.label31, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.label32, 0, 5);
            this.tableLayoutPanel7.Controls.Add(this.label33, 0, 6);
            this.tableLayoutPanel7.Controls.Add(this.label34, 0, 7);
            this.tableLayoutPanel7.Controls.Add(this.schoolmate_photo, 1, 7);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 8;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(0, 268);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // schoolmate_contacts_links
            // 
            this.schoolmate_contacts_links.Location = new System.Drawing.Point(153, 139);
            this.schoolmate_contacts_links.Multiline = true;
            this.schoolmate_contacts_links.Name = "schoolmate_contacts_links";
            this.schoolmate_contacts_links.Size = new System.Drawing.Size(300, 70);
            this.schoolmate_contacts_links.TabIndex = 13;
            // 
            // schoolmate_contacts_phone
            // 
            this.schoolmate_contacts_phone.Location = new System.Drawing.Point(153, 113);
            this.schoolmate_contacts_phone.Name = "schoolmate_contacts_phone";
            this.schoolmate_contacts_phone.Size = new System.Drawing.Size(300, 20);
            this.schoolmate_contacts_phone.TabIndex = 12;
            // 
            // schoolmate_contacts_cellphone
            // 
            this.schoolmate_contacts_cellphone.Location = new System.Drawing.Point(153, 87);
            this.schoolmate_contacts_cellphone.Name = "schoolmate_contacts_cellphone";
            this.schoolmate_contacts_cellphone.Size = new System.Drawing.Size(300, 20);
            this.schoolmate_contacts_cellphone.TabIndex = 11;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(3, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(32, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "Имя:";
            // 
            // schoolmate_birthday
            // 
            this.schoolmate_birthday.Location = new System.Drawing.Point(153, 215);
            this.schoolmate_birthday.Name = "schoolmate_birthday";
            this.schoolmate_birthday.Size = new System.Drawing.Size(300, 20);
            this.schoolmate_birthday.TabIndex = 14;
            // 
            // schoolmate_name
            // 
            this.schoolmate_name.Location = new System.Drawing.Point(153, 3);
            this.schoolmate_name.Name = "schoolmate_name";
            this.schoolmate_name.Size = new System.Drawing.Size(300, 20);
            this.schoolmate_name.TabIndex = 1;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(3, 26);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(107, 13);
            this.label28.TabIndex = 2;
            this.label28.Text = "Папка фотографий:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(3, 55);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(75, 13);
            this.label29.TabIndex = 3;
            this.label29.Text = "Папка видео:";
            // 
            // schoolmate_photos
            // 
            this.schoolmate_photos.AutoSize = true;
            this.schoolmate_photos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.schoolmate_photos.filepath = "";
            this.schoolmate_photos.Location = new System.Drawing.Point(153, 29);
            this.schoolmate_photos.Name = "schoolmate_photos";
            this.schoolmate_photos.Size = new System.Drawing.Size(300, 23);
            this.schoolmate_photos.TabIndex = 4;
            // 
            // schoolmate_videos
            // 
            this.schoolmate_videos.AutoSize = true;
            this.schoolmate_videos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.schoolmate_videos.filepath = "";
            this.schoolmate_videos.Location = new System.Drawing.Point(153, 58);
            this.schoolmate_videos.Name = "schoolmate_videos";
            this.schoolmate_videos.Size = new System.Drawing.Size(300, 23);
            this.schoolmate_videos.TabIndex = 5;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(3, 84);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(115, 13);
            this.label30.TabIndex = 6;
            this.label30.Text = "Мобильный телефон:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(3, 110);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(111, 13);
            this.label31.TabIndex = 7;
            this.label31.Text = "Домашний телефон:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(3, 136);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(49, 13);
            this.label32.TabIndex = 8;
            this.label32.Text = "Ссылки:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(3, 212);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(90, 13);
            this.label33.TabIndex = 9;
            this.label33.Text = "День рождения:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(3, 238);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(75, 13);
            this.label34.TabIndex = 10;
            this.label34.Text = "Фотография:";
            // 
            // schoolmate_photo
            // 
            this.schoolmate_photo.AutoSize = true;
            this.schoolmate_photo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.schoolmate_photo.filename = "";
            this.schoolmate_photo.filter = "";
            this.schoolmate_photo.Location = new System.Drawing.Point(153, 241);
            this.schoolmate_photo.Name = "schoolmate_photo";
            this.schoolmate_photo.Size = new System.Drawing.Size(300, 23);
            this.schoolmate_photo.TabIndex = 15;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tableLayoutPanel6);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(0, 39);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(0, 242);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Одноклассники";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.schoolmates_path, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label26, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.schoolmates_list, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.schoolmates_navigator, 1, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(602, 223);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // schoolmates_path
            // 
            this.schoolmates_path.AutoSize = true;
            this.schoolmates_path.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.schoolmates_path.filepath = "";
            this.schoolmates_path.Location = new System.Drawing.Point(153, 3);
            this.schoolmates_path.Name = "schoolmates_path";
            this.schoolmates_path.Size = new System.Drawing.Size(446, 23);
            this.schoolmates_path.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(3, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(138, 13);
            this.label26.TabIndex = 1;
            this.label26.Text = "Католог одноклассников:";
            // 
            // schoolmates_list
            // 
            this.schoolmates_list.DataSource = this.schoolmates_datasource;
            this.schoolmates_list.FormattingEnabled = true;
            this.schoolmates_list.Location = new System.Drawing.Point(153, 32);
            this.schoolmates_list.Name = "schoolmates_list";
            this.schoolmates_list.Size = new System.Drawing.Size(446, 160);
            this.schoolmates_list.TabIndex = 2;
            // 
            // schoolmates_navigator
            // 
            this.schoolmates_navigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.schoolmates_navigator.BindingSource = this.schoolmates_datasource;
            this.schoolmates_navigator.CountItem = this.bindingNavigatorCountItem;
            this.schoolmates_navigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.schoolmates_navigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.schoolmates_navigator.Location = new System.Drawing.Point(150, 195);
            this.schoolmates_navigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.schoolmates_navigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.schoolmates_navigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.schoolmates_navigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.schoolmates_navigator.Name = "schoolmates_navigator";
            this.schoolmates_navigator.PositionItem = this.bindingNavigatorPositionItem;
            this.schoolmates_navigator.Size = new System.Drawing.Size(452, 25);
            this.schoolmates_navigator.TabIndex = 3;
            this.schoolmates_navigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10);
            this.label3.Size = new System.Drawing.Size(0, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "Одноклассники";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TeachersPanel
            // 
            this.TeachersPanel.BackColor = System.Drawing.SystemColors.Window;
            this.TeachersPanel.Controls.Add(this.groupBox11);
            this.TeachersPanel.Controls.Add(this.groupBox12);
            this.TeachersPanel.Controls.Add(this.label4);
            this.TeachersPanel.Location = new System.Drawing.Point(0, 0);
            this.TeachersPanel.Name = "TeachersPanel";
            this.TeachersPanel.Size = new System.Drawing.Size(0, 0);
            this.TeachersPanel.Text = "Учителя";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.tableLayoutPanel11);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox11.Location = new System.Drawing.Point(0, 281);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(0, 290);
            this.groupBox11.TabIndex = 5;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Карточка учителя";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Controls.Add(this.teacher_contacts_links, 1, 5);
            this.tableLayoutPanel11.Controls.Add(this.teacher_contacts_phone, 1, 4);
            this.tableLayoutPanel11.Controls.Add(this.teacher_contacts_cellphone, 1, 3);
            this.tableLayoutPanel11.Controls.Add(this.label39, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.teacher_name, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.label40, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.label41, 0, 2);
            this.tableLayoutPanel11.Controls.Add(this.teacher_photos, 1, 1);
            this.tableLayoutPanel11.Controls.Add(this.teacher_videos, 1, 2);
            this.tableLayoutPanel11.Controls.Add(this.label42, 0, 3);
            this.tableLayoutPanel11.Controls.Add(this.label43, 0, 4);
            this.tableLayoutPanel11.Controls.Add(this.label44, 0, 5);
            this.tableLayoutPanel11.Controls.Add(this.label45, 0, 6);
            this.tableLayoutPanel11.Controls.Add(this.label46, 0, 7);
            this.tableLayoutPanel11.Controls.Add(this.teacher_photo, 1, 7);
            this.tableLayoutPanel11.Controls.Add(this.teacher_discipline, 1, 6);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 8;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel11.Size = new System.Drawing.Size(0, 268);
            this.tableLayoutPanel11.TabIndex = 1;
            // 
            // teacher_contacts_links
            // 
            this.teacher_contacts_links.Location = new System.Drawing.Point(153, 139);
            this.teacher_contacts_links.Multiline = true;
            this.teacher_contacts_links.Name = "teacher_contacts_links";
            this.teacher_contacts_links.Size = new System.Drawing.Size(300, 70);
            this.teacher_contacts_links.TabIndex = 13;
            // 
            // teacher_contacts_phone
            // 
            this.teacher_contacts_phone.Location = new System.Drawing.Point(153, 113);
            this.teacher_contacts_phone.Name = "teacher_contacts_phone";
            this.teacher_contacts_phone.Size = new System.Drawing.Size(300, 20);
            this.teacher_contacts_phone.TabIndex = 12;
            // 
            // teacher_contacts_cellphone
            // 
            this.teacher_contacts_cellphone.Location = new System.Drawing.Point(153, 87);
            this.teacher_contacts_cellphone.Name = "teacher_contacts_cellphone";
            this.teacher_contacts_cellphone.Size = new System.Drawing.Size(300, 20);
            this.teacher_contacts_cellphone.TabIndex = 11;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(3, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(32, 13);
            this.label39.TabIndex = 0;
            this.label39.Text = "Имя:";
            // 
            // teacher_name
            // 
            this.teacher_name.Location = new System.Drawing.Point(153, 3);
            this.teacher_name.Name = "teacher_name";
            this.teacher_name.Size = new System.Drawing.Size(300, 20);
            this.teacher_name.TabIndex = 1;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(3, 26);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(107, 13);
            this.label40.TabIndex = 2;
            this.label40.Text = "Папка фотографий:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(3, 55);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(75, 13);
            this.label41.TabIndex = 3;
            this.label41.Text = "Папка видео:";
            // 
            // teacher_photos
            // 
            this.teacher_photos.AutoSize = true;
            this.teacher_photos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.teacher_photos.filepath = "";
            this.teacher_photos.Location = new System.Drawing.Point(153, 29);
            this.teacher_photos.Name = "teacher_photos";
            this.teacher_photos.Size = new System.Drawing.Size(300, 23);
            this.teacher_photos.TabIndex = 4;
            // 
            // teacher_videos
            // 
            this.teacher_videos.AutoSize = true;
            this.teacher_videos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.teacher_videos.filepath = "";
            this.teacher_videos.Location = new System.Drawing.Point(153, 58);
            this.teacher_videos.Name = "teacher_videos";
            this.teacher_videos.Size = new System.Drawing.Size(300, 23);
            this.teacher_videos.TabIndex = 5;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(3, 84);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(115, 13);
            this.label42.TabIndex = 6;
            this.label42.Text = "Мобильный телефон:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(3, 110);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(111, 13);
            this.label43.TabIndex = 7;
            this.label43.Text = "Домашний телефон:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(3, 136);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(49, 13);
            this.label44.TabIndex = 8;
            this.label44.Text = "Ссылки:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(3, 212);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(55, 13);
            this.label45.TabIndex = 9;
            this.label45.Text = "Предмет:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(3, 238);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(75, 13);
            this.label46.TabIndex = 10;
            this.label46.Text = "Фотография:";
            // 
            // teacher_photo
            // 
            this.teacher_photo.AutoSize = true;
            this.teacher_photo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.teacher_photo.filename = "";
            this.teacher_photo.filter = "";
            this.teacher_photo.Location = new System.Drawing.Point(153, 241);
            this.teacher_photo.Name = "teacher_photo";
            this.teacher_photo.Size = new System.Drawing.Size(300, 23);
            this.teacher_photo.TabIndex = 15;
            // 
            // teacher_discipline
            // 
            this.teacher_discipline.Location = new System.Drawing.Point(153, 215);
            this.teacher_discipline.Name = "teacher_discipline";
            this.teacher_discipline.Size = new System.Drawing.Size(300, 20);
            this.teacher_discipline.TabIndex = 16;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.tableLayoutPanel12);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox12.Location = new System.Drawing.Point(0, 39);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(0, 242);
            this.groupBox12.TabIndex = 4;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Учителя";
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Controls.Add(this.teachers_path, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.label47, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.teachers_list, 1, 1);
            this.tableLayoutPanel12.Controls.Add(this.teachers_navigator, 1, 2);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 3;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(602, 223);
            this.tableLayoutPanel12.TabIndex = 0;
            // 
            // teachers_path
            // 
            this.teachers_path.AutoSize = true;
            this.teachers_path.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.teachers_path.filepath = "";
            this.teachers_path.Location = new System.Drawing.Point(153, 3);
            this.teachers_path.Name = "teachers_path";
            this.teachers_path.Size = new System.Drawing.Size(446, 23);
            this.teachers_path.TabIndex = 0;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(3, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(138, 13);
            this.label47.TabIndex = 1;
            this.label47.Text = "Католог одноклассников:";
            // 
            // teachers_list
            // 
            this.teachers_list.DataSource = this.teachers_datasource;
            this.teachers_list.FormattingEnabled = true;
            this.teachers_list.Location = new System.Drawing.Point(153, 32);
            this.teachers_list.Name = "teachers_list";
            this.teachers_list.Size = new System.Drawing.Size(446, 160);
            this.teachers_list.TabIndex = 2;
            // 
            // teachers_navigator
            // 
            this.teachers_navigator.AddNewItem = this.toolStripButton7;
            this.teachers_navigator.BindingSource = this.teachers_datasource;
            this.teachers_navigator.CountItem = this.toolStripLabel2;
            this.teachers_navigator.DeleteItem = this.toolStripButton8;
            this.teachers_navigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton11,
            this.toolStripButton12,
            this.toolStripSeparator6,
            this.toolStripButton7,
            this.toolStripButton8});
            this.teachers_navigator.Location = new System.Drawing.Point(150, 195);
            this.teachers_navigator.MoveFirstItem = this.toolStripButton9;
            this.teachers_navigator.MoveLastItem = this.toolStripButton12;
            this.teachers_navigator.MoveNextItem = this.toolStripButton11;
            this.teachers_navigator.MovePreviousItem = this.toolStripButton10;
            this.teachers_navigator.Name = "teachers_navigator";
            this.teachers_navigator.PositionItem = this.toolStripTextBox2;
            this.teachers_navigator.Size = new System.Drawing.Size(452, 25);
            this.teachers_navigator.TabIndex = 3;
            this.teachers_navigator.Text = "bindingNavigator3";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Add new";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel2.Text = "of {0}";
            this.toolStripLabel2.ToolTipText = "Total number of items";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Delete";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "Move first";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Move previous";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Position";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Current position";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "Move next";
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "Move last";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10);
            this.label4.Size = new System.Drawing.Size(0, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "Учителя";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorsPanel
            // 
            this.ColorsPanel.BackColor = System.Drawing.SystemColors.Window;
            this.ColorsPanel.Controls.Add(this.label7);
            this.ColorsPanel.Location = new System.Drawing.Point(0, 0);
            this.ColorsPanel.Name = "ColorsPanel";
            this.ColorsPanel.Size = new System.Drawing.Size(0, 0);
            this.ColorsPanel.Text = "Цвета";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10);
            this.label7.Size = new System.Drawing.Size(0, 39);
            this.label7.TabIndex = 1;
            this.label7.Text = "Цвета";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonsPanel.Controls.Add(this.label8);
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(0, 0);
            this.ButtonsPanel.Text = "Кнопки";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10);
            this.label8.Size = new System.Drawing.Size(0, 39);
            this.label8.TabIndex = 1;
            this.label8.Text = "Кнопки";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScrollbarsPanel
            // 
            this.ScrollbarsPanel.BackColor = System.Drawing.SystemColors.Window;
            this.ScrollbarsPanel.Controls.Add(this.label9);
            this.ScrollbarsPanel.Location = new System.Drawing.Point(0, 0);
            this.ScrollbarsPanel.Name = "ScrollbarsPanel";
            this.ScrollbarsPanel.Size = new System.Drawing.Size(0, 0);
            this.ScrollbarsPanel.Text = "Скроллбары";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(10);
            this.label9.Size = new System.Drawing.Size(0, 39);
            this.label9.TabIndex = 1;
            this.label9.Text = "Скроллбары";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SchoolHistoryPanel
            // 
            this.SchoolHistoryPanel.BackColor = System.Drawing.SystemColors.Window;
            this.SchoolHistoryPanel.Controls.Add(this.label25);
            this.SchoolHistoryPanel.Controls.Add(this.school_history_html);
            this.SchoolHistoryPanel.Controls.Add(this.label19);
            this.SchoolHistoryPanel.Location = new System.Drawing.Point(0, 0);
            this.SchoolHistoryPanel.Name = "SchoolHistoryPanel";
            this.SchoolHistoryPanel.Size = new System.Drawing.Size(0, 0);
            this.SchoolHistoryPanel.Text = "История";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Dock = System.Windows.Forms.DockStyle.Top;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(0, 537);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(168, 13);
            this.label25.TabIndex = 5;
            this.label25.Text = "Доступно html-форматирование";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // school_history_html
            // 
            this.school_history_html.Dock = System.Windows.Forms.DockStyle.Top;
            this.school_history_html.Location = new System.Drawing.Point(0, 39);
            this.school_history_html.Multiline = true;
            this.school_history_html.Name = "school_history_html";
            this.school_history_html.Size = new System.Drawing.Size(0, 498);
            this.school_history_html.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Black;
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(0, 0);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(10);
            this.label19.Size = new System.Drawing.Size(0, 39);
            this.label19.TabIndex = 2;
            this.label19.Text = "История школы";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox10
            // 
            this.groupBox10.Location = new System.Drawing.Point(0, 0);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(200, 100);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.folderSelect3, 1, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // folderSelect3
            // 
            this.folderSelect3.AutoSize = true;
            this.folderSelect3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.folderSelect3.filepath = "";
            this.folderSelect3.Location = new System.Drawing.Point(153, 3);
            this.folderSelect3.Name = "folderSelect3";
            this.folderSelect3.Size = new System.Drawing.Size(44, 23);
            this.folderSelect3.TabIndex = 0;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(3, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(138, 13);
            this.label38.TabIndex = 1;
            this.label38.Text = "Католог одноклассников:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 598);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MemoryBox Constructor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panelManager1.ResumeLayout(false);
            this.GeneralPanel.ResumeLayout(false);
            this.GeneralPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.SchoolPanel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ArchivePanel.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archiveSections_datasource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archiveSections_navigator)).EndInit();
            this.archiveSections_navigator.ResumeLayout(false);
            this.archiveSections_navigator.PerformLayout();
            this.SchoolmatesPanel.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolmates_datasource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolmates_navigator)).EndInit();
            this.schoolmates_navigator.ResumeLayout(false);
            this.schoolmates_navigator.PerformLayout();
            this.TeachersPanel.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachers_datasource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachers_navigator)).EndInit();
            this.teachers_navigator.ResumeLayout(false);
            this.teachers_navigator.PerformLayout();
            this.ColorsPanel.ResumeLayout(false);
            this.ButtonsPanel.ResumeLayout(false);
            this.ScrollbarsPanel.ResumeLayout(false);
            this.SchoolHistoryPanel.ResumeLayout(false);
            this.SchoolHistoryPanel.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_source)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem проектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйПроектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьПроектToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem собратьПроектToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private Controls.PanelManager panelManager1;
        private Controls.ManagedPanel GeneralPanel;
        private System.Windows.Forms.Label label1;
        private ManagedPanel SchoolPanel;
        private ManagedPanel SchoolmatesPanel;
        private ManagedPanel TeachersPanel;
        private ManagedPanel ArchivePanel;
        private ManagedPanel InfoPanel;
        private ManagedPanel ColorsPanel;
        private ManagedPanel ButtonsPanel;
        private ManagedPanel ScrollbarsPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private FileSelect general_intro_video;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox general_show_intro;
        private System.Windows.Forms.CheckBox general_start_fullscreen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox school_name;
        private System.Windows.Forms.TextBox school_contacts_phone;
        private System.Windows.Forms.TextBox school_contacts_email;
        private System.Windows.Forms.TextBox school_contacts_links;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private ManagedPanel SchoolHistoryPanel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private FileSelect school_pictures_director;
        private FileSelect school_pictures_history;
        private FileSelect school_pictures_video;
        private System.Windows.Forms.Label label16;
        private FileSelect school_photo;
        private System.Windows.Forms.TextBox school_director_name;
        private System.Windows.Forms.Label label23;
        private FileSelect school_director_photo;
        private FileSelect school_director_video;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label24;
        private FileSelect school_video;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox school_history_html;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private FolderSelect schoolmates_path;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ListBox schoolmates_list;
        private System.Windows.Forms.BindingNavigator schoolmates_navigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource schoolmates_datasource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox schoolmate_name;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private FolderSelect schoolmate_photos;
        private FolderSelect schoolmate_videos;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DateTimePicker schoolmate_birthday;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox schoolmate_contacts_links;
        private System.Windows.Forms.TextBox schoolmate_contacts_phone;
        private System.Windows.Forms.TextBox schoolmate_contacts_cellphone;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private FileSelect schoolmate_photo;
        private System.Windows.Forms.ToolStripMenuItem сохранитьПроектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private FolderSelect archiveSections_path;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ListBox archiveSections_list;
        private System.Windows.Forms.BindingNavigator archiveSections_navigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private FolderSelect archiveSection_photos;
        private System.Windows.Forms.TextBox archiveSection_name;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private FolderSelect folderSelect3;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.TextBox teacher_contacts_links;
        private System.Windows.Forms.TextBox teacher_contacts_phone;
        private System.Windows.Forms.TextBox teacher_contacts_cellphone;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox teacher_name;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private FolderSelect teacher_photos;
        private FolderSelect teacher_videos;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private FileSelect teacher_photo;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private FolderSelect teachers_path;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.ListBox teachers_list;
        private System.Windows.Forms.BindingNavigator teachers_navigator;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.TextBox teacher_discipline;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox info_html;
        private System.Windows.Forms.BindingSource teachers_datasource;
        private System.Windows.Forms.BindingSource archiveSections_datasource;
        private System.Windows.Forms.BindingSource data_source;
    }
}

