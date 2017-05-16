using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Octagon : Shape
    {
        private int widthOfSide;
        

        public Octagon(int width)
        {
            widthOfSide = width;
        }

        public override void Area()
        {
            Console.WriteLine("Area of Octagon : " + 2 * (1 + Math.Sqrt(2))*(Math.Pow(widthOfSide, 2) ));
        }

        public override void Circumference()
        {
            Console.WriteLine("Circumference of Octagon : " + 8*widthOfSide);
           
        }

        public static Octagon operator +(Octagon one, Octagon two)
        {
            return new Octagon((one.widthOfSide + two.widthOfSide));
        }
    }

}
