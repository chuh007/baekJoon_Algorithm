using System;
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
            for(int i = 0; i < a; i++)
            {
                int answer = 0;
                int plus = 0;
                string s = sr.ReadLine();
                foreach(char c in s)
                {
                    if (c == 'O')
                    {
                        plus++;
                        answer += plus;
                    }
                    else
                    {
                        plus = 0;
                    }
                }
                sb.AppendLine(answer.ToString());
            }
            sw.Write(sb);
            sw.Flush();