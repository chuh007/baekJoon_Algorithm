using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
while (true)
            {
                int n = int.Parse(sr.ReadLine());
                if (n == 0) break;
                int answer = n * (n + 1) / 2;
                sw.WriteLine(answer);
            }
            sw.Flush();