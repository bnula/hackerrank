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
            var max = 0;
            var itt = 0;
            Queue<char> str = new Queue<char>(s);
            StringBuilder checkStr = new StringBuilder();
            StringBuilder bestStr = new StringBuilder();
            for (int i = 0; i < k; i++)
            {
                var chr = str.Dequeue();
                if (vowels.Contains(chr))
                {
                    max++;
                }
                itt++;
                bestStr.Append(chr);
                checkStr.Append(chr);
            }
            for (int i = itt; i < len; i++)
            {
                var sum = max;
                var addChr = str.Dequeue();
                var removeStr = checkStr[0];
                if (vowels.Contains(addChr))
                {
                    sum++;
                } else if (!vowels.Contains(addChr))
                {
                    sum--;
                }
                if (vowels.Contains(removeStr))
                {
                    sum++;
                }
                else
                {
                    sum--;
                }
                if (sum > max)
                {
                    max = sum;
                    bestStr = checkStr;
                }
                checkStr.Remove(0, 1);
                checkStr.Append(addChr);
            }
            return bestStr.ToString();
            
        }
    }
}
