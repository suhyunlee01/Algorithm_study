using System;

public class Solution {
    public long solution(int n, int[] times) {
        
        long answer = BinaryforSolution(n, times);
        return answer;
    }
    
    public long BinaryforSolution(int n, int[] times)
    {
        Array.Sort(times);
        long start = 1;
        long end = (long)times[times.Length -1] * n;
        long result = 0;

        while (start <= end)
        {
            long pivot = (start + end) / 2;
            long sum = 0;

            for (int i = 0; i < times.Length; i++)
            {
                sum += (pivot / times[i]);
            }

            if (sum < n)
            {
                start = pivot + 1;
            }
            else
            {
                result = pivot;
                end = pivot - 1;
            }
        }

        return result;
    }
}