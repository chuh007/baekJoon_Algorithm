using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            sw.Write((input[0] + 1) * (input[1] + 1) / (input[2] + 1) - 1);
            sw.Flush();