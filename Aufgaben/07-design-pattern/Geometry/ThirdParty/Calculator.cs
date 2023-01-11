using System;

namespace Geometry.ThirdParty
{
    public class Calculator
    {
        public static int GetArea(IRectangular rectangle)
        {
            return rectangle.GetWidth() * rectangle.GetHeight();
        }

        public static int GetPerimeter(IRectangular rectangle)
        {
            return 2 * rectangle.GetWidth() + 2 * rectangle.GetHeight();
        }

        public static double GetDiagonal(IRectangular rectangle)
        {
            return Math.Sqrt(Math.Pow(rectangle.GetHeight(), 2.0) + Math.Pow(rectangle.GetWidth(), 2.0));
        }
    }
}