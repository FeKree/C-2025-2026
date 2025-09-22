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
            int m, n;
            Console.WriteLine("Введите разиер массива");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Введите элемент [{i},{j}]: ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("Введённый массив:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            int zero = -1;

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < m; i++)
                {
                    if (a[i, j] == 0)
                    {
                        zero = j;
                        break;
                    }
                }
                if (zero != -1)
                {
                    break;
                }
            }

            if (zero != -1)
                Console.WriteLine("Номер первого столбца с нулевым элементом: " + (zero + 1));
            else
                Console.WriteLine("Столбцов с нулевым элементом нет");
        }
    }
}
