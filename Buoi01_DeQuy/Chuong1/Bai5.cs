using System;

namespace Chuong1
{
    static class Bai5
    {
        static int DocSo(string loiNhac)
        {
            while (true)
            {
                Console.Write(loiNhac + ": ");
                if (int.TryParse(Console.ReadLine(), out int v)) return v;
                Console.WriteLine("Gia tri khong hop le, vui long nhap lai.");
            }
        }

        static long DeQuy(int n)
        {
            if (n < 2) return n;
            return DeQuy(n - 1) + DeQuy(n - 2);
        }

        static long VongLap(int n)
        {
            if (n < 2) return n;
            long a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                long c = a + b;
                a = b;
                b = c;
            }
            return b;
        }

        public static void Run()
        {
            int n = DocSo("Nhap n (0..40)");
            if (n < 0 || n > 40) { Console.WriteLine("n phai nam trong khoang 0..40."); return; }

            Console.WriteLine($"De quy: F({n}) = {DeQuy(n)}");
            Console.WriteLine($"Vong lap: F({n}) = {VongLap(n)}");
        }
    }
}
