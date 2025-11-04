using System;
using System.Linq;
using System.Collections.Generic;

class CITY
{
    private string name;
    private int population;
    private int universities;
    public void SetData(string Name, int Population, int Universities)
    {
        name = Name;
        population = Population;
        universities = Universities;
    }
    public void data()
    {
        Console.WriteLine("Город " + name);
        Console.WriteLine("Количество жителей " + population);
        Console.WriteLine("Количество ВУЗов " + universities);
        Console.WriteLine();
    }
}
class Program
{
    static void Main()
    {
        CITY[] gorod = new CITY[3];
        gorod[0] = new CITY();
        gorod[0].SetData("Минск", 2000000, 30);
        gorod[1] = new CITY();
        gorod[1].SetData("Гродно", 370000, 5);
        gorod[2] = new CITY();
        gorod[2].SetData("Брест", 350000, 4);
        for (int i = 0; i < gorod.Length; i++)
        {
            Console.WriteLine($"Город #{i + 1}:");
            gorod[i].data();
        }
        Console.ReadLine();
        Console.ReadKey();
    }
}
