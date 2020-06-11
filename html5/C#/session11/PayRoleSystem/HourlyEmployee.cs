using System;
namespace PayRoleSystem
{
    public class HourlyEmployee : Employee
    {
        private int hoursWorked;
        private decimal hourlyWage;

        public HourlyEmployee(string firstname, string lastname, int empID, int hoursworked, decimal hourlywage) : base(firstname, lastname, empID)
        {
            HoursWorked = hoursworked;
            HourlyWage = hourlywage;
        }

        public override decimal Earnings()
        {
            if (HoursWorked > 40)
            {
                return ((40 * HourlyWage) + ((HoursWorked - 40) * (HourlyWage * 1.5m)));
            } else {
                return HoursWorked * HourlyWage;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nHourly Employee\nHourly Wage: {HourlyWage}\nHours Worked: {HoursWorked}";
        }

        public int HoursWorked{
            get => hoursWorked;
            set {
                if((value > 0) && (value <= 120))
                {
                    hoursWorked = value;
                }else {
                    throw new ArgumentOutOfRangeException("Argument out of range - Hours worked > 0 and <= 120");
                }
            }
        }

        public decimal HourlyWage
        {
            get => hourlyWage;
            set {
                if(value > 0)
                {
                    hourlyWage = value;
                } else {
                    throw new ArgumentOutOfRangeException("Argument of range - Hourly wage must be > 0");
                }
            }
        }
    }
}