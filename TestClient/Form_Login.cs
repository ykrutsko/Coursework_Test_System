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
            tbLog.Text = "Student";
            tbPass.Text = "123";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            LetStart();
        }

        private void LetStart()
        {
            isOnline = false;
            IsLogAndPassAndServer();
            Task IsServerOnlineTask = new Task(() => ServerStarted());
            Task receiveTask = IsServerOnlineTask.ContinueWith(x => ClientReceive());
            IsServerOnlineTask.Start();
        }

        private void ServerStarted()
        {
            while (!isOnline)
            {
                try
                {
                    Globals.client = new TcpClient("127.0.0.1", 5000);
                    this.Invoke(new Action(() => 
                    {
                        lbMessage.Visible = false;
                        pictureBox.Image = Resources.isconnect;
                        tbLog.Select();
                    }));
                    isOnline = true;
                    this.Invoke(new Action(() => IsLogAndPassAndServer()));
                    break;
                }
                catch (Exception)
                {
                    isOnline = false;
                    this.Invoke(new Action(() => this.pictureBox.Image = Resources.noconnect));
                    this.Invoke(new Action(() => this.lbMessage.Text = "Server NOT started"));
                    this.Invoke(new Action(() => this.lbMessage.Visible = true));
                    Thread.Sleep(2000);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Login = tbLog.Text;
            Password = tbPass.Text.GetSha512();
            string[] LogPassStrArr = new string[] { Login, Password };
            Byte[] outgoingPack = DataPack.CreateDataPack(TcpPackType.ClientAuthReq, LogPassStrArr);
            try
            {
                NetworkStream stream = Globals.client.GetStream();
                stream.Write(outgoingPack, 0, outgoingPack.Length);
            }
            catch
            {
                Globals.client.Close();
                LetStart();
                return;
            }
        }

        private void ClientReceive()
        {
            int sizeInt32 = sizeof(Int32);
            byte[] incomingPack = new byte[61440];
            Byte[] outgoingPack = null;
            int tcpPackSize = 0;
            while (true)
            {
                try
                {
                    NetworkStream stream = Globals.client.GetStream();
                    stream.Read(incomingPack, 0, incomingPack.Length);
                    tcpPackType = (TcpPackType)BitConverter.ToInt32(incomingPack, 0);
                    switch (tcpPackType)
                    {
                        case TcpPackType.ServerAuthAns:
                            tcpPackSize = BitConverter.ToInt32(incomingPack, sizeInt32);
                            string answer = (string)BinObjConverter.ByteArrayToObject(incomingPack, sizeInt32 * 2, tcpPackSize);

                            if (answer == "OK")
                            {
                                this.Invoke(new Action(() => this.lbMessage.ForeColor = Color.Green));
                                this.Invoke(new Action(() => this.lbMessage.Text = "OK"));
                                this.Invoke(new Action(() => this.lbMessage.Visible = true));
                                outgoingPack = DataPack.CreateDataPack(TcpPackType.ClientUserIdReq);
                                stream.Write(outgoingPack, 0, outgoingPack.Length);
                            }
                            else
                            {
                                this.Invoke(new Action(() => this.lbMessage.Text = answer));
                                this.Invoke(new Action(() => this.lbMessage.Visible = true));
                            }
                            break;

                        case TcpPackType.ServerUserIdAns:
                            tcpPackSize = BitConverter.ToInt32(incomingPack, sizeInt32);
                            Globals.userId = (int)BinObjConverter.ByteArrayToObject(incomingPack, sizeInt32 * 2, tcpPackSize);

                            outgoingPack = DataPack.CreateDataPack(TcpPackType.ClientUserToStringReq);
                            stream.Write(outgoingPack, 0, outgoingPack.Length);
                            break;

                        case TcpPackType.ServerUserToStringAns:
                            tcpPackSize = BitConverter.ToInt32(incomingPack, sizeInt32);
                            Globals.userToString = (string)BinObjConverter.ByteArrayToObject(incomingPack, sizeInt32 * 2, tcpPackSize);
                            this.Invoke(new Action(() => this.DialogResult = DialogResult.OK));
                            Thread.Sleep(1000);
                            return;

                        case TcpPackType.ServerStopOrCloseMsg:
                            Globals.client.Close();
                            LetStart();
                            return;
                    }
                }
                catch
                {
                    LetStart();
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
            if (isOnline && DialogResult != DialogResult.OK)
            {
                Byte[] byteNetPack = DataPack.CreateDataPack(TcpPackType.ClientFormCloseMsg, null);
                NetworkStream stream = Globals.client.GetStream();
                stream.Write(byteNetPack, 0, byteNetPack.Length);
                stream.Close();
                Globals.client.Close();
            }
        }
    }
}