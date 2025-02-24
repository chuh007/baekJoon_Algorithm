using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[] arr = new int[input[1]];
            DFS(0, 1);
            sw.Flush();
            void DFS(int now, int start)
            {
                if(now == input[1])
                {
                    for(int i = 0; i < input[1]; i++)
                    {
                        sw.Write(arr[i] + " ");
                    }
                    sw.WriteLine();
                    return;
                }
                for(int i = start; i <= input[0]; i++)
                {
                    arr[now] = i;
                    DFS(now + 1, i + 1);
                }
            }