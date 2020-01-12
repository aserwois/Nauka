using System;

namespace clasobje
{
    class program
    {
        static void Main(string[] args)
        {
            book success = new book("Don't give up!","Mateusz Gabriel",400);

            book success2 = new book("Dupsoon","Janek",120);

            Console.WriteLine(success.title);

            Console.ReadLine();
        }
    }
}