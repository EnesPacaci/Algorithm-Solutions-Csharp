using System;
using System.Collections.Generic;

/*
 * Complexity: O(N log N) Time | O(N) Space
 * Goal: Merge overlapping intervals and return sorted results.
 */
public class Result
{
    public static List<List<int>> mergeHighDefinitionIntervals(List<List<int>> intervals)
    {
        if (intervals.Count <= 1) return intervals;

        intervals.Sort((a, b) => a[0].CompareTo(b[0]));

        List<List<int>> mergedIntervals = new List<List<int>>();
        mergedIntervals.Add(intervals[0]);

        for (int i = 1; i < intervals.Count; i++)
        {
            List<int> current = intervals[i];
            List<int> lastMerged = mergedIntervals[mergedIntervals.Count - 1];

            if (current[0] <= lastMerged[1])
            {
                lastMerged[1] = Math.Max(lastMerged[1], current[1]);
            }
            else
            {
                mergedIntervals.Add(current);
            }
        }

        return mergedIntervals;
    }
}