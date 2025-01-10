using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int minCost = int.MaxValue;
            for (int i = 0; i < input[0] - 1; i++)
            {
                int cost = arr[i] * input[1] + arr[i + 1] * input[1];
                if (cost < minCost)
                {
                    minCost = cost;
                }
            }
            sw.Write(minCost);
            sw.Flush();