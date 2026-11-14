using System;

namespace Chuong3
{
    static class Bai7
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

        static int SoChuSo(long n)
        {
            if (n == 0) return 0;
            return SoChuSo(n / 10) + 1;
        }

        public static void Run()
        {
            int n = DocSo("Nhap n (n > 0)");
            if (n <= 0) { Console.WriteLine("n phai la so nguyen duong."); return; }
            Console.WriteLine($"So chu so cua {n} la {SoChuSo(n)}");
        }
    }
}
