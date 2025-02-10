using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int[] dp = new int[50001];
            dp[1] = 1;
            dp[2] = 2;
            dp[3] = 3;
            dp[4] = 1;
            for(int i = 5; i < 50001; i++)
            {
                double sqrt = Math.Sqrt(i);
                if (sqrt == (int)sqrt)
                {
                    dp[i] = 1;
                    continue;
                }
                dp[i] = dp[i - 1] + 1;
                for (int j = 2; j*j < i; j++)
                {
                    dp[i] = Math.Min(dp[i], dp[i - j * j] + 1);
                }
            }
            sw.Write(dp[a]);
            sw.Flush();