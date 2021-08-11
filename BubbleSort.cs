using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class BubbleSort
    {
        public static void CountSwaps(List<int> a)
        {
            int temp;
            int swaps = 0;
            for (int i = 0; i < a.Count; i++)
            {

                for (int j = 0; j < a.Count - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j+1] = temp;
                        swaps++;
                    }
                }

            }
            Console.WriteLine($"Array is sorted in {swaps} swaps.");
            Console.WriteLine($"First Element: {a[0]}");
            Console.WriteLine($"Last Element: {a[a.Count-1]}");
        }
    }
}
