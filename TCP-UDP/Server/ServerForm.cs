using ForTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class ServerForm : Form
    {
        TCPServer tCPServer;
        List<string> end_points = new List<string>();
        public ServerForm()
        {
            InitializeComponent();
        }

        private void EXITEToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        public static string getIP(string domain)
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
    }
}
