using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
float a = float.Parse(sr.ReadLine());
            sw.Write(a / 4);
            sw.Flush();