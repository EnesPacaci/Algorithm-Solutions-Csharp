using System;
using System.Collections.Generic;

/*
 * Problem: Validate Properly Nested Brackets
 * Language: C#
 * Approach: Stack (LIFO) + Dictionary for mapping
 */
public class Result
{
    public static bool areBracketsProperlyMatched(string code_snippet)
    {
        Dictionary<char, char> bracketPairs = new Dictionary<char, char>
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

        Stack<char> openBrackets = new Stack<char>();

        for (int i = 0; i < code_snippet.Length; i++)
        {
            char currentChar = code_snippet[i];

            if (bracketPairs.ContainsKey(currentChar))
            {
                if (openBrackets.Count == 0) return false;
                char lastOpened = openBrackets.Pop();
                if (lastOpened != bracketPairs[currentChar]) return false;
            }
            else if (bracketPairs.ContainsValue(currentChar))
            {
                openBrackets.Push(currentChar);
            }
        }

        return openBrackets.Count == 0;
    }
}