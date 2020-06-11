using System;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {20,15,30,70,5,6,15};

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        int arry = arr[i];
                        arr[i] = arr[j];
                        arr[j] = arry;
                    }
                }Console.Write($"{arr[i]},");
            }
        }
    }
}
