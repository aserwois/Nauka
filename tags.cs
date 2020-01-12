using System;

namespace weekDays
{
    class programd
    {
        static void M(string[] args)
        {
            System.Console.WriteLine(getDay(3));
        }

        static string getDay(int dayNum)
        {
            string dayName;

            switch(dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Wrong day number!";
                    break;
            }

            return dayName;
        }
    }
}