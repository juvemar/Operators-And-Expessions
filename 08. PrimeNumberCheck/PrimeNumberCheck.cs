/*Write an expression that checks if given positive integer number n (n = 100)
is prime (i.e. it is divisible without remainder only to itself and 1).*/

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Please enter a positive integer number up to 100: ");
        int number = int.Parse(Console.ReadLine());
        bool check = (number >= 1 && number <= 100);
        while (check == false)
        {
            Console.WriteLine("Invalid number! Please enter a positive integer number up to 100: ");
            number = int.Parse(Console.ReadLine());
            if (number >= 1 && number <= 100)
            {
                check = true;
            }
        }
        bool primerOrNot = (number % 2 != 0) && (number % 3 != 0) || number == 2 || number == 3;
        if (primerOrNot)
        {
            Console.WriteLine("The number {0} is prime!", number);
        }
        else
            Console.WriteLine("The number {0} is not prime!", number);
        
    }
}