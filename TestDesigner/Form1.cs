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
    public partial class MainForm : Form
    {
        string currFilePath = string.Empty;
        Test currTest;
        Test currChangedTest;
        int currHashCode;
        

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currTest = currChangedTest = new Test();
            currHashCode = currTest.GetHashCode();
            FillForm();
            dataGridViewQuestions.Columns[0].Width = 500;
            dataGridViewQuestions.Columns[0].HeaderText = "Question";
            dataGridViewQuestions.Columns[1].Width = 90;
            dataGridViewQuestions.Columns[1].HeaderText = "Point";
            dataGridViewQuestions.Columns[2].Visible = false;
            tbAuthor.Select();
        }

        // Main menu
        //---------------------------------------------------------------------
        //Create
        private void greateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(currHashCode != currTest.GetHashCode())
            {
                var dialogResult = MessageBox.Show(
                    "Save changes to current test?", 
                    currFilePath.Any()? currFilePath : "New test", 
                    MessageBoxButtons.YesNoCancel, 
                    MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                }
                else if (dialogResult == DialogResult.Cancel)
                    return;
            }
            currTest = new Test();
            FillForm();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Save
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!currFilePath.Any())
            {
                saveFileDialogTest.Filter = "XML files (*.xml)|*.xml";
                saveFileDialogTest.FilterIndex = 1;
                saveFileDialogTest.RestoreDirectory = true;
                if (saveFileDialogTest.ShowDialog() == DialogResult.OK)
                {
                    currFilePath = saveFileDialogTest.FileName;
                    currTest.Serialize(currFilePath);
                }
            }
            else
            {
                currTest.Serialize(currFilePath);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //---------------------------------------------------------------------


        // Helpfull
        //---------------------------------------------------------------------
        void FillForm()
        {
            tbAuthor.Text = currTest.Author; 
            tbTitle.Text = currTest.Title; 
            tbDescription.Text = currTest.Description;
            tbInfo.Text = currTest.Info;    
            tbCountOfQuestions.Text = currTest.Questions.Count.ToString();
            tbMaxPointsForTest.Text = currTest.Questions.Select(x => x.Points).Sum().ToString();
            numericUpDownMinPass.Value = currTest.PassPercent;
            dataGridViewQuestions.DataSource = currTest.Questions;
            //Question question = dataGridViewQuestions.SelectedRows;
        }



    }
}
