using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            for(int i = 0; i < a; i++)
            {
                string s = sr.ReadLine();
                char c = s[0];
                if (c > 96) c -= (char)32;
                sw.Write(c);
                for(int j = 1; j < s.Length; j++)
                {
                    sw.Write(s[j]);
                }
                sw.WriteLine();
            }
            sw.Flush();