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
        private List<float> ratings = new List<float>();
        // Zachowania
        public string name;
        public void AddRating(float rating)
        {
            if(rating >= 0 && rating <= 10)
            {
                ratings.Add(rating);
            }
        }

        public Statystyki ComputeStatistics()
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