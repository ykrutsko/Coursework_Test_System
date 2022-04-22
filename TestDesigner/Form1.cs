using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLib;

namespace TestDesigner
{
    enum NameType { FileName, TestName}

    public partial class MainForm : Form
    {
        string currFilePath = string.Empty;
        Test currTest;
        bool IsTestChanged = false;
      

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewTest();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!СonfirmedActionWithDialogs())
                e.Cancel = true;
        }

        // Main menu
        //---------------------------------------------------------------------
        // New
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            if(СonfirmedActionWithDialogs())
                NewTest();
        }

        // Open
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (СonfirmedActionWithDialogs())
                OpenTest();
        }

        // Save
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveTest();
        }

        //Exit
        private void exitStripButton_Click_1(object sender, EventArgs e)
        {
            if (СonfirmedActionWithDialogs())
                Application.Exit();
        }
        //---------------------------------------------------------------------


        // Helpfull
        //---------------------------------------------------------------------
        void SetCleanMainForm()
        {
            tbAuthor.Text = String.Empty;
            tbTitle.Text = String.Empty;
            tbDescription.Text = String.Empty;
            tbInfo.Text = String.Empty;
            pictureBox.Image = null;
            tbCountOfQuestions.Text = "0";
            tbMaxPointsForTest.Text = "0";
            numericUpDownMinPass.Value = 0;

            SetCleanDataGridViewQuestions();
            SetCleaDataGridViewAnswers();
        }

        void SetCleanDataGridViewQuestions()
        {
            dataGridViewQuestions.Columns.Clear();
            dataGridViewQuestions.Columns.Add("Question", "Question");
            dataGridViewQuestions.Columns.Add("Point", "Point");
            dataGridViewQuestions.Columns[0].Width = 500;
            dataGridViewQuestions.Columns[1].Width = 90;
        }

        void SetCleaDataGridViewAnswers()
        {
            dataGridViewAnswers.Columns.Clear();
            dataGridViewAnswers.Columns.Add("Answer", "Answer");
            dataGridViewAnswers.Columns.Add("Right", "Is right");
            dataGridViewAnswers.Columns[0].Width = 290;
            dataGridViewAnswers.Columns[1].Width = 90;
        }

        void FillForm()
        {
            tbAuthor.Text = currTest.Author;
            tbTitle.Text = currTest.Title;
            tbDescription.Text = currTest.Description;
            tbInfo.Text = currTest.Info;
            tbCountOfQuestions.Text = currTest.Questions.Count.ToString();
            tbMaxPointsForTest.Text = currTest.Questions.Select(x => x.Points).Sum().ToString();
            //if(!String.IsNullOrEmpty(currTest.Img))
            //    pictureBox.Image = ImgConverter.Base64StringToBitmap(currTest.Img);
            numericUpDownMinPass.Value = currTest.PassPercent;
            if (currTest.Questions.Any())
            {
                FillDataGridViewQuestions();
                FillDataGridViewAnswers();
            }
            else
            {
                SetCleanDataGridViewQuestions();
                SetCleaDataGridViewAnswers();
            }
        }

        void FillDataGridViewQuestions()
        {
            dataGridViewQuestions.Columns.Clear();
            dataGridViewQuestions.DataSource = null;
            dataGridViewQuestions.DataSource = currTest.Questions;
            dataGridViewQuestions.Columns[0].Width = 500;
            dataGridViewQuestions.Columns[0].HeaderText = "Question";
            dataGridViewQuestions.Columns[1].Width = 90;
            dataGridViewQuestions.Columns[1].HeaderText = "Point";
            //dataGridViewQuestions.Columns[2].Visible = false;
            dataGridViewQuestions.Rows[0].Selected = true;
        }

        void FillDataGridViewAnswers()
        {
            dataGridViewAnswers.Columns.Clear();
            dataGridViewAnswers.DataSource = null;
            dataGridViewAnswers.DataSource = currTest.Questions[0].Answers;
            dataGridViewAnswers.Columns[0].Width = 290;
            dataGridViewAnswers.Columns[0].HeaderText = "Answer";
            dataGridViewAnswers.Columns[1].Width = 90;
            dataGridViewAnswers.Columns[1].HeaderText = "Is right";
            //dataGridViewAnswers.Columns[2].Visible = false;
        }

        // Request to save the test
        bool СonfirmedActionWithDialogs()
        {
            if (IsTestChanged)
            {
                var dialog = MessageBox.Show(
                    "Save changes to current test?",
                    currFilePath.Any() ? Path.GetFileName(currFilePath) : "Untitled",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
                if (dialog == DialogResult.Cancel || dialog == DialogResult.Yes && !SaveTest())
                    return false;
            }
            IsTestChanged = false;
            return true;
        }

        // Create New
        void NewTest()
        {
            currTest = new Test();
            currFilePath = String.Empty;
            SetCleanMainForm();
            IsTestChanged = false;
            WindowTitleText();
            WindowFuterText();
            tbTitle.Select();
        }

        // Open Test
        bool OpenTest()
        {
            openFileDialogTest.Filter = "XML files (*.xml)|*.xml";
            openFileDialogTest.FilterIndex = 1;
            openFileDialogTest.RestoreDirectory = true;

            if (openFileDialogTest.ShowDialog() != DialogResult.OK)
                return false;

            currFilePath = openFileDialogTest.FileName;
            try
            {
                currTest = Serializer.Deserialize<Test>(File.ReadAllText(currFilePath));
            }
            catch (Exception ex)
            {
                throw ex;
            }

            FillForm();
            IsTestChanged = false;
            WindowTitleText();
            WindowFuterText();
            return true;
        }

        // Save Test
        bool SaveTest()
        {
            if (!tbTitle.Text.Any())
            {
                var tmpColor = tbTitle.BackColor;
                tbTitle.BackColor = Color.YellowGreen;
                tbTitle.Text = NameGenerator(NameType.TestName);
                tbTitle.Refresh();
                Thread.Sleep(1000);
                tbTitle.BackColor = tmpColor;
                tbTitle.Refresh(); 
            }                

            if (!currFilePath.Any())
            {
                saveFileDialogTest.Filter = "XML files (*.xml)|*.xml";
                saveFileDialogTest.FilterIndex = 1;
                saveFileDialogTest.RestoreDirectory = true;
                saveFileDialogTest.FileName = NameGenerator(NameType.FileName);

                if (saveFileDialogTest.ShowDialog() != DialogResult.OK)
                    return false;

                currFilePath = saveFileDialogTest.FileName;                   
            }

            if(IsTestChanged)
            {
                currTest.Title = tbTitle.Text;
                currTest.Author = tbAuthor.Text;
                currTest.Description = tbDescription.Text;
                currTest.Info = tbInfo.Text;
                currTest.PassPercent = (int)numericUpDownMinPass.Value;
            }

            try
            {
                File.WriteAllText(currFilePath, Serializer.Serialize<Test>(currTest));
            }
            catch (Exception ex)
            {
                throw ex;
            }

            IsTestChanged = false;
            WindowTitleText();
            WindowFuterText();
            return true;
        }

        void WindowTitleText()
        {
            string first = IsTestChanged? "*" : string.Empty;
            string second = currFilePath == string.Empty? "Untitled" : Path.GetFileName(currFilePath);
            string third = " - Test constructor";
            this.Text = new StringBuilder(first + second + third).ToString();
        }

        void WindowFuterText()
        {
            toolStripStatusLabel1.Text = currFilePath == string.Empty? "Current Test not saved yet..." : currFilePath;
        }

        string NameGenerator(NameType nameType)
        {
            if(nameType == NameType.FileName)
                return "Test " + DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss");
            return "Test " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            IsTestChanged = true;
            WindowTitleText();
        }

        private void btnModifyQuestion_Click(object sender, EventArgs e)
        {
            ModifyForm modifyForm = new ModifyForm(currTest.Questions);
            if(modifyForm.ShowDialog() == DialogResult.OK)
            {
                currTest.Questions = modifyForm.Questions;
                FillForm();
            }
        }


        // Work with Questions

    }
}
