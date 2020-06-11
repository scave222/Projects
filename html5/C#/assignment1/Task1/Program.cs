using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
             Console.Write("Enter your name: ");
             string name = (Console.ReadLine());
             Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
             Console.WriteLine($"Your name is {name} and age is {age}");
        }
    }
}
