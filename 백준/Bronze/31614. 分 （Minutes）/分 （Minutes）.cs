using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int H = int.Parse(sr.ReadLine());
            int M = int.Parse(sr.ReadLine());
            sw.Write(H * 60 + M);
            sw.Flush();