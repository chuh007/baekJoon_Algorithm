using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput())); 
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int N = input[0];
            int k = input[1];
            int count = 0;
            int[] coins = new int[N];
            for(int i = 0; i < N; i++)
            {
                coins[i] = int.Parse(sr.ReadLine());
            }
            for(int i = N - 1; i >= 0; i--)
            {
                while (k >= coins[i])
                {
                    k -= coins[i];
                    count++;
                }
            }
            sw.WriteLine(count);
            sw.Flush();