using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLib;

namespace TestDesigner
{
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
            currTest = new Test();
            FillForm();
            tbAuthor.Select();
        }

        // Main menu
        //---------------------------------------------------------------------
        // New
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            if (IsTestChanged)
            {
                if (ShowSaveMessage() == DialogResult.Yes)
                {
                    if (!SaveTest())
                    {
                        return;
                    }
                }
                else if (ShowSaveMessage() == DialogResult.Cancel)
                    return;
            }
            CreateTest();
        }

        // Open
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (IsTestChanged)
            {
                if (ShowSaveMessage() == DialogResult.Yes)
                {
                    if (!SaveTest())
                    {
                        return;
                    }
                }
                else if (ShowSaveMessage() == DialogResult.Cancel)
                    return;
            }
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
            SaveTest();
        }
        //---------------------------------------------------------------------


        // Helpfull
        //---------------------------------------------------------------------
        void FillForm()
        {
            tbAuthor.Text = currTest.Author;
            tbTitle.Text = currTest.Title;
            tbDescription.Text = currTest.Description;
            tbInfo.Text = currTest.Info;
            tbCountOfQuestions.Text = currTest.Questions.Count.ToString();
            tbMaxPointsForTest.Text = currTest.Questions.Select(x => x.Points).Sum().ToString();
            numericUpDownMinPass.Value = currTest.PassPercent;
            dataGridViewQuestions.Columns.Clear();
            dataGridViewQuestions.DataSource = currTest.Questions;
            //{
            //    dataGridViewQuestions.Columns[0].Width = 500;
            //    dataGridViewQuestions.Columns[0].HeaderText = "Question";
            //    dataGridViewQuestions.Columns[1].Width = 90;
            //    dataGridViewQuestions.Columns[1].HeaderText = "Point";
            //    dataGridViewQuestions.Columns[2].Visible = false;
            //}
            //dataGridViewAnswers.DataSource = (dataGridViewQuestions.SelectedCells as Question).Answers;

        }

        // DialogResult
        DialogResult ShowSaveMessage()
        {
            var dialog = MessageBox.Show(
                "Save changes to current test?",
                currFilePath.Any() ? currFilePath : "New test",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
            return dialog;
        }

        // Save Test
        bool SaveTest()
        {
            if (!currFilePath.Any())
            {
                saveFileDialogTest.Filter = "XML files (*.xml)|*.xml";
                saveFileDialogTest.FilterIndex = 1;
                saveFileDialogTest.RestoreDirectory = true;
                if (saveFileDialogTest.ShowDialog() == DialogResult.OK)
                {
                    currFilePath = saveFileDialogTest.FileName;
                    File.WriteAllText(currFilePath, Serializer.Serialize<Test>(currTest));
                    IsTestChanged = false;
                    toolStripStatusLabel1.Text = currFilePath;
                    return true;
                }
            }
            else
            {
                currTest.Serialize(currFilePath);
                IsTestChanged = false;
                toolStripStatusLabel1.Text = currFilePath;
                return true;
            }
            return false;
        }

        // Open Test
        bool OpenTest()
        {
            openFileDialogTest.Filter = "XML files (*.xml)|*.xml";
            openFileDialogTest.FilterIndex = 1;
            openFileDialogTest.RestoreDirectory = true;
            if (openFileDialogTest.ShowDialog() == DialogResult.OK)
            {
                currFilePath = openFileDialogTest.FileName;
                currTest = Serializer.Deserialize<Test>(File.ReadAllText(currFilePath));
                FillForm();
                IsTestChanged = false;
                statusStrip.Text = currFilePath;
                return true;
            }
            return false;
        }

        // Create New
        void CreateTest()
        {
            currTest = new Test();
            IsTestChanged = false;
            FillForm();
        }


    }
}
