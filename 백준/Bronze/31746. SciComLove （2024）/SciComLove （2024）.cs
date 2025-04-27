using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            if (a % 2 == 0) sw.Write("SciComLove");
            else sw.Write("evoLmoCicS");
            sw.Flush();