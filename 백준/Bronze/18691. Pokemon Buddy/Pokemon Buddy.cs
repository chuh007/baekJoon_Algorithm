using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int t = int.Parse(sr.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int need = input[2] - input[1];
                if (need <= 0)
                {
                    sw.WriteLine(0);
                    continue;
                }
                int dir = 0;
                if (input[0] == 1) dir = 1;
                else if (input[0] == 2) dir = 3;
                else if (input[0] == 3) dir = 5;

                int answer = need * dir;
                sw.WriteLine(answer);
            }
            sw.Flush();