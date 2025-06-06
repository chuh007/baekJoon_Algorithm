using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            sw.WriteLine(5 * a - 400);
            sw.WriteLine(a < 100 ? 1 : a == 100 ? 0 : -1);
            sw.Flush();