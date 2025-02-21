using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1
{
    class Bai5
    {
        public static void Run()
        {
            Console.Write("Nhập số nguyên dương n: ");
            int n_144;
            while (!int.TryParse(Console.ReadLine(), out n_144) || n_144 <= 0)
            {
                Console.Write("Vui lòng nhập số nguyên dương: ");
            }

            int count_144 = 0;
            int temp_144 = n_144;

            while (temp_144 > 0)
            {
                temp_144 /= 10; // Loại bỏ chữ số cuối cùng
                count_144++; // Tăng biến đếm 
            }
            Console.WriteLine($"Số chữ số của {n_144} là: {count_144}");
        }
    }
}
