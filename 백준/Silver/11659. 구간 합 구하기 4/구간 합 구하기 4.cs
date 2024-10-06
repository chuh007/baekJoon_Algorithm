using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int n = input[0];
            int m = input[1];
            int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] arr2 = new int[n+1];
            for(int i = 1; i <= n; i++)
            {
                arr2[i] = arr2[i - 1] + arr[i-1];
            }
            for (int i = 0;i < m; i++)
            {
                int[] ij = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                sw.WriteLine(arr2[ij[1]] - arr2[ij[0] - 1]);
            }
            sw.Flush();