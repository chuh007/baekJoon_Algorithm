using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int n = int.Parse(sr.ReadLine());
            int answer = 0;
            for(int i = n; i > 0; i--)
            {
                answer += i;
            }
            sw.WriteLine(answer);
            sw.WriteLine(answer * answer);
            sw.WriteLine(answer * answer);

            sw.Flush();