using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int n = int.Parse(sr.ReadLine());
            sw.Write(n-(n*0.22f)+" ");
            sw.Write(n * 0.8f + n * 0.2f - n * 0.2f * 0.22f);
            sw.Flush();