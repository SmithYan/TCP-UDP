using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ForTCP
{
    /// <summary>
    /// TCP服务类
    /// </summary>
    public class TCPServer
    {
        /// <summary>
        /// 用以传输的Socket
        /// </summary>
        public Socket TCPSocket { get; set; }
        /// <summary>
        /// 线程字典
        /// </summary>
        public Dictionary<string, Thread> Dic_ClientThread = new Dictionary<string, Thread>();
        /// <summary>
        /// 会话字典
        /// </summary>
        public Dictionary<string, TCPSession> Dic_ClientSession = new Dictionary<string, TCPSession>();
        /// <summary>
        /// 是否正在监听
        /// </summary>
        public bool Flag_Listen { get; set; }
        public static  string msg="";
        /// <summary>
        /// 开启服务
        /// </summary>
        /// <param name="ip">需要绑定的ip</param>
        /// <param name="port">需要绑定的port</param>
        /// <returns>开启结果</returns>
        public bool startServer(IPAddress ip, string port)
        {
            TCPSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(ip, int.Parse(port));
            try
            {
                TCPSocket.Bind(endPoint);
            }
            catch (Exception e)
            {
                return false;
            }
            // 设置监听队列的长度(表示可以连接个数)
            TCPSocket.Listen(100);
            // 创建负责监听的线程；
            Thread Thread_ServerListen = new Thread(ListenConnecting);
            Flag_Listen = true;
            Thread_ServerListen.IsBackground = true;
            Thread_ServerListen.Start();
            return true;
        }
        /// <summary>
        /// 监听
        /// </summary>
        private void ListenConnecting()
        {
            while (Flag_Listen)  // 持续不断的监听客户端的连接请求；
            {
                Socket sokConnection = TCPSocket.Accept(); // 一旦监听到一个客户端的请求，就返回一个与该客户端通信的 套接字；
                                                           // 将与客户端连接的 套接字 对象添加到集合中；
                string str_EndPoint = sokConnection.RemoteEndPoint.ToString();
                TCPSession myTCPSession = new TCPSession() { Socket = sokConnection };
                //创建线程接收数据
                Thread th_ReceiveData = new Thread(ReceiveData);
                th_ReceiveData.IsBackground = true;
                th_ReceiveData.Start(myTCPSession);
                //把线程及客户连接加入字典
                Dic_ClientSession.Add(str_EndPoint, myTCPSession);
                Dic_ClientThread.Add(str_EndPoint, th_ReceiveData);
                Thread.Sleep(200);
            }
        }
        /// <summary>
        /// 关闭所有服务
        /// </summary>
        public void CloseServer()
        {
            try
            {
                //锁定
                lock (Dic_ClientSession)
                {
                    foreach (var item in Dic_ClientSession)
                    {
                        item.Value.Close();//关闭每一个连接
                    }
                    Dic_ClientSession.Clear();//清除字典
                }
                lock (Dic_ClientThread)
                {
                    foreach (var item in Dic_ClientThread)
                    {
                        item.Value.Abort();//停止线程
                    }
                    Dic_ClientThread.Clear();
                }
                Flag_Listen = false;
                TCPSocket.Shutdown(SocketShutdown.Both);//服务端不能主动关闭连接,需要把监听到的连接逐个关闭
                if (TCPSocket != null)
                    TCPSocket.Close();
            }
            catch (Exception e)
            {
            }
        }
        public void CloseServer(string end_point)
        {
            try
            {
                //锁定
                lock (Dic_ClientSession[end_point])
                {
                    Dic_ClientSession[end_point].Close();
                    Dic_ClientSession[end_point].IsConnected = false;
                    Dic_ClientSession.Remove(end_point);
                }
                lock (Dic_ClientThread[end_point])
                {
                    Dic_ClientThread[end_point].Abort();
                    Dic_ClientThread.Remove(end_point);
                }
            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// 接收数据
        /// </summary>
        /// <param name="sokConnection">用来接收的会话端</param>
        private void ReceiveData(object sokConnection)
        {
            TCPSession tCPSession = sokConnection as TCPSession;
            Socket SocketSession = tCPSession.Socket;
            tCPSession.IsConnected = true;
            while (tCPSession.IsConnected)
            {
                try
                {
                    string ipEndPort = SocketSession.RemoteEndPoint.ToString();
                    // 定义一个2M的缓存区；
                    byte[] arrMsgRec = new byte[1024 * 1024 * 2];
                    // 将接受到的数据存入到输入  arrMsgRec中；
                    int length = -1;
                    try
                    {
                        length = SocketSession.Receive(arrMsgRec); // 接收数据，并返回数据的长度；
                    }
                    catch//一旦出现错误，立马断开连接
                    {
                        tCPSession.IsConnected = false;
                        // 从通信线程集合中删除被中断连接的通信线程对象；
                        string keystr = SocketSession.RemoteEndPoint.ToString();
                        //删除客户端字典中该socket
                        Dic_ClientSession.Remove(keystr);
                        //关闭线程
                        Dic_ClientThread[keystr].Abort();
                        //删除字典中该线程
                        Dic_ClientThread.Remove(keystr);
                        tCPSession = null;
                        SocketSession = null;
                        break;
                    }
                    //定义MD5pwd检验是不是该用户
                    byte[] md5pwd = new byte[16];
                    Array.Copy(arrMsgRec, 0, md5pwd, 0, 16);

                    if (!Enumerable.SequenceEqual(md5pwd, UseMd5(DateTime.Now.Hour.ToString())))
                    {
                        break;
                    }
                    //定义存储具体数据的byte数组
                    byte[] buf = new byte[length - 16];

                    //将缓冲区中的数据写入byte数组中
                    Array.Copy(arrMsgRec, 16, buf, 0, length - 16);

                    //获得byte数组表示数据的字符串
                    string strReceived = Encoding.UTF8.GetString(buf);
                    msg = ipEndPort+"-"+strReceived;
                }
                catch (Exception)
                {
                }
                Thread.Sleep(100);
            }
        }
        /// <summary>
        /// 发送数据给指定的客户端
        /// </summary>
        /// <param name="_endPoint">客户端套接字</param>
        /// <param name="_buf">发送的数组</param>
        /// <returns>是否发送成功</returns>
        public bool SendData(byte i, string _endPoint, byte[] _buf)
        {
            List<byte> buflist = new List<byte>();
            buflist.Add(i);
            buflist.AddRange(_buf);
            byte[] buf = buflist.ToArray();
            TCPSession myT = new TCPSession();
            if (Dic_ClientSession.TryGetValue(_endPoint, out myT))
            {
                myT.Send(buf);
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 对String用MD5加密成16位
        /// </summary>
        /// <param name="str">需要加密的字符串</param>
        /// <returns>转化之后的byte数组</returns>
        private static byte[] UseMd5(string str)
        {
            MD5 md5 = MD5.Create();//实例化一个md5对像
            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            return md5.ComputeHash(Encoding.UTF8.GetBytes(str));
        }
    }
}
