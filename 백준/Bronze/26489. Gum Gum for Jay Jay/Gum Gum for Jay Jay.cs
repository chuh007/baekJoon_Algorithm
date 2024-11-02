using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
string s;
            int count = 0;
            while (true)
            {
                s = sr.ReadLine();
                if (string.IsNullOrEmpty(s)) break;
                count++;
            }sw.Write(count);
            sw.Flush();