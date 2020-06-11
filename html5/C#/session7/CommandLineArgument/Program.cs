using System;
using System.Collections;

namespace CommandLineArgument
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // if (args.Length > 0)
            // {
            //     Console.WriteLine($"You have entered {args.Length} arguments, they are listed below: ");
            //     foreach (var item in args)
            //     {
            //         Console.WriteLine($"{item}");
            //     }
            // }

            
            ArrayList myArray = new ArrayList();

            myArray.Add ("ifeanyi");
            myArray.Add ("SOJ");
            myArray.Add ("Michael");
            myArray.Add ("Abayomi");

            for (int i = 0; i < myArray.Count; i++)
            {
                Console.Write($"Item {i + 1}: {myArray[i]}");
            }
        }
    }
}
