using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexTest
{
    class Complex
    {
        private double a;
        private double b;
        private char i;



      
        public Complex(double a = 0.2, double b= 1.2, char i = 'i')
        {
            this.a = a;
            this.b = b;
            this.i = i;
        }

        public string AddTwoComPlex(double A, double B, char I)
        {
            double aa = a + A;
            double bb = b + B;
            return $"{aa} + {bb} {I}";

        }
        public string SubTwoComPlex(double A, double B, char I)
        {
            double aa = a - A;
            double bb = b - B;
            return $"{aa}{bb}{I}";

        }

    }
}
