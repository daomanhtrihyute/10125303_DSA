using System;
using System.Text;

namespace Chuong1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n BAI TAP CHUONG 1:");
                Console.WriteLine(" 1. Bai 1:");
                Console.WriteLine(" 2. Bai 2:");
                Console.WriteLine(" 3. Bai 3:");
                Console.WriteLine(" 4. Bai 4:");
                Console.WriteLine(" 5. Bai 5:");
                Console.WriteLine(" 0. Thoat");
                Console.Write("Chon: ");

                string? chon = Console.ReadLine();
                Console.WriteLine();

                switch (chon)
                {
                    case "1": Bai1.Run(); break;
                    case "2": Bai2.Run(); break;
                    case "3": Bai3.Run(); break;
                    case "4": Bai4.Run(); break;
                    case "5": Bai5.Run(); break;
                    case "0": return;
                    default: Console.WriteLine("Lua chon khong hop le."); break;
                }
                Console.Write("\nNhan phim bat ky de quay lai menu...");
                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}
