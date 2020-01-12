using System;

namespace guessProgram
{
    class program
    {
        static void Main(string[] args)
        {
            string password = "batman";
            string guess = "";

            while(guess != password)
            {
            System.Console.Write("Enter the guess: ");
            guess = Console.ReadLine();
            }

            System.Console.WriteLine("You won!");
        }


    }
}