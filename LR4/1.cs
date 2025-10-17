using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static double Fact(int num)
        {
            double result = 1;
            for (int i = 2; i <= num; i++)
                result *= i;
            return result;
        }
        static double Y(double x)
        {
            return (Math.Exp(x) - Math.Exp(-x)) / 2;
        }
        static double S(double x, int n)
        {
            double sum = 0;
            for (int k = 0; k <= n; k++)
            {
                sum += Math.Pow(x, 2 * k + 1) / Fact(2 * k + 1);
            }
            return sum;
        }

        static void Main()
        {
            Console.Write("Введите значение a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите шаг h: ");
            double h = double.Parse(Console.ReadLine());
            Console.Write("Введите значение n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("|   x   |   Y(x)   |   S(x)   |");
            for (double x = a; x <= b + 1e-9; x += h)
            {
                double y = Y(x);
                double s = S(x, n);
                Console.WriteLine($"| {x,5:F2} | {y,8:F5} | {s,8:F5} |");
            }
            Console.ReadKey();
        }
        
    }

}
