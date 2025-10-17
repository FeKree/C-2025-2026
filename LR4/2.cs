using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static double ur(double x, int n)
        {
            if (n == 0)
                return 1;
            else if (n % 2 == 0)
            {
                double ch = ur(x, n / 2);
                return ch * ch;
            }
            else
            {
                return x * ur(x, n - 1);
            }
        }
        static void Main()
        {
            Console.Write("Введите x ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите n ");
            int n = int.Parse(Console.ReadLine());
            double res = ur(x, n);
            Console.WriteLine($"\nРезультат y = {res}");
            Console.ReadKey();
        }
    }

}
