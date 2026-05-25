using System;
using System.Collections.Generic;

/*
 * Complexity: O(N) Time | O(N) Space
 * Goal: Find the indices of two numbers that add up to a specific target.
 */
public class Result
{
    public static List<int> findTaskPairForSlot(List<int> taskDurations, int slotLength)
    {
        Dictionary<int, int> seenNumbers = new Dictionary<int, int>();

        for (int i = 0; i < taskDurations.Count; i++)
        {
            int complement = slotLength - taskDurations[i];

            if (seenNumbers.ContainsKey(complement))
            {
                return new List<int> { seenNumbers[complement], i };
            }

            if (!seenNumbers.ContainsKey(taskDurations[i]))
            {
                seenNumbers.Add(taskDurations[i], i);
            }
        }

        return new List<int> { -1, -1 };
    }
}