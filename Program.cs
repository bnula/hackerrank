using System;
using System.Collections.Generic;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "DDUUDDUDUUUD";
            var valleys = CountingValleys.cntValleys(8, path);
            Console.WriteLine(valleys);
        }
    }
}
