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

namespace TestDesigner
{
    public partial class ModifyForm : Form
    {
        public List<Question> Questions { get; set; }
        public ModifyForm()
        {
            InitializeComponent();
        }

        public ModifyForm(List<Question> questions)
        {
            Questions = questions.Clone<Question>();
            InitializeComponent();
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            Questions.Add(new Question(tbQuestion.Text, (int)numericUpDownPoint.Value, String.Empty));
            FillForm();
        }

        void FillForm()
        {
            //if (!String.IsNullOrEmpty(currTest.Img))
            //    pictureBox.Image = ImgConverter.Base64StringToBitmap(currTest.Img);

            if (Questions.Any())
            {
                FillDataGridViewQuestions();
                //FillDataGridViewAnswers();
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
            dataGridViewQuestions.DataSource = Questions;
            dataGridViewQuestions.Columns[0].Width = 500;
            dataGridViewQuestions.Columns[0].HeaderText = "Question";
            dataGridViewQuestions.Columns[1].Width = 90;
            dataGridViewQuestions.Columns[1].HeaderText = "Point";
            dataGridViewQuestions.Columns[2].Visible = false;
            dataGridViewQuestions.Rows[0].Selected = true;
        }

        void FillDataGridViewAnswers()
        {
            dataGridViewAnswers.Columns.Clear();
            dataGridViewAnswers.DataSource = null;
            dataGridViewAnswers.DataSource = Questions[0].Answers;
            dataGridViewAnswers.Columns[0].Width = 290;
            dataGridViewAnswers.Columns[0].HeaderText = "Answer";
            dataGridViewAnswers.Columns[1].Width = 90;
            dataGridViewAnswers.Columns[1].HeaderText = "Is right";
            dataGridViewAnswers.Columns[2].Visible = false;
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
    }
}
