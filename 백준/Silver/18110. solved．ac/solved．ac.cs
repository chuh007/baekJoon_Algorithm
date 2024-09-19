using System.IO;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int n = int.Parse(sr.ReadLine());
            if (n == 0) sw.WriteLine(0);
            else
            {
                int[] arr = new int[n];
                for(int i = 0; i < n; i++)
                {
                    arr[i] = (int.Parse(sr.ReadLine()));
                }
                Array.Sort(arr);
                int killCount = (int)Math.Round(n*0.15,MidpointRounding.AwayFromZero);
                int killAfterarrCount = n - (2 * killCount);
                int sum = 0;
                for (int i = killCount; i < n - killCount; i++)
                {
                    sum += arr[i];
                }
                sw.WriteLine((int)Math.Round((double)sum / killAfterarrCount, MidpointRounding.AwayFromZero));
            }
            sw.Flush();