using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int[] wv = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            if (a <= wv[0] / wv[1]) sw.Write(1);
            else sw.Write(0);
            sw.Flush();