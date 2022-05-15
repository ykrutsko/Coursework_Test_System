﻿using DALTestingSystemDB;
using RepositoryLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLib;
using TestServer.Properties;
using TextBoxHintLib;


namespace TestServer
{
    public partial class MainForm : Form
    {
        Panel activePanel;
        bool firstTimeUsers = true;
        bool firstTimeGroups = true;
        bool firstTimeAssignTests = true;
        bool firstTimeTestsExplorer = true;
        bool firstTimeReviewPassedTests = true;

        #region Main
        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            activePanel = panelGeneral;
            await Task.Run(() => 
            {
                Globals.repoGroup = Globals.work.Repository<Group>();
                Globals.repoTest = Globals.work.Repository<DALTestingSystemDB.Test>();
                Globals.repoQuestion = Globals.work.Repository<DALTestingSystemDB.Question>();
                Globals.repoAnswer = Globals.work.Repository<DALTestingSystemDB.Answer>();
                Globals.repoUserTest = Globals.work.Repository<UserTest>();
                Globals.repoUserAnswer = Globals.work.Repository<UserAnswer>();

            });

            // DataGridView Sources
            dgvLoadTestForm_Questions.DataSource = bsLoadTestForm_Questions;
            dgvLoadTestForm_Answers.DataSource = bsLoadTestForm_Answers;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            e.Node.Tag = this.treeView1.SelectedNode.Name;
            activePanel.Visible = false;
            switch (e.Node.Tag)
            {
                case "NodeGeneral":
                    activePanel = panelGeneral;
                    break;
                case "NodeUsersAndGroups":
                    activePanel = panelUsersAndGroups;
                    break;
                case "NodeUsers":
                    activePanel = panelUsers;
                    break;
                case "NodeGroups":
                    activePanel = panelGroups;
                    break;
                case "NodeUsersAndTests":
                    activePanel = panelUsersAndTests;
                    break;
                case "NodeAssignTestsToUsers":
                    activePanel = panelAssignTestsToUsers;
                    break;
                case "NodeReviewTestResults":
                    activePanel = panelReviewTestResults;
                    break;
                case "NodeTests":
                    activePanel = panelTests;
                    break;
                case "NodeTestsExplorer":
                    activePanel = panelTestsExplorer;
                    break;
                case "NodeLoadTest":                    
                    activePanel = panelLoadTest;
                    break;
                case "NodeServer":
                    activePanel = panelServer;
                    break;
            }
            activePanel.Dock = DockStyle.Fill;
            activePanel.Visible = true;
        }

        private void toolStripButtonMainForm_Click(object sender, EventArgs e)
        {
            ToolStripButton tsb = sender as ToolStripButton;
            string nodeName = string.Empty;
            switch(tsb.Name)
            {
                case "toolStripButtonGeneral":
                    nodeName = "NodeGeneral";
                    break;
                case "toolStripButtonUsersAndGroups":
                    nodeName = "NodeUsersAndGroups";
                    break;
                case "toolStripButtonUsers":
                    nodeName = "NodeUsers";
                    break;
                case "toolStripButtonGroups":
                    nodeName = "NodeGroups";
                    break;
                case "toolStripButtonUsersAndTests":
                    nodeName = "NodeUsersAndTests";
                    break;
                case "toolStripButtonAssignTestsToUsers":
                    nodeName = "NodeAssignTestsToUsers";
                    break;
                case "toolStripButtonReviewPassedTests":
                    nodeName = "NodeReviewTestResults";
                    break;
                case "toolStripButtonTests":
                    nodeName = "NodeTests";
                    break;
                case "toolStripButtonTestsExplorer":
                    nodeName = "NodeTestsExplorer";
                    break;
                case "toolStripButtonLoadTest":
                    nodeName = "NodeLoadTest";
                    break;
                case "toolStripButtonServer":
                    nodeName = "NodeServer";
                    break;
            }
            treeView1.SelectedNode = treeView1.Nodes.Find(nodeName, true)[0];
            treeView1.Focus();
        }



        #endregion Main

        #region General
        //----------------------------------------------------------------------------
        private void panelGeneral_VisibleChanged(object sender, EventArgs e)
        {
            if (panelGeneral.Visible == false) return;

            Task.Run(() =>
            {
                var users = Globals.repoUser.GetAll();
                this.Invoke(new Action(() => tbGeneralUsers.Text = users.Count().ToString()));
                this.Invoke(new Action(() => tbGeneralAdmins.Text = users.Where(x => x.IsAdmin).Count().ToString()));

                var groups = Globals.repoGroup.GetAll();
                this.Invoke(new Action(() => tbGeneralGroups.Text = groups.Count().ToString()));

                var userTest = Globals.repoUserTest.GetAll();
                this.Invoke(new Action(() => tbGeneralAssign.Text = userTest.Where(x => !x.IsTaked).Count().ToString()));
                int takedCount = userTest.Where(x => x.IsTaked).Count();
                this.Invoke(new Action(() => tbGeneralComleted.Text = takedCount.ToString()));
                int passedCount = userTest.Where(x => x.IsTaked && x.IsPassed).Count();
                this.Invoke(new Action(() => tbGeneralPassed.Text = passedCount.ToString()));
                this.Invoke(new Action(() => tbGeneralFailed.Text = userTest.Where(x => x.IsTaked && !x.IsPassed).Count().ToString()));
                int sumTestPoints = userTest.Where(x => x.IsTaked).SelectMany(x => x.Test.Questions).Select(z => z.Points).Sum();
                int sumUserPoints = (int)userTest.Where(x => x.IsTaked).Select(y => y.PointsGrade).Sum();
                decimal avg = (decimal)(((double)sumUserPoints / sumTestPoints) * 100);
                this.Invoke(new Action(() => tbGeneralAVG.Text = avg.ToString()));
                this.Invoke(new Action(() => tbGeneralAvgPassed.Text = ((decimal)(((double)passedCount / takedCount) * 100)).ToString()));

                var tests = Globals.repoTest.GetAll();
                this.Invoke(new Action(() => tbGeneralCountTests.Text = tests.Count().ToString()));
                this.Invoke(new Action(() => tbGeneralMaxQCount.Text = tests.Select(x=> x.Questions.Count()).Max().ToString()));
                this.Invoke(new Action(() => tbGeneralMinQCount.Text = tests.Select(x=> x.Questions.Count()).Min().ToString()));
                this.Invoke(new Action(() => tbGeneralAvgQCount.Text = tests.Select(x=> x.Questions.Count()).Average().ToString()));
            });
        }
        //----------------------------------------------------------------------------
        #endregion General

        #region Users and Groups
        //----------------------------------------------------------------------------
        private void panelUsersAndGroups_VisibleChanged(object sender, EventArgs e)
        {
            if (panelUsersAndGroups.Visible == false) return;

            Task.Run(() =>
            {
                var users = Globals.repoUser.GetAll();
                this.Invoke(new Action(() => tbUsersAndGroup_Users.Text = users.Count().ToString()));
                this.Invoke(new Action(() => tbUsersAndGroup_Admins.Text = users.Where(x => x.IsAdmin).Count().ToString()));

                var groups = Globals.repoGroup.GetAll();
                this.Invoke(new Action(() => tbUsersAndGroup_Groups.Text = groups.Count().ToString()));
            });
        }
        //----------------------------------------------------------------------------
        #endregion Users and Groups

        #region UsersForm
        //----------------------------------------------------------------------------
        FormSelector UsersForm_selector = FormSelector.Active;
        private async void panelUsers_VisibleChanged(object sender, EventArgs e)
        {
            if (panelUsers.Visible == false)
                return;

            if (firstTimeUsers)
            {
                UsersForm_selector = FormSelector.Active;
                await Task.Run(() => UsersForm_LoadUsersBySelector(UsersForm_selector));
                dgvUsersForm_Users.DataSource = bsUsersForm_Users;
                dgvUsersForm_Users.Columns[4].Visible = false;
                dgvUsersForm_Users.Columns[7].Visible = false;
                dgvUsersForm_Users.Columns[9].Visible = false;
                dgvUsersForm_Users.Columns[10].Visible = false;

                dgvUsersForm_Users.Columns[0].Width = 50;
                dgvUsersForm_Users.Columns[1].Width = 145;
                dgvUsersForm_Users.Columns[2].Width = 145;
                dgvUsersForm_Users.Columns[3].Width = 120;
                dgvUsersForm_Users.Columns[5].Width = 280;
                dgvUsersForm_Users.Columns[6].Width = 80;
                dgvUsersForm_Users.Columns[8].Width = 120;

                dgvUsersForm_Users.Columns[1].HeaderText = "First name";
                dgvUsersForm_Users.Columns[2].HeaderText = "Last name";
                dgvUsersForm_Users.Columns[6].HeaderText = "Admin";
                dgvUsersForm_Users.Columns[8].HeaderText = "Register date";

                firstTimeUsers = false;
            }
            else
            {
                await Task.Run(() => UsersForm_LoadUsersBySelector(UsersForm_selector));
                tbUsersForm_FindByLastName.Text = string.Empty;
                tbUsersForm_FindByLogin.Text = string.Empty;
            }
        }

        private void dgvUsersForm_Users_WhenRowGetSelect()
        {
            if (dgvUsersForm_Users.Rows.Count == 0 || dgvUsersForm_Users.SelectedRows.Count == 0)
            {
                toolStripButtonAddUserByCopy.Enabled = toolStripButtonEditUser.Enabled = toolStripButtonDeleteUser.Enabled = false;
            }
            else
            {
                toolStripButtonAddUserByCopy.Enabled = toolStripButtonEditUser.Enabled = true;
                User currUser = dgvUsersForm_Users.CurrentRow.DataBoundItem as User;
                toolStripButtonDeleteUser.Enabled = currUser.Id != 1 && !currUser.UserTests.Any();
            }
        }

        private DataGridViewRow GetRow_User(DataGridView dgv, User user)
        {
            return dgv.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["Id"].Value.Equals(user.Id))
                    .FirstOrDefault();
        }

        private void dgvUsersForm_Users_SelectionChanged(object sender, EventArgs e)
        {
            dgvUsersForm_Users_WhenRowGetSelect();
        }

        private async void toolStripButtonAddUser_Click(object sender, EventArgs e)
        {
            UsersAddEditForm userForm = new UsersAddEditForm(OpenMode.Add);
            if(userForm.ShowDialog() == DialogResult.OK)
            {
                User newUser = userForm.User;
                await Task.Run(() => Globals.repoUser.Add(newUser));

                this.dgvUsersForm_Users.SelectionChanged -= new System.EventHandler(this.dgvUsersForm_Users_SelectionChanged);
                {
                    await Task.Run(() => UsersForm_LoadUsersBySelector(UsersForm_selector));
                    if (dgvUsersForm_Users.Rows.Count != 0)
                    {
                        DataGridViewRow row = GetRow_User(dgvUsersForm_Users, newUser);
                        if (row != null)
                        {
                            dgvUsersForm_Users.CurrentCell = dgvUsersForm_Users.Rows[row.Index].Cells[0];
                        }
                    }
                    dgvUsersForm_Users_WhenRowGetSelect();
                }
                this.dgvUsersForm_Users.SelectionChanged += new System.EventHandler(this.dgvUsersForm_Users_SelectionChanged);
            }
        }

        private async void toolStripButtonAddUserByCopy_Click(object sender, EventArgs e)
        {
            UsersAddEditForm userForm = new UsersAddEditForm(OpenMode.AddByCopy, (dgvUsersForm_Users.CurrentRow.DataBoundItem as User).PartClone());
            if (userForm.ShowDialog() == DialogResult.OK)
            {
                User newUser = userForm.User;
                await Task.Run(() => Globals.repoUser.Add(newUser));

                this.dgvUsersForm_Users.SelectionChanged -= new System.EventHandler(this.dgvUsersForm_Users_SelectionChanged);
                {
                    await Task.Run(() => UsersForm_LoadUsersBySelector(UsersForm_selector));
                    if (dgvUsersForm_Users.Rows.Count != 0)
                    {
                        DataGridViewRow row = GetRow_User(dgvUsersForm_Users, newUser);
                        if (row != null)
                        {
                            dgvUsersForm_Users.CurrentCell = dgvUsersForm_Users.Rows[row.Index].Cells[0];
                        }
                    }
                    dgvUsersForm_Users_WhenRowGetSelect();
                }
                this.dgvUsersForm_Users.SelectionChanged += new System.EventHandler(this.dgvUsersForm_Users_SelectionChanged);
            }
        }

        private async void toolStripButtonEditUser_Click(object sender, EventArgs e)
        {
            User editableUser = dgvUsersForm_Users.CurrentRow.DataBoundItem as User;
            UsersAddEditForm userForm = new UsersAddEditForm(OpenMode.Edit, editableUser.FullClone());
            if (userForm.ShowDialog() == DialogResult.OK)
            {
                editableUser.UpdateClone(userForm.User);
                await Task.Run(() => Globals.repoUser.Update(editableUser));
                bsUsersForm_Users.ResetBindings(false);

                this.dgvUsersForm_Users.SelectionChanged -= new System.EventHandler(this.dgvUsersForm_Users_SelectionChanged);
                {
                    await Task.Run(() => UsersForm_LoadUsersBySelector(UsersForm_selector));
                    if (dgvUsersForm_Users.Rows.Count != 0)
                    {
                        DataGridViewRow row = GetRow_User(dgvUsersForm_Users, editableUser);
                        if (row != null)
                        {
                            dgvUsersForm_Users.CurrentCell = dgvUsersForm_Users.Rows[row.Index].Cells[0];
                        }                        
                    }
                    dgvUsersForm_Users_WhenRowGetSelect();
                }
                this.dgvUsersForm_Users.SelectionChanged += new System.EventHandler(this.dgvUsersForm_Users_SelectionChanged);
            }
        }

        private async void toolStripButtonDeleteUser_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Delete selected user?", "Test server", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.Cancel)
                return;

            await Task.Run(() => 
            {
                Globals.repoUser.Remove(dgvUsersForm_Users.CurrentRow.DataBoundItem as User);
                UsersForm_LoadUsersBySelector(UsersForm_selector);
            });
        }

        private void dgvUsersForm_Users_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                toolStripButtonEditUser_Click(sender, e);
            }
        }

        private async void UsersForm_RadioButtton_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (!radioButton.Checked) return;
            switch (radioButton.Name)
            {
                case "rbActive":
                    UsersForm_selector = FormSelector.Active;
                    break;
                case "rbArhived":
                    UsersForm_selector = FormSelector.Archived;
                    break;
                case "rbAll":
                    UsersForm_selector = FormSelector.All;
                    break;
            }
            await Task.Run(() => UsersForm_LoadUsersBySelector(UsersForm_selector));
        }

        private async void rbByGroup_CheckedChanged(object sender, EventArgs e)
        {
            cbUsersFormGroup.Enabled = rbByGroup.Checked;
            if (!rbByGroup.Checked)
            {
                cbUsersFormGroup.Items.Clear();
                cbUsersFormGroup.ResetText();
            }
            else
            {
                UsersForm_selector = FormSelector.None;
                await Task.Run(() => UsersForm_LoadUsersBySelector(UsersForm_selector));
                cbUsersFormGroup.Items.AddRange(await Task.Run(() => Globals.repoGroup.GetAll().ToArray()));
            }
        }

        private async void cbUsersFormGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUsersFormGroup.SelectedIndex != -1)
            {
                UsersForm_selector = FormSelector.ByGroup;
                await Task.Run(() => UsersForm_LoadUsersBySelector(UsersForm_selector));
            }
        }

        private void UsersForm_LoadUsersBySelector(FormSelector selector)
        {
            switch (selector)
            {
                case FormSelector.Active:
                    this.Invoke(new Action(() => bsUsersForm_Users.DataSource = Globals.repoUser.FindAll(x => !x.IsArhived)));
                    break;
                case FormSelector.Archived:
                    this.Invoke(new Action(() => bsUsersForm_Users.DataSource = Globals.repoUser.FindAll(x => x.IsArhived)));
                    break;
                case FormSelector.All:
                    this.Invoke(new Action(() => bsUsersForm_Users.DataSource = Globals.repoUser.GetAll()));
                    break;
                case FormSelector.ByGroup:
                    this.Invoke(new Action(() => bsUsersForm_Users.DataSource = Globals.repoGroup.FindById((cbUsersFormGroup.SelectedItem as Group).Id).Users));
                    break;
                case FormSelector.None:
                    this.Invoke(new Action(() => bsUsersForm_Users.Clear()));
                    break;
            }
        }

        private void tbUsersForm_FindByLastName_TextChanged(object sender, EventArgs e)
        {
            if (!tbUsersForm_FindByLastName.Text.Any()) return;
            DataGridViewRow row = dgvUsersForm_Users.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["LastName"].Value.ToString().ToLower().StartsWith(tbUsersForm_FindByLastName.Text.ToLower()))
                .FirstOrDefault();
            if (row != null)
            {
                this.dgvUsersForm_Users.SelectionChanged -= new System.EventHandler(this.dgvUsersForm_Users_SelectionChanged);
                {
                    dgvUsersForm_Users.CurrentCell = dgvUsersForm_Users.Rows[row.Index].Cells[0];
                    dgvUsersForm_Users_WhenRowGetSelect();
                }
                this.dgvUsersForm_Users.SelectionChanged += new System.EventHandler(this.dgvUsersForm_Users_SelectionChanged);
            }
        }

        private void tbUsersForm_FindByLogin_TextChanged(object sender, EventArgs e)
        {
            if (!tbUsersForm_FindByLogin.Text.Any()) return;
            DataGridViewRow row = dgvUsersForm_Users.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["Login"].Value.ToString().ToLower().StartsWith(tbUsersForm_FindByLogin.Text.ToLower()))
                .FirstOrDefault();
            if (row != null)
            {
                this.dgvUsersForm_Users.SelectionChanged -= new System.EventHandler(this.dgvUsersForm_Users_SelectionChanged);
                {
                    dgvUsersForm_Users.CurrentCell = dgvUsersForm_Users.Rows[row.Index].Cells[0];
                    dgvUsersForm_Users_WhenRowGetSelect();
                }
                this.dgvUsersForm_Users.SelectionChanged += new System.EventHandler(this.dgvUsersForm_Users_SelectionChanged);
            }
        }
        //----------------------------------------------------------------------------
        #endregion UsersForm

        #region GroupsForm
        //----------------------------------------------------------------------------
        DALTestingSystemDB.Group GroupsForm_currGroup;
        private async void panelGroups_VisibleChanged(object sender, EventArgs e)
        {
            if (panelGroups.Visible == false) return;

            this.dgvGroupsForm_Groups.SelectionChanged -= new System.EventHandler(this.dgvGroupsForm_Groups_SelectionChanged);
            if (firstTimeGroups)
            {                
                // Groups
                dgvGroupsForm_Groups.Columns.Clear();
                bsGroupsForm_Groups.DataSource = await Task.Run(() => Globals.repoGroup.GetAll());
                dgvGroupsForm_Groups.DataSource = bsGroupsForm_Groups;
                dgvGroupsForm_Groups.Columns[4].Visible = false;
                dgvGroupsForm_Groups.Columns[0].Width = 50;
                dgvGroupsForm_Groups.Columns[1].Width = 140;
                dgvGroupsForm_Groups.Columns[2].Width = 190;
                dgvGroupsForm_Groups.Columns[3].Width = 90;
                dgvGroupsForm_Groups.Columns[3].HeaderText = "Admin group";
                GroupsForm_currGroup = dgvGroupsForm_Groups.CurrentRow.DataBoundItem as Group;
                GroupsForm_GroupsMenuEnDis();

                //Users
                dgvGroupsForm_Users.Columns.Clear();
                bsGroupsForm_Users.DataSource = GroupsForm_currGroup.Users;
                dgvGroupsForm_Users.DataSource = bsGroupsForm_Users;
                for (int i = 4; i <= 10; i++)
                    dgvGroupsForm_Users.Columns[i].Visible = false;
                dgvGroupsForm_Users.Columns[0].Width = 50;
                dgvGroupsForm_Users.Columns[1].Width = 120;
                dgvGroupsForm_Users.Columns[2].Width = 120;
                dgvGroupsForm_Users.Columns[3].Width = 100;
                dgvGroupsForm_Users.Columns[1].HeaderText = "First name";
                dgvGroupsForm_Users.Columns[2].HeaderText = "Last name";
                firstTimeGroups = false;                
            }
            else
            {
                bsGroupsForm_Groups.ResetBindings(false);
                dgvGroupsForm_Groups_WhenRowGetSelect();
            }
            this.dgvGroupsForm_Groups.SelectionChanged += new System.EventHandler(this.dgvGroupsForm_Groups_SelectionChanged);
        }

        private void dgvGroupsForm_Groups_WhenRowGetSelect()
        {
            GroupsForm_currGroup = dgvGroupsForm_Groups.CurrentRow.DataBoundItem as DALTestingSystemDB.Group;
            bsGroupsForm_Users.DataSource = GroupsForm_currGroup.Users;
            bsGroupsForm_Users.ResetBindings(false);
            GroupsForm_GroupsMenuEnDis();
        }

        private void dgvGroupsForm_Groups_SelectionChanged(object sender, EventArgs e)
        {
            dgvGroupsForm_Groups_WhenRowGetSelect();
        }

        private DataGridViewRow GetRow_Group(DataGridView dgv, DALTestingSystemDB.Group group)
        {
            return dgv.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["Id"].Value.Equals(group.Id))
                    .FirstOrDefault();
        }

        private void GroupsForm_GroupsMenuEnDis()
        {
            toolStripButtonAddGroupByCopy.Enabled = true;
            toolStripButtonEditGroup.Enabled = true;
            if ((dgvGroupsForm_Groups.CurrentRow.DataBoundItem as DALTestingSystemDB.Group).Id == 1)
                toolStripButtonDeleteGroup.Enabled = false;
            else
                toolStripButtonDeleteGroup.Enabled = true;
        }

        private async void toolStripButtonAddGroup_Click(object sender, EventArgs e)
        {
            GroupsAddEditForm groupForm = new GroupsAddEditForm(OpenMode.Add);
            if (groupForm.ShowDialog() == DialogResult.OK)
            {
                DALTestingSystemDB.Group newGroup = groupForm.Group;
                await Task.Run(() => Globals.repoGroup.Add(newGroup));

                this.dgvGroupsForm_Groups.SelectionChanged -= new System.EventHandler(this.dgvGroupsForm_Groups_SelectionChanged);
                {
                    bsGroupsForm_Groups.DataSource = await Task.Run(() => Globals.repoGroup.GetAll());
                    DataGridViewRow row = GetRow_Group(dgvGroupsForm_Groups, newGroup);
                    dgvGroupsForm_Groups.CurrentCell = dgvGroupsForm_Groups.Rows[row.Index].Cells[0];
                    dgvGroupsForm_Groups_WhenRowGetSelect();
                }
                this.dgvGroupsForm_Groups.SelectionChanged += new System.EventHandler(this.dgvGroupsForm_Groups_SelectionChanged);                
            }
        }

        private async void toolStripButtonAddGroupByCopy_Click(object sender, EventArgs e)
        {
            GroupsAddEditForm groupForm = new GroupsAddEditForm(OpenMode.AddByCopy, (dgvGroupsForm_Groups.CurrentRow.DataBoundItem as DALTestingSystemDB.Group).PartClone());
            if (groupForm.ShowDialog() == DialogResult.OK)
            {
                DALTestingSystemDB.Group newGroup = groupForm.Group;
                await Task.Run(() => Globals.repoGroup.Add(newGroup));

                this.dgvGroupsForm_Groups.SelectionChanged -= new System.EventHandler(this.dgvGroupsForm_Groups_SelectionChanged);
                {
                    bsGroupsForm_Groups.DataSource = await Task.Run(() => Globals.repoGroup.GetAll());
                    DataGridViewRow row = GetRow_Group(dgvGroupsForm_Groups, newGroup);
                    dgvGroupsForm_Groups.CurrentCell = dgvGroupsForm_Groups.Rows[row.Index].Cells[0];
                    dgvGroupsForm_Groups_WhenRowGetSelect();
                }
                this.dgvGroupsForm_Groups.SelectionChanged += new System.EventHandler(this.dgvGroupsForm_Groups_SelectionChanged);
            }
        }

        private async void toolStripButtonEditGroup_Click(object sender, EventArgs e)
        {
            DALTestingSystemDB.Group editableGroup = dgvGroupsForm_Groups.CurrentRow.DataBoundItem as DALTestingSystemDB.Group;
            GroupsAddEditForm groupForm = new GroupsAddEditForm(OpenMode.Edit, editableGroup.FullClone());
            if(groupForm.ShowDialog() == DialogResult.OK)
            {
                editableGroup.UpdateClone(groupForm.Group);
                await Task.Run(() => Globals.repoGroup.Update(editableGroup));                

                this.dgvGroupsForm_Groups.SelectionChanged -= new System.EventHandler(this.dgvGroupsForm_Groups_SelectionChanged);
                {
                    bsGroupsForm_Groups.ResetBindings(false);
                    DataGridViewRow row = GetRow_Group(dgvGroupsForm_Groups, editableGroup);
                    dgvGroupsForm_Groups.CurrentCell = dgvGroupsForm_Groups.Rows[row.Index].Cells[0];
                    dgvGroupsForm_Groups_WhenRowGetSelect();
                }
                this.dgvGroupsForm_Groups.SelectionChanged += new System.EventHandler(this.dgvGroupsForm_Groups_SelectionChanged);
            }
        }

        private void dgvGroupsForm_Groups_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                toolStripButtonEditGroup_Click(sender, e);
            }
        }

        private async void toolStripButtonDeleteGroup_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Delete selected group?", "Test server", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.Cancel)
                return;

            DALTestingSystemDB.Group deletableGroup = dgvGroupsForm_Groups.CurrentRow.DataBoundItem as DALTestingSystemDB.Group;
            DataGridViewRow row = GetRow_Group(dgvGroupsForm_Groups, deletableGroup);
            int newPos = (row.Index == dgvGroupsForm_Groups.RowCount - 1) ? newPos = row.Index - 1 : newPos = row.Index;
            await Task.Run(() => Globals.repoGroup.Remove(deletableGroup));

            this.dgvGroupsForm_Groups.SelectionChanged -= new System.EventHandler(this.dgvGroupsForm_Groups_SelectionChanged);
            {
                bsGroupsForm_Groups.DataSource = await Task.Run(() => Globals.repoGroup.GetAll());
                dgvGroupsForm_Groups.CurrentCell = dgvGroupsForm_Groups.Rows[newPos].Cells[0];
                dgvGroupsForm_Groups_WhenRowGetSelect();
            }
            this.dgvGroupsForm_Groups.SelectionChanged += new System.EventHandler(this.dgvGroupsForm_Groups_SelectionChanged);
        }

        private void tbGroups_FindByName_TextChanged(object sender, EventArgs e)
        {
            if (!tbGroups_FindByName.Text.Any()) return;
            DataGridViewRow row = dgvGroupsForm_Groups.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["Name"].Value.ToString().ToLower().StartsWith(tbGroups_FindByName.Text.ToLower()))
                .FirstOrDefault();
            if(row != null)
            {
                this.dgvGroupsForm_Groups.SelectionChanged -= new System.EventHandler(this.dgvGroupsForm_Groups_SelectionChanged);
                {
                    dgvGroupsForm_Groups.CurrentCell = dgvGroupsForm_Groups.Rows[row.Index].Cells[0];
                    dgvGroupsForm_Groups_WhenRowGetSelect();
                }
                this.dgvGroupsForm_Groups.SelectionChanged += new System.EventHandler(this.dgvGroupsForm_Groups_SelectionChanged);
            }
        }

        //----------------------------------------------------------------------------
        #endregion Groups

        #region Users and Tests
        //----------------------------------------------------------------------------
        private void panelUsersAndTests_VisibleChanged(object sender, EventArgs e)
        {
            if (panelUsersAndTests.Visible == false) return;

            Task.Run(() =>
            {
                var userTest = Globals.repoUserTest.GetAll();
                this.Invoke(new Action(() => tbUsersAndTestsForm_Assigned.Text = userTest.Where(x => !x.IsTaked).Count().ToString()));
                int takedCount = userTest.Where(x => x.IsTaked).Count();
                this.Invoke(new Action(() => tbUsersAndTestsForm_Comleted.Text = takedCount.ToString()));
                int passedCount = userTest.Where(x => x.IsTaked && x.IsPassed).Count();
                this.Invoke(new Action(() => tbUsersAndTestsForm_Passed.Text = passedCount.ToString()));
                this.Invoke(new Action(() => tbUsersAndTestsForm_Failed.Text = userTest.Where(x => x.IsTaked && !x.IsPassed).Count().ToString()));
                int sumTestPoints = userTest.Where(x => x.IsTaked).SelectMany(x => x.Test.Questions).Select(z => z.Points).Sum();
                int sumUserPoints = (int)userTest.Where(x => x.IsTaked).Select(y => y.PointsGrade).Sum();
                decimal avg = (decimal)(((double)sumUserPoints / sumTestPoints) * 100);
                this.Invoke(new Action(() => tbUsersAndTestsForm_AVG.Text = avg.ToString()));
                this.Invoke(new Action(() => tbUsersAndTestsForm_AvgPassed.Text = ((decimal)(((double)passedCount / takedCount) * 100)).ToString()));
            });
        }
        //----------------------------------------------------------------------------
        #endregion Users and Tests

        #region AssignTests
        //----------------------------------------------------------------------------
        User AssignTestsForm_currUser;
        DALTestingSystemDB.Group AssignTestsForm_currGroup;
        DALTestingSystemDB.Test AssignTestsForm_currTest;
        private async void panelAssignTestsToUsers_VisibleChanged(object sender, EventArgs e)
        {
            if (panelAssignTestsToUsers.Visible == false) return;

            this.dgvAssignTestsForm_Users.SelectionChanged -= new System.EventHandler(this.dgvAssignTestsForm_Users_SelectionChanged);
            this.dgvAssignTestsForm_Groups.SelectionChanged -= new System.EventHandler(this.dgvAssignTestsForm_Groups_SelectionChanged);
            if (firstTimeAssignTests)
            {
                //Users
                dgvAssignTestsForm_Users.Columns.Clear();
                bsAssignTestsForm_Users.DataSource = await Task.Run(() => Globals.repoUser.GetAll());
                dgvAssignTestsForm_Users.DataSource = bsAssignTestsForm_Users;
                for (int i = 4; i <= 10; i++)
                    if (i != 6)
                        dgvAssignTestsForm_Users.Columns[i].Visible = false;
                dgvAssignTestsForm_Users.Columns[0].Width = 50;
                dgvAssignTestsForm_Users.Columns[1].Width = 120;
                dgvAssignTestsForm_Users.Columns[2].Width = 120;
                dgvAssignTestsForm_Users.Columns[3].Width = 100;
                dgvAssignTestsForm_Users.Columns[6].Width = 80;
                dgvAssignTestsForm_Users.Columns[1].HeaderText = "First name";
                dgvAssignTestsForm_Users.Columns[2].HeaderText = "Last name";
                dgvAssignTestsForm_Users.Columns[6].HeaderText = "Admin";
                AssignTestsForm_currUser = dgvAssignTestsForm_Users.CurrentRow.DataBoundItem as User;

                // Groups
                dgvAssignTestsForm_Groups.Columns.Clear();
                bsAssignTestsForm_Groups.DataSource = await Task.Run(() => Globals.repoGroup.GetAll());
                dgvAssignTestsForm_Groups.DataSource = bsAssignTestsForm_Groups;
                dgvAssignTestsForm_Groups.Columns[3].Visible = false;
                dgvAssignTestsForm_Groups.Columns[4].Visible = false;
                dgvAssignTestsForm_Groups.Columns[0].Width = 50;
                dgvAssignTestsForm_Groups.Columns[1].Width = 140;
                dgvAssignTestsForm_Groups.Columns[2].Width = 200;
                AssignTestsForm_currGroup = dgvAssignTestsForm_Groups.CurrentRow.DataBoundItem as DALTestingSystemDB.Group;

                // AssignTests
                dgvAssignTestsForm_Tests.Columns.Clear();
                List<DALTestingSystemDB.Test> userTests = await Task.Run(() => Globals.repoUser.FindById(AssignTestsForm_currUser.Id).UserTests.Where(y => !y.IsTaked).Select(z => z.Test).ToList());
                bsAssignTestsForm_Tests.DataSource = userTests;
                dgvAssignTestsForm_Tests.DataSource = bsAssignTestsForm_Tests;
                for (int i = 4; i <= 9; i++)
                    if (i != 6 && i != 7)
                        dgvAssignTestsForm_Tests.Columns[i].Visible = false;
                dgvAssignTestsForm_Tests.Columns[0].Width = 50;
                dgvAssignTestsForm_Tests.Columns[1].Width = 260;
                dgvAssignTestsForm_Tests.Columns[2].Width = 170;
                dgvAssignTestsForm_Tests.Columns[3].Width = 260;
                dgvAssignTestsForm_Tests.Columns[6].Width = 80;
                dgvAssignTestsForm_Tests.Columns[7].Width = 120;
                dgvAssignTestsForm_Tests.Columns[6].HeaderText = "Archived";
                dgvAssignTestsForm_Tests.Columns[7].HeaderText = "Loaded date";
                if (userTests.Any())
                    AssignTestsForm_currTest = dgvAssignTestsForm_Tests.CurrentRow.DataBoundItem as DALTestingSystemDB.Test;
                firstTimeAssignTests = false;
            }
            else
            {
                bsAssignTestsForm_Users.DataSource = await Task.Run(() => Globals.repoUser.GetAll());
                dgvAssignTestsForm_Users_WhenRowGetSelect();

                bsAssignTestsForm_Groups.DataSource = await Task.Run(() => Globals.repoGroup.GetAll());
                dgvAssignTestsForm_Groups_WhenRowGetSelect();

                tbAssignTestsForm_FindUserByLastName.Text = string.Empty;
                tbAssignTestsForm_FindUserByLogin.Text = string.Empty;
                tbAssignTestsForm_FindGroupByName.Text = string.Empty;
            }
            this.dgvAssignTestsForm_Users.SelectionChanged += new System.EventHandler(this.dgvAssignTestsForm_Users_SelectionChanged);
            this.dgvAssignTestsForm_Groups.SelectionChanged += new System.EventHandler(this.dgvAssignTestsForm_Groups_SelectionChanged);
        }

        private async void dgvAssignTestsForm_Users_WhenRowGetSelect()
        {
            toolStripButtonAssignNewTestForUser.Enabled = true;
            AssignTestsForm_currUser = dgvAssignTestsForm_Users.CurrentRow.DataBoundItem as User;
            bsAssignTestsForm_Tests.DataSource = 
                await Task.Run(() => Globals.repoUser.FindById(AssignTestsForm_currUser.Id)
                .UserTests.Where(y => !y.IsTaked)
                .Select(z => z.Test)
                .ToList());
        }

        private void dgvAssignTestsForm_Groups_WhenRowGetSelect()
        {
            AssignTestsForm_currGroup = dgvAssignTestsForm_Groups.CurrentRow.DataBoundItem as DALTestingSystemDB.Group;
        }

        private void dgvAssignTestsForm_Tests_WhenRowGetSelect()
        {
            if (dgvAssignTestsForm_Tests.Rows.Count == 0 || dgvAssignTestsForm_Tests.SelectedRows.Count == 0)
            {
                toolStripButtonAssignNewTestByCopyForUser.Enabled 
                    = toolStripButtonRemoveAssignedTestForUser.Enabled 
                    = false;
                AssignTestsForm_currTest = null;
            }
            else
            {
                toolStripButtonAssignNewTestByCopyForUser.Enabled
                    = toolStripButtonRemoveAssignedTestForUser.Enabled
                    = true;
                AssignTestsForm_currTest = dgvAssignTestsForm_Tests.CurrentRow.DataBoundItem as DALTestingSystemDB.Test;
            }
        }

        private void dgvAssignTestsForm_Users_SelectionChanged(object sender, EventArgs e)
        {
            dgvAssignTestsForm_Users_WhenRowGetSelect();
        }

        private void dgvAssignTestsForm_Groups_SelectionChanged(object sender, EventArgs e)
        {
            dgvAssignTestsForm_Groups_WhenRowGetSelect();
        }

        private void dgvAssignTestsForm_Tests_SelectionChanged(object sender, EventArgs e)
        {
            dgvAssignTestsForm_Tests_WhenRowGetSelect();
        }

        private async void toolStripButtonAssignNewTestForGroup_Click(object sender, EventArgs e)
        {
            var testsForGroup = await Task.Run(() => Globals.repoTest.GetAll().ToList());
            if (!testsForGroup.Any())
            {
                MessageBox.Show("There are no Tests in database!", "Test server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SelectTestForm assignNewTestForm = new SelectTestForm(testsForGroup, OpenMode.NewTestForGroup);
            if (assignNewTestForm.ShowDialog() == DialogResult.OK)
            {
                DALTestingSystemDB.Test newTest = assignNewTestForm.Test;
                foreach (User user in AssignTestsForm_currGroup.Users)
                {
                    UserTest newUserTest = new UserTest()
                    {
                        IsTaked = false,
                        TakedDate = null,
                        User = user,
                        Test = newTest,
                    };
                    await Task.Run(() => Globals.repoUserTest.Add(newUserTest));
                }

                this.dgvAssignTestsForm_Tests.SelectionChanged -= new System.EventHandler(this.dgvAssignTestsForm_Tests_SelectionChanged);
                {
                    bsAssignTestsForm_Tests.DataSource = 
                        await Task.Run(() => Globals.repoUser.FindById(AssignTestsForm_currUser.Id)
                        .UserTests.Where(y => !y.IsTaked)
                        .Select(z => z.Test)
                        .ToList());

                    bsAssignTestsForm_Tests.MoveLast();
                    dgvAssignTestsForm_Tests_WhenRowGetSelect();
                }
                this.dgvAssignTestsForm_Tests.SelectionChanged += new System.EventHandler(this.dgvAssignTestsForm_Tests_SelectionChanged);
            }
        }

        private async void toolStripButtonAssignNewTestForUser_Click(object sender, EventArgs e)
        {
            var testsForUser = await Task.Run(() => Globals.repoTest.GetAll().ToList());
            if (!testsForUser.Any())
            {
                MessageBox.Show("There are no Tests in database!", "Test server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SelectTestForm assignNewTestForm = new SelectTestForm(testsForUser, OpenMode.NewTestForGroup);
            if(assignNewTestForm.ShowDialog() == DialogResult.OK)
            {
                DALTestingSystemDB.Test newTest = assignNewTestForm.Test;
                UserTest newUserTest = new UserTest() {
                    IsTaked = false,
                    TakedDate = null,
                    User = AssignTestsForm_currUser,
                    Test = newTest,
                };
                await Task.Run(() => Globals.repoUserTest.Add(newUserTest));

                this.dgvAssignTestsForm_Tests.SelectionChanged -= new System.EventHandler(this.dgvAssignTestsForm_Tests_SelectionChanged);
                {
                    bsAssignTestsForm_Tests.DataSource = await Task.Run(() => Globals.repoUser.FindById(AssignTestsForm_currUser.Id).UserTests.Where(y => !y.IsTaked).Select(z => z.Test).ToList());
                    bsAssignTestsForm_Tests.MoveLast();
                    dgvAssignTestsForm_Tests_WhenRowGetSelect();
                }
                this.dgvAssignTestsForm_Tests.SelectionChanged += new System.EventHandler(this.dgvAssignTestsForm_Tests_SelectionChanged);
            }
        }

        private async void toolStripButtonAssignNewTestByCopyForUser_Click(object sender, EventArgs e)
        {
            UserTest newUserTest = new UserTest()
            {
                IsTaked = false,
                TakedDate = null,
                User = AssignTestsForm_currUser,
                Test = AssignTestsForm_currTest,
            };
            await Task.Run(() => Globals.repoUserTest.Add(newUserTest));
            this.dgvAssignTestsForm_Tests.SelectionChanged -= new System.EventHandler(this.dgvAssignTestsForm_Tests_SelectionChanged);
            {
                var userTestslist = await Task.Run(() => Globals.repoUser.FindById(AssignTestsForm_currUser.Id).UserTests.Where(y => !y.IsTaked).Select(z => z.Test).ToList());
                if(userTestslist.Any())
                {
                    bsAssignTestsForm_Tests.DataSource = userTestslist;
                    bsAssignTestsForm_Tests.MoveLast();
                }
                dgvAssignTestsForm_Tests_WhenRowGetSelect();
            }
            this.dgvAssignTestsForm_Tests.SelectionChanged += new System.EventHandler(this.dgvAssignTestsForm_Tests_SelectionChanged);
        }

        private async void toolStripButtonRemoveAssignedTestForUser_Click(object sender, EventArgs e)
        {
            UserTest deletableUserTest = Globals.repoUserTest.FindAll(
                x => x.User.Id == AssignTestsForm_currUser.Id 
                && x.Test.Id == AssignTestsForm_currTest.Id 
                && !x.IsTaked)
                .LastOrDefault();

            if(deletableUserTest == null)
                MessageBox.Show("This test is already in progress!", "Test server", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                await Task.Run(() => Globals.repoUserTest.Remove(deletableUserTest));

            this.dgvAssignTestsForm_Tests.SelectionChanged -= new System.EventHandler(this.dgvAssignTestsForm_Tests_SelectionChanged);
            {
                bsAssignTestsForm_Tests.DataSource = await Task.Run(() => Globals.repoUser.FindById(
                    AssignTestsForm_currUser.Id)
                    .UserTests.Where(y => !y.IsTaked)
                    .Select(z => z.Test)
                    .ToList());

                dgvAssignTestsForm_Tests_WhenRowGetSelect();
            }
            this.dgvAssignTestsForm_Tests.SelectionChanged += new System.EventHandler(this.dgvAssignTestsForm_Tests_SelectionChanged);
        }

        private void tbAssignTestsForm_FindUserByLastName_TextChanged(object sender, EventArgs e)
        {
            if (!tbAssignTestsForm_FindUserByLastName.Text.Any()) return;
            DataGridViewRow row = dgvAssignTestsForm_Users.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["LastName"].Value.ToString().ToLower().StartsWith(tbAssignTestsForm_FindUserByLastName.Text.ToLower()))
                .FirstOrDefault();
            if (row != null)
            {
                this.dgvAssignTestsForm_Users.SelectionChanged -= new System.EventHandler(this.dgvAssignTestsForm_Users_SelectionChanged);
                {
                    dgvAssignTestsForm_Users.CurrentCell = dgvAssignTestsForm_Users.Rows[row.Index].Cells[0];
                    dgvAssignTestsForm_Users_WhenRowGetSelect();
                }
                this.dgvAssignTestsForm_Users.SelectionChanged -= new System.EventHandler(this.dgvAssignTestsForm_Users_SelectionChanged);
            }
        }

        private void tbAssignTestsForm_FindUserByLogin_TextChanged(object sender, EventArgs e)
        {
            if (!tbAssignTestsForm_FindUserByLogin.Text.Any()) return;
            DataGridViewRow row = dgvAssignTestsForm_Users.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["Login"].Value.ToString().ToLower().StartsWith(tbAssignTestsForm_FindUserByLogin.Text.ToLower()))
                .FirstOrDefault();
            if (row != null)
            {
                this.dgvAssignTestsForm_Users.SelectionChanged -= new System.EventHandler(this.dgvAssignTestsForm_Users_SelectionChanged);
                {
                    dgvAssignTestsForm_Users.CurrentCell = dgvAssignTestsForm_Users.Rows[row.Index].Cells[0];
                    dgvAssignTestsForm_Users_WhenRowGetSelect();
                }
                this.dgvAssignTestsForm_Users.SelectionChanged -= new System.EventHandler(this.dgvAssignTestsForm_Users_SelectionChanged);
            }
        }

        private void tbAssignTestsForm_FindGroupByName_TextChanged(object sender, EventArgs e)
        {
            if (!tbAssignTestsForm_FindGroupByName.Text.Any()) return;
            DataGridViewRow row = dgvAssignTestsForm_Groups.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["Name"].Value.ToString().ToLower().StartsWith(tbAssignTestsForm_FindGroupByName.Text.ToLower()))
                .FirstOrDefault();
            if (row != null)
            {
                this.dgvAssignTestsForm_Groups.SelectionChanged -= new System.EventHandler(this.dgvAssignTestsForm_Groups_SelectionChanged);
                {
                    dgvAssignTestsForm_Groups.CurrentCell = dgvAssignTestsForm_Groups.Rows[row.Index].Cells[0];
                    dgvAssignTestsForm_Groups_WhenRowGetSelect();
                }
                this.dgvAssignTestsForm_Groups.SelectionChanged += new System.EventHandler(this.dgvAssignTestsForm_Groups_SelectionChanged);
            }
        }
        //----------------------------------------------------------------------------
        #endregion AssignTests

        #region LoadTestForm
        // LoadTestForm functional
        //-----------------------------------------------------------------------------
        TestLib.Test currTest;
        TestLib.Question currQuestion;
        Bitmap noPhotoBitmap = new Bitmap(Resources.nophoto);
        void LoadTestForm_CleanForm()
        {
            currTest = null;
            currQuestion = null;

            tbTitle.Text = string.Empty;
            tbAuthor.Text = string.Empty;
            tbDescription.Text = string.Empty;
            tbInfo.Text = string.Empty;
            tbCountOfQuestions.Text = string.Empty;
            tbMaxPointsForTest.Text = string.Empty;
            numericUpDownMinPass.Value = 0;
            pictureBox.Image = noPhotoBitmap;

            LoadTestForm_CleanDGVQuestions();
            LoadTestForm_CleanDGVAnswers();
            btnLoadTestForm_SaveTestToDB.Enabled = false;
            pictureBoxWarningDone.Visible = false;
        }
        void LoadTestForm_CleanDGVQuestions()
        {
            bsLoadTestForm_Questions.DataSource = null;
            dgvLoadTestForm_Questions.Columns.Clear();
            dgvLoadTestForm_Questions.Columns.Add("Question", "Question");
            dgvLoadTestForm_Questions.Columns.Add("Point", "Point");
            dgvLoadTestForm_Questions.Columns[0].Width = 510;
            dgvLoadTestForm_Questions.Columns[1].Width = 90;
        }
        void LoadTestForm_CleanDGVAnswers()
        {
            bsLoadTestForm_Answers.DataSource = null;
            dgvLoadTestForm_Answers.Columns.Clear();
            dgvLoadTestForm_Answers.Columns.Add("Answer", "Answer");
            dgvLoadTestForm_Answers.Columns.Add("Right", "Is right");
            dgvLoadTestForm_Answers.Columns[0].Width = 300;
            dgvLoadTestForm_Answers.Columns[1].Width = 90;
        }
        void LoadTestForm_FillForm()
        {
            tbAuthor.Text = currTest.Author;
            tbTitle.Text = currTest.Title;
            tbDescription.Text = currTest.Description;
            tbInfo.Text = currTest.Info;
            pictureBox.Image = SetCurrBitmap();
            numericUpDownMinPass.Value = currTest.PassPercent;
     
            if (currQuestion != null)
            {
                LoadTestForm_FillDGVQuestions();
                LoadTestForm_FillDGVAnswers();
            }
        }
        void LoadTestForm_FillDGVQuestions()
        {
            dgvLoadTestForm_Questions.SelectionChanged -= new System.EventHandler(this.dgvLoadTestForm_Questions_SelectionChanged);
            {
                dgvLoadTestForm_Questions.Columns.Clear();
                bsLoadTestForm_Questions.DataSource = currTest.Questions;
                bsLoadTestForm_Questions.ResetBindings(false);

                dgvLoadTestForm_Questions.Columns[0].Width = 510;
                dgvLoadTestForm_Questions.Columns[0].HeaderText = "Question";
                dgvLoadTestForm_Questions.Columns[1].Width = 90;
                dgvLoadTestForm_Questions.Columns[1].HeaderText = "Point";
                dgvLoadTestForm_Questions.Columns[2].Visible = false;
                dgvLoadTestForm_Questions.Rows[0].Selected = true;

                pictureBox.Image = SetCurrBitmap();
                pictureBox.Refresh();
            }
            dgvLoadTestForm_Questions.SelectionChanged += new System.EventHandler(this.dgvLoadTestForm_Questions_SelectionChanged);

            tbCountOfQuestions.Text = currTest.Questions.Count.ToString();
            tbMaxPointsForTest.Text = currTest.Questions.Select(x => x.Points).Sum().ToString();
        }
        void LoadTestForm_FillDGVAnswers()
        {
            dgvLoadTestForm_Answers.Columns.Clear();
            bsLoadTestForm_Answers.DataSource = currQuestion.Answers;
            bsLoadTestForm_Answers.ResetBindings(false);

            dgvLoadTestForm_Answers.Columns[0].Width = 300;
            dgvLoadTestForm_Answers.Columns[0].HeaderText = "Answer";
            dgvLoadTestForm_Answers.Columns[1].Width = 90;
            dgvLoadTestForm_Answers.Columns[1].HeaderText = "Is right";
            dgvLoadTestForm_Answers.ClearSelection();
        }
        Bitmap SetCurrBitmap()
        {
            if (currQuestion != null && currQuestion.Img != String.Empty)
                return ImgConverter.Base64StringToBitmap(currQuestion.Img);
            return noPhotoBitmap;
        }
        private void btnLoadTestForm_LoadTest_Click(object sender, EventArgs e)
        {
            openXmlFileDialog.Filter = "XML files (*.xml)|*.xml";
            openXmlFileDialog.FilterIndex = 1;
            openXmlFileDialog.RestoreDirectory = true;

            if(openXmlFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LoadTestForm_CleanForm();
                    currTest = Serializer.Deserialize<TestLib.Test>(File.ReadAllText(openXmlFileDialog.FileName));

                    if (currTest != null && currTest.Questions.Any())
                    {
                        currQuestion = currTest.Questions[0];
                    }
                    else
                    {
                        currQuestion = null;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                LoadTestForm_FillForm();
                btnLoadTestForm_SaveTestToDB.Enabled = true;
                pictureBoxWarningDone.Image = Resources.warning;
                pictureBoxWarningDone.Visible = true;
                btnLoadTestForm_SaveTestToDB.Select();
            }
        }
        private void btnLoadTestForm_Clean_Click(object sender, EventArgs e)
        {
            LoadTestForm_CleanForm();
        }
        private void dgvLoadTestForm_Questions_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoadTestForm_Questions.SelectedRows.Count == 0)
                return;
            currQuestion = dgvLoadTestForm_Questions.CurrentRow.DataBoundItem as TestLib.Question;
            pictureBox.Image = SetCurrBitmap();
            LoadTestForm_FillDGVAnswers();
        }
        private async void btnLoadTestForm_SaveTestToDB_Click(object sender, EventArgs e)
        {
            pictureBoxWarningDone.Visible = false;
            btnLoadTestForm_SaveTestToDB.Enabled = false;
            btnLoadTestForm_LoadTest.Enabled = false;
            btnLoadTestForm_Clean.Enabled = false;

            DALTestingSystemDB.Test test = new DALTestingSystemDB.Test();            
            await Task.Run(() =>
            {
                test.Title = currTest.Title;
                test.Author = currTest.Author;
                test.Description = currTest.Description;
                test.Info = currTest.Info;
                test.PassPercent = currTest.PassPercent;
                foreach (var q in currTest.Questions)
                {
                    var question = new DALTestingSystemDB.Question { QuestionText = q.QuestionText, Img = q.Img, Points = q.Points, Test = test };
                    foreach (var a in q.Answers)
                    {
                        var answer = new DALTestingSystemDB.Answer { AnswerText = a.TextAnswer, IsRight = a.IsRight, Question = question };
                        question.Answers.Add(answer);
                    }
                    test.Questions.Add(question);
                }
                test.LoadedDate = DateTime.Now;
                test.IsArchived = false;
                try
                {
                    Globals.repoTest.Add(test);
                }
                catch (DBConcurrencyException ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "TestServer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            pictureBoxWarningDone.Image = Resources.done;   
            pictureBoxWarningDone.Visible = true;
            btnLoadTestForm_LoadTest.Enabled = true;
            btnLoadTestForm_Clean.Enabled = true;
        }
        //-----------------------------------------------------------------------------
        #endregion LoadTestForm functional

        #region Tests
        //----------------------------------------------------------------------------
        private void panelTests_VisibleChanged(object sender, EventArgs e)
        {
            if (panelTests.Visible == false) return;

            Task.Run(() =>
            {
                var tests = Globals.repoTest.GetAll();
                this.Invoke(new Action(() => tbTestsForm_Count.Text = tests.Count().ToString()));
                this.Invoke(new Action(() => tbTestsForm_Max.Text = tests.Select(x => x.Questions.Count()).Max().ToString()));
                this.Invoke(new Action(() => tbTestsForm_Min.Text = tests.Select(x => x.Questions.Count()).Min().ToString()));
                this.Invoke(new Action(() => tbTestsForm_AVG.Text = tests.Select(x => x.Questions.Count()).Average().ToString()));
            });
        }
        //----------------------------------------------------------------------------
        #endregion Tests

        #region TestsExplorerForm 
        // LoadTestForm functional
        //-----------------------------------------------------------------------------
        DALTestingSystemDB.Test TestsExplorer_currTest;
        FormSelector TestsExplorerForm_selector = FormSelector.Active;
        private async void panelTestsExplorer_VisibleChanged(object sender, EventArgs e)
        {
            if (panelTestsExplorer.Visible == false) return;

            this.dgvTestsExplorerForm_Tests.SelectionChanged -= new System.EventHandler(this.dgvTestsExplorerForm_Tests_SelectionChanged);
            if (firstTimeTestsExplorer)
            {
                dgvTestsExplorerForm_Tests.Columns.Clear();
                await Task.Run(() => TestsExplorerForm_LoadTestsBySelector(TestsExplorerForm_selector));
                dgvTestsExplorerForm_Tests.DataSource = bsTestsExplorerForm_Tests;
                for (int i = 4; i <= 9; i++)
                    if (i != 6 && i != 7)
                        dgvTestsExplorerForm_Tests.Columns[i].Visible = false;
                dgvTestsExplorerForm_Tests.Columns[0].Width = 50;
                dgvTestsExplorerForm_Tests.Columns[1].Width = 260;
                dgvTestsExplorerForm_Tests.Columns[2].Width = 170;
                dgvTestsExplorerForm_Tests.Columns[3].Width = 260;
                dgvTestsExplorerForm_Tests.Columns[6].Width = 80;
                dgvTestsExplorerForm_Tests.Columns[7].Width = 120;
                dgvTestsExplorerForm_Tests.Columns[6].HeaderText = "Archived";
                dgvTestsExplorerForm_Tests.Columns[7].HeaderText = "Loaded date";

                tbTestsExplorerForm_FindById.InitHint("Id...");
                tbTestsExplorerForm_FindByTitle.InitHint("Title...");
                tbTestsExplorerForm_FindByAuthor.InitHint("Author...");

                firstTimeTestsExplorer = false;
            }
            else
            {
                await Task.Run(() => TestsExplorerForm_LoadTestsBySelector(TestsExplorerForm_selector));
                tbTestsExplorerForm_FindById.Text = tbTestsExplorerForm_FindByTitle.Text = tbTestsExplorerForm_FindByAuthor.Text = string.Empty;
            }
            dgvTestsExplorerForm_Tests_WhenRowGetSelect();
            this.dgvTestsExplorerForm_Tests.SelectionChanged += new System.EventHandler(this.dgvTestsExplorerForm_Tests_SelectionChanged);

        }

        private void dgvTestsExplorerForm_Tests_WhenRowGetSelect()
        {
            if (dgvTestsExplorerForm_Tests.Rows.Count == 0 || dgvTestsExplorerForm_Tests.SelectedRows.Count == 0)
            {
                toolStripButtonTestLookup.Enabled = toolStripButtonTestDelete.Enabled = false;
            }
            else
            {
                toolStripButtonTestLookup.Enabled = true;
                TestsExplorer_currTest = dgvTestsExplorerForm_Tests.CurrentRow.DataBoundItem as DALTestingSystemDB.Test;
                toolStripButtonTestDelete.Enabled = !TestsExplorer_currTest.UserTests.Any();
            }
        }

        private void dgvTestsExplorerForm_Tests_SelectionChanged(object sender, EventArgs e)
        {
            dgvTestsExplorerForm_Tests_WhenRowGetSelect();
        }

        private DataGridViewRow GetRow_Test(DataGridView dgv, DALTestingSystemDB.Test test)
        {
            return dgv.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["Id"].Value.Equals(test.Id))
                    .FirstOrDefault();
        }

        private async void TestsExplorerForm_RadioButtton_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (!radioButton.Checked) return;
            switch (radioButton.Name)
            {
                case "rbTestsExplorerForm_Actual":
                    TestsExplorerForm_selector = FormSelector.Active;
                    break;
                case "rbTestsExplorerForm_Archived":
                    TestsExplorerForm_selector = FormSelector.Archived;
                    break;
                case "rbTestsExplorerForm_All":
                    TestsExplorerForm_selector = FormSelector.All;
                    break;
            }
            await Task.Run(() => TestsExplorerForm_LoadTestsBySelector(TestsExplorerForm_selector));
        }

        private void TestsExplorerForm_LoadTestsBySelector(FormSelector selector)
        {
            switch (selector)
            {
                case FormSelector.Active:
                    this.Invoke(new Action(() => bsTestsExplorerForm_Tests.DataSource = Globals.repoTest.FindAll(x => !x.IsArchived)));
                    break;
                case FormSelector.Archived:
                    this.Invoke(new Action(() => bsTestsExplorerForm_Tests.DataSource = Globals.repoTest.FindAll(x => x.IsArchived)));
                    break;
                case FormSelector.All:
                    this.Invoke(new Action(() => bsTestsExplorerForm_Tests.DataSource = Globals.repoTest.GetAll()));
                    break;
            }
        }

        private void toolStripButtonAddTest_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode = treeView1.Nodes.Find("NodeLoadTest", true)[0];
            treeView1.Focus();
        }

        private async void toolStripButtonTestLookup_Click(object sender, EventArgs e)
        {
            TestLookupForm testLookupForm = new TestLookupForm(ref TestsExplorer_currTest);
            if(testLookupForm.ShowDialog() == DialogResult.OK)
            {
                await Task.Run(() => Globals.repoTest.Update(TestsExplorer_currTest));
                this.dgvTestsExplorerForm_Tests.SelectionChanged -= new System.EventHandler(this.dgvTestsExplorerForm_Tests_SelectionChanged);
                {
                    await Task.Run(() => TestsExplorerForm_LoadTestsBySelector(TestsExplorerForm_selector));
                    DataGridViewRow row = GetRow_Test(dgvTestsExplorerForm_Tests, TestsExplorer_currTest);
                    if(row != null)
                        dgvTestsExplorerForm_Tests.CurrentCell = dgvTestsExplorerForm_Tests.Rows[row.Index].Cells[0];                   
                }
                dgvTestsExplorerForm_Tests_WhenRowGetSelect();
                this.dgvTestsExplorerForm_Tests.SelectionChanged += new System.EventHandler(this.dgvTestsExplorerForm_Tests_SelectionChanged);
            }            
        }
        private void dgvTestsExplorerForm_Tests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                toolStripButtonTestLookup_Click(sender, e);
            }
        }

        private async void toolStripButtonTestDelete_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Delete selected test?", "Test server", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.Cancel)
                return;

            await Task.Run(() =>
            {
                Globals.repoTest.Remove(TestsExplorer_currTest);
                TestsExplorerForm_LoadTestsBySelector(TestsExplorerForm_selector);
            });
        }

        private void tbTestsExplorerForm_Find_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!tb.Text.Any()) return;
            string columnName = string.Empty;
            switch(tb.Name)
            {
                case "tbTestsExplorerForm_FindById":
                    columnName = "Id";
                    break;
                case "tbTestsExplorerForm_FindByTitle":
                    columnName = "Title";
                    break;
                case "tbTestsExplorerForm_FindByAuthor":
                    columnName = "Author";
                    break;
            }

            DataGridViewRow row = dgvTestsExplorerForm_Tests.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells[columnName].Value.ToString().ToLower().StartsWith(tb.Text.ToLower()))
                .FirstOrDefault();

            if (row != null)
            {
                this.dgvTestsExplorerForm_Tests.SelectionChanged -= new System.EventHandler(this.dgvTestsExplorerForm_Tests_SelectionChanged);
                {
                    dgvTestsExplorerForm_Tests.CurrentCell = dgvTestsExplorerForm_Tests.Rows[row.Index].Cells[0];
                    dgvTestsExplorerForm_Tests_WhenRowGetSelect();
                }
                this.dgvTestsExplorerForm_Tests.SelectionChanged += new System.EventHandler(this.dgvTestsExplorerForm_Tests_SelectionChanged);
            }
        }
        //-----------------------------------------------------------------------------
        #endregion TestsExplorerForm

        #region ReviewTestResults
        //-----------------------------------------------------------------------------
        FormSelector ReviewForm_selector = FormSelector.All;
        User ReviewForm_currUser;
        DALTestingSystemDB.Test ReviewForm_currTest;
        UserTest ReviewForm_currUserTest;

        private async void panelReviewTestResults_VisibleChanged(object sender, EventArgs e)
        {
            if (panelReviewTestResults.Visible == false) return;

            this.dgvReviewForm_UserTests.SelectionChanged -= new System.EventHandler(this.dgvReviewForm_UserTests_SelectionChanged);
            if (firstTimeReviewPassedTests)
            {
                dgvReviewForm_UserTests.Columns.Clear();
                await Task.Run(() => ReviewForm_LoadUserTestsBySelector(ReviewForm_selector));
                dgvReviewForm_UserTests.DataSource = bsReviewForm_UserTests;
                
                dgvReviewForm_UserTests.Columns[6].Visible = false;
                dgvReviewForm_UserTests.Columns[7].Visible = false;
                dgvReviewForm_UserTests.Columns[0].Width = 50;
                dgvReviewForm_UserTests.Columns[1].Width = 250;
                dgvReviewForm_UserTests.Columns[2].Width = 360;
                dgvReviewForm_UserTests.Columns[3].Width = 80;
                dgvReviewForm_UserTests.Columns[4].Width = 80;
                dgvReviewForm_UserTests.Columns[5].Width = 120;
                dgvReviewForm_UserTests.Columns[3].HeaderText = "Grade";
                dgvReviewForm_UserTests.Columns[4].HeaderText = "Passed";
                dgvReviewForm_UserTests.Columns[5].HeaderText = "Taked date";

                firstTimeReviewPassedTests = false;
            }
            else
            {
                await Task.Run(() => ReviewForm_LoadUserTestsBySelector(ReviewForm_selector));
            }
            dgvReviewForm_Tests_WhenRowGetSelect();
            this.dgvReviewForm_UserTests.SelectionChanged += new System.EventHandler(this.dgvReviewForm_UserTests_SelectionChanged);
        }

        private void dgvReviewForm_Tests_WhenRowGetSelect()
        {
            if (dgvReviewForm_UserTests.Rows.Count == 0 || dgvReviewForm_UserTests.SelectedRows.Count == 0)
            {
                toolStripButtonLookupTest.Enabled = false;
                ReviewForm_currUserTest = null;
            }
            else
            {
                toolStripButtonLookupTest.Enabled = true;
                ReviewForm_currUserTest = dgvReviewForm_UserTests.CurrentRow.DataBoundItem as UserTest;
            }
        }

        private void dgvReviewForm_UserTests_SelectionChanged(object sender, EventArgs e)
        {
            dgvReviewForm_Tests_WhenRowGetSelect();
        }

        private FormSelector ReviewForm_SetSelector()
        {
            if (!tbReviewForm_User.Text.Any() && !tbReviewForm_Test.Text.Any())
                return FormSelector.All;
            if (tbReviewForm_User.Text.Any() && !tbReviewForm_Test.Text.Any())
                return FormSelector.ByUser;
            if (!tbReviewForm_User.Text.Any() && tbReviewForm_Test.Text.Any())
                return FormSelector.ByTest;
            return FormSelector.ByUserAndTest;
        }

        private async void btnReviewForm_SelectUser_Click(object sender, EventArgs e)
        {
            if(btnReviewForm_SelectUser.Text == "X")
            {
                tbReviewForm_User.Text = String.Empty;
                ReviewForm_selector = ReviewForm_SetSelector();
                await Task.Run(() => ReviewForm_LoadUserTestsBySelector(ReviewForm_selector));
                btnReviewForm_SelectUser.Text = "• • •";
                return;
            }

            List<User> users = await Task.Run(() => Globals.repoUser.GetAll().ToList());
            SelectUserForm userForm = new SelectUserForm(users, OpenMode.SelectUser);
            if (userForm.ShowDialog() == DialogResult.OK)
            {
                ReviewForm_currUser = userForm.User;
                tbReviewForm_User.Text = ReviewForm_currUser.ToString();
                ReviewForm_selector = ReviewForm_SetSelector();
                await Task.Run(() => ReviewForm_LoadUserTestsBySelector(ReviewForm_selector));
                btnReviewForm_SelectUser.Text = "X";
            }
        }

        private async void btnReviewForm_SelectTest_Click(object sender, EventArgs e)
        {
            if (btnReviewForm_SelectTest.Text == "X")
            {
                tbReviewForm_Test.Text = String.Empty;
                ReviewForm_selector = ReviewForm_SetSelector();
                await Task.Run(() => ReviewForm_LoadUserTestsBySelector(ReviewForm_selector));
                btnReviewForm_SelectTest.Text = "• • •";
                return;
            }

            List<DALTestingSystemDB.Test> tests = await Task.Run(() => Globals.repoTest.GetAll().ToList());
            SelectTestForm userForm = new SelectTestForm(tests, OpenMode.SelectTest);
            if (userForm.ShowDialog() == DialogResult.OK)
            {
                ReviewForm_currTest = userForm.Test;
                tbReviewForm_Test.Text = ReviewForm_currTest.ToString();
                ReviewForm_selector = ReviewForm_SetSelector();
                await Task.Run(() => ReviewForm_LoadUserTestsBySelector(ReviewForm_selector));
                btnReviewForm_SelectTest.Text = "X";
            }
        }

        private void ReviewForm_LoadUserTestsBySelector(FormSelector selector)
        {
            switch (selector)
            {
                case FormSelector.All:
                    this.Invoke(new Action(() => bsReviewForm_UserTests.DataSource = Globals.repoUserTest
                        .FindAll(x => x.IsTaked)));
                    break;
                case FormSelector.ByUser:
                    this.Invoke(new Action(() => bsReviewForm_UserTests.DataSource = Globals.repoUserTest
                        .FindAll(x => x.IsTaked && x.User.Id == ReviewForm_currUser.Id)));
                    break;
                case FormSelector.ByTest:
                    this.Invoke(new Action(() => bsReviewForm_UserTests.DataSource = Globals.repoUserTest
                        .FindAll(x => x.IsTaked && x.Test.Id == ReviewForm_currTest.Id)));
                    break;
                case FormSelector.ByUserAndTest:
                    this.Invoke(new Action(() => bsReviewForm_UserTests.DataSource = Globals.repoUserTest
                        .FindAll(x => x.IsTaked && x.User.Id == ReviewForm_currUser.Id && x.Test.Id == ReviewForm_currTest.Id)));
                    break;
            }
            bsReviewForm_UserTests.ResetBindings(false);
        }

        private void toolStripButtonLookupTest_Click(object sender, EventArgs e)
        {
            UserTestLookupForm userTestLookupForm = new UserTestLookupForm(ReviewForm_currUserTest);
            userTestLookupForm.ShowDialog();
        }

        private void dgvReviewForm_UserTests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                toolStripButtonLookupTest_Click(sender, e);
            }
        }

        private async void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            btnReviewForm_SelectUser.Enabled = btnReviewForm_SelectTest.Enabled = toolStripButtonLookupTest.Enabled = false;
            await Task.Run(() => ReviewForm_LoadUserTestsBySelector(ReviewForm_selector));
            btnReviewForm_SelectUser.Enabled = btnReviewForm_SelectTest.Enabled = true;
            dgvReviewForm_Tests_WhenRowGetSelect();
        }
        #endregion ReviewTestResults



        private void originalSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1277, 723);
        }


















        //dgvGroupsForm_Groups.Columns[0].Width = (int)(dgvGroupsForm_Groups.Width * 0.1);
        // last - dgvGrd.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


    }
}
