using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class CountingValleys
    {
        public static int cntValleys(int steps, string path)
        {
            var level = 0;
            int valNum = 0;
            foreach (var item in path)
            {
                if (item == 'U')
                {
                    level++;
                }
                else
                {
                    level--;
                }
                if (level == 0 && item == 'U')
                {
                    valNum++;
                }
            }
            return valNum;
        }
    }
}
