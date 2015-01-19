//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Please give a decimal number for width of the rectangle: ");
        decimal width = decimal.Parse(Console.ReadLine());
        Console.Write("Please give a decimal number for height of the rectangle: ");
        decimal height = decimal.Parse(Console.ReadLine());

        Console.WriteLine("The parameter of the rectangle is: {0}", 2*(width + height));
        Console.WriteLine("The area of the rectangle is: {0}", width*height);
    }
}