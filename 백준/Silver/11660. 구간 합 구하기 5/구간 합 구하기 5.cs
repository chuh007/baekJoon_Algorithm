using System.IO;
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            int[,] map = new int[arr[0], arr[0]];
            for(int i = 0; i < arr[0]; i++)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                for(int j = 0; j < arr[0]; j++)
                {
                    map[i, j] = input[j];
                }
            }
            for(int i = 0; i < arr[0]; i++)
            {
                if (i != 0) map[i, 0] = map[i - 1, 0] + map[i, 0];
                for (int j = 1; j < arr[0]; j++)
                {
                    if (i > 0) map[i, j] += map[i - 1, j];
                    if (j > 0) map[i, j] += map[i, j - 1];
                    if (i > 0 && j > 0) map[i, j] -= map[i - 1, j - 1];
                }
            }
            for(int i = 0; i < arr[1]; i++)
            {
                int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                int startx = input[0] - 1, starty = input[1] - 1;
                int answer = map[input[2] - 1, input[3] - 1];
                if (startx > 0) answer -= map[startx - 1, input[3] - 1];
                if (starty > 0) answer -= map[input[2] - 1, starty - 1];
                if (startx > 0 && starty > 0) answer += map[startx - 1, starty - 1];
                sw.WriteLine(answer);
            }
            sw.Flush();