﻿using System;

namespace potokOtSimvoli
{
    class potokOtSimvoli
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int len = text.Length;
            for (int i = 0; i < len; i++)
            {
                char symbol = text[i];
                Console.WriteLine(symbol);

            }
        }
    }
}
