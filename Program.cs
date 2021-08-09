using System;
using System.Collections.Generic;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new List<int> { 0, 0, 0, 1, 0, 0 };
            var jumps = JumpingClouds.NumOfJumps(c);
            Console.WriteLine(jumps);
        }
    }
}
