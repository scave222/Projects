using System;

namespace StaticTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("James Stuart");
            Student student2 = new Student("James Stuart");
            Student student3 = new Student("James Stuart");
            Student student4 = new Student("James Stuart");
            Student student5 = new Student("James Stuart");

            Console.WriteLine($"The student class has been instantiated {Student.Counter} times");
        }
    }
}
