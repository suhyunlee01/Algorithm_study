namespace ConsoleApp8
{
        class Program
        {
            static void Main(string[] args)
            {
                int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int treeNum = inputs[0];
                int treeLength = inputs[1];

                int[] trees = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                long endLenFinal = GetEndLen(trees, treeNum, treeLength);

                Console.WriteLine(endLenFinal);
            }

            private static long GetEndLen(int[] items, int itemNum, int needNum)
            {
                long midLen = 0;
                long startLen = 0;
                long endLen = items.Max();

                while (startLen <= endLen)
                {

                    midLen = (startLen + endLen) / 2;

                    long minusLen = 0;

                    for (int i = 0; i < itemNum; i++)
                    {
                        if (items[i] < midLen)
                            continue;

                        minusLen += items[i] - midLen;
                    }

                    if (minusLen >= needNum)
                    {
                        startLen = midLen + 1;
                    }
                    else
                    {
                        endLen = midLen - 1;
                    }
                }
                return endLen;
            }
        }
}