using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
int b = int.Parse(sr.ReadLine());
sw.Write(a * 1000 + b * 10000);
sw.Flush();