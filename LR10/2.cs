using System;
using System.Collections.Generic;
using System.Linq;

namespace LR10
{
    class Address
    {
        private string street;
        private string city;
        private string postalCode;
        private string country;
        public string Street
        {
            get => street;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("не может быть пустой");
                street = value;
            }
        }
        public string City
        {
            get => city;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("не может быть пустым");
                city = value;
            }
        }
        public string PostalCode
        {
            get => postalCode;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 4)
                    throw new ArgumentException("Недопустимый индекс");
                postalCode = value;
            }
        }
        public string Country
        {
            get => country;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("не может быть пустой");
                country = value;
            }
        }
        public Address(string street, string city, string postalCode, string country)
        {
            Street = street;
            City = city;
            PostalCode = postalCode;
            Country = country;
        }
        public void Display()
        {
            Console.WriteLine($"Адрес {Street}, {City}, {PostalCode}, {Country}");
        }
    }
    class Organization : Address
    {
        private string name;
        private int employeeCount;
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Название организации не может быть пустым");
                name = value;
            }
        }
        public int EmployeeCount
        {
            get => employeeCount;
            set
            {
                if (value < 0)
                    throw new ArgumentException("не может быть отрицательным");
                employeeCount = value;
            }
        }
        public Organization(string name, int employeeCount, string street, string city, string postalCode, string country)
            : base(street, city, postalCode, country)
        {
            Name = name;
            EmployeeCount = employeeCount;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Организация{Name}");
            Console.WriteLine($"Сотрудников{EmployeeCount}");
            base.Display();
        }
    }
    class Program
    {
        static void Main()
        {
            try
            {
                var org = new Organization(
                    name: "ffdfdf",
                    employeeCount: 150,
                    street: "Синегуба, 1011",
                    city: "Минск",
                    postalCode: "220030",
                    country: "Беларусь"
                );
                Console.WriteLine("Исходные данные:");
                org.DisplayInfo();
                org.Name = "InnoTech";
                org.EmployeeCount = 200;
                org.City = "Гомель";
                Console.WriteLine("\nПосле изменения:");
                org.DisplayInfo();
                Console.WriteLine("\nПробуем установить неверный индекс:");
                org.PostalCode = "";
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
