using System;
using System.Diagnostics;

namespace Challenge5
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = Stopwatch.StartNew();
            long testNumber = 20;
            while (testNumber % 2 != 0 || testNumber % 3 != 0 || testNumber % 4 != 0 || testNumber % 5 != 0 ||
                     testNumber % 6 != 0 || testNumber % 7 != 0 || testNumber % 8 != 0 || testNumber % 9 != 0 ||
                     testNumber % 10 != 0 || testNumber % 11 != 0 || testNumber % 12 != 0 || testNumber % 13 != 0 ||
                     testNumber % 14 != 0 || testNumber % 15 != 0 || testNumber % 16 != 0 || testNumber % 17 != 0 ||
                     testNumber % 18 != 0 || testNumber % 19 != 0 || testNumber % 20 != 0)
            {
                testNumber += 20;
            }

            Console.WriteLine(testNumber);
            sw.Stop();
            TimeSpan time = sw.Elapsed;
            Console.WriteLine(time);
            Console.Read();
        }
    }
}
