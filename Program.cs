using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Easy made two number and decimal function calculator

            Console.WriteLine("Enter A Number...:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Another Number...:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);
        }
    }
}
