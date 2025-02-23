using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
string a = sr.ReadLine();
            string b = sr.ReadLine();
            int[,] dp = new int[a.Length + 1, b.Length + 1];
            for(int i = 1; i <= a.Length; i++)
            {
                for(int j = 1; j <= b.Length; j++)
                {
                    if (a[i - 1] == b[j - 1]) dp[i, j] = dp[i - 1, j - 1] + 1;
                    else dp[i, j] = dp[i - 1, j] > dp[i, j - 1] ? dp[i - 1, j] : dp[i, j - 1];
                }
            }
            sw.Write(dp[a.Length, b.Length]);
            sw.Flush();