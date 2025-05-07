using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int cnt = 0;
            for(int i = 0; i < 6; i++)
            {
                string s = sr.ReadLine();
                if (s == "W") cnt++;
            }
            if (cnt == 0) sw.Write(-1);
            else if (cnt < 3) sw.Write(3);
            else if (cnt < 5) sw.Write(2);
            else sw.Write(1);
            sw.Flush();