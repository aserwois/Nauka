using System;

namespace clasobje
{
    class program
    {
        static void Main(string[] args)
        {
            book success = new book("Mati");
            success.title = "Don't give up!";
            success.author = "Mateusz Gabriel";
            success.pages = 400;

            book success2 = new book("Dupa");
            success2.title = "Dupsoon";
            success2.author = "Janek";
            success2.pages = 120 ;

            Console.WriteLine(success.title);

            Console.ReadLine();
        }
    }
}