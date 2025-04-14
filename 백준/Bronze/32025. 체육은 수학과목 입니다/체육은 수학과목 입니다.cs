using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int b = int.Parse(sr.ReadLine());
            sw.Write(a > b ? b * 100 / 2 : a * 100 / 2);
            sw.Flush();