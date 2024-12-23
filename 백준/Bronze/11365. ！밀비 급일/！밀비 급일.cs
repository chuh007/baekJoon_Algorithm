using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
while (true)
            {
                string s = sr.ReadLine();
                if (s == "END") break;
                for(int i = s.Length - 1; i >= 0; i--)
                {
                    sw.Write(s[i]);
                }
                sw.WriteLine();
            }
            sw.Flush();