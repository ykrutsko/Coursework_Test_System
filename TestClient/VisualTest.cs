using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestClient
{
    public class VisualTest
    {
        public string Info { get; set; }

        public FlowLayoutPanel FlowPanelProgress { get; set; }
        public List<FlowLayoutPanel> QuestionIndicators { get; set; }
        public List<VisualQuestion> VisualQuestions { get; set; }

        public VisualTest(NetCloneLib.NetCloneTest test)
        {
            Info = test.Info;
            QuestionIndicators = new List<FlowLayoutPanel>();
            VisualQuestions = new List<VisualQuestion>();

            FlowPanelProgress = new FlowLayoutPanel();
            FlowPanelProgress.Size = new System.Drawing.Size(449, 25);

            int width = 0;
            int count = 0;
            foreach (var item in test.Questions)
            {
                FlowLayoutPanel questionindicator = new FlowLayoutPanel();
                questionindicator.Margin = new Padding(2);
                width = (FlowPanelProgress.Width - (FlowPanelProgress.Margin.Left + FlowPanelProgress.Margin.Right) * test.Questions.Count) / test.Questions.Count;
                questionindicator.Width = width;
                questionindicator.Height = FlowPanelProgress.Height - questionindicator.Margin.Top - questionindicator.Margin.Bottom;
                questionindicator.Location = new System.Drawing.Point(count * (FlowPanelProgress.Margin.Left + FlowPanelProgress.Margin.Right + width) + FlowPanelProgress.Margin.Left, questionindicator.Margin.Top);
                questionindicator.BorderStyle = BorderStyle.FixedSingle;
                questionindicator.BackColor = SystemColors.ControlLight;
                questionindicator.Tag = item;
                questionindicator.Click += new EventHandler(QuestionIndicatorClick);
                QuestionIndicators.Add(questionindicator);
                FlowPanelProgress.Controls.Add(questionindicator);

                count++;
            }

        }

        private void QuestionIndicatorClick(object sender, EventArgs e)
        {
            FlowLayoutPanel flp = sender as FlowLayoutPanel;
        }
    }
}
