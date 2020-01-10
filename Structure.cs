using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = {4, 8 , 15, 16, 23, 42};
            string[] friends = new string[5];
            luckyNumbers[1] = 900;

            friends[0] = "Jim";
            friends[1] = "Mati";
            friends[2] = "Łozi";
            friends[3] = "Karol";
            friends[4] = "Pedro";
            

            System.Console.WriteLine(luckyNumbers[1]);
            System.Console.WriteLine(friends[2]);
        }
    }
}       