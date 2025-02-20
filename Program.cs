
using System.Runtime.Intrinsics.X86;
namespace Chuong1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Chọn bài (1-10): "); 
            Console.WriteLine("Bài 1: Tính S(n) = 1 + 2 + 3 + … + n");
            Console.WriteLine("Bạn chọn bài: ");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Bai1.Run();
                        break;
                    //case 2:
                    //    Bai2.Run();
                    //    break;
                    //case 3:
                    //    Bai3.Run();
                    //    break;
                    //case 4:
                    //    Bai4.Run();
                    //    break;
                    //case 5:
                    //    Bai5.Run();
                    //    break;
                    //case 6:
                    //    Bai6.Run();
                    //    break;
                    //case 7:
                    //    Bai7.Run();
                    //    break;
                    //case 8:
                    //    Bai8.Run();
                    //    break;
                    //case 9:
                    //    Bai9.Run();
                    //    break;
                    //case 10:
                    //    Bai10.Run();
                    //    break;
                    default:
                        Console.WriteLine("Bài không hợp lệ!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Vui lòng nhập số hợp lệ!");
            }
        }
    }
}
