using EnumsLib;
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

namespace TestClient
{
    public partial class TestForm : Form
    {
        OpenTestFormMode mode;
        public VisualTest visualTest { get; set; }
        GroupBox activeBox;
        public TestForm()
        {
            InitializeComponent();
        }

        public TestForm(OpenTestFormMode mode)
        {
            this.mode = mode;
            activeBox = groupBox2;
            InitializeComponent();
        }

        public TestForm(OpenTestFormMode mode, VisualTest visualTest)
        {
            this.mode = mode;
            this.visualTest = visualTest;
            VisualQuestion currQuestion = visualTest.VisualQuestionsList[0];
            InitializeComponent();
        }

        
        private async void TestForm_Load(object sender, EventArgs e)
        {
            if(mode == OpenTestFormMode.DemoCheck)
            {
                this.Text = "Demo of multi answer question";
                GenerateDemoCheck();
                btnNext.Select();
                return;
            }

            if (mode == OpenTestFormMode.DemoRadio)
            {
                this.Text = "Demo of one answer question";
                GenerateDemoRadio();
                btnNext.Select();
                return;
            }

            await Task.Run(() => 
            {
                foreach (VisualQuestion question in visualTest.VisualQuestionsList)
                    Invoke(new Action(() => this.Controls.Add(question.GroupBox)));
            });
            // real mode
            lbInfo.Text = visualTest.Info;
            SetQuestion(visualTest.VisualQuestionsList[0]);
        }


        private void SetQuestion(VisualQuestion q)
        {
            groupBox2.Visible = false;
            q.GroupBox.Visible = true;
            //if (activeBox == null)
            //{
            //    activeBox = q.GroupBox;
            //}
            //else
            //{
            //    activeBox.Visible = false;
            //    activeBox = q.GroupBox;
            //    activeBox.Visible = true;
            //}

        }

        private void TestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mode != OpenTestFormMode.Real)
            {
                flowPanelProgress.Visible = false;
                flowPanelDemo.Visible = false;
            }
        }


        #region Demo
        private void GenerateDemoRadio()
        {
            Random rand = new Random();
            for (int i = listDemo.Count() - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                (listDemo[i], listDemo[j]) = (listDemo[j], listDemo[i]);
            }

            foreach (var item in listDemo)
            {
                RadioButton rb = new RadioButton();
                rb.Text = item;
                rb.Size = new Size(flowPanelDemo.Width - 50, item.Length < 77 ? 30 : LinesInAnswer(item.ToString()) * 21);
                flowPanelDemo.Controls.Add(rb);
            }
        }

        private void GenerateDemoCheck()
        {
            Random rand = new Random();
            for (int i = listDemo.Count() - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                (listDemo[i], listDemo[j]) = (listDemo[j], listDemo[i]);
            }

            foreach (var item in listDemo)
            {
                CheckBox cb = new CheckBox();
                cb.Text = item;
                cb.Size = new Size(flowPanelDemo.Width - 50, item.Length < 77 ? 30 : LinesInAnswer(item.ToString()) * 21);
                flowPanelDemo.Controls.Add(cb);
            }
        }

        List<string> listDemo = new List<string>() {
            "Lorem ipsum dolor sit amet consectetur adipisicing elit. Reprehenderit, voluptatum adipisci aperiam consequatur beatae sequi obcaecati repellendus dolorem, hic, corporis aliquid ad nulla mollitia iure.",
            "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Et necessitatibus possimus facere suscipit, ipsam ipsa ad in modi enim! Ad aut labore iusto repudiandae non assumenda quisquam molestiae! Ut quaerat mollitia numquam dolor nemo aliquid deserunt totam officiis voluptates doloremque?",
            "Lorem ipsum dolor sit amet consectetur adipisicing elit. Doloremque error quae obcaecati rem libero repellat recusandae nam voluptatem at?",
            "Lorem ipsum dolor sit amet consectetur adipisicing elit. Vel, dolor.",
            "Lorem ipsum dolor sit amet consectetur adipisicing elit. Ad, illo possimus corrupti minus repellendus sed reprehenderit quis voluptatum nulla fuga? Est tenetur dolore labore maxime? Ratione placeat consectetur molestias obcaecati atque porro cum aperiam maiores!",
            };

        private int LinesInAnswer(string text)
        {
            TextBox tb = new TextBox();
            tb.WordWrap = true;
            tb.Multiline = true;
            tb.Width = 490;
            tb.Font = flowPanelDemo.Font;
            tb.Text = text;

            int count = tb.GetLineFromCharIndex(int.MaxValue) + 1;
            if (tb.Lines.Length == 0)
                --count;
            foreach (string line in tb.Lines)
                if (line == "")
                    --count;
            return count;
        }
        #endregion Demo


    }
}
