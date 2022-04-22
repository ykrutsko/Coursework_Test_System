namespace TestDesigner
{
    partial class ModifyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyForm));
            this.dataGridViewAnswers = new System.Windows.Forms.DataGridView();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Right = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridViewQuestions = new System.Windows.Forms.DataGridView();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.cbIsRight = new System.Windows.Forms.CheckBox();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.rbEdit = new System.Windows.Forms.RadioButton();
            this.rbDelete = new System.Windows.Forms.RadioButton();
            this.numericUpDownPoint = new System.Windows.Forms.NumericUpDown();
            this.btnClearImg = new System.Windows.Forms.Button();
            this.btnLoadImg = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownMinPass = new System.Windows.Forms.NumericUpDown();
            this.tbMaxPointsForTest = new System.Windows.Forms.TextBox();
            this.tbCountOfQuestions = new System.Windows.Forms.TextBox();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnswers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoint)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPass)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAnswers
            // 
            this.dataGridViewAnswers.AllowUserToAddRows = false;
            this.dataGridViewAnswers.AllowUserToDeleteRows = false;
            this.dataGridViewAnswers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnswers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Answer,
            this.Right});
            this.dataGridViewAnswers.Location = new System.Drawing.Point(321, 324);
            this.dataGridViewAnswers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewAnswers.Name = "dataGridViewAnswers";
            this.dataGridViewAnswers.ReadOnly = true;
            this.dataGridViewAnswers.Size = new System.Drawing.Size(447, 196);
            this.dataGridViewAnswers.TabIndex = 5;
            // 
            // Answer
            // 
            this.Answer.HeaderText = "Answer";
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            this.Answer.Width = 290;
            // 
            // Right
            // 
            this.Right.HeaderText = "Is right";
            this.Right.Name = "Right";
            this.Right.ReadOnly = true;
            this.Right.Width = 90;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = global::TestDesigner.Properties.Resources.nophoto;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(13, 12);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(300, 300);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // dataGridViewQuestions
            // 
            this.dataGridViewQuestions.AllowUserToAddRows = false;
            this.dataGridViewQuestions.AllowUserToDeleteRows = false;
            this.dataGridViewQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Question,
            this.Point});
            this.dataGridViewQuestions.Location = new System.Drawing.Point(321, 12);
            this.dataGridViewQuestions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewQuestions.Name = "dataGridViewQuestions";
            this.dataGridViewQuestions.ReadOnly = true;
            this.dataGridViewQuestions.Size = new System.Drawing.Size(657, 239);
            this.dataGridViewQuestions.TabIndex = 3;
            // 
            // Question
            // 
            this.Question.HeaderText = "Question";
            this.Question.Name = "Question";
            this.Question.ReadOnly = true;
            this.Question.Width = 500;
            // 
            // Point
            // 
            this.Point.HeaderText = "Point";
            this.Point.Name = "Point";
            this.Point.ReadOnly = true;
            this.Point.Width = 90;
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(321, 257);
            this.tbQuestion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(545, 55);
            this.tbQuestion.TabIndex = 6;
            // 
            // btnQuestion
            // 
            this.btnQuestion.Location = new System.Drawing.Point(874, 285);
            this.btnQuestion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(105, 27);
            this.btnQuestion.TabIndex = 8;
            this.btnQuestion.Text = "Add";
            this.btnQuestion.UseVisualStyleBackColor = true;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(321, 526);
            this.tbAnswer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbAnswer.Multiline = true;
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(335, 55);
            this.tbAnswer.TabIndex = 9;
            // 
            // cbIsRight
            // 
            this.cbIsRight.AutoSize = true;
            this.cbIsRight.Location = new System.Drawing.Point(664, 526);
            this.cbIsRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbIsRight.Name = "cbIsRight";
            this.cbIsRight.Size = new System.Drawing.Size(62, 19);
            this.cbIsRight.TabIndex = 10;
            this.cbIsRight.Text = "Is right";
            this.cbIsRight.UseVisualStyleBackColor = true;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(664, 554);
            this.btnAnswer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(105, 27);
            this.btnAnswer.TabIndex = 11;
            this.btnAnswer.Text = "Add";
            this.btnAnswer.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(879, 485);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(105, 27);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(879, 523);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 27);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Checked = true;
            this.rbAdd.Location = new System.Drawing.Point(24, 34);
            this.rbAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(81, 19);
            this.rbAdd.TabIndex = 16;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Add mode";
            this.rbAdd.UseVisualStyleBackColor = true;
            // 
            // rbEdit
            // 
            this.rbEdit.AutoSize = true;
            this.rbEdit.Location = new System.Drawing.Point(24, 67);
            this.rbEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbEdit.Name = "rbEdit";
            this.rbEdit.Size = new System.Drawing.Size(81, 19);
            this.rbEdit.TabIndex = 17;
            this.rbEdit.Text = "Edit mode";
            this.rbEdit.UseVisualStyleBackColor = true;
            // 
            // rbDelete
            // 
            this.rbDelete.AutoSize = true;
            this.rbDelete.Location = new System.Drawing.Point(24, 101);
            this.rbDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbDelete.Name = "rbDelete";
            this.rbDelete.Size = new System.Drawing.Size(96, 19);
            this.rbDelete.TabIndex = 18;
            this.rbDelete.Text = "Delete mode";
            this.rbDelete.UseVisualStyleBackColor = true;
            // 
            // numericUpDownPoint
            // 
            this.numericUpDownPoint.Location = new System.Drawing.Point(874, 257);
            this.numericUpDownPoint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownPoint.Name = "numericUpDownPoint";
            this.numericUpDownPoint.Size = new System.Drawing.Size(104, 21);
            this.numericUpDownPoint.TabIndex = 25;
            // 
            // btnClearImg
            // 
            this.btnClearImg.Location = new System.Drawing.Point(13, 318);
            this.btnClearImg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClearImg.Name = "btnClearImg";
            this.btnClearImg.Size = new System.Drawing.Size(145, 27);
            this.btnClearImg.TabIndex = 12;
            this.btnClearImg.Text = "Clear image";
            this.btnClearImg.UseVisualStyleBackColor = true;
            // 
            // btnLoadImg
            // 
            this.btnLoadImg.Location = new System.Drawing.Point(168, 318);
            this.btnLoadImg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoadImg.Name = "btnLoadImg";
            this.btnLoadImg.Size = new System.Drawing.Size(145, 27);
            this.btnLoadImg.TabIndex = 13;
            this.btnLoadImg.Text = "Load image";
            this.btnLoadImg.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAdd);
            this.groupBox1.Controls.Add(this.rbEdit);
            this.groupBox1.Controls.Add(this.rbDelete);
            this.groupBox1.Location = new System.Drawing.Point(775, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 134);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operating mode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.numericUpDownMinPass);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbMaxPointsForTest);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbCountOfQuestions);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbInfo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbAuthor);
            this.groupBox2.Controls.Add(this.tbDescription);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 229);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test info";
            // 
            // numericUpDownMinPass
            // 
            this.numericUpDownMinPass.Location = new System.Drawing.Point(166, 196);
            this.numericUpDownMinPass.Name = "numericUpDownMinPass";
            this.numericUpDownMinPass.ReadOnly = true;
            this.numericUpDownMinPass.Size = new System.Drawing.Size(117, 21);
            this.numericUpDownMinPass.TabIndex = 41;
            // 
            // tbMaxPointsForTest
            // 
            this.tbMaxPointsForTest.Location = new System.Drawing.Point(149, 165);
            this.tbMaxPointsForTest.Name = "tbMaxPointsForTest";
            this.tbMaxPointsForTest.ReadOnly = true;
            this.tbMaxPointsForTest.Size = new System.Drawing.Size(135, 21);
            this.tbMaxPointsForTest.TabIndex = 40;
            // 
            // tbCountOfQuestions
            // 
            this.tbCountOfQuestions.Location = new System.Drawing.Point(149, 135);
            this.tbCountOfQuestions.Name = "tbCountOfQuestions";
            this.tbCountOfQuestions.ReadOnly = true;
            this.tbCountOfQuestions.Size = new System.Drawing.Size(134, 21);
            this.tbCountOfQuestions.TabIndex = 39;
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(85, 100);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.Size = new System.Drawing.Size(198, 21);
            this.tbInfo.TabIndex = 38;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(85, 73);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(198, 21);
            this.tbDescription.TabIndex = 37;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(86, 46);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.ReadOnly = true;
            this.tbAuthor.Size = new System.Drawing.Size(197, 21);
            this.tbAuthor.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 198);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "Minimum passing percent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 168);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Maximum point for test";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Count of questions";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 39);
            this.label4.TabIndex = 31;
            this.label4.Text = "Info for test taker";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Author";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(197, 21);
            this.textBox1.TabIndex = 42;
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 599);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewQuestions);
            this.Controls.Add(this.numericUpDownPoint);
            this.Controls.Add(this.btnLoadImg);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.btnClearImg);
            this.Controls.Add(this.btnQuestion);
            this.Controls.Add(this.dataGridViewAnswers);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.cbIsRight);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ModifyForm";
            this.Text = "Edit test";
            this.Load += new System.EventHandler(this.ModifyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnswers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoint)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAnswers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Right;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridView dataGridViewQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.CheckBox cbIsRight;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.RadioButton rbEdit;
        private System.Windows.Forms.RadioButton rbDelete;
        private System.Windows.Forms.NumericUpDown numericUpDownPoint;
        private System.Windows.Forms.Button btnClearImg;
        private System.Windows.Forms.Button btnLoadImg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownMinPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMaxPointsForTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCountOfQuestions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}