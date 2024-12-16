using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input;
            int[,] array = new int[50, 50];
            int a = int.Parse(sr.ReadLine());
            for(int i = 0; i < a; i++)
            {
                input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                for(int j = 0; j < input[2]; j++)
                {
                    int[] xy = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                    array[xy[1], xy[0]] = 1;
                }
                int answer = 0;
                for(int y = 0; y < input[1]; y++)
                {
                    for(int x = 0; x < input[0]; x++)
                    {
                        if (array[y, x] == 1)
                        {
                            answer++;
                            Dfs(x, y);
                        }
                    }
                }
                sw.WriteLine(answer);
            }
            sw.Flush();
            void Dfs(int x, int y)
            {
                array[y, x] = 0;
                if(0<=x-1&&x-1<input[0]&& 0 <= y && y < input[1])
                {
                    if (array[y, x - 1] == 1) Dfs(x - 1, y);
                }
                if (0 <= x + 1 && x + 1 < input[0] && 0 <= y && y < input[1])
                {
                    if (array[y, x + 1] == 1) Dfs(x + 1, y);
                }
                if (0 <= x && x < input[0] && 0 <= y + 1 && y + 1 < input[1])
                {
                    if (array[y + 1, x] == 1) Dfs(x, y + 1);
                }
                if (0 <= x && x < input[0] && 0 <= y - 1 && y - 1 < input[1])
                {
                    if (array[y - 1, x] == 1) Dfs(x, y - 1);
                }
            }