using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Chuong1
{
    class Bai2
    {
        public static void Run()
        {
            Console.Write("nhập n: ");
            int n_144;
            while (!int.TryParse(Console.ReadLine(), out n_144) || n_144 <= 0)
            {
                Console.Write("Vui lòng nhập số nguyên dương: ");
            }
            long sum_144 = 0;
            long factorial_144 = 1;
            for (int i_144 = 1; i_144 <= n_144; i_144++)
            {
                factorial_144 *= i_144; // Tính giai thừa
                sum_144 += factorial_144; // Cộng vào tổng.
            }

            Console.WriteLine($"S({n_144}) = {sum_144}");
        }
    }
}
