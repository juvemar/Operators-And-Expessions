//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class BitwiseExtractBit3
{
    static void Main()
    {
        Console.Write("Please write an integer number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please write the position of the bit you want to extract: ");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int afterMask = n & mask;
        int back = afterMask >> p;

        Console.WriteLine("The binary representation of {0} is:\n{1}"
                             , n, Convert.ToString(n, 2).PadLeft(16, '0'));
        Console.WriteLine("The value of the bit #{0} of number {1} is {2}", p, n, back);
    }
}