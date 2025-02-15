using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            Dictionary<long, long> time = new Dictionary<long, long>();
            BFS(input[0]);
            sw.Flush();
            void BFS(int now)
            {
                Queue<long> q = new Queue<long>();
                q.Enqueue(now);
                time[now] = 0;
                bool canMake = false;
                while (q.Count > 0)
                {
                    long current = q.Dequeue();
                    if (current == input[1])
                    {
                        sw.Write(time[current] + 1);
                        canMake = true;
                        return;
                    }
                    if (current * 2 <= input[1])
                    {
                        time[current * 2] = time[current] + 1;
                        q.Enqueue(current * 2);
                    }
                    long next = current * 10 + 1;
                    if (next <= input[1])
                    {
                        time[next] = time[current] + 1;
                        q.Enqueue(next);
                    }
                }
                if (canMake == false) sw.Write(-1);
            }