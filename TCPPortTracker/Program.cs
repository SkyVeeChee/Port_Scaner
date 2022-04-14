using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Linq;

namespace TCPPortTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToArray();
            PortScan(input[0], input[1]);
        }

        private static void PortScan(int start, int finish)
        {
            for (int i = start; i <= finish; i++)
            {
                using (TcpClient Scan = new TcpClient())
                {
                    try
                    {
                        Scan.Connect("127.0.0.1", i);
                        Console.WriteLine(i);
                    }
                    catch
                    {
                        //Console.WriteLine("");
                    }
                }
            }
        }
    }
}
