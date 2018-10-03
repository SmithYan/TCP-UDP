using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ForTCP
{
    /// <summary>
    /// TCP客户端类
    /// </summary>
    public class TCPClient
    {
        public TCPClient(string host, int port)
        {
            Host = host;
            Port = port;
        }
        #region 属性
        /// <summary>
        /// 端口值
        /// </summary>
        public static int Port { get; set; }
        /// <summary>
        /// IP地址
        /// </summary>
        public static string Host { get; set; }
        /// <summary>
        /// 用以通信的Socket
        /// </summary>
        public static Socket ClientSocket { get; set; } = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        /// <summary>
        /// 用以加密连接的MD5数组
        /// </summary>
        public static byte[] Md5pwd { get; set; }
        #endregion
        #region 连接断开服务器
        /// <summary>
        /// 连接服务器socket 
        /// </summary>
        /// <returns>是否连接成功</returns>
        public bool startClient()
        {
            try
            {
                //将host转化为ip地址
                IPAddress ip = IPAddress.Parse(Host);
                //将ip以及port表示成网络端点
                IPEndPoint ipe = new IPEndPoint(ip, Port);
                //连接到此网络端点
                Md5pwd = UserMd5(DateTime.Now.Hour.ToString());
                ClientSocket.Connect(ipe);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 断开服务器
        /// </summary>
        public void stopClient()
        {
            byte[] type = new byte[2];
            byte[] mainData = new byte[8];
            byte[] md5pwd = TCPClient.Md5pwd;
            mainData = Encoding.UTF8.GetBytes("已人为退出");
            SendData(md5pwd, mainData);
            ClientSocket.Close();
        }
        #endregion

        #region 加密
        /// <summary>
        /// 对String用MD5加密成16位
        /// </summary>
        /// <param name="str">需要加密的字符串</param>
        /// <returns>转化之后的byte数组</returns>
        private static byte[] UserMd5(string str)
        {
            MD5 md5 = MD5.Create();//实例化一个md5对像
            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            return md5.ComputeHash(Encoding.UTF8.GetBytes(str));
        }
        #endregion

        #region 发送接收
        /// <summary>
        /// 发送字符串
        /// </summary>
        /// <param name="strForSend">需要发送的字符串</param>
        /// <returns>返回是否发送成功，true表示发送成功，false表示发送失败</returns>
        public bool SendData(byte[] md5pwd, byte[] mainData)
        {
            List<byte> list = new List<byte>();
            list.AddRange(md5pwd);
            list.AddRange(mainData);
            try
            {
                if (ClientSocket.Send(list.ToArray()) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// 接收数据
        /// </summary>
        /// <returns>是否接收成功，true表示接收成功，false表示接受失败</returns>
        public byte[] receiveData()
        {
            try
            {
                byte[] arrMsgRec = new byte[1024 * 1024 * 2];
                // 将接受到的数据存入到输入  arrMsgRec中；
                int length = -1;
                try
                {
                    length = ClientSocket.Receive(arrMsgRec); // 接收数据，并返回数据的长度；
                }
                catch
                {
                }
                byte[] buf = new byte[length];
                Array.Copy(arrMsgRec, buf, length);
                return buf;
            }

            catch (Exception)
            {
                return null;
            }
        }
        #endregion
    }
}
