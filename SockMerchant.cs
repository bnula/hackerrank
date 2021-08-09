using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class SockMerchant
    {
        public static int sockMerchant(int n, List<int> arr)
        {
            var dict = new Dictionary<int, int>();
            int pairs = 0;
            foreach (var item in arr)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, 1);
                }
                else
                {
                    pairs++;
                    dict.Remove(item);
                }
            }
            return pairs;
        }
    }
}
