//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;
using System.Threading;

class GravitationOnTheMoon
{
    static void Main()
    {
        //If the Moon's gravity is 17% of the Earth's so the weight of a man will be 83% less than on the Earth
        Console.Write("Please write your weight: ");
        double earthWeight = double.Parse(Console.ReadLine());
        double gravityRatio = 0.17;
        double moonWeight = gravityRatio * earthWeight;
        Console.WriteLine("Your weight on the Moon would be {0}", moonWeight);
    }
}