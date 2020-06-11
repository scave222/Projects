using System;
using System.Collections.Generic;

namespace PayRoleSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            SalariedEmployee salariedEmployee = new SalariedEmployee("James", "Stuart", 001, 10000m);
            HourlyEmployee hourlyEmployee = new HourlyEmployee("Ruth", "Rutherford", 241, 40, 500m);
            CommisionedEmployee commissionedEmployee = new CommisionedEmployee("John", "Stuart", 201, 0.08, 10000m);
            BasePlusCommissionEmployee basePlusCommissionEmployee = new BasePlusCommissionEmployee("John", "Ruth", 001, 10.04m, 0.06, 2000m);

            Invoice invoice1 = new Invoice("Century Fan", "Standing Rechargeable Fan", 18000m, 2);
            Invoice invoice2 = new Invoice("Projector", "EPSON Projector 3456", 68000m, 1);


            Console.WriteLine("=== POLYMORPHYCALLY ACCESSING METHODS OF OBJECTS CREATED FROM CONCRETE DERIVED-CLASSES OF AN ABSTRACT BASE CLASS");
            List<IPayment> paymentsDue = new List<IPayment> () {salariedEmployee, hourlyEmployee, commissionedEmployee, basePlusCommissionEmployee, invoice1, invoice2};

            foreach (var payment in paymentsDue){
                 Console.WriteLine(payment);
                
                if (payment is BasePlusCommissionEmployee)
                {
                    var baseEmply = (BasePlusCommissionEmployee)payment;
                    baseEmply.BaseSalary *= 1.10m;
                    Console.WriteLine($"Salary increment by: 10% {baseEmply.BaseSalary}");
                }
                Console.WriteLine($"Amount to be paid: {payment.GetPaymentAmount():C}\n");

               
            }
        }
    }
}
