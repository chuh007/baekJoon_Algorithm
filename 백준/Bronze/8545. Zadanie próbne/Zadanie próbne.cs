using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
string s = sr.ReadLine();
            char a = s[0];
            char b = s[2];
            sw.Write($"{b}{s[1]}{a}");
            sw.Flush();