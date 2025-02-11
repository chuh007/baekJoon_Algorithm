using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] nm = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[][] map = new int[nm[0]][];
            bool[][] isVisited = new bool[nm[0]][];
            int[][] distance = new int[nm[0]][];
            int startX = 0, startY = 0;
            for (int i = 0; i < nm[0]; i++)
            {
                map[i] = new int[nm[1]];
                isVisited[i] = new bool[nm[1]];
                distance[i] = new int[nm[1]];
                int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                for (int j = 0; j < nm[1]; j++)
                {
                    distance[i][j] = -1;
                    map[i][j] = arr[j];
                    if(arr[j] == 2)
                    {
                        startY = i;
                        startX = j;
                    }
                }
            }
            Queue<(int y,int x)> q = new Queue<(int, int)>();
            isVisited[startY][startX] = true;
            distance[startY][startX] = 0;
            q.Enqueue((startY, startX));
            int[] y = { 0, 1, 0, -1 };
            int[] x = { -1, 0, 1, 0 };
            while(q.Count > 0)
            {
                (int qy, int qx) = q.Dequeue();
                for(int i = 0; i < 4; i++)
                {
                    int ny = qy + y[i];
                    int nx = qx + x[i];
                    if (ny < 0 || ny >= nm[0] || nx < 0 || nx >= nm[1]) continue;
                    if (isVisited[ny][nx] || map[ny][nx] == 0) continue;
                    isVisited[ny][nx] = true;
                    distance[ny][nx] = distance[qy][qx] + 1;
                    q.Enqueue((ny, nx));
                }
            }
            for(int i = 0; i < nm[0]; i++)
            {
                for(int j = 0; j < nm[1]; j++)
                {
                    if (map[i][j] == 0) sw.Write("0 ");
                    else sw.Write(distance[i][j] + " ");
                }
                sw.WriteLine();
            }
            sw.Flush();