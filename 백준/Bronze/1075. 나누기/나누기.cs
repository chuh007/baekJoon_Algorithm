using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            int b = int.Parse(sr.ReadLine());
            int ans = 0;
            a = a / 100 * 100;
            for(int i = 0; i <= 100; i++)
            {
                if (a % b == 0)
                {
                    ans = a % 100;
                    break;
                }
                a++;
            }
            if (ans < 10) sw.Write(0);
            sw.Write(ans);
            sw.Flush();