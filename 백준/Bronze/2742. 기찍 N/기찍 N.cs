using System.Text;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            int a = int.Parse(sr.ReadLine());
            for (int i = a; i > 0; i--)
            {
                sb.AppendLine(i.ToString());
            }
            sw.WriteLine(sb);
            sw.Flush();