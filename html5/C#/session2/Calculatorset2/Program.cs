using System;

namespace Calculatorset2
{
    class Program
    {
        static void Main(string[] args)
        {


           Calculator calculator = new Calculator();
           Console.Write("\nPlease enter number1: ");
           calculator.Num1 = Convert.ToDouble(Console.ReadLine());

           
           Console.Write("\nPlease enter number2: ");
           calculator.Num2 = Convert.ToDouble(Console.ReadLine());

           Console.Write("\nPlease enter an operator between 1,2,3 and 4 which stands for +,-,* and / respectively: ");
           int action = int.Parse(Console.ReadLine());

           if(action == 1){
               Console.Write($"\nThe sum of {calculator.Num1} and {calculator.Num2} is {calculator.add()} ");
           }

           if(action == 2){
               Console.Write($"\nThe subtraction of {calculator.Num1} and {calculator.Num2} is {calculator.sub()} ");
           }
           if(action == 3){
               Console.Write($"\nThe multiplication of {calculator.Num1} and {calculator.Num2} is {calculator.mult()} ");
           }

           if(action == 4){
               if(calculator.Num2 == 0){
                  Console.Write($"\nThe division of {calculator.Num1} and {calculator.Num2} is 0.0 "); 
               }else
               Console.Write($"\nThe division of {calculator.Num1} and {calculator.Num2} is {calculator.div()} ");
           }


          
        }
    }
}
