using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
decimal n = decimal.Parse(sr.ReadLine());
            for(int i = 0; i < n; i++)
            {
                decimal[] input = Array.ConvertAll(sr.ReadLine().Split(), decimal.Parse);
                sw.WriteLine(string.Format("${0:F2}", (input[0] * input[1] * input[2])));

            }
            sw.Flush();