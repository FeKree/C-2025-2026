using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTask
{
    enum Grade { _3 = 3, _4 = 4, _5 = 5, _6 = 6, _7 = 7, _8 = 8, _9 = 9, _10 = 10 }
    struct Marks
    {
        public Grade Physics, Math, Informatics, Chemistry;
        public double Average =>
            ((int)Physics + (int)Math + (int)Informatics + (int)Chemistry) / 4.0;
        public void Print()
        {
            Console.WriteLine($"Физ: {(int)Physics} Мат: {(int)Math} Инф: {(int)Informatics} Хим: {(int)Chemistry} Ср: {Average:F2}");
        }
    }
    struct Student : IComparable<Student>
    {
        public string Name;
        public int Year;
        public string Group;
        public Marks Marks;
        public double AvgScore;
        public void CalculateAvg() => AvgScore = Marks.Average;
        public void Print()
        {
            Console.WriteLine($"{Name,-22} {Year,6} {Group,-10} {AvgScore,8:F2} ");
            Marks.Print();
        }
        public int CompareTo(Student ot) => Name.CompareTo(ot.Name);
    }
    class Program
    {
        static Grade InputGrade(string subject)
        {
            int g;
            do
            {
                Console.Write($" {subject} ");
                if (int.TryParse(Console.ReadLine(), out g) && g >= 3 && g <= 10)
                    return (Grade)g;
                Console.WriteLine("должна быть от 3 до 10");
            } while (true);
        }
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("СТУДЕНТЫ\n");
            Console.Write("Введите количество студентов ");
            int n = int.Parse(Console.ReadLine());
            var stud = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                var s = new Student();
                Console.WriteLine($"\n Студент {i + 1} ");
                Console.Write("Фамилия и инициалы ");
                s.Name = Console.ReadLine();
                Console.Write("Год рождения ");
                s.Year = int.Parse(Console.ReadLine());
                Console.Write("Номер группы ");
                s.Group = Console.ReadLine();
                Console.WriteLine("Оценки");
                s.Marks.Physics = InputGrade("Физика");
                s.Marks.Math = InputGrade("Математика");
                s.Marks.Informatics = InputGrade("Информатика");
                s.Marks.Chemistry = InputGrade("Химия");
                s.CalculateAvg();
                stud.Add(s);
            }
            Console.Write("\nВведите номер группы ");
            string targetGroup = Console.ReadLine();
            var group = stud.Where(s => s.Group == targetGroup).ToList();
            if (!group.Any())
            {
                Console.WriteLine($"В {targetGroup} нет студентов.");
                Console.ReadKey();
                return;
            }
            double totalAvg = group.Average(s => s.AvgScore);
            Console.WriteLine($"\nОбщий балл {targetGroup}: {totalAvg:F2}");
            Console.WriteLine("\nСтуденты выше среднего");
            Console.WriteLine($"{"ФИО",-22} {"Год",6} {"Группа",-10} {"Средний",8}");
            Console.WriteLine(new string('-', 80));
            int count = 0;
            foreach (var s in group)
            {
                if (s.AvgScore > totalAvg)
                {
                    s.Print();
                    count++;
                }
            }
            if (count == 0) Console.WriteLine("студентов нет");
            Console.WriteLine("\n\nСОРТИРОВКА ПО ФАМИЛИИ");
            stud.Sort();
            Console.WriteLine($"{"ФИО",-22} {"Год",6} {"Группа",-10} {"Средний",8}");
            Console.WriteLine(new string('-', 80));
            foreach (var s in stud) s.Print();
            Console.WriteLine("\nТЕСТЫ");
            var testMarks = new Marks
            {
                Physics = Grade._10,
                Math = Grade._7,
                Informatics = Grade._10,
                Chemistry = Grade._5
            };
            double expected = 8.0;
            if (Math.Abs(testMarks.Average - expected) < 0.01)
                Console.WriteLine("Тест пройден");
            else
                Console.WriteLine($"Тест провален");
            Console.ReadKey();
        }
    }
}
