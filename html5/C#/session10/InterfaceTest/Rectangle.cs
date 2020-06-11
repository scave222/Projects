using System;
namespace InterfaceTest
{
    public class Rectangle : IShape,IDetails
    {
        public Rectangle(double length, double breadth)
        {
            this.Length = length;
            this.Breadth = breadth;

        }
        public double Length { get; set; }
        public double Breadth { get; set; }


        public double CalculateArea()
        {
            return Length * Breadth;
        }

        public string result()
        {
            return "This is a Rectangle the area is ";
        }
    }
}