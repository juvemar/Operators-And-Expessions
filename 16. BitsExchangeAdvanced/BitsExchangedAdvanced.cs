//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.

using System;

class BitsExchangeAdvanced
{
    static void Main()
    {
        ulong number;
        bool correctNumber;
        bool correctPosition;
        int lowerBits;
        int higherBits;
        int counter;

        do
        {
            Console.Write("Please enter a positive number: ");
            string enteredNumber = Console.ReadLine();
            correctNumber = ulong.TryParse(enteredNumber, out number);
        } while (number < 0 || correctNumber == false);

        do
        {
            Console.Write("Please enter an integer for a first position of bits you want to exchange: ");
            string enteredNumber = Console.ReadLine();
            correctPosition = int.TryParse(enteredNumber, out lowerBits);
        } while (number < 0 || correctPosition == false);

        do
        {
            Console.Write("Please enter an integer for a higher position of bits you want to exchange: ");
            string enteredNumber = Console.ReadLine();
            correctPosition = Int32.TryParse(enteredNumber, out higherBits);
        } while (number < 0 || correctPosition == false);

        do
        {
            Console.Write("Please enter an integer for the number of bits you want to exchange: ");
            string enteredNumber = Console.ReadLine();
            correctPosition = Int32.TryParse(enteredNumber, out counter);
        } while (number < 0 || correctPosition == false);

        int i;
        int j;
        int h=0;//This variable checks if we make exchanges equal to "counter".
        int numberOfLoops = 0;//This variable check if the first and the second position overlap.
        for(i=lowerBits,j=higherBits;i<(j-numberOfLoops);i++,j++)
        {
            if(((number>>i) & 1) != ((number>>j) &1))
            {
                number = number ^ (ulong)(1 << i);
                number = number ^ (ulong)(1 << j);
                h++;
                if(h == counter)
                {
                    break;
                }
            }
            numberOfLoops++;
        }
        Console.WriteLine("Your number after the exchange is: {0}", number);

      
    }
}