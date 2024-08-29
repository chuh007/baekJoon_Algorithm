using System.Linq;
            using System.Threading.Tasks;
            using System.Numerics;
            using System.Collections;
            using System.Collections.Generic;
            using System.Text;
            using System.IO;
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            StringBuilder sb = new StringBuilder();
int a = int.Parse(sr.ReadLine());
            int answer = 0;
            while (true)
            {
                if(a==1||a==2||a==4||a==7)
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