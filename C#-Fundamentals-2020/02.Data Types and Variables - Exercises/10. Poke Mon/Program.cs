﻿using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int targets = 0;
            double currPower = power * 0.5;

            while (power >= distance)
            {
                power -= distance;
                targets++;

                if (currPower == power && exhaustionFactor != 0)
                {
                    power /= exhaustionFactor;
                }

            }
            Console.WriteLine(power);
            Console.WriteLine(targets);
        }
    }
}
