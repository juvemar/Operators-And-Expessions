/*We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p
from the binary representation of n while preserving all other bits in n.*/

using System;

class ModifyABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Please enter an integer number \"n\": ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter an index \"p\": ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Please enter a value (0 or 1) \"v\": ");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("The binary representation of {0} is:\n {1}", n, Convert.ToString(n, 2).PadLeft(16, '0'));

        int mask;
        int result;

        if (v == 0)
        {
            mask = ~(1 << p);
            result = n & mask;
            Console.WriteLine("The binary representation after the change is:\n {0}", Convert.ToString(result, 2).PadLeft(16, '0'));
        }
        else
        {
            mask = 1 << p;
            result = mask | n;
            Console.WriteLine("The binary representation after the change is:\n {0}", Convert.ToString(result, 2).PadLeft(16, '0'));
        }
    }
}