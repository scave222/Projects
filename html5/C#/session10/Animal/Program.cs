using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Crocodile crocodile = new Crocodile();
            Method method = new Method();

            Console.WriteLine(method.Say());
        }
    }
}
