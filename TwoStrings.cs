using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class TwoStrings
    {
        public static string ShareSubstring(string s1, string s2)
        {
            var set1 = s1.ToHashSet();
            var set2 = s2.ToHashSet();
            foreach (var item in set1)
            {
                if (set2.Contains(item)) return "YES";
            }
            foreach (var item in set2)
            {
                if (set1.Contains(item)) return"YES";
            }

            return "NO";
        }
    }
}
