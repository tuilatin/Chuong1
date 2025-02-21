using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1
{
    class Bai8
    {
        public static void Run()
        {
            Console.Write("Nhập x: ");
            double x_144;
            while (!double.TryParse(Console.ReadLine(), out x_144))
            {
                Console.Write("Vui lòng nhập một số thực hợp lệ: "); 
            }

            Console.Write("Nhập số nguyên dương n: ");
            int n_144;
            while (!int.TryParse(Console.ReadLine(), out n_144) || n_144 <= 0)
            {
                Console.Write("Vui lòng nhập số nguyên dương: ");
            }

            double sum_144 = 0;
            int sumDenominator_144 = 0; // Tổng mẫu số (1 + 2 + ... + n)

            for (int i_144 = 1; i_144 <= n_144; i_144++)
            {
                sumDenominator_144 += i_144; // Cộng dồn mẫu số
                double term_144 = Math.Pow(-1, i_144) * Math.Pow(x_144, i_144) / sumDenominator_144;
                sum_144 += term_144; // Cộng vào tổng
            }

            Console.WriteLine($"S({x_144}, {n_144}) = {sum_144}");
        }
    }
}
