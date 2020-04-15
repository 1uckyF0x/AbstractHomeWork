using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractHomeWork1504
{
    public class Square : Figure

    {
        public Square(double height, double width) : base(height, width)
        {

        }

        public override double Perimeter()

        {
            return Height * 4;
        }
        public override double Area()

        {
            return Height * Height;
        }
    }
}
