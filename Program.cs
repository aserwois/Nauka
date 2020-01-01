using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wpisz swoje Imie: ");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj, " + name);

            Console.Write("Wpisz ile masz lat: ");
            int age = int.Parse(Console.ReadLine());

            if(age >= 18)
            {
                Console.WriteLine("Brawo, jesteś pełnoletni, walnij se browara!");
            } 
            else 
            {
                Console.WriteLine("To wypad!");
            }

            Console.ReadKey();
        }
    }
}