using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            string s = sr.ReadLine();
            for(int i = 0; i < a; i++)
            {
                if (s[i] == 'I') sw.Write("i");
                else sw.Write("L");
            }
            sw.Flush();