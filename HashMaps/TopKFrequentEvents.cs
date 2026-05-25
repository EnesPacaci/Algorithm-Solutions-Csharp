using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Problem: Top K Frequent Events with Order Preservation
 * Language: C#
 * Approach: Dictionary + Tuple + LINQ Sorting
 */
public class Result
{
    public static List<int> getTopKFrequentEvents(List<int> events, int k)
    {
        if (events.Count == 0)
        {
            return new List<int> {};
        }

        Dictionary<int, (int frequency, int firstIndex)> numberStats = new Dictionary<int, (int frequency, int firstIndex)>();

        for (int i = 0; i < events.Count; i++)
        {
            if (numberStats.ContainsKey(events[i]))
            {
                var current = numberStats[events[i]];
                numberStats[events[i]] = (current.frequency + 1, current.firstIndex);
            }
            else
            {
                numberStats.Add(events[i], (1, i));
            }
        }

        return numberStats.ToList()
            .OrderByDescending(x => x.Value.frequency)
            .ThenBy(x => x.Value.firstIndex)
            .Take(k)
            .Select(x => x.Key)
            .ToList();
    }
}