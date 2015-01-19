/*Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right)
in given integer number n, has value of 1.*/

using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Please write an integer number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please write the position of the bit you want to extract: ");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int afterMask = mask & n;
        int back = afterMask >> p;

        bool checkIf1 = back ==1;
        if (checkIf1)
        {
            Console.WriteLine("The value of position {0} in number {1} is 1.", p, n);
        }
        else Console.WriteLine("The value of position {0} in number {1} is 0.", p, n);
    }
}