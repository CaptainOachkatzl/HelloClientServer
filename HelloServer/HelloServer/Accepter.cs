using System;
using System.Net;
using System.Net.Sockets;

namespace HelloServer
{
    class Accepter
    {
        Socket m_acceptSocket;
        bool m_abort = false;

        public Accepter()
        {
            m_acceptSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
        }

        public void Run()
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            int port = 1234;
            m_acceptSocket.Bind(new IPEndPoint(ip, port));
            m_acceptSocket.Listen(10);
            Console.WriteLine("Accepter is now listening.");
            while(!m_abort)
            {
                Socket acceptedSocket = m_acceptSocket.Accept();
                Console.WriteLine("Accepted connection from " + acceptedSocket.RemoteEndPoint.ToString());
            }
        }

        public void Stop()
        {
            m_abort = true;
        }
    }
}