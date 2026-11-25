using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Bai4_C5
    {
        public static void Run()
        {
            Queue<string> printQueue = new Queue<string>();
            printQueue.Enqueue("TaiLieu1.pdf");
            printQueue.Enqueue("BaoCao.docx");
            printQueue.Enqueue("HinhAnh.png");

            while (printQueue.Count > 0)
            {
                string doc = printQueue.Dequeue();
                Console.WriteLine($"ĐANG IN TÀI LIỆU: {doc}");
            }
        }
    }
}