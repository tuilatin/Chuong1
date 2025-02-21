
using System;
using System.Runtime.Intrinsics.X86;
namespace Chuong1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Chọn bài (1-10): "); 
            Console.WriteLine("Bài 1: Tính S(n) = 1 + 2 + 3 + … + n");
            Console.WriteLine("Bài 2: Tính S(n) = 1 + 1.2 + 1.2.3 + … + 1.2.3….n");
            Console.WriteLine("Bài 3: Tính tổng tất cả các “ ước số” của số nguyên dương n");
            Console.WriteLine("Bài 4: Cho số nguyên dương n. Kiểm tra xem n có phải là số nguyên tố hay không");
            Console.WriteLine("Bài 5: Hãy đếm số lượng chữ số của số nguyên dương n");
            Console.WriteLine("Bài 6: Tìm chữ số lớn nhất của số nguyên dương n");
            Console.WriteLine("Bài 7: Hãy kiểm tra các chữ số của số nguyên dương n có giảm dần từ trái sang phải hay không");
            Console.WriteLine("Bài 8: Tính S(x, n) = -x + x^2/(1 + 2) – x^3/(1 + 2 + 3) + … + (-1)^n * x^n/(1 + 2 +… + n)");
            Console.WriteLine("Bài 9: Viết chương trình tìm số lớn nhất trong 3 số thực a, b, c");
            Console.WriteLine("Bài 10: In tất cả các số nguyên dương lẻ nhỏ hơn 100");
            Console.WriteLine("Bạn chọn bài: ");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Bài 1: Tính S(n) = 1 + 2 + 3 + … + n");
                        Bai1.Run();
                        break;
                    case 2:
                        Console.WriteLine("Bài 2: Tính S(n) = 1 + 1.2 + 1.2.3 + … + 1.2.3….n");
                        Bai2.Run();
                        break;
                    case 3:
                        Console.WriteLine("Bài 3: Tính tổng tất cả các “ ước số” của số nguyên dương n");
                        Bai3.Run();
                        break;
                    case 4:
                        Console.WriteLine("bài 4: cho số nguyên dương n. kiểm tra xem n có phải là số nguyên tố hay không");
                        Bai4.Run();
                        break;
                    case 5:
                        Console.WriteLine("Bài 5: Hãy đếm số lượng chữ số của số nguyên dương n");
                        Bai5.Run();
                        break;
                    case 6:
                        Console.WriteLine("Bài 6: Tìm chữ số lớn nhất của số nguyên dương n");
                        Bai6.Run();
                        break;
                    case 7:
                        Console.WriteLine("Bài 7: Hãy kiểm tra các chữ số của số nguyên dương n có giảm dần từ trái sang phải hay không");
                        Bai7.Run();
                        break;
                    case 8:
                        Console.WriteLine("Bài 8: Tính S(x, n) = -x + x^2/(1 + 2) – x^3/(1 + 2 + 3) + … + (-1)^n * x^n/(1 + 2 +… + n)");
                        Bai8.Run();
                        break;
                    case 9:
                        Console.WriteLine("Bài 9: Viết chương trình tìm số lớn nhất trong 3 số thực a, b, c");
                        Bai9.Run();
                        break;
                    case 10:
                        Console.WriteLine("Bài 10: In tất cả các số nguyên dương lẻ nhỏ hơn 100");
                        Bai10.Run();
                        break;
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
