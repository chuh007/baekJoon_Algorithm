using System.IO;

StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int a = int.Parse(sr.ReadLine());
sw.WriteLine(a / 5);
sw.Flush();