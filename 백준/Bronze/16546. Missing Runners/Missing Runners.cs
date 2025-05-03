using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int sum = a * (a + 1) / 2;
            for (int i = 0; i < arr.Length; i++)
            {
                sum -= arr[i];
            }
            sw.Write(sum);
            sw.Flush();