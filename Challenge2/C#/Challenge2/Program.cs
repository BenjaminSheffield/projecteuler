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
            for (int i = 0; i < 100; i++)
            {
                long result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
                if (result > 4000000)
                {
                    break;
                }
                if (result % 2 == 0)
                {
                    totalNumber += result;
                }
            }
            return totalNumber;
        }
    }
}
