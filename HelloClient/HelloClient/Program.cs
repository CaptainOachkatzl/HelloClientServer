using System;
using System.Net.Sockets;

namespace HelloClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trying to connect..");
            Socket connector = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            connector.Connect("127.0.0.1", 1234);
            Console.WriteLine("Connected!");
            Console.ReadLine();
            try
            {
            connector.Shutdown(SocketShutdown.Both);
            connector.Close();
            }
            catch {}

            Console.WriteLine("Disconnected.");
        }
    }
}
