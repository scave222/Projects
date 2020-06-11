using System;

namespace PersonUsingProperties
{
    class Program
    {
        static void Main(string[] args)
        {

            Human jamesStuwat = new Human();
            jamesStuwat.Name = "Jame Stuwat";
            jamesStuwat.Age = 35;
            jamesStuwat.Address = "No 1ks, Gasline Avenue Okoka Ogun State";
            Console.WriteLine($"Name is : {jamesStuwat.Name}");
            Console.WriteLine($"Age is : {jamesStuwat.Age}");
            Console.WriteLine($"Address is : {jamesStuwat.Address}");
        }
    }
}
