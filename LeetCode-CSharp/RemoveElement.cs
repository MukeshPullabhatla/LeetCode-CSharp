using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CSharp
{
    public class RemoveElement
    {
        public int RemoveElements(int[] nums, int val)
        {
            if (nums.Length == 0) return 0;
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!nums[i].Equals(val))
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}
