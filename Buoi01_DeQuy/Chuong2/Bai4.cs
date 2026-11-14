using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Chuong2
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

        // Gt 1: duyet moi uoc 1..k-1 => O(N^2)
        static bool CoBan(int k)
        {
            int tong = 0;
            for (int i = 1; i < k; i++)
                if (k % i == 0) tong += i;
            return k > 1 && tong == k;
        }

        //Gt 2: duyet den can k, moi uoc i cong them k/i => O(N sqrt N)
        static bool CaiTien(int k)
        {
            if (k < 2) return false;
            int tong = 1;
            for (int i = 2; (long)i * i <= k; i++)
            {
                if (k % i == 0)
                {
                    tong += i;
                    if (i != k / i) tong += k / i;
                }
            }
            return tong == k;
        }

        public static void Run()
        {
            int N = DocSo("Nhap N");

            Stopwatch sw = Stopwatch.StartNew();
            List<int> ds1 = new List<int>();
            for (int k = 1; k < N; k++) if (CoBan(k)) ds1.Add(k);
            sw.Stop();
            Console.WriteLine($"Co ban: {string.Join(", ", ds1)} ({sw.Elapsed.TotalMilliseconds:F2} ms)");

            sw.Restart();
            List<int> ds2 = new List<int>();
            for (int k = 1; k < N; k++) if (CaiTien(k)) ds2.Add(k);
            sw.Stop();
            Console.WriteLine($"Cai tien: {string.Join(", ", ds2)} ({sw.Elapsed.TotalMilliseconds:F2} ms)");
        }
    }
}
