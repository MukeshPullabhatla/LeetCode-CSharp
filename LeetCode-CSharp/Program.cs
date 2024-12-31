using static LeetCode_CSharp.AddTwoNumbersSolution;

namespace LeetCode_CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Two Sum
            TwoSumSolution solution = new TwoSumSolution();
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = solution.TwoSum(nums, target);
            Console.WriteLine("[" + result[0] + ", " + result[1] + "]");

            // Add Two Numbers
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            AddTwoNumbersSolution aTNSolution = new AddTwoNumbersSolution();
            ListNode res = aTNSolution.AddTwoNumbers(l1, l2);

            if (res != null)
            {
                while (res != null)
                {
                    Console.Write(res.val);
                    res = res.next;
                    if (res != null) Console.Write(" -> ");
                }
            }
            else
            {
                Console.WriteLine("Result is null");
            }

            // Palindrome Number
            var resPalindromeNumber = new PalindromeNumber();
            var x = -121;
            Console.WriteLine();
            Console.WriteLine(resPalindromeNumber.IsPalindrome((x)));

            // Roman To Integer
            RomanToInteger romanToInt = new RomanToInteger();
            Console.WriteLine(romanToInt.RomanToInt("III"));
            Console.WriteLine(romanToInt.RomanToInt("LVIII"));
            Console.WriteLine(romanToInt.RomanToInt("MCMXCIV"));
        }
    }
}