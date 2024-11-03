using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int T = int.Parse(sr.ReadLine());
            for(int i = 0; i < T; i++)
            {
                string s = sr.ReadLine();
                int nback2 = (s[2]-48) * 10 + s[3]-48;
                int nplus1 = int.Parse(s) + 1;
                if (nplus1 % nback2 == 0) sw.WriteLine("Good");
                else sw.WriteLine("Bye");
            }
            sw.Flush();