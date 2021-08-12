using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class RansomNote
    {
        public static void CheckMagazine(List<string> magazine, List<string> note)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var item in magazine)
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
            foreach (var item in note)
            {
                if (!dict.ContainsKey(item))
                {
                    Console.WriteLine("No");
                    return;
                }
                else if (dict[item] > 1)
                {
                    dict[item]--;
                }
                else
                {
                    dict.Remove(item);
                }
            }
            Console.WriteLine("Yes");
        }
    }
}
