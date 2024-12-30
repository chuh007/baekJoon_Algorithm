using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
while (true)
            {
                string s = sr.ReadLine();
                if (s == "#") break;
                int count = 0;
                foreach(char c in s)
                {
                    if(c == 'a'|| c == 'i' || c == 'o' || c == 'u' || c == 'e' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                    {
                        count++;
                    }
                }
                sw.WriteLine(count);
            }
            sw.Flush();