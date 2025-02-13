using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] heights = new int[257];
            int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            for (int i = 0; i < arr[0]; i++)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                for (int j = 0; j < arr[1]; j++)
                {
                    heights[input[j]]++;
                }
            }
            int bestTime = int.MaxValue;
            int bestHeight = 0;

            for (int i = 0; i <= 256; i++)
            {
                int breakCount = 0;
                int addCount = 0;
                for (int j = 0; j <= 256; j++)
                {
                    if (j > i)
                        breakCount += (j - i) * heights[j];
                    else if (j < i)
                        addCount += (i - j) * heights[j];
                }
                if (arr[2] + breakCount < addCount)
                    continue;
                int time = breakCount * 2 + addCount;
                if (time < bestTime || (time == bestTime && i > bestHeight))
                {
                    bestTime = time;
                    bestHeight = i;
                }
            }
            sw.Write($"{bestTime} {bestHeight}");
            sw.Flush();