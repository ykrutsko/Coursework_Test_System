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
            InitializeComponent();
            activeBox = groupBox2;
            activeBox.Visible = true;
        }

        public TestForm(OpenTestFormMode mode, VisualTest visualTest)
        {
            this.mode = mode;
            this.visualTest = visualTest;
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

            this.Text = visualTest.ToString();
            groupBox2.Visible = btnPrev.Visible = btnNext.Visible = false;
            await Task.Run(() => 
            {                
                Invoke(new Action(() => this.Controls.Add(visualTest.ButtonNext)));
                Invoke(new Action(() => this.Controls.Add(visualTest.ButtonPrev)));
                foreach (VisualQuestion question in visualTest.VisualQuestionsList)
                    Invoke(new Action(() => this.Controls.Add(question.GroupBox)));
            });

            lbInfo.Text = visualTest.Info;
        }

        private void TestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mode == OpenTestFormMode.Real)
            {
                var dialog = MessageBox.Show("Are you sure you want to finish?", visualTest.ToString(), MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialog != DialogResult.OK)
                {
                    e.Cancel = true;
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
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
                int lines = LinesInAnswer(item.ToString());
                rb.Size = new Size(flowPanelDemo.Width - 50, lines == 1 ? 30 : lines * 21);
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
                int lines = LinesInAnswer(item.ToString());
                cb.Size = new Size(flowPanelDemo.Width - 50, lines == 1 ? 30 : lines * 21);
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
            tb.Width = 496;
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
