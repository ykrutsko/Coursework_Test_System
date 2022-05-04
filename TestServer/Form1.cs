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
        GenericUnitOfWork work; 
        IGenericRepository<User> repoUser;
        IGenericRepository<Group> repoGroup;
        IGenericRepository<Folder> repoFolder;
        IGenericRepository<DALTestingSystemDB.Test> repoTest;
        IGenericRepository<DALTestingSystemDB.Question> repoQuestion;
        IGenericRepository<DALTestingSystemDB.Answer> repoAnswer;
        IGenericRepository<UserTest> repoUserTest;
        IGenericRepository<UserAnswer> repoUserAnswer;
        Panel activePanel;

        bool flagTestsExplorer = false;
        bool flagUsers = false;


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

        private void MainForm_Load(object sender, EventArgs e)
        {
            activePanel = panelGeneral;
            work = new GenericUnitOfWork(new TestSystemContext(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString));
            repoUser = work.Repository<User>();
            repoGroup = work.Repository<Group>();
            repoFolder = work.Repository<Folder>();
            repoTest = work.Repository<DALTestingSystemDB.Test>();
            repoQuestion = work.Repository<DALTestingSystemDB.Question>();
            repoAnswer = work.Repository<DALTestingSystemDB.Answer>();
            repoUserTest = work.Repository<UserTest>();
            repoUserAnswer = work.Repository<UserAnswer>();


            var a = repoUser.GetAll();

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

        #region Users
        private async void panelUsers_VisibleChanged(object sender, EventArgs e)
        {
            if (panelUsers.Visible == false)
                return;

            if (!flagUsers)
            {
                await Task.Run(() => {
                    bsUsersForm_Users.DataSource = repoUser.GetAll();
                });

                dgvUsersForm_Users.DataSource = bsUsersForm_Users;
                dgvUsersForm_Users.Columns[4].Visible = false;
                dgvUsersForm_Users.Columns[7].Visible = false;
                dgvUsersForm_Users.Columns[8].Visible = false;
                dgvUsersForm_Users.Columns[10].Visible = false;
                dgvUsersForm_Users.Columns[11].Visible = false;

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

                dgvUsersForm_Users.ClearSelection();
                flagUsers = true;
            }
        }

        private void toolStripButtonAddUser_Click(object sender, EventArgs e)
        {

        }



        #endregion
















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
                test.Folder = repoFolder.FindById(1);
                try
                {
                    repoTest.Add(test);
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
                    bsTestsExplorerForm_Folder1.DataSource = repoFolder.GetAll();
                    bsTestsExplorerForm_Folder2.DataSource = repoFolder.GetAll();
                    bsTestsExplorerForm_Test1.DataSource = repoTest.FindAll(x => x.Folder.Id == 1);
                    bsTestsExplorerForm_Test2.DataSource = repoTest.FindAll(x => x.Folder.Id == 1);
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
            bsTestsExplorerForm_Test1.DataSource = repoTest.FindAll(x => x.Folder.Id == folder.Id);
            dgvTestsExplorerForm_Test1.ClearSelection();
        }

        private void dgvTestsExplorerForm_Folder2_SelectionChanged(object sender, EventArgs e)
        {
            Folder folder = dgvTestsExplorerForm_Folder2.CurrentRow.DataBoundItem as Folder;
            bsTestsExplorerForm_Test2.DataSource = repoTest.FindAll(x => x.Folder.Id == folder.Id);
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
            repoTest.Update(test);
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
