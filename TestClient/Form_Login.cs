using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinObjConverterLib;
using EnumsLib;
using NetPackLib;
using SHA512Lib;
using TestClient.Properties;

namespace TestClient
{
    public partial class LoginForm : Form
    {
        public string Login { get; set; }
        public string Password { get; set; }
        bool isOnline = false;


        TcpPackType tcpPackType;

        public LoginForm()
        {
            InitializeComponent();
            tbLog.Text = "admin";
            tbPass.Text = "admin";
        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            await Task.Run(() => ServerStarted());
            lbMessage.Visible = false;
            pictureBox.Image = Resources.isconnect;
            tbLog.Select();
        }

        private void ServerStarted()
        {
            while (!isOnline)
            {
                try
                {
                    Globals.client = new TcpClient("127.0.0.1", 13000);
                    isOnline = true;
                    this.Invoke(new Action(() => IsLogAndPassAndServer()));
                }
                catch (Exception)
                {
                    this.Invoke(new Action(() => this.lbMessage.Text = "Server Not Started"));
                    this.Invoke(new Action(() => this.lbMessage.Visible = true));
                    Thread.Sleep(2000);
                }
            }
        }


        private void btnOK_Click(object sender, EventArgs e)
        {       
            // string
            Login = tbLog.Text;
            Password = tbPass.Text.GetSha512();
            string[] LogPassStrArr = new string[] { Login, Password };

            // netPack
            Byte[] byteNetPack = NetPack.CreateNetPack(TcpPackType.ClientAuthDataPack, LogPassStrArr);

            // Write to NetStream
            NetworkStream stream = Globals.client.GetStream();
            stream.Write(byteNetPack, 0, byteNetPack.Length);
            stream.Flush();

            Task receiveTask = new Task(() =>
            {
                ClientReceive();
            });
            receiveTask.Start();
        }

        private void ClientReceive()
        {
            int sizeInt32 = sizeof(Int32);
            byte[] incomingPack = new byte[61440];
            while (true)
            {
                try
                {
                    NetworkStream stream = Globals.client.GetStream();
                    stream.Read(incomingPack, 0, incomingPack.Length);
                    tcpPackType = (TcpPackType)BitConverter.ToInt32(incomingPack, 0);
                    int tcpPackSize = BitConverter.ToInt32(incomingPack, sizeInt32);
                    switch (tcpPackType)
                    {
                        case TcpPackType.ServerAuthAnswerPack:
                            bool auth = (bool)BinObjConverter.ByteArrayToObject(incomingPack, sizeInt32 * 2, tcpPackSize);
                            if (auth)
                            {
                                this.Invoke(new Action(() => this.lbMessage.ForeColor = Color.Green));
                                this.Invoke(new Action(() => this.lbMessage.Text = "OK"));
                                this.Invoke(new Action(() => this.lbMessage.Visible = true));
                                Thread.Sleep(1000);
                                this.Invoke(new Action(() => this.DialogResult = DialogResult.OK));
                                return;
                            }
                            else
                            {
                                this.Invoke(new Action(() => this.lbMessage.Text = "Authorization fail"));
                                this.Invoke(new Action(() => this.lbMessage.Visible = true));
                            }
                            break;
                        case TcpPackType.ServerStopOrClosePack:
                            isOnline = false;
                            this.Invoke(new Action(() => ServerStarted()));
                            return;
                    }
                }
                catch
                {
                    isOnline = false;
                    this.Invoke(new Action(() => ServerStarted()));
                    return;
                }
            }
        }

        private void IsLogAndPassAndServer()
        {
            btnOK.Enabled = tbLog.Text.Any() && tbPass.Text.Any() && isOnline;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            IsLogAndPassAndServer();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isOnline && this.DialogResult != DialogResult.OK)
            {
                Byte[] byteNetPack = NetPack.CreateNetPack(TcpPackType.ClientFormClosePack, null);
                NetworkStream stream = Globals.client.GetStream();
                stream.Write(byteNetPack, 0, byteNetPack.Length);
                stream.Flush();
                stream.Close();
                Globals.client.Close();
            }
        }
    }
}
