//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

using System;

class BitwiseExtractBit3
{
    static void Main()
    {
        Console.Write("Please write an unsigned integer number: ");
        uint number = uint.Parse(Console.ReadLine());

        int position = 3;
        int mask = 1 << position;
        int afterMask = (int)number & mask;
        int back = afterMask >> position;

        Console.WriteLine("The binary representation of {0} is:\n{1}"
                             , number, Convert.ToString(number, 2).PadLeft(16, '0'));
        Console.WriteLine("The value of the bit #3 of number {0} is {1}", number, back);
    }
}