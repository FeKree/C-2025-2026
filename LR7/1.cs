using System;
using System.Linq;
using System.Collections.Generic;

public static class lr6
{
    static void Main()
    {
        char[] mas = { 'П', 'р', 'и', 'в', 'е', 'т' };
        Console.WriteLine(" массив  {0}", string.Join(", ", mas));
        string s1 = new string(mas);
        Console.WriteLine("Исходная строка: \"{0}\"", s1);

        // Шаг 3: Копирование исходной строки в новую
        string cop = string.Copy(s1);
        Console.WriteLine("Скопирована строка: \"{0}\"", cop);

        // Шаг 4: Реверс строки — переворот порядка символов
        char[] masrevers = cop.ToCharArray();
        Array.Reverse(masrevers);
        string strreversed = new string(masrevers);
        Console.WriteLine("Реверс \"{0}\"", strreversed);
        Console.WriteLine("\nИтог:");
        Console.WriteLine("Перевёрнутая \"{0}\"", strreversed);
        Console.ReadKey();
    }
}
