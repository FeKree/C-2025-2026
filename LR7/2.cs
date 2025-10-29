using System;
using System.Linq;
using System.Collections.Generic;

class lr7
{
    static void Main()
    {
        string Str_vremya = "Текущее время 15:06:11";
        string[] timeP = Str_vremya.Split(' ')[2].Split(':');
        Console.WriteLine($"Часы: {Str_vremya[0]}, Минуты: {timeP[1]}, Секунды: {timeP[2]}");

        string Str_data = "До нового учебного года осталось 03/01/03";
        string[] dateP = Str_data.Split(' ')[5].Split('/');
        Console.WriteLine($"Месяцев: {dateP[0]}, Недель: {dateP[1]}, Дней: {dateP[2]}");
        Console.ReadKey();
    }
}
