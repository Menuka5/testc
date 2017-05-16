using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes

{
    class Rectangle : Shape
    {
        public int width { get; set; }
        public int heigth { get; set; }

        public Rectangle(int widthOfRectangle, int heigthOfRectangle)
        {
            width = widthOfRectangle;
            heigth = heigthOfRectangle;
        }

        public override void Area()
        {
            Console.WriteLine("Area of Rectangle : " + (width*heigth));
        }

        public override void Circumference()
        {
            Console.WriteLine("Circumference of Rectangle : " +  2 * (width + heigth));
        }

        public static Rectangle operator +(Rectangle one, Rectangle two)
        {
            return new Rectangle( (one.width + two.width), (one.heigth + two.heigth));
        }
    }
}
