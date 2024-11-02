using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What do you want to use? (*, +, -, /): ");
            string operation = Console.ReadLine();

            Console.WriteLine("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (operation == "*") {
                double result = num1 * num2;
                Console.WriteLine($"The result is {result}");
            } else if (operation == "+") {
                double result = num1 + num2;
                Console.WriteLine($"The result is {result}");
            } else if (operation == "-") {
                double result = num1 - num2;
                Console.WriteLine($"The result is {result}");
            } else if (operation == "/") {
                double result = num1 / num2;
                Console.WriteLine($"The result is {result}");
            } else {
                Console.WriteLine("Invalid operation. Please enter a valid operator.");
            }

            Console.ReadKey();
        }
    }
}