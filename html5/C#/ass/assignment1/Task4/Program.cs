using System;

namespace Task4
{
    class Program
    {
        static void Main()
        {
             Console.Write("Enter No 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter No 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter No 3: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Enter No 4: ");
            int num4 = int.Parse(Console.ReadLine());
            Console.Write("Enter No 5: ");
            int num5 = int.Parse(Console.ReadLine());
            Console.Write($"Ascending Sort:");
            
            for (int i = 0; i <= 5 - 1; i++){
            int[] sot =new int[5];
           sot[0]= num1;
           sot[1]= num2;
           sot[2]= num3;
           sot[3]= num4;
           sot[4]= num5;
           Array.Sort(sot);
                
            Console.Write($" {sot[i]},");
        }
        
   
        }
    }
}
