using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
long[] input = Array.ConvertAll(sr.ReadLine().Split(), long.Parse);
            long answer = 1;
            for (long i = input[0]; i > 0; i--)
            {
                answer = (answer * i) % input[1];
                if (answer == 0)
                {
                    break;
                }
            }
            sw.Write(answer % input[1]);
            sw.Flush();