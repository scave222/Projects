namespace PolyShapes
{
    abstract public class Shapes
    {
        protected int length;
        protected int breadth;
        public abstract int Length{get; set;}
        public abstract int Breadth{get; set;}

        public abstract int area();

        public Shapes(int thelen, int thebreath)
        {
            Length = thelen;
            Breadth = thebreath;
        }
    }

    public class Rectangle : Shapes
    {
        public Rectangle(int thelen, int thebreath):base(thelen, thebreath)
        {
            
        }
        public override int Length{
            get{
                return length;
            }
            set{
                if(value > 0)
                {
                    length = value;
                }
            }
        }

         public override int Breadth{
            get{
                return breadth;
            }
            set{
                if(value > 0)
                {
                    breadth = value;
                }
            }
        }

        public override int area()
        {
            return Length * Breadth;
        }

        public override string ToString() 
        {
            return $"The area of the Rectangle is: {area()}";
        }
    }
}