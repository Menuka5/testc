using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Shape
    {
        private int radius;
        public Circle(int radiusOfCircle)
        {
            radius = radiusOfCircle;
        }

        public override void Area()
        {
            Console.WriteLine("Area of Circle : " + (Math.PI * Math.Pow(radius, 2)));
        }

        public override void Circumference()
        {
            Console.WriteLine("Circumference of circle : " + (2 * Math.PI * radius));
        }

        public static Circle operator +(Circle one, Circle two)
        {
            return new Circle(one.radius + two.radius);
        }
    }
}
