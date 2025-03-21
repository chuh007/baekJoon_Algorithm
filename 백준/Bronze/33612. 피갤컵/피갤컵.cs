using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int n = int.Parse(sr.ReadLine());
            int y = 2024;
            int m = 8;
            int add = 7 * (n - 1);
            m += add;
            y += (m - 1) / 12;
            m = (m - 1) % 12 + 1;

            sw.WriteLine($"{y} {m}");
            sw.Flush();