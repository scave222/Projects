using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double customer1 = 15;
            double customer2 = 20;
            double customer3 = 7.4;
            
            double cus1 = CalculateCharges(customer1);
            double cus2 = CalculateCharges(customer2);
            double cus3 = CalculateCharges(customer3);

            
             Console.WriteLine($"The charge for customer1 is: {cus1:C}");
             Console.WriteLine($"The charge for customer2 is: {cus2:C}");
              Console.WriteLine($"The charge for customer3 is: {cus3:C}");

              Console.WriteLine($"The running Total for yesterday receipt is: {(cus1 + cus2 + cus3):C}");
           
            static double CalculateCharges(double hours){

                if(hours > 3){
                    
                   double result = (Math.Ceiling(hours - 3) * 0.5) + 2;
                   if (result > 10){
                       return 10;
                       }
                       else
                       {
                           return result;
                       }               
                }
                else if (hours <= 3 && hours > 0){
                    return 2;
                }
                else return 0;
            }

        }
    }
}
