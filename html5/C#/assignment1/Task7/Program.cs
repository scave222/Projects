using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Enter Your Name: ");
            string input = (Console.ReadLine());
 
            foreach(char ch in input)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
