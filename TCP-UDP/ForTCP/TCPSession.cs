using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace ForTCP
{
    /// <summary>
    /// TCP会话类，配合服务类
    /// </summary>
    public class TCPSession
    {
        #region Properties
        /// <summary>
        /// 特定的Socket用以传输
        /// </summary>
        public Socket Socket { get; set; }
        /// <summary>
        /// 获取当前会话的IP
        /// </summary>
        public string Ip
        {
            get
            {
                IPEndPoint clientipe = (IPEndPoint)Socket.RemoteEndPoint;
                return clientipe.Address.ToString();
            }
        }
        /// <summary>
        /// 获取当前回话的Port
        /// </summary>
        public string Port
        {
            get
            {
                IPEndPoint clientipe = (IPEndPoint)Socket.RemoteEndPoint;
                return clientipe.Port.ToString();
            }
        }
        /// <summary>
        /// 此会话端是否连接
        /// </summary>
        public bool IsConnected { get; set; }
        /// <summary>
        /// 得到的消息
        /// </summary>
        public string Message
        {
            get { return Message; }
            set
            {
                Message = value;

            }
        }

        #endregion


        /// <summary>
        /// 数据缓存区
        /// </summary>
        public List<byte> Buffer = new List<byte>();
        #region 方法
        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="buf">需要发送的数据</param>
        public void Send(byte[] buf)
        {
            if (buf != null)
            {
                Socket.Send(buf);
            }
        }
        /// <summary>
        /// 关闭连接
        /// </summary>
        public void Close()
        {
            Socket.Shutdown(SocketShutdown.Both);
        }
        /// <summary>
        /// 提取正确的数据包
        /// </summary>
        /// <param name="startIndex">开始索引</param>
        /// <param name="size">大小</param>
        /// <returns>提取到的数据包</returns>
        public byte[] GetBuffer(int startIndex, int size)
        {
            byte[] buf = new byte[size];
            Buffer.CopyTo(startIndex, buf, 0, size);
            Buffer.RemoveRange(0, startIndex + size);
            return buf;
        }

        /// <summary>
        /// 添加队列数据
        /// </summary>
        /// <param name="buffer">要添加的数据</param>
        public void AddQueue(byte[] buffer)
        {
            Buffer.AddRange(buffer);
        }
        /// <summary>
        /// 清除缓存
        /// </summary>
        public void ClearQueue()
        {
            Buffer.Clear();
        }
        #endregion
    }
}
