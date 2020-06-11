using System;

namespace problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Sub sub = new Sub("Caleb", "Okogbe", 45);

             sub.FirstName = "Sam";
            // sub.LastName = "Okogbe";
            sub.Num = 80;
           // Console.WriteLine(sub.Num);

            Console.WriteLine($"My name is {sub.FirstName}  {sub.LastName} {sub.Grade}");
            
        }
    }
}
