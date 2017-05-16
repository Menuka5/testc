using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : Shape
    {
        public int side { get; set; }
        public Triangle(int lenghOfSide)
        {
            side = lenghOfSide;
        }

        public override void Area()
        {
            Console.WriteLine("Area of Circle : " + (.25*Math.Sqrt(3)*Math.Pow(side, 2) ));
        }

        public override void Circumference()
        {
            Console.WriteLine("Circumference of triangle : " + (3*side));
        }

        public static Triangle operator +(Triangle one, Triangle two)
        {
            return new Triangle(one.side + two.side);
        }
    }
}
