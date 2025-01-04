using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            if (input[0] < input[1] || (input[0] + input[1]) % 2 != 0) sw.Write(-1);
            else sw.Write($"{(input[0] + input[1]) / 2} {input[0] - (input[0] + input[1]) / 2}");
            sw.Flush();