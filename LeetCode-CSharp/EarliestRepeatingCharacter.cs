using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp
{
    public class EarliestRepeatingCharacter
    {
        public string FirstRepChar(string s)
        {
            int n = s.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (s[i] == s[j])
                    {
                        return s[i].ToString();
                    }
                }
            }
            return "-1";
        }
    }
}
