using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int b = int.Parse(sr.ReadLine());
            if (a < b)
            {
                sw.Write(b - a);
            }
            else
            {
                sw.Write(24 - a + b);
            }
            sw.Flush();