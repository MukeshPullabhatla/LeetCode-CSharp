namespace LeetCode_CSharp
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numDict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (numDict.ContainsKey(diff))
                {
                    return new int[] { numDict[diff], i };
                }
                if (!numDict.ContainsKey(nums[i]))
                    numDict.Add(nums[i], i);
            }
            throw new ArgumentException("No two sum solution");
        }
    }
}