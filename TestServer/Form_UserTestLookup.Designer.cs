namespace TestServer
{
    partial class UserTestLookupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserTestLookupForm));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelYesNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGotPoints = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.tbGotInPercent = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.tbWrong = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.tbCorrect = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbUnanswered = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.tbQuestions = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAnswers = new System.Windows.Forms.DataGridView();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.datagridViewQuestions = new System.Windows.Forms.DataGridView();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.bindingSourceQuestions = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceAnswers = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnswers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAnswers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelYesNo);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.tbGotPoints);
            this.groupBox4.Controls.Add(this.label46);
            this.groupBox4.Controls.Add(this.tbGotInPercent);
            this.groupBox4.Controls.Add(this.label45);
            this.groupBox4.Controls.Add(this.label40);
            this.groupBox4.Controls.Add(this.tbWrong);
            this.groupBox4.Controls.Add(this.label41);
            this.groupBox4.Controls.Add(this.tbCorrect);
            this.groupBox4.Controls.Add(this.label42);
            this.groupBox4.Controls.Add(this.tbDate);
            this.groupBox4.Controls.Add(this.tbUnanswered);
            this.groupBox4.Controls.Add(this.label43);
            this.groupBox4.Controls.Add(this.label44);
            this.groupBox4.Controls.Add(this.label39);
            this.groupBox4.Controls.Add(this.label38);
            this.groupBox4.Controls.Add(this.tbMin);
            this.groupBox4.Controls.Add(this.label37);
            this.groupBox4.Controls.Add(this.tbQuestions);
            this.groupBox4.Controls.Add(this.tbMax);
            this.groupBox4.Controls.Add(this.label36);
            this.groupBox4.Controls.Add(this.label35);
            this.groupBox4.Location = new System.Drawing.Point(795, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 467);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "INFO";
            // 
            // labelYesNo
            // 
            this.labelYesNo.AutoSize = true;
            this.labelYesNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYesNo.Location = new System.Drawing.Point(110, 376);
            this.labelYesNo.Name = "labelYesNo";
            this.labelYesNo.Size = new System.Drawing.Size(60, 15);
            this.labelYesNo.TabIndex = 71;
            this.labelYesNo.Text = "Yes / No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 70;
            this.label1.Text = "* - Unanswered = wrong answer";
            // 
            // tbGotPoints
            // 
            this.tbGotPoints.Location = new System.Drawing.Point(113, 319);
            this.tbGotPoints.Name = "tbGotPoints";
            this.tbGotPoints.ReadOnly = true;
            this.tbGotPoints.Size = new System.Drawing.Size(85, 21);
            this.tbGotPoints.TabIndex = 69;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(22, 376);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(48, 15);
            this.label46.TabIndex = 68;
            this.label46.Text = "Passed";
            // 
            // tbGotInPercent
            // 
            this.tbGotInPercent.Location = new System.Drawing.Point(113, 346);
            this.tbGotInPercent.Name = "tbGotInPercent";
            this.tbGotInPercent.ReadOnly = true;
            this.tbGotInPercent.Size = new System.Drawing.Size(85, 21);
            this.tbGotInPercent.TabIndex = 67;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(22, 349);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(53, 15);
            this.label45.TabIndex = 66;
            this.label45.Text = "Got in %";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label40.Location = new System.Drawing.Point(8, 187);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(54, 17);
            this.label40.TabIndex = 65;
            this.label40.Text = "Result";
            // 
            // tbWrong
            // 
            this.tbWrong.Location = new System.Drawing.Point(113, 292);
            this.tbWrong.Name = "tbWrong";
            this.tbWrong.ReadOnly = true;
            this.tbWrong.Size = new System.Drawing.Size(85, 21);
            this.tbWrong.TabIndex = 64;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(22, 322);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(75, 15);
            this.label41.TabIndex = 63;
            this.label41.Text = "Got in points";
            // 
            // tbCorrect
            // 
            this.tbCorrect.Location = new System.Drawing.Point(113, 265);
            this.tbCorrect.Name = "tbCorrect";
            this.tbCorrect.ReadOnly = true;
            this.tbCorrect.Size = new System.Drawing.Size(85, 21);
            this.tbCorrect.TabIndex = 62;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(22, 295);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(43, 15);
            this.label42.TabIndex = 61;
            this.label42.Text = "Wrong";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(61, 211);
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(137, 21);
            this.tbDate.TabIndex = 60;
            // 
            // tbUnanswered
            // 
            this.tbUnanswered.Location = new System.Drawing.Point(113, 238);
            this.tbUnanswered.Name = "tbUnanswered";
            this.tbUnanswered.ReadOnly = true;
            this.tbUnanswered.Size = new System.Drawing.Size(85, 21);
            this.tbUnanswered.TabIndex = 59;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(22, 268);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(46, 15);
            this.label43.TabIndex = 58;
            this.label43.Text = "Correct";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(22, 241);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(85, 15);
            this.label44.TabIndex = 57;
            this.label44.Text = "Unanswered *";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label39.Location = new System.Drawing.Point(8, 32);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(40, 17);
            this.label39.TabIndex = 56;
            this.label39.Text = "Test";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(22, 214);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(33, 15);
            this.label38.TabIndex = 54;
            this.label38.Text = "Date";
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(113, 110);
            this.tbMin.Name = "tbMin";
            this.tbMin.ReadOnly = true;
            this.tbMin.Size = new System.Drawing.Size(85, 21);
            this.tbMin.TabIndex = 53;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(22, 113);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(71, 15);
            this.label37.TabIndex = 52;
            this.label37.Text = "Min pass %";
            // 
            // tbQuestions
            // 
            this.tbQuestions.Location = new System.Drawing.Point(113, 56);
            this.tbQuestions.Name = "tbQuestions";
            this.tbQuestions.ReadOnly = true;
            this.tbQuestions.Size = new System.Drawing.Size(85, 21);
            this.tbQuestions.TabIndex = 51;
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(113, 83);
            this.tbMax.Name = "tbMax";
            this.tbMax.ReadOnly = true;
            this.tbMax.Size = new System.Drawing.Size(85, 21);
            this.tbMax.TabIndex = 50;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(22, 86);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(67, 15);
            this.label36.TabIndex = 49;
            this.label36.Text = "Max points";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(22, 59);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(62, 15);
            this.label35.TabIndex = 48;
            this.label35.Text = "Questions";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewAnswers);
            this.groupBox3.Controls.Add(this.pictureBox);
            this.groupBox3.Controls.Add(this.datagridViewQuestions);
            this.groupBox3.Location = new System.Drawing.Point(13, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(774, 500);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Questions";
            // 
            // dataGridViewAnswers
            // 
            this.dataGridViewAnswers.AllowUserToAddRows = false;
            this.dataGridViewAnswers.AllowUserToDeleteRows = false;
            this.dataGridViewAnswers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnswers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column19,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.Column20});
            this.dataGridViewAnswers.Location = new System.Drawing.Point(226, 287);
            this.dataGridViewAnswers.MultiSelect = false;
            this.dataGridViewAnswers.Name = "dataGridViewAnswers";
            this.dataGridViewAnswers.ReadOnly = true;
            this.dataGridViewAnswers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAnswers.Size = new System.Drawing.Size(530, 196);
            this.dataGridViewAnswers.TabIndex = 5;
            this.dataGridViewAnswers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAnswers_CellDoubleClick);
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Id";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Width = 50;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Answer text";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn8.Width = 240;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Right";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn9.Width = 90;
            // 
            // Column20
            // 
            this.Column20.HeaderText = "Answer";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Width = 90;
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
            // datagridViewQuestions
            // 
            this.datagridViewQuestions.AllowUserToAddRows = false;
            this.datagridViewQuestions.AllowUserToDeleteRows = false;
            this.datagridViewQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridViewQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column18,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.datagridViewQuestions.Location = new System.Drawing.Point(16, 32);
            this.datagridViewQuestions.MultiSelect = false;
            this.datagridViewQuestions.Name = "datagridViewQuestions";
            this.datagridViewQuestions.ReadOnly = true;
            this.datagridViewQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridViewQuestions.Size = new System.Drawing.Size(740, 242);
            this.datagridViewQuestions.TabIndex = 3;
            this.datagridViewQuestions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridViewQuestions_CellDoubleClick);
            this.datagridViewQuestions.SelectionChanged += new System.EventHandler(this.datagridViewQuestions_SelectionChanged);
            // 
            // Column18
            // 
            this.Column18.Frozen = true;
            this.Column18.HeaderText = "Id";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Width = 50;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.Frozen = true;
            this.dataGridViewTextBoxColumn10.HeaderText = "Question text";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn10.Width = 540;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.Frozen = true;
            this.dataGridViewTextBoxColumn11.HeaderText = "Point";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn11.Width = 90;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(925, 485);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 27);
            this.btnClose.TabIndex = 53;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // UserTestLookupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 526);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserTestLookupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.UserTestLookupForm_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnswers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAnswers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbGotPoints;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox tbGotInPercent;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox tbWrong;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox tbCorrect;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbUnanswered;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox tbQuestions;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewAnswers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridView datagridViewQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource bindingSourceQuestions;
        private System.Windows.Forms.BindingSource bindingSourceAnswers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelYesNo;
    }
}