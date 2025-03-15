            using System.IO;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int answer = 0;
            while (true)
            {
                if(a==1||a==2)
                {
                    answer = -1;
                    break;
                }
                if (a % 5 == 0)
                {
                    answer += a / 5;
                    break;
                }
                a -= 3;
                answer++;
            }
            sw.WriteLine(answer);
            sw.Flush();