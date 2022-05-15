namespace TestServer
{
    partial class UsersAddEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersAddEditForm));
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddUserToGroup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDeleteUserFromGroup = new System.Windows.Forms.ToolStripButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbIsArchive = new System.Windows.Forms.CheckBox();
            this.cbIsAdmin = new System.Windows.Forms.CheckBox();
            this.tbLN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbConfirm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbChangePass = new System.Windows.Forms.CheckBox();
            this.lbSuperAdmin = new System.Windows.Forms.Label();
            this.pictureBoxPass = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.pictureBoxConfirm = new System.Windows.Forms.PictureBox();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip5
            // 
            this.toolStrip5.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddUserToGroup,
            this.toolStripSeparator4,
            this.toolStripButtonDeleteUserFromGroup});
            this.toolStrip5.Location = new System.Drawing.Point(338, 11);
            this.toolStrip5.Name = "toolStrip5";
            this.toolStrip5.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip5.Size = new System.Drawing.Size(59, 27);
            this.toolStrip5.TabIndex = 66;
            this.toolStrip5.Text = "toolStrip5";
            // 
            // toolStripButtonAddUserToGroup
            // 
            this.toolStripButtonAddUserToGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddUserToGroup.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddUserToGroup.Image")));
            this.toolStripButtonAddUserToGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddUserToGroup.Name = "toolStripButtonAddUserToGroup";
            this.toolStripButtonAddUserToGroup.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonAddUserToGroup.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAddUserToGroup.ToolTipText = "Add user to group";
            this.toolStripButtonAddUserToGroup.Click += new System.EventHandler(this.toolStripButtonAddUserToGroup_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonDeleteUserFromGroup
            // 
            this.toolStripButtonDeleteUserFromGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteUserFromGroup.Enabled = false;
            this.toolStripButtonDeleteUserFromGroup.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeleteUserFromGroup.Image")));
            this.toolStripButtonDeleteUserFromGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteUserFromGroup.Name = "toolStripButtonDeleteUserFromGroup";
            this.toolStripButtonDeleteUserFromGroup.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonDeleteUserFromGroup.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonDeleteUserFromGroup.ToolTipText = "Remove user from group";
            this.toolStripButtonDeleteUserFromGroup.Click += new System.EventHandler(this.toolStripButtonDeleteUserFromGroup_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(675, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 65;
            this.label6.Text = "User groups";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(658, 309);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 27);
            this.btnCancel.TabIndex = 64;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(560, 309);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 27);
            this.btnOk.TabIndex = 63;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbIsArchive
            // 
            this.cbIsArchive.AutoSize = true;
            this.cbIsArchive.Location = new System.Drawing.Point(484, 314);
            this.cbIsArchive.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbIsArchive.Name = "cbIsArchive";
            this.cbIsArchive.Size = new System.Drawing.Size(68, 19);
            this.cbIsArchive.TabIndex = 61;
            this.cbIsArchive.Text = "Аrchival";
            this.cbIsArchive.UseVisualStyleBackColor = true;
            this.cbIsArchive.Visible = false;
            // 
            // cbIsAdmin
            // 
            this.cbIsAdmin.AutoSize = true;
            this.cbIsAdmin.Location = new System.Drawing.Point(91, 271);
            this.cbIsAdmin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbIsAdmin.Name = "cbIsAdmin";
            this.cbIsAdmin.Size = new System.Drawing.Size(94, 19);
            this.cbIsAdmin.TabIndex = 60;
            this.cbIsAdmin.Text = "Administator";
            this.cbIsAdmin.UseVisualStyleBackColor = true;
            // 
            // tbLN
            // 
            this.tbLN.Location = new System.Drawing.Point(91, 197);
            this.tbLN.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbLN.Name = "tbLN";
            this.tbLN.Size = new System.Drawing.Size(228, 21);
            this.tbLN.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 58;
            this.label5.Text = "Last name";
            // 
            // tbFN
            // 
            this.tbFN.Location = new System.Drawing.Point(91, 170);
            this.tbFN.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbFN.Name = "tbFN";
            this.tbFN.Size = new System.Drawing.Size(228, 21);
            this.tbFN.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 56;
            this.label4.Text = "First name";
            // 
            // tbConfirm
            // 
            this.tbConfirm.Location = new System.Drawing.Point(91, 118);
            this.tbConfirm.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.PasswordChar = '*';
            this.tbConfirm.Size = new System.Drawing.Size(198, 21);
            this.tbConfirm.TabIndex = 55;
            this.tbConfirm.TextChanged += new System.EventHandler(this.tbConfirm_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 54;
            this.label3.Text = "Confirm *";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(91, 91);
            this.tbPass.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(198, 21);
            this.tbPass.TabIndex = 53;
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "Password *";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(91, 39);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(198, 21);
            this.tbLogin.TabIndex = 51;
            this.tbLogin.TextChanged += new System.EventHandler(this.tbLogin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Login *";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(338, 39);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(410, 251);
            this.dataGridView.TabIndex = 67;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(91, 224);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(228, 41);
            this.tbDescription.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 227);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 69;
            this.label7.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 15);
            this.label8.TabIndex = 71;
            this.label8.Text = "must be unique";
            // 
            // cbChangePass
            // 
            this.cbChangePass.AutoSize = true;
            this.cbChangePass.Location = new System.Drawing.Point(91, 66);
            this.cbChangePass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbChangePass.Name = "cbChangePass";
            this.cbChangePass.Size = new System.Drawing.Size(125, 19);
            this.cbChangePass.TabIndex = 73;
            this.cbChangePass.Text = "Change password";
            this.cbChangePass.UseVisualStyleBackColor = true;
            this.cbChangePass.Visible = false;
            this.cbChangePass.CheckedChanged += new System.EventHandler(this.cbChangePass_CheckedChanged);
            // 
            // lbSuperAdmin
            // 
            this.lbSuperAdmin.AutoSize = true;
            this.lbSuperAdmin.Location = new System.Drawing.Point(192, 272);
            this.lbSuperAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSuperAdmin.Name = "lbSuperAdmin";
            this.lbSuperAdmin.Size = new System.Drawing.Size(124, 15);
            this.lbSuperAdmin.TabIndex = 75;
            this.lbSuperAdmin.Text = "SUPER Administrator";
            this.lbSuperAdmin.Visible = false;
            // 
            // pictureBoxPass
            // 
            this.pictureBoxPass.Image = global::TestServer.Properties.Resources.warning;
            this.pictureBoxPass.Location = new System.Drawing.Point(298, 91);
            this.pictureBoxPass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxPass.Name = "pictureBoxPass";
            this.pictureBoxPass.Size = new System.Drawing.Size(21, 21);
            this.pictureBoxPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPass.TabIndex = 74;
            this.pictureBoxPass.TabStop = false;
            this.pictureBoxPass.Visible = false;
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Image = global::TestServer.Properties.Resources.warning;
            this.pictureBoxLogin.Location = new System.Drawing.Point(298, 39);
            this.pictureBoxLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(21, 21);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogin.TabIndex = 72;
            this.pictureBoxLogin.TabStop = false;
            // 
            // pictureBoxConfirm
            // 
            this.pictureBoxConfirm.Image = global::TestServer.Properties.Resources.warning;
            this.pictureBoxConfirm.Location = new System.Drawing.Point(298, 118);
            this.pictureBoxConfirm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxConfirm.Name = "pictureBoxConfirm";
            this.pictureBoxConfirm.Size = new System.Drawing.Size(21, 21);
            this.pictureBoxConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxConfirm.TabIndex = 70;
            this.pictureBoxConfirm.TabStop = false;
            this.pictureBoxConfirm.Visible = false;
            // 
            // UsersAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 356);
            this.Controls.Add(this.pictureBoxPass);
            this.Controls.Add(this.cbChangePass);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBoxConfirm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.toolStrip5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbIsArchive);
            this.Controls.Add(this.cbIsAdmin);
            this.Controls.Add(this.tbLN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbFN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSuperAdmin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "UsersAddEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.UsersAddEditForm_Load);
            this.toolStrip5.ResumeLayout(false);
            this.toolStrip5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddUserToGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteUserFromGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox cbIsArchive;
        private System.Windows.Forms.CheckBox cbIsAdmin;
        private System.Windows.Forms.TextBox tbLN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.PictureBox pictureBoxConfirm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.CheckBox cbChangePass;
        private System.Windows.Forms.PictureBox pictureBoxPass;
        private System.Windows.Forms.Label lbSuperAdmin;
    }
}