using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int n = int.Parse(sr.ReadLine());
            int[] arr = new int[n];
            int[] dp = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(sr.ReadLine());
            }
            int answer = 0;
            if (n < 3)
            {
                foreach (int item in arr)
                {
                    answer += item;
                }
                sw.Write(answer);
            }
            else
            {
                dp[0] = arr[0];
                dp[1] = arr[0] + arr[1];
                dp[2] = Math.Max(arr[0] + arr[2], arr[1] + arr[2]);
                for (int i = 3; i < n; i++)
                {
                    dp[i] = Math.Max(arr[i] + dp[i - 2], arr[i] + arr[i - 1] + dp[i - 3]);
                }
                sw.Write(dp[n - 1]); 
            }
            sw.Flush();