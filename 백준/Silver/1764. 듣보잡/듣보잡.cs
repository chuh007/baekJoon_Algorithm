using System.Collections.Generic;
using System.Text;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
string[] NM = sr.ReadLine().Split(' ');
            int n = int.Parse(NM[0]);
            int M = int.Parse(NM[1]);
            HashSet<string> hs = new HashSet<string>();
            List<string> ls = new List<string>();
            for(int i = 0; i < n; i++)
            {
                hs.Add(sr.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                string s = sr.ReadLine();
                if (hs.Contains(s))
                {
                    ls.Add(s);
                }
            }
            ls.Sort();
            sw.WriteLine(ls.Count);
            foreach(string s in ls)
            {
                sw.WriteLine(s);
            }
            sw.Flush();