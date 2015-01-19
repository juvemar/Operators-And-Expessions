//Write an expression that checks if given integer is odd or even.

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Please write an integer variable");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("The number is {0}", n % 2 == 0 ? "even" : "odd");

    }
}