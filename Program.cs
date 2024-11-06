using System.Formats.Asn1;

namespace Assignment_1_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 1.3.1
             * Write a program in C# to calculate area of triangle, square and rectangle. 
             * Write 3 different functions for each shape to take dimensions of figure and display the area. 
             * You may create menus. */

            /* Area of a Triangle, A = 1/2 × base × height
             * Area of a Rectangle, A = base x height
             * 
             * A square uses the same formula as a rectangle for it's area.
            */

            int triangleBase = 5, triangleHeight = 3;
            int squareBase = 4, squareHeight = 4;
            int rectangleBase = 6, rectangleHeight = 4;

            double triangleArea = CalculateTriangleArea(triangleBase, triangleHeight);
            double squareArea = CalculateSquareArea(squareBase, squareHeight);
            double rectangleArea = CalculateRectangleArea(rectangleBase, rectangleHeight);

            Console.WriteLine($"A triangle with a base length of {triangleBase} and a height of {triangleHeight} has an area of {triangleArea}.");
            Console.WriteLine($"A square with a base length of {squareBase} and a height of {squareHeight} has an area of {squareArea}.");
            Console.WriteLine($"A rectangle with a base length of {rectangleBase} and a height of {rectangleHeight} has an area of {rectangleArea}.");
        }

        static double CalculateTriangleArea(int b, int h)
        {
            return 0.5 * (b * h);
        }

        static double CalculateSquareArea(int b, int h)
        {
            return b * h;
        }

        static double CalculateRectangleArea(int b, int h)
        {
            return b * h;
        }
    }
}
