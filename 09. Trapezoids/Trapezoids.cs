//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("Please enter a decimal number for \"a\" side of the trapezoid: ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("Please enter a decimal number for \"b\" side of the trapezoid: ");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.Write("Please enter a decimal number for \"h\" - the height of the trapezoid: ");
        decimal h = decimal.Parse(Console.ReadLine());

        decimal area = ((a + b) * h) / 2;
        Console.WriteLine("The area of the trapezoid is " + area);

    }
}