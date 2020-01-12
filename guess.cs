using System;

namespace guessProgram
{
    class program
    {
        static void Main(string[] args)
        {
            string password = "batman";
            string guess = "";
            int guessCounter = 0;

            do
            {
            System.Console.Write("Enter the guess: ");
            guess = Console.ReadLine();
            guessCounter++;
            }
            while(guess != password);

            System.Console.WriteLine("You won!");
            System.Console.WriteLine($"You was trying to guest {guessCounter} times!");
        }
    }
}