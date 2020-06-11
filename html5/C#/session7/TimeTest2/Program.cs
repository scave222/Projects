using System;

namespace TimeTest2
{
    class Program
    {
        static void Main(string[] args)
        {
             Time time = new Time();
           
             Console.WriteLine($"Standard Time Initial Value: {time.ToString()}\n");

             time.SetTime(20, 49, 34);

            
             Console.WriteLine($"Standard Time after settime has been called: {time.ToString()}\n");
        }
    }
}
