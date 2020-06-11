using System;

namespace PersonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();

            Console.Write("Please enter your name: ");
            string yourName = Console.ReadLine();
            person1.setName(yourName);

            Console.Write("Please enter your age: ");
            int yourAge = int.Parse(Console.ReadLine());
            person1.setAge(yourAge);

            Console.Write("Please enter your address: ");
            string yourAddress = Console.ReadLine();
            person1.setAddress(yourAddress);

            string value = $"{person1.displayDetails()}";
            Console.Write(value);
        }
    }
}
