using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int commandsCount = commands.GetLength(0);
        int[] result = new int[commandsCount];

        for (int i = 0; i < commandsCount; i++ )
        {
            int cutstart = commands[i, 0];
            int cutend = commands[i, 1];
            int findIndex = commands[i, 2] - 1;

            List<int> tempNums = GetCuttedTempNums(cutstart, cutend, array);
            int[] sortedNums = GetSortedTmpNums(tempNums);
            result[i] = sortedNums[findIndex];
        }
        
        return result;
    }
    
    private static List<int> GetCuttedTempNums(int cutstart, int cutend, int[]nums)
    {
        List<int> temp = new List<int>();

        for (int i = cutstart - 1; i < cutend; i++)
        {
            temp.Add(nums[i]);
        }
        return temp;
    }

    private static int[] GetSortedTmpNums(List<int> tempNums)
    {
        for (int i = 0; i < tempNums.Count; i++)
        {
            for (int j = 0; j < tempNums.Count - 1 - i; j++)
            {
                if (tempNums[j] > tempNums[j + 1])
                {
                    int temporary = tempNums[j];
                    tempNums[j] = tempNums[j + 1];
                    tempNums[j + 1] = temporary;
                }
            }
        }

        return tempNums.ToArray();
    }
}