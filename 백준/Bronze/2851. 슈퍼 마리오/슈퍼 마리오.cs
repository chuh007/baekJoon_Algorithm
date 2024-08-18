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
int answer = 0;
            bool can = true;
            for(int i = 0; i < 10; i++)
            {
                int a = int.Parse(sr.ReadLine());
                if (can&&(answer + a <= 100 || 100-answer>=answer+a-100))
                {
                    answer += a;
                }
                else
                {
                    can = false;
                }
            }
            sw.Write(answer);
            sw.Flush();