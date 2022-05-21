using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLib;
using TestServer.Properties;

namespace TestServer
{
    public partial class TestLookupForm : Form
    {
        public DALTestingSystemDB.Test Test { get; set; }
        DALTestingSystemDB.Question currQuestion;
        Bitmap noPhotoBitmap = Resources.nophoto;

        public TestLookupForm(ref DALTestingSystemDB.Test test)
        {
            this.Test = test;
            InitializeComponent();
        }

        private void TestLookupForm_Load(object sender, EventArgs e)
        {
            this.Text = Test.ToString();
            tbTitle.Text = Test.Title;
            tbAuthor.Text = Test.Author;
            tbDescription.Text = Test.Description;
            tbInfo.Text = Test.Info;
            tbCountOfQuestions.Text = Test.Questions.Count.ToString();
            tbMaxPointsForTest.Text = Test.Questions.Select(x => x.Points).Sum().ToString();
            numericUpDownMinPass.Value = (int)Test.PassPercent;

            this.dataGridView_Questions.SelectionChanged -= new System.EventHandler(this.dataGridView_Questions_SelectionChanged);
            if (Test.Questions.Any())
            {
                // Question
                dataGridView_Questions.Columns.Clear();
                bindingSourceQuestions.DataSource = Test.Questions;
                dataGridView_Questions.DataSource = bindingSourceQuestions;

                dataGridView_Questions.Columns[2].Visible 
                    = dataGridView_Questions.Columns[4].Visible 
                    = dataGridView_Questions.Columns[5].Visible 
                    = dataGridView_Questions.Columns[6].Visible 
                    = false;

                dataGridView_Questions.Columns[0].Width = 50;
                dataGridView_Questions.Columns[1].Width = 480;
                dataGridView_Questions.Columns[3].Width = 70;
                dataGridView_Questions.Columns[1].HeaderText = "Question";
                dataGridView_Questions.Columns[3].HeaderText = "Point";

                dataGridView_Answers.Columns.Clear();
                Questions_WhenRowGetSelect();

                dataGridView_Answers.Columns[3].Visible
                    = dataGridView_Answers.Columns[4].Visible
                    = false;

                dataGridView_Answers.Columns[0].Width = 50;
                dataGridView_Answers.Columns[1].Width = 270;
                dataGridView_Answers.Columns[2].Width = 70;
                dataGridView_Answers.Columns[1].HeaderText = "Answer";
                dataGridView_Answers.Columns[2].HeaderText = "Is right";
            }
            this.dataGridView_Questions.SelectionChanged += new System.EventHandler(this.dataGridView_Questions_SelectionChanged);

            checkBox.Checked = Test.IsArchived;
            btnCancel.Select();
        }

        private void Questions_WhenRowGetSelect()
        {
            if(dataGridView_Questions.Rows.Count > 0 && dataGridView_Questions.SelectedRows.Count > 0)
            {
                currQuestion = dataGridView_Questions.CurrentRow.DataBoundItem as DALTestingSystemDB.Question;
                pictureBox.Image = SetCurrBitmap();
                bindingSourceAnswers.DataSource = currQuestion.Answers;
                dataGridView_Answers.DataSource = bindingSourceAnswers;
            }
        }

        private void dataGridView_Questions_SelectionChanged(object sender, EventArgs e)
        {
            Questions_WhenRowGetSelect();
        }

        private void dataGridView_Questions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DALTestingSystemDB.Question q = dataGridView_Questions.Rows[e.RowIndex].DataBoundItem as DALTestingSystemDB.Question;
                MessageBox.Show(q.QuestionText, $"Question Id: {q.Id}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView_Answers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DALTestingSystemDB.Answer a = dataGridView_Answers.Rows[e.RowIndex].DataBoundItem as DALTestingSystemDB.Answer;
                MessageBox.Show(a.AnswerText, $"Answer Id: {a.Id}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == noPhotoBitmap)
                return;
            LargeImgForm pictureForm = new LargeImgForm(ImgConverter.Base64StringToBitmap(currQuestion.Img), $"Question Id: {currQuestion.Id}");
            pictureForm.Show();
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox.Image != noPhotoBitmap)
                Cursor.Current = Cursors.Hand;
            else
                Cursor.Current = Cursors.Default;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Test.IsArchived = checkBox.Checked;
        }

        Bitmap SetCurrBitmap()
        {
            if (currQuestion != null && currQuestion.Img != String.Empty)
                return ImgConverter.Base64StringToBitmap(currQuestion.Img);
            return noPhotoBitmap;
        }
    }
}
