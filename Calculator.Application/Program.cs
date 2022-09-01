using System;
using E01.Classes;

namespace E01.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new();
            Console.WriteLine("5 + 6 is " + calc.Add(5, 6));
            Console.WriteLine("5 - 6 is " + calc.Subtract(5, 6));
            Console.WriteLine("5 * 6 is " + calc.Multiply(5, 6));
            Console.WriteLine("5 to the power of 6 is " + calc.Power(5, 6));
        }
    }
}
