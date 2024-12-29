namespace LeetCode_CSharp
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            // input x = 121, x = -121, x = 10
            if (x < 0) return false;
            var original = x;
            var reversed = 0;
            while (x != 0)
            {
                int digit = x % 10;
                reversed = reversed * 10 + digit;
                x = x / 10;
            }
            return reversed == original;
        }
    }
}
