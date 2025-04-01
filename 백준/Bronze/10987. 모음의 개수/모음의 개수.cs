using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
string input = sr.ReadLine();
            int count = 0;
            foreach (char c in input)
            {
                if ("aeiou".Contains(c))
                {
                    count++;
                }
            }
            sw.Write(count);
            sw.Flush();