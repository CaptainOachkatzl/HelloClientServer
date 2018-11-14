using System;

namespace HelloServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Accepter accepter = new Accepter();
            accepter.Run();
        }
    }
}
