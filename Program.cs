using System;
using System.Collections.Generic;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 1, 12, 5, 111, 200, 1000, 10 };
            Console.WriteLine(MarkAndToys.MaximumToysReverseBubble(arr, 50));
        }
    }
}
