using System;
using System.Collections.Generic;

namespace Odcinek10
{
    class Program
    {
        static void Main(string[] args)
        {
            Dziennik dziennik = new Dziennik();
            dziennik.AddRating(3);
            dziennik.AddRating(5);

            Dziennik dziennik2 = dziennik;
            dziennik2.AddRating(8);
        }
    }
}