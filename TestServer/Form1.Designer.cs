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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Users", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Groups", 2, 2);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Users & Groups", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Assign tests to users");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Review passed tests");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Users & Tests", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Load test");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Tests explorer");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Tests", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Reports");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Server");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelInit = new System.Windows.Forms.Panel();
            this.panelUsersAndGroups = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.panelGroups = new System.Windows.Forms.Panel();
            this.panelUsersAndTests = new System.Windows.Forms.Panel();
            this.panelAssignTestsToUsers = new System.Windows.Forms.Panel();
            this.panelReviewPasseTests = new System.Windows.Forms.Panel();
            this.panelTests = new System.Windows.Forms.Panel();
            this.panelTestsExplorer = new System.Windows.Forms.Panel();
            this.panelLoadTest = new System.Windows.Forms.Panel();
            this.btnLoadTestForm_Clean = new System.Windows.Forms.Button();
            this.btnLoadTestForm_SaveTestToDB = new System.Windows.Forms.Button();
            this.btnLoadTestForm_LoadTest = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvLoadTestForm_Answers = new System.Windows.Forms.DataGridView();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Right = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pictureBoxWarningDone = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.bsLoadTestForm_Questions = new System.Windows.Forms.BindingSource(this.components);
            this.bsLoadTestForm_Answers = new System.Windows.Forms.BindingSource(this.components);
            this.panelUsersAndGroups.SuspendLayout();
            this.panelUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.panelLoadTest.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadTestForm_Answers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadTestForm_Questions)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarningDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLoadTestForm_Questions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLoadTestForm_Answers)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 666);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1261, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1261, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1261, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 49);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "NodeUsers";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Users";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "NodeGroups";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Text = "Groups";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "NodeUsersAndGroups";
            treeNode3.SelectedImageIndex = 0;
            treeNode3.Text = "Users & Groups";
            treeNode4.Name = "NodeAssignTestsToUsers";
            treeNode4.Text = "Assign tests to users";
            treeNode5.Name = "NodeReviwPassedTests";
            treeNode5.Text = "Review passed tests";
            treeNode6.Name = "NodeUsersAndTests";
            treeNode6.Text = "Users & Tests";
            treeNode7.Name = "NodeLoadTest";
            treeNode7.Text = "Load test";
            treeNode8.Name = "NodeTestsExplorer";
            treeNode8.Text = "Tests explorer";
            treeNode9.Name = "NodeTests";
            treeNode9.Text = "Tests";
            treeNode10.Name = "NodeReports";
            treeNode10.Text = "Reports";
            treeNode11.Name = "NodeServer";
            treeNode11.Text = "Server";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9,
            treeNode10,
            treeNode11});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(214, 617);
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
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(214, 49);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 617);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // panelInit
            // 
            this.panelInit.Location = new System.Drawing.Point(254, 77);
            this.panelInit.Name = "panelInit";
            this.panelInit.Size = new System.Drawing.Size(200, 100);
            this.panelInit.TabIndex = 9;
            this.panelInit.Visible = false;
            // 
            // panelUsersAndGroups
            // 
            this.panelUsersAndGroups.Controls.Add(this.label3);
            this.panelUsersAndGroups.Controls.Add(this.label2);
            this.panelUsersAndGroups.Controls.Add(this.label1);
            this.panelUsersAndGroups.Location = new System.Drawing.Point(254, 197);
            this.panelUsersAndGroups.Name = "panelUsersAndGroups";
            this.panelUsersAndGroups.Size = new System.Drawing.Size(200, 97);
            this.panelUsersAndGroups.TabIndex = 10;
            this.panelUsersAndGroups.Visible = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users & Groups";
            this.label1.UseMnemonic = false;
            // 
            // panelUsers
            // 
            this.panelUsers.Controls.Add(this.dataGridViewUsers);
            this.panelUsers.Location = new System.Drawing.Point(492, 194);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(200, 100);
            this.panelUsers.TabIndex = 11;
            this.panelUsers.Visible = false;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(123, 96);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(369, 150);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // panelGroups
            // 
            this.panelGroups.Location = new System.Drawing.Point(732, 194);
            this.panelGroups.Name = "panelGroups";
            this.panelGroups.Size = new System.Drawing.Size(200, 100);
            this.panelGroups.TabIndex = 12;
            this.panelGroups.Visible = false;
            // 
            // panelUsersAndTests
            // 
            this.panelUsersAndTests.Location = new System.Drawing.Point(254, 327);
            this.panelUsersAndTests.Name = "panelUsersAndTests";
            this.panelUsersAndTests.Size = new System.Drawing.Size(200, 100);
            this.panelUsersAndTests.TabIndex = 13;
            this.panelUsersAndTests.Visible = false;
            // 
            // panelAssignTestsToUsers
            // 
            this.panelAssignTestsToUsers.Location = new System.Drawing.Point(492, 327);
            this.panelAssignTestsToUsers.Name = "panelAssignTestsToUsers";
            this.panelAssignTestsToUsers.Size = new System.Drawing.Size(200, 100);
            this.panelAssignTestsToUsers.TabIndex = 14;
            this.panelAssignTestsToUsers.Visible = false;
            // 
            // panelReviewPasseTests
            // 
            this.panelReviewPasseTests.Location = new System.Drawing.Point(732, 327);
            this.panelReviewPasseTests.Name = "panelReviewPasseTests";
            this.panelReviewPasseTests.Size = new System.Drawing.Size(200, 100);
            this.panelReviewPasseTests.TabIndex = 15;
            this.panelReviewPasseTests.Visible = false;
            // 
            // panelTests
            // 
            this.panelTests.Location = new System.Drawing.Point(254, 458);
            this.panelTests.Name = "panelTests";
            this.panelTests.Size = new System.Drawing.Size(200, 100);
            this.panelTests.TabIndex = 16;
            // 
            // panelTestsExplorer
            // 
            this.panelTestsExplorer.Location = new System.Drawing.Point(732, 458);
            this.panelTestsExplorer.Name = "panelTestsExplorer";
            this.panelTestsExplorer.Size = new System.Drawing.Size(200, 100);
            this.panelTestsExplorer.TabIndex = 18;
            // 
            // panelLoadTest
            // 
            this.panelLoadTest.Controls.Add(this.pictureBoxWarningDone);
            this.panelLoadTest.Controls.Add(this.btnLoadTestForm_Clean);
            this.panelLoadTest.Controls.Add(this.btnLoadTestForm_SaveTestToDB);
            this.panelLoadTest.Controls.Add(this.btnLoadTestForm_LoadTest);
            this.panelLoadTest.Controls.Add(this.label8);
            this.panelLoadTest.Controls.Add(this.groupBox2);
            this.panelLoadTest.Controls.Add(this.groupBox1);
            this.panelLoadTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoadTest.Location = new System.Drawing.Point(217, 49);
            this.panelLoadTest.Name = "panelLoadTest";
            this.panelLoadTest.Size = new System.Drawing.Size(1044, 617);
            this.panelLoadTest.TabIndex = 17;
            // 
            // btnLoadTestForm_Clean
            // 
            this.btnLoadTestForm_Clean.Location = new System.Drawing.Point(688, 17);
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
            this.btnLoadTestForm_SaveTestToDB.Location = new System.Drawing.Point(903, 17);
            this.btnLoadTestForm_SaveTestToDB.Name = "btnLoadTestForm_SaveTestToDB";
            this.btnLoadTestForm_SaveTestToDB.Size = new System.Drawing.Size(122, 27);
            this.btnLoadTestForm_SaveTestToDB.TabIndex = 19;
            this.btnLoadTestForm_SaveTestToDB.Text = "Save test to DB";
            this.btnLoadTestForm_SaveTestToDB.UseVisualStyleBackColor = true;
            this.btnLoadTestForm_SaveTestToDB.Click += new System.EventHandler(this.btnLoadTestForm_SaveTestToDB_Click);
            // 
            // btnLoadTestForm_LoadTest
            // 
            this.btnLoadTestForm_LoadTest.Location = new System.Drawing.Point(560, 17);
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
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(15, 15);
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
            this.groupBox2.Location = new System.Drawing.Point(334, 50);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(691, 500);
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
            this.Right});
            this.dgvLoadTestForm_Answers.Location = new System.Drawing.Point(226, 287);
            this.dgvLoadTestForm_Answers.MultiSelect = false;
            this.dgvLoadTestForm_Answers.Name = "dgvLoadTestForm_Answers";
            this.dgvLoadTestForm_Answers.ReadOnly = true;
            this.dgvLoadTestForm_Answers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoadTestForm_Answers.Size = new System.Drawing.Size(447, 196);
            this.dgvLoadTestForm_Answers.TabIndex = 5;
            // 
            // Answer
            // 
            this.Answer.HeaderText = "Answer";
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            this.Answer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Answer.Width = 290;
            // 
            // Right
            // 
            this.Right.HeaderText = "Is right";
            this.Right.Name = "Right";
            this.Right.ReadOnly = true;
            this.Right.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Right.Width = 90;
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
            this.dgvLoadTestForm_Questions.Size = new System.Drawing.Size(657, 242);
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
            this.Questions.Width = 500;
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
            this.groupBox1.Location = new System.Drawing.Point(19, 50);
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
            // pictureBoxWarningDone
            // 
            this.pictureBoxWarningDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWarningDone.Image = global::TestServer.Properties.Resources.warning;
            this.pictureBoxWarningDone.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxWarningDone.InitialImage")));
            this.pictureBoxWarningDone.Location = new System.Drawing.Point(870, 17);
            this.pictureBoxWarningDone.Name = "pictureBoxWarningDone";
            this.pictureBoxWarningDone.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxWarningDone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWarningDone.TabIndex = 6;
            this.pictureBoxWarningDone.TabStop = false;
            this.pictureBoxWarningDone.Visible = false;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 688);
            this.Controls.Add(this.panelLoadTest);
            this.Controls.Add(this.panelTestsExplorer);
            this.Controls.Add(this.panelTests);
            this.Controls.Add(this.panelUsers);
            this.Controls.Add(this.panelUsersAndGroups);
            this.Controls.Add(this.panelReviewPasseTests);
            this.Controls.Add(this.panelAssignTestsToUsers);
            this.Controls.Add(this.panelUsersAndTests);
            this.Controls.Add(this.panelGroups);
            this.Controls.Add(this.panelInit);
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
            this.panelUsersAndGroups.ResumeLayout(false);
            this.panelUsersAndGroups.PerformLayout();
            this.panelUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.panelLoadTest.ResumeLayout(false);
            this.panelLoadTest.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadTestForm_Answers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadTestForm_Questions)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarningDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLoadTestForm_Questions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLoadTestForm_Answers)).EndInit();
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
        private System.Windows.Forms.Panel panelInit;
        private System.Windows.Forms.Panel panelUsersAndGroups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelUsers;
        private System.Windows.Forms.Panel panelGroups;
        private System.Windows.Forms.Panel panelUsersAndTests;
        private System.Windows.Forms.Panel panelAssignTestsToUsers;
        private System.Windows.Forms.Panel panelReviewPasseTests;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Questions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Right;
        private System.Windows.Forms.PictureBox pictureBoxWarningDone;
    }
}

