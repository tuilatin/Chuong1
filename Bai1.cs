using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1
{
    class Bai1
    {
        public static void Run()
        {   
            //Chạy trong file program
            int i_144, n_144, sum_144 = 0;
            Console.Write("Nhap n: ");
            n_144 = Convert.ToInt32(Console.ReadLine());
            for (i_144 = 0; i_144 <= n_144; i_144++)
            {
                sum_144 += i_144;
            }
            Console.WriteLine("Sum: " + sum_144);
        }
    }
}
