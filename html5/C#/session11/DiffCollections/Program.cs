using System;
using System.Collections;

namespace DiffCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add(5);
            arr.Add(7);
            arr.Add(4);
            arr.Add(5);
            arr.Add(9);
            Console.WriteLine($"Capacity: {arr.Capacity}\nNumber of items stored: {arr.Count}");

    
        }
    }
}
