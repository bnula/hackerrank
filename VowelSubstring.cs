using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class VowelSubstring
    {
        public static string FindSubstring(string s, int k)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            var len = s.Length;
            int sum;
            int max = 0;
            string topString = "";
            for (int i = 0; i <= len - k; i++)
            {
                var sub = s.Substring(i, k);
                sum = 0;
                foreach (var item in sub)
                {
                    if (vowels.Contains(item))
                    {
                        sum++;
                    }
                }
                if (sum > max)
                {
                    max = sum;
                    topString = sub;
                }
            }
            if (max == 0) topString = "Not found!";
            return topString;
        }
    }
}
