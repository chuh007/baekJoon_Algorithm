using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int count = 0;
            while (a > 0)
            {
                count += a & 1;
                a >>= 1;
            }
            sw.Write(count);
            sw.Flush();