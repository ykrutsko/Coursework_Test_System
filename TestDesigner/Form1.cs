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
using TestDesigner.Properties;
using TestLib;

namespace TestDesigner
{
    public partial class MainForm : Form
    {
        string currFilePath = string.Empty;
        Test currTest;
        Question currQuestion;
        bool IsTestChanged = false;
        bool IsFileMode = false;
        Bitmap noPhotoBitmap = new Bitmap(Resources.nophoto);

        public MainForm()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewQuestions.DataSource = bindingSourceQuestions;
            dataGridViewAnswers.DataSource = bindingSourceAnswers;
            NewTest();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!СonfirmedActionWithDialogs())
                e.Cancel = true;
        }

        // Main menu
        //---------------------------------------------------------------------
        // New Test
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

        // Helpfull
        //---------------------------------------------------------------------
        void SetCleanMainForm()
        {
            // text boxes
            IsFileMode = true;
            tbAuthor.Text = String.Empty;
            tbTitle.Text = String.Empty;
            tbDescription.Text = String.Empty;
            tbInfo.Text = String.Empty;
            tbCountOfQuestions.Text = "0";
            tbMaxPointsForTest.Text = "0";
            numericUpDownMinPass.Value = 0;
            IsFileMode = false;

            // DataGridView
            FillDataGridViewQuestions(ModeFillDataGrid.New);
            SetCleanDataGridViewAnswers();

            //Picture
            pictureBox.Image = noPhotoBitmap;

            //Head. footer
            WindowTitleText();
            WindowFuterText();
            tbTitle.Select();
        }
        void SetCleanDataGridViewAnswers()
        {
            bindingSourceAnswers.DataSource = null;
            dataGridViewAnswers.Columns.Clear();
            dataGridViewAnswers.Columns.Add("Answer", "Answer");
            dataGridViewAnswers.Columns.Add("Right", "Is right");
            dataGridViewAnswers.Columns[0].Width = 290;
            dataGridViewAnswers.Columns[1].Width = 90;
        }

        void FillMainForm()
        {
            // text boxes
            IsFileMode = true;
            tbAuthor.Text = currTest.Author;
            tbTitle.Text = currTest.Title;
            tbDescription.Text = currTest.Description;
            tbInfo.Text = currTest.Info;
            pictureBox.Image = SetCurrBitmap();
            numericUpDownMinPass.Value = currTest.PassPercent;
            IsFileMode = false;

            // DataGridView            
            FillDataGridViewQuestions(ModeFillDataGrid.New);
            FillDataGridViewAnswers();

            //Head, footer 
            WindowTitleText();
            WindowFuterText();

            tbTitle.Select();
        }

        void FillDataGridViewQuestions(ModeFillDataGrid modeFillDataGrid)
        {
            dataGridViewQuestions.SelectionChanged -= new System.EventHandler(this.dataGridViewQuestions_SelectionChanged);
            {
                if(modeFillDataGrid == ModeFillDataGrid.New)
                {
                    dataGridViewQuestions.Columns.Clear();
                    bindingSourceQuestions.DataSource = null;
                    bindingSourceQuestions.DataSource = currTest.Questions;
                    dataGridViewQuestions.Columns[0].Width = 500;
                    dataGridViewQuestions.Columns[0].HeaderText = "Question";
                    dataGridViewQuestions.Columns[1].Width = 90;
                    dataGridViewQuestions.Columns[1].HeaderText = "Point";
                    dataGridViewQuestions.Columns[2].Visible = false;
                }
                bindingSourceQuestions.ResetBindings(false);

                if (currTest.Questions.Any())
                {
                    int pos = 0;
                    if(currQuestion == null)
                    {
                        currQuestion = currTest.Questions[pos];
                    }
                    else
                    {
                        pos = currTest.Questions.IndexOf(currQuestion);
                    }                      
                    dataGridViewQuestions.Rows[pos].Selected = true;

                    toolStripButtonAddByCopy.Enabled = true;
                    toolStripButtonEdit.Enabled = true;
                    toolStripButtonDelete.Enabled = true;
                    UpDownEnableDisable();                    
                }
                else
                {
                    currQuestion = null;

                    toolStripButtonAddByCopy.Enabled = false;
                    toolStripButtonEdit.Enabled = false;
                    toolStripButtonDelete.Enabled = false;
                    toolStripButtonUp.Enabled = false;
                    toolStripButtonDown.Enabled = false;

                }
                pictureBox.Image = SetCurrBitmap();
                pictureBox.Refresh();

            }
            dataGridViewQuestions.SelectionChanged += new System.EventHandler(this.dataGridViewQuestions_SelectionChanged);
            tbCountOfQuestions.Text = currTest.Questions.Count.ToString();
            tbMaxPointsForTest.Text = currTest.Questions.Select(x => x.Points).Sum().ToString();
        }

        void FillDataGridViewAnswers()
        {
            if(currQuestion == null)
            {
                SetCleanDataGridViewAnswers();
                return;
            }
            dataGridViewAnswers.Columns.Clear();
            bindingSourceAnswers.DataSource = currQuestion.Answers;
            dataGridViewAnswers.Columns[0].Width = 290;
            dataGridViewAnswers.Columns[0].HeaderText = "Answer";
            dataGridViewAnswers.Columns[1].Width = 90;
            dataGridViewAnswers.Columns[1].HeaderText = "Is right";

            bindingSourceAnswers.ResetBindings(false);
            dataGridViewAnswers.ClearSelection();
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
            return true;
        }

        // Create New
        void NewTest()
        {
            currTest = new Test();
            currQuestion = null;
            currFilePath = String.Empty;
            IsTestChanged = false;

            //GUI
            SetCleanMainForm();
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
            IsTestChanged = false;
            currQuestion = null;

            // Gui
            FillMainForm();

            return true;
        }

        // Save Test
        bool SaveTest()
        {
            bool isAutoTitle = false;
            if (!tbTitle.Text.Any())
            {
                var tmpColor = tbTitle.BackColor;
                tbTitle.BackColor = Color.YellowGreen;
                tbTitle.Text = NameGenerator(NameType.TestName);
                tbTitle.Refresh();
                Thread.Sleep(1000);
                tbTitle.BackColor = tmpColor;
                tbTitle.Refresh();
                isAutoTitle = true;
            }                

            if (!currFilePath.Any())
            {
                saveFileDialogTest.Filter = "XML files (*.xml)|*.xml";
                saveFileDialogTest.FilterIndex = 1;
                saveFileDialogTest.RestoreDirectory = true;
                if(isAutoTitle)
                {
                    saveFileDialogTest.FileName = NameGenerator(NameType.FileNameAuto);
                }
                else
                {
                    saveFileDialogTest.FileName = NameGenerator(NameType.FileNameTitle);
                }

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
            string second = currFilePath == string.Empty? "Untitled" : Path.GetFileNameWithoutExtension(currFilePath);
            string third = " - Test designer";
            this.Text = new StringBuilder(first + second + third).ToString();
            this.Refresh();
        }

        void WindowFuterText()
        {
            toolStripStatusLabel1.Text = (currFilePath == string.Empty)? "Current Test not saved yet..." : currFilePath;
        }

        string NameGenerator(NameType nameType)
        {
            switch(nameType)
            {
                case NameType.FileNameAuto:
                    return "Test [" + DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss") + "]";
                case NameType.FileNameTitle:
                    return tbTitle.Text + " [" + DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss") + "]";
                case NameType.TestName:
                    return "Test [" + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + "]";
                default:
                    return string.Empty;
            }
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            //if(!IsFileMode)
            //{
            //    IsTestChanged = true;
            //    WindowTitleText();
            //}
        }

        //Modify questions
        //---------------------------------------------------------------------
        // Add
        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            QuestionForm modifyForm = new QuestionForm(Mode.Add);
            if (modifyForm.ShowDialog() == DialogResult.OK)
            {
                currQuestion = modifyForm.CurrQuestion;
                currTest.Questions.Add(currQuestion);
                FillDataGridViewQuestions(ModeFillDataGrid.Edit);
                FillDataGridViewAnswers();
                IsTestChanged = true;
                WindowTitleText();
            }
        }

        //AddByCopy question
        private void toolStripButtonAddByCopy_Click(object sender, EventArgs e)
        {
            QuestionForm modifyForm = new QuestionForm(Mode.AddByCopy, currQuestion.Clone() as Question);
            if (modifyForm.ShowDialog() == DialogResult.OK)
            {
                currQuestion = modifyForm.CurrQuestion;
                currTest.Questions.Add(currQuestion);
                FillDataGridViewQuestions(ModeFillDataGrid.Edit);
                FillDataGridViewAnswers();
                IsTestChanged = true;
                WindowTitleText();
            }
        }

        //Edit question
        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            QuestionForm modifyForm = new QuestionForm(Mode.Edit, currQuestion.Clone() as Question);
            if (modifyForm.ShowDialog() == DialogResult.OK)
            {
                int pos = currTest.Questions.IndexOf(currQuestion);
                currQuestion = currTest.Questions[pos] = modifyForm.CurrQuestion;

                FillDataGridViewQuestions(ModeFillDataGrid.Edit);
                FillDataGridViewAnswers();
                IsTestChanged = true;
                WindowTitleText();
            }
        }

        // Delete question
        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Delete this question?",
                "Test designer",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) != DialogResult.OK) return;

            int pos = currTest.Questions.IndexOf(currQuestion);
            int newPos = (pos == currTest.Questions.Count - 1) ? pos - 1 : pos;

            currTest.Questions.RemoveAt(pos);
            currQuestion = currTest.Questions.Any() ? currTest.Questions[newPos] : null;

            FillDataGridViewQuestions(ModeFillDataGrid.Edit);
            FillDataGridViewAnswers();
            IsTestChanged = true;
            WindowTitleText();
        }

        // Question Up
        private void toolStripButtonUp_Click(object sender, EventArgs e)
        {
            int pos = currTest.Questions.IndexOf(currQuestion);
            (currTest.Questions[pos], currTest.Questions[pos - 1]) = (currTest.Questions[pos - 1], currTest.Questions[pos]);
            FillDataGridViewQuestions(ModeFillDataGrid.Edit);
            IsTestChanged = true;
            WindowTitleText();
        }

        //Question down
        private void toolStripButtonDown_Click(object sender, EventArgs e)
        {
            int pos = currTest.Questions.IndexOf(currQuestion);
            (currTest.Questions[pos], currTest.Questions[pos + 1]) = (currTest.Questions[pos + 1], currTest.Questions[pos]);
            FillDataGridViewQuestions(ModeFillDataGrid.Edit);
            IsTestChanged = true;
            WindowTitleText();
        }

        Bitmap SetCurrBitmap()
        {
            if (currQuestion != null && currQuestion.Img != String.Empty)
                return ImgConverter.Base64StringToBitmap(currQuestion.Img);
            return noPhotoBitmap;
        }

        // Open bitmap in large window
        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == noPhotoBitmap)
                return;
            PictureForm pictureForm = new PictureForm(ImgConverter.Base64StringToBitmap(currQuestion.Img));
            pictureForm.StartPosition = FormStartPosition.CenterParent;
            pictureForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            pictureForm.MaximizeBox = false;
            pictureForm.MinimizeBox = false;
            pictureForm.ShowDialog();

        }

        // Change cursor on picture box
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if(pictureBox.Image != noPhotoBitmap)
                Cursor.Current = Cursors.Hand;
            else
                Cursor.Current = Cursors.Default;
        }

        // Change selected row in grid
        private void dataGridViewQuestions_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewQuestions.SelectedRows.Count == 0)
                return;
            currQuestion = dataGridViewQuestions.CurrentRow.DataBoundItem as Question;
            UpDownEnableDisable();
            pictureBox.Image = SetCurrBitmap();
            FillDataGridViewAnswers();
        }

        private void dataGridViewQuestions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
                toolStripButtonEdit_Click(sender, e);
        }

        // UpDown key Enable / Disable
        void UpDownEnableDisable()
        {
            if (currQuestion == null)
                return;

            int pos = currTest.Questions.IndexOf(currQuestion);
            if (currTest.Questions.Count == 1)
            {
                toolStripButtonUp.Enabled = false;
                toolStripButtonDown.Enabled = false;
            }
            else if (pos == 0)
            {
                toolStripButtonUp.Enabled = false;
                toolStripButtonDown.Enabled = true;
            }
            else if (pos == currTest.Questions.Count - 1)
            {
                toolStripButtonUp.Enabled = true;
                toolStripButtonDown.Enabled = false;
            }
            else
            {
                toolStripButtonUp.Enabled = true;
                toolStripButtonDown.Enabled = true;
            }
        }
    }
}
