using System;
using System.Linq;
using System.Collections.Generic;
class University
{
    public string Name { get; set; }
    public string Gorod { get; set; }
    public University(string name, string gorod)
    {
        Name = name;
        Gorod = gorod;
    }
}
class Program
{
    static void Main()
    {
        List<University> universities = new List<University>
        {
            new University("БГУ", "Минск"),
            new University("БНТУ", "Минск"),
            new University("ГрГУ", "Гродно"),
            new University("ВГУ", "Витебск")
        };
        Console.Write("нНазвание города: ");
        string inputgorod = Console.ReadLine();
        int count = CountUniversitiesInCity(universities, inputgorod);
        Console.WriteLine($"Количество ВУЗов {inputgorod} {count}");
        Console.ReadKey();
    }
    static int CountUniversitiesInCity(List<University> universities, string gorod)
    {
        int count = 0;
        foreach (var university in universities)
        {
            if (university.Gorod.Equals(gorod, StringComparison.OrdinalIgnoreCase))
            {
                count++;
            }
        }
        return count;
        
    }
}
