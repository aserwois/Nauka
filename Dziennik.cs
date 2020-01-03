using System;
using System.Collections.Generic;
using System.Linq;

namespace DzienniczekUcznia
{
    class Dziennik
    {
        public Dziennik()
        {
            ratings = new List<float>();    
        }

        // Stan (zmienne - pola)
        List<float> ratings = new List<float>();
        // Zachowania
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        internal Statystyki ComputeStatistics()
        {
            Statystyki staty = new Statystyki();

            float suma = 0f;
            foreach (var rating in ratings)
            {
                suma += rating;
            }

            staty.AverageGrade = suma / ratings.Count();
            staty.MaxGrade = ratings.Max();
            staty.MinGrade = ratings.Min();

            return staty;
        }

        public float GiveMaxRating()
        {
            return ratings.Max();
        }

        public float GiveMinRating()
        {
            return ratings.Min();
        }
    }
}