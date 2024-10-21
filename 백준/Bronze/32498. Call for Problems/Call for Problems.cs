using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int n = int.Parse(sr.ReadLine());
            int answer = 0;
            for(int i = 0; i < n; i++)
            {
                int input = int.Parse(sr.ReadLine());
                if (input % 2 == 1) answer++;
            }
            sw.Write(answer);
            sw.Flush();