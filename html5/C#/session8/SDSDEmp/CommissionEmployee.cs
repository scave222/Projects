namespace SDSDEmp
{
    public class CommissionEmployee 
    {
        private decimal commission;
        public double Rate {get; set;}
        public decimal Sales {get; set;}

         public CommissionEmployee(string first, string last, string address, string gender, Date birth, Date hiredate, decimal commissioned, double rate, decimal sales) : 
        base (first, last, address, gender, birth, hiredate)
        {
            Commission = commissioned;
            Rate = rate;
            Sales = sales;
        }

         public override string ToString()
        {
            return $"Employment Type: Salary Employee\n{FirstName}, {LastName}\nHired on {HireDate}\nDate of Birth: {Birthday}\nCommision: {Commission:C}";
        }

       public decimal Commission{
           get {return commission;}
           
       }
    }
}