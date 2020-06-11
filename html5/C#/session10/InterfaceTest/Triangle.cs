namespace InterfaceTest
{
    public class Triangle : IShape,IDetails
    {
        public double Base {get; set;}
        public double Height {get; set;}

        public Triangle(double bas, double height)
        {
            Base = bas;
            Height = height;
        }

        public double CalculateArea()
        {
            return 0.5 * (Base * Height);
        }

        public string result()
        {
            return "This is a Triangle the area is ";
        }
    }
}