namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double y, a, b, x, z, f = 0, c;
            Console.WriteLine("Введите a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите z");
            z = Convert.ToInt32(Console.ReadLine());
            if (z > 0)
            {
                x = Math.Sqrt(z);
            }
            else
            {
                x = 3 * z + 1;
            }
            Console.WriteLine("Введите f(x) от 1 до 3");
            c = Convert.ToInt32(Console.ReadLine());
            if(c > 3 || c < 1)
            {
                Console.WriteLine("Неверное число");
            }
            else if (c == 1)
            {
                f = 2 * x;
            }
            else if(c == 2)
            {
                f = x * x;
            }
            else if(c == 3)
            {
                f = x / 3;
            }
            Console.WriteLine("Введите b ");
            b = Convert.ToInt32(Console.ReadLine());
            y = b * Math.Cos(a * f) + Math.Sin(x / 5) + a * Math.Exp(x);
            Console.WriteLine("a = " + a + " b = " + b + " f(x) = " + f + " x = " + x);
            Console.WriteLine("y = " + y);
            Console.ReadKey();
        }
    }
}
