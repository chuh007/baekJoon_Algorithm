using System.Text;
            using System.IO;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
int a=1;
            int b=1;
            while (true)
            {
                string[] s = sr.ReadLine().Split(' ');
                a = int.Parse(s[0]);
                b = int.Parse(s[1]);
                if (a == 0 && b == 0) break;
                if (b % a == 0)
                {
                    sb.AppendLine("factor");
                }
                else if (a % b == 0)
                {
                    sb.AppendLine("multiple");
                }
                else
                {
                    sb.AppendLine("neither");
                }
            }
            sw.Write(sb);
            sw.Flush();