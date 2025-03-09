using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            for (int i = 0; i < a; i++)
            {
                string s = sr.ReadLine();
                sw.Write(s[0]);
                for(int j = 1; j < s.Length; j++)
                {
                    if (s[j] != s[j - 1]) sw.Write(s[j]);
                }
                sw.WriteLine();
            }
            sw.Flush();