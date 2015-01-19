//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class PointInACircle
{
    static void Main()
    {
        double radius = 2;
        Console.Write("Please write a double number for coordinate X: ");
        double numX = double.Parse(Console.ReadLine());
        Console.Write("Please write a double number for coordinate Y: ");
        double numY = double.Parse(Console.ReadLine());

        if ((numX * numX + numY * numY) <= (radius * radius))
        {
            Console.WriteLine("The given point with coordinates {0},{1} is inside the circle!", numX, numY);
        }
        else
            Console.WriteLine("The given point with coordinates {0},{1} is not inside the circle!", numX, numY);
    }
}