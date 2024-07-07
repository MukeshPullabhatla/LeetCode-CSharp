using System;

public class TwoSum
{
	public int[] FindTwoSum(int[] nums, int target)
	{
		for (int i = 0; i < nums.Length; i++)
		{
			for (int j = i + 1; j < nums.Length; j++)
			{
				if (nums[i] + nums[j] == target)
				{
					return new int[] { i, j };
				}
			}
		}
		return new int[] { };
	}
	public static void Main()
	{
		int[] nums = { 2, 7, 11, 15 };
		int target = 9;
		TwoSum twoSum = new TwoSum();
		int[] result = twoSum.FindTwoSum(nums, target);
		Console.WriteLine($"[{result[0]}, {result[1]}]");
	}
}
