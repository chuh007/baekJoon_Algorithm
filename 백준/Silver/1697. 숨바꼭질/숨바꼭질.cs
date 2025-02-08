using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
            bool[] isVisited = new bool[100001];
            int[] time = new int[100001];
            for (int i = 0; i < 100001; i++)
            {
                time[i] = -1;
            }
            if (input[0] >= input[1])
            {
                sw.Write(input[0] - input[1]);
            }
            else BFS(input[0]);
            sw.Flush();
            void BFS(int now)
            {
                Queue<int> q = new Queue<int>();
                q.Enqueue(now);
                isVisited[now] = true;
                time[now] = 0;
                while (q.Count > 0)
                {
                    int current = q.Dequeue();
                    if (current == input[1])
                    {
                        sw.Write(time[current]);
                        return;
                    }
                    if (current - 1 >= 0 && !isVisited[current - 1]) 
                    {
                        isVisited[current - 1] = true;
                        time[current - 1] = time[current] + 1;
                        q.Enqueue(current - 1);
                    }
                    if (current + 1 < 100001 && !isVisited[current + 1])
                    {
                        isVisited[current + 1] = true;
                        time[current + 1] = time[current] + 1;
                        q.Enqueue(current + 1);

                    }
                    if (current * 2 < 100001 && !isVisited[current * 2])
                    {
                        isVisited[current * 2] = true;
                        time[current * 2] = time[current] + 1;
                        q.Enqueue(current * 2);
                    }
                }
            }