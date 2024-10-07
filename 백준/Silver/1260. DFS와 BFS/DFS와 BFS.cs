using System.Collections.Generic;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int vertex = 1001;
            List<int>[] graph = new List<int>[vertex];
            for (int i = 0; i < vertex; i++)
            {
                graph[i] = new List<int>();
            }
            bool[] isvisit = new bool[vertex];
            void DFS(int now)
            {
                for (int i = 0; i < graph[now].Count; i++)
                {
                    int next = graph[now][i];
                    if (!isvisit[next])
                    {
                        isvisit[next] = true;
                        sw.Write(next+" ");
                        DFS(next);
                    }
                }
            }
            void BFS(int start)
            {
                Queue<int> q = new Queue<int>();
                q.Enqueue(start);
                isvisit[start] = true;
                while (q.Count > 0)
                {
                    int now = q.Dequeue();
                    sw.Write(now + " ");
                    for(int i = 0; i < graph[now].Count; i++)
                    {
                        int next = graph[now][i];
                        if (!isvisit[next])
                        {
                            q.Enqueue(next);
                            isvisit[next] = true;
                        }
                    }
                }
            }
            int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            for(int i = 0; i < input[1]; i++)
            {
                int[] ab = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int a = ab[0];
                int b = ab[1];
                graph[a].Add(b);
                graph[b].Add(a);
            }
            for (int i = 0; i < vertex; i++)
            {
                graph[i].Sort();
            }
            isvisit[input[2]] = true;
            sw.Write(input[2]+" ");
            DFS(input[2]);
            sw.Write('\n');
            for (int i = 0; i < vertex; i++)
            {
                isvisit[i] = false;
            }
            BFS(input[2]);
            sw.Flush();