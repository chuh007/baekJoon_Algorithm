using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int a = input[1] - input[0];
            int b = (a + input[2] - 1) / input[2];
            sw.Write(b);
            sw.Flush();