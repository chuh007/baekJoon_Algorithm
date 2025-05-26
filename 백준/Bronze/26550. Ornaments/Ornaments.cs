using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
long n = long.Parse(sr.ReadLine());
            for(int i = 0; i < n; i++)
            {
                long a = long.Parse(sr.ReadLine());
                sw.WriteLine(a * (a + 1) * (a + 2) / 6);
            }
            sw.Flush();