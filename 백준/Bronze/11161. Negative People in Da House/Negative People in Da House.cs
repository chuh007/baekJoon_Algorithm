using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            for (int t = 0; t < a; t++)
            {
                int b = int.Parse(sr.ReadLine());
                int now = 0;
                int nim = 0;

                for (int i = 0; i < b; i++)
                {
                    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                    now += input[0];
                    now -= input[1];
                    if (now < 0)
                    {
                        nim += -now;
                        now = 0;
                    }
                }
                sw.WriteLine(nim);
            }
            sw.Flush();