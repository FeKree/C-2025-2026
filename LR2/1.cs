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
            int[] mas = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Введите " + (i + 1) + " элемент массива");
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            int neg = 0;
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                if (mas[i] < 0)
                {
                    neg = i;
                    break;
                }
            }
            for (int i = neg + 1; i < 10; i++)
            {
                sum += Math.Abs(mas[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
