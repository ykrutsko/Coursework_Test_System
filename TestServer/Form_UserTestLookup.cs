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
using TestLib;
using TestServer.Properties;

namespace TestServer
{
    public partial class UserTestLookupForm : Form
    {
        public UserTest UserTest { get; set; }
        public DALTestingSystemDB.Question currQuestion { get; set; }

        Bitmap noPhotoBitmap = Resources.nophoto;

        public UserTestLookupForm(UserTest userTest)
        {
            this.UserTest = userTest;
            InitializeComponent();
        }

        private void UserTestLookupForm_Load(object sender, EventArgs e)
        {
            this.Text = UserTest.ToString();

            // Test
            tbQuestions.Text = UserTest.Test.Questions.Count().ToString();
            int max = UserTest.Test.Questions.Select(x => x.Points).Sum();
            tbMax.Text = max.ToString();
            tbMin.Text = UserTest.Test.PassPercent.ToString();
            tbDate.Text = UserTest.TakedDate.ToString();

            //Result
            int unanswered = 0;
            int correct = 0;
            int gotInPoints = 0;
            foreach (var q in UserTest.Test.Questions)
            {
                var result = q.Answers.Join(UserTest.UserAnswers,
                    x => x.Id,
                    y => y.Answer.Id,
                    (x, y) => new { Id = x.Id, IsRight = x.IsRight, Answer = y.IsChecked });
                
                //questions
                bool res1 = false;
                foreach (var r in result)
                {
                    res1 = res1 || r.Answer;
                }
                if (!res1)
                    ++unanswered;

                //Correct
                bool res2 = true;
                foreach (var r in result)
                {
                    res2 = res2 && (r.IsRight == r.Answer);
                }
                if (res2)
                {
                    ++correct;
                    gotInPoints += q.Points;
                }
            }
            tbUnanswered.Text = unanswered.ToString();
            tbCorrect.Text = correct.ToString();
            tbWrong.Text = (UserTest.Test.Questions.Count() - correct).ToString();
            tbGotPoints.Text = gotInPoints.ToString();
            decimal gotInPercent = (decimal)(((double)gotInPoints / max) * 100);
            tbGotInPercent.Text = gotInPercent.ToString();

            if(gotInPercent >= (decimal)UserTest.Test.PassPercent)
            {
                labelYesNo.ForeColor = Color.Green;
                labelYesNo.Text = "YES";
            }
            else
            {
                labelYesNo.ForeColor = Color.Red;
                labelYesNo.Text = "NO";
            }

            this.datagridViewQuestions.SelectionChanged -= new System.EventHandler(this.datagridViewQuestions_SelectionChanged);
            {
                //Questions
                bindingSourceQuestions.DataSource = UserTest.Test.Questions;
                datagridViewQuestions.Columns.Clear();
                datagridViewQuestions.DataSource = bindingSourceQuestions;

                datagridViewQuestions.Columns[2].Visible = false;
                datagridViewQuestions.Columns[4].Visible = false;
                datagridViewQuestions.Columns[5].Visible = false;
                datagridViewQuestions.Columns[0].Width = 50;
                datagridViewQuestions.Columns[1].Width = 540;
                datagridViewQuestions.Columns[3].Width = 90;
                datagridViewQuestions.Columns[1].HeaderText = "Question text";
                datagridViewQuestions_WhenRowGetSelect();

                // Answers
                dataGridViewAnswers.Columns.Clear();
                dataGridViewAnswers.DataSource = bindingSourceAnswers;
                dataGridViewAnswers.Columns[0].Width = 50;
                dataGridViewAnswers.Columns[1].Width = 280;
                dataGridViewAnswers.Columns[2].Width = 70;
                dataGridViewAnswers.Columns[3].Width = 70;
                dataGridViewAnswers.Columns[1].HeaderText = "Answer text";
                dataGridViewAnswers.Columns[2].HeaderText = "Right";
                dataGridViewAnswers.Columns[3].HeaderText = "Answer";
            }
            this.datagridViewQuestions.SelectionChanged += new System.EventHandler(this.datagridViewQuestions_SelectionChanged);
        }
        private void JoinAnswerWithUserAnswer()
        {
            var result = currQuestion.Answers.Join(UserTest.UserAnswers,
                x => x.Id,
                y => y.Answer.Id,
                (x, y) => new { Id = x.Id, AnswerText = x.AnswerText, IsRight = x.IsRight, Answer = y.IsChecked });
            bindingSourceAnswers.DataSource = result;
        }

        private void datagridViewQuestions_WhenRowGetSelect()
        {
            currQuestion = datagridViewQuestions.CurrentRow.DataBoundItem as DALTestingSystemDB.Question;
            pictureBox.Image = SetCurrBitmap();
            JoinAnswerWithUserAnswer();
        }

        private void datagridViewQuestions_SelectionChanged(object sender, EventArgs e)
        {
            datagridViewQuestions_WhenRowGetSelect();
        }

        private void datagridViewQuestions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DALTestingSystemDB.Question q = datagridViewQuestions.Rows[e.RowIndex].DataBoundItem as DALTestingSystemDB.Question;
                MessageBox.Show(q.QuestionText, $"Question Id: {q.Id}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewAnswers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DALTestingSystemDB.Answer a = currQuestion.Answers.Where(x => x.Id.ToString() == dataGridViewAnswers.Rows[e.RowIndex].Cells[0].Value.ToString()).FirstOrDefault();
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

        Bitmap SetCurrBitmap()
        {
            if (currQuestion != null && currQuestion.Img != String.Empty)
                return ImgConverter.Base64StringToBitmap(currQuestion.Img);
            return noPhotoBitmap;
        }
    }
}
