using System;

namespace ComplexTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Complex complex = new Complex(3,1,'h');
            //complex.AddTwoComPlex();


            Console.WriteLine($"{complex.SubTwoComPlex(1,12,'i')}");
        }
    }
}
