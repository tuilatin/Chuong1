using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1
{
    class Bai7
    {
        public static void Run()
        {
            Console.Write("Nhập số nguyên dương n: ");
            int n_144;
            while (!int.TryParse(Console.ReadLine(), out n_144) || n_144 <= 0)
            {
                Console.Write("Vui lòng nhập số nguyên dương: ");
            }

            bool isDescending_144 = true;
            int temp_144 = n_144;
            int prevDigit_144 = temp_144 % 10; // Lấy chữ số cuối

            temp_144 /= 10; // Loại bỏ chữ số cuối

            while (temp_144 > 0)
            {
                int currentDigit_144 = temp_144 % 10; // Lấy chữ số kế tiếp
                if (currentDigit_144 <= prevDigit_144) // So sánh với chữ số trước
                {
                    isDescending_144 = false;
                    break;
                }
                prevDigit_144 = currentDigit_144;
                temp_144 /= 10;
            }

            if (isDescending_144)
            {
                Console.WriteLine($"{n_144} có các chữ số giảm dần từ trái sang phải.");
            }
            else
            {
                Console.WriteLine($"{n_144} không có các chữ số giảm dần từ trái sang phải.");
            }
        }
    }
}
