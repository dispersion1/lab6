using Microsoft.VisualBasic;
using System;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение параметра x: ");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            double F = 3 * Math.Sin(x) * (x + 2);
                Console.WriteLine($"Значение F = {F}.");
            Console.ReadKey();
        }
    }
}
