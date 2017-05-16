using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Pentagon : Shape
    {
        private int widthOfASide;
        public Pentagon(int width)
        {
            widthOfASide = width;
        }

        public override void Area()
        {
            Console.WriteLine("Area of Pentagon : " + Math.Pow(widthOfASide, 2) * 0.25 * Math.Sqrt( 5 * ( 5+ 2 * Math.Sqrt(5) ) ));
        }

        public override void Circumference()
        {
            Console.WriteLine("Area of Pentagon : " + 5 * widthOfASide);
        }

        public static Pentagon operator +(Pentagon one, Pentagon two)
        {
            return new Pentagon((one.widthOfASide + two.widthOfASide));
        }
    }
}
