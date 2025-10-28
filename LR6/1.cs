using System;
using System.Linq;
using System.Collections.Generic;

public static class lr6
{
    public static void Main()
    {
        string input = "Это строка текста которая дана x w x y x w уникальный элемент и уникальный случай";
        Dictionary<char, int> sym = new Dictionary<char, int>();
        foreach (char c in input)
        {
            if (sym.ContainsKey(c))
                sym[c]++;
            else
                sym[c] = 1;
        }

        Console.WriteLine("Частота ");
        foreach (var pair in sym)
        {
            Console.WriteLine($"'{pair.Key}' встречается {pair.Value} раз");
        }
        string rep = input.Replace("уникальный", "единственный");
        Console.WriteLine("\nСтрока после замены:");
        Console.WriteLine(rep);
    }
}
