﻿using System;

namespace StepeniNa2
{
    class StepeniNa2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    double result = Math.Pow(2, i);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
