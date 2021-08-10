using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class PasswordDecrypt
    {
        public static string DecryptPassword(string s)
        {
            var end = s.Length;
            StringBuilder pwd = new StringBuilder();
            var intNum = 0;
            for (int i = end-1; i >= 0; i--)
            {
                if (s[i] == '*')
                {
                    pwd.Insert(0, s[i - 2]);
                    pwd.Insert(0, s[i - 1]);
                    i -= 2;
                    continue;
                }
                if (i <= intNum)
                {
                    if (!char.IsDigit(s[i]))
                    {
                        pwd.Insert(0, s[i]);
                    }
                    break;
                }
                else if (char.IsDigit(s[i]))
                {
                    pwd.Insert(0, s[intNum]);
                    intNum++;
                    continue;
                }
                pwd.Insert(0, s[i]);
            }

            return pwd.ToString();
        }
    }
}
