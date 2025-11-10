using System;
using System.Collections.Generic;
using System.Linq;

namespace LR8
{
    class CITY
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public CITY()
        {
            Console.WriteLine("Вызван конструктор CITY");
            Name = "Неизвестно";
            Population = 0;
        }
        public CITY(string name, int population)
        {
            Console.WriteLine("Вызван конструктор CITY");
            Name = name;
            Population = population;
        }
        public virtual void Input()
        {
            Console.Write("Введите город ");
            Name = Console.ReadLine();

            Console.Write("Введите город ");
            Population = int.Parse(Console.ReadLine());
        }
        public virtual void Display()
        {
            Console.WriteLine($"Город {Name}");
            Console.WriteLine($"Население {Population}");
        }
    }

    class SCHOOL : CITY
    {
        public int vip { get; set; }
        public SCHOOL() : base()
        {
            Console.WriteLine("Вызван конструктор SCHOOL без параметров");
            vip = 0;
        }
        public SCHOOL(string name, int population, int graduates) : base(name, population)
        {
            Console.WriteLine("Вызван конструктор SCHOOL");
            vip = graduates;
        }
        public virtual void Input()
        {
            Console.Write("Введите город: ");
            Name = Console.ReadLine();

            Console.Write("Введите население: ");
            Population = int.Parse(Console.ReadLine());
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Количество выпускников {vip}");
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Создание объекта school1 ");
            SCHOOL school1 = new SCHOOL();
            school1.Input();
            Console.WriteLine("\nВывод ");
            school1.Display();

            Console.WriteLine("\nСоздание объекта school2 ");
            SCHOOL school2 = new SCHOOL("Минск", 2000000, 5000);
            Console.WriteLine("\nВывод school2 ");
            school2.Display();
            Console.ReadKey();
        }
    }
}
