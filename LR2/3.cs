using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int[] b = new int[10];
            int[] c = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                a[i] = rnd.Next(-10, 11);
                b[i] = rnd.Next(-10, 11);
                c[i] = rnd.Next(-10, 11);
            }
            Console.WriteLine("Массив a:");
            foreach (int num in a)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Массив b:");
            foreach (int num in b)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Массив c:");
            foreach (int num in c)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            for (int i = 0; i < 10; i++)
            {
                if (a[i] < 0)
                {
                    {
                        sum1 += a[i];
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                if (b[i] < 0)
                {
                    {
                        sum2 += b[i];
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                if (c[i] < 0)
                {
                    {
                        sum3 += c[i];
                    }
                }
            }
            double sr1 = sum1 / 10;
            double sr2 = sum2 / 10;
            double sr3 = sum3 / 10;
            Console.WriteLine("Cреднее арифметическое отрицательных элементов массива a:" + sr1);
            Console.WriteLine("Cреднее арифметическое отрицательных элементов массива b:" + sr2);
            Console.WriteLine("Cреднее арифметическое отрицательных элементов массива c:" + sr3);
            Console.ReadKey();
        }
    }
}
