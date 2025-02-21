using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1
{
    class Bai4
    {
        public static void Run()
        {
            Console.Write("Nhập số nguyên dương n: ");
            int n_144;
            while (!int.TryParse(Console.ReadLine(), out n_144) || n_144 <= 0)
            {
                Console.Write("Vui lòng nhập số nguyên dương: ");
            }

            bool isPrime_144 = true;

            if (n_144 < 2)
            {
                isPrime_144 = false;
            }
            else
            {
                for (int i_144 = 2; i_144 <= Math.Sqrt(n_144); i_144++)
                {
                    if (n_144 % i_144 == 0)
                    {
                        isPrime_144 = false;
                        break;
                    }
                }
            }

            if (isPrime_144)
            {
                Console.WriteLine($"{n_144} là số nguyên tố."); 
            }
            else
            {
                Console.WriteLine($"{n_144} không phải là số nguyên tố.");
            }
        }
    }
}
