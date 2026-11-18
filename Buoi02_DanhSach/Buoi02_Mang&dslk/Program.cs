using Buoi02_Mang_dslk;
using System;
using System.Text;

namespace BTTH02
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("CHƯƠNG 4: MẢNG VÀ DANH SÁCH LIÊN KẾT ");
                Console.WriteLine("=====================================");
                Console.WriteLine("1. Bài 1 Chương 4 - Mảng một chiều (Nhập, xuất, chèn)");
                Console.WriteLine("2. Bài 2 Chương 4 - Quản lý nhân viên");
                Console.WriteLine("3. Bài 3 Chương 4 - Ma trận vuông");
                Console.WriteLine("4. Bài 4 Chương 4 - Danh sách liên kết đơn (Phần 1)");
                Console.WriteLine("5. Bài 5 Chương 4 - Danh sách liên kết đơn (Phần 2)");

                Console.WriteLine("\n BÀI TẬP CUỐI SÁCH");
                Console.WriteLine("6. Bài 7 - Quản lý nhiệt độ");
                Console.WriteLine("7. Bài 8 - Thống kê từ");
                Console.WriteLine("8. Bài 9 - Xử lý số nguyên");
                Console.WriteLine("9. Bài 10 - Ma trận xoắn ốc");
                Console.WriteLine("10. Bài 11 - Ma trận đặc biệt");
                Console.WriteLine("11. Bài 12 - Game Minesweeper");
                Console.WriteLine("12. Bài 13 - Đảo ngược danh sách liên kết");
                Console.WriteLine("13. Bài 14 - Gộp danh sách");
                Console.WriteLine("14. Bài 15 - Phát hiện chu trình");
                Console.WriteLine("15. Bài 16 - Hệ thống lịch sử duyệt web");
                Console.WriteLine("16. Bài 17 - Playlist nhạc");
                Console.WriteLine("17. Bài 18 - Hệ thống đặt hàng");




                Console.WriteLine("\n0. Thoát");
                Console.Write("Chọn bài: ");

                string? chon = Console.ReadLine();

                Console.WriteLine();

                switch (chon)
                {
                    case "1": Bai1_C4.Run(); break;
                    case "2": Bai2_C4.Run(); break;
                    case "3": Bai3_C4.Run(); break;
                    case "4": Bai4_C4.Run(); break;
                    case "5": Bai5_C4.Run(); break;
                    case "6": Bai7.Run(); break;
                    case "7": Bai8.Run(); break;
                    case "8": Bai9.Run(); break;
                    case "9": Bai10.Run(); break;
                    case "10": Bai11.Run(); break;
                    case "11": Bai12.Run(); break;
                    case "12": Bai13.Run(); break;
                    case "13": Bai14.Run(); break;
                    case "14": Bai15.Run(); break;
                    case "15": Bai16.Run(); break;
                    case "16": Bai17.Run(); break;
                    case "17": Bai18.Run(); break;


                    case "0":
                        return;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

                Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}