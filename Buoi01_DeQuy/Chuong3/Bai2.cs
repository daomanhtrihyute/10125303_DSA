using System;

namespace Chuong3
{
    static class Bai2
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

        static long S(int n)
        {
            if (n == 1) return 1;
            return S(n - 1) + (long)n * n;
        }

        public static void Run()
        {
            int n = DocSo("Nhap n (n > 0)");
            if (n <= 0) { Console.WriteLine("n phai la so nguyen duong."); return; }
            Console.WriteLine($"S({n}) = 1 + 2^2 + ... + {n}^2 = {S(n)}");
        }
    }
}
