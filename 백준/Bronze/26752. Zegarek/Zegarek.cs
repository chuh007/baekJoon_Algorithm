using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            DateTime time = new DateTime(1, 1, 1, input[0], input[1], input[2]);
            time = time.AddSeconds(1);
            sw.WriteLine(time.ToString("HH:mm:ss"));
            sw.Flush();