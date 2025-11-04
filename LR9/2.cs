using System;
using System.Linq;
using System.Collections.Generic;

class Person
{
    private string name;
    private int age;
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public string Get()
    {
        return name;
    }
    public void Set(string newName)
    {
        name = newName;
    }
    public int GetA()
    {
        return age;
    }
    public void SetA(int newAge)
    {
        if (newAge >= 0)
            age = newAge;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Имя {name}, Возраст {age}");
    }
}
class Program
{
    static void Main()
    {
        Person[] people = new Person[3];
        people[0] = new Person("Алексей", 25);
        people[1] = new Person("Мария", 30);
        people[2] = new Person("Игорь", 22);
        Console.WriteLine("Исходники ");
        foreach (Person person in people)
        {
            person.DisplayInfo();
        }
        people[1].Set("Марина");
        people[2].SetA(23);
        Console.WriteLine("\nПосле изменений");
        foreach (Person person in people)
        {
            person.DisplayInfo();
        }
        Console.ReadKey();
    }
}
