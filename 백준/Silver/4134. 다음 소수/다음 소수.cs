using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            for(int i = 0; i < a; i++)
            {
                long n = long.Parse(sr.ReadLine());
                while (true)
                {
                    bool isSoSu = true;
                    if (n < 3)
                    {
                        sw.WriteLine(2);
                        break;
                    }
                    for (long j = 2; j < Math.Sqrt(n)+1; j++)
                    {
                        if (n % j == 0)
                        {
                            isSoSu = false;
                            break;
                        }
                    }
                    if (isSoSu)
                    {
                        sw.WriteLine(n);
                        break;
                    }
                    else n++;
                }
            }
            sw.Flush();