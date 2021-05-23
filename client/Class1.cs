using System;

namespace UDP
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPSocket s = new UDPSocket();
            s.Server("127.0.0.1", 27000); 
            Console.WriteLine("================================");
            Console.WriteLine("=   Connected to the server    =");
            Console.WriteLine("================================");
            Console.WriteLine("Waiting for response...");


            UDPSocket c = new UDPSocket();
            c.Client("127.0.0.1", 27000);
            c.Send("TEST for udp from client !");

            Console.ReadKey();
        }
    }
}
