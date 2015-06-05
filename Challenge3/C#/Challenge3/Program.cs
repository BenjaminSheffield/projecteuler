using System;

namespace Challenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrimeFactors());
            Console.ReadLine();
        }

        public static long PrimeFactors()
        {
            long totalNumber = 600851475143;

            for (int i = 2; i < totalNumber; i++)
            {
                if (totalNumber % i == 0)
                {
                    totalNumber = (totalNumber / i);
                }
            }
            return totalNumber;
        }
    }
}
