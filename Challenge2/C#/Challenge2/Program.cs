using System;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci());
            Console.ReadLine();
        }

        public static long Fibonacci()
        {
            long firstNumber = 0;
            long secondNumber = 1;
            long totalNumber = 0;
            long result = firstNumber + secondNumber;
            while (result < 4000000)
            {
                firstNumber = secondNumber;
                secondNumber = result;
                result = firstNumber + secondNumber;
                if (result % 2 == 0)
                {
                    totalNumber += result;
                }
            }
            return totalNumber;
        }
    }
}
