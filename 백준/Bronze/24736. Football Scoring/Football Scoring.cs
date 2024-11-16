using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] input2 = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            sw.Write(input[0] * 6 + input[1] * 3 + input[2] * 2 + input[3] * 1 + input[4] * 2+" ");
            sw.Write(input2[0] * 6 + input2[1] * 3 + input2[2] * 2 + input2[3] * 1 + input2[4] * 2);
            sw.Flush();