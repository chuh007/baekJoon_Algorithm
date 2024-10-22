using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
float n = float.Parse(sr.ReadLine());
            sw.WriteLine((int)n);
            sw.Flush();