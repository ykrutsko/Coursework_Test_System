using DALTestingSystemDB;
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

namespace TestServer
{
    public partial class MainForm : Form
    {
        Panel activePanel;
        bool flagTestsExplorer = false;
        bool firstTimeUsers = true;
        bool firstTimeGroups = true;

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
                Globals.repoFolder = Globals.work.Repository<Folder>();
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
                case "NodeReviwPassedTests":
                    activePanel = panelReviewPassedTests;
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
            }
            activePanel.Dock = DockStyle.Fill;
            activePanel.Visible = true;
        }
        #endregion Main

        #region UsersForm
        //----------------------------------------------------------------------------
        UsersFormSelector selector = UsersFormSelector.Active;
        private async void panelUsers_VisibleChanged(object sender, EventArgs e)
        {
            if (panelUsers.Visible == false)
                return;

            if (firstTimeUsers)
            {
                selector = UsersFormSelector.Active;
                await Task.Run(() => UsersForm_LoadUsersBySelector(selector));
                UsersForm_LoadUsersBySelector(selector);
                dgvUsersForm_Users.DataSource = bsUsersForm_Users;
                dgvUsersForm_Users.Columns[4].Visible = false;
                dgvUsersForm_Users.Columns[7].Visible = false;
                dgvUsersForm_Users.Columns[8].Visible = false;
                dgvUsersForm_Users.Columns[10].Visible = false;

                dgvUsersForm_Users.Columns[0].Width = 50;
                dgvUsersForm_Users.Columns[1].Width = 145;
                dgvUsersForm_Users.Columns[2].Width = 145;
                dgvUsersForm_Users.Columns[3].Width = 120;
                dgvUsersForm_Users.Columns[5].Width = 280;
                dgvUsersForm_Users.Columns[6].Width = 80;
                dgvUsersForm_Users.Columns[9].Width = 120;

                dgvUsersForm_Users.Columns[1].HeaderText = "First name";
                dgvUsersForm_Users.Columns[2].HeaderText = "Last name";
                dgvUsersForm_Users.Columns[6].HeaderText = "Is admin";
                dgvUsersForm_Users.Columns[9].HeaderText = "Register date";
                firstTimeUsers = false;
            }
            else
            {
                await Task.Run(() => UsersForm_LoadUsersBySelector(selector));
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
                    await Task.Run(() => UsersForm_LoadUsersBySelector(selector));
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
                    await Task.Run(() => UsersForm_LoadUsersBySelector(selector));
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
                    await Task.Run(() => UsersForm_LoadUsersBySelector(selector));
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
                UsersForm_LoadUsersBySelector(selector);
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
            switch (radioButton.Name)
            {
                case "rbActive":
                    selector = UsersFormSelector.Active;
                    break;
                case "rbArhived":
                    selector = UsersFormSelector.Archived;
                    break;
                case "rbAll":
                    selector = UsersFormSelector.All;
                    break;
            }
            await Task.Run(() => UsersForm_LoadUsersBySelector(selector));
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
                selector = UsersFormSelector.None;
                await Task.Run(() => UsersForm_LoadUsersBySelector(selector));
                cbUsersFormGroup.Items.AddRange(await Task.Run(() => Globals.repoGroup.GetAll().ToArray()));
            }
        }

        private async void cbUsersFormGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUsersFormGroup.SelectedIndex != -1)
            {
                selector = UsersFormSelector.ByGroup;
                await Task.Run(() => UsersForm_LoadUsersBySelector(selector));
            }
        }

        private void UsersForm_LoadUsersBySelector(UsersFormSelector selector)
        {
            switch (selector)
            {
                case UsersFormSelector.Active:
                    this.Invoke(new Action(() => bsUsersForm_Users.DataSource = Globals.repoUser.FindAll(x => !x.IsArhived)));
                    break;
                case UsersFormSelector.Archived:
                    this.Invoke(new Action(() => bsUsersForm_Users.DataSource = Globals.repoUser.FindAll(x => x.IsArhived)));
                    break;
                case UsersFormSelector.All:
                    this.Invoke(new Action(() => bsUsersForm_Users.DataSource = Globals.repoUser.GetAll()));
                    break;
                case UsersFormSelector.ByGroup:
                    this.Invoke(new Action(() => bsUsersForm_Users.DataSource = Globals.repoGroup.FindById((cbUsersFormGroup.SelectedItem as Group).Id).Users));
                    break;
                case UsersFormSelector.None:
                    this.Invoke(new Action(() => bsUsersForm_Users.Clear()));
                    break;
            }
        }
        //----------------------------------------------------------------------------
        #endregion UsersForm

        #region GroupsForm
        //----------------------------------------------------------------------------
        Group GroupsForm_currGroup;
        User GroupsForm_currUser;
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
                bsGroupsForm_Users.DataSource = await Task.Run(() => Globals.repoGroup.FindById(GroupsForm_currGroup.Id).Users);
                dgvGroupsForm_Users.DataSource = bsGroupsForm_Users;
                for (int i = 4; i <= 10; i++)
                    dgvGroupsForm_Users.Columns[i].Visible = false;
                dgvGroupsForm_Users.Columns[0].Width = 50;
                dgvGroupsForm_Users.Columns[1].Width = 120;
                dgvGroupsForm_Users.Columns[2].Width = 120;
                dgvGroupsForm_Users.Columns[3].Width = 100;
                GroupsForm_currUser = dgvGroupsForm_Users.CurrentRow.DataBoundItem as User;
                firstTimeGroups = false;                
            }
            else
            {
                dgvGroupsForm_Groups_WhenRowGetSelect();
            }
            this.dgvGroupsForm_Groups.SelectionChanged += new System.EventHandler(this.dgvGroupsForm_Groups_SelectionChanged);
        }

        private async void dgvGroupsForm_Groups_WhenRowGetSelect()
        {
            GroupsForm_currGroup = dgvGroupsForm_Groups.CurrentRow.DataBoundItem as DALTestingSystemDB.Group;
            GroupsForm_GroupsMenuEnDis();
            bsGroupsForm_Users.DataSource = await Task.Run(() => Globals.repoGroup.FindById(GroupsForm_currGroup.Id).Users);
            bsGroupsForm_Users.ResetBindings(false);
        }

        private DataGridViewRow GetRow_Group(DataGridView dgv, DALTestingSystemDB.Group group)
        {
            return dgv.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["Id"].Value.Equals(group.Id))
                    .FirstOrDefault();
        }

        private void dgvGroupsForm_Groups_SelectionChanged(object sender, EventArgs e)
        {
            dgvGroupsForm_Groups_WhenRowGetSelect();
        }

        private void GroupsForm_GroupsMenuEnDis()
        {
            if(dgvGroupsForm_Groups.SelectedCells.Count > 0)
            {
                toolStripButtonAddGroupByCopy.Enabled = true;
                toolStripButtonEditGroup.Enabled = true;
                if((dgvGroupsForm_Groups.CurrentRow.DataBoundItem as DALTestingSystemDB.Group).Id == 1)
                    toolStripButtonDeleteGroup.Enabled = false;
                else
                    toolStripButtonDeleteGroup.Enabled = true;
            }
            else
            {
                toolStripButtonAddGroupByCopy.Enabled = false;
                toolStripButtonEditGroup.Enabled = false;
                toolStripButtonDeleteGroup.Enabled = false;
            }
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
        //----------------------------------------------------------------------------
        #endregion Groups

        #region LoadTestForm functional
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
            dgvLoadTestForm_Questions.Columns[0].Width = 500;
            dgvLoadTestForm_Questions.Columns[1].Width = 90;
        }
        void LoadTestForm_CleanDGVAnswers()
        {
            bsLoadTestForm_Answers.DataSource = null;
            dgvLoadTestForm_Answers.Columns.Clear();
            dgvLoadTestForm_Answers.Columns.Add("Answer", "Answer");
            dgvLoadTestForm_Answers.Columns.Add("Right", "Is right");
            dgvLoadTestForm_Answers.Columns[0].Width = 290;
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

                dgvLoadTestForm_Questions.Columns[0].Width = 500;
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

            dgvLoadTestForm_Answers.Columns[0].Width = 290;
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
                test.IsDeletable = true;
                test.Folder = Globals.repoFolder.FindById(1);
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

        #region TestsExplorerForm functional
        // LoadTestForm functional
        //-----------------------------------------------------------------------------
        private async void panelTestsExplorer_VisibleChanged(object sender, EventArgs e)
        {
            if (panelTestsExplorer.Visible == false)
                return;

            if (!flagTestsExplorer)
            {
                await Task.Run(() => {
                    bsTestsExplorerForm_Folder1.DataSource = Globals.repoFolder.GetAll();
                    bsTestsExplorerForm_Folder2.DataSource = Globals.repoFolder.GetAll();
                    bsTestsExplorerForm_Test1.DataSource = Globals.repoTest.FindAll(x => x.Folder.Id == 1);
                    bsTestsExplorerForm_Test2.DataSource = Globals.repoTest.FindAll(x => x.Folder.Id == 1);
                });

                //Folder1
                dgvTestsExplorerForm_Folder1.DataSource = bsTestsExplorerForm_Folder1;
                dgvTestsExplorerForm_Folder1.Columns[0].Visible = false;
                dgvTestsExplorerForm_Folder1.Columns[1].HeaderText = "Name";
                dgvTestsExplorerForm_Folder1.Columns[1].Width = 190;

                dgvTestsExplorerForm_Folder1.Columns[2].Width = 230;
                dgvTestsExplorerForm_Folder1.Columns[2].HeaderText = "Description";

                dgvTestsExplorerForm_Folder1.Columns[3].Visible = false;
                dgvTestsExplorerForm_Folder1.Columns[4].Visible = false;
                dgvTestsExplorerForm_Folder1.Columns[5].Visible = false;
                dgvTestsExplorerForm_Folder1.CurrentCell = dgvTestsExplorerForm_Folder1.Rows[0].Cells[1];

                //Folder2
                dgvTestsExplorerForm_Folder2.DataSource = bsTestsExplorerForm_Folder2;
                dgvTestsExplorerForm_Folder2.Columns[0].Visible = false;
                dgvTestsExplorerForm_Folder2.Columns[1].HeaderText = "Name";
                dgvTestsExplorerForm_Folder2.Columns[1].Width = 190;

                dgvTestsExplorerForm_Folder2.Columns[2].Width = 230;
                dgvTestsExplorerForm_Folder2.Columns[2].HeaderText = "Description";

                dgvTestsExplorerForm_Folder2.Columns[3].Visible = false;
                dgvTestsExplorerForm_Folder2.Columns[4].Visible = false;
                dgvTestsExplorerForm_Folder2.Columns[5].Visible = false;
                dgvTestsExplorerForm_Folder2.CurrentCell = dgvTestsExplorerForm_Folder2.Rows[0].Cells[1];

                // Test 1
                dgvTestsExplorerForm_Test1.DataSource = bsTestsExplorerForm_Test1;
                dgvTestsExplorerForm_Test1.Columns[0].Visible = false;
                dgvTestsExplorerForm_Test1.Columns[1].HeaderText = "Name";
                dgvTestsExplorerForm_Test1.Columns[1].Width = 190;
                dgvTestsExplorerForm_Test1.Columns[2].HeaderText = "Author";
                dgvTestsExplorerForm_Test1.Columns[2].Width = 120;

                dgvTestsExplorerForm_Test1.Columns[3].Visible = false;
                dgvTestsExplorerForm_Test1.Columns[4].Visible = false;
                dgvTestsExplorerForm_Test1.Columns[5].Visible = false;
                dgvTestsExplorerForm_Test1.Columns[6].Visible = false;
                dgvTestsExplorerForm_Test1.Columns[7].Visible = false;

                dgvTestsExplorerForm_Test1.Columns[8].HeaderText = "Load date";
                dgvTestsExplorerForm_Test1.Columns[8].Width = 110;
                dgvTestsExplorerForm_Test1.Columns[9].Visible = false;
                dgvTestsExplorerForm_Test1.Columns[10].Visible = false;
                dgvTestsExplorerForm_Test1.Columns[11].Visible = false;


                // Test 2
                dgvTestsExplorerForm_Test2.DataSource = bsTestsExplorerForm_Test2;
                dgvTestsExplorerForm_Test2.Columns[0].Visible = false;
                dgvTestsExplorerForm_Test2.Columns[1].HeaderText = "Name";
                dgvTestsExplorerForm_Test2.Columns[1].Width = 190;
                dgvTestsExplorerForm_Test2.Columns[2].HeaderText = "Author";
                dgvTestsExplorerForm_Test2.Columns[2].Width = 120;

                dgvTestsExplorerForm_Test2.Columns[3].Visible = false;
                dgvTestsExplorerForm_Test2.Columns[4].Visible = false;
                dgvTestsExplorerForm_Test2.Columns[5].Visible = false;
                dgvTestsExplorerForm_Test2.Columns[6].Visible = false;
                dgvTestsExplorerForm_Test2.Columns[7].Visible = false;

                dgvTestsExplorerForm_Test2.Columns[8].HeaderText = "Load date";
                dgvTestsExplorerForm_Test2.Columns[8].Width = 110;
                dgvTestsExplorerForm_Test2.Columns[9].Visible = false;
                dgvTestsExplorerForm_Test2.Columns[10].Visible = false;
                dgvTestsExplorerForm_Test2.Columns[11].Visible = false;

                flagTestsExplorer = true;
            }
            else
            {
                //bsTestsExplorerForm_Folder1.ResetBindings(false);
                //bsTestsExplorerForm_Folder2.ResetBindings(false);
                //bsTestsExplorerForm_Test1.ResetBindings(false);
                //bsTestsExplorerForm_Test2.ResetBindings(false);

            }
            dgvTestsExplorerForm_Test1.ClearSelection();
            dgvTestsExplorerForm_Test2.ClearSelection();
        }

        private void dgvTestsExplorerForm_Folder1_SelectionChanged(object sender, EventArgs e)
        {
            Folder folder = dgvTestsExplorerForm_Folder1.CurrentRow.DataBoundItem as Folder;
            bsTestsExplorerForm_Test1.DataSource = Globals.repoTest.FindAll(x => x.Folder.Id == folder.Id);
            dgvTestsExplorerForm_Test1.ClearSelection();
        }

        private void dgvTestsExplorerForm_Folder2_SelectionChanged(object sender, EventArgs e)
        {
            Folder folder = dgvTestsExplorerForm_Folder2.CurrentRow.DataBoundItem as Folder;
            bsTestsExplorerForm_Test2.DataSource = Globals.repoTest.FindAll(x => x.Folder.Id == folder.Id);
            dgvTestsExplorerForm_Test2.ClearSelection();
        }

        private void dgvTestsExplorerForm_Test1_SelectionChanged(object sender, EventArgs e)
        {
            toolStripButtonMoveR.Enabled = dgvTestsExplorerForm_Test1.SelectedRows.Count != 0;
            //dgvTestsExplorerForm_Folder1_SelectionChanged(sender, e);
        }

        private void dgvTestsExplorerForm_Test2_SelectionChanged(object sender, EventArgs e)
        {
            toolStripButtonMoveL.Enabled = dgvTestsExplorerForm_Test2.SelectedRows.Count != 0;
        }

        //Move R
        private void toolStripButtonMoveR_Click(object sender, EventArgs e)
        {
            DALTestingSystemDB.Test test = dgvTestsExplorerForm_Test1.CurrentRow.DataBoundItem as DALTestingSystemDB.Test;
            test.Folder = dgvTestsExplorerForm_Folder2.CurrentRow.DataBoundItem as Folder;
            Globals.repoTest.Update(test);
            bsTestsExplorerForm_Test1.ResetBindings(false);
        }

        //Move L
        private void toolStripButtonMoveL_Click(object sender, EventArgs e)
        {

        }













































        //-----------------------------------------------------------------------------
        #endregion TestsExplorerForm functional







    }
}
