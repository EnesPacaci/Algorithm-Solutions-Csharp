using System;
using System.Collections.Generic;

/*
 * Complexity: O(N) Time | O(1) Space
 * Goal: Count elements greater than the average of preceding elements.
 */
public class Result
{
    public static int countResponseTimeRegressions(List<int> responseTimes)
    {
        if (responseTimes.Count <= 1) return 0;

        int count = 0;
        double sum = responseTimes[0];

        for (int index = 1; index < responseTimes.Count; index++)
        {
            if (responseTimes[index] > (sum / index))
                count++;
            
            sum += responseTimes[index];
        }

        return count;
    }
}