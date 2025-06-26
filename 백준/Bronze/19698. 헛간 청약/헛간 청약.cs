using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int w = input[1] / input[3];
            int h = input[2] / input[3];
            sw.WriteLine(input[0] < w * h ? input[0] : w * h);
            sw.Flush();