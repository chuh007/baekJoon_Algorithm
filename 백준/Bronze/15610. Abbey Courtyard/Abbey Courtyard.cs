using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
double a = double.Parse(sr.ReadLine());
            sw.Write(Math.Sqrt(a) * 4);
            sw.Flush();