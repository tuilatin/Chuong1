using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1
{
    class Bai9
    {
        public static void Run()
        {
            Console.Write("Nhập số thực a: ");
            double a_144;
            while (!double.TryParse(Console.ReadLine(), out a_144))
            {
                Console.Write("Vui lòng nhập một số thực hợp lệ: ");
            }

            Console.Write("Nhập số thực b: ");
            double b_144;
            while (!double.TryParse(Console.ReadLine(), out b_144))
            {
                Console.Write("Vui lòng nhập một số thực hợp lệ: ");
            }

            Console.Write("Nhập số thực c: ");
            double c_144;
            while (!double.TryParse(Console.ReadLine(), out c_144))
            {
                Console.Write("Vui lòng nhập một số thực hợp lệ: ");
            }
            double max_144 = Math.Max(a_144, Math.Max(b_144, c_144));
            Console.WriteLine($"Số lớn nhất trong 3 số {a_144}, {b_144}, {c_144} là: {max_144}");
        }
    }
}
