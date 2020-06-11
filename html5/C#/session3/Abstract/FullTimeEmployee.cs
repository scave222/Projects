namespace Abstract
{
    public class FullTimeEmployee : Inheritance
    {
        
        public int AnnualSalary {get; set;}

        public string GetFullName()
        {
            return this.FirstName + " " + LastName;
        }

        public int GetMonthlySalary()
        {
            return this.AnnualSalary / 12;
        }
    }
}