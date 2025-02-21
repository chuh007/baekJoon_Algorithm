using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int n = int.Parse(sr.ReadLine());
            int m = int.Parse(sr.ReadLine());
            int inf = 1000000000;
            int[,] map = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        map[i, j] = 0;
                    else
                        map[i, j] = inf;
                }
            }
            for (int i = 0; i < m; i++)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(),int.Parse);
                if (input[2] < map[input[0] - 1, input[1] - 1]) map[input[0] - 1, input[1] - 1] = input[2];
            }
            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (map[i, k] == inf || map[k, j] == inf)
                            continue;
                        if (map[i, k] + map[k, j] < map[i, j]) map[i, j] = map[i, k] + map[k, j];
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sw.Write((map[i, j] == inf ? 0 : map[i, j]) + " ");
                }
                sw.WriteLine();
            }
            sw.Flush();