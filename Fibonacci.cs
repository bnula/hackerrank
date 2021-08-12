using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class Fibonacci
    {
        public static int NthElementRec(int n)
        {
            if (n == 0) return 0;
            if (n <= 2) return 1;
            else return NthElementRec(n - 1) + NthElementRec(n - 2);
        }

        public static int NthElement(int n)
        {
            if (n == 0) return 0;
            if (n <= 2) return 1;
            int fib1 = 1;
            int fib2 = 1;
            int temp;
            for (int i = 3; i < n; i++)
            {
                temp = fib1;
                fib1 = fib1 + fib2;
                fib2 = temp;
            }
            return fib1 + fib2;
        }
    }
}
