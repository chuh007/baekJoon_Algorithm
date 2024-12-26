using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
string s = sr.ReadLine();
            bool in7 = false, div7 = false;
            foreach (char c in s)
            {
                if (c == '7') in7 = true;
            }
            if (int.Parse(s) % 7 == 0) div7 = true;
            if (in7 && div7) sw.Write(3);
            else if (!in7 && !div7) sw.Write(0);
            else if (in7) sw.Write(2);
            else sw.Write(1);
            sw.Flush();