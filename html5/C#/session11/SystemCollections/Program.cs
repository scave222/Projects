using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SystemCollections
{
    class Program 
    {
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee();
            objEmployee.Add(343,"Abayomi");
            objEmployee.Add(478,"James");
            objEmployee.Add(638,"John");
            objEmployee.Add(106,"Peter");
            Console.WriteLine("Original values stored in Dictionary");
            objEmployee.GetDetails();
            objEmployee.OnRemove(106);
            Console.WriteLine("Modified values stored in Dictionary");
            objEmployee.GetDetails();
            
        }
    }
}
