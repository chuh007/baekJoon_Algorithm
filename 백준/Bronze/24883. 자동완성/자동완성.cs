using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
string s = sr.ReadLine();
            if (s[0] == 'N' || s[0] == 'n') sw.Write("Naver D2");
            else sw.Write("Naver Whale");
            sw.Flush();