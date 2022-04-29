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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGroup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonTest = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonResult = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 581);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1027, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(763, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.panel1.Size = new System.Drawing.Size(264, 581);
            this.panel1.TabIndex = 15;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 554);
            this.listBox1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 27);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server clients";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(760, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 581);
            this.splitter1.TabIndex = 16;
            this.splitter1.TabStop = false;
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonUser,
            this.toolStripButtonGroup,
            this.toolStripSeparator1,
            this.toolStripButtonTest,
            this.toolStripButtonResult});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 2, 1, 0);
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.Size = new System.Drawing.Size(760, 33);
            this.toolStrip.TabIndex = 18;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonUser
            // 
            this.toolStripButtonUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUser.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUser.Image")));
            this.toolStripButtonUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUser.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButtonUser.Name = "toolStripButtonUser";
            this.toolStripButtonUser.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonUser.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonUser.ToolTipText = "Users";
            // 
            // toolStripButtonGroup
            // 
            this.toolStripButtonGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGroup.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGroup.Image")));
            this.toolStripButtonGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGroup.Name = "toolStripButtonGroup";
            this.toolStripButtonGroup.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonGroup.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonGroup.Text = "toolStripButton2";
            this.toolStripButtonGroup.ToolTipText = "Groups";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButtonTest
            // 
            this.toolStripButtonTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTest.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTest.Image")));
            this.toolStripButtonTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTest.Name = "toolStripButtonTest";
            this.toolStripButtonTest.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonTest.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonTest.Text = "toolStripButton3";
            this.toolStripButtonTest.ToolTipText = "Tests";
            // 
            // toolStripButtonResult
            // 
            this.toolStripButtonResult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonResult.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonResult.Image")));
            this.toolStripButtonResult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonResult.Name = "toolStripButtonResult";
            this.toolStripButtonResult.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripButtonResult.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonResult.Text = "toolStripButton4";
            this.toolStripButtonResult.ToolTipText = "Test results";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 603);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonUser;
        private System.Windows.Forms.ToolStripButton toolStripButtonGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonTest;
        private System.Windows.Forms.ToolStripButton toolStripButtonResult;
    }
}

