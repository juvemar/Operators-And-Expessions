/*Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).*/

using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Please write a four-digit number in format abcd: ");
        int input = int.Parse(Console.ReadLine());

        int d = input % 10;
        int c = (input / 10) % 10;
        int b = (input / 100) % 10;
        int a = (input / 1000) % 10;
        int sum = a + b + c + d;
        Console.WriteLine("The sum of the digits of {0} is {1}", input, sum);
        Console.WriteLine("Reversed: {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("Last digit put in front: {3}{0}{1}{2}", a, b, c, d);
        Console.WriteLine("Exchanged second and third digits: {0}{2}{1}{3}", a, b, c, d);
    }
}