using System;
namespace StaticTest
{
    public class Student
    {
        public static int Counter { get; set; }

        public string Name {get; set;}

        public Student(string studentName)
        {
          //  Name = studentName;
            Counter++;
            Console.WriteLine("One object added to ");
        }
    }
}