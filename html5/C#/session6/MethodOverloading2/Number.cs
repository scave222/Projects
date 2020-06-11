using System;
namespace MethodOverloading2
{
    public class Number
    {
        public int Num {get; set;}
        public void checkNum(){
            Console.WriteLine("Implement Method Overloading - checkNum without parameter called!!!");
        }

        public void checkNum(int n){
            Console.WriteLine("Implement Method Overloading - checkNum with an integer type parameter called!!!");
        }

         public void checkNum(int n1, int n2){
            Console.WriteLine("Implement Method Overloading - checkNum with  two parameter of type int called!!!");
        }

         public void checkNum(int n1, float n2){
            Console.WriteLine("Implement Method Overloading - checkNum with two parameter of type int and type float called!!!");
        }

        public void checkNum(float n){
            Console.WriteLine("Implement Method Overloading - checkNum with one parameter of type float called!!!");
        }
    }
}