using System.Text;
            using System.IO;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
int a = int.Parse(sr.ReadLine());
            for(int i = 0; i < a; i++)
            {
                string[] s = sr.ReadLine().Split(',');
                sb.AppendLine((int.Parse(s[0])+int.Parse(s[1])).ToString());
            }
            sw.Write(sb);
            sw.Flush();