using System.Text;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string input = sr.ReadLine();
                if (string.IsNullOrEmpty(input)) break;
                string[] a = input.Split(' ');
                int n = int.Parse(a[0]);
                int k = int.Parse(a[1]);
                int answer = 0;
                int temp = 0;
                while (true)
                {
                    answer += n;
                    temp += n;
                    n = temp / k;
                    temp %= k;
                    if (n == 0) break;
                }
                sb.AppendLine(answer.ToString());
            }
            sw.WriteLine(sb);
            sw.Flush();