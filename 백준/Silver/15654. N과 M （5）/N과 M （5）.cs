using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] list = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            Array.Sort(list);
            int[] arr = new int[input[1]];
            bool[] isVisited = new bool[input[0]];
            DFS(0, 0);
            sw.Flush();
            void DFS(int now, int start)
            {
                if (now == input[1])
                {
                    for (int i = 0; i < input[1]; i++)
                    {
                        sw.Write(arr[i] + " ");
                    }
                    sw.WriteLine();
                    return;
                }
                for (int i = 0; i < input[0]; i++)
                {
                    if (!isVisited[i])
                    {
                        isVisited[i] = true;
                        arr[now] = list[i];
                        DFS(now + 1, i);
                        isVisited[i] = false;
                    }
                }
            }