using System;

namespace SDSDEmp
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date (03, 6, 2010);
            Date date1 = new Date (08, 3, 1990);
            Employee employee = new Employee("Caleb", "Okogbe", "Km 20 Covenant", "Male", date, date1);
            SalaryEmployee salaryEmployee = new SalaryEmployee("Micheal", "Robert", "Km 20 Covenant", "Male", date, date1, 40000);
            CommissionEmployee commissionEmployee = new CommissionEmployee("John", "Collins", "Km 20 Covenant", "Male", date, date1,10000,0.4,500000 );
            BasePlusEmp basePlusEmp = new BasePlusEmp("John", "Collins", "Km 20 Covenant", "Male", date, date1,10000,0.4,500000,20000 );
        }
    }
}
