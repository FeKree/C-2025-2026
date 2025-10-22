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
            Console.WriteLine("Текст ");
            string a = Console.ReadLine();
            string rep = a.Replace("Pascal", "C++");
            rep = rep.Replace("*", "");
            Console.WriteLine("Итрг ");
            Console.WriteLine(rep);
            Console.ReadKey();
        }
    }

}
