using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[,] dp = new int[arr[0] + 1, arr[1] + 1];
            int[] w = new int[arr[0]];
            int[] v = new int[arr[0]];
            for (int i = 0; i < arr[0]; i++)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                w[i] = input[0];
                v[i] = input[1];
            }
            for (int i = 1; i <= arr[0]; i++)
            {
                for(int j = 1; j <= arr[1]; j++)
                {
                    if (w[i - 1] <= j) dp[i, j] = Math.Max(dp[i - 1, j], dp[i - 1, j - w[i - 1]] + v[i - 1]);
                    else dp[i, j] = dp[i - 1, j];
                }
            }
            sw.Write(dp[arr[0], arr[1]]);
            sw.Flush();