using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter base: ");
            int theBase = Convert.ToInt32(Console.ReadLine());

             Console.Write("Enter exponent (negative to quit): ");
            int exponent = Convert.ToInt32(Console.ReadLine());

            string result = IntegerPower(theBase, exponent);
            Console.WriteLine($"{result}");
                
                
             static  string IntegerPower( int theBase, int exponent){
                    if(exponent < 0){
                        return "Exponent cant be less than zero";
                    }

                    else {
                        int num = 1;
                        for(int i = 0; i < exponent; i++){
                        num = num * theBase;
                        
                    }   
               return $"{num}";
            }
             
        }
     }
 }
}
