using System;

namespace ArrayDivisibility
{
    class Program
    {
        static void Main(string[] args)
        {
             
           int[] dist = {7,3,8,6,20};
            int[] list = new int[5];
           for (int i = 0; i < dist.Length; i++)
           {
               if (dist[i] % 2 == 0)
               {    
                  list[i] =   dist[i];
                  Console.WriteLine($" {list[i]} ");
               }
                

           }
        }
    }
}
