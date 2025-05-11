using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            string s = sr.ReadLine();
            bool[,] arr = new bool[2001, 2001];
            int x = 1000, y = 1000;
            arr[x, y] = true;
            int cnt = 1;
            for(int i = 0; i < a; i++)
            {
                switch(s[i])
                {
                    case 'N':
                        y++;
                        break;
                    case 'S':
                        y--;
                        break;
                    case 'W':
                        x++;
                        break;
                    case 'E':
                        x--;
                        break;
                }
                if(!arr[x,y])
                {
                    cnt++;
                    arr[x, y] = true;
                }
            }
            sw.Write(cnt);
            sw.Flush();