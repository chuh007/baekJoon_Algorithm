using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int costX = (input[0] + input[1] - 1) / input[1] * input[2];
            int costY = (input[0] + input[3] - 1) / input[3] * input[4];
            sw.Write(costX > costY ? costY : costX);
            sw.Flush();