using System;

namespace RectangleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Rectangle rectangle = new Rectangle();

            
            Console.WriteLine($"{ rectangle.AreaOfRectangle }");
            Console.WriteLine($"{ rectangle.Perimeter }");
        }
    }
}
