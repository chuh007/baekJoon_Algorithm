using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int[] dp = new int[1000];
            dp[0] = 1;
            dp[1] = 3;
            for(int i = 2; i < a; i++)
            {
                dp[i] = (dp[i - 1] + dp[i - 2] * 2) % 10007;
            }
            sw.Write(dp[a - 1]);
            sw.Flush();