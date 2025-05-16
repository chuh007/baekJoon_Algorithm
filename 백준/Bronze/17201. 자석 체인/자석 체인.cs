using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            string s = sr.ReadLine();
            bool Yes = true;
            for(int i = 1; i < a * 2; i++)
            {
                if(s[i-1] == s[i]) Yes = false;
            }
            sw.Write(Yes ? "Yes" : "No");
            sw.Flush();