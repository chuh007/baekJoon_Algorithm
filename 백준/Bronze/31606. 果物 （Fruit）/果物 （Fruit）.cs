using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int x = int.Parse(sr.ReadLine());
            int y = int.Parse(sr.ReadLine());
            sw.Write(x + y + 3);
            sw.Flush();