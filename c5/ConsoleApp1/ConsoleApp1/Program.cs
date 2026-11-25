using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.OutputEncoding = Encoding.UTF8;

                while (true)
                {
                    Console.WriteLine(" CHƯƠNG 5: NGĂN SẾP VÀ HÀNG ĐỢI ");
                    Console.WriteLine("6. Bài 1 Chương 5 - Kiểm tra biểu thức ngoặc");
                    Console.WriteLine("7. Bài 2 Chương 5 - Lịch sử trình duyệt web");
                    Console.WriteLine("8. Bài 3 Chương 5 - Quá trình thực thi chương trình");
                    Console.WriteLine("9. Bài 4 Chương 5 - Hệ thống in ấn");
                    Console.WriteLine("10. Bài 5 Chương 5 - Đường truyền dữ liệu");
                    Console.WriteLine("11. Bài 6 Chương 5 - Quản lý hàng đợi khách hàng");

                    Console.WriteLine("\n0. Thoát");
                    Console.Write("Chọn bài: ");

                    string? chon = Console.ReadLine();

                    Console.WriteLine();

                    switch (chon)
                    {
                        
                        case "1": Bai1_C5.Run(); break;
                        case "2": Bai2_C5.Run(); break;
                        case "3": Bai3_C5.Run(); break;
                        case "4": Bai4_C5.Run(); break;
                        case "5": Bai5_C5.Run(); break;
                        case "6": Bai6_C5.Run(); break;

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
}
    