using System.Collections.Generic;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
Dictionary<string, string> clothes = new Dictionary<string, string>();
            Dictionary<string, int> clothesnums = new Dictionary<string, int>();
            int T = int.Parse(sr.ReadLine());
            for (int t = 0; t < T; t++)
            {
                int n = int.Parse(sr.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    string[] s = sr.ReadLine().Split();
                    string value = s[0];
                    string key = s[1];
                    if (!clothes.ContainsKey(key))
                    {
                        clothes.Add(key, value);
                        clothesnums.Add(key, 1);
                    }
                    else
                    {
                        clothesnums[key]++;
                    }
                }
                int answer = 1;
                foreach(var item in clothesnums)
                {
                    answer *= item.Value+1;
                }
                sw.WriteLine(answer - 1);
                clothes.Clear();
                clothesnums.Clear();
            }
            sw.Flush();