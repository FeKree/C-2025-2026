using System;
using System.Linq;
using System.Collections.Generic;

public static class lr6
{
    static void Main()
    {
        string str = "FFF Строка вывфылвфыовл";
        string[] words = str.Split(' ');
        Array.Reverse(words);
        string rev = string.Join(" ", words);

        Console.WriteLine("Реверс ");
        Console.WriteLine(rev);
    }
}
