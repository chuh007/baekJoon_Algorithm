using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int a = int.Parse(sr.ReadLine());
            int b = int.Parse(sr.ReadLine());
            if (a == 1 || b == 1) sw.Write(a * b);
            else sw.Write(a * 2 + b * 2 - 4);
            sw.Flush();