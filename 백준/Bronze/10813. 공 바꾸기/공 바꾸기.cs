using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] NM = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int n = NM[0];
            int m = NM[1];
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }
            for (int i = 0; i < m; i++)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int temp = arr[input[0]-1];
                arr[input[0]-1] = arr[input[1]-1];
                arr[input[1]-1] = temp;
            }
            foreach (int item in arr)
            {
                sw.Write($"{item} ");
            }
            sw.Flush();