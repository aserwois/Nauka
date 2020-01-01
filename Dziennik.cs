using System;
using System.Collections.Generic;
using System.Linq;

namespace DzienniczekUcznia
{
    class Dziennik
    {
        // Stan (zmienne - pola)
        List<float> ratings = new List<float>();
        // Zachowania
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        public float CalculateAverage()
        {
            float suma = 0, avg = 0;
            foreach (var rating in ratings)
            {
                suma += rating;
            }

            avg = suma / ratings.Count();

            return avg;
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