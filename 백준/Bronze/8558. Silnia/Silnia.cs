using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int a = int.Parse(sr.ReadLine());
            if(a < 5)
            {
                int ans = 1;
                for(int i = 1; i <= a;i++)
                {
                    ans *= i;
                }
                sw.Write(ans%10);
            }
            else
            {
                sw.Write(0);
            }
            sw.Flush();