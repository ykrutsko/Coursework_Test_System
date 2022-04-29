using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestServer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripButtonUser_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.MdiParent = this;
            userForm.Show();
        }
    }
}
