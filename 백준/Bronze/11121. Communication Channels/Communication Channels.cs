using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            for(int i = 0;i < a;i++)
            {
                string[] s = sr.ReadLine().Split();
                if (s[0] == s[1]) sw.Write("OK\n");
                else sw.Write("ERROR\n");
            }
            sw.Flush();