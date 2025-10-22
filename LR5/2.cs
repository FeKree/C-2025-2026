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
            Console.WriteLine("Текст");
            string a = Console.ReadLine();
            string rep = Regex.Replace(a, @",(?=\S)", ", ");
            int inf = Regex.Matches(rep, @"\bИнформатика\b", RegexOptions.IgnoreCase).Count;
            Console.WriteLine();
            Console.WriteLine("Итог");
            Console.WriteLine(rep);
            Console.WriteLine();
            Console.WriteLine($"Инорматик: {inf}");
            Console.ReadKey();
        }

    }
}
