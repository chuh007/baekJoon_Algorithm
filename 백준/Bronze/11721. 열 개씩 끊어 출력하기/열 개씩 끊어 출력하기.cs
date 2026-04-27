using System.Text;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            string s = sr.ReadLine();
            int count = 0;
            for(int i = 0; i < s.Length; i++)
            {
                sw.Write(s[i]);
                count++;
                if (count > 9)
                {
                    count = 0;
                    sw.Write("\n");
                }
            }
            sw.Flush();