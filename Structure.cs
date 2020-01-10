using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            System.Console.WriteLine($"Hi {name}!");
        }
    }
}       