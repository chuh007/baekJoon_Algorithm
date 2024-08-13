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
            for (int q = 0; q < a; q++)
            {
                int[] inputSE = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
                int startx = inputSE[0];
                int starty = inputSE[1];
                int endx = inputSE[2];
                int endy = inputSE[3];
                int answer = 0;
                int n = int.Parse(sr.ReadLine());
                for(int i = 0; i < n; i++)
                {
                    int[] xyr = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
                    int x = xyr[0];
                    int y = xyr[1];
                    int r = xyr[2];
                    int starttoxy = (x - startx) * (x - startx) + (y - starty) * (y - starty);
                    int endtoxy = (x - endx) * (x - endx) + (y - endy) * (y - endy);
                    if (r * r > starttoxy)
                    {
                        if(r*r<endtoxy) answer++;
                    }
                    else if (r * r > endtoxy)
                    {
                        if (r * r < starttoxy) answer++;
                    }
                }
                sb.AppendLine(answer.ToString());
            }
            sw.WriteLine(sb);
            sw.Flush();