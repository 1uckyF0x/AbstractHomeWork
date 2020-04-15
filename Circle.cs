using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractHomeWork1504
{
    class Circle : Figure

    {
        public const double PI = 3.14;
        public Circle(double height, double width) : base(height, width)
        {

        }
        public override double Perimeter()

        {
            return Height * 2 * PI;
        }

        public override double Area()

        {
            return Height * Height;
        }

    }
}
