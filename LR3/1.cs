using System;
using System.Linq;
using System.Collections.Generic;

public static class lr3
{
    public static void Main()
    {
        Random random = new Random();
        int[] mas = new int[17];

        for (int i = 0; i < 17; i++)
        {
            mas[i] = random.Next(-200, 201);
        }
        Console.WriteLine("Массив: ");
        for (int i = 0; i < 17; i++)
        {
            Console.Write(mas[i] + " ");
        }
        Array.Sort(mas);
        Console.WriteLine("\nСортирован ");
        for (int i = 0; i < 17; i++)
        {
            Console.Write(mas[i] + " ");
        }
        Console.WriteLine("\nМакс " + mas.Max());
        Console.WriteLine("\nМин " + mas.Min());
        int ind = Array.FindIndex(mas, x => x == -100);
        if (ind == -1)
        {
            Console.WriteLine("Элемент не найден.");
        }
        else
        {
            Console.WriteLine("Нужный индекс: " + ind);
        }
        Console.ReadKey();
    }
}
