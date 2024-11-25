using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
string s = sr.ReadLine();
            if (s[0] == s[1]) sw.Write(1);
            else sw.Write(0);
            sw.Flush();