using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int b = int.Parse(sr.ReadLine());
            int c = int.Parse(sr.ReadLine());
            int d = int.Parse(sr.ReadLine());
            if ((a == 8 || a == 9) && (d == 8 || d == 9) && b == c) sw.Write("ignore");
            else sw.Write("answer");
            sw.Flush();