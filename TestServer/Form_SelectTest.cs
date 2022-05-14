using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestServer
{
    public partial class SelectTestForm : Form
    {
        OpenMode openMode;
        public DALTestingSystemDB.Test Test  { get; set; }
        public List<DALTestingSystemDB.Test> Tests { get; set; }
        public SelectTestForm(List<DALTestingSystemDB.Test> tests, OpenMode mode)
        {
            openMode = mode;
            Tests = tests;
            InitializeComponent();
        }

        private void SelectTestForm_Load(object sender, EventArgs e)
        {
            this.Text = openMode == OpenMode.NewTestForUser ? "Select new test for User" : "Select new test for Group";
            dataGridView.Columns.Clear();
            bindingSource.DataSource = Tests;
            dataGridView.DataSource = bindingSource;
            for (int i = 4; i <= 9; i++)
                if (i != 6 && i != 7)
                    dataGridView.Columns[i].Visible = false;
            dataGridView.Columns[0].Width = 50;
            dataGridView.Columns[1].Width = 260;
            dataGridView.Columns[2].Width = 170;
            dataGridView.Columns[3].Width = 260;
            dataGridView.Columns[6].Width = 80;
            dataGridView.Columns[7].Width = 120;
            dataGridView.Columns[6].HeaderText = "Archived";
            dataGridView.Columns[7].HeaderText = "Loaded date";
            textBox.Select();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Test = dataGridView.CurrentRow.DataBoundItem as DALTestingSystemDB.Test;
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnOk_Click(sender, e);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (!textBox.Text.Any()) return;
            DataGridViewRow row = dataGridView.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["Title"].Value.ToString().ToLower().StartsWith(textBox.Text.ToLower()))
                .FirstOrDefault();
            if (row != null)
                dataGridView.CurrentCell = dataGridView.Rows[row.Index].Cells[0];
        }
    }
}
