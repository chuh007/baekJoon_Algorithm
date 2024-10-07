using System.Collections.Generic;
using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int computers = 101;
            List<int>[] graph = new List<int>[computers];
            for(int i = 0; i < computers; i++)
            {
                graph[i] = new List<int>();
            }
            bool[] isvisit = new bool[computers];
            int infectedcoms = 0;
            void DFS(int now)
            {
                for(int i = 0; i < graph[now].Count; i++)
                {
                    int next = graph[now][i];
                    if (!isvisit[next])
                    {
                        isvisit[next] = true;
                        infectedcoms++;
                        DFS(next);
                    }
                }
            }
            int n = int.Parse(sr.ReadLine());
            int m = int.Parse(sr.ReadLine());
            for (int i = 0; i < m; i++)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                graph[input[0]].Add(input[1]);
                graph[input[1]].Add(input[0]);
            }
            isvisit[1] = true;
            DFS(1);
            sw.Write(infectedcoms);
            sw.Flush();