using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int c = int.Parse(sr.ReadLine());
            int n = int.Parse(sr.ReadLine());
            if (c <= input[0] && c * n <= input[0] * n + input[1]) sw.Write(1);
            else sw.Write(0);
            sw.Flush();