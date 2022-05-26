using DALTestingSystemDB;
using RepositoryLib;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestServer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createNew;
            Mutex mutex = new Mutex(false, "TestServerMutex", out createNew);
            if (!createNew)
            {
                MessageBox.Show("TEST SERVER instance is already running!", "Test server", MessageBoxButtons.OK,MessageBoxIcon.Information);
                Application.Exit();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
