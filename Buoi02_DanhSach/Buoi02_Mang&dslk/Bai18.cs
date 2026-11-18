using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi02_Mang_dslk
{
    internal class Bai18
    {
        public static void Run()
        {
            string trangThai = "Chờ xử lý";
            Console.WriteLine($"TRẠNG THÁI ĐƠN HÀNG: {trangThai}");

            trangThai = "Đang giao";
            Console.WriteLine($"CHUYỂN TRẠNG THÁI: {trangThai}");

            trangThai = "Hoàn thành";
            Console.WriteLine($"CHUYỂN TRẠNG THÁI: {trangThai}");
        }
    }
}