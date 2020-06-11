using System;

namespace MultiCastDeligate
{
    public delegate void Calculate(int a , int b);
    class Program
    {
        static void Main(string[] args)
        {
           //Working with Multicast Delegate
           Calculate calculate = Aritmethic.Add;
           calculate += Aritmethic.Division;
           calculate += Aritmethic.Multiplication;
           calculate += Aritmethic.Subtract;

            calculate(10,5);

            calculate -= Aritmethic.Subtract;
            Console.WriteLine("===========Removing reference to subtract method=============");
            calculate(10,5);
        
        }
    }
}
