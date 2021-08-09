using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class ArrayHourglass
    {
        public static int HighestSum(List<List<int>> arr)
        {
            int max = int.MinValue;
            var sum = 0;
            int row;
            var colStop = 2;
            var colStart = 0;
            var hglevel = 0;
            var hg = 0;
            while (true)
            {
                row = hg + hglevel;
                if (hglevel == 1)
                {
                    colStart++;
                    colStop--;
                }
                for (int col = colStart; col <= colStop; col++)
                {
                    sum += arr[row][col];
                    //Console.WriteLine(arr[row][col]);
                }
                if (hglevel == 1)
                {
                    colStart--;
                    colStop++;
                }
                else if (hg == 3 && hglevel == 2 && colStop == 5)
                {
                    Console.WriteLine($"sum - {sum}");
                    if (sum > max) max = sum;
                    return max;
                }
                else if (hg == 3 && hglevel == 2)
                {
                    Console.WriteLine($"sum - {sum}");
                    Console.WriteLine("=========");
                    hg = 0;
                    hglevel = -1;
                    colStart++;
                    colStop++;
                    if (sum > max) max = sum;
                    sum = 0;
                }
                else if (hglevel == 2)
                {
                    Console.WriteLine($"sum - {sum}");
                    Console.WriteLine("=========");
                    hg++;
                    hglevel = -1;
                    if (sum > max) max = sum;
                    sum = 0;
                }
                hglevel++;
            }
        }
    }
}
