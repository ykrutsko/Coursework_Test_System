namespace TestDesigner
{
    partial class NewEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEditForm));
            this.dataGridViewAnswers = new System.Windows.Forms.DataGridView();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Right = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridViewQuestions = new System.Windows.Forms.DataGridView();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cbIsRight = new System.Windows.Forms.CheckBox();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancek = new System.Windows.Forms.Button();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnClearImg = new System.Windows.Forms.Button();
            this.btnLoadImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnswers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.dataGridViewAnswers.Location = new System.Drawing.Point(223, 315);
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
            this.pictureBox.Location = new System.Drawing.Point(13, 315);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(196, 196);
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
            this.dataGridViewQuestions.Location = new System.Drawing.Point(13, 12);
            this.dataGridViewQuestions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewQuestions.Name = "dataGridViewQuestions";
            this.dataGridViewQuestions.ReadOnly = true;
            this.dataGridViewQuestions.Size = new System.Drawing.Size(657, 220);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 238);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(545, 57);
            this.textBox1.TabIndex = 6;
            // 
            // btnQuestion
            // 
            this.btnQuestion.Location = new System.Drawing.Point(566, 268);
            this.btnQuestion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(105, 27);
            this.btnQuestion.TabIndex = 8;
            this.btnQuestion.Text = "Add";
            this.btnQuestion.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(223, 517);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(335, 57);
            this.textBox3.TabIndex = 9;
            // 
            // cbIsRight
            // 
            this.cbIsRight.AutoSize = true;
            this.cbIsRight.Location = new System.Drawing.Point(566, 519);
            this.cbIsRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbIsRight.Name = "cbIsRight";
            this.cbIsRight.Size = new System.Drawing.Size(62, 19);
            this.cbIsRight.TabIndex = 10;
            this.cbIsRight.Text = "Is right";
            this.cbIsRight.UseVisualStyleBackColor = true;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(565, 547);
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
            this.btnOk.Location = new System.Drawing.Point(441, 605);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(105, 27);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancek
            // 
            this.btnCancek.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancek.Location = new System.Drawing.Point(554, 605);
            this.btnCancek.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancek.Name = "btnCancek";
            this.btnCancek.Size = new System.Drawing.Size(105, 27);
            this.btnCancek.TabIndex = 13;
            this.btnCancek.Text = "Cancel";
            this.btnCancek.UseVisualStyleBackColor = true;
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Checked = true;
            this.rbAdd.Location = new System.Drawing.Point(13, 613);
            this.rbAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(81, 19);
            this.rbAdd.TabIndex = 16;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Add mode";
            this.rbAdd.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(105, 613);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 19);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.Text = "Edit mode";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(196, 613);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(96, 19);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.Text = "Delete mode";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(565, 239);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(104, 21);
            this.numericUpDown1.TabIndex = 25;
            // 
            // btnClearImg
            // 
            this.btnClearImg.Location = new System.Drawing.Point(115, 519);
            this.btnClearImg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClearImg.Name = "btnClearImg";
            this.btnClearImg.Size = new System.Drawing.Size(94, 27);
            this.btnClearImg.TabIndex = 12;
            this.btnClearImg.Text = "Clear image";
            this.btnClearImg.UseVisualStyleBackColor = true;
            // 
            // btnLoadImg
            // 
            this.btnLoadImg.Location = new System.Drawing.Point(13, 519);
            this.btnLoadImg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoadImg.Name = "btnLoadImg";
            this.btnLoadImg.Size = new System.Drawing.Size(94, 27);
            this.btnLoadImg.TabIndex = 13;
            this.btnLoadImg.Text = "Load image";
            this.btnLoadImg.UseVisualStyleBackColor = true;
            // 
            // NewEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 652);
            this.Controls.Add(this.dataGridViewQuestions);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnLoadImg);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnClearImg);
            this.Controls.Add(this.btnQuestion);
            this.Controls.Add(this.dataGridViewAnswers);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.rbAdd);
            this.Controls.Add(this.cbIsRight);
            this.Controls.Add(this.btnCancek);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NewEditForm";
            this.Text = "Edit test";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnswers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAnswers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Right;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridView dataGridViewQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox cbIsRight;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancek;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnClearImg;
        private System.Windows.Forms.Button btnLoadImg;
    }
}