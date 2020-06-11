using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name: ");
            string name = (Console.ReadLine());
            Console.WriteLine($"Your name starts with - {name[0]}");
        }
    }
}
