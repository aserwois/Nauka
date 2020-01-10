using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine(num1 + num2);

        }
    }
}       