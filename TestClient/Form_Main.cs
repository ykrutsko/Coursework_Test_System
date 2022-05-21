using BinObjConverterLib;
using DALTestingSystemDB;
using EnumsLib;
using NetPackLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestClient
{
    public partial class MainForm : Form
    {
        TcpPackType tcpPackType;
        List<UserTest> userTests  = new List<UserTest>();
        bool isLoaded = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbUser.Text = Globals.userToString;

            Byte[] outgoingPack = DataPack.CreateDataPack(TcpPackType.ClientUserTestsRequestPack);
            NetworkStream stream = Globals.client.GetStream();
            stream.Write(outgoingPack, 0, outgoingPack.Length);
            stream.Flush();

            Task receiveTask = new Task(() =>
            {
                ClientReceive();
            });
            receiveTask.Start();

            timer.Start();
        }

        private void ClientReceive()
        {     
            int sizeInt32 = sizeof(Int32);
            byte[] incomingPack = new byte[61440];
            int tcpPackSize = 0;
            List<DataPart> dataParts = new List<DataPart>();
            while (true)
            {
                try
                {
                    NetworkStream stream = Globals.client.GetStream();
                    stream.Read(incomingPack, 0, incomingPack.Length);
                    tcpPackType = (TcpPackType)BitConverter.ToInt32(incomingPack, 0);
                    switch (tcpPackType)
                    {
                        case TcpPackType.ServerUserTestsAnswerPack:
                            tcpPackSize = BitConverter.ToInt32(incomingPack, sizeInt32);
                            DataPart dataPart = (DataPart)BinObjConverter.ByteArrayToObject(incomingPack, sizeInt32 * 2, tcpPackSize);
                            if(!dataParts.Any() || dataParts[0].Id == dataPart.Id)
                            {
                                dataParts.Add(dataPart);
                            }

                            if (dataParts.Count == dataPart.PartCount)
                            {
                                dataParts = dataParts.OrderBy(d => d.PartNum).ToList();

                                byte[] data = dataParts[0].Buffer;
                                for (int i = 1; i < dataParts.Count; i++)
                                    data = data.Concat(dataParts[i].Buffer).ToArray();

                                userTests = (List<UserTest>)BinObjConverter.ByteArrayToObject(data, 0, data.Length);
                                //this.Invoke(new Action(() => bindingSourceNewTest.DataSource = userTests[0]));
                                //this.Invoke(new Action(() => dataGridViewNewTest.DataSource = bindingSourceNewTest));

                                dataParts.Clear();
                                isLoaded = true;
                            }
                            break;
                    }
                }
                catch
                {
                    this.Invoke(new Action(() => MessageBox.Show("sdsd")));
                    //this.Invoke(new Action(() => ServerStarted()));
                    //return;
                }
            }
        }



        private void btnRadioDemo_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm(OpenTestFormMode.DemoRadio);
            testForm.ShowDialog();
        }

        private void btnCheckDemo_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm(OpenTestFormMode.DemoCheck);
            testForm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Globals.client.Close();
        }


        private void FillGridNewTest()
        {
            dataGridViewNewTest.Columns.Clear();
            var list = userTests
                .Where(x => !x.IsTaked)
                .Select(x => x.Test)
                .Select(x => new {
                    Id = x.Id, 
                    Title = x.Title, 
                    Info = x.Info, 
                    Questions = x.Questions.Count,
                    MaxPoints = x.Questions.Select(y => y.Points).Sum().ToString(),
                    PassPercent = x.PassPercent                
                }).ToList();

            bindingSourceNewTest.DataSource = list;
            dataGridViewNewTest.DataSource = bindingSourceNewTest;
            dataGridViewNewTest.Columns[0].Width = 50;
            dataGridViewNewTest.Columns[1].Width = 240;
            dataGridViewNewTest.Columns[2].Width = 250;
            dataGridViewNewTest.Columns[3].Width = 80;
            dataGridViewNewTest.Columns[4].Width = 90;
            dataGridViewNewTest.Columns[5].Width = 80;

            dataGridViewNewTest.Columns[4].HeaderText = "Max points";
            dataGridViewNewTest.Columns[5].HeaderText = "Pass %";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(isLoaded)
            {
                FillGridNewTest();
                timer.Stop();
            }
        }
    }
}
