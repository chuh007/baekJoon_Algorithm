using System.IO;
using System;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            for(int i = 0; i < a; i++)
            {
                string[] sarr = sr.ReadLine().Split(' ');
                foreach(string s in sarr)
                {
                    for(int n = s.Length - 1; n >= 0; n--)
                    {
                        sw.Write(s[n]);
                    }
                    sw.Write(" ");
                }
                sw.WriteLine();
            }
            sw.Flush();