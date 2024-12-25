using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] NM = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            bool[] isVisited = new bool[NM[0]];
            List<int>[] graph = new List<int>[NM[0]];
            for(int i = 0; i < graph.Length; i++)
            {
                graph[i] = new List<int>();
            }
            for (int i = 0; i < NM[1]; i++)
            {
                int[] uv = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                graph[uv[0] - 1].Add(uv[1] - 1);
                graph[uv[1] - 1].Add(uv[0] - 1);
            }
            int count = 0;
            for(int i = 0; i < NM[0]; i++)
            {
                if (!isVisited[i])
                {
                    count++;
                    DFS(i);
                }
            }
            sw.Write(count);
            sw.Flush();
            void DFS(int now)
            {
                isVisited[now] = true;
                foreach(int next in graph[now])
                {
                    if (!isVisited[next]) DFS(next);
                }
            }