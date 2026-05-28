using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Problem: Max Unique Substring Length in a Session
 * Language: C#
 * Approach: Sliding Window + Dictionary for optimal index tracking
 */
public class Result
{
    public static int maxDistinctSubstringLengthInSessions(string sessionString)
    {
        if (string.IsNullOrEmpty(sessionString) || sessionString.All(c => c == '*'))
        {
            return 0;
        }

        int left = 0;
        int maxLength = 0;
        Dictionary<char, int> newSessionString = new Dictionary<char, int>();

        for (int right = 0; right < sessionString.Length; right++)
        {
            char currentChar = sessionString[right];

            if (currentChar == '*')
            {
                newSessionString.Clear();
                left = right + 1;
            }
            else
            {
                if (newSessionString.ContainsKey(currentChar) && newSessionString[currentChar] >= left)
                {
                    left = newSessionString[currentChar] + 1;
                }

                newSessionString[currentChar] = right;
                maxLength = Math.Max(maxLength, right - left + 1);
            }
        }

        return maxLength;
    }
}