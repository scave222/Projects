namespace GenericQueueTest
{
    public class Circle
    {
        double radius;
        const double PI = 22/7;
        public Circle()
        {
            radius = 34;
        }
        public double GetArea()
        {
            return 2 * PI * radius * radius;
        }

        public override string ToString() 
        {
            return $"Area is: {GetArea()}";
        }
    }
}