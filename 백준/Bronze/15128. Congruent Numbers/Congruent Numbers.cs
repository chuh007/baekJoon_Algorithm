using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
long[] input = Array.ConvertAll(sr.ReadLine().Split(), long.Parse);
            long num1 = input[0] * input[2];
            long num2 = input[1] * input[3] * 2;
            if (num1 % num2 == 0) sw.WriteLine(1);
            else sw.WriteLine(0);
            sw.Flush();