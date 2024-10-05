using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
Dictionary<string, string> siteandpw = new Dictionary<string, string>();
            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int N = input[0];
            int M = input[1];
            string[] s;
            for (int i = 0; i < N; i++)
            {
                s = sr.ReadLine().Split();
                siteandpw.Add(s[0],s[1]);
            }
            for(int i = 0; i < M; i++)
            {
                string find = sr.ReadLine();
                sw.WriteLine(siteandpw[find]);
            }
            sw.Flush();