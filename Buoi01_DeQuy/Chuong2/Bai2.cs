using System;

namespace Chuong2
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

        static void InMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++) Console.Write(a[i] + " ");
            Console.WriteLine();
        }

        static int Lap(int[] a, int x)
        {
            int l = 0, r = a.Length - 1;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (a[mid] == x) return mid;
                if (x < a[mid]) r = mid - 1;
                else l = mid + 1;
            }
            return -1;
        }

        static int DeQuy(int[] a, int x, int l, int r)
        {
            if (l > r) return -1;
            int mid = l + (r - l) / 2;
            if (a[mid] == x) return mid;
            if (x < a[mid]) return DeQuy(a, x, l, mid - 1);
            return DeQuy(a, x, mid + 1, r);
        }

        public static void Run()
        {
            int[] a = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
            Console.Write("Mang (da sap xep): ");
            InMang(a);
            int x = DocSo("Nhap so can tim");
            Console.WriteLine($"Cach lap: vi tri {Lap(a, x)}");
            Console.WriteLine($"Cach de quy: vi tri {DeQuy(a, x, 0, a.Length - 1)}");
        }
    }
}
