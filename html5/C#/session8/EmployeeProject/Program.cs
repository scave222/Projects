using System;

namespace EmployeeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1, "James Stuart", 35);
            Employee emp2 = new Employee(2, "john Samson", 50);
            Employee emp3 = new Employee(3, "samuel Robert", 40);
            Employee emp4 = new Employee(4, "Albert Blessed", 82);
            Employee emp5 = new Employee(5, "Roland Goerge", 22);
            
            Employee[] EmpArrayList = {emp1,emp2,emp3,emp4,emp5};

            int empID;

            Console.Write("Please enter employee ID: ");
            empID = Convert.ToInt32(Console.ReadLine());
            foreach(Employee employ in EmpArrayList)
            {
                
                if(employ.EmpID == empID)
                {
                    Console.WriteLine(employ.ToString());
                    break;
                    
                }
            

            }
        }
    }
}
