//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;
class ModifyABitAtGivenPosition
{
    static void Main()
    {
        ulong number;
        bool correctNumber;

        do
        {
            Console.Write("Please enter a positive number: ");
            string enteredNumber = Console.ReadLine();
            correctNumber = ulong.TryParse(enteredNumber, out number);
        }while(number < 0 || correctNumber == false);

        for (int lowerBits = 3, higherBits = 24; lowerBits < 6; lowerBits++, higherBits++)
        {
            if (((number >> lowerBits) & 1) != ((number >> higherBits) & 1))
            {
                number = number ^ (ulong)(1 << lowerBits);
                number = number ^ (ulong)(1 << higherBits);
            }
        }
        Console.WriteLine("Your number after the exchange of the bits is {0}", number);
    }
}