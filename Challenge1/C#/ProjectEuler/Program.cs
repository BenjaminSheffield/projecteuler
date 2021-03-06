﻿using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MultipleSums(3, 5, 1000));
            Console.ReadLine();
        }

        public static int MultipleSums(int firstNumber, int secondNumber, int total)
        {
            int totalNumber = 0;
            for (int i = 0; i < total; i++)
            {
                if (i % firstNumber == 0 || i % secondNumber == 0)
                {
                    totalNumber += i;
                }
            }
            return totalNumber;
        }
    }
}
