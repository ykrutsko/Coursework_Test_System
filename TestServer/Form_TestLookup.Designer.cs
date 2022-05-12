namespace TestServer
{
    partial class TestLookupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestLookupForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Answers = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Right = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridView_Questions = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.bindingSourceQuestions = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceAnswers = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Answers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Questions)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAnswers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(819, 523);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 27);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Location = new System.Drawing.Point(723, 523);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 27);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_Answers);
            this.groupBox2.Controls.Add(this.pictureBox);
            this.groupBox2.Controls.Add(this.dataGridView_Questions);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(323, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(694, 500);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Questions";
            // 
            // dataGridView_Answers
            // 
            this.dataGridView_Answers.AllowUserToAddRows = false;
            this.dataGridView_Answers.AllowUserToDeleteRows = false;
            this.dataGridView_Answers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Answers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Answer,
            this.Right});
            this.dataGridView_Answers.Location = new System.Drawing.Point(226, 287);
            this.dataGridView_Answers.MultiSelect = false;
            this.dataGridView_Answers.Name = "dataGridView_Answers";
            this.dataGridView_Answers.ReadOnly = true;
            this.dataGridView_Answers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Answers.Size = new System.Drawing.Size(450, 196);
            this.dataGridView_Answers.TabIndex = 5;
            this.dataGridView_Answers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Answers_CellDoubleClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // Answer
            // 
            this.Answer.HeaderText = "Answer";
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            this.Answer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Answer.Width = 270;
            // 
            // Right
            // 
            this.Right.HeaderText = "Is right";
            this.Right.Name = "Right";
            this.Right.ReadOnly = true;
            this.Right.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Right.Width = 70;
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
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // dataGridView_Questions
            // 
            this.dataGridView_Questions.AllowUserToAddRows = false;
            this.dataGridView_Questions.AllowUserToDeleteRows = false;
            this.dataGridView_Questions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Questions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Questions,
            this.Point});
            this.dataGridView_Questions.Location = new System.Drawing.Point(16, 32);
            this.dataGridView_Questions.MultiSelect = false;
            this.dataGridView_Questions.Name = "dataGridView_Questions";
            this.dataGridView_Questions.ReadOnly = true;
            this.dataGridView_Questions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Questions.Size = new System.Drawing.Size(660, 242);
            this.dataGridView_Questions.TabIndex = 3;
            this.dataGridView_Questions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Questions_CellDoubleClick);
            this.dataGridView_Questions.SelectionChanged += new System.EventHandler(this.dataGridView_Questions_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Questions
            // 
            this.Questions.Frozen = true;
            this.Questions.HeaderText = "Question";
            this.Questions.Name = "Questions";
            this.Questions.ReadOnly = true;
            this.Questions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Questions.Width = 480;
            // 
            // Point
            // 
            this.Point.Frozen = true;
            this.Point.HeaderText = "Point";
            this.Point.Name = "Point";
            this.Point.ReadOnly = true;
            this.Point.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Point.Width = 70;
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
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
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
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox.Location = new System.Drawing.Point(649, 528);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(68, 19);
            this.checkBox.TabIndex = 20;
            this.checkBox.Text = "Archival";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // TestLookupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 566);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TestLookupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.TestLookupForm_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Answers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Questions)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAnswers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_Answers;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridView dataGridView_Questions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTitle;
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
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.BindingSource bindingSourceQuestions;
        private System.Windows.Forms.BindingSource bindingSourceAnswers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Right;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Questions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point;
    }
}