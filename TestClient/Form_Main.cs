using BinObjConverterLib;
using DALTestingSystemDB;
using EnumsLib;
using NetCloneLib;
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
        
        bool firstTime = true;
        bool isLoaded = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            lbUser.Text = Globals.userToString;

            await Task.Run(() => 
            {
                Byte[] outgoingPack = DataPack.CreateDataPack(TcpPackType.ClientUserTestsReq);
                NetworkStream stream = Globals.client.GetStream();
                stream.Write(outgoingPack, 0, outgoingPack.Length);
                stream.Flush();
            });

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
                        case TcpPackType.ServerUserTestsAns:
                            //if (isLoaded)
                            //{
                            //    isLoaded = false;
                            //    this.Invoke(new Action(() =>ButtonStartEnDis()));
                            //}
                            tcpPackSize = BitConverter.ToInt32(incomingPack, sizeInt32);
                            DataPart dataPart = (DataPart)BinObjConverter.ByteArrayToObject(incomingPack, sizeInt32 * 2, tcpPackSize);
                            if(!dataParts.Any() || dataParts[0].Id == dataPart.Id)
                                dataParts.Add(dataPart);

                            if (dataParts.Count == dataPart.PartCount)
                            {
                                dataParts = dataParts.OrderBy(d => d.PartNum).ToList();

                                byte[] data = dataParts[0].Buffer;
                                for (int i = 1; i < dataParts.Count; i++)
                                    data = data.Concat(dataParts[i].Buffer).ToArray();

                                Globals.userTests = (List<NetCloneUserTest>)BinObjConverter.ByteArrayToObject(data, 0, data.Length);
                                dataParts.Clear();

                                this.Invoke(new Action(() => lbWait.Visible = false));
                                this.Invoke(new Action(() => FillGridNewTest()));
                                this.Invoke(new Action(() => FillGridCompletedTest()));

                                isLoaded = true;
                                this.Invoke(new Action(() => ButtonStartEnDis()));
                                this.Invoke(new Action(() => ButtonRefreshEnDis()));

                                Byte[] outgoingPack = DataPack.CreateDataPack(TcpPackType.ClientUserTestsReceivedMsg);
                                stream.Write(outgoingPack, 0, outgoingPack.Length);                                

                                if (firstTime)
                                    firstTime = false;
                            }
                            stream.Flush(); 
                            break;
                    }
                }
                catch (Exception ex)
                {
                    this.Invoke(new Action(() => MessageBox.Show("sdsd")));
                    //this.Invoke(new Action(() => ServerStarted()));
                    //return;
                }
            }
        }

        private void FillGridNewTest()
        {
            var list = Globals.userTests
                .Where(x => !x.IsTaked)
                .Select(z => new {
                    Id = z.Test.Id,
                    Title = z.Test.Title,
                    Info = z.Test.Info,
                    Questions = z.Test.Questions.Count,
                    MaxPoints = z.Test.Questions.Select(p => p.Points).Sum().ToString(),
                    PassPercent = z.Test.PassPercent.ToString(),
                    IdUserTest = z.Id
                }).ToList();

            this.dataGridViewNewTest.SelectionChanged -= new System.EventHandler(this.dataGridViewNewTest_SelectionChanged);
            {
                if (firstTime)
                {
                    dataGridViewNewTest.Columns.Clear();
                    bindingSourceNewTest.DataSource = list;
                    dataGridViewNewTest.DataSource = bindingSourceNewTest;
                    dataGridViewNewTest.Columns[0].Width = 50;
                    dataGridViewNewTest.Columns[1].Width = 240;
                    dataGridViewNewTest.Columns[2].Width = 250;
                    dataGridViewNewTest.Columns[3].Width = 80;
                    dataGridViewNewTest.Columns[4].Width = 90;
                    dataGridViewNewTest.Columns[5].Width = 80;
                    dataGridViewNewTest.Columns[6].Visible = false;
                    dataGridViewNewTest.Columns[4].HeaderText = "Max points";
                    dataGridViewNewTest.Columns[5].HeaderText = "Pass %";
                }
                else
                {
                    bindingSourceNewTest.DataSource = list;
                }
                dataGridViewNewTest_WhenRowSelect();
            }
            this.dataGridViewNewTest.SelectionChanged += new System.EventHandler(this.dataGridViewNewTest_SelectionChanged);                    
        }

        private void FillGridCompletedTest()
        {
            var list = Globals.userTests
                .Where(x => x.IsTaked)
                .Select(y => new {
                    Id = y.Test.Id,
                    Title = y.Test.Title,
                    MaxPoints = y.Test.Questions.Select(z => z.Points).Sum(),
                    ScoredPoints = y.PointsGrade,
                    ScoredPercent = y.Test.Questions.Select(z => z.Points).Sum() != 0 ? (decimal)((y.PointsGrade / y.Test.Questions.Select(z => z.Points).Sum()) * 100) : 0,
                    Passed = y.IsPassed,
                    CompletedDate = y.TakedDate == null ? string.Empty : y.TakedDate.ToString()
                }).ToList();

            if (firstTime)
            {
                dataGridViewCompletedTest.Columns.Clear();
                bindingSourceCompletedTest.DataSource = list;
                dataGridViewCompletedTest.DataSource = bindingSourceCompletedTest;
                dataGridViewCompletedTest.Columns[0].Width = 50;
                dataGridViewCompletedTest.Columns[1].Width = 260;
                dataGridViewCompletedTest.Columns[2].Width = 90;
                dataGridViewCompletedTest.Columns[3].Width = 110;
                dataGridViewCompletedTest.Columns[4].Width = 90;
                dataGridViewCompletedTest.Columns[5].Width = 70;
                dataGridViewCompletedTest.Columns[6].Width = 120;
                dataGridViewCompletedTest.Columns[2].HeaderText = "Max points";
                dataGridViewCompletedTest.Columns[3].HeaderText = "Scored points";
                dataGridViewCompletedTest.Columns[4].HeaderText = "Scored %";
                dataGridViewCompletedTest.Columns[6].HeaderText = "Completed date";
            }
            else
                bindingSourceCompletedTest.DataSource = list;
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

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            isLoaded = false;
            ButtonStartEnDis();
            ButtonRefreshEnDis();
            bindingSourceNewTest.Clear();
            bindingSourceCompletedTest.Clear();
            lbWait.Visible = true;

            await Task.Run(() =>
            {
                Byte[] outgoingPack = DataPack.CreateDataPack(TcpPackType.ClientUserTestsReq);
                NetworkStream stream = Globals.client.GetStream();
                stream.Write(outgoingPack, 0, outgoingPack.Length);
                stream.Flush();
            });
        }

        private void ButtonStartEnDis()
        {
            btnStart.Enabled = dataGridViewNewTest.Rows.Count > 0 && dataGridViewNewTest.SelectedRows.Count > 0 && isLoaded;
        }

        private void ButtonRefreshEnDis()
        {
            btnRefresh.Enabled = isLoaded;
        }

        private void dataGridViewNewTest_WhenRowSelect()
        {
            if(dataGridViewNewTest.Rows.Count > 0 && dataGridViewNewTest.SelectedRows.Count > 0)
            {
                Globals.currUserTest = Globals.userTests.FirstOrDefault(x => x.Id == (int)dataGridViewNewTest.CurrentRow.Cells[6].Value); 
            }
        }

        private void dataGridViewNewTest_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewNewTest_WhenRowSelect();
        }
        private void dataGridViewNewTest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnStart_Click(sender, e);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            VisualTest visualTest = new VisualTest(Globals.currUserTest.Test);
            TestForm testForm = new TestForm(OpenTestFormMode.Real, visualTest);
            if(testForm.ShowDialog() == DialogResult.OK)
            {

            }

            //DontWorryForm dontWorryForm = new DontWorryForm();
            //if(dontWorryForm.ShowDialog() == DialogResult.OK)
            //{
                
            //}
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Byte[] byteNetPack = DataPack.CreateDataPack(TcpPackType.ClientFormCloseMsg, null);
            NetworkStream stream = Globals.client.GetStream();
            stream.Write(byteNetPack, 0, byteNetPack.Length);
            stream.Flush();
            stream.Close();
            Globals.client.Close();
        }
    }
}
