using System;
namespace PayRoleSystem
{
    public class CommisionedEmployee : Employee
    {
        private double commRate;
        private decimal totalSales;

        public CommisionedEmployee(string firstname, string lastname, int empID, double comm, decimal sales) : base (firstname, lastname, empID)
        {
            CommissionRate = comm;
            TotalSales = sales;
        }

        public double CommissionRate{
            get => commRate;

            set{
                if(value > 0 && value <= 1)
                {
                    commRate = value;
                } else {
                    throw new ArgumentOutOfRangeException("Commission must be > 0 and <= 1");
                }
            }
        }

        public decimal TotalSales{
            get => totalSales;

            set{
                if(value > 0)
                {
                    totalSales = value;
                } else {
                    throw new ArgumentOutOfRangeException("Total Sales must be > 0");
                }
            }
        }

        public override decimal Earnings()
        {
            return (decimal)CommissionRate * TotalSales;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nTotal Sales: {TotalSales}\nCommission Rate: {CommissionRate * 100}%";
        }

        
    }
}