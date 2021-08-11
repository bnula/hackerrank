using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class MarkAndToys
    {
        public static int MaximumToysSortMethod(List<int> prices, int k)
        {
            int num = 0;
            prices.Sort();
            foreach (var item in prices)
            {
                k = k - item;
                if (k >= 0)
                {
                    num++;
                }
                else
                {
                    break;
                }
            }
            return num;
        }

        // too slow with big data sets
        public static int MaximumToysReverseBubble(List<int> prices, int k)
        {
            int temp;
            var num = 0;
            for (int i = 0; i < prices.Count(); i++)
            {
                for (int j = 0; j < prices.Count() - 1; j++)
                {
                    if (prices[j] < prices[j + 1])
                    {
                        temp = prices[j];
                        prices[j] = prices[j + 1];
                        prices[j + 1] = temp;
                    }
                }
                k -= prices[prices.Count() - 1 - i];
                if (k >= 0)
                {
                    num++;
                }
                else
                {
                    break;
                }
            }
            foreach (var item in prices)
            {
                Console.Write($"{item} ");
            }
            return num;
        }
    }
}
