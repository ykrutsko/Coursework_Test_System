namespace TestServer
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("General", 4, 4);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Users", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Groups", 2, 2);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Users & Groups", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Assign tests to users", 10, 10);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Review passed tests", 6, 6);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Users & Tests", 5, 5, new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Tests explorer", 7, 7);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Load test", 8, 8);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Tests", 9, 9, new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Server", 11, 11);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.originalSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonGeneral = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonUsersAndGroups = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUsers = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGroups = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonUsersAndTests = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAssignTestsToUsers = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReviewPassedTests = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonTests = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTestsExplorer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLoadTest = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.panelUsersAndGroups = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.tbUsersForm_FindByLastName = new System.Windows.Forms.TextBox();
            this.tbUsersForm_FindByLogin = new System.Windows.Forms.TextBox();
            this.rbByGroup = new System.Windows.Forms.RadioButton();
            this.cbUsersFormGroup = new System.Windows.Forms.ComboBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbArhived = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAddUserByCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEditUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDeleteUser = new System.Windows.Forms.ToolStripButton();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvUsersForm_Users = new System.Windows.Forms.DataGridView();
            this.panelGroups = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tbGroups_FindByName = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.toolStrip7 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddUserToGroup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRemoveUserFromGroup = new System.Windows.Forms.ToolStripButton();
            this.dgvGroupsForm_Users = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip6 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddGroup = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAddGroupByCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEditGroup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDeleteGroup = new System.Windows.Forms.ToolStripButton();
            this.dgvGroupsForm_Groups = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAdminGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.panelUsersAndTests = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panelAssignTestsToUsers = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.tbAssignTestsForm_FindGroupByName = new System.Windows.Forms.TextBox();
            this.tbAssignTestsForm_FindUserByLastName = new System.Windows.Forms.TextBox();
            this.tbAssignTestsForm_FindUserByLogin = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.toolStrip9 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAssignNewTestForGroup = new System.Windows.Forms.ToolStripButton();
            this.dgvAssignTestsForm_Tests = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.dgvAssignTestsForm_Users = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip8 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAssignNewTestForUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAssignNewTestByCopyForUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRemoveAssignedTestForUser = new System.Windows.Forms.ToolStripButton();
            this.dgvAssignTestsForm_Groups = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label20 = new System.Windows.Forms.Label();
            this.panelReviewPassedTests = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panelTests = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.panelTestsExplorer = new System.Windows.Forms.Panel();
            this.tbTestsExplorerForm_FindByAuthor = new System.Windows.Forms.TextBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbTestsExplorerForm_FindById = new System.Windows.Forms.TextBox();
            this.tbTestsExplorerForm_FindByTitle = new System.Windows.Forms.TextBox();
            this.rbTestsExplorerForm_All = new System.Windows.Forms.RadioButton();
            this.rbTestsExplorerForm_Archived = new System.Windows.Forms.RadioButton();
            this.rbTestsExplorerForm_Actual = new System.Windows.Forms.RadioButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddTest = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonTestLookup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonTestDelete = new System.Windows.Forms.ToolStripButton();
            this.dgvTestsExplorerForm_Tests = new System.Windows.Forms.DataGridView();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.panelLoadTest = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBoxWarningDone = new System.Windows.Forms.PictureBox();
            this.btnLoadTestForm_Clean = new System.Windows.Forms.Button();
            this.btnLoadTestForm_SaveTestToDB = new System.Windows.Forms.Button();
            this.btnLoadTestForm_LoadTest = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLoadTestForm_Answers = new System.Windows.Forms.DataGridView();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dgvLoadTestForm_Questions = new System.Windows.Forms.DataGridView();
            this.Questions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.numericUpDownMinPass = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMaxPointsForTest = new System.Windows.Forms.TextBox();
            this.tbCountOfQuestions = new System.Windows.Forms.TextBox();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.openXmlFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bsLoadTestForm_Questions = new System.Windows.Forms.BindingSource(this.components);
            this.bsLoadTestForm_Answers = new System.Windows.Forms.BindingSource(this.components);
            this.bsTestsExplorerForm_Tests = new System.Windows.Forms.BindingSource(this.components);
            this.bsUsersForm_Users = new System.Windows.Forms.BindingSource(this.components);
            this.bsGroupsForm_Groups = new System.Windows.Forms.BindingSource(this.components);
            this.bsAssignTestsForm_Users = new System.Windows.Forms.BindingSource(this.components);
            this.bsAssignTestsForm_Groups = new System.Windows.Forms.BindingSource(this.components);
            this.bsAssignTestsForm_Tests = new System.Windows.Forms.BindingSource(this.components);
            this.bsGroupsForm_Users = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripButtonServer = new System.Windows.Forms.ToolStripButton();
            this.panelServer = new System.Windows.Forms.Panel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelUsersAndGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.toolStrip5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersForm_Users)).BeginInit();
            this.panelGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.toolStrip7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupsForm_Users)).BeginInit();
            this.toolStrip6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupsForm_Groups)).BeginInit();
            this.panelUsersAndTests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panelAssignTestsToUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.toolStrip9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignTestsForm_Tests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignTestsForm_Users)).BeginInit();
            this.toolStrip8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignTestsForm_Groups)).BeginInit();
            this.panelReviewPassedTests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panelTests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panelTestsExplorer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestsExplorerForm_Tests)).BeginInit();
            this.panelLoadTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarningDone)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadTestForm_Answers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadTestForm_Questions)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLoadTestForm_Questions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLoadTestForm_Answers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTestsExplorerForm_Tests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsersForm_Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroupsForm_Groups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAssignTestsForm_Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAssignTestsForm_Groups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAssignTestsForm_Tests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroupsForm_Users)).BeginInit();
            this.panelServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 662);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1261, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.originalSizeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1261, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // originalSizeToolStripMenuItem
            // 
            this.originalSizeToolStripMenuItem.Name = "originalSizeToolStripMenuItem";
            this.originalSizeToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.originalSizeToolStripMenuItem.Text = "Original size";
            this.originalSizeToolStripMenuItem.Click += new System.EventHandler(this.originalSizeToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonGeneral,
            this.toolStripSeparator5,
            this.toolStripButtonUsersAndGroups,
            this.toolStripButtonUsers,
            this.toolStripButtonGroups,
            this.toolStripSeparator8,
            this.toolStripButtonUsersAndTests,
            this.toolStripButtonAssignTestsToUsers,
            this.toolStripButtonReviewPassedTests,
            this.toolStripSeparator11,
            this.toolStripButtonTests,
            this.toolStripButtonTestsExplorer,
            this.toolStripButtonLoadTest,
            this.toolStripSeparator12,
            this.toolStripButtonServer,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 3);
            this.toolStrip1.Size = new System.Drawing.Size(1261, 31);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonGeneral
            // 
            this.toolStripButtonGeneral.AutoSize = false;
            this.toolStripButtonGeneral.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGeneral.Image = global::TestServer.Properties.Resources.general;
            this.toolStripButtonGeneral.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGeneral.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripButtonGeneral.Name = "toolStripButtonGeneral";
            this.toolStripButtonGeneral.Size = new System.Drawing.Size(25, 25);
            this.toolStripButtonGeneral.Text = "toolStripButton1";
            this.toolStripButtonGeneral.ToolTipText = "General";
            this.toolStripButtonGeneral.Click += new System.EventHandler(this.toolStripButtonMainForm_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripButtonUsersAndGroups
            // 
            this.toolStripButtonUsersAndGroups.AutoSize = false;
            this.toolStripButtonUsersAndGroups.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUsersAndGroups.Image = global::TestServer.Properties.Resources.userAndGroup;
            this.toolStripButtonUsersAndGroups.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsersAndGroups.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripButtonUsersAndGroups.Name = "toolStripButtonUsersAndGroups";
            this.toolStripButtonUsersAndGroups.Size = new System.Drawing.Size(25, 25);
            this.toolStripButtonUsersAndGroups.Text = "toolStripButton2";
            this.toolStripButtonUsersAndGroups.ToolTipText = "Users & Groups";
            this.toolStripButtonUsersAndGroups.Click += new System.EventHandler(this.toolStripButtonMainForm_Click);
            // 
            // toolStripButtonUsers
            // 
            this.toolStripButtonUsers.AutoSize = false;
            this.toolStripButtonUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUsers.Image = global::TestServer.Properties.Resources.user;
            this.toolStripButtonUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsers.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripButtonUsers.Name = "toolStripButtonUsers";
            this.toolStripButtonUsers.Size = new System.Drawing.Size(25, 25);
            this.toolStripButtonUsers.Text = "toolStripButton3";
            this.toolStripButtonUsers.ToolTipText = "Users";
            this.toolStripButtonUsers.Click += new System.EventHandler(this.toolStripButtonMainForm_Click);
            // 
            // toolStripButtonGroups
            // 
            this.toolStripButtonGroups.AutoSize = false;
            this.toolStripButtonGroups.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGroups.Image = global::TestServer.Properties.Resources.group;
            this.toolStripButtonGroups.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGroups.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripButtonGroups.Name = "toolStripButtonGroups";
            this.toolStripButtonGroups.Size = new System.Drawing.Size(25, 25);
            this.toolStripButtonGroups.Text = "toolStripButton4";
            this.toolStripButtonGroups.ToolTipText = "Groups";
            this.toolStripButtonGroups.Click += new System.EventHandler(this.toolStripButtonMainForm_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripButtonUsersAndTests
            // 
            this.toolStripButtonUsersAndTests.AutoSize = false;
            this.toolStripButtonUsersAndTests.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUsersAndTests.Image = global::TestServer.Properties.Resources.uesrsAndTests;
            this.toolStripButtonUsersAndTests.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUsersAndTests.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripButtonUsersAndTests.Name = "toolStripButtonUsersAndTests";
            this.toolStripButtonUsersAndTests.Size = new System.Drawing.Size(25, 25);
            this.toolStripButtonUsersAndTests.Text = "toolStripButton5";
            this.toolStripButtonUsersAndTests.ToolTipText = "Users & Tests";
            this.toolStripButtonUsersAndTests.Click += new System.EventHandler(this.toolStripButtonMainForm_Click);
            // 
            // toolStripButtonAssignTestsToUsers
            // 
            this.toolStripButtonAssignTestsToUsers.AutoSize = false;
            this.toolStripButtonAssignTestsToUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAssignTestsToUsers.Image = global::TestServer.Properties.Resources.assign;
            this.toolStripButtonAssignTestsToUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAssignTestsToUsers.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripButtonAssignTestsToUsers.Name = "toolStripButtonAssignTestsToUsers";
            this.toolStripButtonAssignTestsToUsers.Size = new System.Drawing.Size(25, 25);
            this.toolStripButtonAssignTestsToUsers.Text = "toolStripButton6";
            this.toolStripButtonAssignTestsToUsers.ToolTipText = "Assign tests to users";
            this.toolStripButtonAssignTestsToUsers.Click += new System.EventHandler(this.toolStripButtonMainForm_Click);
            // 
            // toolStripButtonReviewPassedTests
            // 
            this.toolStripButtonReviewPassedTests.AutoSize = false;
            this.toolStripButtonReviewPassedTests.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReviewPassedTests.Image = global::TestServer.Properties.Resources.review;
            this.toolStripButtonReviewPassedTests.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReviewPassedTests.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripButtonReviewPassedTests.Name = "toolStripButtonReviewPassedTests";
            this.toolStripButtonReviewPassedTests.Size = new System.Drawing.Size(25, 25);
            this.toolStripButtonReviewPassedTests.Text = "toolStripButton7";
            this.toolStripButtonReviewPassedTests.ToolTipText = "Review passed tests";
            this.toolStripButtonReviewPassedTests.Click += new System.EventHandler(this.toolStripButtonMainForm_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripButtonTests
            // 
            this.toolStripButtonTests.AutoSize = false;
            this.toolStripButtonTests.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTests.Image = global::TestServer.Properties.Resources.test;
            this.toolStripButtonTests.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTests.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripButtonTests.Name = "toolStripButtonTests";
            this.toolStripButtonTests.Size = new System.Drawing.Size(25, 25);
            this.toolStripButtonTests.Text = "toolStripButton8";
            this.toolStripButtonTests.ToolTipText = "Tests";
            this.toolStripButtonTests.Click += new System.EventHandler(this.toolStripButtonMainForm_Click);
            // 
            // toolStripButtonTestsExplorer
            // 
            this.toolStripButtonTestsExplorer.AutoSize = false;
            this.toolStripButtonTestsExplorer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTestsExplorer.Image = global::TestServer.Properties.Resources.explorer;
            this.toolStripButtonTestsExplorer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTestsExplorer.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripButtonTestsExplorer.Name = "toolStripButtonTestsExplorer";
            this.toolStripButtonTestsExplorer.Size = new System.Drawing.Size(25, 25);
            this.toolStripButtonTestsExplorer.Text = "toolStripButton9";
            this.toolStripButtonTestsExplorer.ToolTipText = "Tests explorer";
            this.toolStripButtonTestsExplorer.Click += new System.EventHandler(this.toolStripButtonMainForm_Click);
            // 
            // toolStripButtonLoadTest
            // 
            this.toolStripButtonLoadTest.AutoSize = false;
            this.toolStripButtonLoadTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLoadTest.Image = global::TestServer.Properties.Resources.sand_clock;
            this.toolStripButtonLoadTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoadTest.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripButtonLoadTest.Name = "toolStripButtonLoadTest";
            this.toolStripButtonLoadTest.Size = new System.Drawing.Size(25, 25);
            this.toolStripButtonLoadTest.Text = "toolStripButton10";
            this.toolStripButtonLoadTest.ToolTipText = "Load test";
            this.toolStripButtonLoadTest.Click += new System.EventHandler(this.toolStripButtonMainForm_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 55);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 4;
            treeNode1.Name = "NodeGeneral";
            treeNode1.SelectedImageIndex = 4;
            treeNode1.Text = "General";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "NodeUsers";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "Users";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "NodeGroups";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Text = "Groups";
            treeNode4.ImageIndex = 0;
            treeNode4.Name = "NodeUsersAndGroups";
            treeNode4.SelectedImageIndex = 0;
            treeNode4.Text = "Users & Groups";
            treeNode5.ImageIndex = 10;
            treeNode5.Name = "NodeAssignTestsToUsers";
            treeNode5.SelectedImageIndex = 10;
            treeNode5.Text = "Assign tests to users";
            treeNode6.ImageIndex = 6;
            treeNode6.Name = "NodeReviewPassedTests";
            treeNode6.SelectedImageIndex = 6;
            treeNode6.Text = "Review passed tests";
            treeNode7.ImageIndex = 5;
            treeNode7.Name = "NodeUsersAndTests";
            treeNode7.SelectedImageIndex = 5;
            treeNode7.Text = "Users & Tests";
            treeNode8.ImageIndex = 7;
            treeNode8.Name = "NodeTestsExplorer";
            treeNode8.SelectedImageIndex = 7;
            treeNode8.Text = "Tests explorer";
            treeNode9.ImageIndex = 8;
            treeNode9.Name = "NodeLoadTest";
            treeNode9.SelectedImageIndex = 8;
            treeNode9.Text = "Load test";
            treeNode10.ImageIndex = 9;
            treeNode10.Name = "NodeTests";
            treeNode10.SelectedImageIndex = 9;
            treeNode10.Text = "Tests";
            treeNode11.ImageIndex = 11;
            treeNode11.Name = "NodeServer";
            treeNode11.SelectedImageIndex = 11;
            treeNode11.Text = "Server";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4,
            treeNode7,
            treeNode10,
            treeNode11});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(214, 607);
            this.treeView1.TabIndex = 4;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "userAndGroup.png");
            this.imageList1.Images.SetKeyName(1, "user.png");
            this.imageList1.Images.SetKeyName(2, "group.png");
            this.imageList1.Images.SetKeyName(3, "server.png");
            this.imageList1.Images.SetKeyName(4, "general");
            this.imageList1.Images.SetKeyName(5, "uesrsAndTests");
            this.imageList1.Images.SetKeyName(6, "review.png");
            this.imageList1.Images.SetKeyName(7, "explorer.png");
            this.imageList1.Images.SetKeyName(8, "load");
            this.imageList1.Images.SetKeyName(9, "test");
            this.imageList1.Images.SetKeyName(10, "assign");
            this.imageList1.Images.SetKeyName(11, "monitor");
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(214, 55);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 607);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // panelGeneral
            // 
            this.panelGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGeneral.Controls.Add(this.pictureBox1);
            this.panelGeneral.Controls.Add(this.label23);
            this.panelGeneral.Location = new System.Drawing.Point(254, 77);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(200, 100);
            this.panelGeneral.TabIndex = 9;
            this.panelGeneral.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestServer.Properties.Resources.general;
            this.pictureBox1.Location = new System.Drawing.Point(15, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(42, 5);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 20);
            this.label23.TabIndex = 22;
            this.label23.Text = "General";
            this.label23.UseMnemonic = false;
            // 
            // panelUsersAndGroups
            // 
            this.panelUsersAndGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUsersAndGroups.Controls.Add(this.pictureBox2);
            this.panelUsersAndGroups.Controls.Add(this.label1);
            this.panelUsersAndGroups.Controls.Add(this.label3);
            this.panelUsersAndGroups.Controls.Add(this.label2);
            this.panelUsersAndGroups.Location = new System.Drawing.Point(254, 197);
            this.panelUsersAndGroups.Name = "panelUsersAndGroups";
            this.panelUsersAndGroups.Size = new System.Drawing.Size(200, 97);
            this.panelUsersAndGroups.TabIndex = 10;
            this.panelUsersAndGroups.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TestServer.Properties.Resources.userAndGroup;
            this.pictureBox2.Location = new System.Drawing.Point(15, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Users & Groups";
            this.label1.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // panelUsers
            // 
            this.panelUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUsers.Controls.Add(this.pictureBox3);
            this.panelUsers.Controls.Add(this.label33);
            this.panelUsers.Controls.Add(this.label34);
            this.panelUsers.Controls.Add(this.tbUsersForm_FindByLastName);
            this.panelUsers.Controls.Add(this.tbUsersForm_FindByLogin);
            this.panelUsers.Controls.Add(this.rbByGroup);
            this.panelUsers.Controls.Add(this.cbUsersFormGroup);
            this.panelUsers.Controls.Add(this.rbAll);
            this.panelUsers.Controls.Add(this.rbArhived);
            this.panelUsers.Controls.Add(this.rbActive);
            this.panelUsers.Controls.Add(this.toolStrip5);
            this.panelUsers.Controls.Add(this.label17);
            this.panelUsers.Controls.Add(this.dgvUsersForm_Users);
            this.panelUsers.Location = new System.Drawing.Point(492, 194);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(200, 100);
            this.panelUsers.TabIndex = 11;
            this.panelUsers.Visible = false;
            this.panelUsers.VisibleChanged += new System.EventHandler(this.panelUsers_VisibleChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TestServer.Properties.Resources.user;
            this.pictureBox3.Location = new System.Drawing.Point(15, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 62;
            this.pictureBox3.TabStop = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(313, 573);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(80, 15);
            this.label33.TabIndex = 61;
            this.label33.Text = "Find by Login";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(16, 573);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(107, 15);
            this.label34.TabIndex = 60;
            this.label34.Text = "Find by Last name";
            // 
            // tbUsersForm_FindByLastName
            // 
            this.tbUsersForm_FindByLastName.Location = new System.Drawing.Point(129, 570);
            this.tbUsersForm_FindByLastName.Name = "tbUsersForm_FindByLastName";
            this.tbUsersForm_FindByLastName.Size = new System.Drawing.Size(150, 21);
            this.tbUsersForm_FindByLastName.TabIndex = 59;
            this.tbUsersForm_FindByLastName.TextChanged += new System.EventHandler(this.tbUsersForm_FindByLastName_TextChanged);
            // 
            // tbUsersForm_FindByLogin
            // 
            this.tbUsersForm_FindByLogin.Location = new System.Drawing.Point(399, 570);
            this.tbUsersForm_FindByLogin.Name = "tbUsersForm_FindByLogin";
            this.tbUsersForm_FindByLogin.Size = new System.Drawing.Size(150, 21);
            this.tbUsersForm_FindByLogin.TabIndex = 58;
            this.tbUsersForm_FindByLogin.TextChanged += new System.EventHandler(this.tbUsersForm_FindByLogin_TextChanged);
            // 
            // rbByGroup
            // 
            this.rbByGroup.AutoSize = true;
            this.rbByGroup.Location = new System.Drawing.Point(703, 34);
            this.rbByGroup.Name = "rbByGroup";
            this.rbByGroup.Size = new System.Drawing.Size(73, 19);
            this.rbByGroup.TabIndex = 36;
            this.rbByGroup.Text = "By group";
            this.rbByGroup.UseVisualStyleBackColor = true;
            this.rbByGroup.CheckedChanged += new System.EventHandler(this.rbByGroup_CheckedChanged);
            // 
            // cbUsersFormGroup
            // 
            this.cbUsersFormGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsersFormGroup.Enabled = false;
            this.cbUsersFormGroup.FormattingEnabled = true;
            this.cbUsersFormGroup.Location = new System.Drawing.Point(782, 33);
            this.cbUsersFormGroup.Name = "cbUsersFormGroup";
            this.cbUsersFormGroup.Size = new System.Drawing.Size(237, 23);
            this.cbUsersFormGroup.TabIndex = 35;
            this.cbUsersFormGroup.SelectedIndexChanged += new System.EventHandler(this.cbUsersFormGroup_SelectedIndexChanged);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(644, 33);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(38, 19);
            this.rbAll.TabIndex = 34;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.Click += new System.EventHandler(this.UsersForm_RadioButtton_Click);
            // 
            // rbArhived
            // 
            this.rbArhived.AutoSize = true;
            this.rbArhived.Location = new System.Drawing.Point(546, 33);
            this.rbArhived.Name = "rbArhived";
            this.rbArhived.Size = new System.Drawing.Size(92, 19);
            this.rbArhived.TabIndex = 33;
            this.rbArhived.Text = "Only arhived";
            this.rbArhived.UseVisualStyleBackColor = true;
            this.rbArhived.Click += new System.EventHandler(this.UsersForm_RadioButtton_Click);
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Checked = true;
            this.rbActive.Location = new System.Drawing.Point(455, 33);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(85, 19);
            this.rbActive.TabIndex = 32;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Only actual";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.Click += new System.EventHandler(this.UsersForm_RadioButtton_Click);
            // 
            // toolStrip5
            // 
            this.toolStrip5.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddUser,
            this.toolStripButtonAddUserByCopy,
            this.toolStripSeparator1,
            this.toolStripButtonEditUser,
            this.toolStripSeparator4,
            this.toolStripButtonDeleteUser});
            this.toolStrip5.Location = new System.Drawing.Point(19, 40);
            this.toolStrip5.Name = "toolStrip5";
            this.toolStrip5.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip5.Size = new System.Drawing.Size(115, 27);
            this.toolStrip5.TabIndex = 31;
            this.toolStrip5.Text = "toolStrip5";
            // 
            // toolStripButtonAddUser
            // 
            this.toolStripButtonAddUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddUser.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddUser.Image")));
            this.toolStripButtonAddUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddUser.Name = "toolStripButtonAddUser";
            this.toolStripButtonAddUser.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonAddUser.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAddUser.ToolTipText = "Add user";
            this.toolStripButtonAddUser.Click += new System.EventHandler(this.toolStripButtonAddUser_Click);
            // 
            // toolStripButtonAddUserByCopy
            // 
            this.toolStripButtonAddUserByCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddUserByCopy.Enabled = false;
            this.toolStripButtonAddUserByCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddUserByCopy.Image")));
            this.toolStripButtonAddUserByCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddUserByCopy.Name = "toolStripButtonAddUserByCopy";
            this.toolStripButtonAddUserByCopy.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonAddUserByCopy.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAddUserByCopy.ToolTipText = "Add user by copy";
            this.toolStripButtonAddUserByCopy.Click += new System.EventHandler(this.toolStripButtonAddUserByCopy_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonEditUser
            // 
            this.toolStripButtonEditUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditUser.Enabled = false;
            this.toolStripButtonEditUser.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditUser.Image")));
            this.toolStripButtonEditUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditUser.Name = "toolStripButtonEditUser";
            this.toolStripButtonEditUser.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonEditUser.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonEditUser.ToolTipText = "Edit user";
            this.toolStripButtonEditUser.Click += new System.EventHandler(this.toolStripButtonEditUser_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonDeleteUser
            // 
            this.toolStripButtonDeleteUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteUser.Enabled = false;
            this.toolStripButtonDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteUser.Image")));
            this.toolStripButtonDeleteUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteUser.Name = "toolStripButtonDeleteUser";
            this.toolStripButtonDeleteUser.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonDeleteUser.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonDeleteUser.ToolTipText = "Delete user";
            this.toolStripButtonDeleteUser.Click += new System.EventHandler(this.toolStripButtonDeleteUser_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(42, 5);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 20);
            this.label17.TabIndex = 19;
            this.label17.Text = "Users";
            this.label17.UseMnemonic = false;
            // 
            // dgvUsersForm_Users
            // 
            this.dgvUsersForm_Users.AllowUserToAddRows = false;
            this.dgvUsersForm_Users.AllowUserToDeleteRows = false;
            this.dgvUsersForm_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersForm_Users.Location = new System.Drawing.Point(19, 68);
            this.dgvUsersForm_Users.MultiSelect = false;
            this.dgvUsersForm_Users.Name = "dgvUsersForm_Users";
            this.dgvUsersForm_Users.ReadOnly = true;
            this.dgvUsersForm_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsersForm_Users.Size = new System.Drawing.Size(1000, 496);
            this.dgvUsersForm_Users.TabIndex = 0;
            this.dgvUsersForm_Users.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsersForm_Users_CellDoubleClick);
            this.dgvUsersForm_Users.SelectionChanged += new System.EventHandler(this.dgvUsersForm_Users_SelectionChanged);
            // 
            // panelGroups
            // 
            this.panelGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGroups.Controls.Add(this.pictureBox4);
            this.panelGroups.Controls.Add(this.label26);
            this.panelGroups.Controls.Add(this.tbGroups_FindByName);
            this.panelGroups.Controls.Add(this.label25);
            this.panelGroups.Controls.Add(this.label24);
            this.panelGroups.Controls.Add(this.toolStrip7);
            this.panelGroups.Controls.Add(this.dgvGroupsForm_Users);
            this.panelGroups.Controls.Add(this.toolStrip6);
            this.panelGroups.Controls.Add(this.dgvGroupsForm_Groups);
            this.panelGroups.Controls.Add(this.label18);
            this.panelGroups.Location = new System.Drawing.Point(724, 194);
            this.panelGroups.Name = "panelGroups";
            this.panelGroups.Size = new System.Drawing.Size(208, 100);
            this.panelGroups.TabIndex = 12;
            this.panelGroups.Visible = false;
            this.panelGroups.VisibleChanged += new System.EventHandler(this.panelGroups_VisibleChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TestServer.Properties.Resources.group;
            this.pictureBox4.Location = new System.Drawing.Point(15, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(16, 573);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(116, 15);
            this.label26.TabIndex = 39;
            this.label26.Text = "Find group by name";
            // 
            // tbGroups_FindByName
            // 
            this.tbGroups_FindByName.Location = new System.Drawing.Point(138, 570);
            this.tbGroups_FindByName.Name = "tbGroups_FindByName";
            this.tbGroups_FindByName.Size = new System.Drawing.Size(411, 21);
            this.tbGroups_FindByName.TabIndex = 38;
            this.tbGroups_FindByName.TextChanged += new System.EventHandler(this.tbGroups_FindByName_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(883, 50);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(136, 15);
            this.label25.TabIndex = 37;
            this.label25.Text = "Users in selected group";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(502, 50);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 15);
            this.label24.TabIndex = 36;
            this.label24.Text = "Groups";
            // 
            // toolStrip7
            // 
            this.toolStrip7.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip7.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddUserToGroup,
            this.toolStripSeparator9,
            this.toolStripButtonRemoveUserFromGroup});
            this.toolStrip7.Location = new System.Drawing.Point(569, 38);
            this.toolStrip7.Name = "toolStrip7";
            this.toolStrip7.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip7.Size = new System.Drawing.Size(59, 27);
            this.toolStrip7.TabIndex = 35;
            this.toolStrip7.Text = "toolStrip7";
            this.toolStrip7.Visible = false;
            // 
            // toolStripButtonAddUserToGroup
            // 
            this.toolStripButtonAddUserToGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddUserToGroup.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddUserToGroup.Image")));
            this.toolStripButtonAddUserToGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddUserToGroup.Name = "toolStripButtonAddUserToGroup";
            this.toolStripButtonAddUserToGroup.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonAddUserToGroup.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAddUserToGroup.ToolTipText = "Add user to selected group";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonRemoveUserFromGroup
            // 
            this.toolStripButtonRemoveUserFromGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemoveUserFromGroup.Enabled = false;
            this.toolStripButtonRemoveUserFromGroup.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRemoveUserFromGroup.Image")));
            this.toolStripButtonRemoveUserFromGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveUserFromGroup.Name = "toolStripButtonRemoveUserFromGroup";
            this.toolStripButtonRemoveUserFromGroup.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonRemoveUserFromGroup.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonRemoveUserFromGroup.ToolTipText = "Remove user from selected group";
            // 
            // dgvGroupsForm_Users
            // 
            this.dgvGroupsForm_Users.AllowUserToAddRows = false;
            this.dgvGroupsForm_Users.AllowUserToDeleteRows = false;
            this.dgvGroupsForm_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupsForm_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvGroupsForm_Users.Location = new System.Drawing.Point(569, 68);
            this.dgvGroupsForm_Users.MultiSelect = false;
            this.dgvGroupsForm_Users.Name = "dgvGroupsForm_Users";
            this.dgvGroupsForm_Users.ReadOnly = true;
            this.dgvGroupsForm_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroupsForm_Users.Size = new System.Drawing.Size(450, 523);
            this.dgvGroupsForm_Users.TabIndex = 34;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Login";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "First name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Last name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // toolStrip6
            // 
            this.toolStrip6.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip6.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddGroup,
            this.toolStripButtonAddGroupByCopy,
            this.toolStripSeparator6,
            this.toolStripButtonEditGroup,
            this.toolStripSeparator7,
            this.toolStripButtonDeleteGroup});
            this.toolStrip6.Location = new System.Drawing.Point(19, 38);
            this.toolStrip6.Name = "toolStrip6";
            this.toolStrip6.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip6.Size = new System.Drawing.Size(115, 27);
            this.toolStrip6.TabIndex = 33;
            this.toolStrip6.Text = "toolStrip6";
            // 
            // toolStripButtonAddGroup
            // 
            this.toolStripButtonAddGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddGroup.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddGroup.Image")));
            this.toolStripButtonAddGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddGroup.Name = "toolStripButtonAddGroup";
            this.toolStripButtonAddGroup.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonAddGroup.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAddGroup.ToolTipText = "Add group";
            this.toolStripButtonAddGroup.Click += new System.EventHandler(this.toolStripButtonAddGroup_Click);
            // 
            // toolStripButtonAddGroupByCopy
            // 
            this.toolStripButtonAddGroupByCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddGroupByCopy.Enabled = false;
            this.toolStripButtonAddGroupByCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddGroupByCopy.Image")));
            this.toolStripButtonAddGroupByCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddGroupByCopy.Name = "toolStripButtonAddGroupByCopy";
            this.toolStripButtonAddGroupByCopy.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonAddGroupByCopy.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAddGroupByCopy.ToolTipText = "Add group by copy";
            this.toolStripButtonAddGroupByCopy.Click += new System.EventHandler(this.toolStripButtonAddGroupByCopy_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonEditGroup
            // 
            this.toolStripButtonEditGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditGroup.Enabled = false;
            this.toolStripButtonEditGroup.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditGroup.Image")));
            this.toolStripButtonEditGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditGroup.Name = "toolStripButtonEditGroup";
            this.toolStripButtonEditGroup.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonEditGroup.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonEditGroup.ToolTipText = "Edit group";
            this.toolStripButtonEditGroup.Click += new System.EventHandler(this.toolStripButtonEditGroup_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonDeleteGroup
            // 
            this.toolStripButtonDeleteGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteGroup.Enabled = false;
            this.toolStripButtonDeleteGroup.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteGroup.Image")));
            this.toolStripButtonDeleteGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteGroup.Name = "toolStripButtonDeleteGroup";
            this.toolStripButtonDeleteGroup.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonDeleteGroup.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonDeleteGroup.ToolTipText = "Delete group";
            this.toolStripButtonDeleteGroup.Click += new System.EventHandler(this.toolStripButtonDeleteGroup_Click);
            // 
            // dgvGroupsForm_Groups
            // 
            this.dgvGroupsForm_Groups.AllowUserToAddRows = false;
            this.dgvGroupsForm_Groups.AllowUserToDeleteRows = false;
            this.dgvGroupsForm_Groups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupsForm_Groups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.GroupName,
            this.Description,
            this.IsAdminGroup});
            this.dgvGroupsForm_Groups.Location = new System.Drawing.Point(19, 68);
            this.dgvGroupsForm_Groups.MultiSelect = false;
            this.dgvGroupsForm_Groups.Name = "dgvGroupsForm_Groups";
            this.dgvGroupsForm_Groups.ReadOnly = true;
            this.dgvGroupsForm_Groups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroupsForm_Groups.Size = new System.Drawing.Size(530, 496);
            this.dgvGroupsForm_Groups.TabIndex = 32;
            this.dgvGroupsForm_Groups.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupsForm_Groups_CellDoubleClick);
            this.dgvGroupsForm_Groups.SelectionChanged += new System.EventHandler(this.dgvGroupsForm_Groups_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // GroupName
            // 
            this.GroupName.HeaderText = "GroupName";
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            this.GroupName.Width = 140;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 190;
            // 
            // IsAdminGroup
            // 
            this.IsAdminGroup.HeaderText = "Admin group";
            this.IsAdminGroup.Name = "IsAdminGroup";
            this.IsAdminGroup.ReadOnly = true;
            this.IsAdminGroup.Width = 90;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(42, 5);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 20);
            this.label18.TabIndex = 19;
            this.label18.Text = "Groups";
            this.label18.UseMnemonic = false;
            // 
            // panelUsersAndTests
            // 
            this.panelUsersAndTests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUsersAndTests.Controls.Add(this.pictureBox5);
            this.panelUsersAndTests.Controls.Add(this.label19);
            this.panelUsersAndTests.Location = new System.Drawing.Point(254, 327);
            this.panelUsersAndTests.Name = "panelUsersAndTests";
            this.panelUsersAndTests.Size = new System.Drawing.Size(200, 100);
            this.panelUsersAndTests.TabIndex = 13;
            this.panelUsersAndTests.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::TestServer.Properties.Resources.uesrsAndTests;
            this.pictureBox5.Location = new System.Drawing.Point(15, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(42, 5);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 20);
            this.label19.TabIndex = 19;
            this.label19.Text = "Users & Tests";
            this.label19.UseMnemonic = false;
            // 
            // panelAssignTestsToUsers
            // 
            this.panelAssignTestsToUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAssignTestsToUsers.Controls.Add(this.pictureBox6);
            this.panelAssignTestsToUsers.Controls.Add(this.label32);
            this.panelAssignTestsToUsers.Controls.Add(this.label31);
            this.panelAssignTestsToUsers.Controls.Add(this.label30);
            this.panelAssignTestsToUsers.Controls.Add(this.tbAssignTestsForm_FindGroupByName);
            this.panelAssignTestsToUsers.Controls.Add(this.tbAssignTestsForm_FindUserByLastName);
            this.panelAssignTestsToUsers.Controls.Add(this.tbAssignTestsForm_FindUserByLogin);
            this.panelAssignTestsToUsers.Controls.Add(this.label27);
            this.panelAssignTestsToUsers.Controls.Add(this.toolStrip9);
            this.panelAssignTestsToUsers.Controls.Add(this.dgvAssignTestsForm_Tests);
            this.panelAssignTestsToUsers.Controls.Add(this.label28);
            this.panelAssignTestsToUsers.Controls.Add(this.label29);
            this.panelAssignTestsToUsers.Controls.Add(this.dgvAssignTestsForm_Users);
            this.panelAssignTestsToUsers.Controls.Add(this.toolStrip8);
            this.panelAssignTestsToUsers.Controls.Add(this.dgvAssignTestsForm_Groups);
            this.panelAssignTestsToUsers.Controls.Add(this.label20);
            this.panelAssignTestsToUsers.Location = new System.Drawing.Point(492, 327);
            this.panelAssignTestsToUsers.Name = "panelAssignTestsToUsers";
            this.panelAssignTestsToUsers.Size = new System.Drawing.Size(200, 100);
            this.panelAssignTestsToUsers.TabIndex = 14;
            this.panelAssignTestsToUsers.Visible = false;
            this.panelAssignTestsToUsers.VisibleChanged += new System.EventHandler(this.panelAssignTestsToUsers_VisibleChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::TestServer.Properties.Resources.assign;
            this.pictureBox6.Location = new System.Drawing.Point(15, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 58;
            this.pictureBox6.TabStop = false;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(313, 323);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(80, 15);
            this.label32.TabIndex = 57;
            this.label32.Text = "Find by Login";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(18, 323);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(107, 15);
            this.label31.TabIndex = 56;
            this.label31.Text = "Find by Last name";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(566, 323);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(118, 15);
            this.label30.TabIndex = 55;
            this.label30.Text = "Find group by Name";
            // 
            // tbAssignTestsForm_FindGroupByName
            // 
            this.tbAssignTestsForm_FindGroupByName.Location = new System.Drawing.Point(688, 320);
            this.tbAssignTestsForm_FindGroupByName.Name = "tbAssignTestsForm_FindGroupByName";
            this.tbAssignTestsForm_FindGroupByName.Size = new System.Drawing.Size(150, 21);
            this.tbAssignTestsForm_FindGroupByName.TabIndex = 54;
            this.tbAssignTestsForm_FindGroupByName.TextChanged += new System.EventHandler(this.tbAssignTestsForm_FindGroupByName_TextChanged);
            // 
            // tbAssignTestsForm_FindUserByLastName
            // 
            this.tbAssignTestsForm_FindUserByLastName.Location = new System.Drawing.Point(129, 320);
            this.tbAssignTestsForm_FindUserByLastName.Name = "tbAssignTestsForm_FindUserByLastName";
            this.tbAssignTestsForm_FindUserByLastName.Size = new System.Drawing.Size(150, 21);
            this.tbAssignTestsForm_FindUserByLastName.TabIndex = 51;
            this.tbAssignTestsForm_FindUserByLastName.TextChanged += new System.EventHandler(this.tbAssignTestsForm_FindUserByLastName_TextChanged);
            // 
            // tbAssignTestsForm_FindUserByLogin
            // 
            this.tbAssignTestsForm_FindUserByLogin.Location = new System.Drawing.Point(399, 320);
            this.tbAssignTestsForm_FindUserByLogin.Name = "tbAssignTestsForm_FindUserByLogin";
            this.tbAssignTestsForm_FindUserByLogin.Size = new System.Drawing.Size(150, 21);
            this.tbAssignTestsForm_FindUserByLogin.TabIndex = 50;
            this.tbAssignTestsForm_FindUserByLogin.TextChanged += new System.EventHandler(this.tbAssignTestsForm_FindUserByLogin_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(16, 354);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(160, 15);
            this.label27.TabIndex = 49;
            this.label27.Text = "Assign tests to selected user";
            // 
            // toolStrip9
            // 
            this.toolStrip9.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip9.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip9.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAssignNewTestForGroup});
            this.toolStrip9.Location = new System.Drawing.Point(992, 39);
            this.toolStrip9.Name = "toolStrip9";
            this.toolStrip9.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip9.Size = new System.Drawing.Size(27, 27);
            this.toolStrip9.TabIndex = 48;
            this.toolStrip9.Text = "toolStrip9";
            // 
            // toolStripButtonAssignNewTestForGroup
            // 
            this.toolStripButtonAssignNewTestForGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAssignNewTestForGroup.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAssignNewTestForGroup.Image")));
            this.toolStripButtonAssignNewTestForGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAssignNewTestForGroup.Name = "toolStripButtonAssignNewTestForGroup";
            this.toolStripButtonAssignNewTestForGroup.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonAssignNewTestForGroup.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAssignNewTestForGroup.ToolTipText = "Assign new test for group";
            this.toolStripButtonAssignNewTestForGroup.Click += new System.EventHandler(this.toolStripButtonAssignNewTestForGroup_Click);
            // 
            // dgvAssignTestsForm_Tests
            // 
            this.dgvAssignTestsForm_Tests.AllowUserToAddRows = false;
            this.dgvAssignTestsForm_Tests.AllowUserToDeleteRows = false;
            this.dgvAssignTestsForm_Tests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignTestsForm_Tests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgvAssignTestsForm_Tests.Location = new System.Drawing.Point(19, 372);
            this.dgvAssignTestsForm_Tests.MultiSelect = false;
            this.dgvAssignTestsForm_Tests.Name = "dgvAssignTestsForm_Tests";
            this.dgvAssignTestsForm_Tests.ReadOnly = true;
            this.dgvAssignTestsForm_Tests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignTestsForm_Tests.Size = new System.Drawing.Size(1000, 220);
            this.dgvAssignTestsForm_Tests.TabIndex = 47;
            this.dgvAssignTestsForm_Tests.SelectionChanged += new System.EventHandler(this.dgvAssignTestsForm_Tests_SelectionChanged);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Id";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Title";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 260;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Author";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 170;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Desription";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 260;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Arhived";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 80;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Loaded date";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 120;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(16, 53);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(39, 15);
            this.label28.TabIndex = 44;
            this.label28.Text = "Users";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(566, 53);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(47, 15);
            this.label29.TabIndex = 43;
            this.label29.Text = "Groups";
            // 
            // dgvAssignTestsForm_Users
            // 
            this.dgvAssignTestsForm_Users.AllowUserToAddRows = false;
            this.dgvAssignTestsForm_Users.AllowUserToDeleteRows = false;
            this.dgvAssignTestsForm_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignTestsForm_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.Column5});
            this.dgvAssignTestsForm_Users.Location = new System.Drawing.Point(19, 69);
            this.dgvAssignTestsForm_Users.MultiSelect = false;
            this.dgvAssignTestsForm_Users.Name = "dgvAssignTestsForm_Users";
            this.dgvAssignTestsForm_Users.ReadOnly = true;
            this.dgvAssignTestsForm_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignTestsForm_Users.Size = new System.Drawing.Size(530, 245);
            this.dgvAssignTestsForm_Users.TabIndex = 42;
            this.dgvAssignTestsForm_Users.SelectionChanged += new System.EventHandler(this.dgvAssignTestsForm_Users_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "First name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Last name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Login";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Is admin";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // toolStrip8
            // 
            this.toolStrip8.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip8.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip8.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAssignNewTestForUser,
            this.toolStripButtonAssignNewTestByCopyForUser,
            this.toolStripSeparator10,
            this.toolStripButtonRemoveAssignedTestForUser});
            this.toolStrip8.Location = new System.Drawing.Point(936, 342);
            this.toolStrip8.Name = "toolStrip8";
            this.toolStrip8.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip8.Size = new System.Drawing.Size(83, 27);
            this.toolStrip8.TabIndex = 41;
            this.toolStrip8.Text = "toolStrip8";
            // 
            // toolStripButtonAssignNewTestForUser
            // 
            this.toolStripButtonAssignNewTestForUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAssignNewTestForUser.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAssignNewTestForUser.Image")));
            this.toolStripButtonAssignNewTestForUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAssignNewTestForUser.Name = "toolStripButtonAssignNewTestForUser";
            this.toolStripButtonAssignNewTestForUser.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonAssignNewTestForUser.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAssignNewTestForUser.ToolTipText = "Assign new test for user";
            this.toolStripButtonAssignNewTestForUser.Click += new System.EventHandler(this.toolStripButtonAssignNewTestForUser_Click);
            // 
            // toolStripButtonAssignNewTestByCopyForUser
            // 
            this.toolStripButtonAssignNewTestByCopyForUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAssignNewTestByCopyForUser.Enabled = false;
            this.toolStripButtonAssignNewTestByCopyForUser.Image = global::TestServer.Properties.Resources.add_by_copy;
            this.toolStripButtonAssignNewTestByCopyForUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAssignNewTestByCopyForUser.Name = "toolStripButtonAssignNewTestByCopyForUser";
            this.toolStripButtonAssignNewTestByCopyForUser.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonAssignNewTestByCopyForUser.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAssignNewTestByCopyForUser.Text = "toolStripButton1";
            this.toolStripButtonAssignNewTestByCopyForUser.ToolTipText = "Assign new test for User by copy";
            this.toolStripButtonAssignNewTestByCopyForUser.Click += new System.EventHandler(this.toolStripButtonAssignNewTestByCopyForUser_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonRemoveAssignedTestForUser
            // 
            this.toolStripButtonRemoveAssignedTestForUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemoveAssignedTestForUser.Enabled = false;
            this.toolStripButtonRemoveAssignedTestForUser.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRemoveAssignedTestForUser.Image")));
            this.toolStripButtonRemoveAssignedTestForUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveAssignedTestForUser.Name = "toolStripButtonRemoveAssignedTestForUser";
            this.toolStripButtonRemoveAssignedTestForUser.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonRemoveAssignedTestForUser.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonRemoveAssignedTestForUser.ToolTipText = "Remove assigned test for user";
            this.toolStripButtonRemoveAssignedTestForUser.Click += new System.EventHandler(this.toolStripButtonRemoveAssignedTestForUser_Click);
            // 
            // dgvAssignTestsForm_Groups
            // 
            this.dgvAssignTestsForm_Groups.AllowUserToAddRows = false;
            this.dgvAssignTestsForm_Groups.AllowUserToDeleteRows = false;
            this.dgvAssignTestsForm_Groups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignTestsForm_Groups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvAssignTestsForm_Groups.Location = new System.Drawing.Point(569, 69);
            this.dgvAssignTestsForm_Groups.MultiSelect = false;
            this.dgvAssignTestsForm_Groups.Name = "dgvAssignTestsForm_Groups";
            this.dgvAssignTestsForm_Groups.ReadOnly = true;
            this.dgvAssignTestsForm_Groups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignTestsForm_Groups.Size = new System.Drawing.Size(450, 245);
            this.dgvAssignTestsForm_Groups.TabIndex = 40;
            this.dgvAssignTestsForm_Groups.SelectionChanged += new System.EventHandler(this.dgvAssignTestsForm_Groups_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "GroupName";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 140;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Description";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(42, 5);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(169, 20);
            this.label20.TabIndex = 20;
            this.label20.Text = "Assign tests to user";
            this.label20.UseMnemonic = false;
            // 
            // panelReviewPassedTests
            // 
            this.panelReviewPassedTests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReviewPassedTests.Controls.Add(this.pictureBox7);
            this.panelReviewPassedTests.Controls.Add(this.label21);
            this.panelReviewPassedTests.Location = new System.Drawing.Point(732, 327);
            this.panelReviewPassedTests.Name = "panelReviewPassedTests";
            this.panelReviewPassedTests.Size = new System.Drawing.Size(200, 100);
            this.panelReviewPassedTests.TabIndex = 15;
            this.panelReviewPassedTests.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::TestServer.Properties.Resources.review;
            this.pictureBox7.Location = new System.Drawing.Point(15, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(42, 5);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(174, 20);
            this.label21.TabIndex = 21;
            this.label21.Text = "Review passed tests";
            this.label21.UseMnemonic = false;
            // 
            // panelTests
            // 
            this.panelTests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTests.Controls.Add(this.pictureBox8);
            this.panelTests.Controls.Add(this.label22);
            this.panelTests.Location = new System.Drawing.Point(254, 458);
            this.panelTests.Name = "panelTests";
            this.panelTests.Size = new System.Drawing.Size(200, 100);
            this.panelTests.TabIndex = 16;
            this.panelTests.Visible = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::TestServer.Properties.Resources.test;
            this.pictureBox8.Location = new System.Drawing.Point(15, 5);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(20, 20);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 25;
            this.pictureBox8.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(42, 5);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 20);
            this.label22.TabIndex = 22;
            this.label22.Text = "Tests";
            this.label22.UseMnemonic = false;
            // 
            // panelTestsExplorer
            // 
            this.panelTestsExplorer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTestsExplorer.Controls.Add(this.tbTestsExplorerForm_FindByAuthor);
            this.panelTestsExplorer.Controls.Add(this.pictureBox10);
            this.panelTestsExplorer.Controls.Add(this.label13);
            this.panelTestsExplorer.Controls.Add(this.tbTestsExplorerForm_FindById);
            this.panelTestsExplorer.Controls.Add(this.tbTestsExplorerForm_FindByTitle);
            this.panelTestsExplorer.Controls.Add(this.rbTestsExplorerForm_All);
            this.panelTestsExplorer.Controls.Add(this.rbTestsExplorerForm_Archived);
            this.panelTestsExplorer.Controls.Add(this.rbTestsExplorerForm_Actual);
            this.panelTestsExplorer.Controls.Add(this.toolStrip2);
            this.panelTestsExplorer.Controls.Add(this.dgvTestsExplorerForm_Tests);
            this.panelTestsExplorer.Controls.Add(this.label12);
            this.panelTestsExplorer.Location = new System.Drawing.Point(732, 458);
            this.panelTestsExplorer.Name = "panelTestsExplorer";
            this.panelTestsExplorer.Size = new System.Drawing.Size(200, 100);
            this.panelTestsExplorer.TabIndex = 18;
            this.panelTestsExplorer.Visible = false;
            this.panelTestsExplorer.VisibleChanged += new System.EventHandler(this.panelTestsExplorer_VisibleChanged);
            // 
            // tbTestsExplorerForm_FindByAuthor
            // 
            this.tbTestsExplorerForm_FindByAuthor.Location = new System.Drawing.Point(370, 569);
            this.tbTestsExplorerForm_FindByAuthor.Name = "tbTestsExplorerForm_FindByAuthor";
            this.tbTestsExplorerForm_FindByAuthor.Size = new System.Drawing.Size(170, 21);
            this.tbTestsExplorerForm_FindByAuthor.TabIndex = 74;
            this.tbTestsExplorerForm_FindByAuthor.TextChanged += new System.EventHandler(this.tbTestsExplorerForm_Find_TextChanged);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::TestServer.Properties.Resources.explorer;
            this.pictureBox10.Location = new System.Drawing.Point(15, 5);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(20, 20);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 73;
            this.pictureBox10.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 572);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 15);
            this.label13.TabIndex = 72;
            this.label13.Text = "Find";
            // 
            // tbTestsExplorerForm_FindById
            // 
            this.tbTestsExplorerForm_FindById.AccessibleDescription = "";
            this.tbTestsExplorerForm_FindById.Location = new System.Drawing.Point(60, 569);
            this.tbTestsExplorerForm_FindById.Name = "tbTestsExplorerForm_FindById";
            this.tbTestsExplorerForm_FindById.Size = new System.Drawing.Size(50, 21);
            this.tbTestsExplorerForm_FindById.TabIndex = 70;
            this.tbTestsExplorerForm_FindById.TextChanged += new System.EventHandler(this.tbTestsExplorerForm_Find_TextChanged);
            // 
            // tbTestsExplorerForm_FindByTitle
            // 
            this.tbTestsExplorerForm_FindByTitle.Location = new System.Drawing.Point(110, 569);
            this.tbTestsExplorerForm_FindByTitle.Name = "tbTestsExplorerForm_FindByTitle";
            this.tbTestsExplorerForm_FindByTitle.Size = new System.Drawing.Size(260, 21);
            this.tbTestsExplorerForm_FindByTitle.TabIndex = 69;
            this.tbTestsExplorerForm_FindByTitle.TextChanged += new System.EventHandler(this.tbTestsExplorerForm_Find_TextChanged);
            // 
            // rbTestsExplorerForm_All
            // 
            this.rbTestsExplorerForm_All.AutoSize = true;
            this.rbTestsExplorerForm_All.Location = new System.Drawing.Point(981, 33);
            this.rbTestsExplorerForm_All.Name = "rbTestsExplorerForm_All";
            this.rbTestsExplorerForm_All.Size = new System.Drawing.Size(38, 19);
            this.rbTestsExplorerForm_All.TabIndex = 66;
            this.rbTestsExplorerForm_All.Text = "All";
            this.rbTestsExplorerForm_All.UseVisualStyleBackColor = true;
            this.rbTestsExplorerForm_All.CheckedChanged += new System.EventHandler(this.TestsExplorerForm_RadioButtton_Click);
            // 
            // rbTestsExplorerForm_Archived
            // 
            this.rbTestsExplorerForm_Archived.AutoSize = true;
            this.rbTestsExplorerForm_Archived.Location = new System.Drawing.Point(877, 33);
            this.rbTestsExplorerForm_Archived.Name = "rbTestsExplorerForm_Archived";
            this.rbTestsExplorerForm_Archived.Size = new System.Drawing.Size(98, 19);
            this.rbTestsExplorerForm_Archived.TabIndex = 65;
            this.rbTestsExplorerForm_Archived.Text = "Only archived";
            this.rbTestsExplorerForm_Archived.UseVisualStyleBackColor = true;
            this.rbTestsExplorerForm_Archived.CheckedChanged += new System.EventHandler(this.TestsExplorerForm_RadioButtton_Click);
            // 
            // rbTestsExplorerForm_Actual
            // 
            this.rbTestsExplorerForm_Actual.AutoSize = true;
            this.rbTestsExplorerForm_Actual.Checked = true;
            this.rbTestsExplorerForm_Actual.Location = new System.Drawing.Point(786, 33);
            this.rbTestsExplorerForm_Actual.Name = "rbTestsExplorerForm_Actual";
            this.rbTestsExplorerForm_Actual.Size = new System.Drawing.Size(85, 19);
            this.rbTestsExplorerForm_Actual.TabIndex = 64;
            this.rbTestsExplorerForm_Actual.TabStop = true;
            this.rbTestsExplorerForm_Actual.Text = "Only actual";
            this.rbTestsExplorerForm_Actual.UseVisualStyleBackColor = true;
            this.rbTestsExplorerForm_Actual.CheckedChanged += new System.EventHandler(this.TestsExplorerForm_RadioButtton_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddTest,
            this.toolStripSeparator3,
            this.toolStripButtonTestLookup,
            this.toolStripSeparator2,
            this.toolStripButtonTestDelete});
            this.toolStrip2.Location = new System.Drawing.Point(19, 37);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(89, 27);
            this.toolStrip2.TabIndex = 63;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButtonAddTest
            // 
            this.toolStripButtonAddTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddTest.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddTest.Image")));
            this.toolStripButtonAddTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddTest.Name = "toolStripButtonAddTest";
            this.toolStripButtonAddTest.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonAddTest.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAddTest.ToolTipText = "Add new test";
            this.toolStripButtonAddTest.Click += new System.EventHandler(this.toolStripButtonAddTest_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonTestLookup
            // 
            this.toolStripButtonTestLookup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTestLookup.Enabled = false;
            this.toolStripButtonTestLookup.Image = global::TestServer.Properties.Resources.lookup;
            this.toolStripButtonTestLookup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTestLookup.Name = "toolStripButtonTestLookup";
            this.toolStripButtonTestLookup.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonTestLookup.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonTestLookup.ToolTipText = "Test lookup";
            this.toolStripButtonTestLookup.Click += new System.EventHandler(this.toolStripButtonTestLookup_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonTestDelete
            // 
            this.toolStripButtonTestDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTestDelete.Enabled = false;
            this.toolStripButtonTestDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTestDelete.Image")));
            this.toolStripButtonTestDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTestDelete.Name = "toolStripButtonTestDelete";
            this.toolStripButtonTestDelete.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonTestDelete.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonTestDelete.ToolTipText = "Delete selected test";
            this.toolStripButtonTestDelete.Click += new System.EventHandler(this.toolStripButtonTestDelete_Click);
            // 
            // dgvTestsExplorerForm_Tests
            // 
            this.dgvTestsExplorerForm_Tests.AllowUserToAddRows = false;
            this.dgvTestsExplorerForm_Tests.AllowUserToDeleteRows = false;
            this.dgvTestsExplorerForm_Tests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestsExplorerForm_Tests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17});
            this.dgvTestsExplorerForm_Tests.Location = new System.Drawing.Point(19, 67);
            this.dgvTestsExplorerForm_Tests.MultiSelect = false;
            this.dgvTestsExplorerForm_Tests.Name = "dgvTestsExplorerForm_Tests";
            this.dgvTestsExplorerForm_Tests.ReadOnly = true;
            this.dgvTestsExplorerForm_Tests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestsExplorerForm_Tests.Size = new System.Drawing.Size(1000, 496);
            this.dgvTestsExplorerForm_Tests.TabIndex = 62;
            this.dgvTestsExplorerForm_Tests.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTestsExplorerForm_Tests_CellDoubleClick);
            this.dgvTestsExplorerForm_Tests.SelectionChanged += new System.EventHandler(this.dgvTestsExplorerForm_Tests_SelectionChanged);
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Id";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 50;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Title";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 260;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Author";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 170;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Description";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 260;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Archived";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Width = 80;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Loaded date";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 120;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(42, 5);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Tests explorer";
            // 
            // panelLoadTest
            // 
            this.panelLoadTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLoadTest.Controls.Add(this.pictureBox9);
            this.panelLoadTest.Controls.Add(this.pictureBoxWarningDone);
            this.panelLoadTest.Controls.Add(this.btnLoadTestForm_Clean);
            this.panelLoadTest.Controls.Add(this.btnLoadTestForm_SaveTestToDB);
            this.panelLoadTest.Controls.Add(this.btnLoadTestForm_LoadTest);
            this.panelLoadTest.Controls.Add(this.label8);
            this.panelLoadTest.Controls.Add(this.groupBox2);
            this.panelLoadTest.Controls.Add(this.groupBox1);
            this.panelLoadTest.Location = new System.Drawing.Point(492, 458);
            this.panelLoadTest.Name = "panelLoadTest";
            this.panelLoadTest.Size = new System.Drawing.Size(200, 100);
            this.panelLoadTest.TabIndex = 17;
            this.panelLoadTest.Visible = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::TestServer.Properties.Resources.sand_clock;
            this.pictureBox9.Location = new System.Drawing.Point(15, 5);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(20, 20);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 25;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBoxWarningDone
            // 
            this.pictureBoxWarningDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWarningDone.Image = global::TestServer.Properties.Resources.warning;
            this.pictureBoxWarningDone.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxWarningDone.InitialImage")));
            this.pictureBoxWarningDone.Location = new System.Drawing.Point(837, 570);
            this.pictureBoxWarningDone.Name = "pictureBoxWarningDone";
            this.pictureBoxWarningDone.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxWarningDone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWarningDone.TabIndex = 6;
            this.pictureBoxWarningDone.TabStop = false;
            this.pictureBoxWarningDone.Visible = false;
            // 
            // btnLoadTestForm_Clean
            // 
            this.btnLoadTestForm_Clean.Location = new System.Drawing.Point(930, 16);
            this.btnLoadTestForm_Clean.Name = "btnLoadTestForm_Clean";
            this.btnLoadTestForm_Clean.Size = new System.Drawing.Size(90, 27);
            this.btnLoadTestForm_Clean.TabIndex = 20;
            this.btnLoadTestForm_Clean.Text = "Clean form";
            this.btnLoadTestForm_Clean.UseVisualStyleBackColor = true;
            this.btnLoadTestForm_Clean.Click += new System.EventHandler(this.btnLoadTestForm_Clean_Click);
            // 
            // btnLoadTestForm_SaveTestToDB
            // 
            this.btnLoadTestForm_SaveTestToDB.Enabled = false;
            this.btnLoadTestForm_SaveTestToDB.Location = new System.Drawing.Point(870, 570);
            this.btnLoadTestForm_SaveTestToDB.Name = "btnLoadTestForm_SaveTestToDB";
            this.btnLoadTestForm_SaveTestToDB.Size = new System.Drawing.Size(122, 27);
            this.btnLoadTestForm_SaveTestToDB.TabIndex = 19;
            this.btnLoadTestForm_SaveTestToDB.Text = "Save test to DB";
            this.btnLoadTestForm_SaveTestToDB.UseVisualStyleBackColor = true;
            this.btnLoadTestForm_SaveTestToDB.Click += new System.EventHandler(this.btnLoadTestForm_SaveTestToDB_Click);
            // 
            // btnLoadTestForm_LoadTest
            // 
            this.btnLoadTestForm_LoadTest.Location = new System.Drawing.Point(645, 570);
            this.btnLoadTestForm_LoadTest.Name = "btnLoadTestForm_LoadTest";
            this.btnLoadTestForm_LoadTest.Size = new System.Drawing.Size(122, 27);
            this.btnLoadTestForm_LoadTest.TabIndex = 18;
            this.btnLoadTestForm_LoadTest.Text = "Load test from file";
            this.btnLoadTestForm_LoadTest.UseVisualStyleBackColor = true;
            this.btnLoadTestForm_LoadTest.Click += new System.EventHandler(this.btnLoadTestForm_LoadTest_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(42, 5);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Load test";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvLoadTestForm_Answers);
            this.groupBox2.Controls.Add(this.pictureBox);
            this.groupBox2.Controls.Add(this.dgvLoadTestForm_Questions);
            this.groupBox2.Location = new System.Drawing.Point(329, 49);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(694, 500);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Questions";
            // 
            // dgvLoadTestForm_Answers
            // 
            this.dgvLoadTestForm_Answers.AllowUserToAddRows = false;
            this.dgvLoadTestForm_Answers.AllowUserToDeleteRows = false;
            this.dgvLoadTestForm_Answers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoadTestForm_Answers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Answer,
            this.IsRight});
            this.dgvLoadTestForm_Answers.Location = new System.Drawing.Point(226, 287);
            this.dgvLoadTestForm_Answers.MultiSelect = false;
            this.dgvLoadTestForm_Answers.Name = "dgvLoadTestForm_Answers";
            this.dgvLoadTestForm_Answers.ReadOnly = true;
            this.dgvLoadTestForm_Answers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoadTestForm_Answers.Size = new System.Drawing.Size(450, 196);
            this.dgvLoadTestForm_Answers.TabIndex = 5;
            // 
            // Answer
            // 
            this.Answer.HeaderText = "Answer";
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            this.Answer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Answer.Width = 300;
            // 
            // IsRight
            // 
            this.IsRight.HeaderText = "Is right";
            this.IsRight.Name = "IsRight";
            this.IsRight.ReadOnly = true;
            this.IsRight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IsRight.Width = 90;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = global::TestServer.Properties.Resources.nophoto;
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(16, 287);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(196, 196);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // dgvLoadTestForm_Questions
            // 
            this.dgvLoadTestForm_Questions.AllowUserToAddRows = false;
            this.dgvLoadTestForm_Questions.AllowUserToDeleteRows = false;
            this.dgvLoadTestForm_Questions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoadTestForm_Questions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Questions,
            this.Point});
            this.dgvLoadTestForm_Questions.Location = new System.Drawing.Point(16, 32);
            this.dgvLoadTestForm_Questions.MultiSelect = false;
            this.dgvLoadTestForm_Questions.Name = "dgvLoadTestForm_Questions";
            this.dgvLoadTestForm_Questions.ReadOnly = true;
            this.dgvLoadTestForm_Questions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoadTestForm_Questions.Size = new System.Drawing.Size(660, 242);
            this.dgvLoadTestForm_Questions.TabIndex = 3;
            this.dgvLoadTestForm_Questions.SelectionChanged += new System.EventHandler(this.dgvLoadTestForm_Questions_SelectionChanged);
            // 
            // Questions
            // 
            this.Questions.Frozen = true;
            this.Questions.HeaderText = "Question";
            this.Questions.Name = "Questions";
            this.Questions.ReadOnly = true;
            this.Questions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Questions.Width = 510;
            // 
            // Point
            // 
            this.Point.Frozen = true;
            this.Point.HeaderText = "Point";
            this.Point.Name = "Point";
            this.Point.ReadOnly = true;
            this.Point.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Point.Width = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTitle);
            this.groupBox1.Controls.Add(this.numericUpDownMinPass);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbMaxPointsForTest);
            this.groupBox1.Controls.Add(this.tbCountOfQuestions);
            this.groupBox1.Controls.Add(this.tbInfo);
            this.groupBox1.Controls.Add(this.tbDescription);
            this.groupBox1.Controls.Add(this.tbAuthor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(19, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(302, 500);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(89, 32);
            this.tbTitle.Multiline = true;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.ReadOnly = true;
            this.tbTitle.Size = new System.Drawing.Size(197, 50);
            this.tbTitle.TabIndex = 17;
            // 
            // numericUpDownMinPass
            // 
            this.numericUpDownMinPass.Location = new System.Drawing.Point(170, 462);
            this.numericUpDownMinPass.Name = "numericUpDownMinPass";
            this.numericUpDownMinPass.ReadOnly = true;
            this.numericUpDownMinPass.Size = new System.Drawing.Size(117, 21);
            this.numericUpDownMinPass.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 464);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Minimum passing percent";
            // 
            // tbMaxPointsForTest
            // 
            this.tbMaxPointsForTest.Location = new System.Drawing.Point(153, 434);
            this.tbMaxPointsForTest.Name = "tbMaxPointsForTest";
            this.tbMaxPointsForTest.ReadOnly = true;
            this.tbMaxPointsForTest.Size = new System.Drawing.Size(134, 21);
            this.tbMaxPointsForTest.TabIndex = 15;
            // 
            // tbCountOfQuestions
            // 
            this.tbCountOfQuestions.Location = new System.Drawing.Point(152, 407);
            this.tbCountOfQuestions.Name = "tbCountOfQuestions";
            this.tbCountOfQuestions.ReadOnly = true;
            this.tbCountOfQuestions.Size = new System.Drawing.Size(134, 21);
            this.tbCountOfQuestions.TabIndex = 14;
            // 
            // tbInfo
            // 
            this.tbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInfo.Location = new System.Drawing.Point(90, 261);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(197, 140);
            this.tbInfo.TabIndex = 13;
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDescription.Location = new System.Drawing.Point(89, 115);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(197, 140);
            this.tbDescription.TabIndex = 12;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(89, 88);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.ReadOnly = true;
            this.tbAuthor.Size = new System.Drawing.Size(197, 21);
            this.tbAuthor.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 437);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Maximum point for test";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 410);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Count of questions";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "Info for test taker";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 118);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 35);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Title";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 91);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Author";
            // 
            // toolStripButtonServer
            // 
            this.toolStripButtonServer.AutoSize = false;
            this.toolStripButtonServer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonServer.Image = global::TestServer.Properties.Resources.monitor;
            this.toolStripButtonServer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonServer.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripButtonServer.Name = "toolStripButtonServer";
            this.toolStripButtonServer.Size = new System.Drawing.Size(23, 24);
            this.toolStripButtonServer.ToolTipText = "Server";
            this.toolStripButtonServer.Click += new System.EventHandler(this.toolStripButtonMainForm_Click);
            // 
            // panelServer
            // 
            this.panelServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelServer.Controls.Add(this.pictureBox11);
            this.panelServer.Controls.Add(this.label14);
            this.panelServer.Location = new System.Drawing.Point(977, 458);
            this.panelServer.Name = "panelServer";
            this.panelServer.Size = new System.Drawing.Size(200, 100);
            this.panelServer.TabIndex = 24;
            this.panelServer.Visible = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::TestServer.Properties.Resources.monitor;
            this.pictureBox11.Location = new System.Drawing.Point(15, 5);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(20, 20);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 23;
            this.pictureBox11.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(42, 5);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "Server";
            this.label14.UseMnemonic = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 684);
            this.Controls.Add(this.panelServer);
            this.Controls.Add(this.panelTestsExplorer);
            this.Controls.Add(this.panelLoadTest);
            this.Controls.Add(this.panelTests);
            this.Controls.Add(this.panelReviewPassedTests);
            this.Controls.Add(this.panelAssignTestsToUsers);
            this.Controls.Add(this.panelUsersAndTests);
            this.Controls.Add(this.panelGroups);
            this.Controls.Add(this.panelUsersAndGroups);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.panelUsers);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelUsersAndGroups.ResumeLayout(false);
            this.panelUsersAndGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelUsers.ResumeLayout(false);
            this.panelUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.toolStrip5.ResumeLayout(false);
            this.toolStrip5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersForm_Users)).EndInit();
            this.panelGroups.ResumeLayout(false);
            this.panelGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.toolStrip7.ResumeLayout(false);
            this.toolStrip7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupsForm_Users)).EndInit();
            this.toolStrip6.ResumeLayout(false);
            this.toolStrip6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupsForm_Groups)).EndInit();
            this.panelUsersAndTests.ResumeLayout(false);
            this.panelUsersAndTests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panelAssignTestsToUsers.ResumeLayout(false);
            this.panelAssignTestsToUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.toolStrip9.ResumeLayout(false);
            this.toolStrip9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignTestsForm_Tests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignTestsForm_Users)).EndInit();
            this.toolStrip8.ResumeLayout(false);
            this.toolStrip8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignTestsForm_Groups)).EndInit();
            this.panelReviewPassedTests.ResumeLayout(false);
            this.panelReviewPassedTests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panelTests.ResumeLayout(false);
            this.panelTests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panelTestsExplorer.ResumeLayout(false);
            this.panelTestsExplorer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestsExplorerForm_Tests)).EndInit();
            this.panelLoadTest.ResumeLayout(false);
            this.panelLoadTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarningDone)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadTestForm_Answers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadTestForm_Questions)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLoadTestForm_Questions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLoadTestForm_Answers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTestsExplorerForm_Tests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsersForm_Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroupsForm_Groups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAssignTestsForm_Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAssignTestsForm_Groups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAssignTestsForm_Tests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroupsForm_Users)).EndInit();
            this.panelServer.ResumeLayout(false);
            this.panelServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Panel panelUsersAndGroups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.Panel panelGroups;
        private System.Windows.Forms.Panel panelUsersAndTests;
        private System.Windows.Forms.Panel panelAssignTestsToUsers;
        private System.Windows.Forms.Panel panelReviewPassedTests;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvUsersForm_Users;
        private System.Windows.Forms.BindingSource bsLoadTestForm_Questions;
        private System.Windows.Forms.Panel panelTests;
        private System.Windows.Forms.Panel panelTestsExplorer;
        private System.Windows.Forms.Panel panelLoadTest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvLoadTestForm_Answers;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridView dgvLoadTestForm_Questions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownMinPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMaxPointsForTest;
        private System.Windows.Forms.TextBox tbCountOfQuestions;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLoadTestForm_LoadTest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLoadTestForm_SaveTestToDB;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.OpenFileDialog openXmlFileDialog;
        private System.Windows.Forms.BindingSource bsLoadTestForm_Answers;
        private System.Windows.Forms.Button btnLoadTestForm_Clean;
        private System.Windows.Forms.PictureBox pictureBoxWarningDone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource bsTestsExplorerForm_Tests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.RadioButton rbByGroup;
        private System.Windows.Forms.ComboBox cbUsersFormGroup;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbArhived;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddUser;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddUserByCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteUser;
        private System.Windows.Forms.BindingSource bsUsersForm_Users;
        private System.Windows.Forms.ToolStrip toolStrip6;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddGroup;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddGroupByCopy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteGroup;
        private System.Windows.Forms.DataGridView dgvGroupsForm_Groups;
        private System.Windows.Forms.DataGridView dgvGroupsForm_Users;
        private System.Windows.Forms.ToolStrip toolStrip7;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddUserToGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveUserFromGroup;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tbGroups_FindByName;
        private System.Windows.Forms.BindingSource bsGroupsForm_Groups;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsAdminGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ToolStripMenuItem originalSizeToolStripMenuItem;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DataGridView dgvAssignTestsForm_Users;
        private System.Windows.Forms.ToolStrip toolStrip8;
        private System.Windows.Forms.ToolStripButton toolStripButtonAssignNewTestForUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveAssignedTestForUser;
        private System.Windows.Forms.DataGridView dgvAssignTestsForm_Groups;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ToolStrip toolStrip9;
        private System.Windows.Forms.ToolStripButton toolStripButtonAssignNewTestForGroup;
        private System.Windows.Forms.DataGridView dgvAssignTestsForm_Tests;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tbAssignTestsForm_FindGroupByName;
        private System.Windows.Forms.TextBox tbAssignTestsForm_FindUserByLastName;
        private System.Windows.Forms.TextBox tbAssignTestsForm_FindUserByLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource bsAssignTestsForm_Users;
        private System.Windows.Forms.BindingSource bsAssignTestsForm_Groups;
        private System.Windows.Forms.BindingSource bsAssignTestsForm_Tests;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.ToolStripButton toolStripButtonAssignNewTestByCopyForUser;
        private System.Windows.Forms.BindingSource bsGroupsForm_Users;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox tbUsersForm_FindByLastName;
        private System.Windows.Forms.TextBox tbUsersForm_FindByLogin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbTestsExplorerForm_FindById;
        private System.Windows.Forms.TextBox tbTestsExplorerForm_FindByTitle;
        private System.Windows.Forms.RadioButton rbTestsExplorerForm_All;
        private System.Windows.Forms.RadioButton rbTestsExplorerForm_Archived;
        private System.Windows.Forms.RadioButton rbTestsExplorerForm_Actual;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddTest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonTestLookup;
        private System.Windows.Forms.ToolStripButton toolStripButtonTestDelete;
        private System.Windows.Forms.DataGridView dgvTestsExplorerForm_Tests;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.TextBox tbTestsExplorerForm_FindByAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Questions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsRight;
        private System.Windows.Forms.ToolStripButton toolStripButtonGeneral;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsersAndGroups;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsers;
        private System.Windows.Forms.ToolStripButton toolStripButtonGroups;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButtonUsersAndTests;
        private System.Windows.Forms.ToolStripButton toolStripButtonAssignTestsToUsers;
        private System.Windows.Forms.ToolStripButton toolStripButtonReviewPassedTests;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton toolStripButtonTests;
        private System.Windows.Forms.ToolStripButton toolStripButtonTestsExplorer;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoadTest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripButton toolStripButtonServer;
        private System.Windows.Forms.Panel panelServer;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label14;
    }
}

