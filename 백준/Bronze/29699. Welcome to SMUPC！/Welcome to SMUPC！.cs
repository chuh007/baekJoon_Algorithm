using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
string s = "WelcomeToSMUPC";
            int n = int.Parse(sr.ReadLine());
            sw.Write(n < 14 ? s[n - 1] : s[(n - 1) % 14]);
            sw.Flush();