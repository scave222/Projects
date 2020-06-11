using System;

namespace GradeBookTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] Grades = {{50, 60, 70},{40, 90, 50}, {30, 38, 56}, {57, 83, 30}, {60,82, 70},
                             {80, 40, 73}, {56, 61, 20}, {59, 36, 40}, {50, 36, 46}, {53, 30, 50},
            };
            GradeBook gradebook = new GradeBook("Building SoftWare Applcation with C#",Grades);

            gradebook.DisplayDetails();
            gradebook.ProcessGrade();

        }
    }
}
