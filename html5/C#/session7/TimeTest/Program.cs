using System;

namespace TimeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();
            Console.WriteLine($"Universal Initial Value : {time.ToUniversalTime()}");
             Console.WriteLine($"Standard Time Initial Value: {time.ToString()}\n");

             time.SetTime(20, 49, 34);

             Console.WriteLine($"Universl Time After SetTime has been called: {time.ToUniversalTime()}");
             Console.WriteLine($"Standard Time after settime has been called: {time.ToString()}\n");

             try
             {
                 time.SetTime(123,44,32);

             }
             catch (ArgumentOutOfRangeException e)
             {
                 Console.WriteLine(e.ParamName);
             }
        }
    }
}
