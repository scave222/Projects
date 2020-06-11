using System;

namespace CallProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = {90,32,33,89,60,79,23,91,65,76,98};

            int Firsthighest = num[0];
            
            for (int i = 1; i < num.Length; i++)
            {   
                if (num[i] > Firsthighest)
                {
                    Firsthighest = num[i];
                }   

            }

            
            int second=num[0];
            if (Firsthighest == second)
            {
                second = num[1];
            }
            
            for(int j = 0; j < num.Length; j++)
            {
                
                if(num[j] > second && num[j] < Firsthighest)
                second = num[j];       
            }
            Console.WriteLine(second);
        }
        }
    }

