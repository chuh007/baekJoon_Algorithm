using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
long[] input = Array.ConvertAll(sr.ReadLine().Split(), long.Parse);
            long r;
            while (true)
            {
                r = input[0] % input[1];
                if (r == 0)
                {
                    r = input[1];
                    break;
                }

                long temp = input[1];
                input[1] = r;
                input[0] = temp;
            }
            for (int i = 0; i < r; i++)
            {
                sw.Write(1);
            }

            sw.Flush();