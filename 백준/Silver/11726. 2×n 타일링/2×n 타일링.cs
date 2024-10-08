using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] arr = new int[1001];
            arr[0] = 1;
            arr[1] = 1;
            for(int i = 2; i < 1001; i++)
            {
                arr[i] = (arr[i - 1] + arr[i - 2]) % 10007;
            }
            int n = int.Parse(sr.ReadLine());
            sw.Write(arr[n] % 10007);
            sw.Flush();