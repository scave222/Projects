using System;
namespace Animal
{
    public class Method : IMethod
    {
        public void SayHi()
        {
            Console.WriteLine("Say hi from hi method");
        }

        public void Say()
        {
            Console.WriteLine("Hi");
        }
    }
}