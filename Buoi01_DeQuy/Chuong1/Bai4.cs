using System;

namespace Chuong1
{
    static class Bai4
    {
        static Random rnd = new Random();

        static int[] TaoMangNgauNhien(int n, int max = 10000)
        {
            int[] a = new int[n];
            for (int i = 0; i < n; i++) a[i] = rnd.Next(0, max);
            return a;
        }

        static void InMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++) Console.Write(a[i] + " ");
            Console.WriteLine();
        }

        static void InsertionSort(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int key = a[i];
                int j = i - 1;
                while (j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = key;
            }
        }

        public static void Run()
        {
            int[] a = TaoMangNgauNhien(1000);
            Console.WriteLine("Mang ban dau:");
            InMang(a);
            InsertionSort(a);
            Console.WriteLine("Sau khi sort:");
            InMang(a);
        }
    }
}
