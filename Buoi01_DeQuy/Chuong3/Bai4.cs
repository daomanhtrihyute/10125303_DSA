using System;

namespace Chuong3
{
    static class Bai4
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

        static double DocSoThuc(string loiNhac)
        {
            while (true)
            {
                Console.Write(loiNhac + ": ");
                if (double.TryParse(Console.ReadLine(), out double v)) return v;
                Console.WriteLine("Gia tri khong hop le, vui long nhap lai.");
            }
        }

        static double LuyThua(double x, int n)
        {
            if (n == 0) return 1;
            return LuyThua(x, n - 1) * x;
        }

        static double S(double x, int n)
        {
            if (n < 0) return 1.0 / LuyThua(x, -n);
            return LuyThua(x, n);
        }

        public static void Run()
        {
            double x = DocSoThuc("Nhap x");
            int n = DocSo("Nhap n");
            if (x == 0 && n < 0) { Console.WriteLine("Khong xac dinh (chia cho 0)."); return; }
            Console.WriteLine($"S({x}, {n}) = {x}^{n} = {S(x, n)}");
        }
    }
}
