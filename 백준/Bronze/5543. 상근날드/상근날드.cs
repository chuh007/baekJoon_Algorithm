using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int b = int.Parse(sr.ReadLine());
            int c = int.Parse(sr.ReadLine());
            int d = int.Parse(sr.ReadLine());
            int e = int.Parse(sr.ReadLine());
            sw.WriteLine((a > b ? b > c ? c : b : a > c ? c : a) + (d > e ? e : d) - 50);
            sw.Flush();