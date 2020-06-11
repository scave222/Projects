using System;

namespace EnumerationTest
{
    class Program
    {
       private enum Day
            {
                Sunday = 1,
                Monday,
                Tuesday,
                Wednesday,
                Thursday,
                Friday,
                Saturday,
                
            }
           

        static void Main(string[] args)
        {     
            Console.Write($"{(int)Day.Friday}");
        }
    }
}
