using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            if (input[0] - 2 >= input[2] && input[1] - 2 >= input[3]) sw.Write(1);
            else sw.Write(0);
            sw.Flush();