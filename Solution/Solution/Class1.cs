namespace Solution;

public class Class1
{
    public string LongestPalindrome(string s)
    {
        int maxLength = 0;
        var maxLengthStr= new ReadOnlySpan<char>();

        for (int i = 0; i < s.Length; ++i)
        {
            int left = i; int right = i;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                if (right - left + 1 > maxLength)
                {
                    maxLength = right - left + 1;
                    maxLengthStr = s.AsSpan(left, maxLength);
                }
                --left;
                ++right;
            }
            left = i; 
            right = i+1;
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                if (right - left + 1 > maxLength)
                {
                    maxLength = right - left + 1;
                    maxLengthStr = s.AsSpan(left, maxLength);
                }
                left--;
                right++;
            }
        }
        return maxLengthStr.ToString();
    }
}