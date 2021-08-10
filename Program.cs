using System;
using System.Collections.Generic;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 1, 2, 3, 4, 5 };
            var l = ArrayRotation.RotateLeftRecur(arr, 1);
            foreach (var item in l)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
