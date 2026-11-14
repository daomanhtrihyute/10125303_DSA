using System;

namespace Chuong3
{
    static class Bai6
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

        static int UCLN(int a, int b)
        {
            if (a % b == 0) return b;
            return UCLN(b, a % b);
        }

        public static void Run()
        {
            int a = DocSo("Nhap a (a > 0)");
            int b = DocSo("Nhap b (b > 0)");
            if (a <= 0 || b <= 0) { Console.WriteLine("a, b phai la so nguyen duong."); return; }
            Console.WriteLine($"UCLN({a}, {b}) = {UCLN(a, b)}");
        }
    }
}
