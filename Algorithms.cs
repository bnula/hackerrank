using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class Algorithms
    {
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            List<int> score = new List<int>();
            int first = 0;
            int second = 0;
            for (int i = 0; i < 3; i++)
            {
                var item = a[i] - b[i];
                if (item > 0) first++;
                else if (item < 0) second++;
            }
            score.Add(first);
            score.Add(second);

            return score;
        }

        public static void Staircase(int n)
        {
            string str = "";
            for (int i = 0; i < n; i++)
            {
                str += " ";
            }
            for (int j = 1; j <= n; j++)
            {
                Console.WriteLine(str.Substring(0, n - j) + new String('#', j));
            }
        }
    }
}
