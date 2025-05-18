using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int a = int.Parse(sr.ReadLine());
            int b = int.Parse(sr.ReadLine());
            if (a <= 60 + b) sw.WriteLine(a * 1500);
            else if (a - b <= 60) sw.WriteLine((a - b) * 1500);
            else sw.WriteLine((a - b - 60) * 3000 + (60 + b) * 1500);
            sw.Flush();