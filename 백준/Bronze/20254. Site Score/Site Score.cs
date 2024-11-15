using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
            sw.Write(input[0] * 56 + input[1] * 24 + input[2] * 14 + input[3] * 6);
            sw.Flush();