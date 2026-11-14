using System;

namespace Chuong3
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

        static long UocLeMax(long n)
        {
            if (n % 2 == 1) return n;
            return UocLeMax(n / 2);
        }

        public static void Run()
        {
            int n = DocSo("Nhap n (n > 0)");
            if (n <= 0) { Console.WriteLine("n phai la so nguyen duong."); return; }
            Console.WriteLine($"Uoc le lon nhat cua {n} la {UocLeMax(n)}");
        }
    }
}
