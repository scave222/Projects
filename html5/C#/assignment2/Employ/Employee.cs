namespace Employ
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private decimal Salary;


        public Employee ( string firstName, string lastName, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            salaries = salary;
        }

        public decimal salaries
        {
            get { return Salary;}
            set {
                if(value >= 0){
                    Salary = value;
                }
            }
        }
    }
}