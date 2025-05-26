using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp
{
    public class _796_RotateString
    {
        public bool RotateString(string s, string goal)
        {
            // s = "abcde", goal = "cdeab"
            // s = "abcde", goal = "abced"
            if (s.Length != goal.Length) return false;
            string doubled = s + s;
            return doubled.Contains(goal);
        }
    }
}
