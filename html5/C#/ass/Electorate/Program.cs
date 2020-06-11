using System;

namespace Electorate
{
    class Program
    {
        static void Main(string[] args)
        {
           Elect electorate = new Elect("James", 15);
           Console.Write($"{electorate.Name}" is {electorate.checkEligibility()}  );

        }
    }
}
