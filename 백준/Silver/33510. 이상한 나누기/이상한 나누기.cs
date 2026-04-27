using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
sr.ReadLine();
            string s = sr.ReadLine();
            int count = 0;
            int up = 0;
            for(int i = s.Length - 1; i > 0; i--)
            {
                int bit = s[i] - '0';
                int sum = bit + up;
                if(sum == 1)
                {
                    up = 1;
                    count++;
                }
            }
            sw.Write(count);
            sw.Flush();