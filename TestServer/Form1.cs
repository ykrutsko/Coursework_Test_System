using DALTestingSystemDB;
using RepositoryLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestServer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripButtonUser_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.MdiParent = this;
            userForm.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GenericUnitOfWork work = new GenericUnitOfWork(new TestSystemContext(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString));
            IGenericRepository<User> repoUser = work.Repository<User>();
            IGenericRepository<Group> repoGroup = work.Repository<Group>();

            var a = repoUser.GetAll();
            
        }
    }
}
