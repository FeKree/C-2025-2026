using System;
using System.Linq;
using System.Collections.Generic;
public static class lr3_2
{
    public static void Main()
    {
        Random random = new Random();
        int[] mas = new int[14];
        int[] mas2 = new int[16];
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = random.Next(-200, 201);
        }
        for (int i = 0; i < mas2.Length; i++)
        {
            mas2[i] = random.Next(0, 300);
        }
        Console.WriteLine("Mассив: ");
        for (int i = 0; i < mas.Length; i++)
        {
            Console.Write(mas[i] + " ");
        }

        Array.Reverse(mas);
        Console.WriteLine("\nПеревернутый массив ");
        for (int i = 0; i < mas.Length; i++)
        {
            Console.Write(mas[i] + " ");
        }
        int plus = mas.Count(number => number > 0);
        int minus = mas.Count(number => number < 0);
        Console.WriteLine("\nОтрицательных: " + minus);
        Console.WriteLine("Положительных: " + plus);

        int[] masmas = new int[6];
        Array.Copy(mas, 4, masmas, 0, 6);
        Console.WriteLine("Скопированный массив (элементы с 4 по 9 индексы): ");
        for (int i = 0; i < masmas.Length; i++)
        {
            Console.Write(masmas[i] + " ");
        }
        int[] arrayMerge = mas.Concat(mas2).ToArray();
        Array.Sort(masmas);
        Console.WriteLine("\nСлияние массивов: ");
        for (int i = 0; i < arrayMerge.Length; i++)
        {
            Console.Write(arrayMerge[i] + " ");
        }
        int ind = Array.FindIndex(mas, x => x == 200);
        if (ind == -1)
        {
            Console.WriteLine("\nЭлемент не найден.");
        }
        else
        {
            Console.WriteLine("\nНужный индекс: " + ind);
        }
        Console.ReadKey();
    }
}
