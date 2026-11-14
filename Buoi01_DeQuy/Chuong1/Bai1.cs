using System;

namespace Chuong1
{
    static class Bai1
    {
        static Random rnd = new Random();

        static int[] TaoMangNgauNhien(int n, int max = 10000)
        {
            int[] a = new int[n];
            for (int i = 0; i < n; i++) a[i] = rnd.Next(0, max);
            return a;
        }

        public static void Run()
        {
            int[] a = TaoMangNgauNhien(1000);
            int max = a[0], min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max) max = a[i];
                if (a[i] < min) min = a[i];
            }
            Console.WriteLine("So lon nhat: " + max);
            Console.WriteLine("So nho nhat: " + min);
        }
    }
}
