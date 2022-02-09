using System;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Circle");
            Console.WriteLine("2.Square");
            Console.WriteLine("3.Rectangle");
            Console.WriteLine("4.Triangle");
            GeometricCalc objGeo = new GeometricCalc();
            bool flag = true;
            while (flag == true)
            {
                Console.WriteLine("Enter your choice:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Circle objCircle = new Circle();
                        Console.WriteLine("Enter the radius of circle :");         // setRadius(sc.next)
                        objCircle.Radius = float.Parse(Console.ReadLine());
                        float periCir = objGeo.circlePerimeter(objCircle.Radius);
                        float areaCir = objGeo.circleArea(objCircle.Radius);
                        Console.WriteLine("Perimeter of circle is {0}", periCir);
                        Console.WriteLine("Area of circle is {0}", areaCir);
                        break;

                    case 2:
                        Square objSquare = new Square();
                        Console.WriteLine("Enter the side of square :");
                        objSquare.Side = double.Parse(Console.ReadLine());
                        double periSqr = objGeo.squarePerimeter(objSquare.Side);
                        double areaSqr = objGeo.squareArea(objSquare.Side);
                        Console.WriteLine("Perimeter of square is {0}", periSqr);
                        Console.WriteLine("Area of square is {0}", areaSqr);
                        break;

                    case 3:
                        Rectangle objRectangle = new Rectangle();
                        Console.WriteLine("Enter the length of rectangle :");
                        objRectangle.Length = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the breadth of rectangle :");
                        objRectangle.Breadth = double.Parse(Console.ReadLine());
                        double periRect = objGeo.rectanglePerimeter(objRectangle.Length, objRectangle.Breadth);
                        double areaRect = objGeo.rectangleArea(objRectangle.Length, objRectangle.Breadth);
                        Console.WriteLine("Perimeter of Rectangle is {0}", periRect);
                        Console.WriteLine("Area of Rectangle is {0}", areaRect);
                        break;
                    case 4:
                        Triangle objTriangle = new Triangle();
                        Console.WriteLine("Enter the side1 of triangle: ");
                        objTriangle.Side1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the side2 of triangle: ");
                        objTriangle.Side2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the side3 of triangle: ");
                        objTriangle.Side3 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the height of triangle: ");
                        objTriangle.Height = double.Parse(Console.ReadLine());
                        double periTri = objGeo.trianglePerimeter(objTriangle.Side1, objTriangle.Side2, objTriangle.Side3);
                        double areaTri = objGeo.triangleArea(objTriangle.Height, objTriangle.Side2);
                        Console.WriteLine("Perimeter of Triangle is {0}", periTri);
                        Console.WriteLine("Area of Triangle is {0}", areaTri);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }

                Console.WriteLine("for repeat press 1 and to Exit press 0");
                int repeatProcess = int.Parse(Console.ReadLine());
                switch (repeatProcess)
                {
                    case 0:
                        flag = false;
                        break;
                    case 1:
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("invalid choice! please press 1 or 0 only");
                        break;
                }

            }
        }
    }
}
