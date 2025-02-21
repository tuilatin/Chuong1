using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1
{
    class Bai3
    {
        public static void Run()
        {
            Console.Write("Nhập số nguyên dương n: ");
            int n_144;
            while (!int.TryParse(Console.ReadLine(), out n_144) || n_144 <= 0)
            {
                Console.Write("Vui lòng nhập số nguyên dương: ");
            }

            int sum_144 = 0;

            for (int i_144 = 1; i_144 <= n_144; i_144++)
            {
                if (n_144 % i_144 == 0) // Kiểm tra i_144 có phải ước của n_144 không
                {
                    sum_144 += i_144;
                }
            }
            Console.WriteLine($"Tổng các ước của {n_144} là: {sum_144}");
        }
    }
}
