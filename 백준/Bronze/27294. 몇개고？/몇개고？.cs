using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
            if ((12 <= input[0] && input[0] <= 16) && input[1] != 1) sw.Write(320);
            else sw.Write(280);
            sw.Flush();