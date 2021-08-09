using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class RepeatedString
    {
        public static long NumOfAs(string s, long n)
        {
            long times = 0;
            var repeats = n / s.Length;
            foreach (var ch in s)
            {
                if (ch == 'a')
                {
                    times++;
                }
            }
            times *= repeats;
            var rest = n % s.Length;
            foreach (var ch in s.Substring(0, (int)rest))
            {
                if (ch == 'a')
                {
                    times++;
                }
            }
            return times;
        }
    }
}
