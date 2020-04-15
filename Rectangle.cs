using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractHomeWork1504
{
    class Rectangle : Figure
    {
        public Rectangle(double height, double width) : base(height, width)
        {
            
        }

        public override double Area()
        {            
             return Height * Width;          
        }

        public override double Perimeter()
        {
            return 2 * (Height + Width);
        }
    }
}
