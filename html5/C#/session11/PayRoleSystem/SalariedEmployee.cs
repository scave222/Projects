namespace PayRoleSystem
{
    public class SalariedEmployee : Employee
    {
        private decimal weeklySalary;

        public SalariedEmployee(string firstname, string lastname, int empID, decimal weeklysalary) : base(firstname, lastname, empID)
        {
            WeeklySalary = weeklysalary;
        }

        public decimal  WeeklySalary{
            get => weeklySalary;
            set 
            {
                if (value > 0m)
                    weeklySalary = value;
                else
                    throw new System.ArgumentException("Value out of range");
           }
        }
        public override decimal Earnings() => WeeklySalary;

        public override string ToString() => $"{base.ToString()}\nSalaried Employee";
    

    }
}