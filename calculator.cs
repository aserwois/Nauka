using System;

namespace calculator
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Write an operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                System.Console.WriteLine(num1 + num2);
            } 
            else if (op == "-")
            {
                System.Console.WriteLine(num1 - num2);
            } 
            else if (op == "/")
            {
                System.Console.WriteLine(num1 / num2);
            } 
            else if (op == "*") 
            {
                System.Console.WriteLine(num1 * num2);
            } 
            else 
            {
                System.Console.WriteLine("Operator is wrong!");
            }
        }
    }
}