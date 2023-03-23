// Задание 1.2 [Вариант 2]
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    class Program
    {
        static void Main(string[] args)
        {
            double f;
            int n;
            Console.Write("Введите z= ");
            double z = double.Parse(Console.ReadLine());
            if (z == 0)
            {
                Console.Write("Нельзя делить на ноль\n");
                return;
            }
            Console.Write("Введите x= ");
            double x = Convert.ToSingle(Console.ReadLine());
            if (x <= 0)

            {
                f = x * x + z;
                n = 1;
            }
            else
                if (x > 0 && x <= 3)
            {
                f = x * x * 2.5f;
                n = 2;
            }
            else
            {
                f = Math.Pow(z, 3) / (10 * z);
                n = 3;
            }
            Console.WriteLine("z={0,6:f2}\tx={1,6:f2}\tn={2}\nf={3,8:f4}", z, x, n, f);
            Console.ReadKey();
        }
    }
}