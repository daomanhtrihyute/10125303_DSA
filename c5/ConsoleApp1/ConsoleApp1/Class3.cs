using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Bai3_C5
    {
        public static void Run()
        {
            Stack<string> callStack = new Stack<string>();
            callStack.Push("Main()");
            Console.WriteLine("ĐANG GỌI: Main()");

            callStack.Push("HamA()");
            Console.WriteLine("ĐANG GỌI: HamA()");

            callStack.Push("HamB()");
            Console.WriteLine("ĐANG GỌI: HamB()");

            while (callStack.Count > 0)
            {
                string func = callStack.Pop();
                Console.WriteLine($"THỰC THI XONG VÀ TRẢ VỀ TỪ: {func}");
            }
        }
    }
}

