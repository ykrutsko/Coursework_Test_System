using DALTestingSystemDB;
using RepositoryLib;
using SHA512Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestServer.Properties;

namespace TestServer
{
    public partial class LoginForm : Form
    {
        public string Login { get; set; }
        public string Password { get; set; }
        bool IsConnectToDB = false;
        List<User> users;

        public LoginForm()
        {
            InitializeComponent();
            tbLog.Text = "admin";
            tbPass.Text = "admin";
        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            tbLog.Select();

            await Task.Run(() =>
            {
                var database = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestSystemDB.mdf");
                var conString = $"Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={database};Integrated Security = True; Connect Timeout = 30";
                Globals.work = new GenericUnitOfWork(new TestSystemContext(conString));
                Globals.repoUser = Globals.work.Repository<User>();
                users = Globals.repoUser.FindAll(x => x.IsAdmin).ToList();
            });
            pictureBox.Image = Resources.isconnect;
            IsConnectToDB = true;
            EnDisButtonOk();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Login = tbLog.Text.ToLower();
            Password = tbPass.Text.GetSha512();
            User user = users.FirstOrDefault(x => x.Login.ToLower().Equals(Login)) as User;

            if (user == null)
            {
                lbMessage.Visible = true;
                lbMessage.Text = "No such admin account was found...";
                tbLog.Select();
                return;
            }

            if (!user.Password.Equals(Password, StringComparison.OrdinalIgnoreCase))
            {
                lbMessage.Visible = true;
                lbMessage.Text = "Wrong password. Try again...";
                tbPass.Select();
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void TextBox_TextChange(object sender, EventArgs e)
        {
            EnDisButtonOk();
        }

        private void EnDisButtonOk()
        {
            btnOK.Enabled = tbLog.Text.Any() && tbPass.Text.Any() && IsConnectToDB;
        }
    }
}
