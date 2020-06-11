using System;

namespace Dates
{
    public class Date
    {
        
        public int Day {get; set;}
       public int Month {get; set;}
        public int Year {get; set;}

        public Date(int day, int month, int year)
        {
             Day = day;
            Month = month;
            Year = year;
        }

        public void DisplayDate()
        {
            Console.Write("{0:D2}/{1:D2}/{2:D4}", Day, Month, Year);
        }
    }
}