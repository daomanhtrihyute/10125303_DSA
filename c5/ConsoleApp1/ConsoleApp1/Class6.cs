using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Bai6_C5
    {
        public static void Run()
        {
            Queue<string> customerQueue = new Queue<string>();
            customerQueue.Enqueue("Khách hàng A");
            customerQueue.Enqueue("Khách hàng B");
            customerQueue.Enqueue("Khách hàng C");

            while (customerQueue.Count > 0)
            {
                string customer = customerQueue.Dequeue();
                Console.WriteLine($"ĐANG PHỤC VỤ: {customer}");
            }
        }
    }
}