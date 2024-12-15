namespace LeetCode_CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // TwoSum
            TwoSumSolution solution = new TwoSumSolution();
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = solution.TwoSum(nums, target);
            Console.WriteLine("[" + result[0] + ", " + result[1] + "]");
        }
    }
}