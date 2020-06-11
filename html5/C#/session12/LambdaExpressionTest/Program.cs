using System;

namespace LambdaExpressionTest
{
    public delegate void Greet();
    class Program
    {
        static void Main(string[] args)
        {
            Func<string,int> ReturnLength = x => x.Length;
            string str ="James Stuart";
            Console.WriteLine($"The length of {str} is {ReturnLength(str)}");

            Func<string,int> ReturnLenth = delegate(string x){
                return x.Length;
            };

            string st ="James";
            Console.WriteLine($"The length of {st} is {ReturnLenth(st)}");

            
            //Student student = new Student(7);
            Student student = new Student{Age = 30};
            Predicate<Student> checkStudentAge = (stud) => {return stud.Age > 12 && stud.Age < 20 ;};
            bool status = checkStudentAge(student);
            Console.WriteLine($"Student's age status is: {status}");

            Func<int,int,int> Com = (int a,int b) => {
                if(a > b)
                {
                    return a;
                }
                return b;
            };
            Console.WriteLine($"The largest using Lambda method is {Com(9,8)}");


            Func<int,int,int> Compare = delegate(int a,int b)
            {
                if(a > b)
                {
                    return a;
                }
                return b;
            };
            Console.WriteLine($"The largest using anonymouse method is {Compare(9,8)}");

             int Largest(int a, int b)
            {
                if(a > b)
                {
                    return a;
                }
                return b;
            }
            Console.WriteLine($"The largest is {Largest(9,8)}");


            Greet greet = () => {Console.WriteLine("Good Afternoon!");};
            greet();

            // Func<bool,int> CalculateValue = delegate(Student student)
            //     {
            //         return 5;
            //     };

        }

        // public static bool CheckAge(Student stud)
        // {
        //     if(stud.Age > 12 && stud.Age < 20)
        //     {
        //         return true;
        //     }
        //     return false;
        // }

        
    }
}
