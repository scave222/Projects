using System;

namespace DelegateTest
{
    public delegate void SayHiDeligate(string Aname);
    public delegate int Calculate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            SayHiDeligate sayHi = new SayHiDeligate(SayHi);
            //Another way of craeting an instance of a deligate
            SayHiDeligate sayHi2 = SayHi;

            sayHi("James");  //First method of invoking a deligate
            sayHi2.Invoke("Bukola");  //Second method of invoking a deligate

            Calculate calculate = Aritmethic.Add;
            int result = calculate(60,40);
            Console.WriteLine($"The sum of 60 and 40 is {result}");
        }

        private static void SayHi(string name)
        {
            Console.WriteLine($"Hi {name},I am learning delegate");
        }
    }
}
