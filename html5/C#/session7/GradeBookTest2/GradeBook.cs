using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBookTest2
{
    class GradeBook
    {
        private string CourseName { get; set; }
        private int[,] grades;




        public GradeBook(string coursename, int[,] Grades)
        {
            CourseName = coursename;
            grades = Grades;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"CSC 101 Result for Class A- {CourseName}");
        }



        public void ProcessGrade()
        {
            DisplayGrades();
            Console.WriteLine($"The Lowest Grade is {GetMiniuim()}");
            Console.WriteLine($"The Highedt Grade is {GetMaximum()}");
        }

        private int GetMiniuim (){
            int lowest = grades[0, 0];
            foreach(int grade in grades)
            {
                if(grade < lowest)
                {
                    lowest = grade;
                }
               
            }
            return lowest;
        }
        private int GetMaximum()
        {
            int highest = grades[0, 0];
            foreach (int grade in grades)
            {
                if (grade > highest)
                {
                    highest = grade;
                }

            }
            return highest;
        }
        private void DisplayGrades()
        {
            //double[] testAverage = GetAverage();
           
            for(int i = 0; i < grades.GetLength(0); i++)
            {
                double total = 0.0;
                Console.Write($"Student {i + 1,3}");
                for(int k = 0; k < grades.GetLength(1); k++)
                {
                    total += grades[i, k];
                    Console.Write($"{grades[i, k], 3}\t ");
                }
                double average = total / grades.GetLength(1);
                Console.Write($"{average,4:f}");
                Console.WriteLine();
            }
        }

        // private double [] GetAverage()
        // {
        //     double[] average = new double[10];
           
        //      for(int i =0; i < grades.GetLength(0); i++)
        //     {
        //         double total = 0.0;
        //         for (int k = 0; k < grades.GetLength(i); k++)
        //         {
        //             total += grades[i,k];
        //         }
        //         double ave = total / grades.GetLength(i);
        //         average[i] = ave;
        //     }
        //     return average;

        // }
    }
}
