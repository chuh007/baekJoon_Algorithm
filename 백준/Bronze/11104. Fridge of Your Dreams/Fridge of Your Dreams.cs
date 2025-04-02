using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int answer, cnt;
            for (int i = 0; i < a; i++)
            {
                answer = 0;
                cnt = 1;
                string s = sr.ReadLine();
                for(int j = s.Length - 1; j >= 0; j--)
                {
                    if (s[j] == '1') answer += cnt;
                    cnt *= 2;
                }
                sw.WriteLine(answer);
            }
            sw.Flush();