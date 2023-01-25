using System;
using Geometry.ThirdParty;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            IRectangular rectangle = new Rectangle(3, 4);
            Console.WriteLine(rectangle);
            Console.WriteLine("Area:\t\t" + Calculator.GetArea(rectangle));
            Console.WriteLine("Perimeter:\t" + Calculator.GetPerimeter(rectangle));
            Console.WriteLine("Diagonal:\t" + Calculator.GetDiagonal(rectangle));
            Console.WriteLine("Width/Height Ratio: \t" + Calculator.GetWidthHeightRatio(rectangle));

            IQuadratic square = new Square(3);
            IRectangular rectSquare = new RectangleAdapter(square);
            Console.WriteLine(square);
            Console.WriteLine("Area:\t\t" + Calculator.GetArea(rectSquare));
            Console.WriteLine("Perimeter:\t" + Calculator.GetPerimeter(rectSquare));
            Console.WriteLine("Diagonal:\t" + Calculator.GetDiagonal(rectSquare));
            Console.WriteLine("Width/Height Ratio: \t" + Calculator.GetWidthHeightRatio(rectSquare));


            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Fac von {i}: {Fac(i)}");
            }
        }

        public static int Fac(int number)
        {
            var zaehler = 1;
            var summe = 1;

            while (number != zaehler)
            {
                if (number == 0)
                {
                    return 1;
                }

                summe = number * zaehler;
                zaehler++;
            }

            return zaehler;
        }

    }
}
