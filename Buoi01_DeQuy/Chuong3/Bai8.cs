using System;

namespace Chuong3
{
    static class Bai8
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

        static double Can(int i, int n)
        {
            if (i == n) return Math.Sqrt(n);
            return Math.Sqrt(i + Can(i + 1, n));
        }

        static double S(int n)
        {
            return Can(1, n);
        }

        public static void Run()
        {
            int n = DocSo("Nhap n (n > 0)");
            if (n <= 0) { Console.WriteLine("n phai la so nguyen duong."); return; }
            Console.WriteLine($"S({n}) = {S(n):F6}");
        }
    }
}
