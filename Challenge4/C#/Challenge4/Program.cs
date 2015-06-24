using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;

namespace Challenge4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Palindromic());
        }

        static int Palindromic()
        {
            var highestPalindromic = 0;
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    var totalNumber = i * j;
                    char[] totalChar = totalNumber.ToString().ToCharArray();
                    char[] charReversed = totalChar.Reverse().ToArray();
                    int reversedNumber = Int32.Parse(new string(charReversed));

                    if (totalNumber == reversedNumber && highestPalindromic < totalNumber)
                    {
                        highestPalindromic = totalNumber;
                    }
                }
            }
            return highestPalindromic;
        }
    }
}
