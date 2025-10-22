using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Первая строка");
            string a1 = Console.ReadLine();
            Console.WriteLine("Вторая строка");
            string a2 = Console.ReadLine();
            string a3 = a1 + a2;
            string last = String.Concat(a3.OrderBy(c => c));
            Console.WriteLine("\nИтог");
            Console.WriteLine(last);
            Console.ReadKey();
        }

    }
}
