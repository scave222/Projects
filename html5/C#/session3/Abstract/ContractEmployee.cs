namespace Abstract
{
    public class ContractEmployee : Inheritance
    {
       
        public int HourlyPay {get; set;}
        public int TotalHours {get; set;}

        public string GetFullName()
        {
            return this.FirstName + " " + LastName;
        }

        public int GetMonthlySalary()
        {
            return this.TotalHours * this.HourlyPay;
        }
    }
}