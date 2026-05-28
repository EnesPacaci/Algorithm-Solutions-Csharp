using System;
using System.Text;

/*
 * Problem: Check Palindrome by Filtering Non-Letters
 * Language: C#
 * Approach: StringBuilder for Cleaning + Two Pointers for Validation
 */
public class Result
{
    public static bool isAlphabeticPalindrome(string code)
    {
        StringBuilder newCode = new StringBuilder();
        for (int i = 0; i < code.Length; i++)
        {
            if (char.IsLetter(code[i]))
            {
                newCode.Append(char.ToLower(code[i]));
            }
        }

        string lastCode = newCode.ToString();
        int left = 0;
        int right = lastCode.Length - 1;

        while (left < right)
        {
            if (lastCode[left] != lastCode[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}