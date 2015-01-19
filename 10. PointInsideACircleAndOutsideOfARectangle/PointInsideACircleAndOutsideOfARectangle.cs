/*Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5)
and out of the rectangle R(top=1, left=-1, width=6, height=2).*/

using System;

class PointInsideACircleAndOutsideOfARectangle
{
    static void Main()
    {
        double radius = 1.5;
        Console.Write("Please write a double number for a point in coordinate X: ");
        double numX = double.Parse(Console.ReadLine());
        Console.Write("Please write a double number for a point in coordinate Y: ");
        double numY = double.Parse(Console.ReadLine());

        bool checkCirc = (Math.Pow(numX - 1, 2) + Math.Pow(numY - 1, 2)) <= Math.Pow(radius, 2);
        bool checkRect = ((numX < -1) || (numX > 5)) || ((numY < -1) || (numY > 1));

        if(checkCirc && checkRect)
        {
            Console.WriteLine("Congratulations! The point is within the circle and out of the rectangle!");
        }
        else Console.WriteLine("Sorry! The point is not within the circle and out of the rectangle!");
    }
}