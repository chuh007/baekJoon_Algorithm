using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int B=int.Parse(sr.ReadLine());
            sw.Write(B/11*10);
            sw.Flush();