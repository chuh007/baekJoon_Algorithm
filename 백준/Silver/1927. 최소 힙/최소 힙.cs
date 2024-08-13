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
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            int inputCount = 0;

            for (int i = 0; i < a; i++)
            {
                int input = int.Parse(sr.ReadLine());
                if (input == 0)
                {
                    if (inputCount == 0) 
                    {
                        sb.AppendLine("0");
                    }
                    else
                    {
                        inputCount--;
                        int min = pq.Dequeue();
                        sb.AppendLine(min.ToString());
                    }
                }
                else
                {
                    inputCount++;
                    pq.Enqueue(input, input);
                }
            }

            sw.Write(sb);
            sw.Flush();