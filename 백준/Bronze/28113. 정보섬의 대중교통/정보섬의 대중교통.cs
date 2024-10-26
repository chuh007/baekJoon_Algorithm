using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            if (input[2] > input[1]) sw.Write("Bus");
            else if (input[2] < input[1]) sw.Write("Subway");
            else sw.Write("Anything");
            sw.Flush();