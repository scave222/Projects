namespace SDSDEmp
{
    public class BasePlusEmp
    {
        private decimal commission;
        public double Rate {get; set;}
        public decimal Sales {get; set;}
        public decimal BaseSalary{get; set;}

        public BasePlusEmp(string first, string last, string address, string gender, Date birth, Date hiredate, decimal commissioned, double rate, decimal sales, decimal baseSalary) : 
        base (first, last, address, gender, birth, hiredate)
        {
            Commission = commissioned;
            Rate = rate;
            Sales = sales;
            BaseSalary = baseSalary;

        }

         public override string ToString()
        {
            return $"Employment Type: Salary Employee\n{FirstName}, {LastName}\nHired on {HireDate}\nDate of Birth: {Birthday}\nCommision: {Commission:C}\nBase Salary: {BaseSalary}";
        }

        public decimal Commission{
           get {return commission;}
           
       }
    }
}