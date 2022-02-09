using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class GeometricCalc
    {

        //Circle 
        public float circlePerimeter(float radius)
        {
            return 2 * 3.14f * radius;
        }

        public float circleArea(float radius)
        {
            return 3.14f * radius * radius;
        }

        //square

        public double squarePerimeter(double side)
        {
            return 4 * side;
        }

        public double squareArea(double side)
        {
            return side * side;
        }

        // Rectangle

        public double rectanglePerimeter(double length, double breadth)
        {
            return 2 * (length + breadth);
        }

        public double rectangleArea(double length, double breadth)
        {
            return length * breadth;
        }

        // Triangle

        public double trianglePerimeter(double side1, double side2, double side3)
        {
            return side1 + side2 + side3;
        }

        public double triangleArea(double height, double side2)
        {
            return height * side2 / 2;
        }

    }
}
