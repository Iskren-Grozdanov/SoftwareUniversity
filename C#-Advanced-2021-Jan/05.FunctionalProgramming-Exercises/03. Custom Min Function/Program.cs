﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> func = num => num.Min();

            int[] minNumber = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();                
        }
    }
}
