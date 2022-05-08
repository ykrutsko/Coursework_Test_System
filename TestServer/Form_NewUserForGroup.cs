using DALTestingSystemDB;
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
    public partial class NewUserForGroupForm : Form
    {
        public User User { get; set; }
        public List<User> Users { get; set; }

        public NewUserForGroupForm(List<User> users)
        {
            Users = users;
            InitializeComponent();
        }
        private void NewUserForGroup_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = Users;
            dataGridView.DataSource = bindingSource;
            for (int i = 4; i <= 10; i++)
            {
                if (i == 6)
                    continue;
                dataGridView.Columns[i].Visible = false;
            }
            dataGridView.Columns[0].Width = 50;
            dataGridView.Columns[1].Width = 120;
            dataGridView.Columns[2].Width = 120;
            dataGridView.Columns[3].Width = 110;
            dataGridView.Columns[6].Width = 80;
            dataGridView.Columns[1].HeaderText = "First name";
            dataGridView.Columns[2].HeaderText = "Last name";
            dataGridView.Columns[6].HeaderText = "Is admin";
            dataGridView.ClearSelection();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = dataGridView.SelectedRows.Count > 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            User = dataGridView.CurrentRow.DataBoundItem as User;
        }

        private async void textBox_TextChanged(object sender, EventArgs e)
        {
            bindingSource.DataSource = textBox.Text.Any() ? 
                await Task.Run(() => Globals.repoUser.FindAll(x => x.Login.Contains(textBox.Text))) 
                : await Task.Run(() => Globals.repoUser.GetAll());
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnOK_Click(sender, e);
                this.DialogResult = DialogResult.OK;
            }
        }


    }
}
