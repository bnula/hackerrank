using System;
using System.Collections.Generic;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "aba";
            var num = RepeatedString.NumOfAs(str, 10);
            Console.WriteLine(num);
        }
    }
}
