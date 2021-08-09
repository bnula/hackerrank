using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class JumpingClouds
    {
        public static int NumOfJumps(List<int> c)
        {
            var end = c.Count();
            bool skip = false;
            int jumps = 0;
            for (int i = 0; i < end-1; i++)
            {
                if (skip)
                {
                    skip = false;
                    continue;
                }
                if (i != end - 2)
                {
                    if (c[i + 2] == 0)
                    {
                        jumps++;
                        skip = true;
                        continue;
                    }
                }
                if (c[i+1] == 0)
                {
                    jumps++;
                    continue;
                }
            }
            return jumps;
        }
    }
}
