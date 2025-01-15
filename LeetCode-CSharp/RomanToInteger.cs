namespace LeetCode_CSharp
{
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> romanDict = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };

            int total = 0;
            int prevValue = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                int currentValue = romanDict[s[i]];
                if (currentValue < prevValue)
                {
                    total -= currentValue;
                }
                else
                {
                    total += currentValue;
                }

                prevValue = currentValue;
            }
            return total;
        }
    }
}
