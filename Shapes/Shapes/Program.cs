using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangleOne = new Rectangle(3, 5);
            Rectangle rectangleTwo = new Rectangle(4, 5);
            Rectangle sumOfTwoRectangle = rectangleOne + rectangleTwo;

            Square squareOne = new Square(5);
            Square squareTwo = new Square(7);
            Square sumOfTwoSquare = squareOne + squareTwo;

            Circle circleOne = new Circle(7);
            Circle circleTwo = new Circle(10);
            Circle sumOfTwoCircle = circleOne + circleTwo;

            Triangle triangleOne = new Triangle(8);
            Triangle triangleTwo = new Triangle(10);
            Triangle sumOfTwoTriangles = triangleOne + triangleTwo;

            Octagon octagonOne = new Octagon(4);
            Octagon octagonTwo = new Octagon(7);
            Octagon sumOfTwoOctagon = octagonOne + octagonTwo;

            Pentagon pentagonOne = new Pentagon(4);
            Pentagon pentagonTwo = new Pentagon(7);
            Pentagon sumOfTwoPentagon = pentagonOne + pentagonTwo;

            Console.WriteLine("Rectangle One");
            rectangleOne.Area();
            rectangleOne.Circumference();
            Console.WriteLine("-----------------");
            Console.WriteLine("Rectangle two");
            rectangleTwo.Area();
            rectangleTwo.Circumference();
            Console.WriteLine("-----------------");
            Console.WriteLine("Sum of Rectangle");
            sumOfTwoRectangle.Area();
            sumOfTwoRectangle.Circumference();
            Console.WriteLine("-----------------");

            Console.WriteLine("Square One");
            squareOne.Area();
            squareOne.Circumference();
            Console.WriteLine("-----------------");
            Console.WriteLine("Square Two");
            squareTwo.Area();
            squareTwo.Circumference();
            Console.WriteLine("-----------------");
            Console.WriteLine("Sum of two Squares");
            sumOfTwoSquare.Area();
            sumOfTwoSquare.Circumference();
            Console.WriteLine("-----------------");

            Console.WriteLine("Circle One");
            circleOne.Area();
            circleOne.Circumference();
            Console.WriteLine("-----------------");
            Console.WriteLine("Circle One");
            circleTwo.Area();
            circleTwo.Circumference();
            Console.WriteLine("-----------------");
            Console.WriteLine("Sum of two Circle");
            sumOfTwoCircle.Area();
            sumOfTwoCircle.Circumference();
            Console.WriteLine("-----------------");

            Console.WriteLine("Triangle One");
            triangleOne.Area();
            triangleOne.Circumference();
            Console.WriteLine("-----------------");
            Console.WriteLine("Triangle Two");
            triangleTwo.Area();
            triangleTwo.Circumference();
            Console.WriteLine("-----------------");
            Console.WriteLine("Sum of two Triangle");
            sumOfTwoTriangles.Area();
            sumOfTwoTriangles.Circumference();
            Console.WriteLine("-----------------");

            Console.WriteLine("Pentagon One");
            pentagonOne.Area();
            pentagonOne.Circumference();
            Console.WriteLine("-----------------");
            Console.WriteLine("Pentagon Two");
            pentagonTwo.Area();
            pentagonTwo.Circumference();
            Console.WriteLine("-----------------");
            Console.WriteLine("Sum of two Pentagon");
            sumOfTwoPentagon.Area();
            sumOfTwoPentagon.Circumference();
            Console.WriteLine("-----------------");

            Console.WriteLine("Octagon One");
            octagonOne.Area();
            octagonOne.Circumference();
            Console.WriteLine("-----------------");
            Console.WriteLine("Octagon Two");
            octagonTwo.Area();
            octagonTwo.Circumference();
            Console.WriteLine("-----------------");
            Console.WriteLine("Sum of Octagon");
            sumOfTwoOctagon.Area();
            sumOfTwoOctagon.Circumference();
            Console.WriteLine("-----------------");


            Console.ReadLine();

        }
    }
}
