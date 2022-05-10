using DALTestingSystemDB;
using SHA512Lib;
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
    public partial class UsersAddEditForm : Form
    {
        public List<string> LoginsCollection { get; set; }
        public User User { get; set; }
        OpenMode openMode;


        public UsersAddEditForm(OpenMode mode)
        {
            this.openMode = mode;
            User = new User();
            InitializeComponent();
        }

        public UsersAddEditForm(OpenMode mode, User user)
        {
            this.openMode = mode;
            User = user;
            InitializeComponent();
        }

        private async void UsersAddEditForm_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                LoginsCollection = Globals.repoUser.GetAll().Select(x => x.Login.ToLower()).ToList();
            });

            switch (openMode)
            {
                case OpenMode.Add:
                    pictureBoxPass.Visible = pictureBoxConfirm.Visible = true;
                    break;
                case OpenMode.AddByCopy:
                    pictureBoxPass.Visible = pictureBoxConfirm.Visible = true;
                    tbLogin.Text = User.Login;
                    tbFN.Text = User.FirstName;
                    tbLN.Text = User.LastName;
                    tbDescription.Text = User.Description;
                    cbIsAdmin.Checked = User.IsAdmin;
                    break;
                case OpenMode.Edit:
                    cbChangePass.Visible = true;
                    tbPass.Enabled = false;
                    tbConfirm.Enabled = false;                    
                    if (User.Id == 1)
                    {
                        cbIsAdmin.Visible = false;
                        lbSuperAdmin.Location = new Point(91, 271);
                        lbSuperAdmin.Visible = true;
                    }
                    else
                    {
                        cbIsArchive.Visible = true;
                        cbIsAdmin.Checked = User.IsAdmin;
                        cbIsArchive.Checked = User.IsArhived;
                    }
                    tbLogin.Text = User.Login;
                    tbFN.Text = User.FirstName;
                    tbLN.Text = User.LastName;
                    tbDescription.Text = User.Description;
                    break;
            }

            bindingSource.DataSource = User.Groups;
            dataGridView.DataSource = bindingSource;
            dataGridView.Columns[2].Visible = false;
            dataGridView.Columns[4].Visible = false;
            dataGridView.Columns[0].Width = 50;
            dataGridView.Columns[1].Width = 190;
            dataGridView.Columns[3].Width = 110;
            dataGridView.Columns[3].HeaderText = "Administrators";
            dataGridView.ClearSelection();
            WindowTitleText();
            tbLogin.Select();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            User.Login = tbLogin.Text;
            if(openMode != OpenMode.Edit || openMode == OpenMode.Edit && cbChangePass.Checked)
                User.Password = tbPass.Text.GetSha512();

            User.FirstName = tbFN.Text;
            User.LastName = tbLN.Text;
            User.Description = tbDescription.Text;
                
            if (User.Groups.Where(x => x.Id == 1).Any())
                User.IsAdmin = true;
            else
                User.IsAdmin = cbIsAdmin.Checked;

            if (openMode != OpenMode.Edit)
            {
                User.IsArhived = false;
                User.RegisterDate = DateTime.Now;
            }
            else
                User.IsArhived = cbIsArchive.Checked;
        }

        void WindowTitleText()
        {
            switch (openMode)
            {
                case OpenMode.Add:
                    this.Text = "New user [Add mode]";
                    break;
                case OpenMode.AddByCopy:
                    this.Text = "New user [Add by copy mode]";
                    break;
                case OpenMode.Edit:
                    this.Text = $"{User} [Edit mode]";
                    break;
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            toolStripButtonDeleteUserFromGroup.Enabled = dataGridView.SelectedRows.Count > 0
                && !(User.Id == 1 && (dataGridView.CurrentRow.DataBoundItem as DALTestingSystemDB.Group).Id == 1);
        }

        private async void toolStripButtonAddUserToGroup_Click(object sender, EventArgs e)
        {
            var newGroupsForUser = await Task.Run(() => Globals.repoGroup.GetAll().Except(User.Groups).ToList());
            if (!newGroupsForUser.Any())
            {
                MessageBox.Show("No new groups for user!", "Test server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } 
            NewGroupForUserForm newGroupForUserForm = new NewGroupForUserForm(newGroupsForUser);
            if (newGroupForUserForm.ShowDialog() == DialogResult.OK)
            {
                User.Groups.Add(newGroupForUserForm.Group);
                bindingSource.ResetBindings(false);
            }
        }

        private void toolStripButtonDeleteUserFromGroup_Click(object sender, EventArgs e)
        {
            DALTestingSystemDB.Group group = dataGridView.CurrentRow.DataBoundItem as DALTestingSystemDB.Group;
            User.Groups.Remove(group);
            bindingSource.ResetBindings(false);
        }

        private void cbChangePass_CheckedChanged(object sender, EventArgs e)
        {
            tbPass.Enabled = tbConfirm.Enabled = pictureBoxPass.Visible = pictureBoxConfirm.Visible = cbChangePass.Checked;
            EnableBtnOk();
            if(!cbChangePass.Checked)
            {
                tbPass.Text = tbConfirm.Text = String.Empty;
                pictureBoxPass.Image = pictureBoxConfirm.Image = Resources.warning;
            }
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
            pictureBoxLogin.Image = LoginOk() ? Resources.done : Resources.warning;
            EnableBtnOk();
        }
        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            pictureBoxPass.Image = PassOk() ? Resources.done : Resources.warning;
            EnableBtnOk();
        }

        private void tbConfirm_TextChanged(object sender, EventArgs e)
        {
            pictureBoxConfirm.Image = ConfirmOk() ? Resources.done : Resources.warning;
            EnableBtnOk();
        }

        bool PassOk()
        {
            if (openMode != OpenMode.Edit || cbChangePass.Checked)
                return tbPass.Text.Any();
            return true;
        }
        bool ConfirmOk()
        {
            if (openMode != OpenMode.Edit || cbChangePass.Checked)
                return tbConfirm.Text.Equals(tbPass.Text);
            return true;
        }

        bool LoginOk()
        {
            if (openMode != OpenMode.Edit)
                return tbLogin.Text.Any() && !LoginsCollection.Contains(tbLogin.Text.ToLower());
            return tbLogin.Text == User.Login || !LoginsCollection.Contains(tbLogin.Text.ToLower());
        }

        void EnableBtnOk()
        {
            btnOk.Enabled = LoginOk() && PassOk() && ConfirmOk();
        }
    }
}
