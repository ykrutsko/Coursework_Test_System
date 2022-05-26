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
    public partial class QuestionForm : Form
    {
        Mode mode;
        Answer currAnswer;
        Bitmap currBitmap;
        public Question CurrQuestion { get; set; }
        Bitmap noPhotoBitmap = new Bitmap(Resources.nophoto);
        bool IsQuestionChanged = false;
        bool IsOpenMode = false;

        // Add ctor
        public QuestionForm(Mode mode)
        {
            this.mode = mode;
            CurrQuestion = new Question();
            CurrQuestion.Answers = new List<Answer>();
            InitializeComponent();
        }

        // Edit, AddByCopy ctor
        public QuestionForm(Mode mode, Question question)
        {
            this.mode = mode;
            CurrQuestion = question;
            InitializeComponent();
        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {
            FillForm();
        }

        void FillForm()
        {
            if (mode == Mode.AddByCopy)
                IsQuestionChanged = true;
            WindowTitleText();
            IsOpenMode = true;

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

            dataGridViewAnswers.DataSource = bindingSourceAnswers;
            dataGridViewAnswers.Columns.Clear();
            bindingSourceAnswers.DataSource = CurrQuestion.Answers;
            dataGridViewAnswers.Columns[0].Width = 297;
            dataGridViewAnswers.Columns[0].HeaderText = "Answer";
            dataGridViewAnswers.Columns[1].Width = 90;
            dataGridViewAnswers.Columns[1].HeaderText = "Is right";

            FillDataGridViewAnswers();
            IsOpenMode = false;
        }

        void FillDataGridViewAnswers()
        {
            dataGridViewAnswers.SelectionChanged -= new System.EventHandler(this.dataGridViewAnswers_SelectionChanged);
            {
                bindingSourceAnswers.ResetBindings(false);

                if (CurrQuestion.Answers.Any())
                {
                    int pos = 0;
                    if (currAnswer == null)
                    {
                        currAnswer = CurrQuestion.Answers[pos];
                    }
                    else
                    {
                        pos = CurrQuestion.Answers.IndexOf(currAnswer);
                    }
                    dataGridViewAnswers.Rows[pos].Selected = true;

                    toolStripButtonAddByCopy.Enabled = true;
                    toolStripButtonEdit.Enabled = true;
                    toolStripButtonDelete.Enabled = true;
                    UpDownEnableDisable();
                }
                else
                {
                    currAnswer = null;
                    toolStripButtonAddByCopy.Enabled = false;
                    toolStripButtonEdit.Enabled = false;
                    toolStripButtonDelete.Enabled = false;
                    toolStripButtonUp.Enabled = false;
                    toolStripButtonDown.Enabled = false;
                }
            }
            dataGridViewAnswers.SelectionChanged += new System.EventHandler(this.dataGridViewAnswers_SelectionChanged);
        }

        // DGV Selection change
        private void dataGridViewAnswers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewAnswers.SelectedRows.Count == 0)
                return;

            currAnswer = dataGridViewAnswers.CurrentRow.DataBoundItem as Answer;
            UpDownEnableDisable();
        }

        // Add answer
        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            AnswerForm answerForm = new AnswerForm(Mode.Add);
            if (answerForm.ShowDialog() == DialogResult.OK)
            {
                currAnswer = answerForm.CurrAnswer;
                CurrQuestion.Answers.Add(currAnswer);
                FillDataGridViewAnswers();
                QuestionChanged();
            }
        }

        //Add answer by copy
        private void toolStripButtonAddByCopy_Click(object sender, EventArgs e)
        {
            AnswerForm answerForm = new AnswerForm(Mode.AddByCopy, currAnswer.Clone() as Answer);
            if (answerForm.ShowDialog() == DialogResult.OK)
            {
                currAnswer = answerForm.CurrAnswer;
                CurrQuestion.Answers.Add(currAnswer);
                FillDataGridViewAnswers();
                QuestionChanged();
            }
        }

        // Edit answer
        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            AnswerForm answerForm = new AnswerForm(Mode.Edit, currAnswer.Clone() as Answer);
            if (answerForm.ShowDialog() == DialogResult.OK)
            {
                int pos = CurrQuestion.Answers.IndexOf(currAnswer);
                currAnswer = CurrQuestion.Answers[pos] = answerForm.CurrAnswer;
                FillDataGridViewAnswers();
                QuestionChanged();
            }
        }

        // Cell double click is edit mode
        private void dataGridViewAnswers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                toolStripButtonEdit_Click(sender, e);
        }

        // Move answer Up
        private void toolStripButtonUp_Click(object sender, EventArgs e)
        {
            int pos = CurrQuestion.Answers.IndexOf(currAnswer);
            (CurrQuestion.Answers[pos], CurrQuestion.Answers[pos - 1]) = (CurrQuestion.Answers[pos - 1], CurrQuestion.Answers[pos]);
            FillDataGridViewAnswers();
            QuestionChanged();
        }

        // Move answer down
        private void toolStripButtonDown_Click(object sender, EventArgs e)
        {
            int pos = CurrQuestion.Answers.IndexOf(currAnswer);
            (CurrQuestion.Answers[pos], CurrQuestion.Answers[pos + 1]) = (CurrQuestion.Answers[pos + 1], CurrQuestion.Answers[pos]);
            FillDataGridViewAnswers();
            QuestionChanged();
        }

        // Delete answer
        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Delete this answer?",
                "Test designer",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) != DialogResult.OK) return;

            int pos = CurrQuestion.Answers.IndexOf(currAnswer);
            int newPos = (pos == CurrQuestion.Answers.Count - 1) ? pos - 1 : pos;

            CurrQuestion.Answers.RemoveAt(pos);
            currAnswer = CurrQuestion.Answers.Any() ? CurrQuestion.Answers[newPos] : null;

            FillDataGridViewAnswers();
            QuestionChanged();
        }

        private void tbQuestion_TextChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = !string.IsNullOrEmpty(tbQuestion.Text);
            if(!IsOpenMode)
                QuestionChanged();
        }

        private void numericUpDownPoints_ValueChanged(object sender, EventArgs e)
        {
            if (!IsOpenMode)
                QuestionChanged();
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
                    using (Stream fileStream = openFileDialog.OpenFile())
                    {
                        currBitmap = new Bitmap(Image.FromStream(fileStream));
                    }                  
                    pictureBox.Image = currBitmap;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            QuestionChanged();
        }

        // Clear image
        private void btnClearImg_Click(object sender, EventArgs e)
        {
            currBitmap = null;
            pictureBox.Image = noPhotoBitmap;
            QuestionChanged();
        }

        // OK
        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
        }

        // Save
        void Save()
        {
            CurrQuestion.QuestionText = tbQuestion.Text;
            CurrQuestion.Points = (int)numericUpDownPoints.Value;
            CurrQuestion.Img = (currBitmap == null) ? String.Empty : ImgConverter.BitmapToBase64String(currBitmap);
            IsQuestionChanged = false;
        }

        // Form closing
        private void QuestionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsQuestionChanged)
            {
                DialogResult dialogResult = DialogResultOnClickCancel();
                if (dialogResult == DialogResult.None)
                    e.Cancel = true;
                else
                    this.DialogResult = dialogResult;
            }
        }

        // When Cancel or close form
        DialogResult DialogResultOnClickCancel()
        {
            var dialog = MessageBox.Show(
                "Save changes to current question?",
                "Test designer",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                if (!tbQuestion.Text.Any())
                {
                    var tmpColor = tbQuestion.BackColor;
                    tbQuestion.BackColor = Color.YellowGreen;
                    tbQuestion.Refresh();
                    Thread.Sleep(1000);
                    tbQuestion.BackColor = tmpColor;
                    tbQuestion.Refresh();
                    tbQuestion.Select();
                    return DialogResult.None;
                }
                Save();
                return DialogResult.OK;
            }
            if (dialog == DialogResult.Cancel)
                return DialogResult.None;
            return DialogResult.Cancel;
        }

        void QuestionChanged()
        {
            if (!IsQuestionChanged)
            {
                IsQuestionChanged = true;
                WindowTitleText();
            }
        }

        // Form title
        void WindowTitleText()
        {
            string first = IsQuestionChanged ? "*" : string.Empty;
            string last = string.Empty;
            switch (mode)
            {
                case Mode.Add:
                    last = "Question [Add mode]";
                    break;
                case Mode.AddByCopy:
                    last = "Question [Add by copy mode]";
                    break;
                case Mode.Edit:
                    last = "Question [Edit mode]";
                    break;
            }
            this.Text = first + last;
        }

        // UpDown key Enable / Disable
        void UpDownEnableDisable()
        {
            if (currAnswer == null)
                return;

            int pos = CurrQuestion.Answers.IndexOf(currAnswer);
            if (CurrQuestion.Answers.Count == 1)
            {
                toolStripButtonUp.Enabled = false;
                toolStripButtonDown.Enabled = false;
            }
            else if (pos == 0)
            {
                toolStripButtonUp.Enabled = false;
                toolStripButtonDown.Enabled = true;
            }
            else if (pos == CurrQuestion.Answers.Count - 1)
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
