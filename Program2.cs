using System;


namespace DzienniczekUcznia
{
    class Program2
    {
        static void Main(string[] args)
        {
            Dziennik dziennik = new Dziennik();
            
            dziennik.AddRating(5);   
            dziennik.AddRating(8.5f); 
            dziennik.AddRating(4.7f);  

            Statystyki staty = dziennik.ComputeStatistics();   
            Console.WriteLine("Średnia wartość to: " + staty.AverageGrade);
            Console.WriteLine("Maksymalna wartość to: " + staty.MaxGrade);
            Console.WriteLine("Minimalna wartość to: " + staty.MinGrade);

            
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
        }

        
    }
}