using System;
namespace InheritanceTest
{
    public class Automobile
    {
        //authomatic properties
        public int NumWheels { get; set; }
        public string Colour { get; set; }

        public int YearManu { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; } 

//constructor   int nw, string col, int year, string mod, string man
        public Automobile()
    {
        // NumWheels = nw;
        // Colour = col;
        // YearManu = year;
        // Model = mod;
        // Manufacturer = man;
        Console.WriteLine("Automobile constructor called!");
    }

    public virtual void Move(){
        Console.WriteLine("Automobile is moving!!!");
    }

     public  void Stop(){
        Console.WriteLine("Automobile has stoped!!!");
    }


    }

    class Car:Automobile
    {
        //method overiding
        public override void Move()
        {
            Console.WriteLine("Car is moving!!");
        }

        // public void Stop()
        // {
        //     //Console.WriteLine("Car has stoped!!");
        // }
    }
    
}