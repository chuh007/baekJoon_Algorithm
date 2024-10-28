using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int R = int.Parse(sr.ReadLine());
            int S = int.Parse(sr.ReadLine());
            sw.Write(R * 8 + S * 3 - 28);
            sw.Flush();