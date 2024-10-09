using System.Collections.Generic;
using System.IO;
using System.Text;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
StringBuilder sb = new StringBuilder();
int a = int.Parse(sr.ReadLine());
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) =>
            {
                int absX = Math.Abs(x);
                int absY = Math.Abs(y);
                if (absX == absY) return x.CompareTo(y);
                return absX.CompareTo(absY);
            }));
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