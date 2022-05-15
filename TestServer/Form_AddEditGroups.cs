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
using TestServer.Properties;

namespace TestServer
{
    public partial class GroupsAddEditForm : Form
    {
        public List<string> GroupsNameCollection { get; set; }
        public DALTestingSystemDB.Group Group { get; set; }
        OpenMode openMode;


        public GroupsAddEditForm(OpenMode mode)
        {
            this.openMode = mode;
            Group = new DALTestingSystemDB.Group();
            InitializeComponent();
        }

        public GroupsAddEditForm(OpenMode mode, DALTestingSystemDB.Group group)
        {
            this.openMode = mode;
            Group = group;
            InitializeComponent();
        }

        private async void Form_AddEditGroups_Load(object sender, EventArgs e)
        {
            GroupsNameCollection = await Task.Run(() => Globals.repoGroup.GetAll().Select(x => x.Name.ToLower()).ToList());

            switch (openMode)
            {
                case OpenMode.Add:
                    break;
                case OpenMode.AddByCopy:
                    tbName.Text = Group.Name;
                    tbDescription.Text = Group.Description;
                    break;
                case OpenMode.Edit:
                    if (Group.Id == 1)
                    {
                        lbSuperAdmin.Visible = true;
                    }
                    tbName.Text = Group.Name;
                    tbDescription.Text = Group.Description;
                    break;
            }
            dataGridView.Columns.Clear();
            bindingSource.DataSource = Group.Users;
            dataGridView.DataSource = bindingSource;
            for (int i = 4; i <= 10; i++)
                dataGridView.Columns[i].Visible = false;
            dataGridView.Columns[0].Width = 50;
            dataGridView.Columns[1].Width = 100;
            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[3].Width = 100;
            dataGridView.Columns[1].HeaderText = "First name";
            dataGridView.Columns[2].HeaderText = "Last name";

            WindowTitleText();
            tbName.Select();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            toolStripButtonDeleteUserFromGroup.Enabled = dataGridView.SelectedRows.Count > 0
                && !(Group.Id == 1 && (dataGridView.CurrentRow.DataBoundItem as User).Id == 1);
        }

        private async void toolStripButtonAddUserToGroup_Click(object sender, EventArgs e)
        {
            var newUsersForGroup = await Task.Run(() => Globals.repoUser.GetAll().Except(Group.Users).ToList());
            if (!newUsersForGroup.Any())
            {
                MessageBox.Show("No new Users for Group!", "Test server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SelectUserForm newGroupForUserForm = new SelectUserForm(newUsersForGroup, OpenMode.NewUserForGroup);
            if (newGroupForUserForm.ShowDialog() == DialogResult.OK)
            {
                Group.Users.Add(newGroupForUserForm.User);
                bindingSource.ResetBindings(false);
                bindingSource.MoveLast();
            }
        }

        private void toolStripButtonDeleteUserFromGroup_Click(object sender, EventArgs e)
        {
            User user = dataGridView.CurrentRow.DataBoundItem as User;
            Group.Users.Remove(user);
            bindingSource.ResetBindings(false);
        }

        void WindowTitleText()
        {
            switch (openMode)
            {
                case OpenMode.Add:
                    this.Text = "New group [Add mode]";
                    break;
                case OpenMode.AddByCopy:
                    this.Text = "New group [Add by copy mode]";
                    break;
                case OpenMode.Edit:
                    this.Text = $"{Group.Name} [Edit mode]";
                    break;
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            pictureBoxName.Image = NameOk() ? Resources.done : Resources.warning;
            EnableBtnOk();
        }

        bool NameOk()
        {
            if (openMode != OpenMode.Edit)
                return tbName.Text.Any() && !GroupsNameCollection.Contains(tbName.Text.ToLower());
            return tbName.Text.ToLower() == Group.Name.ToLower() || tbName.Text.Any() && !GroupsNameCollection.Contains(tbName.Text.ToLower());
        }

        void EnableBtnOk()
        {
            btnOk.Enabled = NameOk();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Group.Name = tbName.Text;
            Group.Description = tbDescription.Text;
            if(openMode == OpenMode.Edit && Group.Id == 1 && Group.Users.Count > 1)
                for (int i = 1; i < Group.Users.Count; i++)
                {
                    Group.Users.ElementAt(i).IsAdmin = true;
                }
        }
    }
}
