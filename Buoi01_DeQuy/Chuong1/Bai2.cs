using System;

namespace Chuong1
{
    static class Bai2
    {
        static string KetQua(int i)
        {
            if (i % 15 == 0) return "FizzBuzz";
            if (i % 3 == 0) return "Fizz";
            if (i % 5 == 0) return "Buzz";
            return i.ToString();
        }

        public static void Run()
        {
            for (int i = 1; i <= 100; i++)
                Console.Write(KetQua(i) + " ");
            Console.WriteLine();
        }
    }
}
