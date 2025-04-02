using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            char[,] map = new char[a, a];
            bool isRight = true;
            for (int i = 0; i < a; i++)
            {
                string s = sr.ReadLine();
                if (s.Contains("WWW") || s.Contains("BBB"))
                {
                    isRight = false;
                    break;
                }
                int wcnt = 0, bcnt = 0;
                for (int j = 0; j < a; j++)
                {
                    map[i, j] = s[j];
                    if (s[j] == 'W') wcnt++;
                    else bcnt++;
                }
                if (wcnt != bcnt)
                {
                    isRight = false;
                    break;
                }
            }
            if (isRight)
            {
                for (int i = 0; i < a; i++)
                {
                    int wcnt = 0, bcnt = 0;
                    for (int j = 0; j < a; j++)
                    {
                        if (map[j, i] == 'W') wcnt++;
                        else bcnt++;
                        if (j >= 2 &&
                            map[j, i] == map[j - 1, i] &&
                            map[j, i] == map[j - 2, i])
                        {
                            isRight = false;
                            break;
                        }
                    }
                    if (wcnt != bcnt || !isRight)
                    {
                        isRight = false;
                        break;
                    }
                }
            }
            sw.Write(isRight ? 1 : 0);
            sw.Flush();