using System;

namespace SchoolPortal
{
    class Program
    {
        static void Main(string[] args)
        {
            string dept;
            int RegNum;
            string name;

            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            Console.Write("Please enter your registration number: ");
            RegNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your department: ");
            dept = Console.ReadLine();

            if(dept == "SCI")
            {
                ScienceStudent scienceStudent = new ScienceStudent(name, RegNum);
            } else if (dept == "COMM")
            {
                CommercialStudent commercialtudent = new CommercialStudent(name, RegNum);
            } else {
                Console.WriteLine("Invalid entry!!! Please try again.");
            }
        }
    }
}
