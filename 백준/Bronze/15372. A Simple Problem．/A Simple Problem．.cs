using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
long a = long.Parse(sr.ReadLine());
            for(int i = 0; i < a; i++)
            {
                long b = (long)Math.Pow(long.Parse(sr.ReadLine()), 2);
                sw.WriteLine(b);
            }
            sw.Flush();