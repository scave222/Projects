﻿using System;

namespace MultiplyTwoMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num = {{5,6,4}, {7,5,1}};
            int total = 1;

              for(int i = 0; i < num.GetLength(0); i++)
            {
                for(int k = 0; k < num.GetLength(1); k++)
                {
                    total *= num[i, k];
                }
                
            } Console.WriteLine($"The multiplication of two array is: {total}");
        }
    }
}
