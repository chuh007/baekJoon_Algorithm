using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int b = int.Parse(sr.ReadLine());
            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            sw.Write(a > input.Sum() ? "Padaeng_i Cry" : "Padaeng_i Happy");
            sw.Flush();