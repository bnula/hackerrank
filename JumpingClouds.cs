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
            int jumps = 0;
            // add jump for each iteration
            for (int i = 0; i < end-1; i++)
            {
                jumps++;
                // if the 2nd index in front has zero, add increase i and keep the jumps the same
                if (i+2 < end && c[i+2] == 0)
                {
                    i++;
                }
            }
            return jumps;
        }
    }
}
