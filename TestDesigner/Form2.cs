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
using TestDesigner.Properties;
using TestLib;


// tmpS = dataGridView1.CurrentRow.DataBoundItem as S;

namespace TestDesigner
{
    public partial class ModifyForm : Form
    {
        public Question CurrQuestion { get; set; }
        Answer currAnswer;
        Mode mode;
        Bitmap currBitmap = null;
        Bitmap noPhotoBitmap = new Bitmap(Resources.nophoto);

        public ModifyForm(Mode mode)
        {
            this.mode = mode;
            CurrQuestion = new Question();
            CurrQuestion.Answers = new List<Answer>();
            InitializeComponent();
        }
        public ModifyForm(Mode mode, Question question)
        {
            CurrQuestion = question;
            InitializeComponent();

        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {
            if(mode == Mode.Add)
            {
                Text = "Questions [Add mode]";
                pictureBox.Image = noPhotoBitmap;
            }
            else
            {
                Text = "Questions [Edit mode]";
                FillForm();
            }
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            CurrQuestion.QuestionText = tbQuestion.Text;
            CurrQuestion.Points = (int)numericUpDownPoints.Value;
            CurrQuestion.Img = currBitmap == null? String.Empty : ImgConverter.BitmapToBase64String(currBitmap);
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            //Questions.Add(currQuestion = new Question(tbQuestion.Text, (int)numericUpDownPoint.Value, String.Empty));
            FillForm();
        }

        void FillForm()
        {
            //if (!String.IsNullOrEmpty(Questions.First().Img))
            //    pictureBox.Image = ImgConverter.Base64StringToBitmap(Questions.First().Img);

            //if (Questions.Any())
            //{
            //    FillDataGridViewQuestions();
            //    FillDataGridViewAnswers();
            //}
            //else
            //{
            //    SetCleanDataGridViewQuestions();
            //    SetCleaDataGridViewAnswers();
            //}
        }

        void FillDataGridViewQuestions()
        {
            //dataGridViewQuestions.Columns.Clear();
            //dataGridViewQuestions.DataSource = null;
            //dataGridViewQuestions.DataSource = Questions;
            //dataGridViewQuestions.Columns[0].Width = 500;
            //dataGridViewQuestions.Columns[0].HeaderText = "Question";
            //dataGridViewQuestions.Columns[1].Width = 90;
            //dataGridViewQuestions.Columns[1].HeaderText = "Point";
            //dataGridViewQuestions.Columns[2].Visible = false;

            //currQuestion = currQuestion?? Questions[0];
            //dataGridViewQuestions.ClearSelection();

            //var equalRow = dataGridViewQuestions.Rows
            //    .Cast<DataGridViewRow>()
            //    .Where(x => (x.DataBoundItem as Question).Equals(currQuestion))
            //    .First();

            //dataGridViewQuestions.Rows[equalRow.Index].Selected = true;
        }

        void FillDataGridViewAnswers()
        {
            dataGridViewAnswers.Columns.Clear();
            dataGridViewAnswers.DataSource = null;
            //dataGridViewAnswers.DataSource = currQuestion.Answers;
            dataGridViewAnswers.Columns[0].Width = 290;
            dataGridViewAnswers.Columns[0].HeaderText = "Answer";
            dataGridViewAnswers.Columns[1].Width = 90;
            dataGridViewAnswers.Columns[1].HeaderText = "Is right";
        }

        void SetCleanDataGridViewQuestions()
        {
            //dataGridViewQuestions.Columns.Clear();
            //dataGridViewQuestions.Columns.Add("Question", "Question");
            //dataGridViewQuestions.Columns.Add("Point", "Point");
            //dataGridViewQuestions.Columns[0].Width = 500;
            //dataGridViewQuestions.Columns[1].Width = 90;
        }

        void SetCleaDataGridViewAnswers()
        {
            dataGridViewAnswers.Columns.Clear();
            dataGridViewAnswers.Columns.Add("Answer", "Answer");
            dataGridViewAnswers.Columns.Add("Right", "Is right");
            dataGridViewAnswers.Columns[0].Width = 290;
            dataGridViewAnswers.Columns[1].Width = 90;
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {

        }

        //Load image
        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            openFileDialog.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap bmp = new Bitmap(openFileDialog.FileName);
                    pictureBox.Image = bmp;
                    //currQuestion.Img = ImgConverter.BitmapToBase64String(bmp);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


        }

        //private void dataGridViewQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    currQuestion = dataGridViewQuestions.CurrentRow.DataBoundItem as Question;
        //    FillDataGridViewAnswers();
        //}

        private void dataGridViewAnswers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currAnswer = dataGridViewAnswers.CurrentRow.DataBoundItem as Answer;
        }

        private void tbQuestion_TextChanged(object sender, EventArgs e)
        {
            if(!tbQuestion.Text.Any())
                btnOk.Enabled = false;
            else
                btnOk.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Questions.Add(new Question());
        }



        // Load image
        private void pictureBox_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    currBitmap = new Bitmap(openFileDialog.FileName);
                    pictureBox.Image = currBitmap;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        // Clear image
        private void btnClearImg_Click(object sender, EventArgs e)
        {
            currBitmap = null;
            pictureBox.Image = noPhotoBitmap;
        }
    }
}
