using DALTestingSystemDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestServer
{
    public partial class SelectGroupForm : Form
    {
        OpenMode openMode;
        public DALTestingSystemDB.Group Group { get; set; }
        public List<DALTestingSystemDB.Group> Groups { get; set; }
        public SelectGroupForm(List<DALTestingSystemDB.Group> groups, OpenMode mode)
        {
            Groups = groups;
            openMode = mode;
            InitializeComponent();
        }
        private void NewGroupForUserForm_Load(object sender, EventArgs e)
        {
            switch(openMode)
            {
                case OpenMode.NewGroupForUser:
                    this.Text = "Select new groups for user";
                    break;
            }
            bindingSource.DataSource = Groups;
            dataGridView.DataSource = bindingSource;
            dataGridView.Columns[0].Width = 50;
            dataGridView.Columns[1].Width = 140;
            dataGridView.Columns[2].Width = 190;
            dataGridView.Columns[3].Width = 100;
            dataGridView.Columns[4].Visible = false;
            dataGridView.Columns[3].HeaderText = "Admin group";
            textBox1.Select();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!textBox1.Text.Any()) return;
            DataGridViewRow row = dataGridView.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["Name"].Value.ToString().ToLower().StartsWith(textBox1.Text.ToLower()))
                .FirstOrDefault();
            if (row != null)
                dataGridView.CurrentCell = dataGridView.Rows[row.Index].Cells[0];
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Group = dataGridView.CurrentRow.DataBoundItem as DALTestingSystemDB.Group; 
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnOK_Click(sender, e);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
