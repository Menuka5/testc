using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Shape
    {
        public int width { get; set; }

        public Square(int widthOfSquare)
        {
            width = widthOfSquare;
        }
        public override void Area()
        {
            Console.WriteLine("Area of Square : " + (width * width));
        }

        public override void Circumference()
        {
            Console.WriteLine("Circumference of Square : " + (4 * width));
        }

        public static Square operator +(Square one, Square two)
        {
            return new Square(one.width + two.width);
        }
    }
}
