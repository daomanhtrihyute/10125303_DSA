using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Bai5_C5
    {
        public static void Run()
        {
            Queue<string> networkQueue = new Queue<string>();
            networkQueue.Enqueue("Packet_01");
            networkQueue.Enqueue("Packet_02");
            networkQueue.Enqueue("Packet_03");

            while (networkQueue.Count > 0)
            {
                string packet = networkQueue.Dequeue();
                Console.WriteLine($"ĐANG TRUYỀN GÓI TIN: {packet}");
            }
        }
    }
}