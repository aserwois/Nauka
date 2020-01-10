using System;


namespace DzienniczekUcznia
{
    class Program2
    {
        static void GiveName(Dziennik dziennik)
        {
            dziennik = new Dziennik();
            dziennik.name = "Dzienniczek Matiego";
        }

        static void IncrementNumber(int number)
        {
            number++;
        }
        static void M(string[] args)
        {
            /*Dziennik dziennik = new Dziennik();
            
            dziennik.AddRating(5);   
            dziennik.AddRating(8.5f); 
            dziennik.AddRating(4.7f); 

             Dziennik dziennik2 = new Dziennik();
             Dziennik dziennik3 = new Dziennik();
             Dziennik dziennik4 = new Dziennik();
             Dziennik dziennik5 = new Dziennik();
             Dziennik dziennik6 = new Dziennik();

            Console.WriteLine(Dziennik.Count);

            Statystyki staty = dziennik.ComputeStatistics();   
            Console.WriteLine("Średnia wartość to: " + staty.AverageGrade);
            Console.WriteLine("Maksymalna wartość to: " + staty.MaxGrade);
            Console.WriteLine("Minimalna wartość to: " + staty.MinGrade);*/

            
            /*float avg = dziennik.CalculateAverage(); 
            //float max = dziennik.GiveMaxRating();
           // float min = dziennik.GiveMinRating();     

            for (; ; )
            {
                Console.WriteLine("Podaj ocenę z zakresu 1 do 10: ");   

                float rating ;
                bool result = float.TryParse(Console.ReadLine(), out rating);

                if(rating == 11)
                {
                    break;
                } 

                if (result)
                {
                    dziennik.AddRating(rating);
                }

                dziennik.AddRating(rating);

            } 

            Console.WriteLine("Średnia Twoich ocen to " + dziennik.CalculateAverage());
                Console.WriteLine("Maksymalna ocena to " + dziennik.GiveMaxRating());
                Console.WriteLine("Najniższa ocena to " + dziennik.GiveMinRating());

                Console.ReadKey();*/


                Dziennik d1 = new Dziennik();
                Dziennik d2 = d1;

                GiveName(d1);
                System.Console.WriteLine(d2.name);

                int x1 = 4;
                IncrementNumber(x1);
                System.Console.WriteLine(x1);
        }

        
    }
}