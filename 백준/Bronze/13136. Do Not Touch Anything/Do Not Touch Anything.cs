using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
long[] arr = Array.ConvertAll(sr.ReadLine().Split(), long.Parse);
            long r = arr[0], c = arr[1], n = arr[2];
            long row = (r + n - 1) / n;
            long col = (c + n - 1) / n;
            sw.WriteLine(row * col);
            sw.Flush();