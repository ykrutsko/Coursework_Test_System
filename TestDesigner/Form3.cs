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
    public partial class AnswerForm : Form
    {
        Mode mode;
        public Answer CurrAnswer { get; set; }

        public AnswerForm(Mode mode)
        {
            this.mode = mode;
            CurrAnswer = new Answer();
            FormSettings();
            InitializeComponent();
        }

        public AnswerForm(Mode mode, Answer answer)
        {
            this.mode = mode;
            CurrAnswer = answer;
            FormSettings();
            InitializeComponent();
        }

        //Form settings
        void FormSettings()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void AnswerForm_Load(object sender, EventArgs e)
        {
            switch (mode)
            {
                case Mode.Add:
                    Text = "Answer [Add mode]";
                    tbAnswer.Text = string.Empty;
                    cbIsRight.Checked = false;
                    break;
                case Mode.AddByCopy:
                    Text = "Answer [Add by copy mode]";
                    tbAnswer.Text = CurrAnswer.TextAnswer;
                    cbIsRight.Checked = CurrAnswer.IsRight;
                    break;
                case Mode.Edit:
                    Text = "Answer [Edit mode]";
                    tbAnswer.Text = CurrAnswer.TextAnswer;
                    cbIsRight.Checked = CurrAnswer.IsRight;
                    break;
            }
            tbAnswer.Select();
        }

        private void tbAnswer_TextChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = !string.IsNullOrEmpty(tbAnswer.Text);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CurrAnswer.TextAnswer = tbAnswer.Text;
            CurrAnswer.IsRight = cbIsRight.Checked;
        }
    }
}
