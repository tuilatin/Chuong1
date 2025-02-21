using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1
{
    class Bai6
    {
        public static void Run()
        {
            Console.Write("Nhập số nguyên dương n: ");
            int n_144;
            while (!int.TryParse(Console.ReadLine(), out n_144) || n_144 <= 0)
            {
                Console.Write("Vui lòng nhập số nguyên dương: "); 
            }

            int maxDigit_144 = 0;
            int temp_144 = n_144;

            while (temp_144 > 0)
            {
                int digit_144 = temp_144 % 10; // Lấy chữ số cuối cùng
                if (digit_144 > maxDigit_144) // Kiểm tra chữ số lớn nhất
                {
                    maxDigit_144 = digit_144;
                }
                temp_144 /= 10; // Loại bỏ chữ số cuối cùng
            }

            Console.WriteLine($"Chữ số lớn nhất của {n_144} là: {maxDigit_144}");
        }
    }
}
