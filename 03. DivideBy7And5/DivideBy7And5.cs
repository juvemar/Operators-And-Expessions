//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Please write a number: ");
        int givenInt = int.Parse(Console.ReadLine());
        bool check = (givenInt % 7 == 0) && (givenInt % 5 == 0);

        if (check == true)
        {
            Console.WriteLine("The number {0} can be divided without remainder by 5 and 7", givenInt);
        }
        else
        {
            Console.WriteLine("The number {0} can not be divided without remainder by 5 and 7", givenInt);
        }
    }
}