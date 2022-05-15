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
using TextBoxHintLib;

namespace TestServer
{
    public partial class SelectUserForm : Form
    {
        OpenMode openMode;
        public User User { get; set; }
        public List<User> Users { get; set; }
        public SelectUserForm(List<User> users, OpenMode mode)
        {
            openMode = mode;
            Users = users;
            InitializeComponent();
        }
        private void SelectUserForm_Load(object sender, EventArgs e)
        {
            switch (openMode)
            {
                case OpenMode.NewUserForGroup:
                    this.Text = "Select new user for group";
                    break;
                case OpenMode.SelectUser:
                    this.Text = "Select taked tests user";
                    break;
            }
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
            dataGridView.Columns[6].HeaderText = "Admin";

            textBoxId.InitHint("Id...");
            textBoxFirstName.InitHint("First name...");
            textBoxLastName.InitHint("Last name...");
            textBoxLogin.InitHint("Login...");
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            User = dataGridView.CurrentRow.DataBoundItem as User;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!tb.Text.Any()) return;
            string columnName = string.Empty;
            switch (tb.Name)
            {
                case "textBoxId":
                    columnName = "Id";
                    break;
                case "textBoxFirstName":
                    columnName = "FirstName";
                    break;
                case "textBoxLastName":
                    columnName = "LastName";
                    break;
                case "textBoxLogin":
                    columnName = "Login";
                    break;
            }

            DataGridViewRow row = dataGridView.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells[columnName].Value == null ? false : r.Cells[columnName].Value.ToString().ToLower().StartsWith(tb.Text.ToLower()))
                .FirstOrDefault();

            if (row != null)
                dataGridView.CurrentCell = dataGridView.Rows[row.Index].Cells[0];
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
