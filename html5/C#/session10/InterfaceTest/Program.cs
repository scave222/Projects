using System;
using System.Collections.Generic;

namespace InterfaceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5.0, 6.0);
            Circle circle = new Circle(8.0);
            Triangle triangle = new Triangle(2.0, 4.0);

            List<IShape> shapes = new List<IShape>() {rectangle,circle,triangle};

            foreach(var item in shapes)
            {
                // Console.Write($"{item.result()}");
                Console.WriteLine($"{item.CalculateArea()}");
            }

            
        }
    }
}
