using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1
{
    class Bai10
    {
        public static void Run()
        {
            Console.WriteLine("Các số nguyên dương lẻ nhỏ hơn 100:");

            for (int i_144 = 1; i_144 < 100; i_144 += 2) // Bước nhảy 2 để lấy số lẻ
            {
                Console.Write(i_144 + " ");
            }

            Console.WriteLine(); // Xuống dòng sau khi in xong.
        }
    }
}
