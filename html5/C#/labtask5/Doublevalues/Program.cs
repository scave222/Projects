using System;

namespace Doublevalues
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
             if (args.Length > 0)
            {
                Console.WriteLine($"You have entered {args.Length} arguments, their sum is: ");
                foreach (string item in args)
                {
                    num = num + Convert.ToInt32(item);
                    
                }
                Console.WriteLine($"{num}");
            }

        }
    }
}
