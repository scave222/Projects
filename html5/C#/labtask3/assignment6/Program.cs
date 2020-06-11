using System;

namespace assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Perfect(){
           for (int i = 2; i<= 1000; i++)
           {
               int sum = 0;
               for(int j = 1; j <= i; j++)
               {
                   if(i % j == 0)
                   {
                       sum = sum + j;
                   }
               }
               if((sum - i)== i)
               {
                   Console.WriteLine($"\n{i} is a perfect number ");
                   for(int k = 1; k < i; k++)
                   {
                       if(i % k == 0)
                       {
                           Console.Write($"{k} is a factor of {i} \n");
                       }
                   }
               }
           }
           }
           Perfect(); 
        }
    }
}
