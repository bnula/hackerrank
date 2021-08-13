using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class Strings
    {
        public static int AlternatingCharacters(string s)
        {
            int dels = 0;
            for (int i = 0; i < s.Length-1; i++)
            {
                if (s[i] == s[i + 1]) dels++;
            }
            return dels;
        }

        public static int MakingAnagrams(string a, string b)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int jumps = 0;
            foreach (var item in a)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, 1);
                }
                else
                {
                    dict[item]++;
                }
            }
            foreach (var item in b)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, -1);
                }
                else
                {
                    dict[item]--;
                }
            }
            foreach (var item in dict)
            {
                jumps += Math.Abs(item.Value);
            }
            return jumps;
        }
    }
}
