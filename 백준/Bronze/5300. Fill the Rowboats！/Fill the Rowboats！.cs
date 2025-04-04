using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            for(int i = 1; i <= a; i++)
            {
                sw.Write($"{i} ");
                if (i % 6 == 0) sw.Write("Go! ");
            }
            if (a % 6 != 0) sw.Write("Go!");
            sw.Flush();