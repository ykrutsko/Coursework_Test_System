using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLib;

namespace TestClient
{
    public class VisualTest
    {
        public string Info { get; set; }
        public List<VisualQuestion> VisualQuestionsList { get; set; }
        public FlowLayoutPanel ProgressBarPanel { get; set; }
        public List<FlowLayoutPanel> ProgressBarList { get; set; }
        public VisualQuestion ActiveQuestion { get; set; }
        public Button ButtonNext { get; set; }
        public Button ButtonPrev { get; set; }

        public VisualTest(NetCloneLib.NetCloneTest test)
        {
            Info = test.Info;
            VisualQuestionsList = new List<VisualQuestion>();
            foreach (var q in Globals.currUserTest.Test.Questions)
            {
                VisualQuestion visualQuestion = new VisualQuestion()
                {
                    Id = q.Id,
                    QuestionText = q.QuestionText,
                    Img = q.Img,
                    Points = q.Points,
                    CountRight = q.CountRight,
                    GroupBox = new GroupBox(),
                    VisualAnswersList = new List<VisualAnswer>()
                };

                foreach (var a in q.Answers)
                {
                    VisualAnswer visualAnswer = new VisualAnswer()
                    {
                        Id = a.Id,
                        AnswerText = a.AnswerText,
                        IdUserAnswer = a.IdUserAnswer,
                        IsChecked = a.IsChecked
                    };
                    visualQuestion.VisualAnswersList.Add(visualAnswer);
                }
                VisualQuestionsList.Add(visualQuestion);
            }

            //mix questions and answers
            Random rand = new Random();
            for (int i = VisualQuestionsList.Count() - 1; i >= 1; i--)
            {
                for (int j = VisualQuestionsList[i].VisualAnswersList.Count - 1; j >= 1; j--)
                {
                    int z1 = rand.Next(j + 1);
                    (VisualQuestionsList[i].VisualAnswersList[j], VisualQuestionsList[i].VisualAnswersList[z1])
                        = (VisualQuestionsList[i].VisualAnswersList[z1], VisualQuestionsList[i].VisualAnswersList[j]);
                }
                int z2 = rand.Next(i + 1);
                (VisualQuestionsList[i], VisualQuestionsList[z2]) = (VisualQuestionsList[z2], VisualQuestionsList[i]);
            }

            //Visual
            //----------------------------------------
            foreach (var vq in VisualQuestionsList)
            {
                //groupbox
                vq.GroupBox.Location = new Point(12, 118);
                vq.GroupBox.Size = new Size(1110, 545);
                vq.GroupBox.Text = String.Empty;
                vq.GroupBox.Visible = false;

                //picturebox
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(512, 512);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Image = vq.Img.Any() ? ImgConverter.Base64StringToBitmap(vq.Img) : null;
                vq.GroupBox.Controls.Add(pictureBox);
                pictureBox.Location = new Point(6, 20);

                //labels
                Label labelQst = new Label();
                labelQst.AutoSize = true;
                labelQst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelQst.Text = "Question #" + (VisualQuestionsList.IndexOf(vq) + 1).ToString();
                vq.GroupBox.Controls.Add(labelQst);
                labelQst.Location = new Point(524, 20);

                Label labelPoints = new Label();
                labelPoints.AutoSize = true;
                labelPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelPoints.Text = vq.Points.ToString() + " point(s)";
                vq.GroupBox.Controls.Add(labelPoints);
                labelPoints.Location = new Point(529, 44);

                Label labelQText = new Label();
                labelQText.AutoSize = false;
                labelQText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                labelQText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                labelQText.Text = vq.QuestionText;
                labelQText.Size = new Size(576, 90);
                vq.GroupBox.Controls.Add(labelQText);
                labelQText.Location = new Point(528, 68);

                // answerflow panel
                FlowLayoutPanel flowPanelAnswer = new FlowLayoutPanel();
                flowPanelAnswer.AutoScroll = true;
                flowPanelAnswer.BackColor = SystemColors.ControlLightLight;
                flowPanelAnswer.FlowDirection = FlowDirection.TopDown;
                flowPanelAnswer.Font = new Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                flowPanelAnswer.ForeColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                flowPanelAnswer.Location = new Point(528, 161);
                flowPanelAnswer.Name = "flowPanelDemo";
                flowPanelAnswer.Padding = new Padding(25, 5, 5, 5);
                flowPanelAnswer.Size = new Size(576, 371);
                flowPanelAnswer.TabIndex = 3;
                flowPanelAnswer.WrapContents = false;

                if (vq.CountRight == 1)
                {
                    foreach (var va in vq.VisualAnswersList)
                    {
                        RadioButton rb = new RadioButton();
                        rb.Text = va.AnswerText;
                        rb.Tag = va;
                        rb.CheckedChanged += new EventHandler(RadioCheckChange);
                        rb.Size = new Size(flowPanelAnswer.Width - 50, va.AnswerText.Length < 77 ? 30 : LinesInAnswer(va.AnswerText, flowPanelAnswer) * 21);
                        flowPanelAnswer.Controls.Add(rb);
                    }
                }
                else
                {
                    foreach (var va in vq.VisualAnswersList)
                    {
                        CheckBox cb = new CheckBox();
                        cb.Text = va.AnswerText;
                        cb.Tag = va;
                        cb.CheckedChanged += new EventHandler(CheckBoxCheckChange);
                        cb.Size = new Size(flowPanelAnswer.Width - 50, va.AnswerText.Length < 77 ? 30 : LinesInAnswer(va.AnswerText, flowPanelAnswer) * 21);
                        flowPanelAnswer.Controls.Add(cb);
                    }
                }
                vq.GroupBox.Controls.Add(flowPanelAnswer);
                flowPanelAnswer.Location = new Point(528, 161);
            }

            //Buttons
            ButtonPrev = new Button();
            ButtonPrev.Location = new System.Drawing.Point(757, 669);
            ButtonPrev.Name = "btnPrev";
            ButtonPrev.Size = new System.Drawing.Size(90, 31);
            ButtonPrev.TabIndex = 8;
            ButtonPrev.Text = "<< Previous";
            ButtonPrev.UseVisualStyleBackColor = true;
            ButtonPrev.Click += new EventHandler(Previous);

            ButtonNext = new Button();
            ButtonNext.Location = new System.Drawing.Point(853, 669);
            ButtonNext.Name = "btnNext";
            ButtonNext.Size = new System.Drawing.Size(90, 31);
            ButtonNext.TabIndex = 10;
            ButtonNext.Text = "Next >>";
            ButtonNext.UseVisualStyleBackColor = true;
            ButtonNext.Click += new System.EventHandler(Next);

            // ProgressBar
            ProgressBarList = new List<FlowLayoutPanel>();
            ProgressBarPanel = new FlowLayoutPanel();
            ProgressBarPanel.Size = new System.Drawing.Size(449, 25);
            ProgressBarPanel.Location = new Point(655, 20);

            int count = 0;
            foreach (var vq in VisualQuestionsList)
            {
                FlowLayoutPanel button = new FlowLayoutPanel();
                button.Margin = new Padding(2);
                int width = (ProgressBarPanel.Width - (ProgressBarPanel.Margin.Left + ProgressBarPanel.Margin.Right) * test.Questions.Count) / test.Questions.Count;
                button.Width = width;
                button.Height = ProgressBarPanel.Height - button.Margin.Top - button.Margin.Bottom;
                button.Location = new Point(count * (ProgressBarPanel.Margin.Left + ProgressBarPanel.Margin.Right + width) + ProgressBarPanel.Margin.Left, button.Margin.Top);
                button.BorderStyle = BorderStyle.None;
                button.BackColor = SystemColors.ControlLight;
                button.Cursor = Cursors.Hand;
                button.Click += new EventHandler(QuestionIndicatorClick);

                ProgressBarList.Add(button);
                ProgressBarPanel.Controls.Add(button);
                button.Tag = count;
                count++;
            }

            EnableDisableNextPrev(0);
            ActiveQuestion = VisualQuestionsList[0];
            ActiveQuestion.GroupBox.Controls.Add(ProgressBarPanel);
            ProgressBarList[0].BorderStyle = BorderStyle.FixedSingle;
            ActiveQuestion.GroupBox.Visible = true;
        }

        private void QuestionIndicatorClick(object sender, EventArgs e)
        {
            int pos = VisualQuestionsList.IndexOf(ActiveQuestion);
            ProgressBarList[pos].BorderStyle = BorderStyle.None;

            ActiveQuestion.GroupBox.Controls.Remove(ProgressBarPanel);
            int newPos = (int)((sender as FlowLayoutPanel).Tag);
            EnableDisableNextPrev(newPos);

            ActiveQuestion.GroupBox.Visible = false;
            ActiveQuestion = VisualQuestionsList[newPos];
            ActiveQuestion.GroupBox.Controls.Add(ProgressBarPanel);
            ProgressBarList[newPos].BorderStyle = BorderStyle.FixedSingle;
            ActiveQuestion.GroupBox.Visible = true;
        }

        public void Next(object sender, EventArgs e)
        {
            int pos = VisualQuestionsList.IndexOf(ActiveQuestion);
            ProgressBarList[pos].BorderStyle = BorderStyle.None;

            ActiveQuestion.GroupBox.Controls.Remove(ProgressBarPanel);
            int newPos = ++pos;
            EnableDisableNextPrev(newPos);

            ActiveQuestion.GroupBox.Visible = false;
            ActiveQuestion = VisualQuestionsList[newPos];
            ActiveQuestion.GroupBox.Controls.Add(ProgressBarPanel);
            ProgressBarList[newPos].BorderStyle = BorderStyle.FixedSingle;
            ActiveQuestion.GroupBox.Visible = true;
        }

        public void Previous(object sender, EventArgs e)
        {
            int pos = VisualQuestionsList.IndexOf(ActiveQuestion);
            ProgressBarList[pos].BorderStyle = BorderStyle.None;

            ActiveQuestion.GroupBox.Controls.Remove(ProgressBarPanel);
            int newPos = --pos;
            EnableDisableNextPrev(newPos);

            ActiveQuestion.GroupBox.Visible = false;
            ActiveQuestion = VisualQuestionsList[newPos];
            ActiveQuestion.GroupBox.Controls.Add(ProgressBarPanel);
            ProgressBarList[newPos].BorderStyle = BorderStyle.FixedSingle;
            ActiveQuestion.GroupBox.Visible = true;
        }

        private void EnableDisableNextPrev(int pos)
        {
            if (VisualQuestionsList.Count < 2)
            {
                ButtonPrev.Enabled = ButtonNext.Enabled = false;
                return;
            }
            else
            {
                if (pos == 0)
                {
                    ButtonPrev.Enabled = false;
                    if (!ButtonNext.Enabled)
                        ButtonNext.Enabled = true;
                    ButtonNext.Select();
                    return;
                }
                if (pos == VisualQuestionsList.Count - 1)
                {
                    ButtonNext.Enabled = false;
                    if (!ButtonPrev.Enabled)
                        ButtonPrev.Enabled = true;
                    ButtonPrev.Select();
                    return;
                }
                ButtonNext.Enabled = true;
                ButtonPrev.Enabled = true;
            }
        }

        private void CheckBoxCheckChange(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
                (checkBox.Tag as VisualAnswer).IsChecked = true;
            else
                (checkBox.Tag as VisualAnswer).IsChecked = false;

            int pos = VisualQuestionsList.IndexOf(ActiveQuestion);
            bool isChecked = false;
            foreach (var va in ActiveQuestion.VisualAnswersList)
                isChecked = isChecked || va.IsChecked;
            if (!isChecked)
                ProgressBarList[pos].BackColor = System.Drawing.Color.SandyBrown;
            else
                ProgressBarList[pos].BackColor = System.Drawing.Color.DarkSeaGreen;
        }

        private void RadioCheckChange(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
                (radioButton.Tag as VisualAnswer).IsChecked = true;
            else
                (radioButton.Tag as VisualAnswer).IsChecked = false;

            int pos = VisualQuestionsList.IndexOf(ActiveQuestion);
            bool isChecked = false;
            foreach (var va in ActiveQuestion.VisualAnswersList)
                isChecked = isChecked || va.IsChecked;
            if (!isChecked)
                ProgressBarList[pos].BackColor = System.Drawing.Color.SandyBrown;
            else
                ProgressBarList[pos].BackColor = System.Drawing.Color.DarkSeaGreen;
        }

        private int LinesInAnswer(string text, FlowLayoutPanel panel)
        {
            TextBox tb = new TextBox();
            tb.WordWrap = true;
            tb.Multiline = true;
            tb.Width = 490;
            tb.Font = panel.Font;
            tb.Text = text;

            int count = tb.GetLineFromCharIndex(int.MaxValue) + 1;
            if (tb.Lines.Length == 0)
                --count;
            foreach (string line in tb.Lines)
                if (line == "")
                    --count;
            return count;
        }
    }
}
