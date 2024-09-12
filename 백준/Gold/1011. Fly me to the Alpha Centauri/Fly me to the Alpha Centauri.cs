using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            for (int q = 0; q < a; q++)
            {
                long answer;
                long[] input = Array.ConvertAll(sr.ReadLine().Split(' '), long.Parse);
                long range = input[1] - input[0];
                long lootRange = (long)Math.Sqrt(range);
                if (lootRange * lootRange == range)
                {
                    answer = lootRange * 2 - 1;
                }
                else if (range <= lootRange * lootRange + lootRange)
                {
                    answer = lootRange * 2;
                }
                else
                {
                    answer = lootRange * 2 + 1;
                }
                sw.WriteLine(answer);
            }
            sw.Flush();