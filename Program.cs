using System;

namespace Hello
{
    class Program
    {
        static void n(string[] args)
        {
            ValueTypes();

            for (; ;)
            {
            Greeting();

            AgeInfo();

            Settings();
            }
            
        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("MaxInt: " + maxInt);
            Console.WriteLine("MinInt: " + minInt);
            Console.WriteLine("maxLong: " + maxLong);
            Console.WriteLine("minLong: " + minLong);
        }
        //Wypisujemy powitanie użytkownika
        private static void Greeting()
        {
            Console.Write("Wpisz swoje Imie: ");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj, " + name);
        }

        //Wypisujemy wiek użytkownika
        private static void AgeInfo()
        {
               Console.Write("Wpisz ile masz lat: ");
            int age; 
            bool result = int.TryParse(Console.ReadLine(), out age);

            if(age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Brawo, jesteś pełnoletni, walnij se browara!");
            } 
            else if(result == false) 
            {
                Console.WriteLine("Wprowadziłeś niepoprawną wartość");
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("To wypad!");
            }
        }

        //Ustawienia
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
    }
}