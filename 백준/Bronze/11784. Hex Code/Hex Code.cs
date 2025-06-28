using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
string s;
            while ((s = sr.ReadLine()) != null)
            {
                for (int i = 0; i < s.Length; i += 2)
                {
                    string a = s.Substring(i, 2);
                    int value = Convert.ToInt32(a, 16);
                    char c = (char)value;
                    sw.Write(c);
                }
                sw.WriteLine();
            }
            sw.Flush();