namespace TestClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbWellcome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewNewTest = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCompletedTest = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbUser = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRadioDemo = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnCheckDemo = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbWait = new System.Windows.Forms.Label();
            this.bindingSourceNewTest = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceCompletedTest = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewTest)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompletedTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNewTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCompletedTest)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWellcome
            // 
            this.lbWellcome.AutoSize = true;
            this.lbWellcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWellcome.Location = new System.Drawing.Point(12, 9);
            this.lbWellcome.Name = "lbWellcome";
            this.lbWellcome.Size = new System.Drawing.Size(86, 20);
            this.lbWellcome.TabIndex = 0;
            this.lbWellcome.Text = "Wellcome";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewNewTest);
            this.groupBox1.Location = new System.Drawing.Point(11, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 191);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New tests for you";
            // 
            // dataGridViewNewTest
            // 
            this.dataGridViewNewTest.AllowUserToAddRows = false;
            this.dataGridViewNewTest.AllowUserToDeleteRows = false;
            this.dataGridViewNewTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNewTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column12,
            this.Column5,
            this.Column6});
            this.dataGridViewNewTest.Location = new System.Drawing.Point(6, 20);
            this.dataGridViewNewTest.MultiSelect = false;
            this.dataGridViewNewTest.Name = "dataGridViewNewTest";
            this.dataGridViewNewTest.ReadOnly = true;
            this.dataGridViewNewTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNewTest.Size = new System.Drawing.Size(850, 165);
            this.dataGridViewNewTest.TabIndex = 0;
            this.dataGridViewNewTest.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNewTest_CellDoubleClick);
            this.dataGridViewNewTest.SelectionChanged += new System.EventHandler(this.dataGridViewNewTest_SelectionChanged);
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
            this.Column2.HeaderText = "Title";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 240;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Info";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 250;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Questions";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Max points";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 90;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Pass %";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewCompletedTest);
            this.groupBox2.Location = new System.Drawing.Point(11, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(866, 270);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Completed tests";
            // 
            // dataGridViewCompletedTest
            // 
            this.dataGridViewCompletedTest.AllowUserToAddRows = false;
            this.dataGridViewCompletedTest.AllowUserToDeleteRows = false;
            this.dataGridViewCompletedTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompletedTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column13,
            this.Column10,
            this.Column11});
            this.dataGridViewCompletedTest.Location = new System.Drawing.Point(6, 20);
            this.dataGridViewCompletedTest.MultiSelect = false;
            this.dataGridViewCompletedTest.Name = "dataGridViewCompletedTest";
            this.dataGridViewCompletedTest.ReadOnly = true;
            this.dataGridViewCompletedTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCompletedTest.Size = new System.Drawing.Size(850, 244);
            this.dataGridViewCompletedTest.TabIndex = 1;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Id";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
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
            this.Column8.HeaderText = "Max points";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 90;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Scored points";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 110;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Scored %";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 90;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Passed";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 70;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Completed date";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 120;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUser.Location = new System.Drawing.Point(104, 9);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(184, 20);
            this.lbUser.TabIndex = 3;
            this.lbUser.Text = "[1] Yurii Krutsko (Giorgio)";
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(787, 253);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 27);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRadioDemo
            // 
            this.btnRadioDemo.Location = new System.Drawing.Point(17, 253);
            this.btnRadioDemo.Name = "btnRadioDemo";
            this.btnRadioDemo.Size = new System.Drawing.Size(220, 27);
            this.btnRadioDemo.TabIndex = 5;
            this.btnRadioDemo.Text = "Show one answer question demo";
            this.btnRadioDemo.UseVisualStyleBackColor = true;
            this.btnRadioDemo.Click += new System.EventHandler(this.btnRadioDemo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusStrip1.Location = new System.Drawing.Point(0, 584);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(889, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnCheckDemo
            // 
            this.btnCheckDemo.Location = new System.Drawing.Point(243, 253);
            this.btnCheckDemo.Name = "btnCheckDemo";
            this.btnCheckDemo.Size = new System.Drawing.Size(220, 27);
            this.btnCheckDemo.TabIndex = 8;
            this.btnCheckDemo.Text = "Show multi answers question demo";
            this.btnCheckDemo.UseVisualStyleBackColor = true;
            this.btnCheckDemo.Click += new System.EventHandler(this.btnCheckDemo_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Location = new System.Drawing.Point(787, 26);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 27);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lbWait
            // 
            this.lbWait.AutoSize = true;
            this.lbWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWait.ForeColor = System.Drawing.Color.Green;
            this.lbWait.Location = new System.Drawing.Point(726, 32);
            this.lbWait.Name = "lbWait";
            this.lbWait.Size = new System.Drawing.Size(55, 17);
            this.lbWait.TabIndex = 10;
            this.lbWait.Text = "Wait...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(889, 606);
            this.Controls.Add(this.lbWait);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCheckDemo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnRadioDemo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbWellcome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewTest)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompletedTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNewTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCompletedTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWellcome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewNewTest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewCompletedTest;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRadioDemo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnCheckDemo;
        private System.Windows.Forms.BindingSource bindingSourceNewTest;
        private System.Windows.Forms.BindingSource bindingSourceCompletedTest;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lbWait;
    }
}