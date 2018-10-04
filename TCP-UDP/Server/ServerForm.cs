using ForTCP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Server
{
    public partial class ServerForm : Form
    {
        TCPServer tCPServer;
        UdpClient UdpClient;
        UdpClient UdpServer;
        List<string> end_points = new List<string>();
        string kk = "";
        public ServerForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void EXITEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tCPServer != null)
            {
                tCPServer.CloseServer();
            }
            Application.Exit();
        }

        private void OpenTCPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tCPServer = new TCPServer();
            if (tCPServer.startServer(IPAddress.Any, tBPort.Text.Trim()))
            {
                rtbMSG.Text += "TCP服务开启成功\n";
                getEndPoint();
            }
            else
            {
                rtbMSG.Text += "TCP服务开启失败\n";
            }
        }


        ///<summary>                                
        /// 传入域名返回对应的IP 转载请注明来自
        ///</summary>
        ///<param name="domain">域名</param> 
        ///<returns></returns>   
        public string getIP(string domain)
        {
            domain = domain.Replace("http://", "").Replace("https://", "");
            IPHostEntry hostEntry = Dns.GetHostEntry(domain);
            IPEndPoint ipEndPoint = new IPEndPoint(hostEntry.AddressList[0], 0);
            return ipEndPoint.Address.ToString();
        }

        private void CloseTCPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tCPServer.CloseServer();
            rtbMSG.Text += "服务已关闭\n";
        }

        private void getEndPoint()
        {
            Timer T = new Timer();
            T.Interval = 100;
            T.Enabled = true;
            T.Tick += T_Tick;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            if (kk != TCPServer.msg)
            {
                rtbMSG.Text += TCPServer.msg.Split('-')[0] + "已接收>>" + TCPServer.msg.Split('-')[1] + "\n";
                kk = TCPServer.msg;
            }
            foreach (string item in tCPServer.Dic_ClientSession.Keys)
            {
                if (!cLBConnected.Items.Contains(item))
                {
                    cLBConnected.Items.Add(item);
                }
            }
        }

        private void closeSelectedSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cLBConnected.Items.Count; i++)
            {
                if (cLBConnected.GetItemChecked(i))
                {
                    tCPServer.CloseServer(cLBConnected.GetItemText(cLBConnected.Items[i]).Trim());
                    cLBConnected.Items.RemoveAt(i);
                }
            }
        }

        private void cBAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cBAll.Checked)
            {
                for (int j = 0; j < cLBConnected.Items.Count; j++)
                    cLBConnected.SetItemChecked(j, true);
            }
            else
            {
                for (int j = 0; j < cLBConnected.Items.Count; j++)
                    cLBConnected.SetItemChecked(j, false);
            }
        }

        private void BTSend_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cLBConnected.Items.Count; i++)
            {
                if (cLBConnected.GetItemChecked(i))
                {
                    if (rBCmd.Checked)
                    {
                        tCPServer.SendData(1, cLBConnected.GetItemText(cLBConnected.Items[i]).Trim(), Encoding.UTF8.GetBytes(tBText.Text.Trim()));
                        rtbMSG.Text += "已发送cmd命令>>" + tBText.Text.Trim() + "\n";
                    }
                    else if (rBText.Checked)
                    {
                        tCPServer.SendData(0, cLBConnected.GetItemText(cLBConnected.Items[i]).Trim(), Encoding.UTF8.GetBytes(tBText.Text.Trim()));
                        rtbMSG.Text += "已发送Text文字>>" + tBText.Text.Trim() + "\n";
                    }
                    tBText.Text = "";
                }
                else
                {
                    MessageBox.Show("请选择要发送到的地方");
                }
            }
        }

        private void OpenUDPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbMsgHistory.Text += "UDP监听已开启\n";
            Thread th_UDPServer = new Thread(UDPReceive);
            th_UDPServer.IsBackground = true;
            th_UDPServer.Start();
        }
        private void UDPReceive()
        {
            IPEndPoint localPoint = new IPEndPoint(IPAddress.Any, int.Parse(tbUDPPortToBind.Text.Trim()));
            UdpServer = new UdpClient();
            UdpServer.Client.Bind(localPoint);
            while (true)
            {
                byte[] receiveData = null;
                string receiveString = null;
                receiveData = UdpServer.Receive(ref localPoint);//接收数据 
                receiveString = Encoding.Default.GetString(receiveData);
                tbMsgHistory.Text += "接收到>>" + receiveString + "\n";
            }
        }

        private void CloseUDPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btSendFile_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cLBConnected.Items.Count; i++)
            {
                if (cLBConnected.GetItemChecked(i))
                {
                    string filePath = "";
                    string fileName = "";
                    OpenFileDialog ofd = new OpenFileDialog();
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        filePath = ofd.FileName;
                        fileName = ofd.SafeFileName;
                        SendBigFile(fileName, filePath, tCPServer.Dic_ClientSession[cLBConnected.Items[i].ToString().Trim()].Socket);
                    }
                    rtbMSG.Text += "已发送cmd命令wenjian>>" + tBText.Text.Trim() + "\n";
                }
                else
                {
                    MessageBox.Show("请选择要发送到的地方");
                }
            }
        }
        /// <summary>
        /// 大文件断点传送
        /// </summary>
        private void SendBigFile(string name, string path, Socket socket)
        {
            try
            {
                //读取选择的文件
                using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    //1. 第一步：发送一个包，表示文件的长度，让客户端知道后续要接收几个包来重新组织成一个文件
                    long length = fsRead.Length;
                    byte[] byteName = Encoding.UTF8.GetBytes(name);
                    //获得发送的信息时候，在数组前面加上一个字节 1
                    List<byte> list = new List<byte>();
                    list.Add(2);
                    list.AddRange(byteName);
                    socket.Send(list.ToArray()); //
                    //2. 第二步：每次发送一个1MB的包，如果文件较大，则会拆分为多个包
                    byte[] buffer = new byte[1024 * 1024];
                    long send = 0; //发送的字节数                  
                    while (true)  //大文件断点多次传输
                    {
                        int r = fsRead.Read(buffer, 0, buffer.Length);
                        if (r == 0)
                        {
                            break;
                        }
                        socket.Send(buffer, 0, r, SocketFlags.None);
                        send += r;
                        rtbMSG.Text += string.Format("{0}: 已发送：{1}/{2}", socket.RemoteEndPoint, send, length);
                    }
                }
            }
            catch
            {

            }
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            if (tbHost.Text != "" && tBPort.Text != "")
            {
                string ip="";
                if (rBip.Checked)
                {
                    ip = tbHost.Text.Trim();
                }
                if (rBDomain.Checked)
                {
                    ip = getIP(tbHost.Text.Trim());
                }
                string sendString = null;//要发送的字符串 
                byte[] sendData = null;//要发送的字节数组 
                IPAddress remoteIP = IPAddress.Parse(ip); //假设发送给这个IP
                int remotePort = int.Parse(tbUDPPort.Text.Trim());
                IPEndPoint remotePoint = new IPEndPoint(remoteIP, remotePort);//实例化一个远程端点 
                sendString = tbMsg.Text.Trim();
                sendData = Encoding.Default.GetBytes(sendString);
                UdpClient = new UdpClient();
                UdpClient.Send(sendData, sendData.Length, remotePoint);//将数据发送到远程端点 
                tbMsgHistory.Text += "已发送至"+ remotePoint+">>"+ sendString + "\n";
            }
           
        }
    }
}
