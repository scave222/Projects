using System;

namespace Shift
{
    class Program
    {
        static void Main(string[] args)
        {
             Random random = new Random();

             string[] workers = {"Lekan", "Mathew", "Joy"};
             string[] weeks = {"week 1", "week 2", "week 3", "week 4"};

               int[] shift = new int[3];

                 
                Console.Write("Morning     Afternoon     Night\n");
                for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{weeks[i]}\t{workers[i]}");
                int face = random.Next(1, 4);
                shift[face - 1]++;
            
                
                    Console.Write($"{weeks[i]} {workers[i]} ");
                


                
            }
        }
    }
}
