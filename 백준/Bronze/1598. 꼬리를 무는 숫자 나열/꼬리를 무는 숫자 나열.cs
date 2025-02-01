using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] a = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            sw.WriteLine(Math.Abs((a[0] - 1) / 4 - (a[1] - 1) / 4) + Math.Abs((a[0] - 1) % 4 - (a[1] - 1) % 4));
            sw.Flush();