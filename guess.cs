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
            int guessLimit = 3;
            bool outOfGuesses = false;

            while(!outOfGuesses && guess != password)
            {
                if(guessCounter < guessLimit)
                {
                    System.Console.Write("Enter the guess: ");
                    guess = Console.ReadLine();
                    guessCounter++;
                } else 
                {
                    outOfGuesses = true;
                    System.Console.WriteLine("You are out of guesses idioten! :)");
                }
            }
            if(outOfGuesses == false)
            {
                System.Console.WriteLine("You won!");
                System.Console.WriteLine($"You was trying to guest {guessCounter}");   
            } 
        }
    }
}