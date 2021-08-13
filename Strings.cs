using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class Strings
    {
        public static int MakingAnagrams(string a, string b)
        {
            Dictionary<char, int> dict1 = new Dictionary<char, int>();
            Dictionary<char, int> dict2 = new Dictionary<char, int>();
            int jumps = 0;
            foreach (var item in a)
            {
                if (!dict1.ContainsKey(item))
                {
                    dict1.Add(item, 1);
                }
                else
                {
                    dict1[item]++;
                }
            }
            foreach (var item in b)
            {
                if (!dict2.ContainsKey(item))
                {
                    dict2.Add(item, 1);
                }
                else
                {
                    dict2[item]++;
                }
            }

            if (a.Length > b.Length)
            {
                foreach (var key in dict2)
                {
                    if (dict1.ContainsKey(key.Key))
                    {
                        jumps += Math.Abs(dict1[key.Key] - dict2[key.Key]);
                    }
                    else
                    {
                        jumps += dict2[key.Key];
                    }
                    dict1.Remove(key.Key);
                }
                foreach (var item in dict1)
                {
                    jumps += dict1[item.Key];
                }
            }

            else
            {
                foreach (var key in dict1)
                {
                    if (dict2.ContainsKey(key.Key))
                    {
                        jumps += Math.Abs(dict2[key.Key] - dict1[key.Key]);
                    }
                    else
                    {
                        jumps += dict1[key.Key];
                    }
                    dict2.Remove(key.Key);
                }
                foreach (var item in dict2)
                {
                    jumps += dict2[item.Key];
                }
            }
            return jumps;
        }
    }
}
