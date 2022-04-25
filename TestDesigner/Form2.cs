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
        Mode mode;
        Answer currAnswer;
        Bitmap currBitmap;
        public Question CurrQuestion { get; set; }
        Bitmap noPhotoBitmap = new Bitmap(Resources.nophoto);

        // Add ctor
        public ModifyForm(Mode mode)
        {
            this.mode = mode;
            CurrQuestion = new Question();
            CurrQuestion.Answers = new List<Answer>();
            InitializeComponent();
        }
        // Add byCopy ctor
        public ModifyForm(Mode mode, in Question question)
        {
            this.mode = mode;
            CurrQuestion = question.Clone() as Question;
            InitializeComponent();

        }
        // Edit ctor
        public ModifyForm(Mode mode, Question question)
        {
            this.mode = mode;
            CurrQuestion = question;
            InitializeComponent();

        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {
            switch(mode)
            {
                case Mode.Add:
                    Text = "Questions [Add mode]";
                    break;
                case Mode.AddByCopy:
                    Text = "Questions [Add by copy mode]";
                    break;
                case Mode.Edit:
                    Text = "Questions [Edit mode]";
                    break;
            }
            dataGridViewAnswers.DataSource = bindingSourceAnswers;
            FillForm();
        }

        void FillForm()
        {
            tbQuestion.Text = CurrQuestion.QuestionText;
            if(CurrQuestion.Img.Any())
            {
                currBitmap = new Bitmap(ImgConverter.Base64StringToBitmap(CurrQuestion.Img));
                pictureBox.Image = currBitmap;
            }
            else
            {
                currBitmap = null;
                pictureBox.Image = noPhotoBitmap;
            }
            numericUpDownPoints.Value = CurrQuestion.Points;

            FillDataGridViewAnswers(ModeFillDataGrid.New);
        }

        void FillDataGridViewAnswers(ModeFillDataGrid modeFillDataGrid)
        {
            dataGridViewAnswers.SelectionChanged -= new System.EventHandler(this.dataGridViewAnswers_SelectionChanged);
            {
                if (modeFillDataGrid == ModeFillDataGrid.New)
                {
                    dataGridViewAnswers.Columns.Clear();
                    bindingSourceAnswers.DataSource = CurrQuestion.Answers;
                    dataGridViewAnswers.Columns[0].Width = 290;
                    dataGridViewAnswers.Columns[0].HeaderText = "Answer";
                    dataGridViewAnswers.Columns[1].Width = 90;
                    dataGridViewAnswers.Columns[1].HeaderText = "Is right";
                }
                bindingSourceAnswers.ResetBindings(false);

                if (CurrQuestion.Answers.Any())
                {
                    int pos = currAnswer == null ? 0 : CurrQuestion.Answers.IndexOf(CurrQuestion.Answers.Where(x => ReferenceEquals(x, currAnswer)).FirstOrDefault());
                    currAnswer = CurrQuestion.Answers[pos];
                    dataGridViewAnswers.Rows[pos].Selected = true;

                    toolStripButtonAddByCopy.Enabled = true;
                    toolStripButtonEdit.Enabled = true;
                    toolStripButtonDelete.Enabled = true;
                }
                else
                {
                    currAnswer = null;

                    toolStripButtonAddByCopy.Enabled = false;
                    toolStripButtonEdit.Enabled = false;
                    toolStripButtonDelete.Enabled = false;
                }
            }
            dataGridViewAnswers.SelectionChanged += new System.EventHandler(this.dataGridViewAnswers_SelectionChanged);
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            CurrQuestion.QuestionText = tbQuestion.Text;
            CurrQuestion.Points = (int)numericUpDownPoints.Value;
            CurrQuestion.Img = (currBitmap == null) ? String.Empty : ImgConverter.BitmapToBase64String(currBitmap);
        }


        private void tbQuestion_TextChanged(object sender, EventArgs e)
        {
            if(!tbQuestion.Text.Any())
                btnOk.Enabled = false;
            else
                btnOk.Enabled = true;
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

        private void dataGridViewAnswers_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
