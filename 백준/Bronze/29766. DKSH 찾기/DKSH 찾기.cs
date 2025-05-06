using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
string s = sr.ReadLine();
            int cnt = 0;
            for (int i = 0; i <= s.Length - 4; i++)
            {
                if (s.Substring(i, 4) == "DKSH")
                {
                    cnt++;
                }
            }
            sw.WriteLine(cnt);
            sw.Flush();