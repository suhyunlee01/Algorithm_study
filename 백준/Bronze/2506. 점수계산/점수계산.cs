using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split(' ');

            if (arr.Length == 0)
                return;
            
            int totalScore = GetScore(num, arr);

            Console.WriteLine(totalScore);
        }

        static private int GetScore(int num, string[]arr)
        {
            int score = 0;
            int plusScore = 0;

            for (int i = 0; i < num; i++)
            {
                if (int.Parse(arr[i]) == 0)
                {
                    plusScore = 0;
                    continue;
                }

                plusScore++;
                score = score + plusScore;
            }

            return score;
        }
    }
}
