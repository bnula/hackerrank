using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class Strings
    {
        public static int Gemstones(List<string> arr)
        {
            List<HashSet<char>> set = new List<HashSet<char>>();
            foreach (var str in arr)
            {
                set.Add(str.ToHashSet());
            }
            var d = new Dictionary<char, int>();
            foreach (var item in set)
            {
                foreach (var chr in item)
                {
                    if (!d.ContainsKey(chr)) d.Add(chr, 1);
                    else d[chr]++;
                }
            }
            var gems = 0;
            foreach (var min in d)
            {
                if (min.Value == arr.Count()) gems++;
            }
            return gems;
        }

        public static string PalindromeAnagram(string s)
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (!d.ContainsKey(c)) d.Add(c, 1);
                else d[c]++;
            }
            Dictionary<int, int> charNums = new Dictionary<int, int>();
            foreach (var item in d)
            {
                if (!charNums.ContainsKey(item.Value % 2)) charNums.Add(item.Value % 2, 1);
                else charNums[item.Value % 2]++;
            }
            if (!charNums.ContainsKey(1)) return "YES";
            else if (charNums[1] > 1) return "NO";
            else return "YES";
        }

        public static string SherlockValidString(string s)
        {
            bool correct = false;
            Dictionary<char, int> d = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (!d.ContainsKey(c)) d.Add(c, 1);
                else d[c]++;
            }
            Dictionary<int, int> d2 = new Dictionary<int, int>();
            foreach (var item in d)
            {
                if (!d2.ContainsKey(item.Value)) d2.Add(item.Value, 1);
                else d2[item.Value]++;
            }
            if (d2.Keys.Count() > 2) correct = false;
            if (d2.Keys.Count() == 3 && (d2[d2.Keys.Min()] == 1 && d2.Keys.Min() == 1)) correct = true;
            if (d.Values.Max() - d.Values.Min() != 1) correct = false;
            if (d2[d2.Keys.Max()] > 1) correct = false;
            if (d2[d2.Keys.Min()] == 1 && d2.Keys.Min() == 1) correct = true;
            if (correct) return "YES";
            else return "NO";
        }

        public static int AlternatingCharacters(string s)
        {
            int dels = 0;
            for (int i = 0; i < s.Length - 1; i++)
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
