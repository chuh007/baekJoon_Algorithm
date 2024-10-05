using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
string[] Rickrolls = { "Never gonna give you up", "Never gonna let you down",
            "Never gonna run around and desert you","Never gonna make you cry",
            "Never gonna say goodbye","Never gonna tell a lie and hurt you","Never gonna stop"};

            int n = int.Parse(sr.ReadLine());
            string s;
            bool RickRoll = true;
            for (int i = 0; i < n; i++)
            {
                s = sr.ReadLine();
                if (!Rickrolls.Contains(s))
                {
                    RickRoll = false;
                    break;
                }
            }
            if (RickRoll) sw.Write("No");
            else sw.Write("Yes");
            sw.Flush();