//Write an expression that checks for given integer if its third digit from right-to-left is 7


using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("Please write a three-digit number: ");
        int number = int.Parse(Console.ReadLine());
        while (number < 100)
        {
            Console.WriteLine("The number is invalid! Please write a three-digit number: ");
            number = int.Parse(Console.ReadLine());    
        }

        if ((number / 100) % 10 == 7)
        {
            Console.WriteLine("The third digit from right-to-left of {0} is 7", number);
        }
        else
            Console.WriteLine("The third digit from right-to-left of {0} is not 7", number);
    }
}