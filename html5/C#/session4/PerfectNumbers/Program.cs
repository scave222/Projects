using System;

namespace PerfectNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write ("______ Welcome to Codebits Academy ___________________\n");
        string name, gender;

           Console.Write("Enter youe name: ");
            name = Console.ReadLine();

           Console.Write("Are you a male or female?: If male enter m else type f: ");
            gender = Console.ReadLine();

           
            string title = (gender == "m") ? "Mr" : "Mrs";
            Console.WriteLine($"Welcome {title} {name}");
               }
           }

           }
        
    

