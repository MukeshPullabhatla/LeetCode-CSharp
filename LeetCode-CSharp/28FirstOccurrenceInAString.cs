namespace LeetCode_CSharp
{
    public class _28FirstOccurrenceInAString
    {
        public int StrStr(string haystack, string needle)
        {
            // Knuth-Morris-Pratt(KMP) Algorithm
            if (string.IsNullOrEmpty(needle)) return 0;
            int haystackLength = haystack.Length;
            int needleLength = needle.Length;
            int[] lps = ComputeLPSArray(needle);
            int i = 0;
            int j = 0;
            while (i < haystackLength)
            {
                if (haystack[i] == needle[j])
                {
                    i++;
                    j++;
                    if (j == needleLength)
                    {
                        return i - needleLength;
                    }
                }
                else
                {
                    if (j != 0)
                    {
                        j = lps[j - 1];
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            return -1;
        }

        private int[] ComputeLPSArray(string needle)
        {
            int length = 0;
            int[] lps = new int[needle.Length];
            lps[0] = 0;
            int i = 1;
            while (i < needle.Length)
            {
                if (needle[i] == needle[length])
                {
                    length++;
                    lps[i] = length;
                    i++;
                }
                else
                {
                    if (length != 0)
                    {
                        length = lps[length - 1];
                    }
                    else
                    {
                        lps[i] = 0;
                        i++;
                    }
                }
            }
            return lps;
        }
    }
    // Easy Solution
    //public class _28FirstOccurrenceInAString
    //{
    //    public int StrStr(string haystack, string needle)
    //    {
    //        if (string.IsNullOrEmpty(needle)) return 0;
    //        return haystack.IndexOf(needle);
    //    }
    //}
}
