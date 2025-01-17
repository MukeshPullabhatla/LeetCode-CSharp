﻿using static LeetCode_CSharp.AddTwoNumbersSolution;

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

            // Longest Common Prefix
            LongestCommonPrefix longestCommonPrefix = new LongestCommonPrefix();
            string[] strs = ["flower", "flow", "flight"];
            string[] strs1 = ["dog", "racecar", "car"];
            Console.WriteLine(longestCommonPrefix.LongestCommonPre(strs));
            Console.WriteLine(longestCommonPrefix.LongestCommonPre(strs1));

            // Valid Parentheses
            ValidParentheses isValid = new ValidParentheses();
            var s = "()";
            var s1 = "()[]{}";
            var s2 = "(]";
            var s3 = "([])";
            Console.WriteLine(isValid.IsValid(s));
            Console.WriteLine(isValid.IsValid(s1));
            Console.WriteLine(isValid.IsValid(s2));
            Console.WriteLine(isValid.IsValid(s3));

            // Merge Two Sorted List
            MergeTwoSortedList.ListNode list1 = new MergeTwoSortedList.ListNode(1, new MergeTwoSortedList.ListNode(2, new MergeTwoSortedList.ListNode(4)));
            MergeTwoSortedList.ListNode list2 = new MergeTwoSortedList.ListNode(1, new MergeTwoSortedList.ListNode(3, new MergeTwoSortedList.ListNode(4)));

            MergeTwoSortedList mergeTwoSortedList = new MergeTwoSortedList();
            MergeTwoSortedList.ListNode mergedList = mergeTwoSortedList.MergeTwoLists(list1, list2);
            while (mergedList != null)
            {
                Console.WriteLine(mergedList.val + " ");
                mergedList = mergedList.next;
            }

            // Remove Duplicates From Sorted Array
            RemoveDuplicatesFromSortedArray removeDuplicates = new RemoveDuplicatesFromSortedArray();
            var nums1 = new int[]{ 1, 1, 2 };
            var nums2 = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Console.WriteLine(removeDuplicates.RemoveDuplicates(nums1));
            Console.WriteLine(removeDuplicates.RemoveDuplicates(nums2));
        }
    }
}