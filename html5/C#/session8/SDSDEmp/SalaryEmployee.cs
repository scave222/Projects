namespace SDSDEmp
{
    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }

        public SalaryEmployee(string first, string last, string address, string gender, Date birth, Date hiredate, decimal salary) : 
        base (first, last, address, gender, birth, hiredate)
        {
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Employment Type: Salary Employee\n{FirstName}, {LastName}\nHired on {HireDate}\nDate of Birth: {Birthday}\nSalary: {Salary:C}";
        }
    }
}