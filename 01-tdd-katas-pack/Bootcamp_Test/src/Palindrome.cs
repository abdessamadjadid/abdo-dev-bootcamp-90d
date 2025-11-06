using System;

public class Palindrome
{
    public bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
            return false;

        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
}
