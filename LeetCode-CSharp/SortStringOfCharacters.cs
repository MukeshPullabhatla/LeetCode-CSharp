using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp
{
    public class SortStringOfCharacters
    {
        public string SortString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Sort(arr);
            s = new string(arr);
            return s;
        }
    }
}
