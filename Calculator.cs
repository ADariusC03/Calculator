using System;

namespace Cal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Easy made two number and decimal function Calculator

            /* Console.WriteLine("Enter a number: ");
             double num1 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Enter a number: ");
             double num2 = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine(num1 + num2); */


            //4 function made Calculator, where you can put any 2numbers
            //And specify the operator you want to use
            // Add, Subtract, Multiply, && Divide            


            Console.WriteLine("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter operator: ");
            string op = Console.ReadLine();

            Console.WriteLine("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());


            //Uses the if statement to make the operators and make the 
            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator Partner!!");
            }
        }
    }
}
