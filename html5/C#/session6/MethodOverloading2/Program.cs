using System;

namespace MethodOverloading2
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.checkNum();
            int a = 3;
            float b = 5.5f;
            number.checkNum(a, b);
        }
    }
}
