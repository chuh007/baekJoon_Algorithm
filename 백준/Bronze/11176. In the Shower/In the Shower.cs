using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int t = int.Parse(sr.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
                int emptyCount = 0;
                for (int j = 0; j < input[1]; j++)
                {
                    int now = int.Parse(sr.ReadLine());
                    if (now > input[0])
                    {
                        emptyCount++;
                    }
                }
                sw.WriteLine(emptyCount);
            }
            sw.Flush();